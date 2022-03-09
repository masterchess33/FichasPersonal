using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaWeb.Migrations
{
    public partial class Errorupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Direccion_DireccionEmpleadoDireccionId",
                table: "Empleado");

            migrationBuilder.RenameColumn(
                name: "DireccionEmpleadoDireccionId",
                table: "Empleado",
                newName: "DireccionId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_DireccionEmpleadoDireccionId",
                table: "Empleado",
                newName: "IX_Empleado_DireccionId");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Empleado",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Direccion_DireccionId",
                table: "Empleado",
                column: "DireccionId",
                principalTable: "Direccion",
                principalColumn: "DireccionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Direccion_DireccionId",
                table: "Empleado");

            migrationBuilder.RenameColumn(
                name: "DireccionId",
                table: "Empleado",
                newName: "DireccionEmpleadoDireccionId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_DireccionId",
                table: "Empleado",
                newName: "IX_Empleado_DireccionEmpleadoDireccionId");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Empleado",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Direccion_DireccionEmpleadoDireccionId",
                table: "Empleado",
                column: "DireccionEmpleadoDireccionId",
                principalTable: "Direccion",
                principalColumn: "DireccionId");
        }
    }
}
