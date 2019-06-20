using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DenTech.Properties;

namespace DenTech
{
    public partial class WIN_GLO_Principal : Form
    {
        public WIN_GLO_Principal()
        {
            InitializeComponent();
        }

        private void WIN_GLO_Principal_Load(object sender, EventArgs e)
        {
            STC_NombreUsuario.Text = Settings.Default.NombreUsuario;
        }

        private void BTN_Empleados_Click(object sender, EventArgs e)
        {
            WIN_CAT_Usuarios_T Empleados = new WIN_CAT_Usuarios_T();
            Empleados.Show();
        }

        private void BTN_Pacientes_Click(object sender, EventArgs e)
        {
            WIN_CAT_Pacientes_T Pacientes = new WIN_CAT_Pacientes_T();
            Pacientes.Show();
        }
    }
}
