using Microsoft.EntityFrameworkCore.Migrations;

namespace Task10.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Price", "Rating" },
                values: new object[] { 10m, "Good" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 1,
                column: "Price",
                value: 2396000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 2,
                column: "Price",
                value: 1325000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 3,
                column: "Price",
                value: 2730000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 10756000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 5,
                column: "Price",
                value: 23000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 6,
                column: "Price",
                value: 964000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 7,
                column: "Price",
                value: 10245000m);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 8,
                column: "Price",
                value: 768000m);
        }
    }
}
