-- Cursor para obtener todos los accesorios 

DECLARE
    CURSOR c_accesorios IS
        SELECT ID_ACCESORIO, NOMBRE, DESCRIPCION, PRECIO, STOCK, ID_CATEGORIA
        FROM DBADMIN.ACCESORIO;
    r_accesorio c_accesorios%ROWTYPE;
BEGIN
    OPEN c_accesorios;
    LOOP
        FETCH c_accesorios INTO r_accesorio;
        EXIT WHEN c_accesorios%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_accesorio.ID_ACCESORIO || ' Nombre: ' || r_accesorio.NOMBRE || 
                             ' Descripción: ' || r_accesorio.DESCRIPCION || ' Precio: ' || r_accesorio.PRECIO ||
                             ' Stock: ' || r_accesorio.STOCK || ' ID Categoría: ' || r_accesorio.ID_CATEGORIA);
    END LOOP;
    CLOSE c_accesorios;
END;
/

-- Cursor para obtener categorías activas

DECLARE
    CURSOR c_categorias_activas IS
        SELECT ID_CATEGORIA, NOMBRE, DESCRIPCION
        FROM DBADMIN.CATEGORIA
        WHERE ACTIVO = 1;
    r_categoria c_categorias_activas%ROWTYPE;
BEGIN
    OPEN c_categorias_activas;
    LOOP
        FETCH c_categorias_activas INTO r_categoria;
        EXIT WHEN c_categorias_activas%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_categoria.ID_CATEGORIA || ' Nombre: ' || r_categoria.NOMBRE ||
                             ' Descripción: ' || r_categoria.DESCRIPCION);
    END LOOP;
    CLOSE c_categorias_activas;
END;
/

-- Cursor para obtener clientes activos

DECLARE
    CURSOR c_clientes_activos IS
        SELECT ID_CLIENTE, NOMBRE, APELLIDO, TELEFONO, CORREO, DIRECCION
        FROM DBADMIN.CLIENTE
        WHERE ACTIVO = 1;
    r_cliente c_clientes_activos%ROWTYPE;
BEGIN
    OPEN c_clientes_activos;
    LOOP
        FETCH c_clientes_activos INTO r_cliente;
        EXIT WHEN c_clientes_activos%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_cliente.ID_CLIENTE || ' Nombre: ' || r_cliente.NOMBRE ||
                             ' Apellido: ' || r_cliente.APELLIDO || ' Teléfono: ' || r_cliente.TELEFONO ||
                             ' Correo: ' || r_cliente.CORREO || ' Dirección: ' || r_cliente.DIRECCION);
    END LOOP;
    CLOSE c_clientes_activos;
END;
/


-- Cursor para obtener todos los productos de una categoría específica

DECLARE
    CURSOR c_productos_por_categoria IS
        SELECT ID_PRODUCTO, DESCRIPCION, PRECIO, STOCK, ID_CATEGORIA
        FROM DBADMIN.PRODUCTO
        WHERE ID_CATEGORIA = 1; -- Cambia el ID de categoría según lo necesites
    r_producto c_productos_por_categoria%ROWTYPE;
BEGIN
    OPEN c_productos_por_categoria;
    LOOP
        FETCH c_productos_por_categoria INTO r_producto;
        EXIT WHEN c_productos_por_categoria%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_producto.ID_PRODUCTO || ' Descripción: ' || r_producto.DESCRIPCION ||
                             ' Precio: ' || r_producto.PRECIO || ' Stock: ' || r_producto.STOCK || 
                             ' ID Categoría: ' || r_producto.ID_CATEGORIA);
    END LOOP;
    CLOSE c_productos_por_categoria;
END;
/

-- Cursor para obtener todos los pedidos de un cliente específico

DECLARE
    CURSOR c_pedidos_por_cliente IS
        SELECT ID_PEDIDO, FECHA_PEDIDO, ESTADO
        FROM DBADMIN.PEDIDO
        WHERE ID_CLIENTE = 1; -- Se puede cambiar el id del cliente para el que se necesite
    r_pedido c_pedidos_por_cliente%ROWTYPE;
