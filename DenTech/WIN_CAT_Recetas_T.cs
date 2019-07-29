using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DenTech.Properties;

namespace DenTech
{
    public partial class WIN_CAT_Recetas_T : Form
    {
        ConexionSQL BD = new ConexionSQL();
        public WIN_CAT_Recetas_T(int IdPaciente)
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            WIN_CAT_Recetas_F ventana = new WIN_CAT_Recetas_F();
            ventana.ShowDialog();
        }
        private void Refrescar()
        {
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            string query = "select RECETA.Diagnostico,RECETA.Medicamento,RECETA.Tratamiento,RECETA.Fecha_Inicio,RECETA.Fecha_Final,RECETA.Fecha_Diag from RECETA";
            switch (Settings.Default.TipoUsuario)
            {
                case 1:
                    BTN_Agregar.Visible = false;
                    break;
            }
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = cmd;
            var Data = new DataTable();
            Adaptador.Fill(Data);
            DGV_TablaReceta.DataSource = Data;
        }

        private void BTN_Boton_Click(object sender, EventArgs e)
        {

        }
    }
}
