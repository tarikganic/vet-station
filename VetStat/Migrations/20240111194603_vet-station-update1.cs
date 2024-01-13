using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
 
    public partial class vetstationupdate2 : Migration
    {

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_VetStation_VetStationId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_VetStation_VetStationId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_FAQ_VetStation_VetStationId",
                table: "FAQ");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_VetStation_VetStationId",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "VetStation");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_VetStationId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_FAQ_VetStationId",
                table: "FAQ");

            migrationBuilder.DropIndex(
                name: "IX_Employee_VetStationId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_VetStationId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "VetStationId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "VetStationId",
                table: "FAQ");

            migrationBuilder.DropColumn(
                name: "VetStationId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "VetStationId",
                table: "Appointment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VetStationId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VetStationId",
                table: "FAQ",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VetStationId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VetStationId",
                table: "Appointment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VetStation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsInOffice = table.Column<bool>(type: "bit", nullable: false),
                    IsOnField = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<bool>(type: "bit", nullable: false),
                    Wheelchair = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VetStation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VetStation_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_VetStationId",
                table: "Inventory",
                column: "VetStationId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQ_VetStationId",
                table: "FAQ",
                column: "VetStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_VetStationId",
                table: "Employee",
                column: "VetStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_VetStationId",
                table: "Appointment",
                column: "VetStationId");

            migrationBuilder.CreateIndex(
                name: "IX_VetStation_CityId",
                table: "VetStation",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_VetStation_VetStationId",
                table: "Appointment",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_VetStation_VetStationId",
                table: "Employee",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FAQ_VetStation_VetStationId",
                table: "FAQ",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_VetStation_VetStationId",
                table: "Inventory",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
