﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DenTech.Properties;

namespace DenTech
{
    public partial class WIN_CAT_Usuarios_T : WIN_Template_T
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        public WIN_CAT_Usuarios_T()
        {
            InitializeComponent();
        }

        // Evento botón Agregar
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Usuarios_F Window = new WIN_CAT_Usuarios_F();
                Window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento botón Modificar
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaUsuarios.RowCount == 0)
                    return;

                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Usuarios_F Window = new WIN_CAT_Usuarios_F((int)DGV_TablaUsuarios.CurrentRow.Cells[0].Value);
                Window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento botón Eliminar
        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaUsuarios.RowCount == 0)
                    return;

                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Delete From EMPLEADOS Where Id_Empleado = " + (int)DGV_TablaUsuarios.CurrentRow.Cells[0].Value;
                    cmd.ExecuteNonQuery(); // Se ejecuta

                    // Se confirma la eliminación del registro y se actualiza la información de la tabla
                    MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento botón Cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Evento cuando se carga la ventana
        private void WIN_CAT_Usuarios_T_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se puede conectar con la base de datos
                if (BD.Conexion(true))
                    Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Método Refrescar
        private void Refrescar()
        {
            try
            {
                // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
                BD.conexion.CreateCommand();
                SqlCommand cmd = BD.conexion.CreateCommand();
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                var Data = new DataTable();

                // Se estructura el query
                cmd.CommandText = "Select\n" +
                    "Id_Empleado,\n" +
                    "Usuario,\n" +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM),\n" +
                    "Tipo =\n" +
                    "Case Tipo_Usuario\n" +
                    "   When 0 Then 'Administrador'\n" +
                    "   When 1 Then 'Odontólogo'\n" +
                    "   When 2 Then 'Recepcionista'\n" +
                    "   When 3 Then 'Intendente'\n" +
                    "   When 4 Then 'Super-usuario'\n" +
                    "End\n" +
                    "From EMPLEADOS";
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);

                // Se inserta la información en el DataGridView
                DGV_TablaUsuarios.DataSource = Data;
                try
                {
                    if (Convert.ToString(DGV_TablaUsuarios.CurrentRow.Cells[3].Value) == "Super-usuario" ||
                        (int)DGV_TablaUsuarios.CurrentRow.Cells[0].Value == Settings.Default.IDUsuario)
                    {
                        BTN_Modificar.Enabled = false;
                        BTN_Eliminar.Enabled = false;
                    }
                    else
                    {
                        BTN_Modificar.Enabled = true;
                        BTN_Eliminar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    Glo.Mensajes(10, ex.Message);
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }

        }

        private void DGV_TablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToString(DGV_TablaUsuarios.CurrentRow.Cells[3].Value) == "Super-usuario" ||
                    (int)DGV_TablaUsuarios.CurrentRow.Cells[0].Value == Settings.Default.IDUsuario)
                {
                    BTN_Modificar.Enabled = false;
                    BTN_Eliminar.Enabled = false;
                }
                else
                {
                    BTN_Modificar.Enabled = true;
                    BTN_Eliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
