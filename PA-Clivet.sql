Use Clivet

CREATE PROCEDURE InicioRegistro
    @Username varchar(20),
    @Contraseña varchar(20),
    @Nombre varchar(40),
    @ApellidoP varchar(40),
    @ApellidoM varchar(40),
	@Nivel varchar(40)
AS
    SET NOCOUNT ON;
    DECLARE @Name varchar(20);
    DECLARE @Estado varchar(50);
	DECLARE @PruebaN varchar(40);
    DECLARE @Lv int;
    SELECT @Lv = idNivelAcceso FROM CatNivelAcceso
              WHERE TipoNivelAcceso = @Nivel;
    SELECT @Name = Usuario FROM Usuario
              WHERE Usuario = @Username;
	SELECT @PruebaN = NombreUsuario FROM Usuario
		      WHERE NombreUsuario = @Nombre AND ApellidoPUsuario = @ApellidoP AND ApellidoMUsuario = @ApellidoM;
    IF @Username = @Name
      SET @Estado = 'Ya existe este usuario';
    ELSE
	    IF @PruebaN = @Nombre
          SET @Estado = 'Ya existe esta persona';
        ELSE
           BEGIN
            INSERT INTO Usuario VALUES
	          (@Username,@Contraseña,@Nombre,@ApellidoP,@ApellidoM,@Lv)
           SET @Estado = 'Se registro Correctamente';
           END
    SELECT @Estado as Estado;
GO

EXECUTE InicioRegistro 'Neto','enf3','Ernesto','Nava','Fernández','Administrador';



CREATE PROCEDURE InicioLogin
    @Username varchar(20),
    @Contraseña varchar(20)
AS
    SET NOCOUNT ON;
    DECLARE @Pass varchar(20);
    DECLARE @Acces bit;
    SELECT @Pass = Contraseña FROM Usuario
                  WHERE Usuario = @Username;
    IF @Contraseña = @Pass
        SET @Acces = 1;
    ELSE
        SET @Acces = 0;
    SELECT @Acces as Acces;
    RETURN
GO

EXEC InicioLogIn 'NETo','enf3';

alter PROCEDURE NivelesAcces
AS
	SET NOCOUNT ON;
	select * from CatNivelAcceso;
GO

create PROCEDURE LogInNivelesAcces
	@Username varchar(20)
AS
	SET NOCOUNT ON;
	declare @nivel int;
	declare @Acces int;
	SELECT @nivel = idNivelAcceso FROM Usuario where Usuario = @Username;
    SELECT @nivel as Acces;
GO

select * from CatNivelAcceso

exec LogInNivelesAcces 'user1'

select * from usuario

alter procedure RegistroCliente
	@Cliente varchar(100),
	@Ciudad varchar(100),
	@RFC varchar(200),
	@Direccion varchar(800)
AS
	SET NOCOUNT ON;
	declare @idciudad int;
	declare @PruebaCLiente varchar(100);
	DECLARE @Estado varchar(50);
	select @idciudad = idCiudad from CatCiudad where Ciudad=@Ciudad;
	select @PruebaCLiente = Cliente from Cliente where Cliente = @Cliente;
	if @Cliente = @PruebaCLiente
		set @Estado = 'Este Cliente ya existe'; 
	else
		begin
		  insert into Cliente values (@Cliente,@Direccion,@RFC, @idciudad);
		  set @Estado = 'El Cliente se ha registrado exitosamente';
		end
	select @Estado as Estado;
GO

exec RegistroCliente 'Cliente2', 'Tampico'
select * from CatCiudad
select * from Cliente

alter procedure RegistroProveedor
	@Proveedor varchar(100),
	@Ciudad varchar(100),
	@RFC varchar(200),
	@Direccion varchar(800)
AS
	SET NOCOUNT ON;
	declare @idciudad int;
	declare @PruebaProveedor varchar(100);
	DECLARE @Estado varchar(50);
	select @idciudad = idCiudad from CatCiudad where Ciudad=@Ciudad;
	select @PruebaProveedor = Proveedor from Proveedor where Proveedor = @Proveedor;
	if @Proveedor = @PruebaProveedor
		set @Estado = 'Este Proveedor ya existe'; 
	else
		begin
		  insert into Proveedor values (@Proveedor, @idciudad,@Direccion,@RFC);
		  set @Estado = 'El Proveedor se ha registrado exitosamente';
		end
	select @Estado as Estado;
