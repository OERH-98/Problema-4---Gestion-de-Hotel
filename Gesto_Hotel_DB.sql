--[Base de datos - Gestion de hoteles]
--Hecho por:
--Base de datos y diagramas: Luis Soriano
--Windows Forms y CRUD: Omar Ernesto
--<------------------------------------------------>
--<----------(Creacion de base de datos)----------->
--<------------------------------------------------>
--En este apartado creamos nuestra base de datos que almacenara la informacion del gestor hotelero
CREATE DATABASE Gestor_Hotel_DB
--Automaticamente con el GO y el USE se activara la base de datos
GO
USE Gestor_Hotel_DB
GO
--<------------------------------------------------>
--<------------(Creacion de tablas)---------------->
--<------------------------------------------------>
-- 1. Tabla de Roles
--Tabla encargada de manejar los cargos o roles del usuario
CREATE TABLE Roles (
    idRol INT PRIMARY KEY IDENTITY(1,1),
    nombreRol NVARCHAR(150) NOT NULL UNIQUE
);
GO
-- 2. Tabla de Servicios
--El servicio que tiene derecho el usuario
CREATE TABLE Servicios (
    idServicio INT PRIMARY KEY IDENTITY(1,1),
    fechaRegistroServicio DATETIME NOT NULL DEFAULT GETDATE(),
    nombreServicio NVARCHAR(150) NOT NULL UNIQUE,
    descripcionServicio NVARCHAR (300) NOT NULL
);
GO
-- 3. Tabla de Habitaciones
--Tabla que almacena cada una de las habitaciones del hotel
CREATE TABLE Habitaciones (
    idHabitacion INT PRIMARY KEY IDENTITY(1,1),
    numeroHabitacion INT NOT NULL UNIQUE
);
GO
-- 4. Tabla de Usuarios
--Tabla encargada de manejar informacion personal de las cuentas
CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    correoElectronico NVARCHAR(350) NOT NULL UNIQUE,
    clave NVARCHAR(350) NOT NULL,
    genero NVARCHAR(50) NOT NULL,
    idRol INT NOT NULL,
    nombreSistemaUsuario nvarchar (15) NOT NULL,
    fechaRegistroUsuario DATETIME NOT NULL DEFAULT GETDATE(),
    numeroTelefono VARCHAR(20) NOT NULL, --Almacena el numero telefonico del usuario
    fechaCumpleanios DATE NOT NULL,
    direccion NVARCHAR (150) NOT NULL,
	fotoPerfil VARBINARY (MAX) NULL,
    CONSTRAINT fkRoles FOREIGN KEY (idRol) REFERENCES Roles(idRol) ON DELETE CASCADE
);
GO

CREATE TABLE Clientes(
idCliente INT PRIMARY KEY IDENTITY (1,1),
nombreCliente NVARCHAR (60) NOT NULL,
apellidoCliente NVARCHAR (60) NOT NULL,
fechaRegistroCliente DATETIME NOT NULL DEFAULT GETDATE(),
fechaCumpleanios DATE NOT NULL,
numeroTelefono VARCHAR NOT NULL,
DUI VARCHAR (10) NOT NULL,
direccionCliente NVARCHAR (150) NOT NULL);
-- 5. Tabla de Reservas
--¿El cliente necesita un lugar para vivir temporalmente? La tabla Reservas guarda las habitaciones compradas por clientes
GO
CREATE TABLE Reservas (
    idReserva INT PRIMARY KEY IDENTITY(1,1),
    idHabitacion INT NOT NULL,
    idUsuario INT NOT NULL,
    idServicio INT NOT NULL,
    idCliente INT NOT NULL,
    fechaReserva DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fkRegistradoPorUsuario FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario) ON DELETE CASCADE,
    CONSTRAINT fkHabitacion FOREIGN KEY (idHabitacion) REFERENCES Habitaciones(idHabitacion) ON DELETE CASCADE,
    CONSTRAINT fkServicio FOREIGN KEY (idServicio) REFERENCES Servicios(idServicio) ON DELETE CASCADE,
    CONSTRAINT fkCliente FOREIGN KEY (idCliente) REFERENCES Clientes (idCliente) ON DELETE CASCADE
);

