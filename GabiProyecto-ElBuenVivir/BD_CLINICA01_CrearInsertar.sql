--Proyecto Fase II
--Estudiante: Gabriela Gutiérrez Hernández
--Base de datos para la Clínica El Buen Vivir

--Creación de la base de datos

CREATE DATABASE BD_CLINICA01
GO

USE BD_CLINICA01
GO



--=====================================
--CREACIÓN DE TABLAS
--1.=====================================
create table PuestoTrabajo (
	IdPuestoTrabajo int identity(1,1) constraint pk_IdPuestoTrabajo primary key,
	Nombre  varchar(50) not null, 
	Fecha_creacion datetime default getdate()
)

--2.*************
create table Funcionarios (
	IdFuncionario int identity(1,1) constraint pk_IdFuncionario primary key,
	Nombre varchar(50) not null,
	PrimerApellido	varchar(15)	not null,
	SegundoApellido	varchar(15)	not null,
	Cedula varchar(15) not null unique,
	FechaNacimiento  datetime not null,
	Genero char(1),
	Telefono varchar(20) not null,
	Correo	varchar(50)	not null unique,
	FechaCreacion datetime default getdate(),
	Estado bit,
	IdPuestoTrabajo int not null constraint fk_IdPuestoTrabajo foreign key (IdPuestoTrabajo) references PuestoTrabajo(IdPuestoTrabajo)
)

--3.*************
create table AccesoSistema (
	IdAccesoSistema int identity(1,1) constraint pk_IdAccesoSistema primary key,
	IdFuncionario int not null constraint fk_IdFuncionario foreign key(IdFuncionario) references Funcionarios(IdFuncionario),
	Clave varchar(max) not null,
	NivelAcceso int, 
	Fecha_creacion datetime default getdate()
)

--4.*************
create table Bitacora(
	IdBitacora int identity(1,1) constraint pk_IdBitacora primary key,
	FechaCita  datetime not null,
	Descripcion varchar(500)
)

--5.*************
create table Especialidades (
	IdEspecialidad int identity(1,1) constraint pk_IdEspecialidad primary key,
	NombreEsp varchar(50),
	RequisitosAcademicos varchar(50),
	FechaCreacion datetime default getdate()
)

--6.*************
create table FuncionariosEspecialidades (
	IdFuncionarioEspecialidad int identity(1,1) constraint pk_IdFuncionarioEspecialidad primary key,
	IdFuncionario int not null constraint fk2_IdFuncionario foreign key (IdFuncionario) references Funcionarios(IdFuncionario),
	IdEspecialidad int not null constraint kf_IdEspecialidad foreign key (IdEspecialidad) references Especialidades(IdEspecialidad)
)

--7.*************
create table Pacientes (
	IdPaciente int identity(1,1) constraint pk_IdPaciente primary key,
	Nombre  varchar(50), 
	PrimerApellido	varchar(15)	not null,
	SegundoApellido	varchar(15)	not null,
	Cedula varchar(15) not null unique,
	FechaNacimiento  datetime not null,
	Genero char(1),
	Telefono varchar(20) not null,
	Correo	varchar(50)	not null unique,
	FechaCreacion datetime default getdate(),
	Estado bit
)

--8.*************
create table Especialistas (
	IdEspecialista int identity(1,1) constraint pk_IdEspecialista primary key,
	IdEspecialidad int not null constraint fk_IdEspecialidad foreign key (IdEspecialidad) references Especialidades(IdEspecialidad),
	--IdFuncionario int not null constraint fk3_IdFuncionario foreign key (IdFuncionario) references Funcionarios(IdFuncionario),
	--IdPuestoTrabajo int not null constraint fk2_IdPuestoTrabajo foreign key (IdPuestoTrabajo) references PuestoTrabajo(IdPuestoTrabajo),
	HorarioDisponible datetime,
	FechaCreacion datetime default getdate(),
	Estado bit
)

--ALTER TABLE Especialistas
--DROP CONSTRAINT fk3_IdFuncionario;

--ALTER TABLE Especialistas
--DROP COLUMN IdFuncionario;


--ALTER TABLE Especialistas
--DROP CONSTRAINT fk2_IdPuestoTrabajo;
--ALTER TABLE Especialistas
--DROP COLUMN IdPuestoTrabajo;

--9.*************
create table Citas (
	IdCitas int identity(1,1) constraint pk_IdCitas primary key,
	IdPaciente int not null constraint fk_IdPaciente foreign key (IdPaciente) references Pacientes(IdPaciente),
	IdEspecialista int not null constraint fk_IdEspecialista foreign key (IdEspecialista) references Especialistas(IdEspecialista),
	FechaCita  datetime, 
	FechaCreacion datetime default getdate()
)

--10.*************
create table Pagos (
	IdPagos int identity(1,1) constraint pk_IdPagos primary key,
	IdCitas int not null constraint fk_IdCitas foreign key (IdCitas) references Citas(IdCitas),
	Monto decimal(5,2) not null,
	FechaPago datetime not null,
	FormaPago varchar(35) not null,
	Descuento decimal(5,2) not null,
	MontoFinal decimal(5,2),
	FechaRegistro datetime default getdate()
)

--11.*************
create table HorariosEspecialistas (
	IdHorarioEspecialista int identity(1,1) constraint pk_IdHorarioEspecialista primary key,
	IdEspecialista int not null constraint fk2_IdEspecialista foreign key (IdEspecialista) references Especialistas(IdEspecialista),
	Dia char,
	Hora_inicio time,
	Hora_fin  time
)

--12.*************
create table Diagnosticos (
	IdDiagnostico int identity(1,1) constraint pk_IdDiagnostico primary key,
	Descripcion varchar(50),
	FechaCreacion datetime default getdate()
)

--13.*************
create table SignosVitales (
	IdSignosVitales int identity(1,1) constraint pk_IdSignosVitales primary key,
	Descripcion varchar(50),
	Presion decimal(5,2),
	Temperatura decimal(5,2),
	Estatura decimal(5,2),
	Peso decimal (5,2),
	FechaCreacion datetime default getdate()
)

--14.*************
create table Medicamentos (
	IdMedicamentos int identity(1,1) constraint pk_IdMedicamentos primary key,
	Descripcion varchar(50),
	FechaCreacion datetime default getdate()
)

--15.*************
create table Laboratorios (
	IdLaboratorio int identity(1,1) constraint pk_IdLaboratorio primary key,
	Descripcion varchar(50),
	FechaCreacion datetime default getdate()
)

--16.*************
create table HistorialClinico (
	IdHistorialClinico int identity(1,1) constraint pk_IdHistorialClinico  primary key,
	IdPaciente int not null constraint fk3_IdPaciente foreign key (IdPaciente) references Pacientes(IdPaciente),
	IdEspecialista int not null constraint fk3_IdEspecialista foreign key (IdEspecialista) references Especialistas(IdEspecialista),
	IdDiagnostico int not null constraint fk_IdDiagnostico foreign key (IdDiagnostico) references diagnosticos(IdDiagnostico),
	IdMedicamentos int not null constraint fk_IdMedicamentos foreign key (IdMedicamentos) references Medicamentos(IdMedicamentos),
	FechaConsulta datetime,
	IdSignosVitales int not null constraint fk_IdSignosVitales foreign key (IdSignosVitales) references SignosVitales(IdSignosVitales),
	IdLaboratorio int not null constraint fk_IdLaboratorio foreign key (IdLaboratorio) references Laboratorios(IdLaboratorio),
	FechaCreacion datetime default getdate()
)