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
            if (BD.Conexion(true))
            {
                BD.conexion.CreateCommand();
                SqlCommand comando = BD.conexion.CreateCommand();
                comando.CommandText = "SELECT Id_Empleado, Usuario FROM EMPLEADOS";
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                var ds = new DataTable();
                adaptador.Fill(ds);
                COMBO_Usuario.DataSource = ds;
                COMBO_Usuario.ValueMember = "Id_Empleado";
                COMBO_Usuario.DisplayMember = "Usuario";
            }
            else
            {
                COMBO_Usuario.Enabled = false;
                EDT_Contrasena.Enabled = false;
                BTN_Acceder.Enabled = false;
                //IMG_Icono.Visible = true;
                //STC_MensajeConexion.Visible = true;
            }
        }

        private void BTN_Acceder_Click(object sender, EventArgs e)
        {
            //Verifica que los campos tengan información
            if (ValidarCampos())
            {
                bool ExisteUsuario = false;
                // Se busca en la base de datos
                BD.conexion.CreateCommand();
                SqlCommand comando = BD.conexion.CreateCommand();
                comando.CommandText = "IF EXISTS(SELECT * FROM EMPLEADOS WHERE Id_Empleado = '" + COMBO_Usuario.SelectedValue + "' AND Password = '" + EDT_Contrasena.Text + "') SELECT 'true' ELSE SELECT 'false'";
                ExisteUsuario = Convert.ToBoolean(comando.ExecuteScalar());
                if (ExisteUsuario)
                {
                    WIN_GLO_Principal Principal = new WIN_GLO_Principal();
                    Principal.Show();
                    this.Close();
                }
                else
                    Glo.Mensajes(8);
            }
            else
            {
                // Muestra un mensaje donde indica que hay un error
                Glo.Mensajes(3);
            }
        }

        private void BTN_Config_Click(object sender, EventArgs e)
        {
            WIN_GLO_Login_F LoginF = new WIN_GLO_Login_F();
            LoginF.Show();
            if (Settings.Default.ConexionValida == true)
            {
                this.Refresh();
            }
        }
        //Método que verifica que los campos tengan información
        private bool ValidarCampos()
        {
            // Verifica que los campos tengan información en ellos
            if (COMBO_Usuario.Text == null || EDT_Contrasena.Text == "")
                return false;
            else
                return true;
        }
    }
}
