using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetStat.Migrations
{
    /// <inheritdoc />
    public partial class Animal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Customer_OwnerId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Animal_AnimalId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Employee_EmployeeId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_TimeSlot_TimeSlotId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_VetStation_VetStationId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Availability_Employee_EmployeeId",
                table: "Availability");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Availability_AvailabilityId",
                table: "TimeSlot");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Employee_SlotEmployeeId",
                table: "TimeSlot");

            migrationBuilder.AlterColumn<int>(
                name: "SlotEmployeeId",
                table: "TimeSlot",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AvailabilityId",
                table: "TimeSlot",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Availability",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VetStationId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlotId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Appointment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Animal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalSpeciesId",
                table: "Animal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Customer_OwnerId",
                table: "Animal",
                column: "OwnerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesId",
                table: "Animal",
                column: "AnimalSpeciesId",
                principalTable: "Species",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Animal_AnimalId",
                table: "Appointment",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Employee_EmployeeId",
                table: "Appointment",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_TimeSlot_TimeSlotId",
                table: "Appointment",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_VetStation_VetStationId",
                table: "Appointment",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Availability_Employee_EmployeeId",
                table: "Availability",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Availability_AvailabilityId",
                table: "TimeSlot",
                column: "AvailabilityId",
                principalTable: "Availability",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Employee_SlotEmployeeId",
                table: "TimeSlot",
                column: "SlotEmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Customer_OwnerId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Animal_AnimalId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Employee_EmployeeId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_TimeSlot_TimeSlotId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_VetStation_VetStationId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Availability_Employee_EmployeeId",
                table: "Availability");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Availability_AvailabilityId",
                table: "TimeSlot");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Employee_SlotEmployeeId",
                table: "TimeSlot");

            migrationBuilder.AlterColumn<int>(
                name: "SlotEmployeeId",
                table: "TimeSlot",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvailabilityId",
                table: "TimeSlot",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Availability",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VetStationId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlotId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Animal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalSpeciesId",
                table: "Animal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Customer_OwnerId",
                table: "Animal",
                column: "OwnerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Species_AnimalSpeciesId",
                table: "Animal",
                column: "AnimalSpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Animal_AnimalId",
                table: "Appointment",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Employee_EmployeeId",
                table: "Appointment",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_TimeSlot_TimeSlotId",
                table: "Appointment",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_VetStation_VetStationId",
                table: "Appointment",
                column: "VetStationId",
                principalTable: "VetStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Availability_Employee_EmployeeId",
                table: "Availability",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Availability_AvailabilityId",
                table: "TimeSlot",
                column: "AvailabilityId",
                principalTable: "Availability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Employee_SlotEmployeeId",
                table: "TimeSlot",
                column: "SlotEmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
