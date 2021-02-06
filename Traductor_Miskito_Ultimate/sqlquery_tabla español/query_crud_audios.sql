-- procedimiento mostrar
create proc spmostrar_audio
as
SELECT top 100 dbo.audio.idaudio, dbo.audio.nombre, dbo.audio.direccion, dbo.audio.imagen,
 dbo.audio.idespañol, dbo.español.Español, dbo.español.Miskito
FROM dbo.audio INNER JOIN dbo.español ON dbo.audio.idespañol = dbo.español.idEspañol
order by dbo.audio.idaudio desc
go

-- create procedimiento buscar palabra
create proc spbuscar_audio
@buscaraudio varchar(50)
as
SELECT dbo.audio.idaudio, dbo.audio.nombre, dbo.audio.direccion, dbo.audio.imagen,
 dbo.audio.idespañol, dbo.español.Español, dbo.español.Miskito
FROM dbo.audio INNER JOIN dbo.español ON dbo.audio.idespañol = dbo.español.idEspañol
where dbo.audio.nombre like @buscaraudio + '%'
order by dbo.audio.idaudio desc
go

--procedimiento insertar
create proc insertar_audio
@idaudio int output,
@nombre varchar(50),
@direccion varbinary(max),
@imagen image,
@idespañol int
as
insert into audio(nombre,direccion, imagen,idespañol)
values (@nombre, @direccion,@imagen,@idespañol)
go


--procedimiento editar palabra
create proc speditar_audio
@idaudio int,
@nombre varchar(50),
@direccion varbinary(max),
@imagen image,
@idespañol int
as
update audio set nombre= @nombre,
direccion = @direccion,
imagen = @imagen,
idespañol= @idespañol
where idaudio = @idaudio
go


--procedimiento eliminar palabra
create proc eliminar_audio
@idaudio int
as
delete  from audio
where idaudio= @idaudio
go



-----------------------------------------------------------

create proc spmostrar_palabra
as
SELECT top 100 dbo.Español.idespañol, dbo.Español.Español, dbo.Español.Miskito, dbo.Español.imagen, dbo.Español.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Español ON dbo.Audio.idaudio = dbo.Español.idaudio
order by dbo.Español.idespañol desc
go

create proc spbuscar_palabra
@buscarpalabra varchar(50)
as
SELECT dbo.Español.idespañol, dbo.Español.Español, dbo.Español.Miskito, dbo.Español.imagen, dbo.Español.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Español ON dbo.Audio.idaudio = dbo.Español.idaudio
where dbo.Español.Español like @buscarpalabra + '%'
order by dbo.Español.idespañol desc
go


--procedimiento insertar
create proc insertar_palabra
@idespañol int output,
@Español varchar(50),
@Miskito varchar(50),
@imagen image,
@idaudio int
as
insert into Español(Español,Miskito, imagen,idaudio)
values (@Español, @Miskito,@imagen,@idaudio)
go


--procedimiento editar palabra
create proc speditar_palabra
@idespañol int,
@Español varchar(50),
@Miskito varchar(50),
@imagen image,
@idaudio int
as
update Español set Español= @Español,
Miskito = @Miskito,
imagen = @imagen,
idaudio = @idaudio
where idespañol = @idespañol
go

--procedimiento eliminar palabra
create proc eliminar_palabra
@idespañol int
as
delete  from Español
where idespañol= @idespañol
go