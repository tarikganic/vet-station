using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_VetStation_VetStationId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "VetStationId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_VetStation_VetStationId",
                table: "Employee",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_VetStation_VetStationId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "VetStationId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_VetStation_VetStationId",
                table: "Employee",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
