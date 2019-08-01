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
    public partial class WIN_CAT_Diente_F : WIN_Template
    {
        public WIN_CAT_Diente_F()
        {
            InitializeComponent();
        }

        private void WIN_CAT_Diente_F_Load(object sender, EventArgs e)
        {
            TituloVentana += "Odontograma";
            TituloBanner = "Odontograma";
        }
    }
}
