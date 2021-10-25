Build started...
Build succeeded.
CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

START TRANSACTION;

CREATE TABLE `Aseguradoras` (
    `Id` varchar(255) NOT NULL,
    `Nombre` varchar(100) NULL,
    `CodigoInt` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetRoles` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayName` varchar(150) NULL,
    `Name` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoles` PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetUsers` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(150) NULL,
    `Prefix` varchar(45) NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(256) CHARACTER SET utf8mb4 NULL,
    `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 NULL,
    `EmailConfirmed` tinyint(1) NOT NULL,
    `PasswordHash` longtext CHARACTER SET utf8mb4 NULL,
    `SecurityStamp` longtext CHARACTER SET utf8mb4 NULL,
    `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumber` longtext CHARACTER SET utf8mb4 NULL,
    `PhoneNumberConfirmed` tinyint(1) NOT NULL,
    `TwoFactorEnabled` tinyint(1) NOT NULL,
    `LockoutEnd` datetime(6) NULL,
    `LockoutEnabled` tinyint(1) NOT NULL,
    `AccessFailedCount` int NOT NULL,
    CONSTRAINT `PK_AspNetUsers` PRIMARY KEY (`Id`)
);

CREATE TABLE `Departamentos` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(100) NULL,
    `Deleted` tinyint(1) NOT NULL DEFAULT FALSE,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Empresas` (
    `Id` varchar(255) NOT NULL,
    `Nombre` varchar(255) NULL,
    `Telefono` varchar(45) NULL,
    `Direccion` varchar(200) NULL,
    `Eslogan` varchar(200) NULL,
    `Logo` varbinary(2038) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Enfermedades` (
    `Id` varchar(255) NOT NULL,
    `Catalogo` varchar(45) NULL,
    `Codigo` varchar(45) NULL,
    `Descripcion` varchar(1024) NULL,
    `Keywords` varchar(2045) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Estudios` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(512) NULL,
    `Tipo` varchar(45) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `ExploracionItemTemplates` (
    `Id` varchar(255) NOT NULL,
    `Nombre` varchar(100) NULL,
    `Deleted` tinyint NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `GruposAntecedentes` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(100) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Habitaciones` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(45) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Medicamentos` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(512) NULL,
    `CreatedAt` datetime NOT NULL,
    `Deleted` tinyint(1) NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Nacionalidades` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(100) NULL,
    `CodigoInt` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Provincias` (
    `Id` varchar(255) NOT NULL,
    `Nombre` varchar(200) NULL,
    `CodigoInt` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `Sustancias` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(200) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `TiposAtenciones` (
    `Id` varchar(45) NOT NULL,
    `Descripcion` varchar(45) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `TiposNotasMedicas` (
    `Id` varchar(45) NOT NULL,
    `Descripcion` varchar(45) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `TiposParentescos` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(45) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetRoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetRoleClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ClaimType` longtext CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderKey` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderDisplayName` longtext CHARACTER SET utf8mb4 NULL,
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserLogins` PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserRoles` (
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `RoleId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AspNetUserRoles` PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AspNetUserTokens` PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `TiposAntecedentes` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(100) NULL,
    `GrupoId` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_TipoAntecedente_GrupoAntecedente` FOREIGN KEY (`GrupoId`) REFERENCES `GruposAntecedentes` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Camas` (
    `Id` varchar(255) NOT NULL,
    `Descripcion` varchar(50) NULL,
    `HabitacionId` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Cama_Habitacion` FOREIGN KEY (`HabitacionId`) REFERENCES `Habitaciones` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Pacientes` (
    `Id` varchar(255) NOT NULL,
    `Nombres` varchar(100) NULL,
    `PrimerApellido` varchar(100) NOT NULL,
    `SegundoApellido` varchar(100) NOT NULL,
    `Sexo` char(1) NULL,
    `FechaNacimiento` datetime NOT NULL,
    `EstadoCivil` char(1) NULL,
    `Telefono` varchar(20) NULL,
    `Celular` varchar(20) NULL,
    `Email` varchar(100) NULL,
    `Cedula` varchar(20) NOT NULL,
    `Direccion` varchar(250) NULL,
    `Estatura` decimal(10,2) NOT NULL,
    `UnidadEstatura` varchar(10) NULL,
    `NacionalidadId` varchar(255) NULL,
    `ProvinciaId` varchar(255) NULL,
    `Ciudad` varchar(150) NULL,
    `AseguradoraId` varchar(255) NULL,
    `NSS` varchar(20) NULL,
    `NumAsegurado` varchar(20) NULL,
    `Nota` varchar(512) NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` varchar(255) NOT NULL,
    `DeletedAt` datetime NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Pacientes_Aseguradoras` FOREIGN KEY (`AseguradoraId`) REFERENCES `Aseguradoras` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Pacientes_Nacionalidades` FOREIGN KEY (`NacionalidadId`) REFERENCES `Nacionalidades` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Pacientes_Provincias` FOREIGN KEY (`ProvinciaId`) REFERENCES `Provincias` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AlergiasPacientes` (
    `PacienteId` varchar(255) NOT NULL,
    `SustanciaId` varchar(255) NOT NULL,
    `Comentario` varchar(200) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`PacienteId`, `SustanciaId`),
    CONSTRAINT `FK_AlergiaPaciente_Pacientea` FOREIGN KEY (`PacienteId`) REFERENCES `Pacientes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AlergiasPacientes_Sustancias_SustanciaId` FOREIGN KEY (`SustanciaId`) REFERENCES `Sustancias` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AntecedentesPacientes` (
    `PacienteId` varchar(255) NOT NULL,
    `TipoAntecedenteId` varchar(255) NOT NULL,
    `Detalle` varchar(255) NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `Deleted` tinyint NOT NULL,
    `DeletedAt` datetime NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`PacienteId`, `TipoAntecedenteId`),
    CONSTRAINT `FK_AntecedentePaciente_Paciente` FOREIGN KEY (`PacienteId`) REFERENCES `Pacientes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AntecedentePaciente_TipoAntecedente` FOREIGN KEY (`TipoAntecedenteId`) REFERENCES `TiposAntecedentes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AtencionesMedicas` (
    `Id` varchar(255) NOT NULL,
    `PacienteId` varchar(255) NULL,
    `TipoId` varchar(45) NULL,
    `AseguradoraId` varchar(255) NULL,
    `MedicoId` varchar(255) NULL,
    `FechaIngreso` datetime NOT NULL,
    `EdadPaciente` varchar(100) NULL,
    `CamaId` varchar(255) NULL,
    `Origen` varchar(100) NULL,
    `NombreFinanciador` varchar(200) NULL,
    `TipoFinanciamiento` varchar(20) NULL,
    `FirmaPaciente` varbinary(2048) NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `Deleted` tinyint NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `DeletedAt` datetime NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AtencionesMedicas_Aseguradoras` FOREIGN KEY (`AseguradoraId`) REFERENCES `Aseguradoras` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AtencionesMedicas_Camas` FOREIGN KEY (`CamaId`) REFERENCES `Camas` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AtencionesMedicas_Creator` FOREIGN KEY (`CreatedBy`) REFERENCES `AspNetUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AtencionesMedicas_Medicos` FOREIGN KEY (`MedicoId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AtencionesMedicas_Pacientes` FOREIGN KEY (`PacienteId`) REFERENCES `Pacientes` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AtencionesMedicas_TipoAtenciones` FOREIGN KEY (`TipoId`) REFERENCES `TiposAtenciones` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `PacientesParentescos` (
    `PacienteId` varchar(255) NOT NULL,
    `TipoParentescoId` varchar(255) NOT NULL,
    `ParentescoId` varchar(255) NOT NULL,
    `Comentario` varchar(200) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`PacienteId`, `TipoParentescoId`, `ParentescoId`),
    CONSTRAINT `FK_PacienteParentescos_Pacientes` FOREIGN KEY (`PacienteId`) REFERENCES `Pacientes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_PacientesParentesco_TiposParentesco` FOREIGN KEY (`TipoParentescoId`) REFERENCES `TiposParentescos` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ParentescosPaciente_Pacientes` FOREIGN KEY (`ParentescoId`) REFERENCES `Pacientes` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `NotasEnfermeria` (
    `Id` varchar(255) NOT NULL,
    `AtencionId` varchar(255) NULL,
    `HabitusExterior` mediumtext NULL,
    `Observaciones` mediumtext NULL,
    `EnfermeraId` varchar(255) NULL,
    `Fecha` datetime NOT NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `DeletedAt` datetime NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_NotaEnfermeria_AtencionMedia` FOREIGN KEY (`AtencionId`) REFERENCES `AtencionesMedicas` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_NotaEnfermeria_Enfermera` FOREIGN KEY (`EnfermeraId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `NotasMedica` (
    `Id` varchar(255) NOT NULL,
    `AtencionId` varchar(255) NULL,
    `MotivoConsulta` mediumtext NULL,
    `HistoriaEnfermedad` mediumtext NULL,
    `Nota` mediumtext NULL,
    `TipoNotaId` varchar(255) NULL,
    `DeOrden` tinyint(1) NOT NULL,
    `Dieta` varchar(100) NULL,
    `ExamenFisico` mediumtext NULL,
    `Observaciones` mediumtext NULL,
    `MedicoId` varchar(255) NULL,
    `MotivoEgreso` mediumtext NULL,
    `Pronostico` varchar(100) NULL,
    `Fecha` datetime NOT NULL,
    `Peso` decimal(10,2) NOT NULL,
    `UnidadPeso` varchar(45) NULL,
    `EscalaGlasgow` int NOT NULL,
    `EscalaDolor` int NOT NULL,
    `SaturacionOxigeno` int NOT NULL,
    `OtrosParametros` varchar(1024) NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `DeletedAt` datetime(6) NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_NotasMedicas_AtencionesMedica` FOREIGN KEY (`AtencionId`) REFERENCES `AtencionesMedicas` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_NotasMedicas_Medicos` FOREIGN KEY (`MedicoId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_NotasMedicas_TiposNota` FOREIGN KEY (`TipoNotaId`) REFERENCES `TiposNotasMedicas` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `SolicitudesInterconsultas` (
    `AtencionId` varchar(255) NOT NULL,
    `NumItem` int NOT NULL,
    `MedicoId` varchar(255) NULL,
    `DepartamentoId` varchar(255) NULL,
    `MedicoInterconsultadoId` varchar(255) NULL,
    `Motivo` mediumtext NULL,
    `Recomendaciones` mediumtext NULL,
    `Atendido` tinyint(1) NOT NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL,
    `DeletedAt` datetime NOT NULL,
    `DeletedBy` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`AtencionId`, `NumItem`),
    CONSTRAINT `FK_SolicitudInterconsulta_AtencionMedica` FOREIGN KEY (`AtencionId`) REFERENCES `AtencionesMedicas` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SolicitudInterconsulta_Departamento` FOREIGN KEY (`DepartamentoId`) REFERENCES `Departamentos` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SolicitudInterconsulta_MedicoInterconsultado` FOREIGN KEY (`MedicoInterconsultadoId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SolicitudInterconsulta_MedicoSolicitante` FOREIGN KEY (`MedicoId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Medicaciones` (
    `AtencionId` varchar(255) NOT NULL,
    `NumItem` int NOT NULL,
    `NotaEnfermeriaId` varchar(255) NOT NULL,
    `MedicamentoId` varchar(45) NULL,
    `Cantidad` int NOT NULL,
    `Unidad` varchar(25) NULL,
    `Via` varchar(45) NULL,
    `Comentario` varchar(250) NULL,
    `CreatedBy` varchar(255) NULL,
    `CreatedAt` datetime NOT NULL,
    `Deleted` tinyint(1) NOT NULL,
    `DeletedAt` datetime NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`AtencionId`, `NotaEnfermeriaId`, `NumItem`),
    CONSTRAINT `FK_Medicacion_AtencionesMedicas` FOREIGN KEY (`AtencionId`) REFERENCES `AtencionesMedicas` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Medicacion_Medicamentos` FOREIGN KEY (`MedicamentoId`) REFERENCES `Medicamentos` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Medicacion_NotasEnfemeria` FOREIGN KEY (`NotaEnfermeriaId`) REFERENCES `NotasEnfermeria` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Diagnosticos` (
    `NotaMedicaId` varchar(255) NOT NULL,
    `NumItem` varchar(255) NOT NULL,
    `EnfermedadId` varchar(255) NULL,
    `Comentario` varchar(1024) NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `DeletedAt` datetime NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`NotaMedicaId`, `NumItem`),
    CONSTRAINT `FK_Diagnosticos_Enfermerdad` FOREIGN KEY (`EnfermedadId`) REFERENCES `Enfermedades` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Diagnosticos_NotasMedicas` FOREIGN KEY (`NotaMedicaId`) REFERENCES `NotasMedica` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `ExploracionItems` (
    `NotaMedicaId` varchar(255) NOT NULL,
    `ExploracionItemTemplateId` varchar(255) NOT NULL,
    `Descripcion` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL DEFAULT FALSE,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`NotaMedicaId`, `ExploracionItemTemplateId`),
    CONSTRAINT `FK_ExploracionItem_ExploracionItemTemplate` FOREIGN KEY (`ExploracionItemTemplateId`) REFERENCES `ExploracionItemTemplates` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_ExploracionItem_NotasMedicas` FOREIGN KEY (`NotaMedicaId`) REFERENCES `NotasMedica` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `NotaMedicaCustomFields` (
    `NotaMedicaId` varchar(255) NOT NULL,
    `NumItem` int NOT NULL,
    `Titulo` varchar(255) NULL,
    `Valor` mediumtext NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`NotaMedicaId`, `NumItem`),
    CONSTRAINT `FK_NotasMedicasCustomField_NotasMedica` FOREIGN KEY (`NotaMedicaId`) REFERENCES `NotasMedica` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `OrdenesMedica` (
    `NotaMedicaId` varchar(255) NOT NULL,
    `NumItem` int NOT NULL,
    `TipoId` varchar(45) NULL,
    `MedicamentoId` varchar(255) NULL,
    `Unidad` varchar(45) NULL,
    `Cantiad` decimal(65,30) NOT NULL,
    `Via` varchar(100) NULL,
    `Intervalo` int NOT NULL,
    `Tiempo` varchar(45) NULL,
    `Monodosis` tinyint(1) NOT NULL,
    `NumDiagnostico` int NOT NULL,
    `TiempoExpiracion` int NOT NULL,
    `Suspendido` tinyint(1) NOT NULL,
    `EstudioId` varchar(255) NULL,
    `Fecha` datetime NOT NULL,
    `Instruccciones` mediumtext NULL,
    `Comentario` mediumtext NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `Deleted` tinyint NOT NULL,
    `DeletedBy` varchar(255) NULL,
    `DeletedAt` datetime NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    CONSTRAINT `PK_OrdenesMedica` PRIMARY KEY (`NotaMedicaId`, `NumItem`),
    CONSTRAINT `FK_OrdenesMedica_Estudios` FOREIGN KEY (`EstudioId`) REFERENCES `Estudios` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_OrdenesMedica_Medicamentos` FOREIGN KEY (`MedicamentoId`) REFERENCES `Medicamentos` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_OrdenesMedica_NotasMedica` FOREIGN KEY (`NotaMedicaId`) REFERENCES `NotasMedica` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SignosVitales` (
    `AtencionId` varchar(255) NOT NULL,
    `NumItem` int NOT NULL,
    `NotaMedicaId` varchar(255) NULL,
    `NotaEnfermeriaId` varchar(255) NULL,
    `Origen` varchar(10) NULL,
    `Temperatura` decimal(10,2) NOT NULL,
    `UnidadTemperatura` varchar(15) NULL,
    `FrecuenciaRespiratoria` int NOT NULL,
    `FrecuenciaCardiaca` int NOT NULL,
    `PresionSistolica` int NOT NULL,
    `PresionDiastolica` int NOT NULL,
    `Diuresis` decimal(10,2) NOT NULL,
    `CreatedAt` datetime NOT NULL,
    `CreatedBy` varchar(255) NULL,
    `UpdatedAt` datetime NOT NULL,
    `UpdatedBy` varchar(255) NULL,
    `Deleted` tinyint(1) NOT NULL,
    `DeletedAt` datetime NOT NULL,
    `DeletedBy` varchar(255) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`AtencionId`, `NumItem`),
    CONSTRAINT `FK_SignosVitales_Atenciones` FOREIGN KEY (`AtencionId`) REFERENCES `AtencionesMedicas` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SignosVitales_NotasEnfermeria` FOREIGN KEY (`NotaEnfermeriaId`) REFERENCES `NotasEnfermeria` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SignosVitales_NotasMedica` FOREIGN KEY (`NotaMedicaId`) REFERENCES `NotasMedica` (`Id`) ON DELETE RESTRICT
);

INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('1c06702c-530c-45df-b2d0-002b6bea4637', NULL, 'SENASA');
INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('ccd6f37e-1107-4e8a-9cdc-51d9998f0bf0', NULL, 'ARS HUMANO');
INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('c83dab48-2bcc-497b-86fb-d304bc17db04', NULL, 'UNIVERSAL');

INSERT INTO `AspNetRoles` (`Id`, `ConcurrencyStamp`, `DisplayName`, `Name`, `NormalizedName`)
VALUES ('0c2dc9fb-f24f-49b7-91c6-20272304e7f5', '60e40e87-38d5-436e-b7db-e214f819ca14', 'Administrador', 'admin', 'ADMINISTRADOR');
INSERT INTO `AspNetRoles` (`Id`, `ConcurrencyStamp`, `DisplayName`, `Name`, `NormalizedName`)
VALUES ('bb3e7273-1d4b-4667-95f0-41e681a8c245', 'b3c129f6-ece3-4cfb-bc96-d46ada8c2af2', 'User', 'user', 'USER');

INSERT INTO `AspNetUsers` (`Id`, `AccessFailedCount`, `ConcurrencyStamp`, `Email`, `EmailConfirmed`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PhoneNumber`, `PhoneNumberConfirmed`, `Prefix`, `SecurityStamp`, `TwoFactorEnabled`, `UserName`)
VALUES ('cd433001-3f7d-4793-bd75-71c9e4da7f6b', 0, 'd9b82e89-edd5-48a0-a728-7e92c90fb921', 'root@system.local', FALSE, FALSE, NULL, 'Root', 'ROOT@SYSTEM.LOCAL', 'ROOT@SYSTEM.LOCAL', 'AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==', NULL, FALSE, 'Sr', '6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW', FALSE, 'root@system.local');

INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('d9ea403e-e550-4306-80bf-4fb107d1176b', 'HEMOGRAMA', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('0fadc010-7525-428d-a1b4-4ca76d097f4d', 'ORINA', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('4ebc94ca-98ae-49d7-a616-e5675f82906d', 'COPROLOGICO', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('edbe48ec-5253-4389-836e-cf13cf7de49c', 'SONOGRAFIA', 'IMG');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('cadb7537-3f77-46fe-9599-555f6137a6e4', 'TOMOGRAFIA', 'IMG');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('4d2cc093-6cf7-48b3-93dc-844f213fe90e', 'RADIOGRAFIA', 'IMG');

INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('6c412c62-74e2-4077-bd99-190176f26003', 'PATOLOGICOS');
INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('5846b6c0-1ee8-4255-a93e-bcd61bb588f2', 'NO PATOLOGICOS');
INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('46d31292-2fb9-4986-9c1f-b94aa075870b', 'PSIQUIATRICOS');

INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('cc65eb17-96f8-43ac-b22b-bb4645d8f536', 'Habitacion 303');
INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('f472afae-c219-45b5-abc7-04420f03a609', 'Habitacion 302');
INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('82715739-71b7-4b87-8dd6-196240c3e454', 'Habitacion 301');

INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('b8c88814-bbb4-41a8-a61f-620df9890a35', '2021-09-14 16:27:12', FALSE, 'ACETAMINOFEN');
INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('e6a71a8e-f718-4718-8c0c-814edc54c731', '2021-09-14 16:27:12', FALSE, 'PARACETAMOL');
INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('78578d72-9d9a-4453-8df4-a26f6a38b82a', '2021-09-14 16:27:12', FALSE, 'SOLUCION SALINA MIXTA 1000ml');

INSERT INTO `Nacionalidades` (`Id`, `CodigoInt`, `Descripcion`)
VALUES ('0f993170-77f5-4eac-ba9f-f27823ed091e', NULL, 'Dominicana');

INSERT INTO `Provincias` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('e2d8e515-c6ec-4258-98f7-dad48d10c695', NULL, 'Duarte');

INSERT INTO `TiposAtenciones` (`Id`, `Descripcion`)
VALUES ('E', 'Emergencia');
INSERT INTO `TiposAtenciones` (`Id`, `Descripcion`)
VALUES ('H', 'Hospitalizacion');
INSERT INTO `TiposAtenciones` (`Id`, `Descripcion`)
VALUES ('A', 'Ambulatoria');

INSERT INTO `TiposNotasMedicas` (`Id`, `Descripcion`)
VALUES ('I', 'Ingreso');
INSERT INTO `TiposNotasMedicas` (`Id`, `Descripcion`)
VALUES ('E', 'Evolucion');
INSERT INTO `TiposNotasMedicas` (`Id`, `Descripcion`)
VALUES ('EG', 'Egreso');

INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('1b0f6b1a-42a2-4c77-9d2b-9b362d2a340f', 'Esposo/a');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('e943abd0-0124-4fc6-8242-194809bbfee5', 'Padre');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('ad850dc0-f528-41ca-8225-b213451f2380', 'Madre');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('0ba85b32-885e-4168-83e8-bb4b9eff1ee4', 'Hijo/a');

CREATE INDEX `IX_AlergiasPacientes_SustanciaId` ON `AlergiasPacientes` (`SustanciaId`);

CREATE INDEX `IX_AntecedentesPacientes_PacienteId_TipoAntecedenteId` ON `AntecedentesPacientes` (`PacienteId`, `TipoAntecedenteId`);

CREATE INDEX `IX_AntecedentesPacientes_TipoAntecedenteId` ON `AntecedentesPacientes` (`TipoAntecedenteId`);

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` (`RoleId`);

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` (`NormalizedName`);

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` (`RoleId`);

CREATE INDEX `EmailIndex` ON `AspNetUsers` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` (`NormalizedUserName`);

CREATE INDEX `IX_AtencionesMedicas_AseguradoraId` ON `AtencionesMedicas` (`AseguradoraId`);

CREATE INDEX `IX_AtencionesMedicas_CamaId` ON `AtencionesMedicas` (`CamaId`);

CREATE INDEX `IX_AtencionesMedicas_CreatedBy` ON `AtencionesMedicas` (`CreatedBy`);

CREATE INDEX `IX_AtencionesMedicas_MedicoId` ON `AtencionesMedicas` (`MedicoId`);

CREATE INDEX `IX_AtencionesMedicas_PacienteId` ON `AtencionesMedicas` (`PacienteId`);

CREATE INDEX `IX_AtencionesMedicas_TipoId` ON `AtencionesMedicas` (`TipoId`);

CREATE INDEX `IX_Camas_HabitacionId` ON `Camas` (`HabitacionId`);

CREATE INDEX `IX_Diagnosticos_EnfermedadId` ON `Diagnosticos` (`EnfermedadId`);

CREATE INDEX `IX_ExploracionItems_ExploracionItemTemplateId` ON `ExploracionItems` (`ExploracionItemTemplateId`);

CREATE INDEX `IX_Medicaciones_MedicamentoId` ON `Medicaciones` (`MedicamentoId`);

CREATE INDEX `IX_Medicaciones_NotaEnfermeriaId` ON `Medicaciones` (`NotaEnfermeriaId`);

CREATE INDEX `IX_NotasEnfermeria_AtencionId` ON `NotasEnfermeria` (`AtencionId`);

CREATE INDEX `IX_NotasEnfermeria_EnfermeraId` ON `NotasEnfermeria` (`EnfermeraId`);

CREATE INDEX `IX_NotasMedica_AtencionId` ON `NotasMedica` (`AtencionId`);

CREATE INDEX `IX_NotasMedica_MedicoId` ON `NotasMedica` (`MedicoId`);

CREATE INDEX `IX_NotasMedica_TipoNotaId` ON `NotasMedica` (`TipoNotaId`);

CREATE INDEX `IX_OrdenesMedica_EstudioId` ON `OrdenesMedica` (`EstudioId`);

CREATE INDEX `IX_OrdenesMedica_MedicamentoId` ON `OrdenesMedica` (`MedicamentoId`);

CREATE UNIQUE INDEX `Cedula_UNIQUE` ON `Pacientes` (`Cedula`);

CREATE INDEX `IX_Pacientes_AseguradoraId` ON `Pacientes` (`AseguradoraId`);

CREATE INDEX `IX_Pacientes_NacionalidadId` ON `Pacientes` (`NacionalidadId`);

CREATE INDEX `IX_Pacientes_ProvinciaId` ON `Pacientes` (`ProvinciaId`);

CREATE INDEX `IX_PacientesParentescos_ParentescoId` ON `PacientesParentescos` (`ParentescoId`);

CREATE INDEX `IX_PacientesParentescos_TipoParentescoId` ON `PacientesParentescos` (`TipoParentescoId`);

CREATE UNIQUE INDEX `IX_SignosVitales_AtencionId_NotaMedicaId_NumItem` ON `SignosVitales` (`AtencionId`, `NotaMedicaId`, `NumItem`);

CREATE INDEX `IX_SignosVitales_NotaEnfermeriaId` ON `SignosVitales` (`NotaEnfermeriaId`);

CREATE INDEX `IX_SignosVitales_NotaMedicaId` ON `SignosVitales` (`NotaMedicaId`);

CREATE INDEX `IX_SolicitudesInterconsultas_DepartamentoId` ON `SolicitudesInterconsultas` (`DepartamentoId`);

CREATE INDEX `IX_SolicitudesInterconsultas_MedicoId` ON `SolicitudesInterconsultas` (`MedicoId`);

CREATE INDEX `IX_SolicitudesInterconsultas_MedicoInterconsultadoId` ON `SolicitudesInterconsultas` (`MedicoInterconsultadoId`);

CREATE INDEX `IX_TiposAntecedentes_GrupoId` ON `TiposAntecedentes` (`GrupoId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210914202713_addedUniqueFieldsInSignosVitales', '5.0.0');

COMMIT;

START TRANSACTION;

DROP PROCEDURE IF EXISTS `POMELO_BEFORE_DROP_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID TINYINT(1);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `Extra` = 'auto_increment'
			AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_KEY` = 'PRI'
			LIMIT 1;
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

DROP PROCEDURE IF EXISTS `POMELO_AFTER_ADD_PRIMARY_KEY`;
DELIMITER //
CREATE PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255), IN `COLUMN_NAME_ARGUMENT` VARCHAR(255))
BEGIN
	DECLARE HAS_AUTO_INCREMENT_ID INT(11);
	DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
	DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
	DECLARE SQL_EXP VARCHAR(1000);
	SELECT COUNT(*)
		INTO HAS_AUTO_INCREMENT_ID
		FROM `information_schema`.`COLUMNS`
		WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
			AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
			AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
			AND `COLUMN_TYPE` LIKE '%int%'
			AND `COLUMN_KEY` = 'PRI';
	IF HAS_AUTO_INCREMENT_ID THEN
		SELECT `COLUMN_TYPE`
			INTO PRIMARY_KEY_TYPE
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SELECT `COLUMN_NAME`
			INTO PRIMARY_KEY_COLUMN_NAME
			FROM `information_schema`.`COLUMNS`
			WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
				AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
				AND `COLUMN_NAME` = COLUMN_NAME_ARGUMENT
				AND `COLUMN_TYPE` LIKE '%int%'
				AND `COLUMN_KEY` = 'PRI';
		SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL AUTO_INCREMENT;');
		SET @SQL_EXP = SQL_EXP;
		PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
		EXECUTE SQL_EXP_EXECUTE;
		DEALLOCATE PREPARE SQL_EXP_EXECUTE;
	END IF;
END //
DELIMITER ;

ALTER TABLE `OrdenesMedica` DROP FOREIGN KEY `FK_OrdenesMedica_Estudios`;

ALTER TABLE `OrdenesMedica` DROP FOREIGN KEY `FK_OrdenesMedica_Medicamentos`;

ALTER TABLE `OrdenesMedica` DROP FOREIGN KEY `FK_OrdenesMedica_NotasMedica`;

ALTER TABLE `OrdenesMedica` DROP FOREIGN KEY `FK_OrdenesMedicas_AtencionesMedicas`;

CALL POMELO_BEFORE_DROP_PRIMARY_KEY(NULL, 'OrdenesMedica');
ALTER TABLE `OrdenesMedica` DROP PRIMARY KEY;

ALTER TABLE `OrdenesMedica` ADD CONSTRAINT `FK_OrdenesMedica_Estudios` FOREIGN KEY (`EstudioId`) REFERENCES `Estudios` (`EstudioId`) ON DELETE RESTRICT;

ALTER TABLE `OrdenesMedica` ADD CONSTRAINT `FK_OrdenesMedica_Medicamentos` FOREIGN KEY (`MedicamentoId`) REFERENCES `Medicamentos` (`MedicamentoId`) ON DELETE RESTRICT;

ALTER TABLE `OrdenesMedica` ADD CONSTRAINT `FK_OrdenesMedica_NotasMedica` FOREIGN KEY (`NotaMedicaId`) REFERENCES `NotasMedica` (`NotaMedicaId`) ON DELETE CASCADE;

ALTER TABLE `OrdenesMedica` ADD CONSTRAINT `FK_OrdenesMedicas_AtencionesMedicas` FOREIGN KEY (`AntencionId`) REFERENCES `AtencionesMedicas` (`AntencionId`) ON DELETE CASCADE;

DELETE FROM `Aseguradoras`
WHERE `Id` = '1c06702c-530c-45df-b2d0-002b6bea4637';
SELECT ROW_COUNT();


DELETE FROM `Aseguradoras`
WHERE `Id` = 'c83dab48-2bcc-497b-86fb-d304bc17db04';
SELECT ROW_COUNT();


DELETE FROM `Aseguradoras`
WHERE `Id` = 'ccd6f37e-1107-4e8a-9cdc-51d9998f0bf0';
SELECT ROW_COUNT();


DELETE FROM `AspNetRoles`
WHERE `Id` = '0c2dc9fb-f24f-49b7-91c6-20272304e7f5';
SELECT ROW_COUNT();


DELETE FROM `AspNetRoles`
WHERE `Id` = 'bb3e7273-1d4b-4667-95f0-41e681a8c245';
SELECT ROW_COUNT();


DELETE FROM `AspNetUsers`
WHERE `Id` = 'cd433001-3f7d-4793-bd75-71c9e4da7f6b';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '0fadc010-7525-428d-a1b4-4ca76d097f4d';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '4d2cc093-6cf7-48b3-93dc-844f213fe90e';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '4ebc94ca-98ae-49d7-a616-e5675f82906d';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = 'cadb7537-3f77-46fe-9599-555f6137a6e4';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = 'd9ea403e-e550-4306-80bf-4fb107d1176b';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = 'edbe48ec-5253-4389-836e-cf13cf7de49c';
SELECT ROW_COUNT();


DELETE FROM `GruposAntecedentes`
WHERE `Id` = '46d31292-2fb9-4986-9c1f-b94aa075870b';
SELECT ROW_COUNT();


DELETE FROM `GruposAntecedentes`
WHERE `Id` = '5846b6c0-1ee8-4255-a93e-bcd61bb588f2';
SELECT ROW_COUNT();


DELETE FROM `GruposAntecedentes`
WHERE `Id` = '6c412c62-74e2-4077-bd99-190176f26003';
SELECT ROW_COUNT();


DELETE FROM `Habitaciones`
WHERE `Id` = '82715739-71b7-4b87-8dd6-196240c3e454';
SELECT ROW_COUNT();


DELETE FROM `Habitaciones`
WHERE `Id` = 'cc65eb17-96f8-43ac-b22b-bb4645d8f536';
SELECT ROW_COUNT();


DELETE FROM `Habitaciones`
WHERE `Id` = 'f472afae-c219-45b5-abc7-04420f03a609';
SELECT ROW_COUNT();


DELETE FROM `Medicamentos`
WHERE `Id` = '78578d72-9d9a-4453-8df4-a26f6a38b82a';
SELECT ROW_COUNT();


DELETE FROM `Medicamentos`
WHERE `Id` = 'b8c88814-bbb4-41a8-a61f-620df9890a35';
SELECT ROW_COUNT();


DELETE FROM `Medicamentos`
WHERE `Id` = 'e6a71a8e-f718-4718-8c0c-814edc54c731';
SELECT ROW_COUNT();


DELETE FROM `Nacionalidades`
WHERE `Id` = '0f993170-77f5-4eac-ba9f-f27823ed091e';
SELECT ROW_COUNT();


DELETE FROM `Provincias`
WHERE `Id` = 'e2d8e515-c6ec-4258-98f7-dad48d10c695';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = '0ba85b32-885e-4168-83e8-bb4b9eff1ee4';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = '1b0f6b1a-42a2-4c77-9d2b-9b362d2a340f';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = 'ad850dc0-f528-41ca-8225-b213451f2380';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = 'e943abd0-0124-4fc6-8242-194809bbfee5';
SELECT ROW_COUNT();


ALTER TABLE `OrdenesMedica` MODIFY COLUMN `TiempoExpiracion` int(11) NOT NULL;

ALTER TABLE `OrdenesMedica` MODIFY COLUMN `NumDiagnostico` int(11) NOT NULL;

ALTER TABLE `OrdenesMedica` MODIFY COLUMN `Intervalo` int(11) NOT NULL;

ALTER TABLE `OrdenesMedica` MODIFY COLUMN `NumItem` int(11) NOT NULL;

ALTER TABLE `OrdenesMedica` ADD `AntencionId` varchar(255) NOT NULL DEFAULT '';

ALTER TABLE `OrdenesMedica` ADD CONSTRAINT `PK_OrdenesMedica` PRIMARY KEY (`AntencionId`, `NotaMedicaId`, `NumItem`);

INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('fad74623-3cc9-406d-96b4-294dffcbe367', NULL, 'SENASA');
INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('948c6f5c-39d0-4ceb-ac0e-5260c09c419c', NULL, 'ARS HUMANO');
INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('24df76ea-29cf-42cf-8ed7-4af8ac30c715', NULL, 'UNIVERSAL');

INSERT INTO `AspNetRoles` (`Id`, `ConcurrencyStamp`, `DisplayName`, `Name`, `NormalizedName`)
VALUES ('998706f8-980e-4e08-8261-7c77b0329a47', '27a36baf-a372-4715-8cb7-92bafc75c215', 'Administrador', 'admin', 'ADMINISTRADOR');
INSERT INTO `AspNetRoles` (`Id`, `ConcurrencyStamp`, `DisplayName`, `Name`, `NormalizedName`)
VALUES ('0d8b2c1f-6c3c-4228-8715-aa445246104c', '10a88b6f-dd32-499d-b6ed-a3ef6c38e6da', 'User', 'user', 'USER');

INSERT INTO `AspNetUsers` (`Id`, `AccessFailedCount`, `ConcurrencyStamp`, `Email`, `EmailConfirmed`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PhoneNumber`, `PhoneNumberConfirmed`, `Prefix`, `SecurityStamp`, `TwoFactorEnabled`, `UserName`)
VALUES ('6ba2095a-874a-4d40-b1c5-e551549f4175', 0, 'd9b82e89-edd5-48a0-a728-7e92c90fb921', 'root@system.local', FALSE, FALSE, NULL, 'Root', 'ROOT@SYSTEM.LOCAL', 'ROOT@SYSTEM.LOCAL', 'AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==', NULL, FALSE, 'Sr', '6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW', FALSE, 'root@system.local');

INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('a03d218a-4173-4ede-bbd7-f85e30a5c415', 'HEMOGRAMA', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('19209846-d4f1-41c1-b8d5-9bbeb9e9a1e7', 'ORINA', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('4a3cf727-72db-469d-b301-94818c960cc6', 'COPROLOGICO', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('5ce622f5-95ce-4971-99df-2f075ffed659', 'SONOGRAFIA', 'IMG');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('293ad4c4-1306-4d16-a0b2-d60342506aac', 'TOMOGRAFIA', 'IMG');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('5295640a-e2e4-4482-9510-44d4567e28d0', 'RADIOGRAFIA', 'IMG');

INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('44fbacaa-960f-4c48-997f-aa1a6f350661', 'PSIQUIATRICOS');
INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('b8155a6c-8cdc-44b9-9edd-5fe9ef738ef3', 'NO PATOLOGICOS');
INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('92b4c393-dbce-447e-90bd-b1ecaf8f492d', 'PATOLOGICOS');

INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('ea81bc98-24b3-42c4-b65e-ebf44b29f427', 'Habitacion 301');
INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('82bf17d3-092a-43e1-9741-77adcd2455c3', 'Habitacion 302');
INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('5fd0f5c2-baf8-4436-b908-aa07ff029c0a', 'Habitacion 303');

INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('653ee164-3b4d-449c-bc40-64579fe0b64b', '2021-10-21 11:45:25', FALSE, 'ACETAMINOFEN');
INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('8a9e62d3-d171-4375-b7d3-895269b941d0', '2021-10-21 11:45:25', FALSE, 'PARACETAMOL');
INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('133ce391-8a5c-402d-af02-6fdc8debbcc6', '2021-10-21 11:45:25', FALSE, 'SOLUCION SALINA MIXTA 1000ml');

INSERT INTO `Nacionalidades` (`Id`, `CodigoInt`, `Descripcion`)
VALUES ('c7ce9c01-a305-4d77-b86b-5629bb708abd', NULL, 'Dominicana');

INSERT INTO `Provincias` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('852e7b94-6676-464f-950a-9f6026f3e905', NULL, 'Duarte');

INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('5e0e16f2-84c9-45be-86ab-3f07f012cc4e', 'Esposo/a');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('173d4c6b-5a46-4da6-956d-382951fa9794', 'Padre');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('daefce01-1580-45fe-b3ac-b1c22b92dac4', 'Madre');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('8e4f66b5-32d4-4e9e-9f47-b57a88c174c8', 'Hijo/a');

CREATE INDEX `IX_OrdenesMedica_NotaMedicaId` ON `OrdenesMedica` (`NotaMedicaId`);

ALTER TABLE `OrdenesMedica` ADD CONSTRAINT `FK_OrdenesMedicas_AtencionesMedicas` FOREIGN KEY (`AntencionId`) REFERENCES `AtencionesMedicas` (`Id`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211021154526_addedAtencionIDInOrdenesMedicas', '5.0.0');

DROP PROCEDURE `POMELO_BEFORE_DROP_PRIMARY_KEY`;

DROP PROCEDURE `POMELO_AFTER_ADD_PRIMARY_KEY`;

COMMIT;

START TRANSACTION;

DELETE FROM `Aseguradoras`
WHERE `Id` = '24df76ea-29cf-42cf-8ed7-4af8ac30c715';
SELECT ROW_COUNT();


DELETE FROM `Aseguradoras`
WHERE `Id` = '948c6f5c-39d0-4ceb-ac0e-5260c09c419c';
SELECT ROW_COUNT();


DELETE FROM `Aseguradoras`
WHERE `Id` = 'fad74623-3cc9-406d-96b4-294dffcbe367';
SELECT ROW_COUNT();


DELETE FROM `AspNetRoles`
WHERE `Id` = '0d8b2c1f-6c3c-4228-8715-aa445246104c';
SELECT ROW_COUNT();


DELETE FROM `AspNetRoles`
WHERE `Id` = '998706f8-980e-4e08-8261-7c77b0329a47';
SELECT ROW_COUNT();


DELETE FROM `AspNetUsers`
WHERE `Id` = '6ba2095a-874a-4d40-b1c5-e551549f4175';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '19209846-d4f1-41c1-b8d5-9bbeb9e9a1e7';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '293ad4c4-1306-4d16-a0b2-d60342506aac';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '4a3cf727-72db-469d-b301-94818c960cc6';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '5295640a-e2e4-4482-9510-44d4567e28d0';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = '5ce622f5-95ce-4971-99df-2f075ffed659';
SELECT ROW_COUNT();


DELETE FROM `Estudios`
WHERE `Id` = 'a03d218a-4173-4ede-bbd7-f85e30a5c415';
SELECT ROW_COUNT();


DELETE FROM `GruposAntecedentes`
WHERE `Id` = '44fbacaa-960f-4c48-997f-aa1a6f350661';
SELECT ROW_COUNT();


DELETE FROM `GruposAntecedentes`
WHERE `Id` = '92b4c393-dbce-447e-90bd-b1ecaf8f492d';
SELECT ROW_COUNT();


DELETE FROM `GruposAntecedentes`
WHERE `Id` = 'b8155a6c-8cdc-44b9-9edd-5fe9ef738ef3';
SELECT ROW_COUNT();


DELETE FROM `Habitaciones`
WHERE `Id` = '5fd0f5c2-baf8-4436-b908-aa07ff029c0a';
SELECT ROW_COUNT();


DELETE FROM `Habitaciones`
WHERE `Id` = '82bf17d3-092a-43e1-9741-77adcd2455c3';
SELECT ROW_COUNT();


DELETE FROM `Habitaciones`
WHERE `Id` = 'ea81bc98-24b3-42c4-b65e-ebf44b29f427';
SELECT ROW_COUNT();


DELETE FROM `Medicamentos`
WHERE `Id` = '133ce391-8a5c-402d-af02-6fdc8debbcc6';
SELECT ROW_COUNT();


DELETE FROM `Medicamentos`
WHERE `Id` = '653ee164-3b4d-449c-bc40-64579fe0b64b';
SELECT ROW_COUNT();


DELETE FROM `Medicamentos`
WHERE `Id` = '8a9e62d3-d171-4375-b7d3-895269b941d0';
SELECT ROW_COUNT();


DELETE FROM `Nacionalidades`
WHERE `Id` = 'c7ce9c01-a305-4d77-b86b-5629bb708abd';
SELECT ROW_COUNT();


DELETE FROM `Provincias`
WHERE `Id` = '852e7b94-6676-464f-950a-9f6026f3e905';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = '173d4c6b-5a46-4da6-956d-382951fa9794';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = '5e0e16f2-84c9-45be-86ab-3f07f012cc4e';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = '8e4f66b5-32d4-4e9e-9f47-b57a88c174c8';
SELECT ROW_COUNT();


DELETE FROM `TiposParentescos`
WHERE `Id` = 'daefce01-1580-45fe-b3ac-b1c22b92dac4';
SELECT ROW_COUNT();


ALTER TABLE `OrdenesMedica` CHANGE `Unidad` `UnidadDosis` varchar(45) NULL;

ALTER TABLE `OrdenesMedica` CHANGE `TipoId` `Tipo` varchar(45) NULL;

ALTER TABLE `OrdenesMedica` CHANGE `Cantiad` `CantidadDosis` decimal(65,30) NOT NULL DEFAULT 0.0;

INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('83ff4b07-7679-4d9d-b458-ae3da97f50cf', NULL, 'SENASA');
INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('f39bffcb-a60f-4394-9f9e-13227ead33bd', NULL, 'ARS HUMANO');
INSERT INTO `Aseguradoras` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('a33f0d75-6cc4-4d7c-8f52-f754ca62f365', NULL, 'UNIVERSAL');

INSERT INTO `AspNetRoles` (`Id`, `ConcurrencyStamp`, `DisplayName`, `Name`, `NormalizedName`)
VALUES ('c6fd389f-68f6-47cc-bc11-ac0c453abbe1', 'ff460bd3-978a-4b32-9bd9-49b4dca81153', 'Administrador', 'admin', 'ADMINISTRADOR');
INSERT INTO `AspNetRoles` (`Id`, `ConcurrencyStamp`, `DisplayName`, `Name`, `NormalizedName`)
VALUES ('410be4c9-b0d8-41a5-a318-d4fd8e726c05', '15cbdd67-5dea-43b1-9d47-786882d298f2', 'User', 'user', 'USER');

INSERT INTO `AspNetUsers` (`Id`, `AccessFailedCount`, `ConcurrencyStamp`, `Email`, `EmailConfirmed`, `LockoutEnabled`, `LockoutEnd`, `Name`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PhoneNumber`, `PhoneNumberConfirmed`, `Prefix`, `SecurityStamp`, `TwoFactorEnabled`, `UserName`)
VALUES ('980b0310-9391-42e2-a993-3050913cc211', 0, 'd9b82e89-edd5-48a0-a728-7e92c90fb921', 'root@system.local', FALSE, FALSE, NULL, 'Root', 'ROOT@SYSTEM.LOCAL', 'ROOT@SYSTEM.LOCAL', 'AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==', NULL, FALSE, 'Sr', '6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW', FALSE, 'root@system.local');

INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('dc7b0520-7392-43e9-9e60-381cce4f434e', 'HEMOGRAMA', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('df5ce0db-baa6-425d-9f34-93009e54d9d7', 'ORINA', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('cbf6728f-1e01-4b4e-ae22-38282fc3cc66', 'COPROLOGICO', 'LAB');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('fb05804c-c719-4798-83ae-2bfe3a76c91a', 'SONOGRAFIA', 'IMG');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('25ec36c9-34e5-4eef-a1ef-915d0d23c3d4', 'TOMOGRAFIA', 'IMG');
INSERT INTO `Estudios` (`Id`, `Descripcion`, `Tipo`)
VALUES ('7850f594-a33c-4135-b28c-14e3a1ddede1', 'RADIOGRAFIA', 'IMG');

INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('3ab1da4d-f71e-47fe-b435-39f3e8fa4346', 'PSIQUIATRICOS');
INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('7d17a379-beab-4e03-be45-6d04eaf886c7', 'NO PATOLOGICOS');
INSERT INTO `GruposAntecedentes` (`Id`, `Descripcion`)
VALUES ('66d2033c-7c57-4da1-a60f-1b45cd7e91d3', 'PATOLOGICOS');

INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('9cde42e2-ee5c-4158-8a71-b921e20e7353', 'Habitacion 301');
INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('a3c94bd3-bf7d-4c25-914f-6ea40419b39c', 'Habitacion 302');
INSERT INTO `Habitaciones` (`Id`, `Descripcion`)
VALUES ('4f79839c-1a40-4026-a6d4-b2845617c32a', 'Habitacion 303');

INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('ec087614-a914-4279-a92d-993a292fcb44', '2021-10-25 10:21:51', FALSE, 'ACETAMINOFEN');
INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('c141dc89-2cae-49e3-867d-dc8d6c9a732f', '2021-10-25 10:21:51', FALSE, 'PARACETAMOL');
INSERT INTO `Medicamentos` (`Id`, `CreatedAt`, `Deleted`, `Descripcion`)
VALUES ('c399acc8-da3e-49a5-ac9a-5620fd26652d', '2021-10-25 10:21:51', FALSE, 'SOLUCION SALINA MIXTA 1000ml');

INSERT INTO `Nacionalidades` (`Id`, `CodigoInt`, `Descripcion`)
VALUES ('0222ed7a-a9e7-46b7-8cf9-6b09aaa7aef9', NULL, 'Dominicana');

INSERT INTO `Provincias` (`Id`, `CodigoInt`, `Nombre`)
VALUES ('a920506d-05e3-4b16-90cf-af689bf7f028', NULL, 'Duarte');

INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('5e6f7b81-b5b6-48ef-a392-89dface5946b', 'Esposo/a');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('0152a497-0bcf-40cc-aeb2-b87a649f1135', 'Padre');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('10d9bbfa-f7b9-481d-80fe-59ecda65aec3', 'Madre');
INSERT INTO `TiposParentescos` (`Id`, `Descripcion`)
VALUES ('d72f8ef6-129c-4d06-a3a0-0479cc7969d3', 'Hijo/a');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211025142152_fieldsChangedInOrdenMedica', '5.0.0');

COMMIT;


