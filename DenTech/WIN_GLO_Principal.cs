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
    public partial class WIN_GLO_Principal : WIN_Template
    {
        int ventanas = 0;
        public WIN_GLO_Principal()
        {
            InitializeComponent();
        }
        private void Hora_Tick(object sender, EventArgs e)
        {
            STC_Dia.Text = "Fecha: "+DateTime.Now.ToShortDateString();
            STC_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void WIN_GLO_Principal_Load(object sender, EventArgs e)
        {
            TituloVentana += "Menú Principal";
            TituloBanner = Settings.Default.NombreUsuario;
            switch (Settings.Default.TipoUsuario)
            {
                case 0:
                    BTN_Empleados.Visible = true;
                    BTN_Pacientes.Visible = false;
                    BTN_Citas.Visible = false;
                    BTN_Inventario.Visible = true;
                    BTN_Servicios.Visible = true;
                    BTN_Expediente.Visible = false;
                    break;
                case 1:
                    BTN_Empleados.Visible = false;
                    BTN_Pacientes.Visible = false;
                    BTN_Citas.Visible = true;
                    BTN_Inventario.Visible = true;
                    BTN_Servicios.Visible = false;
                    BTN_Expediente.Visible = true;
                    break;
                case 2:
                    BTN_Empleados.Visible = false;
                    BTN_Pacientes.Visible = true;
                    BTN_Citas.Visible = true;
                    BTN_Inventario.Visible = true;
                    BTN_Servicios.Visible = false;
                    BTN_Expediente.Visible = true;
                    break;
                case 3:
                    BTN_Empleados.Visible = false;
                    BTN_Pacientes.Visible = false;
                    BTN_Citas.Visible = false;
                    BTN_Inventario.Visible = true;
                    BTN_Servicios.Visible = false;
                    BTN_Expediente.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void BTN_Empleados_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<WIN_CAT_Usuarios_T>().FirstOrDefault();
            WIN_CAT_Usuarios_T frm = form ?? new WIN_CAT_Usuarios_T();
            frm.MdiParent = PNL_Ventanas.MdiForm;
            frm.Show();
            frm.Focus();
            PNL_Ventanas.Refresh();
        }

        private void BTN_Pacientes_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<WIN_CAT_Pacientes_T>().FirstOrDefault();
            WIN_CAT_Pacientes_T frm = form ?? new WIN_CAT_Pacientes_T();
            frm.MdiParent = PNL_Ventanas.MdiForm;
            frm.Show();
            frm.Focus();
            PNL_Ventanas.Refresh();
        }

        private void BTN_Inventario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<WIN_CAT_Inventario_T>().FirstOrDefault();
            WIN_CAT_Inventario_T frm = form ?? new WIN_CAT_Inventario_T();
            frm.MdiParent = PNL_Ventanas.MdiForm;
            frm.Show();
            frm.Focus();
            PNL_Ventanas.Refresh();
        }

        private void BTN_Servicios_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<WIN_CAT_Servicios_T>().FirstOrDefault();
            WIN_CAT_Servicios_T frm = form ?? new WIN_CAT_Servicios_T();
            frm.MdiParent = PNL_Ventanas.MdiForm;
            frm.Show();
            frm.Focus();
            PNL_Ventanas.Refresh();
        }

        private void BTN_Expediente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<WIN_CAT_Expediente_T>().FirstOrDefault();
            WIN_CAT_Expediente_T frm = form ?? new WIN_CAT_Expediente_T();
            frm.MdiParent = PNL_Ventanas.MdiForm;
            frm.Show();
            frm.Focus();
            PNL_Ventanas.Refresh();
        }

        private void BTN_Citas_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<WIN_CAT_Citas_T>().FirstOrDefault();
            WIN_CAT_Citas_T frm = form ?? new WIN_CAT_Citas_T();
            frm.MdiParent = PNL_Ventanas.MdiForm;
            frm.Show();
            frm.Focus();
            PNL_Ventanas.Refresh();
        }

        private void PNL_Ventanas_Resize(object sender, EventArgs e)
        {
            ventanas = PNL_Ventanas.MdiForm.MdiChildren.Count();
            if (ventanas != 0)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    for (int i = 0; i < ventanas; i++)
                    {
                        PNL_Ventanas.MdiForm.MdiChildren[i].SetDesktopLocation(78, 28);
                    }
                }
                if (WindowState == FormWindowState.Normal)
                {
                    for (int i = 0; i < ventanas; i++)
                    {
                        PNL_Ventanas.MdiForm.MdiChildren[i].SetDesktopLocation(14, 8);
                    }
                }
            }
            PNL_Ventanas.Refresh();
        }
    }
}
