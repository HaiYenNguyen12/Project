using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManageProject.API.Database.Migrations
{
    public partial class ChangeTypePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "User",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "longblob")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.AlterColumn<byte[]>(
                name: "password",
                table: "User",
                type: "longblob",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
