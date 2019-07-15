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
    public partial class WIN_CAT_Expediente_F : Form
    {
        // Variables globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales MG = new MetodosGlobales();
        int gnIdExpediente = 0;

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
            {
                // Se limpian los campos
                STC_NombreOdontologo.Text = "";
                STC_NombrePaciente.Text = "";
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
            int IdOdontologo = Window._ReturnId;

            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Se estructura el query
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Select " +
                    "Usuario, " +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM), " +
                    "From EMPLEADOS " +
                    "Where Id_Empleado = " + IdOdontologo;

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
            }
        }

        private void BTN_Paciente_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
            WIN_CAT_Seleccion_F Window = new WIN_CAT_Seleccion_F(2);
            Window.ShowDialog();
            int IdPaciente = Window._ReturnId;

            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Se estructura el query
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Select " +
                    "Nombre, " +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM), " +
                    "From PACIENTES " +
                    "Where Id_Paciente = " + IdPaciente;

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
            }
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