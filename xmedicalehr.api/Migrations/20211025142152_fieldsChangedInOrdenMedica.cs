using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xmedical_ehr.Migrations
{
    public partial class fieldsChangedInOrdenMedica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "24df76ea-29cf-42cf-8ed7-4af8ac30c715");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "948c6f5c-39d0-4ceb-ac0e-5260c09c419c");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "fad74623-3cc9-406d-96b4-294dffcbe367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d8b2c1f-6c3c-4228-8715-aa445246104c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "998706f8-980e-4e08-8261-7c77b0329a47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ba2095a-874a-4d40-b1c5-e551549f4175");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "19209846-d4f1-41c1-b8d5-9bbeb9e9a1e7");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "293ad4c4-1306-4d16-a0b2-d60342506aac");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "4a3cf727-72db-469d-b301-94818c960cc6");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "5295640a-e2e4-4482-9510-44d4567e28d0");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "5ce622f5-95ce-4971-99df-2f075ffed659");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "a03d218a-4173-4ede-bbd7-f85e30a5c415");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "44fbacaa-960f-4c48-997f-aa1a6f350661");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "92b4c393-dbce-447e-90bd-b1ecaf8f492d");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "b8155a6c-8cdc-44b9-9edd-5fe9ef738ef3");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "5fd0f5c2-baf8-4436-b908-aa07ff029c0a");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "82bf17d3-092a-43e1-9741-77adcd2455c3");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "ea81bc98-24b3-42c4-b65e-ebf44b29f427");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "133ce391-8a5c-402d-af02-6fdc8debbcc6");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "653ee164-3b4d-449c-bc40-64579fe0b64b");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "8a9e62d3-d171-4375-b7d3-895269b941d0");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "c7ce9c01-a305-4d77-b86b-5629bb708abd");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "852e7b94-6676-464f-950a-9f6026f3e905");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "173d4c6b-5a46-4da6-956d-382951fa9794");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "5e0e16f2-84c9-45be-86ab-3f07f012cc4e");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "8e4f66b5-32d4-4e9e-9f47-b57a88c174c8");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "daefce01-1580-45fe-b3ac-b1c22b92dac4");

            migrationBuilder.RenameColumn(
                name: "Unidad",
                table: "OrdenesMedica",
                newName: "UnidadDosis");

            migrationBuilder.RenameColumn(
                name: "TipoId",
                table: "OrdenesMedica",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "Cantiad",
                table: "OrdenesMedica",
                newName: "CantidadDosis");

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "83ff4b07-7679-4d9d-b458-ae3da97f50cf", null, "SENASA" },
                    { "f39bffcb-a60f-4394-9f9e-13227ead33bd", null, "ARS HUMANO" },
                    { "a33f0d75-6cc4-4d7c-8f52-f754ca62f365", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c6fd389f-68f6-47cc-bc11-ac0c453abbe1", "ff460bd3-978a-4b32-9bd9-49b4dca81153", "Administrador", "admin", "ADMINISTRADOR" },
                    { "410be4c9-b0d8-41a5-a318-d4fd8e726c05", "15cbdd67-5dea-43b1-9d47-786882d298f2", "User", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prefix", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "980b0310-9391-42e2-a993-3050913cc211", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "dc7b0520-7392-43e9-9e60-381cce4f434e", "HEMOGRAMA", "LAB" },
                    { "df5ce0db-baa6-425d-9f34-93009e54d9d7", "ORINA", "LAB" },
                    { "cbf6728f-1e01-4b4e-ae22-38282fc3cc66", "COPROLOGICO", "LAB" },
                    { "fb05804c-c719-4798-83ae-2bfe3a76c91a", "SONOGRAFIA", "IMG" },
                    { "25ec36c9-34e5-4eef-a1ef-915d0d23c3d4", "TOMOGRAFIA", "IMG" },
                    { "7850f594-a33c-4135-b28c-14e3a1ddede1", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "3ab1da4d-f71e-47fe-b435-39f3e8fa4346", "PSIQUIATRICOS" },
                    { "7d17a379-beab-4e03-be45-6d04eaf886c7", "NO PATOLOGICOS" },
                    { "66d2033c-7c57-4da1-a60f-1b45cd7e91d3", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "9cde42e2-ee5c-4158-8a71-b921e20e7353", "Habitacion 301" },
                    { "a3c94bd3-bf7d-4c25-914f-6ea40419b39c", "Habitacion 302" },
                    { "4f79839c-1a40-4026-a6d4-b2845617c32a", "Habitacion 303" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "ec087614-a914-4279-a92d-993a292fcb44", new DateTime(2021, 10, 25, 10, 21, 51, 776, DateTimeKind.Local).AddTicks(5229), false, "ACETAMINOFEN" },
                    { "c141dc89-2cae-49e3-867d-dc8d6c9a732f", new DateTime(2021, 10, 25, 10, 21, 51, 777, DateTimeKind.Local).AddTicks(1113), false, "PARACETAMOL" },
                    { "c399acc8-da3e-49a5-ac9a-5620fd26652d", new DateTime(2021, 10, 25, 10, 21, 51, 777, DateTimeKind.Local).AddTicks(1131), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "0222ed7a-a9e7-46b7-8cf9-6b09aaa7aef9", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "a920506d-05e3-4b16-90cf-af689bf7f028", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "5e6f7b81-b5b6-48ef-a392-89dface5946b", "Esposo/a" },
                    { "0152a497-0bcf-40cc-aeb2-b87a649f1135", "Padre" },
                    { "10d9bbfa-f7b9-481d-80fe-59ecda65aec3", "Madre" },
                    { "d72f8ef6-129c-4d06-a3a0-0479cc7969d3", "Hijo/a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "83ff4b07-7679-4d9d-b458-ae3da97f50cf");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "a33f0d75-6cc4-4d7c-8f52-f754ca62f365");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "f39bffcb-a60f-4394-9f9e-13227ead33bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "410be4c9-b0d8-41a5-a318-d4fd8e726c05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6fd389f-68f6-47cc-bc11-ac0c453abbe1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980b0310-9391-42e2-a993-3050913cc211");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "25ec36c9-34e5-4eef-a1ef-915d0d23c3d4");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "7850f594-a33c-4135-b28c-14e3a1ddede1");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "cbf6728f-1e01-4b4e-ae22-38282fc3cc66");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "dc7b0520-7392-43e9-9e60-381cce4f434e");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "df5ce0db-baa6-425d-9f34-93009e54d9d7");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "fb05804c-c719-4798-83ae-2bfe3a76c91a");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "3ab1da4d-f71e-47fe-b435-39f3e8fa4346");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "66d2033c-7c57-4da1-a60f-1b45cd7e91d3");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "7d17a379-beab-4e03-be45-6d04eaf886c7");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "4f79839c-1a40-4026-a6d4-b2845617c32a");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "9cde42e2-ee5c-4158-8a71-b921e20e7353");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "a3c94bd3-bf7d-4c25-914f-6ea40419b39c");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "c141dc89-2cae-49e3-867d-dc8d6c9a732f");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "c399acc8-da3e-49a5-ac9a-5620fd26652d");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "ec087614-a914-4279-a92d-993a292fcb44");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "0222ed7a-a9e7-46b7-8cf9-6b09aaa7aef9");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "a920506d-05e3-4b16-90cf-af689bf7f028");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "0152a497-0bcf-40cc-aeb2-b87a649f1135");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "10d9bbfa-f7b9-481d-80fe-59ecda65aec3");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "5e6f7b81-b5b6-48ef-a392-89dface5946b");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "d72f8ef6-129c-4d06-a3a0-0479cc7969d3");

            migrationBuilder.RenameColumn(
                name: "UnidadDosis",
                table: "OrdenesMedica",
                newName: "Unidad");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "OrdenesMedica",
                newName: "TipoId");

            migrationBuilder.RenameColumn(
                name: "CantidadDosis",
                table: "OrdenesMedica",
                newName: "Cantiad");

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "fad74623-3cc9-406d-96b4-294dffcbe367", null, "SENASA" },
                    { "948c6f5c-39d0-4ceb-ac0e-5260c09c419c", null, "ARS HUMANO" },
                    { "24df76ea-29cf-42cf-8ed7-4af8ac30c715", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "998706f8-980e-4e08-8261-7c77b0329a47", "27a36baf-a372-4715-8cb7-92bafc75c215", "Administrador", "admin", "ADMINISTRADOR" },
                    { "0d8b2c1f-6c3c-4228-8715-aa445246104c", "10a88b6f-dd32-499d-b6ed-a3ef6c38e6da", "User", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prefix", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6ba2095a-874a-4d40-b1c5-e551549f4175", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "a03d218a-4173-4ede-bbd7-f85e30a5c415", "HEMOGRAMA", "LAB" },
                    { "19209846-d4f1-41c1-b8d5-9bbeb9e9a1e7", "ORINA", "LAB" },
                    { "4a3cf727-72db-469d-b301-94818c960cc6", "COPROLOGICO", "LAB" },
                    { "5ce622f5-95ce-4971-99df-2f075ffed659", "SONOGRAFIA", "IMG" },
                    { "293ad4c4-1306-4d16-a0b2-d60342506aac", "TOMOGRAFIA", "IMG" },
                    { "5295640a-e2e4-4482-9510-44d4567e28d0", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "44fbacaa-960f-4c48-997f-aa1a6f350661", "PSIQUIATRICOS" },
                    { "b8155a6c-8cdc-44b9-9edd-5fe9ef738ef3", "NO PATOLOGICOS" },
                    { "92b4c393-dbce-447e-90bd-b1ecaf8f492d", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "ea81bc98-24b3-42c4-b65e-ebf44b29f427", "Habitacion 301" },
                    { "82bf17d3-092a-43e1-9741-77adcd2455c3", "Habitacion 302" },
                    { "5fd0f5c2-baf8-4436-b908-aa07ff029c0a", "Habitacion 303" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "653ee164-3b4d-449c-bc40-64579fe0b64b", new DateTime(2021, 10, 21, 11, 45, 25, 909, DateTimeKind.Local).AddTicks(5989), false, "ACETAMINOFEN" },
                    { "8a9e62d3-d171-4375-b7d3-895269b941d0", new DateTime(2021, 10, 21, 11, 45, 25, 910, DateTimeKind.Local).AddTicks(1630), false, "PARACETAMOL" },
                    { "133ce391-8a5c-402d-af02-6fdc8debbcc6", new DateTime(2021, 10, 21, 11, 45, 25, 910, DateTimeKind.Local).AddTicks(1653), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "c7ce9c01-a305-4d77-b86b-5629bb708abd", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "852e7b94-6676-464f-950a-9f6026f3e905", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "5e0e16f2-84c9-45be-86ab-3f07f012cc4e", "Esposo/a" },
                    { "173d4c6b-5a46-4da6-956d-382951fa9794", "Padre" },
                    { "daefce01-1580-45fe-b3ac-b1c22b92dac4", "Madre" },
                    { "8e4f66b5-32d4-4e9e-9f47-b57a88c174c8", "Hijo/a" }
                });
        }
    }
}
