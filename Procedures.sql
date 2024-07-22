--------------------------------------------------------
-- Archivo creado  - jueves-julio-18-2024   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Procedure CONSULTARACCESORIOS
--------------------------------------------------------
SET DEFINE OFF;

CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARACCESORIOS" (
    p_resultado OUT SYS_REFCURSOR
) 
AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        ID_ACCESORIO,
        NOMBRE,
        DESCRIPCION,
        PRECIO,
        STOCK,
        NOMBRE_CATEGORIA
    FROM DBADMIN.VISTAACCESORIOS;
END consultaraccesorios;
/
--------------------------------------------------------
--  DDL for Procedure CONSULTARCATEGORIA
--------------------------------------------------------
set define off;

CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARCATEGORIA" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR SELECT
                             nombre,
                             activo,
                             descripcion
                         FROM DBADMIN.VISTACATEGORIAS;

END consultarCategoria;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARDETALLEPEDIDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARDETALLEPEDIDO" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        ID_DETALLE,
        ID_PEDIDO,
        NOMBRE_PRODUCTO,
        CANTIDAD,
        PRECIO,
        TOTAL
    FROM DBADMIN.VISTADETALLEPEDIDO;
END consultarDetallePedido;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARDEVOLUCIONES
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARDEVOLUCIONES" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        ID_DEVOLUCION,
        ID_CLIENTE,
        ID_PRODUCTO,
        FECHA_DEVOLUCION,
        CANTIDAD,
        MOTIVO
    FROM DBADMIN.VISTADEVOLUCIONES;
END consultarDevoluciones;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARPEDIDOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARPEDIDOS" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_pedido,
        Id_cliente,
        fecha_pedido,
        estado
    FROM DBADMIN.VISTAPEDIDOS;
END consultarPedidos;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARPRODUCTOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARPRODUCTOS" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_producto,
        Descripcion,
        Precio,
        Stock,
        Id_categoria,
        Id_sucursal,
        activo
    FROM DBADMIN.VISTAPRODUCTOS;
END consultarProductos;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARROL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARROL" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_rol,
        Nombre
    FROM DBADMIN.VISTAROLES;
END consultarRol;

/


--------------------------------------------------------
--  DDL for Procedure CONSULTARSUCURSAL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARSUCURSAL" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_sucursal,
        Nombre,
        ubicacion,
        telefono
    FROM DBADMIN.VISTASUCURSALES;
END consultarSucursal;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARUSUARIOPORUSERNAME
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARUSUARIOPORUSERNAME" (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2,
    p_resultado OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        username,
        password,
        nombre,
        apellido,
        correo,
        telefono,
        activo,
        id_rol,
        id_usuario
    FROM
        usuario
    WHERE
        Username = p_username and password=p_password;
END;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARUSUARIOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARUSUARIOS" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR SELECT
                             Username,
                             nombre,
                             apellido,
                             activo
                         FROM
                             DBADMIN.VISTAUSUARIOS;

END;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARVENTA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARVENTA" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_venta,
        subtotal,
        iva,
        total,
        id_cliente,
        id_producto
    FROM
        DBADMIN.VISTAVENTAS;
END consultarVenta;

