--Accesorios
BEGIN
    registraraccesorio(
        p_nombre => 'Monitor gigabyte',
        p_descripcion => 'Monitor 27 pulgadas,144hz',
        p_precio => 25,
        p_stock => 150,
        p_id_categoria => 1
    );
END;
/
SELECT*FROM ACCESORIO

SET SERVEROUTPUT ON;
VARIABLE c REFCURSOR;

BEGIN
    consultarAccesorios(:c);
END;
/

PRINT c;


BEGIN
    eliminarAccesorio(p_id_accesorio => 1);
END;
/


SET SERVEROUTPUT ON;  
BEGIN
    modificarAccesorio(
        p_id_accesorio => 1,
        p_nombre => 'Nuevo nombre',
        p_descripcion => 'Nueva descripción',
        p_precio => 99.99,
        p_stock => 50,
        p_id_categoria => 1
    );
END;
/


SELECT * FROM usuario;



-----------Usuarios--------
BEGIN
    registrarusuario(
        p_username => 'Sebastian',
        p_password => 'password123',
        p_nombre => 'Sebastian',
        p_apellido => 'Coto',
        p_correo => 'scoto@example.com',
        p_telefono => 1234567890
    );
END;
/


SELECT * FROM usuario;
SELECT * FROM Cliente;

SET SERVEROUTPUT ON;
VARIABLE c REFCURSOR;

BEGIN
    consultarusuarios(:c);
END;
/

PRINT c;

BEGIN
    eliminarUsuario(44);
END;
/


BEGIN
    modificarUsuario(44, 'jdoe_new', 'John', 'Doe', 'jdoe_new@example.com', 9876543210);
END;
/


-----Categoria--------

BEGIN
    registrarCategoria('Electrónica', 1, 'Artículos de electrónica y gadgets.');
END;
/

SELECT * FROM categoria;


VARIABLE c REFCURSOR;
BEGIN
    consultarCategoria(:c);
END;
/
PRINT c;

BEGIN
    eliminarCategoria(1);  
END;
/

BEGIN
    modificarCategoria(1, 'Electrónica y Gadgets', 1, 'Artículos electrónicos y gadgets actualizados.');
END;
/


-------Detalle Pedido--------
DECLARE
    v_id_pedido NUMBER := 1; 
    v_id_producto NUMBER := 1;
    v_cantidad NUMBER := 5;
    v_precio NUMBER := 10.5;
END;
/

VARIABLE c REFCURSOR;
BEGIN
    consultarDetallePedido(:c);
END;
/


BEGIN
    eliminarDetallePedido(1);  
END;
/

BEGIN
    modificarDetallePedido(1, 1,7,20);
END;
/

-----Devolucion-------
BEGIN
    registrarDevolucion(
        p_id_cliente => 1, 
        p_id_producto => 1,
        p_cantidad => 1, 
        p_motivo => 'Defectuoso' 
    );
END;
/

VARIABLE c REFCURSOR;
BEGIN
    consultarDevoluciones(:c);
END;
/

BEGIN
    eliminarDevoluciones(1);  
END;
/

BEGIN
    modificarDevolucion(1, 1,7,Cambio de color);
END;
/

-----Pedidos---------
BEGIN
    registrarPedido(
        p_id_cliente => 1, 
        p_fecha_pedido => SYSDATE,  
        p_estado => 1              
    );
END;
/

VARIABLE c REFCURSOR;
BEGIN
    consultarPedidos(:c);
END;
/
PRINT c;

BEGIN
    eliminarPedidos(1);  
END;
/


BEGIN
    modificarPedido(
        p_id_pedido => 2,             
        p_fecha_pedido => SYSDATE,   
        p_estado => 0               
    );
END;
/

----Producto-----
BEGIN
    registrarProducto('Producto de prueba', 100.50, 10, 1, 1, 1);
END;


VARIABLE c REFCURSOR;
BEGIN
    consultarProductos(:c);
END;
/
PRINT c;


BEGIN
    eliminarProducto(1);  
END;
/


BEGIN
    modificarProducto('Producto Modificado',100.30,2,1,1,0);
END;
/
---Rol---
BEGIN
    registrarRol(
        p_id_rol => 4, 
        p_Nombre => 'Gerente',  
        p_id_usuario => 1              
    );
END;
/


VARIABLE c REFCURSOR;
BEGIN
    consultarRol(:c);
END;
/
PRINT c;

BEGIN
    eliminarRol(4);  
END;
/


BEGIN
    modificarRol(
        p_id_rol => 4,             
        p_Nombre => 'Viejo',   
        p_id_usuario => 3               
    );
END;
/

--Sucursal---
BEGIN
    registrarSucursal(
        p_id_sucursal => 2, 
        p_Nombre => 'Cartago',  
        p_ubicacion => '100m sur de la iglesia',
        p_telefono => 12345678
    );
END;
/


VARIABLE c REFCURSOR;
BEGIN
    consultarSucursal(:c);
END;
/
PRINT c;

BEGIN
    eliminarSucursal(2);  
END;
/


BEGIN
    modificarSucursal(
        p_id_sucursal => 2, 
        p_Nombre => 'SJO',  
        p_ubicacion => 'nADA',
        p_telefono => 12345678
    );
END;
/
-----Venta----
BEGIN
    registrarVenta(
        p_id_venta => 1, 
        p_subtotal => 1000,  
        p_iva => 0.13,
        p_id_cliente => 1,
        p_id_producto => 1
    );
END;
/


VARIABLE c REFCURSOR;
BEGIN
    consultarVenta(:c);
END;
/
PRINT c;

BEGIN
    eliminarVenta(1);  
END;
/


BEGIN
    modificarVenta(
        p_id_venta => 1, 
        p_subtotal => 2000,  
        p_iva => 0.13,
        p_total => NULL  
    );
END;
/