using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class vetstationmainvet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "ChiefVetStationId",
                table: "MainVet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MainVet_ChiefVetStationId",
                table: "MainVet",
                column: "ChiefVetStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainVet_VetStation_ChiefVetStationId",
                table: "MainVet",
                column: "ChiefVetStationId",
                principalTable: "VetStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainVet_VetStation_ChiefVetStationId",
                table: "MainVet");

            migrationBuilder.DropIndex(
                name: "IX_MainVet_ChiefVetStationId",
                table: "MainVet");

            migrationBuilder.DropColumn(
                name: "ChiefVetStationId",
                table: "MainVet");

        }
    }
}
