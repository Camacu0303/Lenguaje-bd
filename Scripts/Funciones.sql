-- Funcion para obtener el nombre completo de un cliente

CREATE OR REPLACE FUNCTION obtener_nombre_completo_cliente(p_id_cliente IN NUMBER) RETURN VARCHAR2 IS
   nombre_completo VARCHAR2(200);
BEGIN
   SELECT nombre || ' ' || apellido INTO nombre_completo
   FROM cliente
   WHERE id_cliente = p_id_cliente;
   RETURN nombre_completo;
END;

-- Funcion para calcular el total de productos en stock

CREATE OR REPLACE FUNCTION total_stock_productos RETURN NUMBER IS
   total_stock NUMBER;
BEGIN
   SELECT SUM(stock) INTO total_stock
   FROM producto;
   RETURN total_stock;
END;


-- Funcion para obtener el precio total de  un pedido

CREATE OR REPLACE FUNCTION obtener_total_pedido(p_id_pedido IN NUMBER) RETURN NUMBER IS
   total NUMBER;
BEGIN
   SELECT SUM(cantidad * precio) INTO total
   FROM detalle_pedido
   WHERE id_pedido = p_id_pedido;
   RETURN total;
END;

--Funci�n para verificar si un producto est� en stock

CREATE OR REPLACE FUNCTION producto_en_stock(p_id_producto IN NUMBER) RETURN BOOLEAN IS
   stock_producto NUMBER;
BEGIN
   SELECT stock INTO stock_producto
   FROM producto
   WHERE id_producto = p_id_producto;
   RETURN stock_producto > 0;
END;

--Funci�n para obtener el estado de un pedido

CREATE OR REPLACE FUNCTION obtener_estado_pedido(p_id_pedido IN NUMBER) RETURN VARCHAR2 IS
   estado VARCHAR2(20);
BEGIN
   SELECT estado INTO estado
   FROM pedido
   WHERE id_pedido = p_id_pedido;
   RETURN estado;
END;


--Funci�n para calcular el total de ventas de un cliente

CREATE OR REPLACE FUNCTION total_ventas_cliente(p_id_cliente IN NUMBER) RETURN NUMBER IS
   total_ventas NUMBER;
BEGIN
   SELECT SUM(total) INTO total_ventas
   FROM venta
   WHERE id_cliente = p_id_cliente;
   RETURN total_ventas;
END;



--Funci�n para contar el n�mero de pedidos de un cliente

CREATE OR REPLACE FUNCTION contar_pedidos_cliente(p_id_cliente IN NUMBER) RETURN NUMBER IS
   numero_pedidos NUMBER;
BEGIN
   SELECT COUNT(*) INTO numero_pedidos
   FROM pedido
   WHERE id_cliente = p_id_cliente;
   RETURN numero_pedidos;
END;


-- Funci�n para obtener el nombre de un producto por su ID

CREATE OR REPLACE FUNCTION obtener_nombre_producto(p_id_producto IN NUMBER) RETURN VARCHAR2 IS
   nombre_producto VARCHAR2(500);
BEGIN
   SELECT descripcion INTO nombre_producto
   FROM producto
   WHERE id_producto = p_id_producto;
   RETURN nombre_producto;
END;


--Funci�n para calcular el impuesto total de una venta

CREATE OR REPLACE FUNCTION calcular_iva_venta(p_id_venta IN NUMBER) RETURN NUMBER IS
   iva NUMBER;
BEGIN
   SELECT iva INTO iva
   FROM venta
   WHERE id_venta = p_id_venta;
   RETURN iva;
END;


--  Funci�n para verificar si un cliente est� activo

CREATE OR REPLACE FUNCTION cliente_activo(p_id_cliente IN NUMBER) RETURN BOOLEAN IS
   activo_cliente NUMBER;
BEGIN
   SELECT activo INTO activo_cliente
   FROM cliente
   WHERE id_cliente = p_id_cliente;
   RETURN activo_cliente = 1;
END;


--Funci�n para obtener la cantidad total de un producto devuelto

CREATE OR REPLACE FUNCTION total_devoluciones_producto(p_id_producto IN NUMBER) RETURN NUMBER IS
   total_devoluciones NUMBER;
BEGIN
   SELECT SUM(cantidad) INTO total_devoluciones
   FROM devolucion d
   JOIN detalle_pedido dp ON d.id_detalle = dp.id_detalle
   WHERE dp.id_producto = p_id_producto;
   RETURN total_devoluciones;
END;


--Funci�n para calcular el total de ingresos de una sucursal

CREATE OR REPLACE FUNCTION total_ingresos_sucursal(p_id_sucursal IN NUMBER) RETURN NUMBER IS
   ingresos_totales NUMBER;
BEGIN
   SELECT SUM(v.total) INTO ingresos_totales
   FROM venta v
   JOIN producto p ON v.id_producto = p.id_producto
   WHERE p.id_sucursal = p_id_sucursal;
   RETURN ingresos_totales;
END;


-- Funci�n para obtener el nombre de la sucursal por su ID

CREATE OR REPLACE FUNCTION obtener_nombre_sucursal(p_id_sucursal IN NUMBER) RETURN VARCHAR2 IS
   nombre_sucursal VARCHAR2(100);
BEGIN
   SELECT nombre INTO nombre_sucursal
   FROM sucursal
   WHERE id_sucursal = p_id_sucursal;
   RETURN nombre_sucursal;
END;


-- Funci�n para obtener el nombre de un empleado

CREATE OR REPLACE FUNCTION obtener_nombre_completo_empleado(p_id_empleado IN NUMBER) RETURN VARCHAR2 IS
   nombre_completo_empleado VARCHAR2(200);
BEGIN
   SELECT nombre || ' ' || apellido INTO nombre_completo_empleado
   FROM empleado
   WHERE id_empleado = p_id_empleado;
   RETURN nombre_completo_empleado;
END;

-- Funci�n para obtener la descripci�n de una categor�a

CREATE OR REPLACE FUNCTION obtener_descripcion_categoria(p_id_categoria IN NUMBER) RETURN VARCHAR2 IS
   descripcion_categoria VARCHAR2(500);
BEGIN
   SELECT descripcion INTO descripcion_categoria
   FROM categoria
   WHERE id_categoria = p_id_categoria;
   RETURN descripcion_categoria;
END;
