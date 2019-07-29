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
    public partial class WIN_CAT_Inventario_T : WIN_Template
    {
        WIN_GLO_Principal Principal = new WIN_GLO_Principal();
        ConexionSQL BD = new ConexionSQL();
        public WIN_CAT_Inventario_T()
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            //WIN_CAT_Inventario_F window = new WIN_CAT_Inventario_F();
            //window.ShowDialog();
            var form = Application.OpenForms.OfType<WIN_CAT_Inventario_F>().FirstOrDefault();
            WIN_CAT_Inventario_F frm = form ?? new WIN_CAT_Inventario_F();
            frm.MdiParent = Principal.PNL_Ventanas.MdiForm;
            frm.ShowDialog();
            Refrescar();
        }

        // Método que refresca el data grid view
        private void Refrescar()
        {
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            string query = "SELECT Id_Inventario, Descripcion, Cantidad, Fecha_Inicio, Fecha_Final FROM INVENTARIO"; 
            switch (Settings.Default.TipoUsuario)
            {
                case 1:
                    BTN_Agregar.Visible = false;
                    BTN_Eliminar.Visible = false;
                    query += " WHERE Tipo_Producto = '0'";
                    break;
                case 3:
                    BTN_Agregar.Visible = false;
                    BTN_Eliminar.Visible = false;
                    query += " WHERE Tipo_Producto = '1'";
                    break;
            }
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = cmd;
            var Data = new DataTable();
            Adaptador.Fill(Data);
            DGV_TablaProducto.DataSource = Data;
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DGV_TablaProducto.RowCount == 0)
            {
                return;
            }
            else
            {
                WIN_CAT_Inventario_F window = new WIN_CAT_Inventario_F((int)DGV_TablaProducto.CurrentRow.Cells[0].Value);
                window.ShowDialog();
                Refrescar();
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (DGV_TablaProducto.RowCount == 0)
            {
                return;
            }
            else
            {
                // Se verifica la respuesta
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Delete From INVENTARIO Where Id_Inventario = " + (int)DGV_TablaProducto.CurrentRow.Cells[0].Value;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado con éxito.", "Dentech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                }
            }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WIN_CAT_Inventario_T_Load(object sender, EventArgs e)
        {
            // Verifica qe la conexión sea exitosa
            if (BD.Conexion(true))
                Refrescar();
            TituloVentana += "Inventario";
            TituloBanner = "Inventario";
        }
    }
}
