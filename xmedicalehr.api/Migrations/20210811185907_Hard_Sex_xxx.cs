﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xmedical_ehr.Migrations
{
    public partial class Hard_Sex_xxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aseguradoras",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    CodigoInt = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    DisplayName = table.Column<string>(type: "varchar(150)", nullable: true),
                    Name = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: true),
                    varchar45 = table.Column<string>(name: "varchar(45)", type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(255)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(45)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(200)", nullable: true),
                    Eslogan = table.Column<string>(type: "varchar(200)", nullable: true),
                    Logo = table.Column<byte[]>(type: "varbinary(2038)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enfermedades",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Catalogo = table.Column<string>(type: "varchar(45)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(45)", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(1024)", nullable: true),
                    Keywords = table.Column<string>(type: "varchar(2045)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(512)", nullable: true),
                    Tipo = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExploracionItemTemplates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Deleted = table.Column<sbyte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposAntecedentes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(512)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", nullable: true),
                    CodigoInt = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(200)", nullable: true),
                    CodigoInt = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sustancias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposAtenciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(45)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposNotasMedicas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(45)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposParentescos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Value = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposAntecedentes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", nullable: true),
                    GrupoId = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoAntecedente_GrupoAntecedente",
                        column: x => x.GrupoId,
                        principalTable: "GruposAntecedentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Camas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    HabitacionId = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cama_Habitacion",
                        column: x => x.HabitacionId,
                        principalTable: "Habitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(100)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "varchar(100)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sexo = table.Column<string>(type: "char(1)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    EstadoCivil = table.Column<string>(type: "char(1)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(20)", nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Cedula = table.Column<string>(type: "varchar(20)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(250)", nullable: true),
                    Estatura = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UnidadEstatura = table.Column<string>(type: "varchar(10)", nullable: true),
                    NacionalidadId = table.Column<string>(type: "varchar(255)", nullable: true),
                    ProvinciaId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Ciudad = table.Column<string>(type: "varchar(150)", nullable: true),
                    AseguradoraId = table.Column<string>(type: "varchar(255)", nullable: true),
                    NSS = table.Column<string>(type: "varchar(20)", nullable: true),
                    NumAsegurado = table.Column<string>(type: "varchar(20)", nullable: true),
                    Nota = table.Column<string>(type: "varchar(512)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<string>(type: "varchar(255)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Aseguradoras",
                        column: x => x.AseguradoraId,
                        principalTable: "Aseguradoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Nacionalidades",
                        column: x => x.NacionalidadId,
                        principalTable: "Nacionalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Provincias",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlergiasPacientes",
                columns: table => new
                {
                    PacienteId = table.Column<string>(type: "varchar(255)", nullable: false),
                    SustanciaId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Comentario = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.PacienteId, x.SustanciaId });
                    table.ForeignKey(
                        name: "FK_AlergiaPaciente_Pacientea",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlergiasPacientes_Sustancias_SustanciaId",
                        column: x => x.SustanciaId,
                        principalTable: "Sustancias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AntecedetesPacientes",
                columns: table => new
                {
                    PacienteId = table.Column<string>(type: "varchar(255)", nullable: false),
                    varchar255 = table.Column<string>(name: "varchar(255)", type: "varchar(255)", nullable: false),
                    Detalle = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<sbyte>(type: "tinyint", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.PacienteId, x.varchar255 });
                    table.ForeignKey(
                        name: "FK_AntecedentePaciente_Paciente",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AntecedentePaciente_TipoAntecedente",
                        column: x => x.varchar255,
                        principalTable: "TiposAntecedentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtencionesMedicas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    PacienteId = table.Column<string>(type: "varchar(255)", nullable: true),
                    TipoId = table.Column<string>(type: "varchar(45)", nullable: true),
                    AseguradoraId = table.Column<string>(type: "varchar(255)", nullable: true),
                    MedicoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime", nullable: false),
                    EdadPaciente = table.Column<string>(type: "varchar(100)", nullable: true),
                    CamaId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Origen = table.Column<string>(type: "varchar(100)", nullable: true),
                    NombreFinanciador = table.Column<string>(type: "varchar(200)", nullable: true),
                    TipoFinanciamiento = table.Column<string>(type: "varchar(20)", nullable: true),
                    FirmaPaciente = table.Column<byte[]>(type: "varbinary(2048)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<sbyte>(type: "tinyint", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtencionesMedicas_Aseguradoras",
                        column: x => x.AseguradoraId,
                        principalTable: "Aseguradoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtencionesMedicas_Camas",
                        column: x => x.CamaId,
                        principalTable: "Camas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtencionesMedicas_Creator",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtencionesMedicas_Medicos",
                        column: x => x.MedicoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtencionesMedicas_Pacientes",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtencionesMedicas_TipoAtenciones",
                        column: x => x.TipoId,
                        principalTable: "TiposAtenciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacientesParentescos",
                columns: table => new
                {
                    PacienteId = table.Column<string>(type: "varchar(255)", nullable: false),
                    TipoParentescoId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ParentescoId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Comentario = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.PacienteId, x.TipoParentescoId, x.ParentescoId });
                    table.ForeignKey(
                        name: "FK_PacienteParentescos_Pacientes",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacientesParentesco_TiposParentesco",
                        column: x => x.TipoParentescoId,
                        principalTable: "TiposParentescos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentescosPaciente_Pacientes",
                        column: x => x.ParentescoId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotasEnfermeria",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    AtencionId = table.Column<string>(type: "varchar(255)", nullable: true),
                    HabitusExterior = table.Column<string>(type: "mediumtext", nullable: true),
                    Observaciones = table.Column<string>(type: "mediumtext", nullable: true),
                    EnfermeraId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaEnfermeria_AtencionMedia",
                        column: x => x.AtencionId,
                        principalTable: "AtencionesMedicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotaEnfermeria_Enfermera",
                        column: x => x.EnfermeraId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotasMedica",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    AtencionId = table.Column<string>(type: "varchar(255)", nullable: true),
                    MotivoConsulta = table.Column<string>(type: "mediumtext", nullable: true),
                    HistoriaEnfermedad = table.Column<string>(type: "mediumtext", nullable: true),
                    Nota = table.Column<string>(type: "mediumtext", nullable: true),
                    TipoNotaId = table.Column<string>(type: "varchar(255)", nullable: true),
                    DeOrden = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Dieta = table.Column<string>(type: "varchar(100)", nullable: true),
                    ExamenFisico = table.Column<string>(type: "mediumtext", nullable: true),
                    Observaciones = table.Column<string>(type: "mediumtext", nullable: true),
                    MedicoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    MotivoEgreso = table.Column<string>(type: "mediumtext", nullable: true),
                    Pronostico = table.Column<string>(type: "varchar(100)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UnidadPeso = table.Column<string>(type: "varchar(45)", nullable: true),
                    EscalaGlasgow = table.Column<int>(type: "int", nullable: false),
                    EscalaDolor = table.Column<int>(type: "int", nullable: false),
                    SaturacionOxigeno = table.Column<int>(type: "int", nullable: false),
                    OtrosParametros = table.Column<string>(type: "varchar(1024)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasMedicas_AtencionesMedica",
                        column: x => x.AtencionId,
                        principalTable: "AtencionesMedicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotasMedicas_Medicos",
                        column: x => x.MedicoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotasMedicas_TiposNota",
                        column: x => x.TipoNotaId,
                        principalTable: "TiposNotasMedicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesInterconsultas",
                columns: table => new
                {
                    AtencionId = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumItem = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    DepartamentoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    MedicoInterconsultadoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Motivo = table.Column<string>(type: "mediumtext", nullable: true),
                    Recomendaciones = table.Column<string>(type: "mediumtext", nullable: true),
                    Atendido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.AtencionId, x.NumItem });
                    table.ForeignKey(
                        name: "FK_SolicitudInterconsulta_AtencionMedica",
                        column: x => x.AtencionId,
                        principalTable: "AtencionesMedicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudInterconsulta_Departamento",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudInterconsulta_MedicoInterconsultado",
                        column: x => x.MedicoInterconsultadoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudInterconsulta_MedicoSolicitante",
                        column: x => x.MedicoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicaciones",
                columns: table => new
                {
                    AtencionId = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumItem = table.Column<int>(type: "int", nullable: false),
                    NotaEnfermeriaId = table.Column<string>(type: "varchar(255)", nullable: false),
                    MedicamentoId = table.Column<string>(type: "varchar(45)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Unidad = table.Column<string>(type: "varchar(25)", nullable: true),
                    Via = table.Column<string>(type: "varchar(45)", nullable: true),
                    Comentario = table.Column<string>(type: "varchar(250)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.AtencionId, x.NotaEnfermeriaId, x.NumItem });
                    table.ForeignKey(
                        name: "FK_Medicacion_AtencionesMedicas",
                        column: x => x.AtencionId,
                        principalTable: "AtencionesMedicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicacion_Medicamentos",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medicacion_NotasEnfemeria",
                        column: x => x.NotaEnfermeriaId,
                        principalTable: "NotasEnfermeria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    NotaMedicaId = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumItem = table.Column<string>(type: "varchar(255)", nullable: false),
                    EnfermedadId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Comentario = table.Column<string>(type: "varchar(1024)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.NotaMedicaId, x.NumItem });
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Enfermerdad",
                        column: x => x.EnfermedadId,
                        principalTable: "Enfermedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_NotasMedicas",
                        column: x => x.NotaMedicaId,
                        principalTable: "NotasMedica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExploracionItems",
                columns: table => new
                {
                    NotaMedicaId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ExploracionItemTemplateId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.NotaMedicaId, x.ExploracionItemTemplateId });
                    table.ForeignKey(
                        name: "FK_ExploracionItem_ExploracionItemTemplate",
                        column: x => x.ExploracionItemTemplateId,
                        principalTable: "ExploracionItemTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExploracionItem_NotasMedicas",
                        column: x => x.NotaMedicaId,
                        principalTable: "NotasMedica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotaMedicaCustomFields",
                columns: table => new
                {
                    NotaMedicaId = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumItem = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(255)", nullable: true),
                    Valor = table.Column<string>(type: "mediumtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.NotaMedicaId, x.NumItem });
                    table.ForeignKey(
                        name: "FK_NotasMedicasCustomField_NotasMedica",
                        column: x => x.NotaMedicaId,
                        principalTable: "NotasMedica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesMedica",
                columns: table => new
                {
                    NotaMedicaId = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumItem = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<string>(type: "varchar(45)", nullable: true),
                    MedicamentoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Unidad = table.Column<string>(type: "varchar(45)", nullable: true),
                    Cantiad = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Via = table.Column<string>(type: "varchar(100)", nullable: true),
                    Intervalo = table.Column<int>(type: "int", nullable: false),
                    Tiempo = table.Column<string>(type: "varchar(45)", nullable: true),
                    Monodosis = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NumDiagnostico = table.Column<int>(type: "int", nullable: false),
                    TiempoExpiracion = table.Column<int>(type: "int", nullable: false),
                    Suspendido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EstudioId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Instruccciones = table.Column<string>(type: "mediumtext", nullable: true),
                    Comentario = table.Column<string>(type: "mediumtext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<sbyte>(type: "tinyint", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesMedica", x => new { x.NotaMedicaId, x.NumItem });
                    table.ForeignKey(
                        name: "FK_OrdenesMedica_Estudios",
                        column: x => x.EstudioId,
                        principalTable: "Estudios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesMedica_Medicamentos",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesMedica_NotasMedica",
                        column: x => x.NotaMedicaId,
                        principalTable: "NotasMedica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    AtencionId = table.Column<string>(type: "varchar(255)", nullable: false),
                    NumItem = table.Column<int>(type: "int", nullable: false),
                    NotaMedicaId = table.Column<string>(type: "varchar(255)", nullable: true),
                    NotaEnfermeriaId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Origen = table.Column<string>(type: "varchar(10)", nullable: true),
                    Temperatura = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UnidadTemperatura = table.Column<string>(type: "varchar(15)", nullable: true),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    PresionSistolica = table.Column<int>(type: "int", nullable: false),
                    PresionDiastolica = table.Column<int>(type: "int", nullable: false),
                    Diuresis = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(255)", nullable: true),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeletedBy = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.AtencionId, x.NumItem });
                    table.ForeignKey(
                        name: "FK_SignosVitales_Atenciones",
                        column: x => x.AtencionId,
                        principalTable: "AtencionesMedicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignosVitales_NotasEnfermeria",
                        column: x => x.NotaEnfermeriaId,
                        principalTable: "NotasEnfermeria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SignosVitales_NotasMedica",
                        column: x => x.NotaMedicaId,
                        principalTable: "NotasMedica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "5e46571c-3e37-471a-89c0-67cb537b3435", null, "SENASA" },
                    { "4eae19b4-72a6-4007-826a-8658780a4449", null, "ARS HUMANO" },
                    { "e69f77d5-7712-4bd1-abe4-cf9d6434085e", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[] { "1872ffce-b45f-488a-aa1e-371ff7004f8c", "e45c8741-fac3-4121-b2f1-ab469ad0b04b", "Administrador", "admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "varchar(45)", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "86065938-65e8-4258-8a59-9c9f78a15321", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "6516f4fc-5562-42df-b2d8-3a5ffe58b937", "HEMOGRAMA", "LAB" },
                    { "0217ca5b-9adc-45a7-a215-2bc058b40f58", "ORINA", "LAB" },
                    { "8cf6b0c3-8a05-4cc0-a49f-6913fb918566", "COPROLOGICO", "LAB" },
                    { "93ad4bb1-0983-4175-b44f-6a54413a12fb", "SONOGRAFIA", "IMG" },
                    { "649fc467-7536-43f2-81df-b37df1503508", "TOMOGRAFIA", "IMG" },
                    { "5401ac1b-f904-4a58-8284-a27b3bd5c061", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "1bbe4827-824c-490d-afa0-35287613cda0", "PATOLOGICOS" },
                    { "f34c0149-c03d-40aa-83d4-2bb8902dca66", "NO PATOLOGICOS" },
                    { "3685fc44-8a11-429b-a40a-e98aa0531c8b", "PSIQUIATRICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "5f22a5f5-0e66-4043-abae-6fea7ccbd1e6", "Habitacion 303" },
                    { "c700f3d8-18cf-42f4-b595-51b17a460f53", "Habitacion 302" },
                    { "eec11d9b-baf0-469e-a1c9-35286668ad42", "Habitacion 301" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "c115e3cd-590e-4738-926e-bc670afdee5a", new DateTime(2021, 8, 11, 14, 59, 3, 470, DateTimeKind.Local).AddTicks(6978), false, "ACETAMINOFEN" },
                    { "40a1025a-9e26-4b1e-b2fe-70c016e4d363", new DateTime(2021, 8, 11, 14, 59, 3, 474, DateTimeKind.Local).AddTicks(5091), false, "PARACETAMOL" },
                    { "b30674fa-9c8b-4c5f-936d-333d295ed8a0", new DateTime(2021, 8, 11, 14, 59, 3, 474, DateTimeKind.Local).AddTicks(5175), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "5aa1f454-6ad3-42b2-a4b4-2c820e36ace0", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "be9e2f9a-05a3-41aa-938c-abebcc79d456", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposAtenciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "E", "Emergencia" },
                    { "H", "Hospitalizacion" },
                    { "A", "Ambulatoria" }
                });

            migrationBuilder.InsertData(
                table: "TiposNotasMedicas",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "I", "Ingreso" },
                    { "E", "Evolucion" },
                    { "EG", "Egreso" }
                });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "0b95d78c-d284-4f57-b6dc-1ea040beea9d", "Esposo/a" },
                    { "3709fc66-8389-4749-94ab-0d8c14843c74", "Padre" },
                    { "499d39af-d18d-4677-936f-fe3fd29a2731", "Madre" },
                    { "31c61022-8996-4e76-a584-b203763b8e35", "Hijo/a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlergiasPacientes_SustanciaId",
                table: "AlergiasPacientes",
                column: "SustanciaId");

            migrationBuilder.CreateIndex(
                name: "IX_AntecedetesPacientes_varchar(255)",
                table: "AntecedetesPacientes",
                column: "varchar(255)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AtencionesMedicas_AseguradoraId",
                table: "AtencionesMedicas",
                column: "AseguradoraId");

            migrationBuilder.CreateIndex(
                name: "IX_AtencionesMedicas_CamaId",
                table: "AtencionesMedicas",
                column: "CamaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtencionesMedicas_CreatedBy",
                table: "AtencionesMedicas",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AtencionesMedicas_MedicoId",
                table: "AtencionesMedicas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtencionesMedicas_PacienteId",
                table: "AtencionesMedicas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_AtencionesMedicas_TipoId",
                table: "AtencionesMedicas",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Camas_HabitacionId",
                table: "Camas",
                column: "HabitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_EnfermedadId",
                table: "Diagnosticos",
                column: "EnfermedadId");

            migrationBuilder.CreateIndex(
                name: "IX_ExploracionItems_ExploracionItemTemplateId",
                table: "ExploracionItems",
                column: "ExploracionItemTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaciones_MedicamentoId",
                table: "Medicaciones",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaciones_NotaEnfermeriaId",
                table: "Medicaciones",
                column: "NotaEnfermeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasEnfermeria_AtencionId",
                table: "NotasEnfermeria",
                column: "AtencionId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasEnfermeria_EnfermeraId",
                table: "NotasEnfermeria",
                column: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasMedica_AtencionId",
                table: "NotasMedica",
                column: "AtencionId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasMedica_MedicoId",
                table: "NotasMedica",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasMedica_TipoNotaId",
                table: "NotasMedica",
                column: "TipoNotaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesMedica_EstudioId",
                table: "OrdenesMedica",
                column: "EstudioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesMedica_MedicamentoId",
                table: "OrdenesMedica",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "Cedula_UNIQUE",
                table: "Pacientes",
                column: "Cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_AseguradoraId",
                table: "Pacientes",
                column: "AseguradoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_NacionalidadId",
                table: "Pacientes",
                column: "NacionalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ProvinciaId",
                table: "Pacientes",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesParentescos_ParentescoId",
                table: "PacientesParentescos",
                column: "ParentescoId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientesParentescos_TipoParentescoId",
                table: "PacientesParentescos",
                column: "TipoParentescoId");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_NotaEnfermeriaId",
                table: "SignosVitales",
                column: "NotaEnfermeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_NotaMedicaId",
                table: "SignosVitales",
                column: "NotaMedicaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesInterconsultas_DepartamentoId",
                table: "SolicitudesInterconsultas",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesInterconsultas_MedicoId",
                table: "SolicitudesInterconsultas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesInterconsultas_MedicoInterconsultadoId",
                table: "SolicitudesInterconsultas",
                column: "MedicoInterconsultadoId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposAntecedentes_GrupoId",
                table: "TiposAntecedentes",
                column: "GrupoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlergiasPacientes");

            migrationBuilder.DropTable(
                name: "AntecedetesPacientes");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "ExploracionItems");

            migrationBuilder.DropTable(
                name: "Medicaciones");

            migrationBuilder.DropTable(
                name: "NotaMedicaCustomFields");

            migrationBuilder.DropTable(
                name: "OrdenesMedica");

            migrationBuilder.DropTable(
                name: "PacientesParentescos");

            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "SolicitudesInterconsultas");

            migrationBuilder.DropTable(
                name: "Sustancias");

            migrationBuilder.DropTable(
                name: "TiposAntecedentes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Enfermedades");

            migrationBuilder.DropTable(
                name: "ExploracionItemTemplates");

            migrationBuilder.DropTable(
                name: "Estudios");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "TiposParentescos");

            migrationBuilder.DropTable(
                name: "NotasEnfermeria");

            migrationBuilder.DropTable(
                name: "NotasMedica");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "GruposAntecedentes");

            migrationBuilder.DropTable(
                name: "AtencionesMedicas");

            migrationBuilder.DropTable(
                name: "TiposNotasMedicas");

            migrationBuilder.DropTable(
                name: "Camas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "TiposAtenciones");

            migrationBuilder.DropTable(
                name: "Habitaciones");

            migrationBuilder.DropTable(
                name: "Aseguradoras");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
