using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace DenTech
{
    public partial class WIN_Template : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        string resName = "";
        public WIN_Template()
        {
            InitializeComponent();
        }

        public string TituloVentana
        {
            get { return TB_Titulo.Text; }
            set { TB_Titulo.Text = value; }
        }

        public string TituloBanner
        {
            get { return STC_TituloBanner.Text; }
            set { STC_TituloBanner.Text = value; }
        }

        private void TB_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                resName = $"Maximize1"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                TB_Maximizar.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                //TB_Maximizar.Image = System.Drawing.Image.FromFile(@"D:\Desktop\ControlBox Visual Studio\Maximize 1.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                resName = $"Maximize2"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                TB_Maximizar.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                //TB_Maximizar.Image = System.Drawing.Image.FromFile(@"D:\Desktop\ControlBox Visual Studio\Maximize 2.png");
            }
        }

        private void TB_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TB_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void TB_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X), (this.Top + e.Y - pos.Y));
        }

        private void TB_Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
