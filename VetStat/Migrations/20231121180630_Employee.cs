using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VetstationId = table.Column<int>(type: "int", nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Barber_Employee_Id",
                table: "Barber",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Employee_Id",
                table: "Customer",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurse_Employee_Id",
                table: "Nurse",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vet_Employee_Id",
                table: "Vet",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barber_Employee_Id",
                table: "Barber");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Employee_Id",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurse_Employee_Id",
                table: "Nurse");

            migrationBuilder.DropForeignKey(
                name: "FK_Vet_Employee_Id",
                table: "Vet");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
