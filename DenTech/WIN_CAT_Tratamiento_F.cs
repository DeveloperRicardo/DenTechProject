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

namespace DenTech
{
    public partial class WIN_CAT_Tratamiento_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        int gnIdTratamiento = 0;

        public WIN_CAT_Tratamiento_F(int IdTratamiento = 0)
        {
            InitializeComponent();
            gnIdTratamiento = IdTratamiento;
        }

        private void WIN_CAT_Tratamiento_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica que tenga información de un usuario existente
                if (gnIdTratamiento != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select " +
                        "Descripcion, " +
                        "Precio " +
                        "From TRATAMIENTO " +
                        "Where Id_Tratamiento = " + gnIdTratamiento;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Descripcion.Text = Reader[0].ToString();
                        EDT_Precio.Text = Reader[1].ToString();
                    }
                    Reader.Close(); // Se libera
                }
            }
        }
        private void ValidarCampos()
        {
            // Verifica que el campo Usuario tenga información
            if (EDT_Descripcion.TextLength == 0 || EDT_Descripcion.Text == "")
            {
                // Marca error y te regresa al campo
                Glo.Mensajes(3);
                EDT_Descripcion.Focus();
                return;
            }

            // Verifica que el campo Nombre tenga información
            if (EDT_Precio.TextLength == 0 || EDT_Precio.Text == "")
            {
                // Marca error y te regresa al campo
                Glo.Mensajes(3);
                EDT_Precio.Focus();
                return;
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            SqlCommand cmd = BD.conexion.CreateCommand();
            // Verifica si el registro se creará o se modificará
            if (gnIdTratamiento == 0)
            {
                // Se estructura query para agregar el registro a la base de datos
                cmd.CommandText = "Insert Into TRATAMIENTO " +
                    "Values('" + EDT_Descripcion.Text + "', " + EDT_Precio.Text + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Registro existente, se modificará
            {
                // Se abre la conexión y se estructura el query para agregar el registro
               
                cmd.CommandText = "Update TRATAMIENTO " +
                    "Set Descripcion = '" + EDT_Descripcion.Text + "', Precio = " + EDT_Precio.Text + 
                    " Where Id_Tratamiento = " + gnIdTratamiento;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cierra la ventana
            this.Close();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
