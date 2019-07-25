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
//            if (BD.Conexion(true))
//            {
                ds.Clear();
                BD.conexion.CreateCommand();
                SqlCommand comando = BD.conexion.CreateCommand();
                comando.CommandText = "SELECT Id_Empleado, Usuario FROM EMPLEADOS";
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(ds);
                DGV_Login.DataSource = ds;
                COMBO_Usuario.DataSource = ds;
                COMBO_Usuario.ValueMember = "Id_Empleado";
                COMBO_Usuario.DisplayMember = "Usuario";
                //COMBO_Usuario.Refresh();
                //DGV_Login.Refresh();
//            }
//            else
//            {
//                COMBO_Usuario.Enabled = false;
//                EDT_Contrasena.Enabled = false;
//                BTN_Acceder.Enabled = false;
                //IMG_Icono.Visible = true;
                //STC_MensajeConexion.Visible = true;
//            }
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
                    comando.CommandText = "SELECT Tipo_Usuario FROM EMPLEADOS WHERE Id_Empleado = '" + COMBO_Usuario.SelectedValue + "'";
                    Settings.Default.TipoUsuario = Convert.ToInt16(comando.ExecuteScalar());
                    Settings.Default.NombreUsuario = COMBO_Usuario.Text;
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
            WIN_GLO_Login_F LoginF = new WIN_GLO_Login_F(true);
            LoginF.ShowDialog();
            if (Settings.Default.ConexionValida == true)
            {
                //ds.Clear();
                //COMBO_Usuario.DataSource = null;
                //COMBO_Usuario.ValueMember = null;
                //COMBO_Usuario.DisplayMember = null;
                //COMBO_Usuario.Refresh();
                ////                BD.Conexion(false);
                if (BD.Conexion(true))
                {
                    Conexion();
                }
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
