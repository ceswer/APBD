using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task08.Migrations
{
    public partial class AuthRTE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RerfreshTokenExpiration",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RerfreshTokenExpiration",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1996, 5, 16, 0, 26, 47, 83, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2000, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1994, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1999, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1971, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1992, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1967, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1954, 5, 16, 0, 26, 47, 94, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 26, 47, 158, DateTimeKind.Local).AddTicks(2060), new DateTime(2021, 8, 14, 0, 26, 47, 158, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3665), new DateTime(2021, 8, 14, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3762), new DateTime(2021, 8, 14, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3789), new DateTime(2021, 8, 14, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 16, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3817), new DateTime(2021, 8, 14, 0, 26, 47, 159, DateTimeKind.Local).AddTicks(3828) });
        }
    }
}
