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
using DenTech.Properties;

namespace DenTech
{
    public partial class WIN_GLO_Login : Form
    {
        MetodosGlobales Glo = new MetodosGlobales();
        ConexionSQL BD = new ConexionSQL();
        DataTable ds = new DataTable();
        public WIN_GLO_Login()
        {
            InitializeComponent();
        }

        private void WIN_GLO_Login_Load(object sender, EventArgs e)
        {
            Conexion();
        }
        public void Conexion()
        {
            if (!BD.Conexion(true))
            {
                EDT_Usuario.Enabled = false;
                EDT_Contrasena.Enabled = false;
                BTN_Acceder.Enabled = false;
            }
        }

        private void BTN_Acceder_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica que los campos tengan información
                if (ValidarCampos())
                {
                    bool ExisteUsuario = false;
                    // Se busca en la base de datos
                    BD.conexion.CreateCommand();
                    SqlCommand comando = BD.conexion.CreateCommand();
                    comando.CommandText = "IF EXISTS(SELECT * FROM EMPLEADOS WHERE Usuario = '" + EDT_Usuario.Text + "' AND Password = '" + EDT_Contrasena.Text + "') SELECT 'true' ELSE SELECT 'false'";
                    ExisteUsuario = Convert.ToBoolean(comando.ExecuteScalar());
                    if (ExisteUsuario)
                    {
                        comando.CommandText = "SELECT Tipo_Usuario FROM EMPLEADOS WHERE Usuario = '" + EDT_Usuario.Text + "'";
                        Settings.Default.TipoUsuario = Convert.ToInt16(comando.ExecuteScalar());
                        comando.CommandText = "SELECT Id_Empleado FROM EMPLEADOS WHERE Usuario = '" + EDT_Usuario.Text + "'";
                        Settings.Default.IDUsuario = Convert.ToInt16(comando.ExecuteScalar());
                        Settings.Default.NombreUsuario = EDT_Usuario.Text;
                        WIN_GLO_Principal Principal = new WIN_GLO_Principal();
                        Principal.Show();
                        this.Close();
                    }
                    else
                    {
                        Glo.Mensajes(8);
                    }
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Config_Click(object sender, EventArgs e)
        {
            try
            {
                WIN_GLO_Login_F LoginF = new WIN_GLO_Login_F(true);
                LoginF.ShowDialog();
                if (Settings.Default.ConexionValida == true)
                {
                    if (BD.Conexion(true))
                    {
                        Conexion();
                    }
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
        //Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            bool Regresar = true;
            try
            {
                // Verifica que los campos tengan información en ellos
                if (EDT_Usuario.TextLength == 0 || EDT_Usuario.Text == "")
                {
                    Glo.Mensajes(3, "Usuario");
                    EDT_Usuario.Focus();
                    Regresar = false;
                }
                if (EDT_Contrasena.TextLength == 0 || EDT_Contrasena.Text == "")
                {
                    Glo.Mensajes(3, "Contrasena");
                    EDT_Contrasena.Focus();
                    Regresar = false;
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
                Regresar = false;
            }
            return Regresar;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
