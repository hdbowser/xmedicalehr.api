using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xmedical_ehr.Migrations
{
    public partial class fixErrorInAntecedentes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "AntecedetesPacientes",
                newName: "AntecedentesPacientes");

            migrationBuilder.RenameColumn(
                name: "varchar(255)",
                table: "AntecedentesPacientes",
                newName: "TipoAntecedenteId");

            migrationBuilder.RenameIndex(
                name: "IX_AntecedetesPacientes_varchar(255)",
                table: "AntecedentesPacientes",
                newName: "IX_AntecedentesPacientes_TipoAntecedenteId");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pacientes",
                type: "char(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "fe3989c8-3b67-46f0-a7d1-e7be8f9ac2f3", null, "SENASA" },
                    { "347ede97-46a0-48d8-a61c-c89f1e162d58", null, "ARS HUMANO" },
                    { "5c19d8a8-51dd-40c6-ae94-e25884bacaea", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0aa0bc80-ad02-4f86-bf92-213c671256c4", "a7549bf1-30f1-4c12-8db7-043a5a520e22", "Administrador", "admin", "ADMINISTRADOR" },
                    { "9e86d6f0-e41d-491f-a1eb-28d1ce993b02", "b2bcfabc-e08d-4553-936b-6469cb2dc90c", "User", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prefix", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8f0fd160-cded-4810-9575-302e0ec9e16c", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "022dfad6-80cb-48b2-8019-a26e95d2234c", "HEMOGRAMA", "LAB" },
                    { "9e16bcc6-1bcf-4b1e-9f6f-8e0b165c20aa", "ORINA", "LAB" },
                    { "71f16b0e-4d8b-4858-ab3f-5b909e24134f", "COPROLOGICO", "LAB" },
                    { "be30eacd-b632-4c74-bf0f-3639a7771c6e", "SONOGRAFIA", "IMG" },
                    { "5ef8f8f7-65bc-4690-bded-05b02b550842", "TOMOGRAFIA", "IMG" },
                    { "451565c9-5665-416d-b4c9-84d984b9bd26", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "f819b2f4-1066-443a-9499-34c70fe3a26c", "PSIQUIATRICOS" },
                    { "ef98bcc5-b080-4d69-a1ba-74d0340c0429", "NO PATOLOGICOS" },
                    { "bcc7298a-61f3-409d-bd90-2538eff495cd", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "e301a299-8754-409b-9717-704fe79d4ce1", "Habitacion 301" },
                    { "748cf6c4-8aad-40a9-b582-7b229ee81930", "Habitacion 302" },
                    { "4f87e010-78cb-4c5a-96da-c5e829e5f442", "Habitacion 303" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "d129ad60-dbc2-46e3-81f9-8de5c8ed48a5", new DateTime(2021, 8, 24, 15, 15, 17, 53, DateTimeKind.Local).AddTicks(8028), false, "ACETAMINOFEN" },
                    { "4f7ab432-69f1-408b-a1b1-a1664d2287a0", new DateTime(2021, 8, 24, 15, 15, 17, 54, DateTimeKind.Local).AddTicks(8116), false, "PARACETAMOL" },
                    { "c96785c8-96db-4b77-a4f7-3b98311cbcab", new DateTime(2021, 8, 24, 15, 15, 17, 54, DateTimeKind.Local).AddTicks(8182), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "ed1c1080-4806-44f5-a09c-5bb49ff11121", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "f6c0856d-931a-4d03-bb77-575722466bd7", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "bc3d4500-1997-4251-9959-957193c6c861", "Esposo/a" },
                    { "cd63f60b-c377-4cdd-a067-9f1d14964287", "Padre" },
                    { "524626f9-68a6-4b3c-a4e1-8cc46b573dfa", "Madre" },
                    { "ff28441c-4616-4345-b10e-d7de0fcc9620", "Hijo/a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "347ede97-46a0-48d8-a61c-c89f1e162d58");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "5c19d8a8-51dd-40c6-ae94-e25884bacaea");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "fe3989c8-3b67-46f0-a7d1-e7be8f9ac2f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0aa0bc80-ad02-4f86-bf92-213c671256c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e86d6f0-e41d-491f-a1eb-28d1ce993b02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f0fd160-cded-4810-9575-302e0ec9e16c");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "022dfad6-80cb-48b2-8019-a26e95d2234c");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "451565c9-5665-416d-b4c9-84d984b9bd26");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "5ef8f8f7-65bc-4690-bded-05b02b550842");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "71f16b0e-4d8b-4858-ab3f-5b909e24134f");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "9e16bcc6-1bcf-4b1e-9f6f-8e0b165c20aa");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "be30eacd-b632-4c74-bf0f-3639a7771c6e");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "bcc7298a-61f3-409d-bd90-2538eff495cd");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "ef98bcc5-b080-4d69-a1ba-74d0340c0429");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "f819b2f4-1066-443a-9499-34c70fe3a26c");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "4f87e010-78cb-4c5a-96da-c5e829e5f442");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "748cf6c4-8aad-40a9-b582-7b229ee81930");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "e301a299-8754-409b-9717-704fe79d4ce1");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "4f7ab432-69f1-408b-a1b1-a1664d2287a0");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "c96785c8-96db-4b77-a4f7-3b98311cbcab");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "d129ad60-dbc2-46e3-81f9-8de5c8ed48a5");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "ed1c1080-4806-44f5-a09c-5bb49ff11121");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "f6c0856d-931a-4d03-bb77-575722466bd7");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "524626f9-68a6-4b3c-a4e1-8cc46b573dfa");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "bc3d4500-1997-4251-9959-957193c6c861");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "cd63f60b-c377-4cdd-a067-9f1d14964287");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "ff28441c-4616-4345-b10e-d7de0fcc9620");

            migrationBuilder.RenameTable(
                name: "AntecedentesPacientes",
                newName: "AntecedetesPacientes");

            migrationBuilder.RenameColumn(
                name: "TipoAntecedenteId",
                table: "AntecedetesPacientes",
                newName: "varchar(255)");

            migrationBuilder.RenameIndex(
                name: "IX_AntecedentesPacientes_TipoAntecedenteId",
                table: "AntecedetesPacientes",
                newName: "IX_AntecedetesPacientes_varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pacientes",
                type: "char(1)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(1)",
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
    }
}