/
--------------------------------------------------------
--  DDL for Procedure DESACTIVARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."DESACTIVARUSUARIO" (
    p_id_usuario   IN usuario.id_usuario%TYPE
) AS
BEGIN
    UPDATE usuario
    SET 
        activo = 0   -- Set activo column to 0 (deactivate user)
    WHERE id_usuario = p_id_usuario;

    COMMIT;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20001, 'Usuario no encontrado.');
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20002, 'Error al desactivar usuario: ' || SQLERRM);
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARACCESORIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARACCESORIO" (
    p_id_accesorio IN NUMBER
) AS
BEGIN
    DELETE FROM accesorio
    WHERE id_accesorio = p_id_accesorio;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARCATEGORIA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARCATEGORIA" (
    p_id_categoria IN NUMBER
) AS
BEGIN
    DELETE FROM categoria
    WHERE id_categoria = p_id_categoria;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARDETALLEPEDIDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARDETALLEPEDIDO" (
    p_id_detalle IN NUMBER
) AS
BEGIN
    DELETE FROM detalle_pedido
    WHERE id_detalle = p_id_detalle;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARDEVOLUCIONES
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARDEVOLUCIONES" (
    p_id_devolucion IN NUMBER
) AS
BEGIN
    DELETE FROM devolucion
    WHERE id_devolucion = p_id_devolucion;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARPEDIDOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARPEDIDOS" (
    p_id_pedido IN NUMBER
) AS
BEGIN
    DELETE FROM pedido
    WHERE id_pedido = p_id_pedido;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARPRODUCTO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARPRODUCTO" (
    p_id_producto IN NUMBER
) AS
BEGIN
    DELETE FROM producto
    WHERE id_producto = p_id_producto;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARROL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARROL" (
    p_id_rol IN NUMBER
) AS
BEGIN
    DELETE FROM rol
    WHERE id_rol = p_id_rol;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARSUCURSAL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARSUCURSAL" (
    p_id_sucursal IN NUMBER
) AS
BEGIN
    DELETE FROM sucursal
    WHERE id_sucursal = p_id_sucursal;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARUSUARIO" (
    p_id_usuario IN NUMBER
) AS
BEGIN
    DELETE FROM usuario
    WHERE id_usuario = p_id_usuario;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure ELIMINARVENTA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARVENTA" (
    p_id_venta IN NUMBER
) AS
BEGIN
    DELETE FROM venta
    WHERE id_venta = p_id_venta;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARACCESORIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARACCESORIO" (
    p_id_accesorio   IN NUMBER,
    p_nombre         IN VARCHAR2,
    p_descripcion    IN VARCHAR2,
    p_precio         IN NUMBER,
    p_stock          IN NUMBER,
    p_id_categoria   IN NUMBER
) AS
BEGIN
    UPDATE accesorio
    SET 
        nombre = p_nombre,
        descripcion = p_descripcion,
        precio = p_precio,
        stock = p_stock,
        id_categoria = p_id_categoria
    WHERE id_accesorio = p_id_accesorio;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARCATEGORIA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARCATEGORIA" (
    p_id_categoria   IN NUMBER,
    p_nombre IN VARCHAR2,
    p_activo IN NUMBER,
    p_descripcion    IN VARCHAR2
) AS
BEGIN
    UPDATE categoria
    SET 
        nombre = p_nombre,
        activo = p_activo,
        descripcion = p_descripcion
    WHERE id_categoria = p_id_categoria;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARDETALLEPEDIDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARDETALLEPEDIDO" (
    p_id_detalle   IN NUMBER,
    p_cantidad IN VARCHAR2,
    p_precio IN NUMBER,
    p_total   IN VARCHAR2
) AS
BEGIN
    UPDATE detalle_pedido
    SET 
        cantidad = p_cantidad,
        precio = p_precio,
        total = p_total
    WHERE id_detalle = p_id_detalle;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARDEVOLUCION
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARDEVOLUCION" (
    p_id_devolucion   IN NUMBER,
    p_fecha_devolucion IN DATE,
    p_cantidad IN NUMBER,
    p_motivo   IN VARCHAR2
) AS
BEGIN
    UPDATE devolucion
    SET 
        fecha_devolucion = p_fecha_devolucion,
        cantidad = p_cantidad,
        motivo = p_motivo

    WHERE id_devolucion = p_id_devolucion;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARPEDIDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARPEDIDO" (
    p_id_pedido   IN NUMBER,
    p_fecha_pedido IN DATE,
    p_estado IN NUMBER
) AS
BEGIN
    UPDATE pedido
    SET  
        fecha_pedido = SYSDATE,
        estado = p_estado
    WHERE id_pedido = p_id_pedido;

    COMMIT;
