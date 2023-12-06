CREATE DATABASE DB_GestionProyectos;
USE DB_GestionProyectos;

/*DROP Table empleados;
SELECT * FROM usuarios;
SELECT * FROM empleados;*/

CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY AUTO_INCREMENT,
    Dni VARCHAR(100) NULL,
    Apellido VARCHAR(100) NULL,
    Nombre VARCHAR(100) NULL,
    Role VARCHAR(100) NULL,
    Telefono VARCHAR(100) NULL,
    FechaNacimiento DATE NULL,
    LoginName VARCHAR(100) NULL,
    Password VARCHAR(100) NULL,
    Estado BIT(1) DEFAULT NULL,
    Habilidad VARCHAR(100) NULL,
    Foto LONGBLOB NULL
);
CREATE TABLE Empleados(
	IdEmpleado INT PRIMARY KEY AUTO_INCREMENT,
    Dni VARCHAR(100) NULL,
    Apellido VARCHAR(100) NULL,
    Nombre VARCHAR(100) NULL,
    Role VARCHAR(100) NULL,
    Telefono VARCHAR(100) NULL,
    FechaNacimiento DATE NULL,
    LoginName VARCHAR(100) NULL,
    Password VARCHAR(100) NULL,
    Estado BIT(1) DEFAULT NULL,
    Habilidad VARCHAR(100) NULL,
    Foto LONGBLOB NULL
);

CREATE TABLE Proyectos(
	IdProyecto INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NULL,
    Descripcion VARCHAR(100) NULL,
    FechaInicio DATE NULL,
    FechaFinalizacion DATE NULL,
    Estado VARCHAR(100) NULL,
    IdUsuario INT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Tareas(
	IdTarea INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NULL,
    Descripcion VARCHAR(100) NULL,
    FechaInicio DATE NULL,
    FechaVencimineto DATE NULL,
    IdEmpleado INT NULL,
    IdUsuario INT NULL,
    IdProyecto INT NULL,
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
    FOREIGN KEY (IdProyecto) REFERENCES Proyectos(IdProyecto)
);

/************************ PROCEDIMIENTOS ALMACENADOS ************************/

/************************ LOGIN DE USERS Y EMPELADOS ************************/

DELIMITER $$
CREATE PROCEDURE spLoginUsuario
(
	IN pLoginName VARCHAR (100),
	IN pPassword VARCHAR (100)
)
BEGIN
	SELECT * FROM Usuarios 
    WHERE LoginName=pLoginName AND Password=pPassword;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spLoginEmpleado
(
	IN pLoginName VARCHAR (100),
	IN pPassword VARCHAR (100)
)
BEGIN
	SELECT * FROM Empleados 
    WHERE LoginName = pLoginName AND Password = pPassword;
END $$
DELIMITER ;

/****************************************************************************/

/************************ CREAR PARA TODAS LA TABLAS ************************/

DELIMITER $$
CREATE PROCEDURE spCrearUsuario
(
	IN pDni VARCHAR(100) ,
    IN pApellido VARCHAR(100) ,
    IN pNombre VARCHAR(100) ,
    IN pRole VARCHAR(100) ,
    IN pTelefono VARCHAR(100) ,
    IN pFechaNacimiento DATE ,
    IN pLoginName VARCHAR(100) ,
    IN pPassword VARCHAR(100) ,
    IN pEstado BIT(1)  ,
    IN pHabilidad VARCHAR(100) ,
    IN pFoto LONGBLOB 
)
BEGIN
    INSERT INTO usuarios
    (Dni, Nombre, Apellido, Role, Telefono, FechaNacimiento, LoginName, Password, Estado, Habilidad, Foto)
    VALUES (pDni, pApellido, pNombre, pRole, pTelefono, pFechaNacimiento, pLoginName, pPassword, pEstado, pHabilidad, pFoto);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spCrearEmpleado
(
	IN pDni VARCHAR(100) ,
    IN pApellido VARCHAR(100) ,
    IN pNombre VARCHAR(100) ,
    IN pRole VARCHAR(100) ,
    IN pTelefono VARCHAR(100) ,
    IN pFechaNacimiento DATE ,
    IN pLoginName VARCHAR(100) ,
    IN pPassword VARCHAR(100) ,
    IN pEstado BIT(1)  ,
    IN pHabilidad VARCHAR(100) ,
    IN pFoto LONGBLOB 
)
BEGIN
    INSERT INTO empleados
    (Dni, Nombre, Apellido, Role, Telefono, FechaNacimiento, LoginName, Password, Estado, Habilidad, Foto)
    VALUES (pDni, pApellido, pNombre, pRole, pTelefono, pFechaNacimiento, pLoginName, pPassword, pEstado, pHabilidad, pFoto);
END $$
DELIMITER ;

/*call spCrearUsuario('43698945','Balero','Sergio', 'Administrador','3884668626','2002-03-23','admin','admin',1,'Diseñador','/img/admin.jpg');*/
/*call spCrearEmpleado('42567890','Valero','Tomas', 'Empleado','3875461321','2000-03-23','tomi12','tomi12',1,'Tester','/img/emp.jpg');*/
