using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xmedical_ehr.Migrations
{
    public partial class addedAtencionIDInOrdenesMedicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenesMedica",
                table: "OrdenesMedica");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "1c06702c-530c-45df-b2d0-002b6bea4637");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "c83dab48-2bcc-497b-86fb-d304bc17db04");

            migrationBuilder.DeleteData(
                table: "Aseguradoras",
                keyColumn: "Id",
                keyValue: "ccd6f37e-1107-4e8a-9cdc-51d9998f0bf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2dc9fb-f24f-49b7-91c6-20272304e7f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3e7273-1d4b-4667-95f0-41e681a8c245");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd433001-3f7d-4793-bd75-71c9e4da7f6b");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "0fadc010-7525-428d-a1b4-4ca76d097f4d");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "4d2cc093-6cf7-48b3-93dc-844f213fe90e");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "4ebc94ca-98ae-49d7-a616-e5675f82906d");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "cadb7537-3f77-46fe-9599-555f6137a6e4");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "d9ea403e-e550-4306-80bf-4fb107d1176b");

            migrationBuilder.DeleteData(
                table: "Estudios",
                keyColumn: "Id",
                keyValue: "edbe48ec-5253-4389-836e-cf13cf7de49c");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "46d31292-2fb9-4986-9c1f-b94aa075870b");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "5846b6c0-1ee8-4255-a93e-bcd61bb588f2");

            migrationBuilder.DeleteData(
                table: "GruposAntecedentes",
                keyColumn: "Id",
                keyValue: "6c412c62-74e2-4077-bd99-190176f26003");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "82715739-71b7-4b87-8dd6-196240c3e454");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "cc65eb17-96f8-43ac-b22b-bb4645d8f536");

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: "f472afae-c219-45b5-abc7-04420f03a609");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "78578d72-9d9a-4453-8df4-a26f6a38b82a");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "b8c88814-bbb4-41a8-a61f-620df9890a35");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "Id",
                keyValue: "e6a71a8e-f718-4718-8c0c-814edc54c731");

            migrationBuilder.DeleteData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: "0f993170-77f5-4eac-ba9f-f27823ed091e");

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: "e2d8e515-c6ec-4258-98f7-dad48d10c695");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "0ba85b32-885e-4168-83e8-bb4b9eff1ee4");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "1b0f6b1a-42a2-4c77-9d2b-9b362d2a340f");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "ad850dc0-f528-41ca-8225-b213451f2380");

            migrationBuilder.DeleteData(
                table: "TiposParentescos",
                keyColumn: "Id",
                keyValue: "e943abd0-0124-4fc6-8242-194809bbfee5");

            migrationBuilder.AlterColumn<int>(
                name: "TiempoExpiracion",
                table: "OrdenesMedica",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumDiagnostico",
                table: "OrdenesMedica",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Intervalo",
                table: "OrdenesMedica",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumItem",
                table: "OrdenesMedica",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AntencionId",
                table: "OrdenesMedica",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenesMedica",
                table: "OrdenesMedica",
                columns: new[] { "AntencionId", "NotaMedicaId", "NumItem" });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesMedica_NotaMedicaId",
                table: "OrdenesMedica",
                column: "NotaMedicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesMedicas_AtencionesMedicas",
                table: "OrdenesMedica",
                column: "AntencionId",
                principalTable: "AtencionesMedicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesMedicas_AtencionesMedicas",
                table: "OrdenesMedica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenesMedica",
                table: "OrdenesMedica");

            migrationBuilder.DropIndex(
                name: "IX_OrdenesMedica_NotaMedicaId",
                table: "OrdenesMedica");

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

            migrationBuilder.DropColumn(
                name: "AntencionId",
                table: "OrdenesMedica");

            migrationBuilder.AlterColumn<int>(
                name: "TiempoExpiracion",
                table: "OrdenesMedica",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "NumDiagnostico",
                table: "OrdenesMedica",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "Intervalo",
                table: "OrdenesMedica",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "NumItem",
                table: "OrdenesMedica",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenesMedica",
                table: "OrdenesMedica",
                columns: new[] { "NotaMedicaId", "NumItem" });

            migrationBuilder.InsertData(
                table: "Aseguradoras",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[,]
                {
                    { "1c06702c-530c-45df-b2d0-002b6bea4637", null, "SENASA" },
                    { "ccd6f37e-1107-4e8a-9cdc-51d9998f0bf0", null, "ARS HUMANO" },
                    { "c83dab48-2bcc-497b-86fb-d304bc17db04", null, "UNIVERSAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c2dc9fb-f24f-49b7-91c6-20272304e7f5", "60e40e87-38d5-436e-b7db-e214f819ca14", "Administrador", "admin", "ADMINISTRADOR" },
                    { "bb3e7273-1d4b-4667-95f0-41e681a8c245", "b3c129f6-ece3-4cfb-bc96-d46ada8c2af2", "User", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prefix", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cd433001-3f7d-4793-bd75-71c9e4da7f6b", 0, "d9b82e89-edd5-48a0-a728-7e92c90fb921", "root@system.local", false, false, null, "Root", "ROOT@SYSTEM.LOCAL", "ROOT@SYSTEM.LOCAL", "AQAAAAEAACcQAAAAEBEI92DDQ3rQr8oCpJKHlvz1hN/VDJpzGkFdV3qEHSjAQdLm5q6JEvzmS6sJpQnHMw==", null, false, "Sr", "6XKETTFVMB3X6M4ENBW6YYVZYCTO52XW", false, "root@system.local" });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Descripcion", "Tipo" },
                values: new object[,]
                {
                    { "d9ea403e-e550-4306-80bf-4fb107d1176b", "HEMOGRAMA", "LAB" },
                    { "0fadc010-7525-428d-a1b4-4ca76d097f4d", "ORINA", "LAB" },
                    { "4ebc94ca-98ae-49d7-a616-e5675f82906d", "COPROLOGICO", "LAB" },
                    { "edbe48ec-5253-4389-836e-cf13cf7de49c", "SONOGRAFIA", "IMG" },
                    { "cadb7537-3f77-46fe-9599-555f6137a6e4", "TOMOGRAFIA", "IMG" },
                    { "4d2cc093-6cf7-48b3-93dc-844f213fe90e", "RADIOGRAFIA", "IMG" }
                });

            migrationBuilder.InsertData(
                table: "GruposAntecedentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "46d31292-2fb9-4986-9c1f-b94aa075870b", "PSIQUIATRICOS" },
                    { "5846b6c0-1ee8-4255-a93e-bcd61bb588f2", "NO PATOLOGICOS" },
                    { "6c412c62-74e2-4077-bd99-190176f26003", "PATOLOGICOS" }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "82715739-71b7-4b87-8dd6-196240c3e454", "Habitacion 301" },
                    { "f472afae-c219-45b5-abc7-04420f03a609", "Habitacion 302" },
                    { "cc65eb17-96f8-43ac-b22b-bb4645d8f536", "Habitacion 303" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Descripcion" },
                values: new object[,]
                {
                    { "b8c88814-bbb4-41a8-a61f-620df9890a35", new DateTime(2021, 9, 14, 16, 27, 12, 151, DateTimeKind.Local).AddTicks(3478), false, "ACETAMINOFEN" },
                    { "e6a71a8e-f718-4718-8c0c-814edc54c731", new DateTime(2021, 9, 14, 16, 27, 12, 151, DateTimeKind.Local).AddTicks(9202), false, "PARACETAMOL" },
                    { "78578d72-9d9a-4453-8df4-a26f6a38b82a", new DateTime(2021, 9, 14, 16, 27, 12, 151, DateTimeKind.Local).AddTicks(9226), false, "SOLUCION SALINA MIXTA 1000ml" }
                });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "CodigoInt", "Descripcion" },
                values: new object[] { "0f993170-77f5-4eac-ba9f-f27823ed091e", null, "Dominicana" });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "CodigoInt", "Nombre" },
                values: new object[] { "e2d8e515-c6ec-4258-98f7-dad48d10c695", null, "Duarte" });

            migrationBuilder.InsertData(
                table: "TiposParentescos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "1b0f6b1a-42a2-4c77-9d2b-9b362d2a340f", "Esposo/a" },
                    { "e943abd0-0124-4fc6-8242-194809bbfee5", "Padre" },
                    { "ad850dc0-f528-41ca-8225-b213451f2380", "Madre" },
                    { "0ba85b32-885e-4168-83e8-bb4b9eff1ee4", "Hijo/a" }
                });
        }
    }
}
