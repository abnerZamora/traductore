create proc spmostrar_miskito
as
SELECT top 100 dbo.Espa�ol.idespa�ol,  dbo.Espa�ol.Miskito,dbo.Espa�ol.Espa�ol, dbo.Espa�ol.imagen, dbo.Espa�ol.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Espa�ol ON dbo.Audio.idaudio = dbo.Espa�ol.idaudio
order by dbo.Espa�ol.idespa�ol desc
go


create proc spbuscar_miskito
@buscarmiskito varchar(50)
as
SELECT dbo.Espa�ol.idespa�ol, dbo.Espa�ol.Miskito,dbo.Espa�ol.Espa�ol, dbo.Espa�ol.imagen, dbo.Espa�ol.idaudio, dbo.Audio.nombre, dbo.Audio.direccion
FROM dbo.Audio INNER JOIN dbo.Espa�ol ON dbo.Audio.idaudio = dbo.Espa�ol.idaudio
where dbo.Espa�ol.Miskito like @buscarmiskito + '%'
order by dbo.Espa�ol.idespa�ol desc
go