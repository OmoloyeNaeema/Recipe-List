using System;

namespace backend.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public bool Watched { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}