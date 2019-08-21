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
    public partial class WIN_CAT_Implante_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        Validacion Val = new Validacion();

        int gnIdImplante = 0;
        public WIN_CAT_Implante_F(int IdImplante = 0)
        {
            InitializeComponent();
            gnIdImplante = IdImplante;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WIN_CAT_Implante_F_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se puede conectar con la base de datos
                if (BD.Conexion(true))
                {
                    // Verifica que tenga información de un usuario existente
                    if (gnIdImplante != 0)
                    {
                        // Se estructura el query
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Select " +
                            "Descripcion, " +
                            "Precio " +
                            "From IMPLANTE " +
                            "Where Id_Implante = " + gnIdImplante;

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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }         
        }

        private bool ValidarCampos()
        {
            bool Regresar = true;
            try
            {
                // Verifica que el campo Usuario tenga información
                if (EDT_Descripcion.TextLength == 0 || EDT_Descripcion.Text == "")
                {
                    // Marca error y te regresa al campo
                    Glo.Mensajes(3, "Descripción");
                    EDT_Descripcion.Focus();
                    Regresar = false;
                }

                // Verifica que el campo Nombre tenga información
                if (EDT_Precio.TextLength == 0 || EDT_Precio.Text == "")
                {
                    // Marca error y te regresa al campo
                    Glo.Mensajes(3, "Precio");
                    EDT_Precio.Focus();
                    Regresar = false;
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
                Regresar = false;
            }
            return Regresar;
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    // Verifica si el registro se creará o se modificará
                    if (gnIdImplante == 0)
                    {
                        // Se estructura query para agregar el registro a la base de datos
                        cmd.CommandText = "Insert Into IMPLANTE " +
                            "Values('" + EDT_Descripcion.Text + "', " + EDT_Precio.Text + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Registro existente, se modificará
                    {
                        // Se abre la conexión y se estructura el query para agregar el registro

                        cmd.CommandText = "Update IMPLANTE " +
                            "Set Descripcion = '" + EDT_Descripcion.Text + "', Precio = " + EDT_Precio.Text +
                            " Where Id_Implante = " + gnIdImplante;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Cierra la ventana
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void ValidacionNumeros(object sender, KeyPressEventArgs e)
        {
            Val.soloNumeros(e);
        }
    }
}
