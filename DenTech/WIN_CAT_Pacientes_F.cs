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
    public partial class WIN_CAT_Pacientes_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        int gnIdPaciente = 0;

        // Procedimiento de la ventana
        public WIN_CAT_Pacientes_F(int pIdPaciente = 0)
        {
            InitializeComponent();
            gnIdPaciente = pIdPaciente;
        }

        // Evento cuando se carga la ventana
        private void WIN_CAT_Pacientes_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                #region Se llena el combo Tipo Sangre
                // Se instancia un objeto que adaptará la información del query, además se declaran variables
                SqlDataAdapter adaptador = new SqlDataAdapter();
                var ds = new DataTable();

                // Se estructura query para llenar el combo de Tipo Sangre
                BD.conexion.CreateCommand();
                SqlCommand comando = BD.conexion.CreateCommand();
                comando.CommandText = "SELECT Id_Sangre, Descripcion FROM SANGRE";
                comando.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                adaptador.SelectCommand = comando;
                adaptador.Fill(ds);

                // Se asignan los valores en el COMBO
                COMBO_TipoSangre.DataSource = ds;
                COMBO_TipoSangre.ValueMember = "Id_Sangre";
                COMBO_TipoSangre.DisplayMember = "Descripcion";
                #endregion

                // Verifica que tenga información de un usuario existente
                if (gnIdPaciente != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select \n" +
                        "Nombre, \n" +
                        "ApellidoP, \n" +
                        "ApellidoM, \n" +
                        "Edad, \n" +
                        "Sexo, \n" +
                        "Id_Sangre, \n" +
                        "Telefono, \n" +
                        "Tel_Emergencia, \n" +
                        "Direccion \n" +
                        "From PACIENTES " +
                        "Where PACIENTES.Id_Paciente = " + gnIdPaciente;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Nombre.Text = Reader[0].ToString();
                        EDT_ApellidoP.Text = Reader[1].ToString();
                        EDT_ApellidoM.Text = Reader[2].ToString();
                        EDT_Edad.Text = Reader[3].ToString();
                        EDT_Telefono.Text = Reader[6].ToString();
                        EDT_TelefonoEm.Text = Reader[7].ToString();
                        EDT_Direccion.Text = Reader[8].ToString();
                        COMBO_Sexo.SelectedIndex = Int32.Parse(Reader[4].ToString());
                        COMBO_TipoSangre.SelectedValue = Int32.Parse(Reader[5].ToString());
                    }
                    Reader.Close(); // Se libera
                }
            }
        }

        // Evento botón Aceptar
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Valida que los campos tengan información
            ValidarCampos();

            // Verifica si el registro se creará o se modificará
            if (gnIdPaciente == 0)
            {
                string NuevoCodigo = "";
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "SELECT MAX(Matricula) FROM PACIENTES";
                NuevoCodigo = Glo.CodigoRegistro(Convert.ToInt16(cmd.ExecuteScalar()));
                cmd.CommandText = "Insert Into PACIENTES(Matricula, Nombre, ApellidoP, ApellidoM, Edad, Sexo, Id_Sangre, Telefono, Tel_Emergencia, Direccion) " +
                    "Values('" + NuevoCodigo + "', '" + EDT_Nombre.Text + "', '" + EDT_ApellidoP.Text + "', '" + EDT_ApellidoM.Text + "', '" + EDT_Edad.Text + "', '" + COMBO_Sexo.SelectedIndex + "', '" + COMBO_TipoSangre.SelectedValue + "', '" + EDT_Telefono.Text + "', '" + EDT_TelefonoEm.Text + "', '" + EDT_Direccion.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Registro existente, se modificará
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update PACIENTES " +
                    "Set Nombre = '" + EDT_Nombre.Text + "', ApellidoP = '" + EDT_ApellidoP.Text + "', ApellidoM = '" + EDT_ApellidoM.Text + "', Edad = '" + EDT_Edad.Text + "', Sexo = '" + COMBO_Sexo.SelectedIndex + "', Id_Sangre = '" + COMBO_TipoSangre.SelectedValue + "', Telefono = '" + EDT_Telefono.Text + "', Tel_Emergencia = '" + EDT_TelefonoEm.Text + "', Direccion = '" + EDT_Direccion.Text + "' " +
                    "Where Id_Paciente = " + gnIdPaciente;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Se cierra la ventana
            this.Close();
        }

        // Evento botón Cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
        }

        // Método ValidarCampos
        private void ValidarCampos()
        {
            // Verifica que el campo Usuario tenga información
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

            // Verifica que el campo Edad tenga información
            if (EDT_Edad.TextLength == 0 || EDT_Edad.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Edad no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Edad.Focus();
                return;
            }

            // Verifica que el campo Teléfono tenga información
            if (EDT_Telefono.TextLength == 0 || EDT_Telefono.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Teléfono no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Telefono.Focus();
                return;
            }

            // Verifica que el campo TeléfonoEm tenga información
            if (EDT_TelefonoEm.TextLength == 0 || EDT_TelefonoEm.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Tel. Emergencia no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_TelefonoEm.Focus();
                return;
            }

            // Verifica que el campo Dirección tenga información
            if (EDT_Direccion.TextLength == 0 || EDT_Direccion.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Tel. Dirección no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Direccion.Focus();
                return;
            }

            // Verifica que el combo Sexo tenga información
            if (COMBO_Sexo.SelectedIndex == -1)
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Sexo no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COMBO_Sexo.Focus();
                return;
            }

            // Verifica que el combo TipoSangre tenga información
            if (COMBO_TipoSangre.SelectedIndex == -1)
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Tipo Sangre no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COMBO_TipoSangre.Focus();
                return;
            }
        }
    }
}
