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
    public partial class WIN_CAT_Inventario_F : WIN_Template_F
    {
        MetodosGlobales Glo = new MetodosGlobales();
        ConexionSQL BD = new ConexionSQL();
        static private int gIdProducto;
        public WIN_CAT_Inventario_F(int pIdProducto = 0)
        {
            InitializeComponent();
            gIdProducto = pIdProducto;

        }
        // Método que verifica si los campos tienen información
        private bool ValidarCampos()
        {
            // Verifica que el campo Nombre tenga información
            if (EDT_Nombre.TextLength == 0 || EDT_Nombre.Text == "")
            {
                // Marca error y te regresa al campo
                Glo.Mensajes(3);
                EDT_Nombre.Focus();
                return false;
            }
            return true;
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                if (gIdProducto == 0)
                {
                    // Se abre la conexión y se estructura el query para agregar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Insert Into INVENTARIO(Descripcion, Cantidad, Fecha_Inicio, Fecha_Final,Tipo_Producto) " +
                        "Values('" + EDT_Nombre.Text + "', " + NUD_Cantidad.Text + ", '" + DT_FechaInicio.Value + "', '" + DT_FechaFinal.Value + "','"+COMBO_Opcion.SelectedIndex+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado con éxito.", "Agregar Empresas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Registro ya existente, se modifica
                {
                    // Se abre conexión y se estructura el query para modificar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Update INVENTARIO " +
                        "Set Descripcion = '" + EDT_Nombre.Text + "', Cantidad = " + NUD_Cantidad.Text + ", Fecha_Inicio = '" + DT_FechaInicio.Value + "', Fecha_Final = '" + DT_FechaFinal.Value + "', " +
                        "Tipo_Producto ='"+COMBO_Opcion.SelectedIndex+"' WHERE Id_Inventario = " + gIdProducto;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro modificado con éxito.", "Modificar Empresas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close(); // Se cierra la ventana
            }

        }

        private void WIN_CAT_Inventario_F_Load(object sender, EventArgs e)
        {

            if (BD.Conexion(true))
            {
                // Se verifica si el registro existe
                if (gIdProducto != 0)
                {
                    // Obtiene la información de la empresa
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "SELECT Descripcion, Cantidad, Tipo_Producto, Fecha_Inicio, Fecha_Final FROM INVENTARIO Where Id_Inventario = " + gIdProducto;
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();
 
                    // Verifica si tiene información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Nombre.Text = Reader[0].ToString();
                        NUD_Cantidad.Text = Reader[1].ToString();
                        COMBO_Opcion.SelectedIndex = Convert.ToInt16(Reader[2]);
                        DT_FechaInicio.Value = Convert.ToDateTime(Reader[3]);
                        DT_FechaFinal.Value = Convert.ToDateTime(Reader[4]);
                    }
                    Reader.Close();
                    if (Settings.Default.TipoUsuario != 0)
                    {
                        EDT_Nombre.Enabled = false;
                        DT_FechaInicio.Enabled = false;
                        DT_FechaFinal.Enabled = false;
                        COMBO_Opcion.Enabled = false;
                    }
                }
            }
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
