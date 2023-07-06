using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_CRM.Migrations
{
    /// <inheritdoc />
    public partial class editUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UltimoLogin",
                table: "Usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimoLogin",
                table: "Usuario",
                type: "datetime2",
                nullable: true);
        }
    }
}
