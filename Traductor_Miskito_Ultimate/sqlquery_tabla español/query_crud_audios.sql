-- procedimiento mostrar
create proc spmostrar_audio
as
SELECT top 100 dbo.audio.idaudio, dbo.audio.nombre, dbo.audio.direccion, dbo.audio.imagen,
 dbo.audio.idespa�ol, dbo.espa�ol.Espa�ol, dbo.espa�ol.Miskito
FROM dbo.audio INNER JOIN dbo.espa�ol ON dbo.audio.idespa�ol = dbo.espa�ol.idEspa�ol
order by dbo.audio.idaudio desc
go

-- create procedimiento buscar palabra
create proc spbuscar_audio
@buscaraudio varchar(50)
as
SELECT dbo.audio.idaudio, dbo.audio.nombre, dbo.audio.direccion, dbo.audio.imagen,
 dbo.audio.idespa�ol, dbo.espa�ol.Espa�ol, dbo.espa�ol.Miskito
FROM dbo.audio INNER JOIN dbo.espa�ol ON dbo.audio.idespa�ol = dbo.espa�ol.idEspa�ol
where dbo.audio.nombre like @buscaraudio + '%'
order by dbo.audio.idaudio desc
go

--procedimiento insertar
create proc insertar_audio
@idaudio int output,
@nombre varchar(50),
@direccion varbinary(max),
@imagen image,
@idespa�ol int
as
insert into audio(nombre,direccion, imagen,idespa�ol)
values (@nombre, @direccion,@imagen,@idespa�ol)
go


--procedimiento editar palabra
create proc speditar_audio
@idaudio int,
@nombre varchar(50),
@direccion varbinary(max),
@imagen image,
@idespa�ol int
as
update audio set nombre= @nombre,
direccion = @direccion,
imagen = @imagen,
idespa�ol= @idespa�ol
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
SELECT top 100 dbo.Espa�ol.idespa�ol, dbo.Espa�ol.Espa�ol, dbo.Espa�ol.Miskito, dbo.Espa�ol.imagen, dbo.Espa�ol.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Espa�ol ON dbo.Audio.idaudio = dbo.Espa�ol.idaudio
order by dbo.Espa�ol.idespa�ol desc
go

create proc spbuscar_palabra
@buscarpalabra varchar(50)
as
SELECT dbo.Espa�ol.idespa�ol, dbo.Espa�ol.Espa�ol, dbo.Espa�ol.Miskito, dbo.Espa�ol.imagen, dbo.Espa�ol.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Espa�ol ON dbo.Audio.idaudio = dbo.Espa�ol.idaudio
where dbo.Espa�ol.Espa�ol like @buscarpalabra + '%'
order by dbo.Espa�ol.idespa�ol desc
go


--procedimiento insertar
create proc insertar_palabra
@idespa�ol int output,
@Espa�ol varchar(50),
@Miskito varchar(50),
@imagen image,
@idaudio int
as
insert into Espa�ol(Espa�ol,Miskito, imagen,idaudio)
values (@Espa�ol, @Miskito,@imagen,@idaudio)
go


--procedimiento editar palabra
create proc speditar_palabra
@idespa�ol int,
@Espa�ol varchar(50),
@Miskito varchar(50),
@imagen image,
@idaudio int
as
update Espa�ol set Espa�ol= @Espa�ol,
Miskito = @Miskito,
imagen = @imagen,
idaudio = @idaudio
where idespa�ol = @idespa�ol
go

--procedimiento eliminar palabra
create proc eliminar_palabra
@idespa�ol int
as
delete  from Espa�ol
where idespa�ol= @idespa�ol
go