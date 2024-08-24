--------------------------------------------------------
--  trigger  for Table usuarios
--------------------------------------------------------
CREATE OR REPLACE TRIGGER"DBADMIN"."TRG_AUDITORIA_USUARIOS"
AFTER INSERT OR UPDATE OR DELETE ON "DBADMIN"."USUARIO"
FOR EACH ROW
DECLARE
    v_accion VARCHAR2(50);
    v_detalle_anterior VARCHAR2(255);
    v_detalle_nuevo VARCHAR2(255);
BEGIN
  
    IF INSERTING THEN
        v_accion := 'INSERT';
        v_detalle_nuevo := 'Usuario creado: ' || :NEW.username;
    ELSIF UPDATING THEN
        v_accion := 'UPDATE';
        v_detalle_anterior := 'Usuario anterior: ' || :OLD.username;
        v_detalle_nuevo := 'Usuario actualizado: ' || :NEW.username;
    ELSIF DELETING THEN
        v_accion := 'DELETE';
        v_detalle_anterior := 'Usuario eliminado: ' || :OLD.username;
    END IF;

    
    INSERT INTO auditoria_usuarios (
        id_usuario,
        accion,
        descripcion,
        usuario_accion,
        fecha_accion,
        detalle_anterior,
        detalle_nuevo
    ) VALUES (
        NVL(:NEW.id_usuario, :OLD.id_usuario),  
        v_accion,
        v_accion || ' realizado en usuario ' || NVL(:NEW.username, :OLD.username),
        USER, 
        SYSDATE,
        v_detalle_anterior,
        v_detalle_nuevo
    );
END;
--------------------------------------------------------
--  trigger  for Table Rol
--------------------------------------------------------

CREATE OR REPLACE TRIGGER "DBADMIN"."TRG_AUDITORIA_ROL"
AFTER INSERT OR UPDATE OR DELETE ON "DBADMIN"."ROL"
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_ROL" (
            "ID_ROL", "NOMBRE", "OPERACION", "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :NEW."ID_ROL", :NEW."NOMBRE", 'INSERT', SYSTIMESTAMP, USER
        );
    ELSIF UPDATING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_ROL" (
            "ID_ROL", "NOMBRE", "OPERACION", "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :NEW."ID_ROL", :NEW."NOMBRE", 'UPDATE', SYSTIMESTAMP, USER
        );
    ELSIF DELETING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_ROL" (
            "ID_ROL", "NOMBRE", "OPERACION", "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :OLD."ID_ROL", :OLD."NOMBRE", 'DELETE', SYSTIMESTAMP, USER
        );
    END IF;
END;
--------------------------------------------------------
--  trigger  for Table empleado
--------------------------------------------------------


CREATE OR REPLACE TRIGGER "DBADMIN"."TRG_AUDITORIA_EMPLEADO"
AFTER INSERT OR UPDATE OR DELETE ON "DBADMIN"."EMPLEADO"
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_EMPLEADO" (
            "ID_EMPLEADO", "NOMBRE", "APELLIDO", "CORREO", "TELEFONO", 
            "ID_SUCURSAL", "ACTIVO", "OPERACION", 
            "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :NEW."ID_EMPLEADO", :NEW."NOMBRE", :NEW."APELLIDO", 
            :NEW."CORREO", :NEW."TELEFONO", :NEW."ID_SUCURSAL", 
            :NEW."ACTIVO", 'INSERT', 
            SYSTIMESTAMP, USER
        );
    ELSIF UPDATING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_EMPLEADO" (
            "ID_EMPLEADO", "NOMBRE", "APELLIDO", "CORREO", "TELEFONO", 
            "ID_SUCURSAL", "ACTIVO", "OPERACION", 
            "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :NEW."ID_EMPLEADO", :NEW."NOMBRE", :NEW."APELLIDO", 
            :NEW."CORREO", :NEW."TELEFONO", :NEW."ID_SUCURSAL", 
            :NEW."ACTIVO", 'UPDATE', 
            SYSTIMESTAMP, USER
        );
    ELSIF DELETING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_EMPLEADO" (
            "ID_EMPLEADO", "NOMBRE", "APELLIDO", "CORREO", "TELEFONO", 
            "ID_SUCURSAL", "ACTIVO", "OPERACION", 
            "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :OLD."ID_EMPLEADO", :OLD."NOMBRE", :OLD."APELLIDO", 
            :OLD."CORREO", :OLD."TELEFONO", :OLD."ID_SUCURSAL", 
            :OLD."ACTIVO", 'DELETE', 
            SYSTIMESTAMP, USER
        );
    END IF;
END;

--------------------------------------------------------
--  trigger  for Table SUCURSAL
--------------------------------------------------------

CREATE OR REPLACE TRIGGER "DBADMIN"."TRG_AUDITORIA_SUCURSAL"
AFTER INSERT OR UPDATE OR DELETE ON "DBADMIN"."SUCURSAL"
FOR EACH ROW
BEGIN
    IF INSERTING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_SUCURSAL" (
            "ID_SUCURSAL", "NOMBRE", "UBICACION", "TELEFONO", 
            "OPERACION", "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :NEW."ID_SUCURSAL", :NEW."NOMBRE", :NEW."UBICACION", 
            :NEW."TELEFONO", 'INSERT', 
            SYSTIMESTAMP, USER
        );
    ELSIF UPDATING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_SUCURSAL" (
            "ID_SUCURSAL", "NOMBRE", "UBICACION", "TELEFONO", 
            "OPERACION", "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :NEW."ID_SUCURSAL", :NEW."NOMBRE", :NEW."UBICACION", 
            :NEW."TELEFONO", 'UPDATE', 
            SYSTIMESTAMP, USER
        );
    ELSIF DELETING THEN
        INSERT INTO "DBADMIN"."AUDITORIA_SUCURSAL" (
            "ID_SUCURSAL", "NOMBRE", "UBICACION", "TELEFONO", 
            "OPERACION", "FECHA_OPERACION", "USUARIO"
        ) VALUES (
            :OLD."ID_SUCURSAL", :OLD."NOMBRE", :OLD."UBICACION", 
            :OLD."TELEFONO", 'DELETE', 
            SYSTIMESTAMP, USER
        );
    END IF;
END;
--------------------------------------------------------
--  trigger  for Table inicio sesion
--------------------------------------------------------

CREATE OR REPLACE TRIGGER trg_audit_logon
AFTER LOGON ON DATABASE
DECLARE
    v_username VARCHAR2(100);
BEGIN
    
    SELECT USER INTO v_username FROM dual;

 
    INSERT INTO audit_sesion (username, operation, session_id)
    VALUES (v_username, 'INICIO DE SESIÓN', SYS_CONTEXT('USERENV', 'SESSIONID'));
END;

CREATE OR REPLACE TRIGGER trg_audit_logoff
BEFORE LOGOFF ON DATABASE
DECLARE
    v_username VARCHAR2(100);
BEGIN
    
    SELECT USER INTO v_username FROM dual;

    
    INSERT INTO audit_sesion (username, operation, session_id)
    VALUES (v_username, 'CIERRE DE SESIÓN', SYS_CONTEXT('USERENV', 'SESSIONID'));
END;
