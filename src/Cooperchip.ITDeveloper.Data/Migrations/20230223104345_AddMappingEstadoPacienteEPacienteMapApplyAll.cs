﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Cooperchip.ITDeveloper.Data.Migrations
{
    public partial class AddMappingEstadoPacienteEPacienteMapApplyAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_EstadoPaciente_EstadoPacienteId",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "RgOrgao",
                table: "Paciente",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "Paciente",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "varchar(90)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Paciente",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Paciente",
                type: "varchar(11)",
                fixedLength: true,
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Mural",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Mural",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aviso",
                table: "Mural",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Mural",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "EstadoPaciente",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_EstadoPaciente_EstadoPacienteId",
                table: "Paciente",
                column: "EstadoPacienteId",
                principalTable: "EstadoPaciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_EstadoPaciente_EstadoPacienteId",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "RgOrgao",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldFixedLength: true,
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Mural",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Mural",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aviso",
                table: "Mural",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Mural",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "EstadoPaciente",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_EstadoPaciente_EstadoPacienteId",
                table: "Paciente",
                column: "EstadoPacienteId",
                principalTable: "EstadoPaciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
