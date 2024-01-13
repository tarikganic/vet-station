using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class Customerdelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Customer_OwnerId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Animal_OwnerId",
                table: "Animal");

            migrationBuilder.AddColumn<float>(
                name: "MembershipLoyalty",
                table: "Person",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProfileCreationDate",
                table: "Person",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Animal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animal_CustomerId",
                table: "Animal",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Person_CustomerId",
                table: "Animal",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Person_CustomerId",
                table: "Appointment",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Person_CustomerId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Person_CustomerId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Animal_CustomerId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "MembershipLoyalty",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ProfileCreationDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Animal");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MembershipLoyalty = table.Column<float>(type: "real", nullable: true),
                    ProfileCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_OwnerId",
                table: "Animal",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Customer_OwnerId",
                table: "Animal",
                column: "OwnerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
