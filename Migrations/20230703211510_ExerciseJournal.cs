using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyJournalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseJournal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExcerciseJournal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcerciseJournal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcerciseJournalJournals",
                columns: table => new
                {
                    ExcerciseJournalsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    JournalsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcerciseJournalJournals", x => new { x.ExcerciseJournalsId, x.JournalsId });
                    table.ForeignKey(
                        name: "FK_ExcerciseJournalJournals_ExcerciseJournal_ExcerciseJournalsId",
                        column: x => x.ExcerciseJournalsId,
                        principalTable: "ExcerciseJournal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExcerciseJournalJournals_Journals_JournalsId",
                        column: x => x.JournalsId,
                        principalTable: "Journals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExcerciseJournalJournals_JournalsId",
                table: "ExcerciseJournalJournals",
                column: "JournalsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcerciseJournalJournals");

            migrationBuilder.DropTable(
                name: "ExcerciseJournal");
        }
    }
}
