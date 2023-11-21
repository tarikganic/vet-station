using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class PersonVet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialSkill = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vet_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vet");
        }
    }
}
