using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task08.Migrations
{
    public partial class AuthDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1996, 5, 16, 1, 20, 20, 406, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2000, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1994, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1999, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1971, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1992, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1967, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1954, 5, 16, 1, 20, 20, 409, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(3746), new DateTime(2021, 8, 14, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 8, 14, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6181), new DateTime(2021, 8, 14, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6188), new DateTime(2021, 8, 14, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6195), new DateTime(2021, 8, 14, 1, 20, 20, 427, DateTimeKind.Local).AddTicks(6198) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1996, 5, 16, 0, 41, 51, 904, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2000, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1994, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1999, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1971, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1992, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1967, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1954, 5, 16, 0, 41, 51, 907, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 41, 51, 927, DateTimeKind.Local).AddTicks(7524), new DateTime(2021, 8, 14, 0, 41, 51, 927, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(3), new DateTime(2021, 8, 14, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(24), new DateTime(2021, 8, 14, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(31), new DateTime(2021, 8, 14, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(37), new DateTime(2021, 8, 14, 0, 41, 51, 928, DateTimeKind.Local).AddTicks(41) });
        }
    }
}
