CREATE DATABASE DENTECHBD
USE DENTECHBD
DROP DATABASE DENTECHBD
CREATE TABLE EMPLEADOS(Id_Empleado int primary key identity, Usuario varchar(30),Nombre varchar(20),ApellidoP varchar(12), ApellidoM varchar(12), Password varchar(20),
Tipo_Usuario int)

CREATE TABLE SANGRE(Id_Sangre int primary key identity, Descripcion varchar(3))

CREATE TABLE INVENTARIO(Id_Inventario int primary key identity, Descripcion varchar(100),Cantidad int, Fecha_Inicio date, Fecha_Final date, Tipo_Producto int)

CREATE TABLE SERVICIOS(Id_Servicios int primary key identity, Id_Inventario int foreign key references INVENTARIO(Id_Inventario) on update cascade on delete cascade,
Descripcion varchar(100),Precio decimal(10,2))

CREATE TABLE PACIENTES(Id_Paciente int primary key identity, Id_Sangre int foreign key references SANGRE(Id_Sangre) on update cascade on delete cascade,
Nombre varchar(20),ApellidoP varchar(12),ApellidoM varchar(12), Edad int,Sexo int, Direccion varchar(30),Telefono varchar(10),Tel_Emergencia varchar(10))

CREATE TABLE CITAS(Id_Cita int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade,
Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Id_Servicios int foreign key references SERVICIOS(Id_Servicios)
on update cascade on delete cascade,Fecha_Cita date)

CREATE TABLE HISTORIAL(Id_Historial int primary key identity, Id_Cita int foreign key references CITAS(Id_Cita) on update cascade on delete cascade, Fecha_Mod date)

CREATE TABLE EXPEDIENTE(Id_Expediente int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade,
Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Enfermedad varchar(100), Alergia varchar(100), Fecha date)

CREATE TABLE RECETA(Id_Receta int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade,
Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade,Diagnostico varchar(100), Medicamento varchar(100),
Tratamiento varchar(100),Fecha_Inicio date, Fecha_Final date, Fecha_Diag date)

CREATE TABLE INVENTARIO(Id_Inventario int primary key identity, Descripcion varchar(100),Cantidad int, Fecha_Inicio date, Fecha_Final date, Tipo_Producto int)

CREATE TABLE TRATAMIENTO(Id_Tratamiento int primary key identity, Descripcion varchar(100), Precio int)

CREATE TABLE IMPLANTE(Id_Implante int primary key identity, Descripcion varchar(100), Precio int)

CREATE TABLE ODONTOGRAMA(Id_Odontograma int primary key identity, Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade,
Fecha_Registro date, Descripcion varchar(100))

CREATE TABLE DIENTE(Id_Diente int primary key identity, Id_Odontograma int foreign key references ODONTOGRAMA(Id_Odontograma) on update cascade on delete cascade,
NumDiente int, Descripcion varchar(510))

CREATE TABLE DETALLEDIENTE(Id_Detalle int primary key identity, ID_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade,
AreaDiente int,Estatus int);

CREATE TABLE IMPLANTEDIENTE(Id_ImplanteDiente int primary key identity, Id_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade, 
Id_Implante int foreign key references IMPLANTE(Id_Implante) on update cascade on delete cascade)

CREATE TABLE TRATAMIENTODIENTE(Id_TrataDiente int primary key identity, Id_Diente int foreign key references DIENTE(Id_Diente) on update cascade on delete cascade, 
Id_Tratamiento int foreign key references TRATAMIENTO(Id_Tratamiento) on update cascade on delete cascade)

IF EXISTS(SELECT * FROM sys.triggers WHERE name = 'TR_Crear_Diente') SELECT 'true' ELSE SELECT 'false'

create trigger TR_Crear_Diente
on ODONTOGRAMA
for insert
as
	DECLARE @ID int
	SET @ID = (SELECT Id_Odontograma FROM inserted)
	INSERT INTO DIENTE VALUES(@ID,11,'')
	INSERT INTO DIENTE VALUES(@ID,12,'')
	INSERT INTO DIENTE VALUES(@ID,13,'')
	INSERT INTO DIENTE VALUES(@ID,14,'')
	INSERT INTO DIENTE VALUES(@ID,15,'')
	INSERT INTO DIENTE VALUES(@ID,16,'')
	INSERT INTO DIENTE VALUES(@ID,17,'')
	INSERT INTO DIENTE VALUES(@ID,18,'')
	INSERT INTO DIENTE VALUES(@ID,21,'')
	INSERT INTO DIENTE VALUES(@ID,22,'')
	INSERT INTO DIENTE VALUES(@ID,23,'')
	INSERT INTO DIENTE VALUES(@ID,24,'')
	INSERT INTO DIENTE VALUES(@ID,25,'')
	INSERT INTO DIENTE VALUES(@ID,26,'')
	INSERT INTO DIENTE VALUES(@ID,27,'')
	INSERT INTO DIENTE VALUES(@ID,28,'')
	INSERT INTO DIENTE VALUES(@ID,31,'')
	INSERT INTO DIENTE VALUES(@ID,32,'')
	INSERT INTO DIENTE VALUES(@ID,33,'')
	INSERT INTO DIENTE VALUES(@ID,34,'')
	INSERT INTO DIENTE VALUES(@ID,35,'')
	INSERT INTO DIENTE VALUES(@ID,36,'')
	INSERT INTO DIENTE VALUES(@ID,37,'')
	INSERT INTO DIENTE VALUES(@ID,38,'')
	INSERT INTO DIENTE VALUES(@ID,41,'')
	INSERT INTO DIENTE VALUES(@ID,42,'')
	INSERT INTO DIENTE VALUES(@ID,43,'')
	INSERT INTO DIENTE VALUES(@ID,44,'')
	INSERT INTO DIENTE VALUES(@ID,45,'')
	INSERT INTO DIENTE VALUES(@ID,46,'')
	INSERT INTO DIENTE VALUES(@ID,47,'')
	INSERT INTO DIENTE VALUES(@ID,48,'');

create trigger TR_Crear_Detalle
on DIENTE
for insert
as
	DECLARE @ID int
	SET @ID = (SELECT Id_Diente FROM inserted)
	INSERT INTO DETALLEDIENTE VALUES(@ID,1,0)
	INSERT INTO DETALLEDIENTE VALUES(@ID,2,0)
	INSERT INTO DETALLEDIENTE VALUES(@ID,3,0)
	INSERT INTO DETALLEDIENTE VALUES(@ID,4,0)
	INSERT INTO DETALLEDIENTE VALUES(@ID,5,0)
	INSERT INTO DETALLEDIENTE VALUES(@ID,6,0)
	INSERT INTO DETALLEDIENTE VALUES(@ID,7,0);


SELECT * FROM ODONTOGRAMA
select * from DIENTE
select * from DETALLEDIENTE

DROP TABLE DETALLEDIENTE
DROP TABLE DIENTE
DROP TABLE ODONTOGRAMA

--TABLA DE ANTECEDENTES

--TABLA DE ARCHIVOS ADJUNTOS

INSERT INTO SANGRE VALUES('A+');
INSERT INTO SANGRE VALUES('A-');
INSERT INTO SANGRE VALUES('B+');
INSERT INTO SANGRE VALUES('B-');
INSERT INTO SANGRE VALUES('AB+');
INSERT INTO SANGRE VALUES('AB-');
INSERT INTO SANGRE VALUES('O+');
INSERT INTO SANGRE VALUES('O-');


SELECT Estatus, Descripcion FROM DETALLEDIENTE WHERE Id_Diente = 128 AND AreaDiente = 1

