using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenTech
{
    public partial class WIN_CAT_Expediente_F : Form
    {
        // Variables globales
        int gnIdExpediente = 0;

        public WIN_CAT_Expediente_F(int pIdExpediente = 0)
        {
            InitializeComponent();
            gnIdExpediente = pIdExpediente;
        }

        private void WIN_CAT_Expediente_F_Load(object sender, EventArgs e)
        {

        }

        private void STC_NombreCompleto_Click(object sender, EventArgs e)
        {

        }

        // Evento del botón Cerrar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }
    }
}
