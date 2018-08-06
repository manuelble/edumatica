CREATE TABLE departamentos 
    ( iddepartamento INTEGER NOT NULL IDENTITY NOT FOR REPLICATION , 
     Descripcion INTEGER NOT NULL ) 

ALTER TABLE Departamentos ADD constraint departamento_pk PRIMARY KEY CLUSTERED (IdDepartamento)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE empleados (
    idempleados      INTEGER NOT NULL,
    nombre           VARCHAR(200) NOT NULL,
    direccion        VARCHAR(200) NOT NULL,
    telefono         VARCHAR(200) NOT NULL,
    iddepartamento   INTEGER NOT NULL
)


ALTER TABLE Empleados ADD constraint empleados_pk PRIMARY KEY CLUSTERED (IdEmpleados)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

ALTER TABLE Empleados
    ADD CONSTRAINT empleados_departamentos_fk FOREIGN KEY ( iddepartamento )
        REFERENCES departamentos ( iddepartamento )
ON DELETE NO ACTION 

