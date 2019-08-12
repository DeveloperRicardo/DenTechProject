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
    public partial class WIN_CAT_Citas_T : WIN_Template
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        List<FlowLayoutPanel> Lista = new List<FlowLayoutPanel>();
        DateTime Hoy = DateTime.Today;

        public WIN_CAT_Citas_T()
        {
            InitializeComponent();
        }

        // Evento al cargar la ventana
        private void WIN_CAT_Citas_T_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Genera los cuadros del mes y agrega la información
                GenerarCuadros(42);
                AgregarNumeroDia(5, 31);
                Refrescar();
            }
        }

        // Evento del botón Agregar
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Citas_F Window = new WIN_CAT_Citas_F();
            Window.ShowDialog();
            Refrescar();
        }

        // Evento del botón Modificar
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaCitas.RowCount == 0)
                return;

            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Citas_F Window = new WIN_CAT_Citas_F((int)DGV_TablaCitas.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            Refrescar();
        }

        // Evento del botón Eliminar
        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaCitas.RowCount == 0)
                return;

            // Pregunta al usuario si desea eliminar el registro
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Se estructura el query para eliminar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Delete From CITAS Where Id_Cita = " + (int)DGV_TablaCitas.CurrentRow.Cells[0].Value;
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se confirma la eliminación del registro y se actualiza la información de la tabla
                MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
            }
        }

        // Evento del botón Cancelar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método Refrescar
        public void Refrescar()
        {
            // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            var Data = new DataTable();

            // Se estructura el query
            cmd.CommandText = "Select " +
                "Id_Cita,  " +
                "CITAS.Id_Paciente,  " +
                "NombreOdontologo = (EMPLEADOS.Nombre + ' ' + EMPLEADOS.ApellidoP + ' ' + EMPLEADOS.ApellidoM), " +
                "NombrePaciente = (PACIENTES.Nombre + ' ' + PACIENTES.ApellidoP + ' ' + PACIENTES.ApellidoM), " +
                "Fecha_Cita " +
                "From CITAS " +
                "Left Join EMPLEADOS on EMPLEADOS.Id_Empleado = CITAS.Id_Empleado " +
                "Left Join PACIENTES on PACIENTES.Id_Paciente = CITAS.Id_Paciente " +
                "Order By Fecha_Cita Desc";
            cmd.ExecuteNonQuery(); // Se ejecuta

            // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
            Adaptador.SelectCommand = cmd;
            Adaptador.Fill(Data);

            // Se inserta la información en el DataGridView
            DGV_TablaCitas.DataSource = Data;
        }

        // Evento del botón Recetas
        private void BTN_Recetas_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaCitas.RowCount == 0)
                return;

            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Recetas_T Window = new WIN_CAT_Recetas_T((int)DGV_TablaCitas.CurrentRow.Cells[1].Value);
            Window.ShowDialog();
            Refrescar();
        }

        // Método GenerarCuadros
        private void GenerarCuadros(int NumDias)
        {
            // Se limpia el control y el objeto
            LAYOUT_Cuerpo.Controls.Clear();
            Lista.Clear();

            // Clico que se repetirá por el número de días indicado
            for (int i = 1; i <= NumDias; i++)
            {
                // Se instancia objeto de tipo Layout
                FlowLayoutPanel Cuadro = new FlowLayoutPanel();

                // Se agrega información a sus propiedades
                Cuadro.Name = $"LAYOUT_Dia{i}";
                Cuadro.Size = new Size(132, 71);
                Cuadro.BackColor = Color.White;
                Cuadro.BorderStyle = BorderStyle.FixedSingle;
                LAYOUT_Cuerpo.Controls.Add(Cuadro);
                Lista.Add(Cuadro);
            }
        }

        // Método AgregarNumeroDia
        private void AgregarNumeroDia(int DiaI, int DiaF)
        {
            // Variable
            int Dia = 1;

            // Ciclo que se repetirá por la cantidad de registros en la lista
            for (int i = 1; i <= DiaF; i++)
            {
                // Se instancia objeto de tipo Label
                Label Static = new Label();

                // Se agregan las propiedades del objeto
                Static.Name = $"STC_DiaNum{i}";
                Static.AutoSize = false;
                Static.TextAlign = ContentAlignment.MiddleRight;
                Static.Size = new Size(119, 25);
                Static.Text = Dia.ToString();
                Lista[(i - 2) + DiaI].Controls.Add(Static);
                Dia++;
            }
        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}