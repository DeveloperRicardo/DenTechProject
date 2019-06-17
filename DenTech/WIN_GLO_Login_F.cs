using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DenTech.Properties;
using System.Data.SqlClient;

namespace DenTech
{
    public partial class WIN_GLO_Login_F : Form
    {
        bool Modificar = false;
        string conexion = "";
        string path = Environment.CurrentDirectory + @"\ConexionDenTech.ini";
        MetodosGlobales Glo = new MetodosGlobales();
        public WIN_GLO_Login_F(bool Mod = false)
        {
            Modificar = Mod;
            InitializeComponent();
            CargarInformacion();
        }

        #region Validar Campos
        private bool ValidarCampos()
        {
            if (EDT_Usuario.Text == "" || EDT_Contrasena.Text == "" || EDT_Servidor.Text == "" || EDT_BaseDatos.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region ProbarConexion
        private void BTN_ProbarConexion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                Glo.Mensajes(3);
                return;
            }
            try
            {
                conexion = @"user id=" + EDT_Usuario.Text +
                           ";password=" + EDT_Contrasena.Text +
                           ";server=" + EDT_Servidor.Text +
                           ";database=" + EDT_BaseDatos.Text + ";";
                using (SqlConnection Miconexion = new SqlConnection(conexion))
                {
                    Miconexion.Open();
                    Glo.Mensajes(1);
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Glo.Mensajes(2);
            }
        }
        #endregion

        #region Guardar INI
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                Glo.Mensajes(3);
                return;
            }
            conexion = @"user id=" + EDT_Usuario.Text +
                       ";password=" + EDT_Contrasena.Text +
                       ";server=" + EDT_Servidor.Text +
                       ";database=" + EDT_BaseDatos.Text + ";";
            if (File.Exists(path))
            {
                File.WriteAllText(path, conexion);
            }
            else
            {
                FileStream archivo = File.Create(path);
                Byte[] info = new UTF8Encoding(true).GetBytes(conexion);
                archivo.Write(info, 0, info.Length);
                archivo.Close();
            }
            Glo.Mensajes(6);
            Settings.Default.ConexionGuardada = true;
            //For testing purposes only
            if (Settings.Default.Testing == true)
            {
                DialogResult Pregunta = MessageBox.Show("Desea probar la conexión con la configuración?", "DenTech", MessageBoxButtons.YesNo);
                if (Pregunta == DialogResult.Yes)
                {
                    //                   MessageBox.Show("Se probara la conexión con la configuración.", "DenTech", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    try
                    {
                        using (SqlConnection Miconexionini = new SqlConnection(File.ReadAllText(path)))
                        {
                            Miconexionini.Open();
                            Glo.Mensajes(1);
                            Settings.Default.ConexionValida = true;
                            Miconexionini.Close();

                        }
                    }
                    catch (Exception)
                    {
                        Glo.Mensajes(2);
                        Settings.Default.ConexionValida = false;
                    }
                }
            }
            VerificarTablas();
        }
        #endregion

