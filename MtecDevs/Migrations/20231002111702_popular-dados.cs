using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f6f56b7-cce5-4dad-adc2-0746a99bc39e", "b2bdcbca-771d-4f22-9487-7daa08f181ef", "Usuario", "USUARIO" },
                    { "34280970-c9ae-43eb-8989-bcd04cc920ad", "785ca2c3-9da9-479a-a66e-0ee1fa4fe89f", "Moderador", "Moderador" },
                    { "b5ca1749-bc11-4866-bc46-1793c1d246d6", "a546449b-5f81-4a61-94bd-fa4abce911ec", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62ab6b19-5617-45fc-b07b-b7b9ac8a93d8", 0, "da70ecfe-1fba-4ccc-8aff-a836a6aef671", "risattimatheus@gmail.com", true, false, null, "RISATTIMATHEUS@GMAIL.COM", "MAPOKO", "AQAAAAEAACcQAAAAELC554+KnQ6Ic6ASn1s5eVz4aDPP1mR8VhOSzt0YYZdDLu4hIXwAUbEEd0Rxz2P+hQ==", "14991911777", true, "daf464d6-703e-4acf-9b1d-87476a2b94ae", false, "Mapoko" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "FullStack" },
                    { (byte)2, "FrontEnd" },
                    { (byte)3, "BackEnd" },
                    { (byte)4, "Design" },
                    { (byte)5, "Jogos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b5ca1749-bc11-4866-bc46-1793c1d246d6", "62ab6b19-5617-45fc-b07b-b7b9ac8a93d8" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "62ab6b19-5617-45fc-b07b-b7b9ac8a93d8", new DateTime(2007, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/avatar.png", "Matheus Clementino Risatti", (byte)2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f6f56b7-cce5-4dad-adc2-0746a99bc39e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34280970-c9ae-43eb-8989-bcd04cc920ad");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b5ca1749-bc11-4866-bc46-1793c1d246d6", "62ab6b19-5617-45fc-b07b-b7b9ac8a93d8" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "62ab6b19-5617-45fc-b07b-b7b9ac8a93d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5ca1749-bc11-4866-bc46-1793c1d246d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62ab6b19-5617-45fc-b07b-b7b9ac8a93d8");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: (byte)2);
        }
    }
}
