using Microsoft.EntityFrameworkCore;
using MyJournalsAPI.Models;
using System.Reflection.Metadata;

namespace MyJournalsAPI
{
    public class MyJournalDbContext : DbContext
    {
        public DbSet<Journals> Journals { get; set; }
        public DbSet<ExcerciseJournal> ExerciseJournals { get; set; }

        public string? DbPath { get; }

        public MyJournalDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "myjournal1.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