BEGIN
    OPEN c_pedidos_por_cliente;
    LOOP
        FETCH c_pedidos_por_cliente INTO r_pedido;
        EXIT WHEN c_pedidos_por_cliente%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_pedido.ID_PEDIDO || ' Fecha: ' || r_pedido.FECHA_PEDIDO ||
                             ' Estado: ' || r_pedido.ESTADO);
    END LOOP;
    CLOSE c_pedidos_por_cliente;
END;
/

-- Cursor para obtener todas las devoluciones de un cliente específico

DECLARE
    CURSOR c_devoluciones_por_cliente IS
        SELECT ID_DEVOLUCION, ID_PRODUCTO, FECHA_DEVOLUCION, CANTIDAD, MOTIVO
        FROM DBADMIN.DEVOLUCION
        WHERE ID_CLIENTE = 1; -- Se puede cambiar el id del cliente segun se necesite
    r_devolucion c_devoluciones_por_cliente%ROWTYPE;
BEGIN
    OPEN c_devoluciones_por_cliente;
    LOOP
        FETCH c_devoluciones_por_cliente INTO r_devolucion;
        EXIT WHEN c_devoluciones_por_cliente%NOTFOUND;
        

        DBMS_OUTPUT.PUT_LINE('ID: ' || r_devolucion.ID_DEVOLUCION || ' Producto: ' || r_devolucion.ID_PRODUCTO ||
                             ' Fecha: ' || r_devolucion.FECHA_DEVOLUCION || ' Cantidad: ' || r_devolucion.CANTIDAD ||
                             ' Motivo: ' || r_devolucion.MOTIVO);
    END LOOP;
    CLOSE c_devoluciones_por_cliente;
END;
/

-- Cursor para obtener empleados activos en una sucursal específica

DECLARE
    CURSOR c_empleados_por_sucursal IS
        SELECT ID_EMPLEADO, NOMBRE, APELLIDO, CORREO, TELEFONO, ACTIVO, ID_USUARIO
        FROM DBADMIN.EMPLEADO
        WHERE ID_SUCURSAL = 1 AND ACTIVO = 1; -- Se puede cambiar el id de la sucursal segun se necesite
    r_empleado c_empleados_por_sucursal%ROWTYPE;
BEGIN
    OPEN c_empleados_por_sucursal;
    LOOP
        FETCH c_empleados_por_sucursal INTO r_empleado;
        EXIT WHEN c_empleados_por_sucursal%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_empleado.ID_EMPLEADO || ' Nombre: ' || r_empleado.NOMBRE ||
                             ' Apellido: ' || r_empleado.APELLIDO || ' Correo: ' || r_empleado.CORREO ||
                             ' Teléfono: ' || r_empleado.TELEFONO || ' ID Usuario: ' || r_empleado.ID_USUARIO);
    END LOOP;
    CLOSE c_empleados_por_sucursal;
END;
/

-- Cursor para obtener ventas de un cliente específico

DECLARE
    CURSOR c_ventas_por_cliente IS
        SELECT ID_VENTA, SUBTOTAL, IVA, TOTAL, ID_PRODUCTO
        FROM DBADMIN.VENTA
        WHERE ID_CLIENTE = 1; -- Se cambia el id de cliente segun se necesite
    r_venta c_ventas_por_cliente%ROWTYPE;
BEGIN
    OPEN c_ventas_por_cliente;
    LOOP
        FETCH c_ventas_por_cliente INTO r_venta;
        EXIT WHEN c_ventas_por_cliente%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_venta.ID_VENTA || ' Subtotal: ' || r_venta.SUBTOTAL ||
                             ' IVA: ' || r_venta.IVA || ' Total: ' || r_venta.TOTAL ||
                             ' ID Producto: ' || r_venta.ID_PRODUCTO);
    END LOOP;
    CLOSE c_ventas_por_cliente;
END;
/


-- Cursor para obtener todos los roles

DECLARE
    CURSOR c_roles IS
        SELECT ID_ROL, NOMBRE
        FROM DBADMIN.ROL;
    r_rol c_roles%ROWTYPE;
BEGIN
    OPEN c_roles;
    LOOP
        FETCH c_roles INTO r_rol;
        EXIT WHEN c_roles%NOTFOUND;
        
        DBMS_OUTPUT.PUT_LINE('ID: ' || r_rol.ID_ROL || ' Nombre: ' || r_rol.NOMBRE);
    END LOOP;
    CLOSE c_roles;
END;
/
