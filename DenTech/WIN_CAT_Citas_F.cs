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
    public partial class WIN_CAT_Citas_F : WIN_Template_F
    {
        // Variables y objetos globales
        int gnIdCita = 0, gnIdOdontologo = 0, gnIdPaciente = 0;
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales MG = new MetodosGlobales();

        public WIN_CAT_Citas_F(int pnIdCita = 0)
        {
            InitializeComponent();
            gnIdCita = pnIdCita;
        }

        // Evento al cargar la ventana
        private void WIN_CAT_Citas_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica que tenga información de una cita existente
                if (gnIdCita != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select " +
                        "Id_Empleado, " +
                        "Id_Paciente, " +
                        "Fecha_Cita " +
                        "From CITAS " +
                        "Order By Fecha_Cita Desc";

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        gnIdOdontologo = Convert.ToInt32(Reader[0].ToString());
                        gnIdPaciente = Convert.ToInt32(Reader[1].ToString());
                        EDT_Fecha.Value = Convert.ToDateTime(Reader[2]);
                        Reader.Close(); // Se libera

                        // Busca al odontólogo, se estructura el query
                        SqlCommand cmd2 = BD.conexion.CreateCommand();
                        cmd2.CommandText = "Select " +
                            "Usuario, " +
                            "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                            "From EMPLEADOS " +
                            "Where Id_Empleado = " + gnIdOdontologo;

                        // Ejecuta el query y almacena los datos consultados
                        SqlDataReader Reader2 = cmd2.ExecuteReader();
                        Reader2.Read();

                        // Revisa si cuenta con información
                        if (Reader2.HasRows)
                        {
                            // Inserta la información a los controles
                            EDT_Odontologo.Text = Reader2[0].ToString();
                            STC_NombreOdontologo.Text = Reader2[1].ToString();
                        }
                        else
                        {
                            // Se limpian los campos
                            EDT_Odontologo.Text = "";
                            STC_NombreOdontologo.Text = "";
                        }
                        Reader2.Close(); // Se libera

                        // Busca al paciente, se estrutura el query
                        SqlCommand cmd3 = BD.conexion.CreateCommand();
                        cmd3.CommandText = "Select " +
                            "Nombre, " +
                            "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                            "From PACIENTES " +
                            "Where Id_Paciente = " + gnIdPaciente;

                        // Ejecuta el query y almacena los datos consultados
                        SqlDataReader Reader3 = cmd3.ExecuteReader();
                        Reader3.Read();

                        // Revisamos si cuenta con información
                        if (Reader3.HasRows)
                        {
                            // Inserta la información a los controles
                            EDT_Paciente.Text = Reader3[0].ToString();
                            STC_NombrePaciente.Text = Reader3[1].ToString();
                        }
                        else
                        {
                            // Se limpian los campos
                            EDT_Paciente.Text = "";
                            STC_NombrePaciente.Text = "";
                        }
                        Reader3.Close(); // Se libera
                    }
                }
                else
                {
                    // Muestra los campos vacios
                    EDT_Odontologo.Text = "";
                    EDT_Paciente.Text = "";
                    STC_NombreOdontologo.Text = "";
                    STC_NombrePaciente.Text = "";
                }
            }
        }

        // Evento del botón lupa Odontólogo
        private void BTN_Odontologo_Click(object sender, EventArgs e)
        { 
            // Se insatncia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
            WIN_CAT_Seleccion_F Window = new WIN_CAT_Seleccion_F(1);
            Window.ShowDialog();
            gnIdOdontologo = Window._ReturnId;

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
            else
            {
                // Se limpian los campos
                EDT_Odontologo.Text = "";
                STC_NombreOdontologo.Text = "";
            }
            Reader.Close(); // Se libera
        }

        // Evento del botón lupa Paciente
        private void BTN_Paciente_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
            WIN_CAT_Seleccion_F Window = new WIN_CAT_Seleccion_F(2);
            Window.ShowDialog();
            gnIdPaciente = Window._ReturnId;

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
            else
            {
                // Se limpian los campos
                EDT_Paciente.Text = "";
                STC_NombrePaciente.Text = "";
            }
            Reader.Close(); // Se libera
        }

        // Evento del botón Aceptar
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos tengan información
            ValidarCampos();

            // Verifica si el registro se creará o se modificará
            if (gnIdCita == 0)
            {
                // Se abre la conexión y se estructura el query para agregar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Insert Into CITAS(Id_Empleado, Id_Paciente, Fecha_Cita) Values(" +
                    gnIdOdontologo + ", " + gnIdPaciente + ", '" + EDT_Fecha.Value.ToString("yyyy-MM-dd") + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Se abre la conexión y se estructura el query para modificar el registro
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Update CITAS Set " +
                    "Id_Empleado = " + gnIdOdontologo + ", " +
                    "Id_Paciente = " + gnIdPaciente + ", " +
                    "Fecha_Cita = '" + EDT_Fecha.Value.ToString("yyyy-MM-dd") + "' " +
                    "Where Id_Cita = " + gnIdCita;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Se cierra la ventana
            this.Close();
        }

        // Evento del botón Cerrar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
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

            // Valida que el campo Fecha tenga información
            if (EDT_Fecha.Value == null)
            {
                MG.Mensajes(3, "Fecha");
                EDT_Fecha.Focus();
                return;
            }
        }
    }
}
