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
            bool Regresar = true;
            try
            {
                if (EDT_Usuario.TextLength == 0 || EDT_Usuario.Text == "")
                {
                    Glo.Mensajes(3, "Usuario");
                    EDT_Usuario.Focus();
                    Regresar = false;
                }
                if (EDT_Contrasena.TextLength == 0 || EDT_Contrasena.Text == "")
                {
                    Glo.Mensajes(3, "Contraseña");
                    EDT_Contrasena.Focus();
                    Regresar = false;
                }
                if (EDT_Servidor.TextLength == 0 || EDT_Servidor.Text == "")
                {
                    Glo.Mensajes(3, "Servidor");
                    EDT_Servidor.Focus();
                    Regresar = false;
                }
                if (EDT_BaseDatos.TextLength == 0 || EDT_BaseDatos.Text == "")
                {
                    Glo.Mensajes(3, "Base de Datos");
                    EDT_Usuario.Focus();
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
        #endregion

        #region ProbarConexion
        private void BTN_ProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    conexion = @"user id=" + EDT_Usuario.Text +
                                   ";password=" + EDT_Contrasena.Text +
                                   ";server=" + EDT_Servidor.Text +
                                   ";database=" + EDT_BaseDatos.Text + ";";
                    Glo.ProbarConexion(conexion);
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
        #endregion

        #region Guardar INI
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
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
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }    
        }
        #endregion

        #region Cargar Informacion
        private void CargarInformacion()
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
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
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        #endregion
    }
}
