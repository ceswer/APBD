using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task08.Migrations
{
    public partial class Auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RerfreshTokenExpiration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_PK", x => x.IdUser);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_User_Login",
                table: "User",
                column: "Login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1996, 5, 3, 14, 56, 20, 859, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2000, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1994, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1999, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1971, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1992, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1967, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1954, 5, 3, 14, 56, 20, 863, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(7615), new DateTime(2021, 8, 1, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9688), new DateTime(2021, 8, 1, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9705), new DateTime(2021, 8, 1, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9712), new DateTime(2021, 8, 1, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9718), new DateTime(2021, 8, 1, 14, 56, 20, 880, DateTimeKind.Local).AddTicks(9721) });
        }
    }
}
