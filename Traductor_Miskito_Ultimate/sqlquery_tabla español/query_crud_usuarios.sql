-- procedimiento mostrar
create proc spmostrar_usuarios
as
select top 100 * from Usuarios
order bY id desc
go

-- create procedimiento buscar palabra
create proc spbuscar_usuario
@buscarusuario varchar(50)
as
select * from Usuarios
where Usuariio like @buscarusuario + '%'
go

--procedimiento insertar
create proc insertar_usuario
@id int output,
@usuario varchar(20),
@contraseña varchar(20),
@nombres varchar(20),
@apellidos varchar(20),
@privilegios varchar(20),
@email varchar(30)
as
insert into Usuarios (id, Usuariio, Contraseña, Nombres, Apellidos,Privilegios,Email)
values (@id, @usuario,@contraseña, @nombres, @apellidos, @privilegios, @email)
go


--procedimiento editar palabra
create proc speditar_usuario
@id int,
@usuario varchar(20),
@contraseña varchar(20),
@nombres varchar(20),
@apellidos varchar(20),
@privilegios varchar(20),
@email varchar(30)
as
update Usuarios set Usuariio= @usuario,
Contraseña = @contraseña, Nombres= @nombres, Apellidos= @apellidos, Privilegios= @privilegios, Email= @email
where id = @id
go


--procedimiento eliminar palabra
create proc eliminar_usuario
@id int
as
delete  from Usuarios
where id= @id
go
