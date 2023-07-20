using Microsoft.EntityFrameworkCore;
using MyJournalsAPI.Models;
using System.Reflection.Metadata;

namespace MyJournalsAPI
{
    public class MyJournalDbContext : DbContext
    {
        public DbSet<Journals> Journals { get; set; }
        public DbSet<Excercise> Exercise { get; set; }
        public DbSet<Health> Health { get; set; }
        public DbSet<Dietary> Dietary { get; set; }
        public DbSet<Travel> Travel { get; set; }
        public DbSet<Personal> Personal { get; set; }

        public string? DbPath { get; }

        public MyJournalDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "myjournals.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

}
