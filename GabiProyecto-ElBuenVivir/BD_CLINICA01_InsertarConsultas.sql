use BD_CLINICA01;

select *from Funcionarios;

Insert into Funcionarios(Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo) Values 
(UPPER(@Nombre), UPPER(@PrimerApellido), UPPER(@SegundoApellido), @Cedula, @FechaNacimiento, UPPER(@Genero), @Telefono, UPPER(@Correo), @Estado, @IdPuestoTrabajo)

Select IdFuncionario, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo from Funcionarios

Select IdFuncionario, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo from Funcionarios where Estado=1

Select *from Funcionarios;
select *from HorariosEspecialistas;
select *from Especialistas;

select  * from HorariosEspecialistas h where h.IdEspecialista= 1 and h.Dia= 'L' and ( ('07:00') >= h.Hora_inicio and'07:00' < h.Hora_fin) or ('07:30') > h.Hora_inicio and ('07:30') <=(h.Hora_fin) or ('07:00')<= h.Hora_inicio and '07:30'>=h.Hora_fin