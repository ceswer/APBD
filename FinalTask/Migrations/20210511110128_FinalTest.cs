using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalTask.Migrations
{
    public partial class FinalTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atist",
                columns: table => new
                {
                    IdArtist = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Artist_PK", x => x.IdArtist);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    IdEvent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdEvent_PK", x => x.IdEvent);
                });

            migrationBuilder.CreateTable(
                name: "Organiser",
                columns: table => new
                {
                    IdOrganiser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Organiser_PK", x => x.IdOrganiser);
                });

            migrationBuilder.CreateTable(
                name: "Artist_Event",
                columns: table => new
                {
                    IdEvent = table.Column<int>(type: "int", nullable: false),
                    IdArtist = table.Column<int>(type: "int", nullable: false),
                    PerfomanceDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ArtistEvent_PK", x => new { x.IdArtist, x.IdEvent });
                    table.ForeignKey(
                        name: "Artist_Event_PK",
                        column: x => x.IdArtist,
                        principalTable: "Atist",
                        principalColumn: "IdArtist",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Event_Artist_PK",
                        column: x => x.IdEvent,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event_Organiser",
                columns: table => new
                {
                    IdEvent = table.Column<int>(type: "int", nullable: false),
                    IdOrganiser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("EventOrganiser_PK", x => new { x.IdOrganiser, x.IdEvent });
                    table.ForeignKey(
                        name: "Event_Organiser_PK",
                        column: x => x.IdEvent,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Organiser_Event_PK",
                        column: x => x.IdEvent,
                        principalTable: "Organiser",
                        principalColumn: "IdOrganiser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Atist",
                columns: new[] { "IdArtist", "Nickname" },
                values: new object[,]
                {
                    { 1, "Ceswer" },
                    { 2, "BullDog" },
                    { 3, "Nie wiem" },
                    { 4, "Losowy nickname" },
                    { 5, "Help me!!!" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "IdEvent", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1547), "One more party", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1545) },
                    { 6, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1541), "For being quick party", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1538) },
                    { 5, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1530), "Sea Horses Party", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1527) },
                    { 4, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1523), "Cant do it faster", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1520) },
                    { 3, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1452), "Ceswer Party", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1449) },
                    { 2, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1444), "Hololulu", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(1431) },
                    { 1, new DateTime(2021, 5, 31, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(845), "EventSample", new DateTime(2021, 4, 21, 14, 1, 27, 326, DateTimeKind.Local).AddTicks(185) }
                });

            migrationBuilder.InsertData(
                table: "Organiser",
                columns: new[] { "IdOrganiser", "Name" },
                values: new object[,]
                {
                    { 1, "Ceswer" },
                    { 2, "Kowalski" },
                    { 3, "Piotrowski" },
                    { 4, "Nazarii" },
                    { 5, "Sample" },
                    { 6, "One by one" }
                });

            migrationBuilder.InsertData(
                table: "Artist_Event",
                columns: new[] { "IdArtist", "IdEvent", "PerfomanceDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 21, 14, 1, 27, 317, DateTimeKind.Local).AddTicks(703) },
                    { 2, 1, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3292) },
                    { 3, 1, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3305) },
                    { 2, 2, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3246) },
                    { 1, 2, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3286) },
                    { 4, 2, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3309) },
                    { 1, 3, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3296) },
                    { 2, 3, new DateTime(2021, 4, 21, 14, 1, 27, 321, DateTimeKind.Local).AddTicks(3312) }
                });

            migrationBuilder.InsertData(
                table: "Event_Organiser",
                columns: new[] { "IdEvent", "IdOrganiser" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Event_IdEvent",
                table: "Artist_Event",
                column: "IdEvent");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Organiser_IdEvent",
                table: "Event_Organiser",
                column: "IdEvent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist_Event");

            migrationBuilder.DropTable(
                name: "Event_Organiser");

            migrationBuilder.DropTable(
                name: "Atist");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Organiser");
        }
    }
}
