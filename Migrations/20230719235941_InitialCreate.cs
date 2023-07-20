using System;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyJournalsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Breakfast = table.Column<string>(type: "TEXT", nullable: true),
                    Lunch = table.Column<string>(type: "TEXT", nullable: true),
                    Dinner = table.Column<string>(type: "TEXT", nullable: true),
                    Desert = table.Column<string>(type: "TEXT", nullable: true),
                    Snacks = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCalories = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalCarbohydrates = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalProtien = table.Column<int>(type: "INTEGER", nullable: true),
                    WorkOutType = table.Column<string>(type: "TEXT", nullable: true),
                    Duration = table.Column<string>(type: "TEXT", nullable: true),
                    HealthIssue = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Physician = table.Column<string>(type: "TEXT", nullable: true),
                    EntryTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Destination = table.Column<string>(type: "TEXT", nullable: true),
                    Travel_Duration = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Journals");

        }

       
    }
}
