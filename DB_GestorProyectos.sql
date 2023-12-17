CREATE DATABASE DB_GestionProyectos;
USE DB_GestionProyectos;

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
    Estado VARCHAR(100) NULL
);

/*ALTER Table proyectos DROP FOREIGN KEY proyectos_ibfk_1;
ALTER Table proyectos DROP column IdUsuario;*/

CREATE TABLE Tareas(
	IdTarea INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NULL,
    Descripcion VARCHAR(100) NULL,
    FechaInicio DATE NULL,
    FechaVencimiento DATE NULL,
    Estado VARCHAR(100) NULL,
    Prioridad VARCHAR(100) NULL,
    IdEmpleado INT NULL,
    IdUsuario INT NULL,
    IdProyecto INT NULL,
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado) ,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario) ,
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

/********************************* USUARIOS *********************************/

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
    (Dni,  Apellido, Nombre, Role, Telefono, FechaNacimiento, LoginName, Password, Estado, Habilidad, Foto)
    VALUES (pDni, pApellido, pNombre, pRole, pTelefono, pFechaNacimiento, pLoginName, pPassword, pEstado, pHabilidad, pFoto);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarUsuariosOpcion(
	IN cTexto VARCHAR(50)
)
BEGIN
	SELECT u.IdUsuario,
		   u.Dni, 
           u.Apellido,
           u.Nombre,
           u.Role,
           u.Telefono,
           u.FechaNacimiento,
		   u.LoginName,
           u.Password,
           u.Estado,
           u.Habilidad,
           u.Foto,
           "Eliminar" AS op
           
FROM usuarios u

WHERE u.Nombre LIKE CONCAT('%',cTexto,'%');

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarUsuariosActivos
(
	IN cTexto VARCHAR(225)
)
BEGIN
	SELECT u.IdUsuario, u.Apellido
    FROM usuarios u                
	WHERE   u.nombre LIKE CONCAT('%', cTexto , '%') AND u.Estado != 0;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarUsuarioPorTarea
(
	IN pIdTarea INT
)
BEGIN
	SELECT u.IdUsuario, CONCAT(u.Apellido," ",u.Nombre) AS Administrador
FROM usuarios u
INNER JOIN tareas t ON u.IdUsuario = t.IdUsuario
WHERE t.IdTarea = pIdTarea;

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spEliminarUsuario
(
    IN pIdUsuario INT
)
BEGIN
    DELETE FROM usuarios 
    WHERE IdUsuario=pIdUsuario; 
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spActualizarUsuario
(
	IN pIdUsuario INT,
	IN pDni VARCHAR(50),
    IN pNombre VARCHAR(100),
	IN pApellido VARCHAR(100),
    IN pRole VARCHAR(100), 
    IN pTelefono VARCHAR(100),
    IN pFechaNacimiento DATE,
    IN pLoginName VARCHAR(100),
    IN pPassword VARCHAR(100), 
    IN pEstado bit(1),
    IN pHabilidad VARCHAR(50),   
    IN pFoto longblob
)
BEGIN
    UPDATE usuarios SET 
    Dni=pDni,
    Nombre=pNombre,
    Apellido=pApellido,
    Role=pRole,
    Telefono=pTelefono,
    FechaNacimiento=pFechaNacimiento,
    LoginName=pLoginName,
    Password=pPassword,
    Estado = pEstado,
    Habilidad=pHabilidad,
    Foto=pFoto
    WHERE IdUsuario = pIdUsuario;
    
    if pEstado = 0 THEN
		call spDesvincularTareaDeUsuario(pIdUsuario);
    END IF;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spDesvincularTareaDeUsuario
(
	IN pIdUsuario INT
)
BEGIN 
	Update tareas t
    SET t.IdUsuario = null
    WHERE t.IdUsuario = pIdUsuario;
END $$
DELIMITER ;


-- este procedimiento se usara para valiadar si se puede eliminar un usuario
DELIMITER $$
CREATE PROCEDURE spCantidadDeTareasPorUsuario
(
	IN pIdUsuario INT,
    OUT totalTareas INT
)
BEGIN
	SELECT COUNT(*) INTO totalTareas 
    FROM tareas t
    WHERE t.IdUsuario = pIdUsuario;

END $$
DELIMITER ;

/****************************************************************************/

/******************************* EMPLEADOS **********************************/


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
    (Dni, Apellido, Nombre, Role, Telefono, FechaNacimiento, LoginName, Password, Estado, Habilidad, Foto)
    VALUES (pDni, pApellido, pNombre, pRole, pTelefono, pFechaNacimiento, pLoginName, pPassword, pEstado, pHabilidad, pFoto);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarEmpleadosOpcion(
	IN cTexto VARCHAR(50)
)
BEGIN
	SELECT e.IdEmpleado,
		   e.Dni, 
           e.Apellido,
           e.Nombre,
           e.Role,
           e.Telefono,
           e.FechaNacimiento,
		   e.LoginName,
           e.Password,
           e.Estado,
           e.Habilidad,
           e.Foto,
           "Eliminar" AS op
           
