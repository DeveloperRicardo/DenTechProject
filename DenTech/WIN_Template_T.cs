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
    public partial class WIN_Template_T : Form
    {
        public WIN_Template_T()
        {
            InitializeComponent();
        }

        public string TituloBanner
        {
            get { return STC_TituloBanner.Text; }
            set { STC_TituloBanner.Text = value; }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
