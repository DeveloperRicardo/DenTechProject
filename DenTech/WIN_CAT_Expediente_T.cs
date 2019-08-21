using System;
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
    public partial class WIN_CAT_Expediente_T : WIN_Template_T
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();

        public WIN_CAT_Expediente_T()
        {
            InitializeComponent();
        }

        // Evento del botón Agregar
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Expediente_F Window = new WIN_CAT_Expediente_F();
            Window.ShowDialog();
            Refrescar();
        }

        // Evento del botón Modificar
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaExpediente.RowCount == 0)
                return;

            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Expediente_F Window = new WIN_CAT_Expediente_F((int)DGV_TablaExpediente.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            Refrescar();
        }

        // Evento del botón Eliminar
        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaExpediente.RowCount == 0)
                return;

            // Pregunta al usuario si desea eliminar el registro
            if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Se estructura el query para eliminar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Delete From EXPEDIENTE Where Id_Expediente = " + (int)DGV_TablaExpediente.CurrentRow.Cells[0].Value;
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se confirma la eliminación del registro y se actualiza la información de la tabla
                MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
            }
        }

        // Evento del botón Cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
        }

        // Evento cuando se carga la ventana
        private void WIN_CAT_Expediente_T_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
                Refrescar();
        }

        // Método Refrescar
        private void Refrescar()
        {
            // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            var Data = new DataTable();

            // Se estructura el query
            cmd.CommandText = "Select\n" +
                "EXPEDIENTE.Id_Expediente,\n" +
                "Odontologo = (EMPLEADOS.Nombre + ' ' + EMPLEADOS.ApellidoP + ' ' + EMPLEADOS.ApellidoM),\n" +
                "Paciente = (PACIENTES.Nombre + ' ' + PACIENTES.ApellidoP + ' ' + PACIENTES.ApellidoM),\n" +
                "EXPEDIENTE.Enfermedad,\n" +
                "EXPEDIENTE.Alergia,\n" +
                "EXPEDIENTE.Fecha,\n" +
                "EXPEDIENTE.Id_Paciente\n" +
                "From EXPEDIENTE\n" +
                "Left Join EMPLEADOS on EMPLEADOS.Id_Empleado = EXPEDIENTE.Id_Empleado\n" +
                "Left Join PACIENTES on PACIENTES.Id_Paciente = EXPEDIENTE.Id_Paciente\n" +
                "Order By Expediente.Fecha Desc";
            cmd.ExecuteNonQuery(); // Se ejecuta

            // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
            Adaptador.SelectCommand = cmd;
            Adaptador.Fill(Data);

            // Se inserta la información en el DataGridView
            DGV_TablaExpediente.DataSource = Data;
        }

        //private void BTN_General_Click(object sender, EventArgs e)
        //{
        //    // Verifica que la tabla tenga información
        //    if (DGV_TablaExpediente.RowCount == 0)
        //        return;

        //    Menu_General.Show(BTN_General, new Point(0, BTN_General.Height));
        //}

        //private void OP_Recetas_Click(object sender, EventArgs e)
        //{
        //    // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
        //    WIN_CAT_Recetas_T Window = new WIN_CAT_Recetas_T((int)DGV_TablaExpediente.CurrentRow.Cells[6].Value);
        //    Window.ShowDialog();
        //    Refrescar();
        //}

        private void BTN_Dental_Click(object sender, EventArgs e)
        {
            //Menu_Dental.Show(BTN_Dental, new Point(0, BTN_Dental.Height));
            OP_Odontograma_Click(sender, e);
        }

        private void OP_Odontograma_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaExpediente.RowCount == 0)
                return;

            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Odontograma_T Window = new WIN_CAT_Odontograma_T((int)DGV_TablaExpediente.CurrentRow.Cells[6].Value);
            Window.ShowDialog();
            Refrescar();
        }

        private void OP_ArcAdjuntos_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaExpediente.RowCount == 0)
                return;

            //// Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
            //WIN_CAT_ArchivosAdjuntos_T Window = new WIN_CAT_ArchivosAdjuntos_T((int)DGV_TablaExpediente.CurrentRow.Cells[6].Value);
            //Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_General_Click(object sender, EventArgs e)
        {
            Menu_General.Show(BTN_General, new Point(0, BTN_General.Height));
        }
    }
}