FROM empleados e

WHERE e.Nombre LIKE CONCAT('%',cTexto,'%');

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarEmpleadosActivos
(
	IN cTexto VARCHAR(50)
)
BEGIN
	SELECT e.IdEmpleado, Apellido
FROM empleados e

WHERE e.Nombre LIKE CONCAT('%',cTexto,'%') AND e.Estado != 0;

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarEmpleadosPorTarea
(
	IN pIdTarea INT
)
BEGIN
	SELECT e.IdEmpleado, CONCAT(e.Apellido," ",e.Nombre) AS Empleado
FROM empleados e
INNER JOIN tareas t ON e.IdEmpleado = t.IdEmpleado
WHERE t.IdTarea = pIdTarea;

END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spEliminarEmpleado
(
    IN pIdEmpleado INT
)
BEGIN
    DELETE FROM empleados 
    WHERE IdEmpleado=pIdEmpleado; 
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spActualizarEmpleado
(
	IN pIdEmpleado INT,
	IN pDni VARCHAR(50),
    IN pNombre VARCHAR(100),
	IN pApellido VARCHAR(100),
    IN pRole VARCHAR(100), 
    IN pTelefono VARCHAR(100),
    IN pFechaNacimiento DATE,
    IN pLoginName VARCHAR(100),
    IN pPassword VARCHAR(100), 
    IN pEstado bit(1),
    IN pHabilidad VARCHAR(50),   
    IN pFoto longblob
)
BEGIN
    UPDATE empleados SET 
    Dni=pDni,
    Nombre=pNombre,
    Apellido=pApellido,
    Role=pRole,
    Telefono=pTelefono,
    FechaNacimiento=pFechaNacimiento,
    LoginName=pLoginName,
    Password=pPassword,
    Estado = pEstado,
    Habilidad=pHabilidad,
    Foto=pFoto
    WHERE IdEmpleado = pIdEmpleado;
    
    if pEstado = 0 THEN
		call spDesvincularTareaDeEmpleado(pIdEmpleado);
    END IF;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spDesvincularTareaDeEmpleado
(
	IN pIdEmpleado INT
)
BEGIN 
	Update tareas t
    SET t.IdEmpleado = null
    WHERE t.IdEmpleado = pIdEmpleado;
END $$
DELIMITER ;


/****************************************************************************/

/******************************** PROYECTOS *********************************/

DELIMITER $$
CREATE PROCEDURE spCrearProyecto
(
	IN pNombre VARCHAR(100) ,
    IN pDescripcion VARCHAR(100) ,
    IN pFechaInicio DATE ,
    IN pFechaFinalizacion DATE
)
BEGIN
    INSERT INTO proyectos
    (Nombre, Descripcion, FechaInicio, FechaFinalizacion, Estado)
    VALUES(pNombre, pDescripcion, pFechaInicio, pFechaFinalizacion, "Incompleto");
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spActualizarProyecto
(
	IN pIdProyecto INT,
    IN pNombre VARCHAR(100),
	IN pDescripcion VARCHAR(100),
    IN pFechaInicio DATE,
    IN pFechaFinalizacion DATE
)
BEGIN
    UPDATE proyectos SET 
    Nombre=pNombre,
    Descripcion=pDescripcion,
    FechaInicio=pFechaInicio,
    FechaFinalizacion=FechaFinalizacion
    WHERE IdProyecto = pIdProyecto;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spEliminarProyecto
(
    IN pIdProyecto INT
)
BEGIN
    DELETE FROM proyectos 
    WHERE IdProyecto=pIdProyecto; 
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarProyectosOpcion
(
	IN cTexto VARCHAR(50)
)
BEGIN
	SELECT p.IdProyecto,
           p.Nombre,
           p.Descripcion,
           p.FechaInicio,
           p.FechaFinalizacion,
		   p.Estado,
           "Ver Tareas" AS op
	FROM proyectos p

	WHERE p.Nombre LIKE CONCAT('%',cTexto,'%');

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarProyectoPorTarea
(
	IN pIdTarea INT
)
BEGIN
	SELECT p.IdProyecto, p.Nombre AS Proyecto
FROM proyectos p
INNER JOIN tareas t ON p.IdProyecto = t.IdProyecto
WHERE t.IdTarea = pIdTarea;

