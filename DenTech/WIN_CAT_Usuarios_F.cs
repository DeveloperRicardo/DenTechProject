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
    public partial class WIN_CAT_Usuarios_F : Form
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        int gnIdUsuario = 0;

        // Procedimiento de la ventana
        public WIN_CAT_Usuarios_F(int pIdUsuario = 0)
        {
            InitializeComponent();
            gnIdUsuario = pIdUsuario;
        }

        // Evento cuando se carga la ventana
        private void WIN_USU_Usuarios_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica que tenga información de un usuario existente
                if (gnIdUsuario != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select " +
                        "Usuario, "+
                        "Nombre, " +
                        "ApellidoP, " +
                        "ApellidoM, " +
                        "Password, " +
                        "Tipo_Usuario " +
                        "From EMPLEADOS " +
                        "Where Id_Empleado = " + gnIdUsuario;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Usuario.Text = Reader[0].ToString();
                        EDT_Nombre.Text = Reader[1].ToString();
                        EDT_ApellidoP.Text = Reader[2].ToString();
                        EDT_ApellidoM.Text = Reader[3].ToString();
                        EDT_Password.Text = Reader[4].ToString();
                        COMBO_TipoUsuario.SelectedIndex = Int32.Parse(Reader[5].ToString());
                    }
                    Reader.Close(); // Se libera
                }
            }
        }

        // Evento del botón Aceptar
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Revisa los campos
            ValidarCampos();

            // Verifica si el registro se creará o se modificará
            if (gnIdUsuario == 0)
            {
                // Se estructura query para verificar que NO existe tal usuario
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "If Exists(Select EMPLEADOS.Usuario From EMPLEADOS Where EMPLEADOS.Usuario = '" + EDT_Usuario.Text + "') Select 'true' Else Select 'false'";

                // Verifica si se encontró el usuario
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    // Marca error y te regresa al campo
                    MessageBox.Show("El usuario ya existe.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EDT_Usuario.Focus();
                    return;
                }

                // Se estructura query para agregar el registro a la base de datos
                cmd.CommandText = "Insert Into EMPLEADOS(Usuario, Nombre, ApellidoP, ApellidoM, Password, Tipo_Usuario) " +
                    "Values('" + EDT_Usuario.Text + "', '" + EDT_Nombre.Text + "', '" + EDT_ApellidoP.Text + "', '" + EDT_ApellidoM.Text + "', '" + EDT_Password.Text + "', '" + COMBO_TipoUsuario.SelectedIndex + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Registro existente, se modificará
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update EMPLEADOS " +
                    "Set Usuario = '" + EDT_Usuario.Text + "', Nombre = '" + EDT_Nombre.Text + "', ApellidoP = '" + EDT_ApellidoP.Text + "', ApellidoM = '" + EDT_ApellidoM.Text + "', Password = '" + EDT_Password.Text + "', Tipo_Usuario = '" + COMBO_TipoUsuario.SelectedIndex + "' " +
                    "Where Id_Empleado = " + gnIdUsuario;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cierra la ventana
            this.Close(); 
        }

        // Evento del botón Cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método que verifica si los campos tienen información
        private void ValidarCampos()
        {
            // Verifica que el campo Usuario tenga información
            if (EDT_Usuario.TextLength == 0 || EDT_Usuario.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Usuario no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Usuario.Focus();
                return;
            }

            // Verifica que el campo Nombre tenga información
            if (EDT_Nombre.TextLength == 0 || EDT_Nombre.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Nombre no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Nombre.Focus();
                return;
            }

            // Verifica que el campo ApellidoP tenga información
            if (EDT_ApellidoP.TextLength == 0 || EDT_ApellidoP.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Ap. Paterno no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_ApellidoP.Focus();
                return;
            }

            // Verifica que el campo ApellidoM tenga información
            if (EDT_ApellidoM.TextLength == 0 || EDT_ApellidoM.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Ap. Materno no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_ApellidoM.Focus();
                return;
            }

            // VErifica que el campo Password tenga información
            if (EDT_Password.TextLength == 0 || EDT_Password.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Contraseña no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Password.Focus();
                return;
            }

            // Verifica que el combo TipoUsuario tenga información
            if (COMBO_TipoUsuario.SelectedIndex == -1)
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Tipo no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COMBO_TipoUsuario.Focus();
                return;
            }
        }
    }
}