END;

/


--------------------------------------------------------
--  DDL for Procedure MODIFICARPRODUCTO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARPRODUCTO" (
    p_id_producto NUMBER,
    p_descripcion VARCHAR2,
    p_precio NUMBER,
    p_stock NUMBER,
    p_id_categoria NUMBER,
    p_id_sucursal NUMBER,
    p_activo NUMBER
) AS
BEGIN
    UPDATE producto
    SET  
        descripcion = p_descripcion, 
        precio = p_precio ,
        stock = p_stock ,
        activo = p_activo 
        WHERE id_producto = p_id_producto;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARROL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARROL" (
    p_id_rol NUMBER,
    p_nombre VARCHAR2
) AS
BEGIN
    UPDATE rol
    SET 
        nombre = p_nombre
        WHERE id_rol = p_id_rol;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARSUCURSAL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARSUCURSAL" (
    p_id_sucursal NUMBER,
    p_nombre VARCHAR2,
    p_ubicacion VARCHAR2,
    p_telefono NUMBER
) AS
BEGIN
    UPDATE sucursal
    SET 
        nombre = p_nombre,
        ubicacion = p_ubicacion,
        telefono = p_telefono
        WHERE id_sucursal = p_id_sucursal;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARUSUARIO" (
    p_id_usuario   IN usuario.id_usuario%TYPE,
    p_username     IN usuario.username%TYPE,
    p_nombre       IN usuario.nombre%TYPE,
    p_apellido     IN usuario.apellido%TYPE,
    p_correo       IN usuario.correo%TYPE,
    p_telefono     IN usuario.telefono%TYPE
) AS
BEGIN
    UPDATE usuario
    SET 
        username = p_username,
        nombre = p_nombre,
        apellido = p_apellido,
        correo = p_correo,
        telefono = p_telefono
    WHERE id_usuario = p_id_usuario;

    COMMIT;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20001, 'Usuario no encontrado.');
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20002, 'Error al modificar usuario: ' || SQLERRM);
END;

/
--------------------------------------------------------
--  DDL for Procedure MODIFICARVENTA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARVENTA" (
    p_id_venta NUMBER,
    p_subtotal NUMBER,
    p_iva NUMBER,
    p_total NUMBER
) AS
    v_calcula_total NUMBER;
BEGIN

    v_calcula_total := p_subtotal + (p_subtotal * p_iva);


    UPDATE venta
    SET 
        subtotal = p_subtotal,
        iva = p_iva,
        total = v_calcula_total
    WHERE id_venta = p_id_venta;

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARACCESORIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARACCESORIO" (
    p_nombre       IN VARCHAR2,
    p_descripcion  IN VARCHAR2,
    p_precio       IN NUMBER,
    p_stock        IN NUMBER,
    p_id_categoria IN NUMBER
) AS
BEGIN
    INSERT INTO accesorio (
        nombre,
        descripcion,
        precio,
        stock,
        id_categoria
    ) VALUES (
        p_nombre,
        p_descripcion,
        p_precio,
        p_stock,
        p_id_categoria
    );

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARCATEGORIA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARCATEGORIA" (
    p_nombre       IN VARCHAR2,
    p_activo IN NUMBER,
    p_descripcion IN VARCHAR2
) AS
BEGIN
    INSERT INTO categoria (
        nombre,
        activo,
        descripcion
    ) VALUES (
        p_nombre,
        p_activo,
        p_descripcion
    );

    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARDETALLEPEDIDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARDETALLEPEDIDO" (
    p_id_pedido IN NUMBER,
    p_id_producto IN NUMBER,
    p_cantidad IN NUMBER,
    p_precio IN NUMBER
) AS
    v_pedido_exist NUMBER;
    v_producto_exist NUMBER;
    v_total NUMBER;
