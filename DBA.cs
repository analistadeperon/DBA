USE [master];
GO

CREATE DATABASE [VendasDb];
GO

USE [VendasDb];
GO

CREATE TABLE [dbo].[Usuario]
	(
		[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
		[Usuario] VARCHAR(50) NOT NULL, 
		[Senha] VARCHAR(50) NOT NULL
	);
GO

INSERT 
	INTO [dbo].[Usuario]([Usuario], [Senha])
	VALUES ('Dom', '123456'), 
		   ('jonh', '789012'), 
		   ('IOS', '345678');
GO
