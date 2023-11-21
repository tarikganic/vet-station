using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class PersonBarber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Certification = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barber_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barber");
        }
    }
}
