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
    public partial class WIN_CAT_Inventario_T : WIN_Template_T
    {
        MetodosGlobales Glo = new MetodosGlobales();
        ConexionSQL BD = new ConexionSQL();

        public WIN_CAT_Inventario_T()
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                WIN_CAT_Inventario_F window = new WIN_CAT_Inventario_F();
                window.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Método que refresca el data grid view
        private void Refrescar()
        {
            try
            {
                BD.conexion.CreateCommand();
                SqlCommand cmd = BD.conexion.CreateCommand();
                string query = "SELECT Id_Inventario, Descripcion, Cantidad, Fecha_Inicio, Fecha_Final FROM INVENTARIO";
                switch (Settings.Default.TipoUsuario)
                {
                    case 1:
                        query += " WHERE Tipo_Producto = '0'";
                        break;
                    case 3:
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
                if (Settings.Default.TipoUsuario != 0 && Settings.Default.TipoUsuario != 4)
                {
                    BTN_Agregar.Visible = false;
                    BTN_Modificar.Visible = false;
                    BTN_Eliminar.Visible = false;
                    DGV_TablaProducto.Columns[3].Visible = false;
                    DGV_TablaProducto.Columns[4].Visible = false;
                }
                if (DGV_TablaProducto.RowCount != 0)
                {
                    if ((int)DGV_TablaProducto.CurrentRow.Cells[2].Value == 0)
                    {
                        BTN_Disminuir.Enabled = false;
                    }
                    else
                    {
                        if (Settings.Default.TipoUsuario == 0 || Settings.Default.TipoUsuario == 3 || Settings.Default.TipoUsuario == 4)
                        {
                            BTN_Disminuir.Enabled = true;
                        }
                    }
                }         
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WIN_CAT_Inventario_T_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica qe la conexión sea exitosa
                if (BD.Conexion(true))
                    Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Aumentar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_TablaProducto.RowCount == 0)
                {
                    return;
                }
                // Se abre conexión y se estructura el query para modificar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update INVENTARIO " +
                    "Set Cantidad = Cantidad + 1 WHERE Id_Inventario = " + (int)DGV_TablaProducto.CurrentRow.Cells[0].Value;
                cmd.ExecuteNonQuery();
                BTN_Disminuir.Enabled = true;
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Disminuir_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_TablaProducto.RowCount == 0)
                {
                    return;
                }
                // Se abre conexión y se estructura el query para modificar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update INVENTARIO " +
                    "Set Cantidad = Cantidad - 1 WHERE Id_Inventario = " + (int)DGV_TablaProducto.CurrentRow.Cells[0].Value;
                cmd.ExecuteNonQuery();
                Refrescar();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void DGV_TablaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)DGV_TablaProducto.CurrentRow.Cells[2].Value == 0)
            {
                BTN_Disminuir.Enabled = false;
            }
            else
            {
                if (Settings.Default.TipoUsuario == 0 || Settings.Default.TipoUsuario == 3 || Settings.Default.TipoUsuario == 4)
                {
                    BTN_Disminuir.Enabled = true;
                }
            }
        }
    }
}
