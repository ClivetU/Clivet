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
alter table detalleVenta add MetodoPago int, foreign key (MetodoPago) references MPago(IDPago) 

insert into Cliente values('TIENDAS CHEDRAUI, S.A. DE C.V.', 'AV. CONSTITUYENTES 1150 Col. LOMAS ALTAS, DELEGACION MIGUEL HIDALGO, MEXICO, D.F., MEXICO. C.P. 11950','TCH850701RM1');

select dv.idCompra as Folio, Pv.Proveedor, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago, U.Usuario from Compra as C, MPago as mp, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago;

select dv.idVenta as Folio, C.Cliente, V.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago, U.Usuario from Venta as V, MPago as mp, Cliente as C, Usuario as U, detalleVenta as dv, Producto as P where V.idCliente=C.idCliente and V.idUsuario=U.idUsuario and V.idVenta = dv.idVenta and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago;


select * from Producto;
select*from Proveedor;
select*from conexion;
create table conexion
(Producto varchar(100),
Proveedor varchar(100)
)

insert into conexion values ('Hielo Grande','ROCOS'),('Hielo Medio','AMERICAS'),('hielo','ICEMAKER'),('RRRRRRR','Proveedor1');

update Producto set Unidad='bolsa' where idProducto=4;



declare @prueba varchar(100);select @prueba = Producto from conexion where Producto='hilo'; if @prueba is not null (select*from conexion)

select p.Producto,p.Existencia,p.Precio,p.Unidad,c.Proveedor from Producto as p, conexion as c where p.Producto!='' and p.Unidad!='NULL' and c.Producto=p.Producto