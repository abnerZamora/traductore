USE [traductor]
GO
/****** Object:  StoredProcedure [dbo].[speditar_palabra]    Script Date: 15/6/2019 12:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[speditar_palabra]
@idespañol int,
@palabraespañol varchar(50),
@descripcion varchar(256)
as
update español set Español= @palabraespañol,
Miskito = @descripcion
where idEspañol = @idespañol
