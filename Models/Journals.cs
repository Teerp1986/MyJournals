namespace MyJournalsAPI.Models
{
    public class Journals
    {
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public string? Notes { get; set; }  
    }
}
