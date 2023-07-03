namespace MyJournalsAPI.Models
{
    public class Journals
    {
        public Guid Id { get; set; }

        public List<Personal>? Personal { get; set; }

        public List<Health>? Health { get; set; }

        public List<Dietary>? Dietary { get; set; }

        public List<Travel>? Travel { get; set; }

        public List<ExcerciseJournal> ExcerciseJournals { get; set; }
    }
    
    public class Travel
    {
        public Guid Id { get; set; }

        public DateOnly Date { get; set; }

        public string Destination { get; set; }

        public string Duration { get; set; }
    }

    public class Dietary 
    {
        public Guid Id { get; set; }

        public DateOnly Date { get; set; }

        public string? Breakfast { get; set; }

        public string? Lunch { get; set; }

        public string? Dinner { get; set; }

        public string? Desert { get; set; }

        public string? Snacks { get; set; }

        public string DietaryNotes { get; set; }
        
    }

    public class Health
    {
        public Guid Id { get; set; }

        public DateOnly Date { get; set; }

        public string HealthIssue { get; set; }

        public string Description { get; set; }

        public string Physician { get; set; }
    }

    public class Personal
    {
        public Guid Id { get; set; }

        public DateOnly Date { get; set; }

        public string JournalEntry { get; set; }
    }
}
