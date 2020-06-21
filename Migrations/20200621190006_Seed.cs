using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Apbd11.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDoctor",
                table: "Prescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                table: "Prescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "artur@danone.pl", "Artur", "Partyka" });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[] { 1, "Good stuff", "Prozac", "antidepressant" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1798, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "Mickiewicz" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "Date", "DoctorId", "DueDate", "IdDoctor", "IdPatient", "PatientId" },
                values: new object[] { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null });

            migrationBuilder.InsertData(
                table: "Prescriptions_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose", "MedicamentId", "PrescriptionId" },
                values: new object[] { 1, 1, "Don't share with children", 1, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DropColumn(
                name: "IdDoctor",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IdPatient",
                table: "Prescriptions");
        }
    }
}