BEGIN

    SELECT COUNT(*)
    INTO v_pedido_exist
    FROM pedido
    WHERE id_pedido = p_id_pedido;

    SELECT COUNT(*)
    INTO v_producto_exist
    FROM producto
    WHERE id_producto = p_id_producto;

    IF v_pedido_exist = 1 AND v_producto_exist = 1 THEN
        v_total := p_cantidad * p_precio;

        INSERT INTO detalle_pedido (
            Id_pedido,
            Id_producto,
            cantidad,
            precio,
            total
        ) VALUES (
            p_id_pedido,
            p_id_producto,
            p_cantidad,
            p_precio,
            v_total
        );

        COMMIT;
    ELSE
        DBMS_OUTPUT.PUT_LINE('Error: El id_pedido o id_producto no existe.');
    END IF;
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARDEVOLUCION
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARDEVOLUCION" (
    p_id_cliente IN NUMBER,
    p_id_producto IN NUMBER,
    p_cantidad IN NUMBER,
    p_motivo IN VARCHAR2
) AS
    v_id_devolucion NUMBER;
    v_producto_exist NUMBER;
    v_cliente_exist NUMBER;
BEGIN

    SELECT COUNT(*)
    INTO v_producto_exist
    FROM producto
    WHERE id_producto = p_id_producto;

    SELECT COUNT(*)
    INTO v_cliente_exist
    FROM cliente
    WHERE id_cliente = p_id_cliente;


    IF v_producto_exist = 1 AND v_cliente_exist = 1 THEN

        SELECT seq_devolucion.NEXTVAL INTO v_id_devolucion FROM dual;


        INSERT INTO devolucion (
            ID_DEVOLUCION,
            ID_CLIENTE,
            ID_PRODUCTO,
            FECHA_DEVOLUCION,
            CANTIDAD,
            MOTIVO
        ) VALUES (
            v_id_devolucion,
            p_id_cliente,
            p_id_producto,
            SYSDATE, 
            p_cantidad,
            p_motivo
        );

        COMMIT; 
        DBMS_OUTPUT.PUT_LINE('Devolución registrada correctamente. ID_DEVOLUCION = ' || v_id_devolucion);
    ELSE
        DBMS_OUTPUT.PUT_LINE('Error: El ID_PRODUCTO o ID_CLIENTE no existe.');
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error al registrar devolución: ' || SQLERRM);
        ROLLBACK; 
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARPEDIDO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARPEDIDO" (
    p_id_cliente IN NUMBER,
    p_fecha_pedido IN DATE,
    p_estado IN NUMBER
) AS
    v_cliente_exist NUMBER;
    v_id_pedido NUMBER;
BEGIN

    SELECT COUNT(*)
    INTO v_cliente_exist
    FROM cliente
    WHERE id_cliente = p_id_cliente;

    IF v_cliente_exist > 0 THEN

        SELECT secuencia_pedido.NEXTVAL INTO v_id_pedido FROM dual;


        INSERT INTO pedido (
            Id_pedido,
            Id_cliente,
            fecha_pedido,
            estado
        ) VALUES (
            v_id_pedido,
            p_id_cliente,
            SYSDATE,
            p_estado
        );

        COMMIT; 
        DBMS_OUTPUT.PUT_LINE('Pedido registrado correctamente. ID_pedido: ' || v_id_pedido);
    ELSE
        DBMS_OUTPUT.PUT_LINE('El cliente no existe. No se puede registrar el pedido.');
    END IF;

EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error al registrar el pedido: ' || SQLERRM);
        ROLLBACK; 
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARPRODUCTO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARPRODUCTO" (
    p_descripcion VARCHAR2,
    p_precio NUMBER,
    p_stock NUMBER,
    p_id_categoria NUMBER,
    p_id_sucursal NUMBER,
    p_activo NUMBER
)
IS
    v_categoria_exist NUMBER;
    v_sucursal_exist NUMBER;
