using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />

    public partial class vetstationupdate1 : Migration
    {

        ///
        ///<GenerateAssemblyInfo>false</GenerateAssemblyInfo>
        /// 
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VetStation_City_CityId",
                table: "VetStation");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "VetStation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "VetStation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1")
                .Annotation("SqlServer:Identity", "1, 0");

            migrationBuilder.AddForeignKey(
                name: "FK_VetStation_City_CityId",
                table: "VetStation",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VetStation_City_CityId",
                table: "VetStation");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "VetStation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "VetStation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 0");

            migrationBuilder.AddForeignKey(
                name: "FK_VetStation_City_CityId",
                table: "VetStation",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
