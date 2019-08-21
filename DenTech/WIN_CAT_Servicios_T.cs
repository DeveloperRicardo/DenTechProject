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
    public partial class WIN_CAT_Servicios_T : WIN_Template_T
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();

        public WIN_CAT_Servicios_T()
        {
            InitializeComponent();
        }

        // Evento al cargar la ventana
        private void WIN_CAT_Servicios_T_Load(object sender, EventArgs e)
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

        // Evento del botón Agregar
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Servicios_F Window = new WIN_CAT_Servicios_F();
                Window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Modificar
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaServicios.RowCount == 0)
                    return;

                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Servicios_F Window = new WIN_CAT_Servicios_F((int)DGV_TablaServicios.CurrentRow.Cells[0].Value);
                Window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Eliminar
        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaServicios.RowCount == 0)
                    return;

                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Delete From SERVICIOS Where Id_Servicios = " + (int)DGV_TablaServicios.CurrentRow.Cells[0].Value;
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

        // Evento del botón Cancelar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
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
                    "Id_Servicios,\n" +
                    "Descripcion,\n" +
                    "Precio\n" +
                    "From SERVICIOS\n" +
                    "Order By Descripcion Asc";
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);

                // Se inserta la información en el DataGridView
                DGV_TablaServicios.DataSource = Data;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