END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spObtenerPorcentajeDeProyecto
(
	IN pIdProyecto INT,
	OUT porcentaje INT
)
BEGIN
	-- en estas varibles se almacenara lo datos para hacer calculos
	DECLARE totalTareas INT;
    DECLARE tareasFinalizadas INT;
    
    -- cuento y almaceno todas las tareas del proyecto
    SELECT COUNT(*) INTO totalTareas 
    FROM tareas t
    WHERE t.IdProyecto = pIdProyecto;
    
    -- cuento y almaceno solo las tareas que hallan finalizado
    SELECT COUNT(*) INTO tareasFinalizadas 
    FROM tareas t
    WHERE t.IdProyecto = pIdProyecto AND t.Estado = "Finalizado";
    
    -- condicion en caso de que el proyecto no tenga tareas
    if totalTareas != 0 THEN
		set porcentaje = ((tareasFinalizadas * 100) / totalTareas);
	ELSE 
		SET porcentaje = 0;
    END IF;
    
END $$
DELIMITER ;


-- este procedimineto se encarga de verificar que las tareas esten finalizadas
-- para poder finalizar el proyecto 
DELIMITER $$
CREATE PROCEDURE spConsultarEstadoDeProyecto
(
	IN pIdProyecto INT,
	OUT bandera INT
)
BEGIN
	-- en estas varibles se almacenara lo datos para hacer calculos
	DECLARE totalTareas INT;
    DECLARE tareasFinalizadas INT;
    
    -- cuento y almaceno todas las tareas del proyecto
    SELECT COUNT(*) INTO totalTareas 
    FROM tareas t
    WHERE t.IdProyecto = pIdProyecto;
    
    -- cuento y almaceno solo las tareas que hallan finalizado
    SELECT COUNT(*) INTO tareasFinalizadas 
    FROM tareas t
    WHERE t.IdProyecto = pIdProyecto AND t.Estado = "Finalizado";
    
    IF totalTareas = 0 THEN
		SET bandera = 0;
	 ELSEIF totalTareas = tareasFinalizadas THEN
		SET bandera = 1;
	ELSE 
		SET bandera = 0;
	END IF;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spFinalizarProyecto
(
	IN pIdProyecto INT 
)
BEGIN
	UPDATE proyectos SET 
	Estado = "Finalizado"
	WHERE IdProyecto = pIdProyecto;
END $$
DELIMITER ;

/****************************************************************************/

/******************************** TAREAS *********************************/

DELIMITER $$
CREATE PROCEDURE spCrearTarea
(
	IN pNombre VARCHAR(100) ,
    IN pDescripcion VARCHAR(100) ,
    IN pFechaInicio DATE ,
    IN pFechaVencimiento DATE,
	IN pPrioridad VARCHAR(100),
    IN pIdEmpleado INT,
    IN pIdUsuario INT,
    IN pIdProyecto INT
)
BEGIN
    INSERT INTO tareas
    (Nombre, Descripcion, FechaInicio, FechaVencimiento, Estado, Prioridad, IdEmpleado, IdUsuario, IdProyecto)
    VALUES(pNombre, pDescripcion, pFechaInicio, pFechaVencimiento, "No iniciado", pPrioridad, pIdEmpleado, pIdUsuario, pIdProyecto);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarTareas
(
	IN cTexto VARCHAR(50)
)
BEGIN
    SELECT t.IdTarea,
		   t.Nombre,
           t.Descripcion,
           t.FechaInicio,
           t.FechaVencimiento,
           t.Estado,
           t.Prioridad,
           t.IdUsuario,
           t.IdEmpleado,
           t.IdProyecto,
           "Ver Detalle" AS op
	FROM tareas t
    WHERE t.Nombre LIKE CONCAT('%', cTexto , '%');
END $$
DELIMITER ;

/**ALTER TABLE tareas CHANGE FechaVencimineto FechaVencimiento DATE NULL;**/

/*SELECT * FROM tareas;*/


DELIMITER $$
CREATE PROCEDURE spEliminarTarea
(
    IN pIdTarea INT
)
BEGIN
    DELETE FROM tareas 
    WHERE IdTarea=pIdTarea; 
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spActualizarTarea
(
	IN pIdTarea INT,
    IN pNombre VARCHAR(100),
	IN pDescripcion VARCHAR(100),
    IN pFechaInicio DATE,
    IN pFechaVencimiento DATE,
    IN pPrioridad VARCHAR(100),
    IN pIdEmpleado INT,
    IN pIdUsuario INT,
    IN pIdProyecto INT
)
BEGIN
    UPDATE tareas SET 
    Nombre=pNombre,
    Descripcion=pDescripcion,
    FechaInicio=pFechaInicio,
    FechaVencimiento=pFechaVencimiento,
    Prioridad=pPrioridad,
    IdEmpleado=pIdEmpleado,
    IdUsuario = pIdUsuario,
    IdProyecto=pIdProyecto
    WHERE IdTarea = pIdTarea;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarTareasPorProyecto(
	IN pIdProyecto INT
)
BEGIN
	SELECT t.IdTarea,
           t.Nombre,
           t.Descripcion,
           t.FechaInicio,
           t.FechaVencimiento,
		   t.Estado,
           t.Prioridad
	FROM tareas t

	WHERE t.IdProyecto = pIdProyecto;

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spCantidadDeTareasPorProyecto
(
	IN pIdProyecto INT,
    OUT totalTareas INT
)
BEGIN
	SELECT COUNT(*) INTO totalTareas 
    FROM tareas t
    WHERE t.IdProyecto = pIdProyecto;