--<------------------------------------------------>
--<------------(Insercion de datos)---------------->
--<------------------------------------------------>
GO
-- Insercion de Servicios
INSERT INTO Servicios (nombreServicio,descripcionServicio)
VALUES
('Estadía todo incluido','Contiene Un acceso Completo al Hotel, con Alimento'),
('Estadía con alimento incluido',''),
('Estadía por 1 dia y 1 noche',''),
('Estadía por 5 dias y 5 noches',''),
('Estadía por 1 año','');
-- Insercion de Roles
GO
INSERT INTO Roles (nombreRol)
VALUES
('Administrador'),
('Recepcionista'),
('Gerente')
GO
-- Insercion de Habitaciones
INSERT INTO Habitaciones (numeroHabitacion)
VALUES
(101), (102), (103), (104), (105),
(106), (107), (108), (109), (110),
(111), (112), (113), (114), (115);
GO

--<------------------------------------------------>
--<-------------(Mostrar con selects)-------------->
--<------------------------------------------------>
-- Muestra los usuarios con su Rol
GO
CREATE VIEW RECEPCIONISTA AS
SELECT
Usuario.nombreSistemaUsuario AS [Nombre de Usuario],
Usuario.nombre AS [Nombre],
Usuario.apellido AS [Apellido],
Usuario.correoElectronico AS [Correo Electrónico],
Usuario.numeroTelefono AS [Numero Telefonico],
Roles.nombreRol AS [Rol],
Usuario.fechaCumpleanios AS [Fecha Nacimiento],
Usuario.genero AS [Genero],
Usuario.direccion as [Direccion],
Usuario.fotoPerfil AS [Foto de perfil],
Usuario.fechaRegistroUsuario AS [Fecha de Registro]
FROM Usuario
INNER JOIN Roles ON Usuario.idRol = Roles.idRol
WHERE Usuario.idRol = 2;
GO
CREATE VIEW GERENTE AS
SELECT
Usuario.nombreSistemaUsuario AS [Nombre de Usuario],
Usuario.nombre AS [Nombre],
Usuario.apellido AS [Apellido],
Usuario.correoElectronico AS [Correo Electrónico],
Usuario.numeroTelefono AS [Numero Telefonico],
Roles.nombreRol AS [Rol],
Usuario.fechaCumpleanios AS [Fecha Nacimiento],
Usuario.genero AS [Genero],
Usuario.direccion as [Direccion],
Usuario.fotoPerfil AS [Foto de perfil],
Usuario.fechaRegistroUsuario AS [Fecha de Registro]
FROM Usuario
INNER JOIN Roles ON Usuario.idRol = Roles.idRol
WHERE Usuario.idRol = 3;
GO
-- Muestra las reservas con Cliente, Habitacion y Servicio
CREATE VIEW RESERVAS_HOTEL AS
SELECT
Habitaciones.numeroHabitacion AS [Habitación asignada],
Clientes.nombreCliente + Clientes.apellidoCliente AS [Cliente asignado],
Servicios.nombreServicio AS [Servicio contratado],
Usuario.nombre + Usuario.apellido AS [Registrado por],
Reservas.fechaReserva AS [Fecha de Reserva]
FROM Reservas
INNER JOIN Habitaciones ON Reservas.idHabitacion = Habitaciones.idHabitacion
INNER JOIN Usuario ON Reservas.idUsuario = Usuario.idUsuario
INNER JOIN Clientes on Reservas.idCliente = Clientes.idCliente
INNER JOIN Servicios ON Reservas.idServicio = Servicios.idServicio;
GO
-- Muestra las habitaciones disponibles
CREATE VIEW HABITACION_HOTEL AS
SELECT numeroHabitacion AS [Número de Habitación]
FROM Habitaciones;
GO

-- Muestra los servicios disponibles
CREATE VIEW SERVICIOS_HOTEL AS
SELECT nombreServicio AS [Definicion del servicio],
Servicios.fechaRegistroServicio AS [Fecha de Registro],
Servicios.descripcionServicio AS [Descripción]
FROM Servicios;
GO
--<------------------------------------------------>
--<-------(Eliminar tablas y resetearlas)---------->
--<------------------------------------------------>
GO
/*DROP TABLE Reservas;
DROP TABLE Usuario;
DROP TABLE Habitaciones;
DROP TABLE Servicios;
DROP TABLE Roles;*/