GO
exec RegistroProveedor 'Adi','Tampico','2rw42er4wq','codig 678 col. herreros'
select*from Proveedor

alter procedure RegistroProducto
	@Producto varchar(100),
	@Existencia int,
	@Precio money,
	@Unidad varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaProducto varchar(100);
	DECLARE @Estado varchar(50);
	select @PruebaProducto = Producto from Producto where Producto = @Producto;
	if @Producto = @PruebaProducto
		set @Estado = 'Este Producto ya existe'; 
	else
		begin
		  insert into Producto values (@Producto,@Existencia,@Precio,@Unidad);
		  set @Estado = 'El Producto se ha registrado exitosamente';
		end
	select @Estado as Estado;
GO

delete Usuario where Usuario='net'
select * from Usuario

CREATE TYPE TableParameterType AS TABLE
(Producto nvarchar(100));
GO

create procedure EliminarUsuario
	@valor varchar(100)
as
	SET NOCOUNT ON;
	declare @estado varchar(50);
	declare @pruebaUser varchar(100);
	select @pruebaUser = Usuario from Usuario where Usuario = @valor;
	if(@pruebaUser=@valor)
	begin
	  delete Usuario where Usuario=@valor;
	  set @estado='Se ha eliminado este Usuario Correctamente';
	end
	else
	  set @estado='Este usuario no existe';
	select @estado as Estado
go

exec EliminarUsuario


alter PROCEDURE BuscarUsuarios
    @Texto varchar(100)
AS
    SELECT TOP(4) Usuario from Usuario where Usuario like @Texto+'%' group by Usuario, IdUsuario order by Usuario asc;
GO

exec BuscarUsuarios 'n'

select * from usuario where usuario = 'neto3'

create procedure BotonUsuario
	@Use varchar(100)
AS
	SET NOCOUNT ON;
	select Usuario,Contraseña,NombreUsuario,ApellidoPUsuario,ApellidoMUsuario,TipoNivelAcceso from Usuario as U, CatNivelAcceso as N
	where U.idNivelAcceso=N.idNivelAcceso and Usuario=@Use
GO

exec BotonUsuario 'neto3'


alter procedure ModifCliente
	@Cliente varchar(100),
	@Ciudad varchar(100),
	@RFC varchar(200),
	@Direccion varchar(800)
AS
	SET NOCOUNT ON;
	declare @idciudad int;
	declare @PruebaCLiente varchar(100);
	DECLARE @Estado varchar(50);
	select @idciudad = idCiudad from CatCiudad where Ciudad=@Ciudad;
	select @PruebaCLiente = Cliente from Cliente where Cliente = @Cliente;
	if @Cliente != @PruebaCLiente
		set @Estado = 'Este Cliente no existe'; 
	else
		begin
		  update Cliente set idCiudad=@idciudad, RFC=@RFC, Direccion=@Direccion where Cliente = @Cliente;
		  set @Estado = 'El Cliente se ha modificado exitosamente';
		end
	select @Estado as Estado;
GO

alter procedure EliminCliente
	@Cliente varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaCLiente varchar(100);
	DECLARE @Estado varchar(50);
	select @PruebaCLiente = Cliente from Cliente where Cliente = @Cliente;
	if @Cliente != @PruebaCLiente
		set @Estado = 'Este Cliente no existe'; 
	else
		begin
		  delete Cliente where Cliente = @Cliente;
		  set @Estado = 'El Cliente se ha eliminado exitosamente';
		end
	select @Estado as Estado;
GO

select*from CatCiudad
select*from Cliente
exec RegistroCliente 'Cliente1', 'Tampico';
exec ModifCliente 'Cliente1', 'Tampico';
exec EliminCliente 'Cliente1'
 

 alter procedure ModifProveedor
	@Proveedor varchar(100),
	@Ciudad varchar(100),
	@RFC varchar(200),
	@Direccion varchar(800)
