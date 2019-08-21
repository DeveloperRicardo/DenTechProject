using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
namespace DenTech
{
    public partial class WIN_CAT_Recetas_F : WIN_Template
    {
        RecetaDataSet _recetareporte;
        MetodosGlobales Glo = new MetodosGlobales();

        public WIN_CAT_Recetas_F()
        {
            InitializeComponent();
        }
        public WIN_CAT_Recetas_F(RecetaDataSet datos): this()
        {
            _recetareporte = datos;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void WIN_CAT_Recetas_F_Load(object sender, EventArgs e)
        {
            try
            {
                Receta_Reporte _crt = new Receta_Reporte();
                _crt.SetDataSource(_recetareporte);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = _crt;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
