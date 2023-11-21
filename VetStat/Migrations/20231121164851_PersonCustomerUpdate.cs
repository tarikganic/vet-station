using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class PersonCustomer1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Person_Id",
                table: "Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Person_Id",
                table: "Customer",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Person_Id",
                table: "Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Person_Id",
                table: "Customer",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
