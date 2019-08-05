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
    public partial class WIN_CAT_Expediente_F : WIN_Template
    {
        // Variables globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales MG = new MetodosGlobales();
        int gnIdExpediente = 0;
        int gnIdOdontologo = 0;
        int gnIdPaciente = 0;

        public WIN_CAT_Expediente_F(int pIdExpediente = 0)
        {
            InitializeComponent();
            gnIdExpediente = pIdExpediente;
        }

        // Evento cuando se carga la ventana
        private void WIN_CAT_Expediente_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {// Verifica que tenga información de un usuario existente
                if (gnIdExpediente != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select \n" +
                        "Id_Empleado, \n" +
                        "Id_Paciente, \n" +
                        "Enfermedad, \n" +
                        "Alergia, \n" +
                        "Fecha \n" +
                        "From EXPEDIENTE\n" +
                        "Where EXPEDIENTE.Id_Expediente = " + gnIdExpediente;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        gnIdOdontologo = Convert.ToInt16(Reader[0]);
                        gnIdPaciente = Convert.ToInt16(Reader[1]);
                        EDT_Enfermedad.Text = Reader[2].ToString();
                        EDT_Alergias.Text = Reader[3].ToString();
                        DT_Fecha.Value = Convert.ToDateTime(Reader[4]);
                        Reader.Close(); // Se libera

                        // Se estructura el query
                        cmd.CommandText = "Select " +
                            "Usuario, " +
                            "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                            "From EMPLEADOS " +
                            "Where Id_Empleado = " + gnIdOdontologo;

                        // Ejecuta el query y almacena los datos consultados
                        SqlDataReader Reader2 = cmd.ExecuteReader();
                        Reader2.Read();

                        // Revisa si cuenta con información
                        if (Reader2.HasRows)
                        {
                            // Inserta la información a los controles
                            EDT_Odontologo.Text = Reader2[0].ToString();
                            STC_NombreOdontologo.Text = Reader2[1].ToString();
                        }
                        Reader2.Close(); // Se libera

                        //Paciente
                        cmd.CommandText = "Select " +
                            "Nombre, " +
                            "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                            "From PACIENTES " +
                            "Where Id_Paciente = " +gnIdPaciente;

                        // Ejecuta el query y almacena los datos consultados
                        SqlDataReader Reader3 = cmd.ExecuteReader();
                        Reader3.Read();

                        // Revisa si cuenta con información
                        if (Reader3.HasRows)
                        {
                            // Inserta la información a los controles
                            EDT_Paciente.Text = Reader3[0].ToString();
                            STC_NombrePaciente.Text = Reader3[1].ToString();
                        }
                        Reader3.Close(); // Se libera
                    }

                }
                else {
                    // Se limpian los campos
                    STC_NombreOdontologo.Text = "";
                    STC_NombrePaciente.Text = "";
                }
            }
        }

        // Evento del botón Cerrar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Evento del botón de Odontólogo
        private void BTN_Odontologo_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
            WIN_CAT_Seleccion_F Window = new WIN_CAT_Seleccion_F(1);
            Window.ShowDialog();
            gnIdOdontologo = Window._ReturnId;

            // Verifica si se puede conectar con la base de datos
//            if (BD.Conexion(true))
//            {
                // Se estructura el query
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Select " +
                    "Usuario, " +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                    "From EMPLEADOS " +
                    "Where Id_Empleado = " + gnIdOdontologo;

                // Ejecuta el query y almacena los datos consultados
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();

                // Revisa si cuenta con información
                if (Reader.HasRows)
                {
                    // Inserta la información a los controles
                    EDT_Odontologo.Text = Reader[0].ToString();
                    STC_NombreOdontologo.Text = Reader[1].ToString();
                }
                Reader.Close(); // Se libera
         //   }
        }

        private void BTN_Paciente_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
            WIN_CAT_Seleccion_F Window = new WIN_CAT_Seleccion_F(2);
            Window.ShowDialog();
            gnIdPaciente = Window._ReturnId;

            // Verifica si se puede conectar con la base de datos
//            if (BD.Conexion(true))
//            {
                // Se estructura el query
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Select " +
                    "Nombre, " +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                    "From PACIENTES " +
                    "Where Id_Paciente = " + gnIdPaciente;

                // Ejecuta el query y almacena los datos consultados
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();

                // Revisa si cuenta con información
                if (Reader.HasRows)
                {
                    // Inserta la información a los controles
                    EDT_Paciente.Text = Reader[0].ToString();
                    STC_NombrePaciente.Text = Reader[1].ToString();
                }
                Reader.Close(); // Se libera
           // }
        }

        #region Eventos innecesarios
        private void STC_Odontologo_Click(object sender, EventArgs e)
        {

        }

        private void STC_NombreCompleto_Click(object sender, EventArgs e)
        {

        }
        #endregion

        // Evento del EDT Odontólogo
        private void EDT_Odontologo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Revisa los campos
            ValidarCampos();

            // Verifica si el registro se creará o se modificará
            if (gnIdExpediente == 0)
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Insert Into EXPEDIENTE(Id_Empleado, Id_Paciente, Enfermedad, Alergia, Fecha) " +
                    "Values(" + gnIdOdontologo + ", " + gnIdPaciente + ", '" + EDT_Enfermedad.Text + "', '" + EDT_Alergias.Text + "', '" + DT_Fecha.Value + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Registro existente, se modificará
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update EXPEDIENTE " +
                    "Set Id_Empleado = " + gnIdOdontologo + ", Id_Paciente = " + gnIdPaciente + ", Enfermedad = '" + EDT_Enfermedad.Text + "', Alergia = '" + EDT_Alergias.Text +
                    "', Fecha = '" + DT_Fecha.Value + "' Where Id_Expediente = " + gnIdExpediente;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cierra la ventana
            this.Close();
        }

        // Método ValidarCampos
        private void ValidarCampos()
        {
            // Valida que el campo Odontólogo tenga información
            if (EDT_Odontologo.Text == "")
            {
                MG.Mensajes(3, "Odontólogo");
                EDT_Odontologo.Focus();
                return;
            }

            // Valida que el campo Paciente tenga información
            if (EDT_Paciente.Text == "")
            {
                MG.Mensajes(3, "Paciente");
                EDT_Paciente.Focus();
                return;
            }

            // Valida que el campo Enfermedades tenga información
            if (EDT_Enfermedad.Text == "")
            {
                MG.Mensajes(3, "Enfermedades");
                EDT_Enfermedad.Focus();
                return;
            }

            // Valida que el campo Alergias tenga información
            if (EDT_Alergias.Text == "")
            {
                MG.Mensajes(3, "Alergias");
                EDT_Alergias.Focus();
                return;
            }
        }
    }
}