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
    public partial class WIN_CAT_Servicios_F : WIN_Template
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales MG = new MetodosGlobales();
        int gnIdServicio = 0;

        public WIN_CAT_Servicios_F(int pnIdServicio = 0)
        {
            InitializeComponent();
            gnIdServicio = pnIdServicio;
        }

        // Evento cuando se carga la ventana
        private void WIN_CAT_Servicios_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica que tenga información de un usuario existente
                if (gnIdServicio != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select \n" +
                        "Descripcion, \n" +
                        "Precio \n" +
                        "From SERVICIOS\n" +
                        "Where SERVICIOS.Id_Servicios = " + gnIdServicio;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Servicio.Text = Reader[0].ToString();
                        EDT_Precio.Text = Reader[1].ToString();
                    }
                    Reader.Close(); // Se libera
                }
            }
        }

        // Evento del botón Aceptar
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Valida que los campos tengan información
            ValidarCampos();

            // Verifica si el registro se creará o se modificará
            if (gnIdServicio == 0)
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Insert Into SERVICIOS(Descripcion, Precio) " +
                    "Values('" + EDT_Servicio.Text + "', '" + EDT_Precio.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Registro existente, se modificará
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update SERVICIOS " +
                    "Set Descripcion = '" + EDT_Servicio.Text + "', Precio = '" + EDT_Precio.Text + "' " +
                    "Where Id_Servicios = " + gnIdServicio;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Se cierra la ventana
            this.Close();
        }

        // Evento del botón Cancelar
        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método ValidarCampos
        private void ValidarCampos()
        {
            // Verifica que el campo Servicio tenga información
            if (EDT_Servicio.Text == "")
            {
                MG.Mensajes(3, "Servicio");
                EDT_Servicio.Focus();
                return;
            }

            // Verifica que el campo Precio tenga información
            if (EDT_Precio.Text == "")
            {
                MG.Mensajes(3, "Precio");
                EDT_Precio.Focus();
                return;
            }
        }
    }
}
