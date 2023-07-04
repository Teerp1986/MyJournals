using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyJournalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseMIG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseJournalJournals_ExcerciseJournal_ExcerciseJournalsId",
                table: "ExcerciseJournalJournals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcerciseJournal",
                table: "ExcerciseJournal");

            migrationBuilder.RenameTable(
                name: "ExcerciseJournal",
                newName: "ExerciseJournals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseJournals",
                table: "ExerciseJournals",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseJournalJournals_ExerciseJournals_ExcerciseJournalsId",
                table: "ExcerciseJournalJournals",
                column: "ExcerciseJournalsId",
                principalTable: "ExerciseJournals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseJournalJournals_ExerciseJournals_ExcerciseJournalsId",
                table: "ExcerciseJournalJournals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseJournals",
                table: "ExerciseJournals");

            migrationBuilder.RenameTable(
                name: "ExerciseJournals",
                newName: "ExcerciseJournal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcerciseJournal",
                table: "ExcerciseJournal",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseJournalJournals_ExcerciseJournal_ExcerciseJournalsId",
                table: "ExcerciseJournalJournals",
                column: "ExcerciseJournalsId",
                principalTable: "ExcerciseJournal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
