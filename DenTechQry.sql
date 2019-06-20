CREATE TABLE EMPLEADOS(Id_Empleado int primary key identity, Usuario varchar(30),Nombre varchar(20),ApellidoP varchar(12), ApellidoM varchar(12), Password varchar(20),
Tipo_Usuario int)

CREATE TABLE SANGRE(Id_Sangre int primary key identity, Descripcion varchar(3),TipoSangre int)

CREATE TABLE PACIENTES(Id_Paciente int primary key identity, Id_Sangre int foreign key references SANGRE(Id_Sangre) on update cascade on delete cascade,
Nombre varchar(20),ApellidoP varchar(12),ApellidoM varchar(12), Edad int,Sexo int, Direccion varchar(30),Telefono varchar(10),Tel_Emergencia varchar(10))

CREATE TABLE CITAS(Id_Cita int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade,
Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Fecha_Cita date)

CREATE TABLE HISTORIAL(Id_Historial int primary key identity, Id_Cita int foreign key references CITAS(Id_Cita) on update cascade on delete cascade, Fecha_Mod date)

CREATE TABLE EXPEDIENTE(Id_Expediente int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade,
Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade, Enfermedad varchar(100), Alergia varchar(100))

CREATE TABLE RECETA(Id_Receta int primary key identity, Id_Empleado int foreign key references EMPLEADOS(Id_Empleado) on update cascade on delete cascade,
Id_Paciente int foreign key references PACIENTES(Id_Paciente) on update cascade on delete cascade,Diagnostico varchar(100), Medicamento varchar(100),
Tratamiento varchar(100),Fecha_Inicio date, Fecha_Final date, Fecha_Diag date)

INSERT INTO SANGRE VALUES('A+',1);
INSERT INTO SANGRE VALUES('A-',2);
INSERT INTO SANGRE VALUES('B+',3);
INSERT INTO SANGRE VALUES('B-',4);
INSERT INTO SANGRE VALUES('AB+',5);
INSERT INTO SANGRE VALUES('AB-',6);
INSERT INTO SANGRE VALUES('O+',7);
INSERT INTO SANGRE VALUES('O-',8);