AS
	SET NOCOUNT ON;
	declare @idciudad int;
	declare @PruebaProveedor varchar(100);
	DECLARE @Estado varchar(50);
	select @idciudad = idCiudad from CatCiudad where Ciudad=@Ciudad;
	select @PruebaProveedor = Proveedor from Proveedor where Proveedor = @Proveedor;
	if @Proveedor != @PruebaProveedor
		set @Estado = 'Este Proveedor no existe'; 
	else
		begin
		  update Proveedor set idCiudad=@idciudad, RFC=@RFC,Direccion=@Direccion where Proveedor=@Proveedor;
		  set @Estado = 'El Proveedor se ha modificado exitosamente';
		end
	select @Estado as Estado;
GO


alter procedure ModifProducto
	@Producto varchar(100),
	@Existencia int,
	@Precio money,
	@Unidad varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaProducto varchar(100);
	DECLARE @Estado varchar(50);
	select @PruebaProducto = Producto from Producto where Producto = @Producto;
	if @Producto != @PruebaProducto
		set @Estado = 'Este Producto no existe'; 
	else
		begin
		  update Producto set Existencia=@Existencia, Precio=@Precio, Unidad= @Unidad where Producto=@Producto;
		  set @Estado = 'El Producto se ha modificado exitosamente';
		end
	select @Estado as Estado;
GO

select * from Venta
select *from detalleVenta
select * from Compra
select *from detalleCompra
select*from Proveedor
select*from Producto
select*from Usuario
select*from Cliente
select*from Sucursal
insert into Sucursal values('Sucursal1', 1)
insert into Proveedor values('Proveedor1',1)
insert into Compra Values(2,1,1,'2017-22-06 11:50:38.843')
insert into detalleCompra values(2,5,(280*5),1)

select V.idVenta, C.Cliente, U.Usuario, V.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal from Venta as V, Cliente as C, Usuario as U, detalleVenta as dv, Producto as P where V.idCliente=C.idCliente and V.idUsuario=U.idUsuario and V.idVenta = dv.idVenta and dv.idProducto=P.idProducto;

select C.idCompra, Pv.Proveedor, U.Usuario, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal from Compra as C, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto;

alter procedure RegistroVenta
	@Cliente varchar(100),
	@Usuario varchar(100),
	@fecha varchar(100),
	@Producto varchar(100),
	@Unidad int,
	@MetPago varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaProducto varchar(100);
	declare @PruebaUsuario varchar(100);
	declare @PruebaCliente varchar(100);
	declare @PruebaPago varchar(100);
	declare @idCliente int;
	declare @idPago int;
	declare @idUsuario int;
	declare @idProducto int;
	declare @idVenta int;
	declare @Precio int;
	DECLARE @Estado varchar(50);
	select @PruebaCliente=Cliente, @idCliente = idCliente from Cliente where Cliente=@Cliente;
	select @PruebaUsuario=Usuario, @idUsuario=idUsuario from Usuario where Usuario=@Usuario;
	select @PruebaPago=Pago, @idPago=IDPago from MPago where Pago=@MetPago;
	select @PruebaProducto=Producto, @idProducto=idProducto, @Precio=Precio from Producto where Producto=@Producto;
	if @PruebaCliente != @Cliente
	  set @Estado = 'Este cliente no existe';
	else
	  if @PruebaProducto != @Producto
	    set @Estado = 'Este producto no existe';
	  else
	  if @PruebaPago != @MetPago
	    set @Estado = 'Este metodo de pago no existe';
	  else
	    begin
		insert into Venta values(@idCliente,@idUsuario,1,@fecha);
		select top(1) @idVenta=idVenta from Venta order by idVenta desc;
		insert into detalleVenta values(@idVenta,@Unidad,(@Precio*@Unidad),@idProducto,@idPago);
		set @Estado = 'Se ha registrado correctamente la venta';
		end
	select @Estado as Estado;
GO



