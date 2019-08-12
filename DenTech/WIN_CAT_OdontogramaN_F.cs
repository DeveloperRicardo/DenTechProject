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
    public partial class WIN_CAT_OdontogramaN_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        int gnIdPaciente = 0;
        public WIN_CAT_OdontogramaN_F(int IdPaciente = 0)
        {
            InitializeComponent();
            gnIdPaciente = IdPaciente;
        }

        // Método que verifica si los campos tienen información
        private bool ValidarCampos()
        {
            // Verifica que el campo Nombre tenga información
            if (EDT_Descripcion.TextLength == 0 || EDT_Descripcion.Text == "")
            {
                // Marca error y te regresa al campo
                Glo.Mensajes(3);
                EDT_Descripcion.Focus();
                return false;
            }
            return true;
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                if (BD.Conexion(true))
                {
                    // Se abre la conexión y se estructura el query para agregar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "INSERT INTO ODONTOGRAMA VALUES(" + gnIdPaciente + ",'" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "','" + EDT_Descripcion.Text + "');";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado con éxito.", "Dentech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Se cierra la ventana
                }
            }

        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
