use Clivet
select c.Cliente,ca.Ciudad,ca.Estado,c.Direccion,c.RFC from Cliente as c, CatCiudad as Ca where c.IdCiudad=ca.idCiudad


--alter table Cliente add IdCiudad int, foreign key (IdCiudad) references CatCiudad(IdCiudad);

alter table Proveedor add Direccion varchar(150);
alter table Proveedor add RFC varchar (30);

select p.Proveedor,ca.Ciudad,ca.Estado,p.Direccion,p.RFC from Proveedor as p, CatCiudad as ca where p.idCiudad=ca.idCiudad

select*from Proveedor

insert into Cliente values('HELAMI',2, 'AV. LAS TORRES 803 COL. MAYORCA C.P. 13905','TTH350701TS5');
insert into Cliente values('BON-ICE',2, 'SARCONIA 453 COL. DIAMANTE C.P. 78905','KJL54125GF7');
SELECT*FROM CatCiudad;
insert into Proveedor values ('ICESMAKER',2,'COLORADO 324 COL. ARBOLES C.P. 96367','Q0G0F8S808');
INSERT INTO Proveedor VALUES ('MOLDERS',3,'AV. EL POZO 401 COL. RIO ROJO C.P. 81043','BS08VD09T7');
INSERT INTO Proveedor VALUES ('ROCOS',4,'AV. EL PERICO 111 COL. JIMENEZ JIMENEZ C.P. 94527','HS923TF30');
INSERT INTO Proveedor VALUES ('LOS MENDEZ',5,'SIÑUEGOZ 746 COL. DEL MAR C.P. 38729','BNSI8VO87');
INSERT INTO Proveedor VALUES ('AMERICAS',3,'CAMINO ROJO 182 COL. PLATA C.P. 98264','FS077A8F0');
select*from Proveedor

exec RegistroVenta 'Cliente2', 'admin1','10/07/2017','Hielo Grande',7
select*from Producto where Producto='Hielo Grande';
exec RegistroCompra 'Proveedor1','admin1','09/07/2017','Hielo Grande',10;

select C.idCompra, Pv.Proveedor, U.Usuario, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago from Compra as C, MPago as mp, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago;

create procedure ObtenUsuario
as
select Usuario,Contraseña,TipoNivelAcceso as Nivel_Seguridad,NombreUsuario as Nombre, ApellidoPUsuario as Apellido_Paterno,ApellidoMUsuario as Apellido_Materno from Usuario, CatNivelAcceso where Usuario.idNivelAcceso=CatNivelAcceso.idNivelAcceso
go