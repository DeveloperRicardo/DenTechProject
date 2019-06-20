using DenTech.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace DenTech
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MetodosGlobales Glo = new MetodosGlobales();
            string path = Environment.CurrentDirectory + @"\ConexionDenTech.ini";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Si existe el archivo de configuracion
            if (File.Exists(Environment.CurrentDirectory + @"\ConexionDenTech.ini"))
            {
                //Se da true la variable global indicando que si esta el archivo
                Settings.Default.ConexionGuardada = true;
                //Si se logra hacer la conexión con los parametros del archivo
                if (Glo.ProbarConexion(File.ReadAllText(path)))
                {
                    //Se da true a la variable global indicando que si hay conexión
                    Settings.Default.ConexionValida = true;
                    //Verifica si existen en la BD las tablas necesarias
                    Glo.VerificarTablas(File.ReadAllText(path));
                    //Se abre la ventana de login
                    FormsApplication.Run(new WIN_GLO_Login());
                }
                //Si no se logra hacer la conexión con los parametros del archivo
                else
                {
                    //Se da false a la variable global indicando que no hay conexión
                    Settings.Default.ConexionValida = false;
                    //Se abre la ventana de configuración de conexión
                    FormsApplication.Run(new WIN_GLO_Login_F());
                }
            }
            else
            {
                //Se da false la variable global indicando que no esta el archivo
                Settings.Default.ConexionGuardada = false;
                //Se da false a la variable global indicando que no hay conexión
                Settings.Default.ConexionValida = false;
                //Se abre la ventana de configuración de conexión
                FormsApplication.Run(new WIN_GLO_Login_F());
            }
        }
    }
}
