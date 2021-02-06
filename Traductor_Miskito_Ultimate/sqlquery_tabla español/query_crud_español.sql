-- procedimiento mostrar
create proc spmostrar_audio
as
select top 100 * from Audio
order by idaudio desc
go

-- create procedimiento buscar palabra
create proc spbuscar_audio
@buscaraudio varchar(50)
as
select * from Audio
where nombre like @buscaraudio + '%'
go

--procedimiento insertar
create proc insertar_audio
@idaudio int output,
@nombre varchar(50),
@direccion varchar(max)
as
insert into Audio (nombre,direccion)
values (@nombre, @direccion)
go


--procedimiento editar palabra
create proc speditar_audio
@idaudio int,
@nombre varchar(50),
@direccion varchar(max)
as
update Audio set nombre= @nombre,
direccion = @direccion
where idaudio = @idaudio
go


--procedimiento eliminar palabra
create proc eliminar_audio
@idaudio int
as
delete  from Audio
where idaudio= @idaudio
go
