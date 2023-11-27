using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class Animal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Animal_AnimalSpeciesId",
                table: "Animal",
                column: "AnimalSpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesId",
                table: "Animal",
                column: "AnimalSpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesId",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_AnimalSpeciesId",
                table: "Animal");
        }
    }
}
