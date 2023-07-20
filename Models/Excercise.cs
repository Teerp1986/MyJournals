using System.Text.Json.Serialization;


namespace MyJournalsAPI.Models
{
    public class Excercise : Journals
    {
        public string? WorkOutType { get; set; }

        public string? Duration { get; set; }

    }
}
