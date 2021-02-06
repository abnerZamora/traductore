create proc spmostrar_miskito
as
SELECT top 100 dbo.Español.idespañol,  dbo.Español.Miskito,dbo.Español.Español, dbo.Español.imagen, dbo.Español.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Español ON dbo.Audio.idaudio = dbo.Español.idaudio
order by dbo.Español.idespañol desc
go


create proc spbuscar_miskito
@buscarmiskito varchar(50)
as
SELECT dbo.Español.idespañol, dbo.Español.Miskito,dbo.Español.Español, dbo.Español.imagen, dbo.Español.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Español ON dbo.Audio.idaudio = dbo.Español.idaudio
where dbo.Español.Miskito like @buscarmiskito + '%'
order by dbo.Español.idespañol desc
go