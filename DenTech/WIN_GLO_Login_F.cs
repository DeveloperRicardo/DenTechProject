using DenTech.Properties;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DenTech
{
    public partial class WIN_GLO_Login_F : WIN_Template_F
    {
        bool Modificar = false;
        string conexion = "";
        string path = Environment.CurrentDirectory + @"\ConexionDenTech.ini";
        MetodosGlobales Glo = new MetodosGlobales();
        public WIN_GLO_Login_F(bool Mod = false)
        {
            Modificar = Mod;
            InitializeComponent();
            CargarInformacion();
        }

        #region Validar Campos
        private bool ValidarCampos()
        {
            if (EDT_Usuario.Text == "" || EDT_Contrasena.Text == "" || EDT_Servidor.Text == "" || EDT_BaseDatos.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region ProbarConexion
        private void BTN_ProbarConexion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                Glo.Mensajes(3);
                return;
            }
            conexion = @"user id=" + EDT_Usuario.Text +
                           ";password=" + EDT_Contrasena.Text +
                           ";server=" + EDT_Servidor.Text +
                           ";database=" + EDT_BaseDatos.Text + ";";
            Glo.ProbarConexion(conexion);
        }
        #endregion

        #region Guardar INI
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                Glo.Mensajes(3);
                return;
            }
            conexion = @"user id=" + EDT_Usuario.Text +
                       ";password=" + EDT_Contrasena.Text +
                       ";server=" + EDT_Servidor.Text +
                       ";database=" + EDT_BaseDatos.Text + ";";
            if (File.Exists(path))
            {
                File.WriteAllText(path, conexion);
            }
            else
            {
                FileStream archivo = File.Create(path);
                Byte[] info = new UTF8Encoding(true).GetBytes(conexion);
                archivo.Write(info, 0, info.Length);
                archivo.Close();
            }
            Glo.Mensajes(6);
            Settings.Default.ConexionGuardada = true;
            //Se prueba la conexion con los parametros de archivo
            if (Glo.ProbarConexion(File.ReadAllText(path)))
            {
                Settings.Default.ConexionValida = true;
                Glo.VerificarTablas(File.ReadAllText(path));
            }          
        }
        #endregion

        #region Cargar Informacion
        private void CargarInformacion()
        {
            if (File.Exists(path))
            {
                string datos = File.ReadAllText(path);
                string[] parametros = datos.Split(Convert.ToChar(";"));
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            parametros[i] = parametros[i].Remove(0, 8);
                            break;
                        case 1:
                            parametros[i] = parametros[i].Remove(0, 9);
                            break;
                        case 2:
                            parametros[i] = parametros[i].Remove(0, 7);
                            break;
                        case 3:
                            parametros[i] = parametros[i].Remove(0, 9);
                            break;
                    }
                }
                EDT_Usuario.Text = parametros[0];
                EDT_Contrasena.Text = parametros[1];
                EDT_Servidor.Text = parametros[2];
                EDT_BaseDatos.Text = parametros[3];

            }
        }
        #endregion

        #region Cerrar Ventana

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            ValidarLogin();
            this.Close();
        }
        private void CerrarVentana(object sender, FormClosingEventArgs e)
        {
            ValidarLogin();
        }
        private void ValidarLogin()
        {
            if (Modificar == false)
            {
                if (Settings.Default.ConexionGuardada == true && Settings.Default.ConexionValida == true)
                {
                    WIN_GLO_Login Login = new WIN_GLO_Login();
                    if (Modificar == false)
                        Login.Show();
                }
            }
        }

        #endregion
    }
}
