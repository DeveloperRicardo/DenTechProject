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
    public partial class WIN_CAT_Expediente_F : WIN_Template_F
    {
        // Variables globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
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
            try
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
                    if (gnIdExpediente != 0)
                    {
                        // Se estructura el query
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Select \n" +
                            "Id_Empleado, \n" +
                            "Id_Paciente, \n" +
                            "Enfermedad, \n" +
                            "Alergia, \n" +
                            "Fecha, \n" +
                            "Id_Sangre \n" +
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
                            COMBO_TipoSangre.SelectedValue = Int32.Parse(Reader[5].ToString());
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
                                "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM), " +
                                "Edad " +
                                "From PACIENTES " +
                                "Where Id_Paciente = " + gnIdPaciente;

                            // Ejecuta el query y almacena los datos consultados
                            SqlDataReader Reader3 = cmd.ExecuteReader();
                            Reader3.Read();

                            // Revisa si cuenta con información
                            if (Reader3.HasRows)
                            {
                                // Inserta la información a los controles
                                EDT_Paciente.Text = Reader3[0].ToString();
                                STC_NombrePaciente.Text = Reader3[1].ToString();
                                STC_EdadPaciente.Text = Reader3[2].ToString();
                            }
                            Reader3.Close(); // Se libera
                        }

                    }
                    else
                    {
                        // Se limpian los campos
                        STC_NombreOdontologo.Text = "";
                        STC_NombrePaciente.Text = "";
                        STC_EdadPaciente.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
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
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Paciente_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y se obtiene el Id del usuario deseado
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
                    "NombreCompleto = (Nombre + ' ' + ApellidoP + ' ' + ApellidoM), " +
                    "Edad " +
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
                    STC_EdadPaciente.Text = Reader[2].ToString();
                }
                Reader.Close(); // Se libera
                                // }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }            
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Revisa los campos
                if (ValidarCampos())
                {
                    // Verifica si el registro se creará o se modificará
                    if (gnIdExpediente == 0)
                    {
                        // Se abre la conexión y se estructura el query para agregar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Insert Into EXPEDIENTE(Id_Empleado, Id_Paciente, Enfermedad, Alergia, Fecha, Id_Sangre) " +
                            "Values(" + gnIdOdontologo + ", " + gnIdPaciente + ", '" + EDT_Enfermedad.Text + "', '" + EDT_Alergias.Text + "', '" + DT_Fecha.Value + "', '" + COMBO_TipoSangre.SelectedValue + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Registro existente, se modificará
                    {
                        // Se abre la conexión y se estructura el query para agregar el registro
                        SqlCommand cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "Update EXPEDIENTE " +
                            "Set Id_Empleado = " + gnIdOdontologo + ", Id_Paciente = " + gnIdPaciente + ", Enfermedad = '" + EDT_Enfermedad.Text + "', Alergia = '" + EDT_Alergias.Text +
                            "', Fecha = '" + DT_Fecha.Value + "', Id_Sangre = '" + COMBO_TipoSangre.SelectedValue + "' Where Id_Expediente = " + gnIdExpediente;
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

        // Método ValidarCampos
        private bool ValidarCampos()
        {
            bool Regresar = true;
            try
            {
                // Valida que el campo Odontólogo tenga información
                if (EDT_Odontologo.TextLength == 0 || EDT_Odontologo.Text == "")
                {
                    Glo.Mensajes(3, "Odontólogo");
                    EDT_Odontologo.Focus();
                    Regresar = false;
                }

                // Valida que el campo Paciente tenga información
                if (EDT_Paciente.TextLength == 0 || EDT_Paciente.Text == "")
                {
                    Glo.Mensajes(3, "Paciente");
                    EDT_Paciente.Focus();
                    Regresar = false;
                }

                // Valida que el campo Enfermedades tenga información
                if (EDT_Enfermedad.TextLength == 0 || EDT_Enfermedad.Text == "")
                {
                    Glo.Mensajes(3, "Enfermedades");
                    EDT_Enfermedad.Focus();
                    Regresar = false;
                }

                // Valida que el campo Alergias tenga información
                if (EDT_Alergias.TextLength == 0 || EDT_Alergias.Text == "")
                {
                    Glo.Mensajes(3, "Alergias");
                    EDT_Alergias.Focus();
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
    }
}