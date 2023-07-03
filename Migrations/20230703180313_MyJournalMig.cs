using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyJournalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class MyJournalMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dietary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Breakfast = table.Column<string>(type: "TEXT", nullable: true),
                    Lunch = table.Column<string>(type: "TEXT", nullable: true),
                    Dinner = table.Column<string>(type: "TEXT", nullable: true),
                    Desert = table.Column<string>(type: "TEXT", nullable: true),
                    Snacks = table.Column<string>(type: "TEXT", nullable: true),
                    DietaryNotes = table.Column<string>(type: "TEXT", nullable: false),
                    JournalsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dietary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dietary_Journals_JournalsId",
                        column: x => x.JournalsId,
                        principalTable: "Journals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Health",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HealthIssue = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Physician = table.Column<string>(type: "TEXT", nullable: false),
                    JournalsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Health_Journals_JournalsId",
                        column: x => x.JournalsId,
                        principalTable: "Journals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JournalEntry = table.Column<string>(type: "TEXT", nullable: false),
                    JournalsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personal_Journals_JournalsId",
                        column: x => x.JournalsId,
                        principalTable: "Journals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Travel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Destination = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    JournalsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Travel_Journals_JournalsId",
                        column: x => x.JournalsId,
                        principalTable: "Journals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dietary_JournalsId",
                table: "Dietary",
                column: "JournalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Health_JournalsId",
                table: "Health",
                column: "JournalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_JournalsId",
                table: "Personal",
                column: "JournalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Travel_JournalsId",
                table: "Travel",
                column: "JournalsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dietary");

            migrationBuilder.DropTable(
                name: "Health");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Travel");

            migrationBuilder.DropTable(
                name: "Journals");
        }
    }
}
