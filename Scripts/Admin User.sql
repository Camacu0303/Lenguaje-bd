-- Create the user
CREATE USER DBAdmin IDENTIFIED BY password;
GRANT DBA TO DBAdmin;
CREATE TABLESPACE "LenguajeDB"
DATAFILE 'C:\Oracle\Lenguajedb\lenguajedb01.dbf' 
SIZE 100M
AUTOEXTEND ON
NEXT 10M MAXSIZE UNLIMITED;

-- Assign default and temporary tablespaces
ALTER USER DBAdmin 
DEFAULT TABLESPACE "LenguajeDB" 
TEMPORARY TABLESPACE temp;

-- Allocate quotas on the tablespaces
ALTER USER DBAdmin QUOTA UNLIMITED ON "LenguajeDB";