using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cooperchip.ITDeveloper.Mvc.Migrations
{
    public partial class AddUserAndRolerWithExtensionMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "EDB90C0F-1CC4-4148-87C9-284256D89460", "896dee62-470e-4db9-968d-1ff64ca78283", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apelido", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4AB3FFE5-8319-4C22-B097-3ABD7040697A", 0, "alts", "7009df03-c3be-4afa-8a1c-c0362e2a7f06", new DateTime(2023, 3, 3, 3, 23, 34, 448, DateTimeKind.Local).AddTicks(8840), "altsystems@outlook.com.br", true, false, null, "Alt Systems", "ALTSYSTEMS@OUTLOOK.COM.BR", "ALTSYSTEMS@OUTLOOK.COM.BR", "AQAAAAEAACcQAAAAEIUI5VZ/UDoORqcIyYUsGr/lsPDrXHQs2HokZam91pZCrXDEbqYK5hlahuMqEVUjIA==", null, false, "c4e74369-b8bd-43f7-bae1-28da5cd1c60f", false, "altsystems@outlook.com.br" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "EDB90C0F-1CC4-4148-87C9-284256D89460", "4AB3FFE5-8319-4C22-B097-3ABD7040697A" });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
