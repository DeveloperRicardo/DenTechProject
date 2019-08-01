﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenTech
{
    public partial class WIN_CAT_Odontograma_T : Form
    {
        public WIN_CAT_Odontograma_T(int IdPaciente = 0)
        {
            InitializeComponent();
        }

        private void WIN_CAT_Odontograma_T_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Odontograma_F Window = new WIN_CAT_Odontograma_F();
            Window.ShowDialog();
            Refrescar();
        }
        // Método que refresca el data grid view
        private void Refrescar()
        {
            //BD.conexion.CreateCommand();
            //SqlCommand cmd = BD.conexion.CreateCommand();
            //string query = "SELECT Id_Inventario, Descripcion, Cantidad, Fecha_Inicio, Fecha_Final FROM INVENTARIO";
            //switch (Settings.Default.TipoUsuario)
            //{
            //    case 1:
            //        BTN_Agregar.Visible = false;
            //        BTN_Eliminar.Visible = false;
            //        query += " WHERE Tipo_Producto = '0'";
            //        break;
            //    case 3:
            //        BTN_Agregar.Visible = false;
            //        BTN_Eliminar.Visible = false;
            //        query += " WHERE Tipo_Producto = '1'";
            //        break;
            //}
            //cmd.CommandText = query;
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter Adaptador = new SqlDataAdapter();
            //Adaptador.SelectCommand = cmd;
            //var Data = new DataTable();
            //Adaptador.Fill(Data);
            //DGV_TablaNombre.DataSource = Data;
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaNombre.RowCount == 0)
                return;

            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Odontograma_F Window = new WIN_CAT_Odontograma_F((int)DGV_TablaNombre.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            Refrescar();
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaNombre.RowCount == 0)
                return;

            // Pregunta al usuario si desea eliminar el registro
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //// Se estructura el query para eliminar el registro
                //SqlCommand cmd = BD.conexion.CreateCommand();
                //cmd.CommandText = "Delete From EXPEDIENTE Where Id_Expediente = " + (int)DGV_TablaExpediente.CurrentRow.Cells[0].Value;
                //cmd.ExecuteNonQuery(); // Se ejecuta

                //// Se confirma la eliminación del registro y se actualiza la información de la tabla
                //MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refrescar();
            }
        }
    }
}
