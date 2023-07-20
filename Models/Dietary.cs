namespace MyJournalsAPI.Models
{
    public class Dietary : Journals
    {
        public string? Breakfast { get; set; }

        public string? Lunch { get; set; }

        public string? Dinner { get; set; }

        public string? Desert { get; set; }

        public string? Snacks { get; set; }

        public int? TotalCalories { get; set; }

        public int? TotalCarbohydrates { get; set; }
        
        public int? TotalProtien { get; set; }
    }
}
