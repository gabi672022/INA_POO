--Proyecto Fase II
--Estudiante: Gabriela Gutiérrez Hernández
--Base de datos para la Clínica El Buen Vivir

--Procedimientos Almacenados
use BD_CLINICA01
--******************************************
--EditarFuncionario
--******************************************
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

--******************************************************************************
--PUESTO TRABAJO
--******************************************************************************
--EditarPaciente
go
create or alter proc spEditarPuestoTrabajo(
	@IdPuestoTrabajo int,
	@Nombre varchar(50),
	@Respuesta bit output,
	@Mensaje varchar (200) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

	if not exists(select *from PuestoTrabajo  where Nombre = @Nombre and IdPuestoTrabajo != @IdPuestoTrabajo)
	begin
		update PuestoTrabajo set
		Nombre= @Nombre
		where IdPuestoTrabajo = @IdPuestoTrabajo

		set @Respuesta = 1
	end
	else
		set @Mensaje = 'Puesto de trabajo existe'
end

--exec
go

declare @Respuesta bit
declare @Mensaje varchar (200)

exec spEditarPuestoTrabajo
@IdPuestoTrabajo= 3, 
@Nombre= 'Médico', 
@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from PuestoTrabajo;

--EliminarPaciente
go
create or alter proc spEliminarPuestoTrabajo(
	@IdPuestoTrabajo int,
	@Respuesta bit output,
	@Mensaje varchar (200) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ' '
	--Verifica si existe vinculación con la tabla Especialistas
	if exists(select *from Especialistas where IdPuestoTrabajo= @IdPuestoTrabajo)
	begin
		set @Mensaje= 'No se puede elminar puesto de trabajo debido a que existe vinculación con la tabla Especialistas'
	end
	--Verifica si existe vinculación con la tabla Funcionarios
	if exists (select *from Funcionarios where IdPuestoTrabajo= @IdPuestoTrabajo)
	begin
		set @Mensaje = 'No se puede eliminar puesto de trabajo debido a que existe vinculación con la tabla Funcioanrio'
	end

	if exists(select *from PuestoTrabajo where IdPuestoTrabajo = @IdPuestoTrabajo)	
	begin	
		delete from PuestoTrabajo where IdPuestoTrabajo = @IdPuestoTrabajo
		set @Respuesta = 1
		set @Mensaje = 'Puesto de trabajo eliminado'
	end
end



--exec
go
declare @Respuesta bit
declare @Mensaje varchar (200)


exec spEliminarPuestoTrabajo
@IdPuestoTrabajo= 2, 

@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Especialistas where IdPuestoTrabajo= 3
select *from Funcionarios where IdPuestoTrabajo= 3
select *from PuestoTrabajo 

--******************************************************************************
--ESPECIALIDADES
--******************************************************************************
--EditarEspecialidades
go
create or alter proc spEditarEspecialidad(
	@IdEspecialidad int,
	@NombreEsp varchar(50),
	@RequisitosAcademicos varchar(50),
	@Respuesta bit output,
	@Mensaje varchar (200) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

	if not exists(select *from Especialidades  where NombreEsp = @NombreEsp and IdEspecialidad != @IdEspecialidad)
	begin
		update Especialidades set
		NombreEsp= @NombreEsp,
		RequisitosAcademicos = @RequisitosAcademicos
		where IdEspecialidad = @IdEspecialidad

		set @Respuesta = 1
	end
	else
		set @Mensaje = 'Especialidad existe'
end

--exec
go

declare @Respuesta bit
declare @Mensaje varchar (200)

exec spEditarEspecialidad
@IdEspecialidad= 3, 
@NombreEsp= 'Odontología', 
@RequisitosAcademicos= 'Licenciatura', 
@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Especialidades;
select *from Funcionarios
select *from PuestoTrabajo

--******************************************************************************
--CONTROL ACCESO
--******************************************************************************
--EditarControl Acceso
go
create or alter proc spEditarControlAcceso(
	@IdAccesoSistema int,
	@IdFuncionario int,
	@Clave varchar(max),
	@NivelAcceso int,
	@Respuesta bit output,
	@Mensaje varchar (200) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ' '

	if not exists(select *from AccesoSistema  where Clave = @Clave and IdAccesoSistema != @IdAccesoSistema)
	begin
		update AccesoSistema set
		IdFuncionario= @IdFuncionario,
		Clave = @Clave,
		NivelAcceso= @NivelAcceso
		where IdAccesoSistema = @IdAccesoSistema

		set @Respuesta = 1
	end
	else
		set @Mensaje = 'Funcionario existe'
end

--exec
go

declare @Respuesta bit
declare @Mensaje varchar (200)

exec spEditarControlAcceso
@IdAccesoSistema= 2, 
@IdFuncionario= 3, 
@Clave='123',
@NivelAcceso= 1, 
@Respuesta = @Respuesta output,
@Mensaje= @Mensaje output

select @Respuesta
select @Mensaje 

select *from Especialidades;
select *from Funcionarios
select *from PuestoTrabajo
select *from Especialistas;
select *from FuncionariosEspecialidades;


Insert into AccesoSistema( IdFuncionario, Clave, NivelAcceso) values (@IdFuncionario, @Clave, @NivelAcceso)

Insert into Especialistas(IdEspecialidad) values (1),
												(2);

Insert into FuncionariosEspecialidades(IdFuncionario, IdEspecialidad) values
(6,1),
(3,1),
(7,2);

Insert into FuncionariosEspecialidades(IdFuncionario, IdEspecialidad) values
(3,1);


select e2.IdEspecialista, f.Nombre, f.PrimerApellido, f.SegundoApellido, e.NombreEsp, h.Dia, h.Hora_inicio, h.Hora_fin
from Funcionarios f 
inner join FuncionariosEspecialidades f1 on f.IdFuncionario= f1.IdFuncionario
inner join Especialidades e on f1.IdEspecialidad = e.IdEspecialidad
inner join Especialistas e2 on f1.IdEspecialidad= e2.IdEspecialidad
inner join PuestoTrabajo p on p.IdPuestoTrabajo = f.IdPuestoTrabajo
inner join HorariosEspecialistas h on h.IdEspecialista= e2.IdEspecialista
where p.Nombre= 'Médico' and NombreEsp='Medicina General';

Select *from HorariosEspecialistas;

Insert into HorariosEspecialistas(IdEspecialista, Dia, Hora_inicio, Hora_fin) values
(1,'L', '7:00', '7:30'),
(1,'L', '8:00', '8:30'),
(1,'J', '7:00', '7:30'),
(1,'V', '7:00', '7:30'),
(2,'L', '9:00', '9:30'),
(2,'K', '8:00', '8:30'),
(2,'M', '10:00', '10:30'),
(2,'V', '3:00', '3:30');

select NombreEsp from Especialidades;