alter procedure RegistroCompra
	@Proveedor varchar(100),
	@Usuario varchar(100),
	@fecha varchar(100),
	@Producto varchar(100),
	@Unidad int,
	@MetPago varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaProducto varchar(100);
	declare @PruebaUsuario varchar(100);
	declare @PruebaProveedor varchar(100);
	declare @PruebaPago varchar(100);
	declare @idProveedor int;
	declare @idPago int;
	declare @idUsuario int;
	declare @idProducto int;
	declare @idCompra int;
	declare @Precio int;
	DECLARE @Estado varchar(50);
	select @PruebaProveedor=p.Proveedor, @idProveedor = p.idProveedor from Proveedor as p where p.Proveedor=@Proveedor;
	select @PruebaUsuario=Usuario, @idUsuario=idUsuario from Usuario where Usuario=@Usuario;
	select @PruebaPago=Pago, @idPago=IDPago from MPago where Pago=@MetPago;	
	select @PruebaProducto=Producto, @idProducto=idProducto, @Precio=Precio from Producto where Producto=@Producto;
	if @PruebaProveedor != @Proveedor
	  set @Estado = 'Este proveedor no existe';
	else
	  if @PruebaProducto != @Producto
	    set @Estado = 'Este producto no existe';
	  else
	  if @PruebaPago != @MetPago
	    set @Estado = 'Este metodo de pago no existe';
	  else
	    begin
		insert into Compra values(@idProveedor,@idUsuario,1,@fecha);
		select top(1) @idCompra=idCompra from Compra order by idCompra desc;
		insert into detalleCompra values(@idCompra,@Unidad,(@Precio*@Unidad),@idProducto,@idPago);
		set @Estado = 'Se ha registrado correctamente la compra';
		end
	select @Estado as Estado;
GO
exec RegistroCompra 'PruebaX','admi','14-08-2018','Hielo Gan',28,'hgfds'
select*from Compra
select*from detalleCompra

select*from detalleCompra;
select*from detalleVenta;
select*from MPago;

CREATE PROCEDURE ModificRegistro
    @Username varchar(20),
    @Contraseña varchar(20),
    @Nombre varchar(40),
    @ApellidoP varchar(40),
    @ApellidoM varchar(40),
	@Nivel varchar(40)
AS
    SET NOCOUNT ON;
    DECLARE @Name varchar(20);
    DECLARE @Estado varchar(50);
	DECLARE @PruebaN varchar(40);
    DECLARE @Lv int;
    SELECT @Lv = idNivelAcceso FROM CatNivelAcceso
              WHERE TipoNivelAcceso = @Nivel;
    SELECT @Name = Usuario FROM Usuario
              WHERE Usuario = @Username;
	SELECT @PruebaN = NombreUsuario FROM Usuario
		      WHERE NombreUsuario = @Nombre AND ApellidoPUsuario = @ApellidoP AND ApellidoMUsuario = @ApellidoM;
    IF @Username != @Name
      SET @Estado = 'Este usuario NO existe';
    ELSE
           BEGIN
		   update Usuario set Contraseña=@Contraseña,NombreUsuario=@Nombre,ApellidoPUsuario=@ApellidoP,ApellidoMUsuario=@ApellidoM,idNivelAcceso=@Lv where Usuario=@Username;            
           SET @Estado = 'El usuario se ha actualizado Correctamente';
           END
    SELECT @Estado as Estado;
GO


alter PROCEDURE BuscadorX
    @Texto varchar(100),
	@num int
AS
   if @num=1
    SELECT TOP(3) Cliente from Cliente where Cliente like @Texto+'%' group by Cliente, idCliente order by Cliente asc;
	else
	if @num=2
	SELECT TOP(3) Producto from Producto where Producto like @Texto+'%' group by Producto, idProducto order by Producto asc;
	else
	if @num=3
	SELECT TOP(3) Pago from MPago where Pago like @Texto+'%' group by Pago, IDPago order by Pago asc;
	else
	if @num=4
	SELECT TOP(3) Proveedor from Proveedor where Proveedor like @Texto+'%' group by Proveedor, idProveedor order by Proveedor asc;
