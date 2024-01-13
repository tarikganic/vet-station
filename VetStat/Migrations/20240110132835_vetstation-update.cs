using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class vetstationupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInOffice",
                table: "VetStation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnField",
                table: "VetStation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Parking",
                table: "VetStation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wheelchair",
                table: "VetStation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wifi",
                table: "VetStation",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInOffice",
                table: "VetStation");

            migrationBuilder.DropColumn(
                name: "IsOnField",
                table: "VetStation");

            migrationBuilder.DropColumn(
                name: "Parking",
                table: "VetStation");

            migrationBuilder.DropColumn(
                name: "Wheelchair",
                table: "VetStation");

            migrationBuilder.DropColumn(
                name: "Wifi",
                table: "VetStation");
        }
    }
}
