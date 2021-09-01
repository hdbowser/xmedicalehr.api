using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xmedical_ehr.Migrations
{
    public partial class changesSomeConfigurationClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "4eae19b4-72a6-4007-826a-8658780a4449");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "5e46571c-3e37-471a-89c0-67cb537b3435");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "e69f77d5-7712-4bd1-abe4-cf9d6434085e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1872ffce-b45f-488a-aa1e-371ff7004f8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86065938-65e8-4258-8a59-9c9f78a15321");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "0217ca5b-9adc-45a7-a215-2bc058b40f58");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "5401ac1b-f904-4a58-8284-a27b3bd5c061");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "649fc467-7536-43f2-81df-b37df1503508");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "6516f4fc-5562-42df-b2d8-3a5ffe58b937");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "8cf6b0c3-8a05-4cc0-a49f-6913fb918566");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "93ad4bb1-0983-4175-b44f-6a54413a12fb");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "1bbe4827-824c-490d-afa0-35287613cda0");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "3685fc44-8a11-429b-a40a-e98aa0531c8b");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "f34c0149-c03d-40aa-83d4-2bb8902dca66");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "5f22a5f5-0e66-4043-abae-6fea7ccbd1e6");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "c700f3d8-18cf-42f4-b595-51b17a460f53");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "eec11d9b-baf0-469e-a1c9-35286668ad42");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "40a1025a-9e26-4b1e-b2fe-70c016e4d363");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "b30674fa-9c8b-4c5f-936d-333d295ed8a0");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "c115e3cd-590e-4738-926e-bc670afdee5a");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "5aa1f454-6ad3-42b2-a4b4-2c820e36ace0");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "be9e2f9a-05a3-41aa-938c-abebcc79d456");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "0b95d78c-d284-4f57-b6dc-1ea040beea9d");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "31c61022-8996-4e76-a584-b203763b8e35");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "3709fc66-8389-4749-94ab-0d8c14843c74");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "499d39af-d18d-4677-936f-fe3fd29a2731");

            migrationBuilder.RenameColumn(
                name: "varchar(45)",
                table: "AspNetUsers",
                newName: "Prefix");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Pacientes",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Pacientes",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Pacientes",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prefix",
                table: "AspNetUsers",
                type: "varchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "7dcc5e0a-42f7-4817-825c-be05164ef09d", null, "SENASA" },
                    { "aaace255-825d-452c-91cf-efd3ea9e47cf", null, "ARS HUMANO" },
                    { "5f57b370-fbe9-43cd-af49-c05fb17ad15b", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70680118-54ae-4c17-bf4b-e40075b12ad8", "c2bf8faa-339d-4257-ac16-1819dcbe0562", "Administrador", "admin", "ADMINISTRADOR" },
                    { "9a655ce0-7fd8-412e-aafe-978f015ad628", "cc177ae7-d7ac-40c8-9608-1e2ba937acef", "User", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prefix", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e7db5c7-9ac5-4a6f-b894-53666098645d", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "ba515f72-cd54-4789-addb-448b0b6d2fc6", "HEMOGRAMA", "LAB" },
                    { "37338a79-a955-46ce-9095-b467d24ac12e", "ORINA", "LAB" },
                    { "fb177b55-fe8d-42f3-b766-d6ac3fd80273", "COPROLOGICO", "LAB" },
                    { "f534955f-62a5-456e-9988-c4ccaeac1082", "SONOGRAFIA", "IMG" },
                    { "a73e124b-9f91-43e7-9fd2-709c89e6452d", "TOMOGRAFIA", "IMG" },
                    { "76bf0803-a1d7-4d25-aab2-39dd508185a2", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "a957ee1e-d702-4987-a34e-07ddc7fb4128", "PSIQUIATRICOS" },
                    { "4218cdb3-a2a7-49b7-9f6b-cc603a10ab14", "NO PATOLOGICOS" },
                    { "5db9ff04-9e26-4140-a856-65855bd9df82", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "425c2293-0c34-48ee-8ea9-f0d8449eff06", "Habitacion 301" },
                    { "fe286023-a21d-4016-9a2a-c99e1f77957b", "Habitacion 302" },
                    { "ab725d10-6c3d-4723-a9d0-6056dfa9e53f", "Habitacion 303" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "948faef4-8cdd-4e5e-b0be-19dee9852471", new DateTime(2021, 8, 17, 16, 11, 57, 642, DateTimeKind.Local).AddTicks(4775), false, "ACETAMINOFEN" },
                    { "b3587611-32ed-4b82-a8fe-6fb1c0d5e129", new DateTime(2021, 8, 17, 16, 11, 57, 643, DateTimeKind.Local).AddTicks(1219), false, "PARACETAMOL" },
                    { "caae1add-49c4-4622-9f86-17bb1971da29", new DateTime(2021, 8, 17, 16, 11, 57, 643, DateTimeKind.Local).AddTicks(1509), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "97b4c63b-0a66-4651-bb5f-3a285e90a170", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "230ab872-1c8f-437b-aa5f-c4966a2caeaf", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "78377314-7187-4601-8afa-f4303984c2b2", "Esposo/a" },
                    { "4b2d4a65-7b00-494f-bd5c-b70a42dcf6e2", "Padre" },
                    { "cfac25ab-cab2-464b-bc6e-b3ac5c4a6b94", "Madre" },
                    { "80a97754-ab11-410b-b40b-7bd85cf1dcea", "Hijo/a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "5f57b370-fbe9-43cd-af49-c05fb17ad15b");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "7dcc5e0a-42f7-4817-825c-be05164ef09d");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "aaace255-825d-452c-91cf-efd3ea9e47cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70680118-54ae-4c17-bf4b-e40075b12ad8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a655ce0-7fd8-412e-aafe-978f015ad628");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e7db5c7-9ac5-4a6f-b894-53666098645d");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "37338a79-a955-46ce-9095-b467d24ac12e");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "76bf0803-a1d7-4d25-aab2-39dd508185a2");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "a73e124b-9f91-43e7-9fd2-709c89e6452d");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "ba515f72-cd54-4789-addb-448b0b6d2fc6");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "f534955f-62a5-456e-9988-c4ccaeac1082");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "fb177b55-fe8d-42f3-b766-d6ac3fd80273");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "4218cdb3-a2a7-49b7-9f6b-cc603a10ab14");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "5db9ff04-9e26-4140-a856-65855bd9df82");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "a957ee1e-d702-4987-a34e-07ddc7fb4128");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "425c2293-0c34-48ee-8ea9-f0d8449eff06");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "ab725d10-6c3d-4723-a9d0-6056dfa9e53f");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "fe286023-a21d-4016-9a2a-c99e1f77957b");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "948faef4-8cdd-4e5e-b0be-19dee9852471");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "b3587611-32ed-4b82-a8fe-6fb1c0d5e129");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "caae1add-49c4-4622-9f86-17bb1971da29");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "97b4c63b-0a66-4651-bb5f-3a285e90a170");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "230ab872-1c8f-437b-aa5f-c4966a2caeaf");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "4b2d4a65-7b00-494f-bd5c-b70a42dcf6e2");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "78377314-7187-4601-8afa-f4303984c2b2");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "80a97754-ab11-410b-b40b-7bd85cf1dcea");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "cfac25ab-cab2-464b-bc6e-b3ac5c4a6b94");

            migrationBuilder.RenameColumn(
                name: "Prefix",
                table: "AspNetUsers",
                newName: "varchar(45)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Pacientes",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Pacientes",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Pacientes",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(45)",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldNullable: true);

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
                    { "3685fc44-8a11-429b-a40a-e98aa0531c8b", "PSIQUIATRICOS" },
                    { "f34c0149-c03d-40aa-83d4-2bb8902dca66", "NO PATOLOGICOS" },
                    { "1bbe4827-824c-490d-afa0-35287613cda0", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "eec11d9b-baf0-469e-a1c9-35286668ad42", "Habitacion 301" },
                    { "c700f3d8-18cf-42f4-b595-51b17a460f53", "Habitacion 302" },
                    { "5f22a5f5-0e66-4043-abae-6fea7ccbd1e6", "Habitacion 303" }
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
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "0b95d78c-d284-4f57-b6dc-1ea040beea9d", "Esposo/a" },
                    { "3709fc66-8389-4749-94ab-0d8c14843c74", "Padre" },
                    { "499d39af-d18d-4677-936f-fe3fd29a2731", "Madre" },
                    { "31c61022-8996-4e76-a584-b203763b8e35", "Hijo/a" }
                });
        }
    }
}
