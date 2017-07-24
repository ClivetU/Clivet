insert into CatNivelAcceso values ('Administrador')
insert into CatNivelAcceso values ('Usuario')

insert into Usuario values ('Admin1','Admin1','Admin','Admin','Admin',1)
insert into Usuario values ('User1','User1','User','User','User',2)

select*from CatNivelAcceso

insert into  CatCiudad values ('Tampico'),('Monterrey'),('Nuevo Leon');

insert into MPago values ('Debito'),('Credito');

-----------------------HECTOR----------------------------------
select*from CatNivelAcceso


insert into  CatCiudad values ('Tampico','Tamaulipas'),('Monterrey','Nuevo Leon'),('Naranjos','Veracruz'),('Poza Rica','Veracruz')
insert into  CatCiudad values ('Mexico, D.F.', 'Mexico');
select*from cliente
insert into Cliente values('TIENDAS CHEDRAUI, S.A. DE C.V.', 'AV. CONSTITUYENTES 1150 Col. LOMAS ALTAS, DELEGACION MIGUEL HIDALGO, C.P. 11950','TCH850701RM1',5);
insert into Cliente values('HELAMI', 'AV. LAS TORRES 803 COL. MAYORCA C.P. 13905','TTH350701TS5',2);
insert into Cliente values('BON-ICE', 'SARCONIA 453 COL. DIAMANTE C.P. 78905','KJL54125GF7',2);
insert into Cliente values('ARTELI', 'AV. LAS FLORES 470 COL. MONTE ALTO C.P. 89255','JHK67543MS6',1);
insert into Cliente values('COCA-COLA', 'GAYTAN 189 COL. MENESTENES C.P. 45890','SGT23546JH1',4);
 
 CREATE PROCEDURE RPCLIENTES
 AS
 select c.Cliente,ca.Ciudad,ca.Estado,c.Direccion,c.RFC from Cliente as c, CatCiudad as Ca where c.IdCiudad=ca.idCiudad
 GO
  EXEC RPCLIENTES



alter table Proveedor add Direccion varchar(150);
alter table Proveedor add RFC varchar (30);

create procedure RPPROVEEDOR
AS
select p.Proveedor,ca.Ciudad,ca.Estado,p.Direccion,p.RFC from Proveedor as p, CatCiudad as ca where p.idCiudad=ca.idCiudad
EXEC RPPROVEEDOR

insert into Proveedor values ('ICESMAKER',2,'COLORADO 324 COL. ARBOLES C.P. 96367','Q0G0F8S808');
INSERT INTO Proveedor VALUES ('MOLDERS',3,'AV. EL POZO 401 COL. RIO ROJO C.P. 81043','BS08VD09T7');
INSERT INTO Proveedor VALUES ('ROCOS',4,'AV. EL PERICO 111 COL. JIMENEZ JIMENEZ C.P. 94527','HS923TF30');
INSERT INTO Proveedor VALUES ('LOS MENDEZ',5,'SIÑUEGOZ 746 COL. DEL MAR C.P. 38729','BNSI8VO87');
INSERT INTO Proveedor VALUES ('AMERICAS',3,'CAMINO ROJO 182 COL. PLATA C.P. 98264','FS077A8F0');


Select * from Catciudad
Select * from CatNivelAcceso
Select * from Cliente
Select * from Compra
Select * from detalleCompra
Select * from DEtalleVenta
Select * from producto
Select * from proveedor
Select * from sucursal
Select * from usuario
Select * from venta

truncate table Cliente