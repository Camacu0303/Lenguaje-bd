--------------------------------------------------------
--  DDL for Procedure CONSULTARCLIENTES
--------------------------------------------------------
set define off;

CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."CONSULTARCLIENTES" (
    p_resultado OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN p_resultado FOR 
    SELECT 
        ID_CLIENTE,
        NOMBRE,
        APELLIDO,
        TELEFONO,
        CORREO,
        DIRECCION,
        ACTIVO
    FROM cliente;
END;
/
--------------------------------------------------------
--  DDL for Procedure REGISTRARCLIENTE
--------------------------------------------------------
set define off;

CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."REGISTRARCLIENTE" (
    p_nombre       IN VARCHAR2,
    p_apellido     IN VARCHAR2,
    p_telefono     IN VARCHAR2,
    p_correo       IN VARCHAR2,
    p_direccion    IN VARCHAR2,
    p_activo       IN NUMBER
) AS
BEGIN
    INSERT INTO cliente (
        NOMBRE,
        APELLIDO,
        TELEFONO,
        CORREO,
        DIRECCION,
        ACTIVO
    ) VALUES (
        p_nombre,
        p_apellido,
        p_telefono,
        p_correo,
        p_direccion,
        p_activo
    );

    COMMIT;
END;
/
--------------------------------------------------------
--  DDL for Procedure MODIFICARCLIENTE
--------------------------------------------------------
set define off;

CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."MODIFICARCLIENTE" (
    p_id_cliente   IN NUMBER,
    p_nombre       IN VARCHAR2,
    p_apellido     IN VARCHAR2,
    p_telefono     IN VARCHAR2,
    p_correo       IN VARCHAR2,
    p_direccion    IN VARCHAR2,
    p_activo       IN NUMBER
) AS
BEGIN
    UPDATE cliente
    SET 
        NOMBRE = p_nombre,
        APELLIDO = p_apellido,
        TELEFONO = p_telefono,
        CORREO = p_correo,
        DIRECCION = p_direccion,
        ACTIVO = p_activo
    WHERE ID_CLIENTE = p_id_cliente;

    COMMIT;
END;
/

--------------------------------------------------------
--  DDL for Procedure ELIMINARCLIENTE
--------------------------------------------------------
set define off;

CREATE OR REPLACE NONEDITIONABLE PROCEDURE "DBADMIN"."ELIMINARCLIENTE" (
    p_id_cliente IN NUMBER
) AS
BEGIN
    DELETE FROM cliente
    WHERE ID_CLIENTE = p_id_cliente;

    COMMIT;
END;
/


