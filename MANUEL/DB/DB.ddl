-- Generado por Oracle SQL Developer Data Modeler 18.2.0.179.0756
--   en:        2018-07-29 16:08:38 CDT
--   sitio:      SQL Server 2008
--   tipo:      SQL Server 2008



CREATE TABLE departamentos 
    ( iddepartamento INTEGER NOT NULL IDENTITY NOT FOR REPLICATION , 
     Descripcion INTEGER NOT NULL ) go

ALTER TABLE Departamentos ADD constraint departamento_pk PRIMARY KEY CLUSTERED (IdDepartamento)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go

CREATE TABLE empleados (
    idempleados      INTEGER NOT NULL,
    nombre           VARCHAR(200) NOT NULL,
    direccion        VARCHAR(200) NOT NULL,
    telefono         VARCHAR(200) NOT NULL,
    iddepartamento   INTEGER NOT NULL
)

go

ALTER TABLE Empleados ADD constraint empleados_pk PRIMARY KEY CLUSTERED (IdEmpleados)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go

ALTER TABLE Empleados
    ADD CONSTRAINT empleados_departamentos_fk FOREIGN KEY ( iddepartamento )
        REFERENCES departamentos ( iddepartamento )
ON DELETE NO ACTION 
    ON UPDATE no action go



-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                             2
-- CREATE INDEX                             0
-- ALTER TABLE                              3
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE DATABASE                          0
-- CREATE DEFAULT                           0
-- CREATE INDEX ON VIEW                     0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE ROLE                              0
-- CREATE RULE                              0
-- CREATE SCHEMA                            0
-- CREATE PARTITION FUNCTION                0
-- CREATE PARTITION SCHEME                  0
-- 
-- DROP DATABASE                            0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
