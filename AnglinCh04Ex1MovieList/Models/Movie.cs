using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AnglinCh04Ex1MovieList.Models
{
    public class Movie
    {
        public string Slug => Name?.Replace(' ', '-').ToLower() + "-" + Year?.ToString();

        public int MovieId { get; set; }

        [Required (ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required (ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Please enter a year after 1889.")]
        public int? Year { get; set; }

        [Required (ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Please enter a rating between 1 and 5.")]
        public int? Rating { get; set; }

        [Required (ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; } = string.Empty;
        [ValidateNever]
        public Genre Genre { get; set; } = null!;
    }
}
