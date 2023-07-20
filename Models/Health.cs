namespace MyJournalsAPI.Models
{
    public class Health : Journals
    {
        public string? HealthIssue { get; set; }

        public string? Description { get; set; }

        public string? Physician { get; set; }
    }
}
