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

namespace DenTech
{
    public partial class WIN_CAT_Pacientes_T : WIN_Template_T
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();

        public WIN_CAT_Pacientes_T()
        {
            InitializeComponent();
        }
        
        // Evento botón Agregar
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Pacientes_F Window = new WIN_CAT_Pacientes_F();
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
                if (DGV_TablaPacientes.RowCount == 0)
                    return;

                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Pacientes_F Window = new WIN_CAT_Pacientes_F((int)DGV_TablaPacientes.CurrentRow.Cells[0].Value);
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
                if (DGV_TablaPacientes.RowCount == 0)
                    return;

                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Delete From PACIENTES Where Id_Paciente = " + (int)DGV_TablaPacientes.CurrentRow.Cells[0].Value;
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

        // Evento al cargar la ventana
        private void WIN_CAT_Pacientes_T_Load(object sender, EventArgs e)
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

        // Evento botón Cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
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
                    "Id_Paciente,\n" +
                    "Matricula,\n" +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM),\n" +
                    "Edad,\n" +
                    //"Tipo =\n" + // Tipo Sangre
                    //"Case Id_Sangre\n" +
                    //"   When 1 Then 'A+'\n" +
                    //"   When 2 Then 'A-'\n" +
                    //"   When 3 Then 'B+'\n" +
                    //"   When 4 Then 'B-'\n" +
                    //"   When 5 Then 'AB+'\n" +
                    //"   When 6 Then 'AB-'\n" +
                    //"   When 7 Then 'O+'\n" +
                    //"   When 8 Then 'O-'\n" +
                    //"END,\n" +
                    "Telefono,\n" +
                    "Tel_Emergencia\n" +
                    "From PACIENTES";
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);

                // Se inserta la información en el DataGridView
                DGV_TablaPacientes.DataSource = Data;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
