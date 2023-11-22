using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class PersonChildren2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Certification",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Person",
                newName: "PersonType");

            migrationBuilder.AddColumn<int>(
                name: "Customer_PersonId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vet_EmployeeId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vet_PersonId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_Customer_PersonId",
                table: "Person",
                column: "Customer_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EmployeeId",
                table: "Person",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonId",
                table: "Person",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Vet_EmployeeId",
                table: "Person",
                column: "Vet_EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Vet_PersonId",
                table: "Person",
                column: "Vet_PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Person_Customer_PersonId",
                table: "Person",
                column: "Customer_PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Person_EmployeeId",
                table: "Person",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Person_PersonId",
                table: "Person",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Person_Vet_EmployeeId",
                table: "Person",
                column: "Vet_EmployeeId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Person_Vet_PersonId",
                table: "Person",
                column: "Vet_PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Person_Customer_PersonId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Person_EmployeeId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Person_PersonId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Person_Vet_EmployeeId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Person_Vet_PersonId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_Customer_PersonId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_EmployeeId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_PersonId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_Vet_EmployeeId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_Vet_PersonId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Customer_PersonId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Vet_EmployeeId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Vet_PersonId",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "PersonType",
                table: "Person",
                newName: "Discriminator");

            migrationBuilder.AddColumn<byte[]>(
                name: "Certification",
                table: "Person",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
