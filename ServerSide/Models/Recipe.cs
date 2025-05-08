using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Instructions { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}