--------------------------------------------------------
-- Archivo creado  - jueves-julio-18-2024   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for View VISTAACCESORIOS
--------------------------------------------------------

CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAACCESORIOS" (
    "ID_ACCESORIO",
    "NOMBRE",
    "DESCRIPCION",
    "PRECIO",
    "STOCK",
    "NOMBRE_CATEGORIA"
) AS
SELECT
    a.id_accesorio,
    a.nombre,
    a.descripcion,
    a.precio,
    a.stock,
    c.nombre AS nombre_categoria
FROM
    accesorio a
JOIN
    categoria c ON a.id_categoria = c.id_categoria;

--------------------------------------------------------
--  DDL for View VISTACATEGORIAS
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTACATEGORIAS" ("ID_CATEGORIA", "NOMBRE", "ACTIVO", "DESCRIPCION") AS 
  SELECT ID_CATEGORIA, NOMBRE, ACTIVO, DESCRIPCION
FROM categoria
;



--------------------------------------------------------
--  DDL for View VISTACLIENTES
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTACLIENTES" ("ID_CLIENTE", "NOMBRE", "APELLIDO", "TELEFONO", "CORREO", "DIRECCION", "USERNAME", "PASSWORD", "ACTIVO") AS 
  SELECT ID_CLIENTE, NOMBRE, APELLIDO, TELEFONO, CORREO, DIRECCION, USERNAME, PASSWORD, ACTIVO
FROM cliente
;
--------------------------------------------------------
--  DDL for View VISTADETALLESDEDIDO
--------------------------------------------------------

CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTADETALLEPEDIDO" (
    "ID_DETALLE",
    "ID_PEDIDO",
    "NOMBRE_PRODUCTO",
    "CANTIDAD",
    "PRECIO",
    "TOTAL"
) AS
SELECT
    d.Id_detalle,
    d.Id_pedido,
    p.descripcion AS nombre_producto,
    d.cantidad,
    d.precio,
    d.total
FROM
    Detalle_pedido d
JOIN
    producto p ON d.Id_producto = p.id_producto;
--------------------------------------------------------
--  DDL for View VISTADEVOLUCIONES
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTADEVOLUCIONES" ("ID_DEVOLUCION", "ID_CLIENTE", "ID_PRODUCTO", "FECHA_DEVOLUCION", "CANTIDAD", "MOTIVO") AS 
 SELECT
        d.Id_devolucion,
        c.nombre,
        d.id_producto,
        d.fecha_devolucion,
        d.cantidad,
        d.Motivo
    FROM
        devolucion d
    JOIN
        cliente c ON d.Id_devolucion = c.id_cliente;

--------------------------------------------------------
--  DDL for View VISTAEMPLEADOS
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAEMPLEADOS" ("ID_EMPLEADO", "USERNAME", "NOMBRE", "PASSWORD", "APELLIDO", "CORREO", "TELEFONO", "ID_SUCURSAL", "ACTIVO") AS 
  SELECT ID_EMPLEADO, USERNAME, NOMBRE, PASSWORD, APELLIDO, CORREO, TELEFONO, ID_SUCURSAL, ACTIVO
FROM empleado
;
--------------------------------------------------------
--  DDL for View VISTAPEDIDOS
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAPEDIDOS" ("ID_PEDIDO", "ID_CLIENTE", "FECHA_PEDIDO", "ESTADO") AS 
  SELECT ID_PEDIDO, ID_CLIENTE, FECHA_PEDIDO, ESTADO
FROM pedido
;
--------------------------------------------------------
--  DDL for View VISTAPRODUCTOS
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAPRODUCTOS" ("ID_PRODUCTO", "DESCRIPCION", "PRECIO", "STOCK", "ID_CATEGORIA", "ID_SUCURSAL", "ACTIVO") AS 
  SELECT ID_PRODUCTO, DESCRIPCION, PRECIO, STOCK, ID_CATEGORIA, ID_SUCURSAL, ACTIVO
FROM producto
;
--------------------------------------------------------
--  DDL for View VISTAROLES
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAROLES" ("ID_ROL", "NOMBRE") AS 
  SELECT ID_ROL, NOMBRE
FROM rol
;

--------------------------------------------------------
--  DDL for View VISTASUCURSALES
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTASUCURSALES" ("ID_SUCURSAL", "NOMBRE", "UBICACION", "TELEFONO") AS 
  SELECT ID_SUCURSAL, NOMBRE, UBICACION, TELEFONO
FROM sucursal
;
--------------------------------------------------------
--  DDL for View VISTAUSUARIOS
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAUSUARIOS" ("ID_USUARIO", "USERNAME", "PASSWORD", "NOMBRE", "APELLIDO", "CORREO", "TELEFONO", "ACTIVO") AS 
  SELECT ID_USUARIO, USERNAME, PASSWORD, NOMBRE, APELLIDO, CORREO, TELEFONO, ACTIVO
FROM usuario
;
--------------------------------------------------------
--  DDL for View VISTAVENTAS
--------------------------------------------------------

  CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "DBADMIN"."VISTAVENTAS" ("ID_VENTA", "SUBTOTAL", "IVA", "TOTAL", "ID_CLIENTE", "ID_PRODUCTO") AS 
  SELECT ID_VENTA, SUBTOTAL, IVA, TOTAL, ID_CLIENTE, ID_PRODUCTO
FROM venta
;
