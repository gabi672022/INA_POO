

select *from Funcionarios;

Insert into Funcionarios(Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo) Values 
(UPPER(@Nombre), UPPER(@PrimerApellido), UPPER(@SegundoApellido), @Cedula, @FechaNacimiento, UPPER(@Genero), @Telefono, UPPER(@Correo), @Estado, @IdPuestoTrabajo)

Select IdFuncionario, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo from Funcionarios

Select IdFuncionario, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo from Funcionarios where Estado=1

Select *from Funcionarios;