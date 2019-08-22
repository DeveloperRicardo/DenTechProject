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
    public partial class WIN_CAT_Receta_Repo : WIN_Template_F
    {
        MetodosGlobales Glo = new MetodosGlobales();
        ConexionSQL BD = new ConexionSQL();
        public DateTime Fecha = DateTime.Today;
        int gnIdReceta = 0, gnIdPaciente = 0, gnIdEmpleado = 0;
        

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los campos tengan información
                if (ValidarCampos())
                {
                    // Verifica si el registro se creará o se modificará
                    if (gnIdReceta == 0)
                    {
                        // Se abre la conexión y se estructura el query para agregar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Insert Into RECETA(Id_Empleado, Id_Paciente, Diagnostico, Medicamento, Tratamiento, Fecha_Inicio, Fecha_Final, Fecha_Diag) Values(" +
                            gnIdEmpleado + ", " + gnIdPaciente + ", '" + EDT_Diagnostico.Text + "', '" + EDT_Medicamento.Text + "', '" + EDT_Tratamiento.Text+ "', '" + EDT_FechaInicio.Value.ToString("yyyy-MM-dd") +
                            "', '" + EDT_FechaFinal.Value.ToString("yyyy-MM-dd") + "', '" + EDT_FechaDiag.Value.ToString("yyyy-MM-dd") + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Se abre la conexión y se estructura el query para modificar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Update RECETA Set " +
                            "Diagnostico = '" + EDT_Diagnostico.Text + "', " +
                            "Medicamento = '" + EDT_Medicamento.Text + "', " +
                            "Tratamiento = '" + EDT_Tratamiento.Text + "', " +
                            "Fecha_Inicio = '" + EDT_FechaInicio.Value.ToString("yyyy-MM-dd") + "' " +
                            "Fecha_Final = '" + EDT_FechaFinal.Value.ToString("yyyy-MM-dd") + "' " +
                            "Where Id_Receta = " + gnIdReceta;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Se cierra la ventana
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        public bool ValidarCampos()
        {
            bool Regresar = true;
            try
            {
                if (EDT_Diagnostico.TextLength == 0 || EDT_Diagnostico.Text == "")
                {
                    Glo.Mensajes(3, "Diagnostico");
                    EDT_Diagnostico.Focus();
                    Regresar = false;
                }
                if (EDT_Medicamento.TextLength == 0 || EDT_Medicamento.Text == "")
                {
                    Glo.Mensajes(3, "Medicamento");
                    EDT_Medicamento.Focus();
                    Regresar = false;
                }
                if (EDT_Tratamiento.TextLength == 0 || EDT_Tratamiento.Text == "")
                {
                    Glo.Mensajes(3, "Tratamiento");
                    EDT_Tratamiento.Focus();
                    Regresar = false;
                }
                if (EDT_FechaInicio.Value == null)
                {
                    Glo.Mensajes(3, "Fecha inicio");
                    EDT_FechaInicio.Focus();
                    Regresar = false;
                }
                if (EDT_FechaFinal.Value == null)
                {
                    Glo.Mensajes(3, "Fecha final");
                    EDT_FechaFinal.Focus();
                    Regresar = false;
                }
                if (STC_NombreOdontologo.Text == string.Empty)
                {
                    Glo.Mensajes(3, "Nombre odontólogo");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento del botón lupa Odontólogo
        private void BTN_Odontologo_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
                WIN_CAT_Seleccion_F Window = new WIN_CAT_Seleccion_F(1);
                Window.ShowDialog();
                gnIdEmpleado = Window._ReturnId;

                // Se estructura el query
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "Select " +
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                    "From EMPLEADOS " +
                    "Where Id_Empleado = " + gnIdEmpleado;

                // Ejecuta el query y almacena los datos consultados
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();

                // Revisa si cuenta con información para insertar la información en el control
                if (Reader.HasRows)
                    STC_NombreOdontologo.Text = Reader[0].ToString();
                else
                    STC_NombreOdontologo.Text = "";
                Reader.Close(); // Se libera
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        public WIN_CAT_Receta_Repo(int idReceta = 0, int idPaciente = 0,int idEmpleado = 0)
        {
            InitializeComponent();
            gnIdReceta = idReceta;
            gnIdPaciente = idPaciente;
            gnIdEmpleado = idEmpleado;
        }

        private void WIN_CAT_Receta_Repo_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se puede conectar con la base de datos
                if (BD.Conexion(true))
                {
                    // Verifica que tenga información de una cita existente
                    if (gnIdReceta != 0)
                    {
                        // Se estructura el query
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Select " +
                            "Id_Empleado, " +
                            "Id_Paciente, " +
                            "Diagnostico, " +
                            "Medicamento, " +
                            "Tratamiento, " +
                            "Fecha_Inicio, " +
                            "Fecha_Final, " +
                            "Fecha_Diag, " +
                            "From RECETA " +
                            "Where Id_Receta = " + gnIdReceta;

                        // Ejecuta el query y almacena los datos consultados
                        SqlDataReader Reader = cmd.ExecuteReader();
                        Reader.Read();

                        // Revisa si cuenta con información
                        if (Reader.HasRows)
                        {
                            // Inserta la información a los controles
                            gnIdEmpleado = Convert.ToInt32(Reader[0].ToString());
                            gnIdPaciente = Convert.ToInt32(Reader[1].ToString());
                            EDT_Diagnostico.Text = Reader[2].ToString();
                            EDT_Medicamento.Text = Reader[3].ToString();
                            EDT_Tratamiento.Text = Reader[4].ToString();
                            EDT_FechaInicio.Value = Convert.ToDateTime(Reader[5]);
                            EDT_FechaFinal.Value = Convert.ToDateTime(Reader[6]);
                            EDT_FechaDiag.Value = Convert.ToDateTime(Reader[7]);
                            Reader.Close(); // Se libera

                            // Busca al odontólogo, se estructura el query
                            SqlCommand cmd2 = BD.conexion.CreateCommand();
                            cmd2.CommandText = "Select " +
                                "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM) " +
                                "From EMPLEADOS " +
                                "Where Id_Empleado = " + gnIdEmpleado;

                            // Ejecuta el query y almacena los datos consultados
                            SqlDataReader Reader2 = cmd2.ExecuteReader();
                            Reader2.Read();

                            // Revisa si cuenta con información para insertarla en el texto
                            if (Reader2.HasRows)
                                STC_NombreOdontologo.Text = Reader2[0].ToString();
                            else
                                STC_NombreOdontologo.Text = "";
                            Reader2.Close(); // Se libera
                        }
                    }
                    else
                    {
                        // Muestra los campos vacios
                        STC_NombreOdontologo.Text = string.Empty;
                        EDT_FechaDiag.Value = new DateTime(Fecha.Year, Fecha.Month, Fecha.Day);
                    }
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
