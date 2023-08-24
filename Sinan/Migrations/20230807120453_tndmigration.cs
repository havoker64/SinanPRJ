using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinan.Migrations
{
    /// <inheritdoc />
    public partial class tndmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cfSerology",
                table: "notificacao");

            migrationBuilder.DropColumn(
                name: "csSerology",
                table: "notificacao");

            migrationBuilder.DropColumn(
                name: "dSerology",
                table: "notificacao");

            migrationBuilder.DropColumn(
                name: "insulation",
                table: "notificacao");

            migrationBuilder.DropColumn(
                name: "ns1",
                table: "notificacao");

            migrationBuilder.DropColumn(
                name: "prnt",
                table: "notificacao");

            migrationBuilder.DropColumn(
                name: "rtpcr",
                table: "notificacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "cfSerology",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "csSerology",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "dSerology",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "insulation",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ns1",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "prnt",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "rtpcr",
                table: "notificacao",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