BEGIN

    SELECT COUNT(*) INTO v_categoria_exist
    FROM categoria
    WHERE id_categoria = p_id_categoria;


    SELECT COUNT(*) INTO v_sucursal_exist
    FROM sucursal
    WHERE id_sucursal = p_id_sucursal;


    IF v_categoria_exist = 1 AND v_sucursal_exist = 1 THEN
        INSERT INTO producto (descripcion, precio, stock, id_categoria, id_sucursal, activo)
        VALUES (p_descripcion, p_precio, p_stock, p_id_categoria, p_id_sucursal, p_activo);
        COMMIT; 
        DBMS_OUTPUT.PUT_LINE('Producto registrado correctamente.');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Error: La categoría o la sucursal especificada no existe.');
    END IF;
END registrarProducto;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARROL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARROL" (
    p_id_rol IN NUMBER DEFAULT NULL,
    p_nombre IN VARCHAR2
)
IS
BEGIN
    INSERT INTO rol (id_rol, nombre)
    VALUES (p_id_rol, p_nombre);
    COMMIT;
END registrarRol;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARSUCURSAL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARSUCURSAL" (
    p_id_sucursal IN NUMBER,
    p_nombre IN VARCHAR2,
    p_ubicacion IN VARCHAR2,
    p_telefono IN NUMBER
)
IS
BEGIN
    INSERT INTO sucursal (id_sucursal, nombre, ubicacion,telefono)
    VALUES (p_id_sucursal, p_nombre, p_ubicacion,p_telefono);
    COMMIT;
END registrarSucursal;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARUSUARIO" (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2,
    p_nombre   IN VARCHAR2,
    p_apellido IN VARCHAR2,
    p_correo   IN VARCHAR2,
    p_telefono IN VARCHAR2,
    p_id_rol   IN NUMBER  -- New parameter for ID_ROL
) AS
    v_id_cliente NUMBER;
BEGIN
    INSERT INTO usuario (
        username,
        password,
        nombre,
        apellido,
        correo,
        telefono,
        activo,
        id_rol  -- Insert ID_ROL into usuario table
    ) VALUES (
        p_username,
        p_password,
        p_nombre,
        p_apellido,
        p_correo,
        p_telefono,
        1,
        p_id_rol
    );

    -- Assuming you also need to insert into cliente (adjust if necessary)
    INSERT INTO cliente (
        username,
        nombre,
        password,
        apellido,
        correo,
        telefono,
        activo
    ) VALUES (
        p_username,
        p_nombre,
        p_password,
        p_apellido,
        p_correo,
        p_telefono,
        1
    );
    COMMIT;
END;

/
--------------------------------------------------------
--  DDL for Procedure REGISTRARVENTA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARVENTA" (
    p_id_venta IN NUMBER,
    p_subtotal IN NUMBER,
    p_iva IN NUMBER,
    p_id_cliente IN NUMBER,
    p_id_producto IN NUMBER
)
IS
    v_cliente_exist NUMBER;
    v_producto_exist NUMBER;
    v_total NUMBER;
BEGIN

    v_total := p_subtotal + (p_subtotal * p_iva);

    SELECT COUNT(*)
    INTO v_cliente_exist
    FROM cliente
    WHERE id_cliente = p_id_cliente;


    SELECT COUNT(*)
    INTO v_producto_exist
    FROM producto
    WHERE id_producto = p_id_producto;


    IF v_cliente_exist = 1 AND v_producto_exist = 1 THEN
        INSERT INTO venta (id_venta, subtotal, iva, total, id_cliente, id_producto)
        VALUES (p_id_venta, p_subtotal, p_iva, v_total, p_id_cliente, p_id_producto);
        COMMIT;

        DBMS_OUTPUT.PUT_LINE('Venta registrada correctamente.');
    ELSE

        DBMS_OUTPUT.PUT_LINE('Error: El cliente o el producto no existen.');
    END IF;

EXCEPTION
    WHEN OTHERS THEN

        DBMS_OUTPUT.PUT_LINE('Error: Ha ocurrido un error al intentar registrar la venta.');
END registrarVenta;

/
