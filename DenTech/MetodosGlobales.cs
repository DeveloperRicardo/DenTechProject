﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DenTech
{
    public class MetodosGlobales
    {
        #region Mensajes
        public void Mensajes(int Mensaje)
        {
            switch (Mensaje)
            {
                case 1:
                    MessageBox.Show("Conexión exitosa.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Conexión no exitosa.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Los campos no pueden estar vacios.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Ya existen todas las tablas.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 5:
                    MessageBox.Show("Se han creado las tablas faltantes.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 6:
                    MessageBox.Show("Se ha guardado la configuración. Se probara la conexión.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 7:
                    MessageBox.Show("No se pudo cerrar la conexión con la base de datos.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("Contraseña incorrecta.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion

        #region ProbarConexion
        public bool ProbarConexion(string Parametros)
        {
            bool Conexion = false;
            try
            {
                using (SqlConnection Miconexion = new SqlConnection(Parametros))
                {
                    Miconexion.Open();
                    Mensajes(1);
                    Conexion = true;
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Mensajes(2);
                Conexion = false;
            }
            return Conexion;
        }
        #endregion

        #region Verificar y Crear Tablas
        public void VerificarTablas(string Parametros)
        {
            try
            {
                using (SqlConnection Miconexion = new SqlConnection(Parametros))
                {
                    bool ExistePACIENTES = false, ExisteEMPLEADOS = false, ExisteCITAS = false,
                        ExisteHISTORIAL = false, ExisteSANGRE = false, ExisteEXPEDIENTE = false, ExisteRECETA = false;
                    int NumUsuarios = 0, NumSangre = 0;
                    Miconexion.Open();
                    SqlCommand Query = Miconexion.CreateCommand();
                    //Verificar si existen la tablas
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EMPLEADOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEMPLEADOS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SANGRE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteSANGRE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PACIENTES') SELECT 'true' ELSE SELECT 'false'";
                    ExistePACIENTES = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CITAS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteCITAS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'HISTORIAL') SELECT 'true' ELSE SELECT 'false'";
                    ExisteHISTORIAL = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EXPEDIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEXPEDIENTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'RECETA') SELECT 'true' ELSE SELECT 'false'";
                    ExisteRECETA = Convert.ToBoolean(Query.ExecuteScalar());
                    if (!ExistePACIENTES || !ExisteEMPLEADOS || !ExisteCITAS || !ExisteHISTORIAL || !ExisteSANGRE || !ExisteEXPEDIENTE || !ExisteRECETA)
                    {
                        MessageBox.Show("Se crearan las tablas faltantes en la base de datos.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string QryTablas = "";
                        if (!ExisteEMPLEADOS)
                        {
                            QryTablas += "CREATE TABLE EMPLEADOS(Id_Empleado int primary key identity, Usuario varchar(30),Nombre varchar(20)," +
                                         "ApellidoP varchar(12), ApellidoM varchar(12), Password varchar(20), Tipo_Usuario int);";
                        }
                        if (!ExisteSANGRE)
                        {
                            QryTablas += "CREATE TABLE SANGRE(Id_Sangre int primary key identity, Descripcion varchar(3), TipoSangre int)";
                        }
                        if (!ExistePACIENTES)
                        {
                            QryTablas += "CREATE TABLE PACIENTES(Id_Paciente int primary key identity, Id_Sangre int foreign key references SANGRE(Id_Sangre) on update cascade on delete cascade," +
                                         "Nombre varchar(20),ApellidoP varchar(12),ApellidoM varchar(12), Edad int,Sexo int, Direccion varchar(30),Telefono varchar(10),Tel_Emergencia varchar(10));";
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
                        if (!ExisteEXPEDIENTE)
                        {
                            QryTablas += "CREATE TABLE EXPEDIENTE(Id_Expediente int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Enfermedad varchar(100), Alergia varchar(100));";
                        }
                        if (!ExisteRECETA)
                        {
                            QryTablas += "CREATE TABLE RECETA(Id_Receta int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade,Diagnostico varchar(100), Medicamento varchar(100)," +
                                         "Tratamiento varchar(100),Fecha_Inicio date, Fecha_Final date, Fecha_Diag date);";
                        }
                        Query.CommandText = QryTablas;
                        Query.ExecuteNonQuery();
                        Mensajes(5);
                    }
                    Query.CommandText = "SELECT COUNT(*) FROM EMPLEADOS";
                    NumUsuarios = Convert.ToInt32(Query.ExecuteScalar());
                    Query.CommandText = "SELECT COUNT(*) FROM SANGRE";
                    NumSangre = Convert.ToInt32(Query.ExecuteScalar());
                    if (NumUsuarios == 0)
                    {
                        Query.CommandText = "INSERT INTO EMPLEADOS VALUES('admin','admin','admin','admin','admin',1);";
                        Query.ExecuteNonQuery();
                    }
                    if (NumSangre == 0)
                    {
                        Query.CommandText = "INSERT INTO SANGRE VALUES('A+',1);"+
                                            "INSERT INTO SANGRE VALUES('A-',2);" +
                                            "INSERT INTO SANGRE VALUES('B+',3);" +
                                            "INSERT INTO SANGRE VALUES('B-',4);" +
                                            "INSERT INTO SANGRE VALUES('AB+',5);" +
                                            "INSERT INTO SANGRE VALUES('AB-',6);" +
                                            "INSERT INTO SANGRE VALUES('O+',7);" +
                                            "INSERT INTO SANGRE VALUES('O-',8);";
                        Query.ExecuteNonQuery();
                    }
                    Miconexion.Close();
                }
            }
            catch (Exception)
            {
                Mensajes(2);
            }
        }
        #endregion
    }
}