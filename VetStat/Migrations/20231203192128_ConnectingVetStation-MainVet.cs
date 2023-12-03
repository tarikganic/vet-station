using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class ConnectingVetStationMainVet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainVetId",
                table: "VetStation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VetStation_MainVetId",
                table: "VetStation",
                column: "MainVetId");

            migrationBuilder.AddForeignKey(
                name: "FK_VetStation_MainVet_MainVetId",
                table: "VetStation",
                column: "MainVetId",
                principalTable: "MainVet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VetStation_MainVet_MainVetId",
                table: "VetStation");

            migrationBuilder.DropIndex(
                name: "IX_VetStation_MainVetId",
                table: "VetStation");

            migrationBuilder.DropColumn(
                name: "MainVetId",
                table: "VetStation");
        }
    }
}
