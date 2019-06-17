using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DenTech.Properties;

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
            //if (Settings.Default.Testing == true)
            //{
                if (File.Exists(Environment.CurrentDirectory + @"\ConexionDenTech.ini"))
                {
                    Settings.Default.ConexionGuardada = true;
                }
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings.Default.ConexionGuardada == true)
            {
                FormsApplication.Run(new WIN_GLO_Login());
            }
            else
            {
                FormsApplication.Run(new WIN_GLO_Login_F());
            }
        }
    }
}
