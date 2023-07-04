﻿using System.Text.Json.Serialization;


namespace MyJournalsAPI.Models
{
    public class ExcerciseJournal
    {
        public Guid Id { get; set; }

        public DateOnly Date { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Duration { get; set; }

        [JsonIgnore]
        public List<Journals>? Journals { get; set; }
    }
}