GO



create procedure ElimVenta
	@Cliente varchar(100),
	@Usuario varchar(100),
	@fecha varchar(100),
	@Producto varchar(100),
	@Unidad int,
	@MetPago varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaProducto varchar(100);
	declare @PruebaUsuario varchar(100);
	declare @PruebaCliente varchar(100);
	declare @PruebaPago varchar(100);
	declare @idCliente int;
	declare @idPago int;
	declare @idUsuario int;
	declare @idProducto int;
	declare @idVenta int;
	declare @Precio int;
	DECLARE @Estado varchar(50);
	select @PruebaCliente=Cliente, @idCliente = idCliente from Cliente where Cliente=@Cliente;
	select @PruebaUsuario=Usuario, @idUsuario=idUsuario from Usuario where Usuario=@Usuario;
	select @PruebaPago=Pago, @idPago=IDPago from MPago where Pago=@MetPago;
	select @PruebaProducto=Producto, @idProducto=idProducto, @Precio=Precio from Producto where Producto=@Producto;
	if @PruebaCliente != @Cliente
	  set @Estado = 'Este cliente no existe';
	else
	  if @PruebaProducto != @Producto
	    set @Estado = 'Este producto no existe';
	  else
	  if @PruebaPago != @MetPago
	    set @Estado = 'Este metodo de pago no existe';
	  else
	    begin
		delete Venta where idCliente= @idCliente and idUsuario= @idUsuario and fecha= @fecha;
		select top(1) @idVenta=idVenta from Venta order by idVenta desc;
		delete detalleVenta where idVenta= @idVenta and Cantidad= @Unidad and idProducto= @idProducto;
		set @Estado = 'Se ha registrado correctamente la venta';
		end
	select @Estado as Estado;
GO
create procedure ElimCompra
	@Proveedor varchar(100),
	@Usuario varchar(100),
	@fecha varchar(100),
	@Producto varchar(100),
	@Unidad int,
	@MetPago varchar(100)
AS
	SET NOCOUNT ON;
	declare @PruebaProducto varchar(100);
	declare @PruebaUsuario varchar(100);
	declare @PruebaProveedor varchar(100);
	declare @PruebaPago varchar(100);
	declare @idProveedor int;
	declare @idPago int;
	declare @idUsuario int;
	declare @idProducto int;
	declare @idCompra int;
	declare @Precio int;
	DECLARE @Estado varchar(50);
	select @PruebaProveedor=Proveedor, @idProveedor = idProveedor from Proveedor where Proveedor=@Proveedor;
	select @PruebaUsuario=Usuario, @idUsuario=idUsuario from Usuario where Usuario=@Usuario;
	select @PruebaPago=Pago, @idPago=IDPago from MPago where Pago=@MetPago;
	select @PruebaProducto=Producto, @idProducto=idProducto, @Precio=Precio from Producto where Producto=@Producto;
	if @PruebaProveedor != @Proveedor
	  set @Estado = 'Este proveedor no existe';
	else
	  if @PruebaProducto != @Producto
	    set @Estado = 'Este producto no existe';
	  else
	  if @PruebaPago != @MetPago
	    set @Estado = 'Este metodo de pago no existe';
	  else
	    begin
		delete Compra where idProveedor= @idProveedor and idUsuario= @idUsuario and fecha= @fecha;
		select top(1) @idCompra=idCompra from Compra order by idCompra desc;
		delete detalleCompra where idCompra= @idCompra and cantidad= @Unidad and idProducto= @idProducto;
		set @Estado = 'Se ha registrado correctamente la compra';
		end
	select @Estado as Estado;
GO

select V.idVenta, C.Cliente, U.Usuario, V.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago from Venta as V, MPago as mp, Cliente as C, Usuario as U, detalleVenta as dv, Producto as P where V.idCliente=C.idCliente and V.idUsuario=U.idUsuario and V.idVenta = dv.idVenta and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago;
select C.idCompra, Pv.Proveedor, U.Usuario, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago from Compra as C, MPago as mp, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago and U.Usuario like 'hol%' order by U.Usuario asc;