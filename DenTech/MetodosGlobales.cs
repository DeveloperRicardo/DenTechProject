using System;
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
        public void Mensajes(int Mensaje, string Excepcion = "")
        {
            switch (Mensaje)
            {
                case 1:
                    MessageBox.Show("Conexión exitosa.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Conexión no exitosa.\n\nDetalles del error:\n"+Excepcion, "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("El campo '"+ Excepcion + "' no puede estar vacío.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Usuario o contraseña incorrecta.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 9:
                    MessageBox.Show("Se han creado los métodos faltantes.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 10:
                    MessageBox.Show("Ha ocurrido un error al realizar un proceso.\n\nDetalles del error:\n" + Excepcion, "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                Mensajes(2, ex.Message);
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
                    bool ExistePACIENTES = false, ExisteEMPLEADOS = false, ExisteCITAS = false, ExisteHISTORIAL = false,
                         ExisteSANGRE = false, ExisteEXPEDIENTE = false, ExisteRECETA = false, ExisteINVENTARIO = false,
                         ExisteSERVICIOS = false, ExisteARCHIVOS = false, ExisteANTECEDENTES = false, ExisteODONTOGRAMA = false, 
                         ExisteDIENTE = false, ExisteDETALLE = false, ExisteTRATAMIENTO = false, ExisteIMPLANTE = false,
                         ExisteEXTRACCION = false, ExisteTRATADIENTE = false, ExisteIMPDIENTE = false, ExisteEXDIENTE = false,
                         ExisteTRCrearDiente = false, ExisteTRCrearDetalle = false;
                    int NumUsuarios = 0, NumSangre = 0;
                    string QryTablas = "", QryTablas2 = "", tablas = "";
                    Miconexion.Open();
                    SqlCommand Query = Miconexion.CreateCommand();
                    //Verificar si existen la tablas
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EMPLEADOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEMPLEADOS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SANGRE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteSANGRE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SERVICIOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteSERVICIOS = Convert.ToBoolean(Query.ExecuteScalar());
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
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'INVENTARIO') SELECT 'true' ELSE SELECT 'false'";
                    ExisteINVENTARIO = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ARCHIVOSADJUNTOS') SELECT 'true' ELSE SELECT 'false'";
                    ExisteARCHIVOS = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ODONTOGRAMA') SELECT 'true' ELSE SELECT 'false'";
                    ExisteODONTOGRAMA = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'DIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteDIENTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'DETALLEDIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteDETALLE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TRATAMIENTO') SELECT 'true' ELSE SELECT 'false'";
                    ExisteTRATAMIENTO = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'IMPLANTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteIMPLANTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EXTRACCION') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEXTRACCION = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TRATAMIENTODIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteTRATADIENTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'IMPLANTEDIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteIMPDIENTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EXTRACCIONDIENTE') SELECT 'true' ELSE SELECT 'false'";
                    ExisteEXDIENTE = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM sys.triggers WHERE name = 'TR_Crear_Diente') SELECT 'true' ELSE SELECT 'false'";
                    ExisteTRCrearDiente = Convert.ToBoolean(Query.ExecuteScalar());
                    Query.CommandText = "IF EXISTS(SELECT * FROM sys.triggers WHERE name = 'TR_Crear_Detalle') SELECT 'true' ELSE SELECT 'false'";
                    ExisteTRCrearDetalle = Convert.ToBoolean(Query.ExecuteScalar());
                    if (!ExistePACIENTES || !ExisteEMPLEADOS || !ExisteCITAS || !ExisteHISTORIAL || !ExisteSANGRE ||
                        !ExisteEXPEDIENTE || !ExisteRECETA || !ExisteINVENTARIO || !ExisteSERVICIOS || !ExisteARCHIVOS ||
                        !ExisteODONTOGRAMA || !ExisteDIENTE || !ExisteDETALLE || !ExisteTRATAMIENTO || !ExisteIMPLANTE ||
                        !ExisteEXTRACCION || !ExisteTRATADIENTE || !ExisteIMPDIENTE || !ExisteEXDIENTE)
                    {
                        if (!ExisteEMPLEADOS)
                        {
                            QryTablas += "CREATE TABLE EMPLEADOS(Id_Empleado int primary key identity, Usuario varchar(30),Nombre varchar(20)," +
                                         "ApellidoP varchar(12), ApellidoM varchar(12), Password varchar(20), Tipo_Usuario int);";
                            tablas += "-EMPLEADOS\n";
                        }
                        if (!ExisteSANGRE)
                        {
                            QryTablas += "CREATE TABLE SANGRE(Id_Sangre int primary key identity, Descripcion varchar(3))";
                            tablas += "-SANGRE\n";
                        }
                        if (!ExisteSERVICIOS)
                        {
                            QryTablas += "CREATE TABLE SERVICIOS(Id_Servicios int primary key identity, Descripcion varchar(100),Precio decimal(10,2))";
                            tablas += "-SERVICIOS\n";
                        }
                        if (!ExistePACIENTES)
                        {
                            QryTablas += "CREATE TABLE PACIENTES(Id_Paciente int primary key identity, " +
                                         "Matricula varchar(6), Nombre varchar(20),ApellidoP varchar(12),ApellidoM varchar(12), Edad int,Sexo int, Direccion varchar(100),Telefono varchar(10),Tel_Emergencia varchar(10));";
                            tablas += "-PACIENTES\n";
                        }
                        if (!ExisteCITAS)
                        {
                            QryTablas += "CREATE TABLE CITAS(Id_Cita int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Id_Servicios int foreign key references SERVICIOS(Id_Servicios)"+
                                         "on update cascade on delete cascade, Fecha_Cita datetime);";
                            tablas += "-CITAS\n";
                        }
                        if (!ExisteHISTORIAL)
                        {
                            QryTablas += "CREATE TABLE HISTORIAL(Id_Historial int primary key identity," +
                                         "Id_Cita int foreign key references CITAS(Id_Cita) on update cascade on delete cascade, Fecha_Mod date);";
                            tablas += "-HISTORIAL\n";
                        }
                        if (!ExisteEXPEDIENTE)
                        {
                            QryTablas += "CREATE TABLE EXPEDIENTE(Id_Expediente int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, "+
                                         "Id_Sangre int foreign key references SANGRE(Id_Sangre) on update cascade on delete cascade, Enfermedad varchar(100), Alergia varchar(100), Fecha date);";
                            tablas += "-EXPEDIENTE\n";
                        }
                        if (!ExisteRECETA)
                        {
                            QryTablas += "CREATE TABLE RECETA(Id_Receta int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade," +
                                         "Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade,Diagnostico varchar(100), Medicamento varchar(100)," +
                                         "Tratamiento varchar(100),Fecha_Inicio date, Fecha_Final date, Fecha_Diag date);";
                            tablas += "-RECETA\n";
                        }
                        if (!ExisteINVENTARIO)
                        {
                            QryTablas += "CREATE TABLE INVENTARIO(Id_Inventario int primary key identity, Descripcion varchar(100),Cantidad int, Fecha_Inicio date, Fecha_Final date, Tipo_Producto int);";
                            tablas += "-INVENTARIO\n";
                        }
                        if (!ExisteARCHIVOS)
                        {
                            QryTablas += "CREATE TABLE ARCHIVOSADJUNTOS(Id int primary key identity, Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade," +
                                         "Nombre varchar(100),RutaLogica varchar(500));";
                            tablas += "-ARCHIVOSADJUNTOS\n";
                        }
                        if (!ExisteODONTOGRAMA)
                        {
                            QryTablas += "CREATE TABLE ODONTOGRAMA(Id_Odontograma int primary key identity, Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade," +
                                         "Fecha_Registro date, Descripcion varchar(100));";
                            tablas += "-ODONTOGRAMA\n";
                        }
                        if (!ExisteDIENTE)
                        {
                            QryTablas += "CREATE TABLE DIENTE(Id_Diente int primary key identity, Id_Odontograma int foreign key references ODONTOGRAMA(Id_Odontograma) on update cascade on delete cascade," +
                                         "NumDiente int, Descripcion varchar(510));";
                            tablas += "-DIENTE\n";
                        }
                        if (!ExisteDETALLE)
                        {
                            QryTablas += "CREATE TABLE DETALLEDIENTE(Id_Detalle int primary key identity, ID_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade," +
                                         "AreaDiente int, Estatus int); ";
                            tablas += "-DETALLEDIENTE\n";
                        }
                        if (!ExisteTRATAMIENTO)
                        {
                            QryTablas += "CREATE TABLE TRATAMIENTO(Id_Tratamiento int primary key identity, Descripcion varchar(100), Precio decimal(10,2));";
                            tablas += "-TRATAMIENTO\n";
                        }
                        if (!ExisteIMPLANTE)
                        {
                            QryTablas += "CREATE TABLE IMPLANTE(Id_Implante int primary key identity, Descripcion varchar(100), Precio decimal(10,2));";
                            tablas += "-IMPLANTE\n";
                        }
                        if (!ExisteEXTRACCION)
                        {
                            QryTablas += "CREATE TABLE EXTRACCION(Id_Extraccion int primary key identity, Descripcion varchar(100), Precio decimal(10,2));";
                            tablas += "-EXTRACCION\n";
                        }
                        if (!ExisteTRATADIENTE)
                        {
                            QryTablas += "CREATE TABLE TRATAMIENTODIENTE(Id_TrataDiente int primary key identity, "+
                                         "Id_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade, " +
                                         "Id_Tratamiento int foreign key references TRATAMIENTO(Id_Tratamiento) on update cascade on delete cascade);";
                            tablas += "-TRATAMIENTODIENTE\n";
                        }
                        if (!ExisteIMPDIENTE)
                        {
                            QryTablas += "CREATE TABLE IMPLANTEDIENTE(Id_ImplanteDiente int primary key identity, " +
                                         "Id_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade, " +
                                         "Id_Implante int foreign key references IMPLANTE(Id_Implante) on update cascade on delete cascade);";
                            tablas += "-IMPLANTEDIENTE\n";
                        }
                        if (!ExisteEXDIENTE)
                        {
                            QryTablas += "CREATE TABLE EXTRACCIONDIENTE(Id_ExtraDiente int primary key identity, " +
                                         "Id_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade, " +
                                         "Id_Extraccion int foreign key references EXTRACCION(Id_Extraccion) on update cascade on delete cascade);";
                            tablas += "-EXTRACCIONDIENTE\n";
                        }
                        MessageBox.Show("Se crearan las siguientes tablas faltantes en la base de datos:\n\n" + tablas, "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Query.CommandText = "INSERT INTO EMPLEADOS VALUES('admin','admin','admin','admin','admin',0);";
                        Query.ExecuteNonQuery();
                    }
                    if (NumSangre == 0)
                    {
                        Query.CommandText = "INSERT INTO SANGRE VALUES('A+');"+
                                            "INSERT INTO SANGRE VALUES('A-');" +
                                            "INSERT INTO SANGRE VALUES('B+');" +
                                            "INSERT INTO SANGRE VALUES('B-');" +
                                            "INSERT INTO SANGRE VALUES('AB+');" +
                                            "INSERT INTO SANGRE VALUES('AB-');" +
                                            "INSERT INTO SANGRE VALUES('O+');" +
                                            "INSERT INTO SANGRE VALUES('O-');";
                        Query.ExecuteNonQuery();
                    }
                    if (!ExisteTRCrearDiente || !ExisteTRCrearDetalle)
                    {
                        QryTablas = "";
                        tablas = "";
                        if (!ExisteTRCrearDiente)
                        {
                            QryTablas += "create trigger TR_Crear_Diente \n" +
                                         "on ODONTOGRAMA \n" +
                                         "for insert \n" +
                                         "as \n " +
                                         "DECLARE @ID int \n"+
                                         "SET @ID = (SELECT Id_Odontograma FROM inserted) \n" +
                                         "INSERT INTO DIENTE VALUES(@ID,11,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,12,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,13,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,14,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,15,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,16,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,17,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,18,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,21,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,22,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,23,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,24,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,25,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,26,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,27,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,28,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,31,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,32,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,33,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,34,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,35,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,36,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,37,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,38,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,41,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,42,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,43,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,44,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,45,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,46,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,47,'') \n" +
	                                     "INSERT INTO DIENTE VALUES(@ID,48,'');\n ";
                            tablas += "-TR_Crear_Diente\n";
                        }
                        if (!ExisteTRCrearDetalle)
                        {
                            QryTablas2 = "create trigger TR_Crear_Detalle \n" +
                                         "on DIENTE \n" +
                                         "for insert \n" +
                                         "as \n " +
                                         "DECLARE @ID2 int \n" +
                                         "SET @ID2 = (SELECT Id_Diente FROM inserted) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,1,0) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,2,0) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,3,0) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,4,0) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,5,0) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,6,0) \n" +
                                         "INSERT INTO DETALLEDIENTE VALUES(@ID2,7,0) \n";
                            tablas += "-TR_Crear_Detalle\n";
                        }
                        MessageBox.Show("Se crearan los siguientes métodos faltantes en la base de datos:\n\n" + tablas, "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Query.CommandText = QryTablas;
                        Query.ExecuteNonQuery();
                        Query.CommandText = QryTablas2;
                        Query.ExecuteNonQuery();
                        Mensajes(9);
                    }
                    Miconexion.Close();
                }
            }
            catch (Exception ex)
            {
                Mensajes(2,ex.Message);
            }
        }
        #endregion

        #region CodigoRegistro
        public string CodigoRegistro(int codigo){
            string Nuevocodigo = "";
            codigo += 1;
            switch (codigo.ToString().Count())
            {
                case 1:
                    Nuevocodigo = "00000" + (codigo);
                    break;
                case 2:
                    Nuevocodigo = "0000" + (codigo);
                    break;
                case 3:
                    Nuevocodigo = "000" + (codigo);
                    break;
                case 4:
                    Nuevocodigo = "00" + (codigo);
                    break;
                case 5:
                    Nuevocodigo = "0" + (codigo);
                    break;
                case 6:
                    Nuevocodigo = Convert.ToString(codigo);
                    break;
                default:
                    break;
            }
            return Nuevocodigo;
        }
        #endregion
    }
}
