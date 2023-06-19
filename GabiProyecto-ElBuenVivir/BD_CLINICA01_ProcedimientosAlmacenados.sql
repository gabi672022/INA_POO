--Proyecto Fase II
--Estudiante: Gabriela Gutiérrez Hernández
--Base de datos para la Clínica El Buen Vivir

--Procedimientos Almacenados
use BD_CLINICA01

--EditarFuncionario
go
create or alter proc spEditarFuncionario(
	@IdFuncionario int,
	@Nombre varchar(50),
	@PrimerApellido varchar(15),
	@SegundoApellido varchar (15),
	@Cedula varchar (15),
	@FechaNacimiento datetime,
	@Genero varchar(1),
	@Telefono varchar(20),
	@Correo varchar (50),
	--@FechaCreacion datetime,
	@Estado bit,
	@IdPuestoTrabajo int,
	@Respuesta bit output,
	@Mensaje varchar (200) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

	if not exists(select *from Funcionarios f where f.Cedula= @Cedula and f.IdFuncionario != @IdFuncionario)
	begin
		update Funcionarios set
		Nombre= @Nombre,
		PrimerApellido = @PrimerApellido,
		SegundoApellido= @SegundoApellido,
		Cedula= @Cedula,
		FechaNacimiento= @FechaNacimiento,
		Genero= @Genero,
		Telefono= @Telefono,
		Correo= @Correo,
		--FechaCreacion = @FechaCreacion,
		Estado= @Estado,
		IdPuestoTrabajo = @IdPuestoTrabajo
		where IdFuncionario = @IdFuncionario

		set @Respuesta = 1
	end
	else
		set @Mensaje = 'Funcionario existe'
end

--exec
go
declare @Respuesta bit
declare @Mensaje varchar (200)
--declare @FechaCreacion datetime

--set @FechaCreacion= CONVERT(datetime, '19000101',112)

exec spEditarFuncionario
@IdFuncionario= 3, 
@Nombre= 'GABRIELA', 
@PrimerApellido= 'GUTIÉRREZ', 
@SegundoApellido='HERNÁNDEZ', 
@Cedula= '101470478', 
@FechaNacimiento= '19970618',
@Genero='F', 
@Telefono= '87451236',
@Correo= 'GABIGUT@GMAIL.COM',
--@FechaCreacion= @FechaCreacion, 
@Estado=1, 
@IdPuestoTrabajo= 1, 
@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Funcionarios;

--EliminarFuncionario
go
create or alter proc spEliminarFuncionario(
	@IdFuncionario int,
	@Estado bit,
	@Respuesta bit output,
	@Mensaje varchar (200) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

		update Funcionarios set
			
		Estado= 0
		where IdFuncionario = @IdFuncionario	
			
		set @Respuesta = 1
		set @Mensaje = 'Funcionario deshabilitado'
end

--exec
go
declare @Respuesta bit
declare @Mensaje varchar (200)


exec spEliminarFuncionario
@IdFuncionario= 4, 
@Estado=0, 

@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Funcionarios;
--******************************************************************************
--PACIENTE
--******************************************************************************

--EditarPaciente
go
create or alter proc spEditarPaciente(
	@IdPaciente int,
	@Nombre varchar(50),
	@PrimerApellido varchar(15),
	@SegundoApellido varchar (15),
	@Cedula varchar (15),
	@FechaNacimiento datetime,
	@Genero varchar(1),
	@Telefono varchar(20),
	@Correo varchar (50),
	--@FechaCreacion datetime,
	@Estado bit,
	@Respuesta bit output,
	@Mensaje varchar (200) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

	if not exists(select *from Pacientes p where p.Cedula= @Cedula and p.IdPaciente != @IdPaciente)
	begin
		update Pacientes set
		Nombre= @Nombre,
		PrimerApellido = @PrimerApellido,
		SegundoApellido= @SegundoApellido,
		Cedula= @Cedula,
		FechaNacimiento= @FechaNacimiento,
		Genero= @Genero,
		Telefono= @Telefono,
		Correo= @Correo,
		--FechaCreacion = @FechaCreacion,
		Estado= @Estado
		
		where IdPaciente = @IdPaciente

		set @Respuesta = 1
	end
	else
		set @Mensaje = 'Paciente existe'
end

--exec
go
declare @Respuesta bit
declare @Mensaje varchar (200)
--declare @FechaCreacion datetime

--set @FechaCreacion= CONVERT(datetime, '19000101',112)

exec spEditarPaciente
@IdPaciente= 3, 
@Nombre= 'GABRIELA', 
@PrimerApellido= 'GUTIÉRREZ', 
@SegundoApellido='HERNÁNDEZ', 
@Cedula= '101470478', 
@FechaNacimiento= '19970618',
@Genero='F', 
@Telefono= '87451236',
@Correo= 'GABIGUT@GMAIL.COM',
--@FechaCreacion= @FechaCreacion, 
@Estado=1, 
@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Pacientes;

--EliminarPaciente
go
create or alter proc spEliminarPaciente(
	@IdPaciente int,
	@Estado bit,
	@Respuesta bit output,
	@Mensaje varchar (200) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

		update Pacientes set
			
		Estado= 0
		where IdPaciente = @IdPaciente	
			
		set @Respuesta = 1
		set @Mensaje = 'Paciente deshabilitado'
end

--exec
go
declare @Respuesta bit
declare @Mensaje varchar (200)


exec spEliminarPaciente
@IdPaciente= 4, 
@Estado=0, 

@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Pacientes;