/*
   martes, 4 de julio de 201705:21:51 p. m.
   Usuario: 
   Servidor: NETO\SQLEXPRESS
   Base de datos: Clivet
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Cliente
	DROP CONSTRAINT FK__Cliente__idCiuda__0A9D95DB
GO
ALTER TABLE dbo.Cliente
	DROP CONSTRAINT FK__Cliente__idCiuda__21B6055D
GO
ALTER TABLE dbo.Cliente
	DROP CONSTRAINT FK__Cliente__idCiuda__778AC167
GO
ALTER TABLE dbo.CatCiudad SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Cliente ADD
	Direccion varchar(70) NULL,
	RFC varchar(30) NULL
GO
ALTER TABLE dbo.Cliente
	DROP COLUMN idCiudad
GO
ALTER TABLE dbo.Cliente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


alter table CLiente alter column Direccion varchar(150)

alter table Producto add Unidad varchar(50)

alter table CatCiudad add Estado varchar(80)



create table MPago
(IDPago INT IDENTITY (1,1) PRIMARY KEY,
Pago VARCHAR(50)
)

alter table detalleCompra add MetodoPAgo int, foreign key (MetodoPAgo) references MPago(IDPago) 

insert into Cliente values('TIENDAS CHEDRAUI, S.A. DE C.V.', 'AV. CONSTITUYENTES 1150 Col. LOMAS ALTAS, DELEGACION MIGUEL HIDALGO, MEXICO, D.F., MEXICO. C.P. 11950','TCH850701RM1');
