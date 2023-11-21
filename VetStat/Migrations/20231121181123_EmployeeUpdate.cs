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
                name: "FK_Customer_Employee_Id",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_EmployeeId",
                table: "Customer",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Employee_EmployeeId",
                table: "Customer",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Employee_EmployeeId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_EmployeeId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Employee_Id",
                table: "Customer",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
