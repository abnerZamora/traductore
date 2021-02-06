-- procedimiento mostrar
create proc spmostrar_palabra_miskito
as
select top 100 * from miskito
order by idMiskito desc
go

-- create procedimiento buscar palabra
create proc spbuscar_palabra_miskitu
@buscarpalabra varchar(50)
as
select * from miskito
where palabraMiskito like @buscarpalabra + '%'
go

--procedimiento insertar
create proc insertar_palabra_miskito
@idmiskito int output,
@palabramiskito varchar(50),
@descripcion varchar (256)
as
insert into miskito (palabraMiskito,descripcion)
values (@palabramiskito, @descripcion)
go


--procedimiento editar palabra
create proc speditar_palabra_miskito
@idmiskito int,
@palabramiskito varchar(50),
@descripcion varchar(256)
as
update miskito set palabraMiskito= @palabramiskito,
descripcion = @descripcion
where idMiskito = @idmiskito
go


--procedimiento eliminar palabra
create proc eliminar_palabra_miskito
@idmiskito int
as
delete  from miskito
where idMiskito= @idmiskito
go