END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarTareasPorEmpleado
(
	IN pIdEmpleado INT
)
BEGIN
	SELECT t.IdTarea,
		   t.Nombre,
           t.Descripcion,
           t.FechaInicio,
           t.FechaVencimiento,
           t.Estado,
           t.Prioridad,
           p.Nombre AS Proyecto,
           t.IdUsuario,
           t.IdEmpleado,
           t.IdProyecto
	FROM tareas t
    INNER JOIN empleados e ON t.IdEmpleado = e.IdEmpleado
    INNER JOIN proyectos p ON t.IdProyecto = p.IdProyecto 
    WHERE t.IdEmpleado = pIdEmpleado;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarTareasPorVencimiento
(
	IN pIdEmpleado INT
)
BEGIN
	SELECT t.IdTarea,
		   t.Nombre,
           t.Descripcion,
           t.FechaInicio,
           t.FechaVencimiento,
           t.Estado,
           t.Prioridad,
           p.Nombre AS Proyecto,
           t.IdUsuario,
           t.IdEmpleado,
           t.IdProyecto
	FROM tareas t
    INNER JOIN empleados e ON t.IdEmpleado = e.IdEmpleado
    INNER JOIN proyectos p ON t.IdProyecto = p.IdProyecto 
    WHERE t.IdEmpleado = pIdEmpleado
    ORDER BY FechaVencimiento;

END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE spListarTareasPorEstado
(
	IN pIdEmpleado INT,
    IN pEstado VARCHAR(100)
)
BEGIN
	SELECT t.IdTarea,
		   t.Nombre,
           t.Descripcion,
           t.FechaInicio,
           t.FechaVencimiento,
           t.Estado,
           t.Prioridad,
           p.Nombre AS Proyecto,
           t.IdUsuario,
           t.IdEmpleado,
           t.IdProyecto
	FROM tareas t
    INNER JOIN empleados e ON t.IdEmpleado = e.IdEmpleado
    INNER JOIN proyectos p ON t.IdProyecto = p.IdProyecto 
    WHERE t.IdEmpleado = pIdEmpleado AND t.Estado LIKE CONCAT('%', pEstado , '%');

END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spListarTareasPorPrioridad
(
	IN pIdEmpleado INT,
    IN pPrioridad VARCHAR(100)
)
BEGIN
	SELECT t.IdTarea,
		   t.Nombre,
           t.Descripcion,
           t.FechaInicio,
           t.FechaVencimiento,
           t.Estado,
           t.Prioridad,
           p.Nombre AS Proyecto,
           t.IdUsuario,
           t.IdEmpleado,
           t.IdProyecto
	FROM tareas t
    INNER JOIN empleados e ON t.IdEmpleado = e.IdEmpleado
    INNER JOIN proyectos p ON t.IdProyecto = p.IdProyecto 
    WHERE t.IdEmpleado = pIdEmpleado AND t.Prioridad LIKE CONCAT('%', pPrioridad , '%');

END $$
DELIMITER ;

SELECT * FROM tareas 
WHERE IdEmpleado = 3
ORDER BY FechaVencimiento;

SELECT * FROM tareas 
WHERE IdEmpleado = 2
ORDER BY Prioridad DESC;


DELIMITER $$
CREATE PROCEDURE spActualizarEstadoDeTarea
(
	IN pIdTarea INT,
    IN pEstado VARCHAR(100)
)	
BEGIN 
	UPDATE tareas t
    SET t.Estado = pEstado
    WHERE t.IdTarea = pIdTarea;
END $$
DELIMITER ;

/****************************************************************************/

/******************************** TRIGGER *********************************/

DELIMITER $$
CREATE TRIGGER CambiarEstadoDeProyecto
AFTER INSERT ON tareas
FOR EACH ROW
BEGIN 
	UPDATE proyectos p
    SET p.Estado = "Incompleto"
    WHERE p.IdProyecto = NEW.IdProyecto;
END $$
DELIMITER ;



