using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xmedical_ehr.Migrations
{
    public partial class addedEnfermedadIdInOrdenMedica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Instruccciones",
                table: "OrdenesMedica",
                newName: "Instrucciones");

            migrationBuilder.AddColumn<string>(
                name: "EnfermedadId",
                table: "OrdenesMedica",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "5d1e6657-21d5-4c7f-aec3-ae130354b260", null, "SENASA" },
                    { "a41c12e2-1ff0-4a64-a9ea-18ac226eb8e7", null, "ARS HUMANO" },
                    { "316f4ea7-a304-4f11-8a8d-cd94698fe392", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d281abf5-321c-4e71-bf29-882c6b0bcd46", "d3820c00-1486-4d73-823e-f6229c160f47", "Administrador", "admin", "ADMINISTRADOR" },
                    { "cb140ba5-3533-48bb-ba36-34bf474ecd1c", "3e942484-ed27-44bd-8a1a-f69bf723fdc0", "User", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prefix", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "61778e2d-0427-4372-b972-e70cbbd95299", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "0897c630-7c88-4079-93e5-584ee1946170", "HEMOGRAMA", "LAB" },
                    { "7a89009a-fade-4eab-8453-412556ae9f93", "ORINA", "LAB" },
                    { "9a3ada87-bce2-4670-839f-62d1338e0f13", "COPROLOGICO", "LAB" },
                    { "d5272f0d-c380-4a8a-bd53-96deccdd69cd", "SONOGRAFIA", "IMG" },
                    { "b1e866a1-5e9b-4e27-8c93-b54660a2d374", "TOMOGRAFIA", "IMG" },
                    { "cc319ddd-8e26-478b-b7e6-ec44f24e9ce5", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "17b53790-ac6c-4d78-b693-8bfef712237c", "PSIQUIATRICOS" },
                    { "4f2d5587-54ab-4edc-9777-8b9ea17b98be", "NO PATOLOGICOS" },
                    { "b6ccd9f4-82ea-494d-be9e-f87626e11ad9", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "744b6723-68b8-4bbd-9aa9-ad27d4392723", "Habitacion 301" },
                    { "e3deecab-b122-4505-ab29-bf31c8eb5a43", "Habitacion 302" },
                    { "a5e42189-056b-4705-9896-26507c3e2528", "Habitacion 303" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "0c06d126-fcb9-4fc1-9297-450be39cbb35", new DateTime(2021, 10, 25, 16, 21, 2, 18, DateTimeKind.Local).AddTicks(5504), false, "ACETAMINOFEN" },
                    { "b8e44a06-ee63-4e68-abed-851abe6266fa", new DateTime(2021, 10, 25, 16, 21, 2, 19, DateTimeKind.Local).AddTicks(2268), false, "PARACETAMOL" },
                    { "cf466c39-a923-4e26-9b12-ee4b4492218e", new DateTime(2021, 10, 25, 16, 21, 2, 19, DateTimeKind.Local).AddTicks(2342), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "c781f9de-517d-458a-8ffe-66d9a376a093", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "426c3668-3605-480b-bfc9-fe43fd9f1cf1", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "eb703f69-58fd-41d2-ad10-2c27f889101f", "Esposo/a" },
                    { "c4e73952-3a70-443a-b7a5-7dc1b08e6111", "Padre" },
                    { "c717cf0f-caec-4311-aa1f-ff0bf26ee81d", "Madre" },
                    { "d5488544-a8be-41fa-b0df-a6bbe40aee59", "Hijo/a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesMedica_EnfermedadId",
                table: "OrdenesMedica",
                column: "EnfermedadId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesMedicas_Enfermedades",
                table: "OrdenesMedica",
                column: "EnfermedadId",
                principalTable: "Enfermedades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesMedicas_Enfermedades",
                table: "OrdenesMedica");

            migrationBuilder.DropIndex(
                name: "IX_OrdenesMedica_EnfermedadId",
                table: "OrdenesMedica");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "316f4ea7-a304-4f11-8a8d-cd94698fe392");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "5d1e6657-21d5-4c7f-aec3-ae130354b260");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "a41c12e2-1ff0-4a64-a9ea-18ac226eb8e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb140ba5-3533-48bb-ba36-34bf474ecd1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d281abf5-321c-4e71-bf29-882c6b0bcd46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61778e2d-0427-4372-b972-e70cbbd95299");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "0897c630-7c88-4079-93e5-584ee1946170");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "7a89009a-fade-4eab-8453-412556ae9f93");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "9a3ada87-bce2-4670-839f-62d1338e0f13");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "b1e866a1-5e9b-4e27-8c93-b54660a2d374");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "cc319ddd-8e26-478b-b7e6-ec44f24e9ce5");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "d5272f0d-c380-4a8a-bd53-96deccdd69cd");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "17b53790-ac6c-4d78-b693-8bfef712237c");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "4f2d5587-54ab-4edc-9777-8b9ea17b98be");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "b6ccd9f4-82ea-494d-be9e-f87626e11ad9");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "744b6723-68b8-4bbd-9aa9-ad27d4392723");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "a5e42189-056b-4705-9896-26507c3e2528");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "e3deecab-b122-4505-ab29-bf31c8eb5a43");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "0c06d126-fcb9-4fc1-9297-450be39cbb35");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "b8e44a06-ee63-4e68-abed-851abe6266fa");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "cf466c39-a923-4e26-9b12-ee4b4492218e");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "c781f9de-517d-458a-8ffe-66d9a376a093");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "426c3668-3605-480b-bfc9-fe43fd9f1cf1");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "c4e73952-3a70-443a-b7a5-7dc1b08e6111");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "c717cf0f-caec-4311-aa1f-ff0bf26ee81d");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "d5488544-a8be-41fa-b0df-a6bbe40aee59");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "eb703f69-58fd-41d2-ad10-2c27f889101f");

            migrationBuilder.DropColumn(
                name: "EnfermedadId",
                table: "OrdenesMedica");

            migrationBuilder.RenameColumn(
                name: "Instrucciones",
                table: "OrdenesMedica",
                newName: "Instruccciones");

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
    }
}