        #region Verificar y Crear Tablas
        private void VerificarTablas()
        {
            try
            {
                using (SqlConnection Miconexion = new SqlConnection(File.ReadAllText(path)))
                {
                    bool ExistePACIENTES = false, ExisteEMPLEADOS = false, ExisteCITAS = false,
                        ExisteHISTORIAL = false, ExisteSANGRE = false, ExisteEXPEDIENTE = false, ExisteRECETA = false;
                    int NumUsuarios = 0;
                    Miconexion.Open();
                    SqlCommand Query = Miconexion.CreateCommand();
                    //Verificar si existen la tablas
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PACIENTES') SELECT 'true' ELSE SELECT 'false'";
                    ExistePACIENTES = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EMPLEADOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEMPLEADOS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CITAS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteCITAS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'HISTORIAL') SELECT 'true' ELSE SELECT 'false'";
                    ExisteHISTORIAL = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SANGRE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteSANGRE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EXPEDIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEXPEDIENTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'RECETA') SELECT 'true' ELSE SELECT 'false'";
                    ExisteRECETA = Convert.ToBoolean(Query.ExecuteScalar());
                    if (!ExistePACIENTES || !ExisteEMPLEADOS || !ExisteCITAS || !ExisteHISTORIAL || !ExisteSANGRE || !ExisteEXPEDIENTE || !ExisteRECETA)
                    {
                        MessageBox.Show("Se crearan las tablas faltantes en la base de datos.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string QryTablas = "";
                        if (!ExistePACIENTES)
                        {
                            QryTablas += "CREATE TABLE PACIENTES(Id_Paciente int primary key identity, Nombre varchar(20),ApellidoP varchar(12)," +
                                         "ApellidoM varchar(12), Edad int,Sexo int, Direccion varchar(30),Telefono varchar(10),Tel_Emergencia varchar(10));";
                        }
                        if (!ExisteEMPLEADOS)
                        {
                            QryTablas += "CREATE TABLE EMPLEADOS(Id_Empleado int primary key identity, Usuario varchar(30),Nombre varchar(20)," +
                                         "ApellidoP varchar(12), ApellidoM varchar(12), Password varchar(20));";
                        }
                        if (!ExisteCITAS)
                        {
                            QryTablas += "CREATE TABLE CITAS(Id_Cita int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Fecha_Cita date);";
                        }
                        if (!ExisteHISTORIAL)
                        {
                            QryTablas += "CREATE TABLE HISTORIAL(Id_Historial int primary key identity," +
                                         "Id_Cita int foreign key references CITAS(Id_Cita) on update cascade on delete cascade, Fecha_Mod date);";
                        }
                        if (!ExisteSANGRE)
                        {
                            QryTablas += "CREATE TABLE SANGRE(Id_Sangre int primary key identity," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, TipoSangre int);";
                        }
                        if (!ExisteEXPEDIENTE)
                        {
                            QryTablas += "CREATE TABLE EXPEDIENTE(Id_Expediente int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Sangre int foreign key references SANGRE(Id_Sangre) on update cascade on delete cascade, Enfermedad varchar(100), Alergia varchar(100));";
                        }
                        if (!ExisteRECETA)
                        {
                            QryTablas += "CREATE TABLE RECETA(Id_Receta int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade,Diagnostico varchar(100), Medicamento varchar(100)," +
                                         "Tratamiento varchar(100),Fecha_Inicio date, Fecha_Final date, Fecha_Diag date);";
                        }
                        Query.CommandText = QryTablas;
                        Query.ExecuteNonQuery();
                        Glo.Mensajes(5);
                    }
                    Query.CommandText = "SELECT COUNT(*) FROM EMPLEADOS";
                    NumUsuarios = Convert.ToInt32(Query.ExecuteScalar());
                    if (NumUsuarios == 0)
                    {
                        Query.CommandText = "INSERT INTO EMPLEADOS VALUES('admin','admin','admin','admin','admin')";
                        Query.ExecuteNonQuery();
                    }
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Glo.Mensajes(2);
            }
        }
        #endregion

        #region Cargar Informacion
        private void CargarInformacion()
        {
            if (File.Exists(path))
            {
                string datos = File.ReadAllText(path);
                string[] parametros = datos.Split(Convert.ToChar(";"));
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            parametros[i] = parametros[i].Remove(0, 8);
                            break;
                        case 1:
                            parametros[i] = parametros[i].Remove(0, 9);
                            break;
                        case 2:
                            parametros[i] = parametros[i].Remove(0, 7);
                            break;
                        case 3:
                            parametros[i] = parametros[i].Remove(0, 9);
                            break;
                    }
                }
                EDT_Usuario.Text = parametros[0];
                EDT_Contrasena.Text = parametros[1];
                EDT_Servidor.Text = parametros[2];
                EDT_BaseDatos.Text = parametros[3];

            }
        }
        #endregion

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            if (Settings.Default.ConexionGuardada == false)
            {
                this.Close();
            }
            else
            {
                WIN_GLO_Login Login = new WIN_GLO_Login();
                if (Modificar == false)
                    Login.Show();
                this.Close();
            }
        }
    }
}
