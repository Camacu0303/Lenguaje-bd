
CREATE OR REPLACE PACKAGE pkg_accesorios AS
    -- Procedimiento para consultar accesorios
    PROCEDURE consultaraccesorios(p_resultado OUT SYS_REFCURSOR);
    
    -- Procedimiento para eliminar un accesorio
    PROCEDURE eliminaraccesorio(p_id_accesorio IN NUMBER);
    
    -- Procedimiento para modificar un accesorio
    PROCEDURE modificaraccesorio(
        p_id_accesorio   IN NUMBER,
        p_nombre         IN VARCHAR2,
        p_descripcion    IN VARCHAR2,
        p_precio         IN NUMBER,
        p_stock          IN NUMBER,
        p_id_categoria   IN NUMBER
    );
    
    -- Procedimiento para registrar un accesorio
    PROCEDURE registraraccesorio(
        p_nombre       IN VARCHAR2,
        p_descripcion  IN VARCHAR2,
        p_precio       IN NUMBER,
        p_stock        IN NUMBER,
        p_id_categoria IN NUMBER
    );
END pkg_accesorios;
/
CREATE OR REPLACE PACKAGE BODY pkg_accesorios AS

   PROCEDURE consultaraccesorios( 
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR SELECT
                             a.nombre,
                             a.descripcion,
                             a.precio,
                             a.stock,
                             c.nombre AS nombre_categoria
                         FROM
                                  accesorio a
                             JOIN categoria c ON a.id_categoria = c.id_categoria;

END consultaraccesorios;


  PROCEDURE eliminaraccesorio( 
    p_id_accesorio IN NUMBER
) AS
BEGIN
    DELETE FROM accesorio
    WHERE id_accesorio = p_id_accesorio;

    COMMIT;
END;


 PROCEDURE modificaraccesorio( 
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


  PROCEDURE registraraccesorio( 
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

END pkg_accesorios;



/
CREATE OR REPLACE PACKAGE pkg_categoria AS
    -- Procedimiento para consultar categorías
    PROCEDURE consultarcategoria(p_resultado OUT SYS_REFCURSOR);
    
    -- Procedimiento para eliminar una categoría
    PROCEDURE eliminarcategoria(p_id_categoria IN NUMBER);
    
    -- Procedimiento para modificar una categoría
    PROCEDURE modificarcategoria(
        p_id_categoria   IN NUMBER,
        p_nombre         IN VARCHAR2,
        p_activo         IN NUMBER,
        p_descripcion    IN VARCHAR2
    );
    
    -- Procedimiento para registrar una categoría
    PROCEDURE registrarcategoria(
        p_nombre       IN VARCHAR2,
        p_activo       IN NUMBER,
        p_descripcion  IN VARCHAR2
    );
END pkg_categoria;
/
CREATE OR REPLACE PACKAGE BODY DBAdmin.pkg_categoria AS

   PROCEDURE consultarcategoria( 
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR SELECT
                             nombre,
                             activo,
                             descripcion
                         FROM
                                 categoria;

END consultarcategoria;


  PROCEDURE eliminarcategoria( 
    p_id_categoria IN NUMBER
) AS
BEGIN
    DELETE FROM categoria
    WHERE id_categoria = p_id_categoria;

    COMMIT;
END;


 PROCEDURE modificarcategoria( 
    p_id_categoria   IN NUMBER,
    p_nombre         IN VARCHAR2,
    p_activo         IN NUMBER,
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


  PROCEDURE registrarcategoria( 
    p_nombre       IN VARCHAR2,
    p_activo       IN NUMBER,
    p_descripcion  IN VARCHAR2
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

END pkg_categoria;



/
CREATE OR REPLACE PACKAGE pkg_detalle_pedido AS
    -- Procedimiento para consultar detalles de pedidos
    PROCEDURE consultardetallepedido(p_resultado OUT SYS_REFCURSOR);
    
    -- Procedimiento para eliminar un detalle de pedido
    PROCEDURE eliminardetallepedido(p_id_detalle IN NUMBER);
    
    -- Procedimiento para modificar un detalle de pedido
    PROCEDURE modificardetallepedido(
        p_id_detalle   IN NUMBER,
        p_cantidad     IN NUMBER,
        p_precio       IN NUMBER,
        p_total        IN NUMBER
    );
    
    -- Procedimiento para registrar un detalle de pedido
    PROCEDURE registrardetallepedido(
        p_id_pedido    IN NUMBER,
        p_id_producto  IN NUMBER,
        p_cantidad     IN NUMBER,
        p_precio       IN NUMBER
    );
END pkg_detalle_pedido;
/
CREATE OR REPLACE PACKAGE BODY pkg_detalle_pedido AS

   PROCEDURE consultardetallepedido( 
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        d.Id_detalle,
        d.Id_pedido,
        p.descripcion AS nombre_producto,
        d.cantidad,
        d.precio,
        d.total
    FROM
        detalle_pedido d
    JOIN
        producto p ON d.Id_producto = p.id_producto;
END consultardetallepedido;


  PROCEDURE eliminardetallepedido( 
    p_id_detalle IN NUMBER
) AS
BEGIN
    DELETE FROM detalle_pedido
    WHERE id_detalle = p_id_detalle;

    COMMIT;
END;


 PROCEDURE modificardetallepedido( 
    p_id_detalle   IN NUMBER,
    p_cantidad     IN NUMBER,
    p_precio       IN NUMBER,
    p_total        IN NUMBER
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


  PROCEDURE registrardetallepedido( 
    p_id_pedido    IN NUMBER,
    p_id_producto  IN NUMBER,
    p_cantidad     IN NUMBER,
    p_precio       IN NUMBER
) AS
    v_pedido_exist   NUMBER;
    v_producto_exist NUMBER;
    v_total          NUMBER;
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
            id_pedido,
            id_producto,
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

END pkg_detalle_pedido;


/
CREATE OR REPLACE PACKAGE pkg_devoluciones AS
    -- Procedimiento para consultar devoluciones
    PROCEDURE consultardevoluciones(p_resultado OUT SYS_REFCURSOR);
    
    -- Procedimiento para eliminar una devolución
    PROCEDURE eliminardevoluciones(p_id_devolucion IN NUMBER);
    
    -- Procedimiento para modificar una devolución
    PROCEDURE modificardevolucion(
        p_id_devolucion    IN NUMBER,
        p_fecha_devolucion IN DATE,
        p_cantidad         IN NUMBER,
        p_motivo           IN VARCHAR2
    );
    
    -- Procedimiento para registrar una devolución
    PROCEDURE registrardevolucion(
        p_id_cliente   IN NUMBER,
        p_id_producto  IN NUMBER,
        p_cantidad     IN NUMBER,
        p_motivo       IN VARCHAR2
    );
END pkg_devoluciones;
/

CREATE OR REPLACE PACKAGE BODY pkg_devoluciones AS

   PROCEDURE consultardevoluciones( 
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        d.Id_devolucion,
        d.Id_cliente,
        d.fecha_devolucion,
        d.cantidad,
        d.Motivo
    FROM
        devolucion d
    JOIN
        cliente c ON d.Id_cliente = c.id_cliente;
END consultardevoluciones;


  PROCEDURE eliminardevoluciones( 
    p_id_devolucion IN NUMBER
) AS
BEGIN
    DELETE FROM devolucion
    WHERE id_devolucion = p_id_devolucion;

    COMMIT;
END;


 PROCEDURE modificardevolucion( 
    p_id_devolucion    IN NUMBER,
    p_fecha_devolucion IN DATE,
    p_cantidad         IN NUMBER,
    p_motivo           IN VARCHAR2
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


  PROCEDURE registrardevolucion( 
    p_id_cliente   IN NUMBER,
    p_id_producto  IN NUMBER,
    p_cantidad     IN NUMBER,
    p_motivo       IN VARCHAR2
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
            id_devolucion,
            id_cliente,
            id_producto,
            fecha_devolucion,
            cantidad,
            motivo
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

END pkg_devoluciones;
/



CREATE OR REPLACE PACKAGE pkg_pedidos AS
    -- Procedimiento para consultar pedidos
    PROCEDURE consultarpedidos(p_resultado OUT SYS_REFCURSOR);
    
    -- Procedimiento para eliminar un pedido
    PROCEDURE eliminarpedidos(p_id_pedido IN NUMBER);
    
    -- Procedimiento para modificar un pedido
    PROCEDURE modificarpedido(
        p_id_pedido   IN NUMBER,
        p_fecha_pedido IN DATE,
        p_estado       IN NUMBER
    );
    
    -- Procedimiento para registrar un pedido
    PROCEDURE registrarpedido(
        p_id_cliente   IN NUMBER,
        p_fecha_pedido IN DATE,
        p_estado       IN NUMBER
    );
END pkg_pedidos;
/

CREATE OR REPLACE PACKAGE BODY pkg_pedidos AS

   PROCEDURE consultarpedidos( 
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_pedido,
        Id_cliente,
        fecha_pedido,
        estado
    FROM
        pedido;
END consultarpedidos;


  PROCEDURE eliminarpedidos( 
    p_id_pedido IN NUMBER
) AS
BEGIN
    DELETE FROM pedido
    WHERE id_pedido = p_id_pedido;

    COMMIT;
END;


 PROCEDURE modificarpedido( 
    p_id_pedido    IN NUMBER,
    p_fecha_pedido IN DATE,
    p_estado       IN NUMBER
) AS
BEGIN
    UPDATE pedido
    SET  
        fecha_pedido = SYSDATE,
        estado = p_estado
    WHERE id_pedido = p_id_pedido;

    COMMIT;
END;


  PROCEDURE registrarpedido( 
    p_id_cliente   IN NUMBER,
    p_fecha_pedido IN DATE,
    p_estado       IN NUMBER
) AS
    v_cliente_exist NUMBER;
    v_id_pedido     NUMBER;
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

END pkg_pedidos;
/



CREATE OR REPLACE PACKAGE pkg_productos AS
    -- Procedimiento para consultar productos
    PROCEDURE consultarproductos(p_resultado OUT SYS_REFCURSOR);
    
    -- Procedimiento para eliminar un producto
    PROCEDURE eliminarproducto(p_id_producto IN NUMBER);
    
    -- Procedimiento para modificar un producto
    PROCEDURE modificarproducto(
        p_id_producto    NUMBER,
        p_descripcion    VARCHAR2,
        p_precio         NUMBER,
        p_stock          NUMBER,
        p_id_categoria   NUMBER,
        p_id_sucursal    NUMBER,
        p_activo         NUMBER
    );
    
    -- Procedimiento para registrar un producto
    PROCEDURE registrarproducto(
        p_descripcion    VARCHAR2,
        p_precio         NUMBER,
        p_stock          NUMBER,
        p_id_categoria   NUMBER,
        p_id_sucursal    NUMBER,
        p_activo         NUMBER
    );
END pkg_productos;
/

CREATE OR REPLACE PACKAGE BODY pkg_productos AS

   PROCEDURE consultarproductos( 
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
    FROM
        producto;
END consultarproductos;


  PROCEDURE eliminarproducto( 
    p_id_producto IN NUMBER
) AS
BEGIN
    DELETE FROM producto
    WHERE id_producto = p_id_producto;

    COMMIT;
END;


 PROCEDURE modificarproducto( 
    p_id_producto    NUMBER,
    p_descripcion    VARCHAR2,
    p_precio         NUMBER,
    p_stock          NUMBER,
    p_id_categoria   NUMBER,
    p_id_sucursal    NUMBER,
    p_activo         NUMBER
) AS
BEGIN
    UPDATE producto
    SET  
        descripcion = p_descripcion, 
        precio = p_precio,
        stock = p_stock,
        id_categoria = p_id_categoria,
        id_sucursal = p_id_sucursal,
        activo = p_activo
    WHERE id_producto = p_id_producto;

    COMMIT;
END;


  PROCEDURE registrarproducto( 
    p_descripcion    VARCHAR2,
    p_precio         NUMBER,
    p_stock          NUMBER,
    p_id_categoria   NUMBER,
    p_id_sucursal    NUMBER,
    p_activo         NUMBER
) IS
    v_categoria_exist NUMBER;
    v_sucursal_exist NUMBER;
BEGIN

    SELECT COUNT(*)
    INTO v_categoria_exist
    FROM categoria
    WHERE id_categoria = p_id_categoria;

    SELECT COUNT(*)
    INTO v_sucursal_exist
    FROM sucursal
    WHERE id_sucursal = p_id_sucursal;

    IF v_categoria_exist = 1 AND v_sucursal_exist = 1 THEN
        INSERT INTO producto (
            descripcion,
            precio,
            stock,
            id_categoria,
            id_sucursal,
            activo
        ) VALUES (
            p_descripcion,
            p_precio,
            p_stock,
            p_id_categoria,
            p_id_sucursal,
            p_activo
        );
        COMMIT; 
        DBMS_OUTPUT.PUT_LINE('Producto registrado correctamente.');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Error: La categoría o la sucursal especificada no existe.');
    END IF;
END registrarproducto;

END pkg_productos;
/



CREATE OR REPLACE PACKAGE pkg_rol AS

   -- Procedimiento para consultar roles
   PROCEDURE consultarRol(
       p_resultado OUT SYS_REFCURSOR
   );

   -- Procedimiento para eliminar un rol
   PROCEDURE eliminarRol(
       p_id_rol IN NUMBER
   );

   -- Procedimiento para modificar un rol
   PROCEDURE modificarRol(
       p_id_rol NUMBER,
       p_nombre VARCHAR2,
       p_id_usuario NUMBER
   );

   -- Procedimiento para registrar un rol
   PROCEDURE registrarRol(
       p_id_rol IN NUMBER DEFAULT NULL,
       p_nombre IN VARCHAR2
   );

END pkg_rol;
/

CREATE OR REPLACE PACKAGE BODY pkg_rol AS

   -- Procedimiento para consultar roles
   PROCEDURE consultarRol( 
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_rol,
        Nombre
    FROM
        rol;
END consultarRol;


   -- Procedimiento para eliminar un rol
   PROCEDURE eliminarRol( 
    p_id_rol IN NUMBER
) AS
BEGIN
    DELETE FROM rol
    WHERE id_rol = p_id_rol;

    COMMIT;
END eliminarRol;


   -- Procedimiento para modificar un rol
   PROCEDURE modificarRol( 
    p_id_rol NUMBER,
    p_nombre VARCHAR2,
    p_id_usuario NUMBER
) AS
BEGIN
    UPDATE rol
    SET 
        nombre = p_nombre   
    WHERE id_rol = p_id_rol;

    COMMIT;
END modificarRol;


   -- Procedimiento para registrar un rol
   PROCEDURE registrarRol( 
    p_id_rol IN NUMBER DEFAULT NULL,
    p_nombre IN VARCHAR2
) IS
BEGIN
    INSERT INTO rol (id_rol, nombre)
    VALUES (p_id_rol, p_nombre);
    COMMIT;
END registrarRol;

END pkg_rol;
/



CREATE OR REPLACE PACKAGE pkg_sucursal AS

   -- Procedimiento para consultar todas las sucursales
   PROCEDURE consultarSucursal(
       p_resultado OUT SYS_REFCURSOR
   );

   -- Procedimiento para eliminar una sucursal por su ID
   PROCEDURE eliminarSucursal(
       p_id_sucursal IN NUMBER
   );

   -- Procedimiento para modificar una sucursal
    PROCEDURE modificarsucursal(
        p_id_sucursal IN NUMBER,
        p_nombre IN VARCHAR2,
        p_ubicacion IN VARCHAR2,
        p_telefono IN VARCHAR2
    );

   -- Procedimiento para registrar una nueva sucursal
   PROCEDURE registrarSucursal(
       p_nombre IN VARCHAR2,
       p_direccion IN VARCHAR2,
       p_telefono IN VARCHAR2
   );

END pkg_sucursal;

/
CREATE OR REPLACE PACKAGE BODY pkg_sucursal AS
 PROCEDURE eliminarsucursal ( -- CREATE OR REPLACE NONEDITIONABLE 
    p_id_sucursal IN NUMBER
) AS
BEGIN
    DELETE FROM sucursal
    WHERE id_sucursal = p_id_sucursal;
    COMMIT;
END;

PROCEDURE consultarsucursal (-- CREATE OR REPLACE NONEDITIONABLE
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR
    SELECT
        Id_sucursal,
        Nombre,
        ubicacion,
        telefono
    FROM
        sucursal;
END;
   PROCEDURE modificarsucursal(
        p_id_sucursal IN NUMBER,
        p_nombre IN VARCHAR2,
        p_ubicacion IN VARCHAR2,
        p_telefono IN VARCHAR2
    ) AS
    BEGIN
        UPDATE sucursal
        SET 
            nombre = p_nombre,
            ubicacion = p_ubicacion,
            telefono = p_telefono
        WHERE id_sucursal = p_id_sucursal;
        
        -- Confirmar la transacción
        COMMIT;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RAISE_APPLICATION_ERROR(-20002, 'Sucursal no encontrada.');
        WHEN OTHERS THEN
            RAISE_APPLICATION_ERROR(-20003, 'Error al modificar la sucursal: ' || SQLERRM);
    END modificarsucursal;

 PROCEDURE registrarSucursal(
        p_nombre IN VARCHAR2,
        p_direccion IN VARCHAR2,
        p_telefono IN VARCHAR2
    ) IS
        v_id_sucursal NUMBER;
    BEGIN
        -- Obtener el próximo valor de la secuencia
        SELECT seq_id_sucursal.NEXTVAL INTO v_id_sucursal FROM dual;

        -- Insertar los datos en la tabla
        INSERT INTO sucursal (ID_SUCURSAL, NOMBRE, UBICACION, TELEFONO)
        VALUES (v_id_sucursal, p_nombre, p_direccion, p_telefono);

        -- Confirmar la transacción
        COMMIT;
    EXCEPTION
        WHEN OTHERS THEN
            -- Manejar cualquier error
            ROLLBACK;
            RAISE_APPLICATION_ERROR(-20001, 'Error al registrar la sucursal: ' || SQLERRM);
    END registrarSucursal;
END pkg_sucursal;
/


CREATE OR REPLACE PACKAGE pkg_usuario AS

   -- Procedimiento para consultar un usuario por su nombre de usuario y contraseña
   PROCEDURE consultarUsuarioPorUsername(
       p_username IN VARCHAR2,
       p_password IN VARCHAR2,
       p_resultado OUT SYS_REFCURSOR
   );

   -- Procedimiento para consultar todos los usuarios
   PROCEDURE consultarUsuarios(
       p_resultado OUT SYS_REFCURSOR
   );

   -- Procedimiento para desactivar un usuario
   PROCEDURE desactivarUsuario(
       p_id_usuario IN usuario.id_usuario%TYPE
   );

   -- Procedimiento para eliminar un usuario
   PROCEDURE eliminarUsuario(
       p_id_usuario IN NUMBER
   );

   -- Procedimiento para modificar un usuario
   PROCEDURE modificarUsuario(
       p_id_usuario IN usuario.id_usuario%TYPE,
       p_username IN usuario.username%TYPE,
       p_nombre IN usuario.nombre%TYPE,
       p_apellido IN usuario.apellido%TYPE,
       p_correo IN usuario.correo%TYPE,
       p_telefono IN usuario.telefono%TYPE
   );

   -- Procedimiento para registrar un nuevo usuario
   PROCEDURE registrarUsuario(
       p_username IN VARCHAR2, 
       p_password IN VARCHAR2,
       p_nombre IN VARCHAR2,
       p_apellido IN VARCHAR2,
       p_correo IN VARCHAR2,
       p_telefono IN VARCHAR2,
       p_id_rol IN NUMBER  
   );

END pkg_usuario;
/

CREATE OR REPLACE PACKAGE BODY pkg_usuario AS

   PROCEDURE consultarUsuarioPorUsername(
       p_username IN VARCHAR2,
       p_password IN VARCHAR2,
       p_resultado OUT SYS_REFCURSOR
   ) AS
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
           username = p_username AND password = p_password;
   END consultarUsuarioPorUsername;

   PROCEDURE consultarUsuarios(
       p_resultado OUT SYS_REFCURSOR
   ) AS
   BEGIN
       OPEN p_resultado FOR
       SELECT
           username,
           nombre,
           apellido,
           activo
       FROM
           usuario;
   END consultarUsuarios;

   PROCEDURE desactivarUsuario(
       p_id_usuario IN usuario.id_usuario%TYPE
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
   END desactivarUsuario;

   PROCEDURE eliminarUsuario(
       p_id_usuario IN NUMBER
   ) AS
   BEGIN
       DELETE FROM usuario
       WHERE id_usuario = p_id_usuario;

       COMMIT;
   END eliminarUsuario;

   PROCEDURE modificarUsuario(
       p_id_usuario IN usuario.id_usuario%TYPE,
       p_username IN usuario.username%TYPE,
       p_nombre IN usuario.nombre%TYPE,
       p_apellido IN usuario.apellido%TYPE,
       p_correo IN usuario.correo%TYPE,
       p_telefono IN usuario.telefono%TYPE
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
   END modificarUsuario;

   PROCEDURE registrarUsuario(
       p_username IN VARCHAR2, 
       p_password IN VARCHAR2,
       p_nombre IN VARCHAR2,
       p_apellido IN VARCHAR2,
       p_correo IN VARCHAR2,
       p_telefono IN VARCHAR2,
       p_id_rol IN NUMBER  
   ) AS
   BEGIN
       INSERT INTO usuario (
           username,
           password,
           nombre,
           apellido,
           correo,
           telefono,
           activo,
           id_rol  
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
       COMMIT;
   END registrarUsuario;

END pkg_usuario;
/



CREATE OR REPLACE PACKAGE pkg_venta AS

   -- Procedimiento para consultar todas las ventas
   PROCEDURE consultarVenta(
       p_resultado OUT SYS_REFCURSOR
   );

   -- Procedimiento para eliminar una venta por su ID
   PROCEDURE eliminarVenta(
       p_id_venta IN NUMBER
   );

   -- Procedimiento para modificar una venta
   PROCEDURE modificarVenta(
       p_id_venta IN NUMBER,
       p_subtotal IN NUMBER,
       p_iva IN NUMBER,
       p_total IN NUMBER
   );

   -- Procedimiento para registrar una nueva venta
   PROCEDURE registrarVenta(
       p_id_venta IN NUMBER,
       p_subtotal IN NUMBER,
       p_iva IN NUMBER,
       p_id_cliente IN NUMBER,
       p_id_producto IN NUMBER
   );

END pkg_venta;
/

CREATE OR REPLACE PACKAGE BODY pkg_venta AS

   PROCEDURE consultarVenta(
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
           venta;
   END consultarVenta;

   PROCEDURE eliminarVenta(
       p_id_venta IN NUMBER
   ) AS
   BEGIN
       DELETE FROM venta
       WHERE id_venta = p_id_venta;

       COMMIT;
   END eliminarVenta;

   PROCEDURE modificarVenta(
       p_id_venta IN NUMBER,
       p_subtotal IN NUMBER,
       p_iva IN NUMBER,
       p_total IN NUMBER
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
   END modificarVenta;

   PROCEDURE registrarVenta(
       p_id_venta IN NUMBER,
       p_subtotal IN NUMBER,
       p_iva IN NUMBER,
       p_id_cliente IN NUMBER,
       p_id_producto IN NUMBER
   ) IS
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
           INSERT INTO venta (
               id_venta,
               subtotal,
               iva,
               total,
               id_cliente,
               id_producto
           ) VALUES (
               p_id_venta,
               p_subtotal,
               p_iva,
               v_total,
               p_id_cliente,
               p_id_producto
           );
           COMMIT;

           DBMS_OUTPUT.PUT_LINE('Venta registrada correctamente.');
       ELSE
           DBMS_OUTPUT.PUT_LINE('Error: El cliente o el producto no existen.');
       END IF;

   EXCEPTION
       WHEN OTHERS THEN
           DBMS_OUTPUT.PUT_LINE('Error: Ha ocurrido un error al intentar registrar la venta.');
   END registrarVenta;

END pkg_venta;


