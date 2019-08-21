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
    public partial class WIN_CAT_Extraccion_T : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        int IdDiente = 0;
        public int Estatus = 0;

        public WIN_CAT_Extraccion_T(int gnIdDiente = 0)
        {
            InitializeComponent();
            IdDiente = gnIdDiente;
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
                    "Id_Extraccion,\n" +
                    "Descripcion,\n" +
                    "Precio \n" +
                    "From EXTRACCION";
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);
                // Se inserta la información en el DataGridView
                DGV_TablaExtraccion.DataSource = Data;
                // Verifica que la tabla tenga información
                if (DGV_TablaExtraccion.RowCount == 0)
                {
                    BTN_Seleccionar.Enabled = false;
                }
                else
                {
                    BTN_Seleccionar.Enabled = true;
                }
                RADIO_Realizado.Checked = true;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Extraccion_F Window = new WIN_CAT_Extraccion_F();
                Window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void WIN_CAT_Extraccion_T_Load(object sender, EventArgs e)
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

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaExtraccion.RowCount == 0)
                    return;

                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Extraccion_F Window = new WIN_CAT_Extraccion_F((int)DGV_TablaExtraccion.CurrentRow.Cells[0].Value);
                Window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaExtraccion.RowCount == 0)
                    return;

                bool ExisteSeleccion = false;
                //Verifica si el tratamiento esta seleccionado en otro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "IF EXISTS(SELECT * FROM EXTRACCIONDIENTE WHERE Id_Extraccion = " + (int)DGV_TablaExtraccion.CurrentRow.Cells[0].Value +
                                  ") SELECT 'true' ELSE SELECT 'false'";
                ExisteSeleccion = Convert.ToBoolean(cmd.ExecuteScalar());
                if (ExisteSeleccion == true)
                {
                    MessageBox.Show("No se puede eliminar el registro debido a que esta en uso.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Pregunta al usuario si desea eliminar el registro
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Se estructura el query para eliminar el registro
                        cmd.CommandText = "Delete From EXTRACCION Where Id_Extraccion = " + (int)DGV_TablaExtraccion.CurrentRow.Cells[0].Value;
                        cmd.ExecuteNonQuery(); // Se ejecuta

                        // Se confirma la eliminación del registro y se actualiza la información de la tabla
                        MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refrescar();
                    }
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = BD.conexion.CreateCommand();
                bool ExisteRegistro = false;
                cmd.CommandText = "IF EXISTS(SELECT * FROM EXTRACCIONDIENTE WHERE Id_Diente = " + IdDiente +
                                  ") SELECT 'true' ELSE SELECT 'false'";
                ExisteRegistro = Convert.ToBoolean(cmd.ExecuteScalar());
                if (ExisteRegistro == true)
                {
                    cmd.CommandText = "UPDATE EXTRACCIONDIENTE SET Id_Extraccion = " + (int)DGV_TablaExtraccion.CurrentRow.Cells[0].Value +
                        " WHERE Id_Diente = " + IdDiente;

                }
                else
                {
                    cmd.CommandText = "INSERT INTO EXTRACCIONDIENTE VALUES(" + IdDiente + ", " + (int)DGV_TablaExtraccion.CurrentRow.Cells[0].Value + ")";
                }
                cmd.ExecuteNonQuery();
                if (RADIO_Realizado.Checked)
                {
                    Estatus = 2;
                }
                if (RADIO_Pendiente.Checked)
                {
                    Estatus = 1;
                }
                //if (RADIO_Ninguno.Checked)
                //{
                //    Estatus = 0;
                //}
                this.Close();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
