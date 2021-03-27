using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Range(1,20)]
        [Display(Name = "Numbers In Stock")]
        public byte NumbersInStock { get; set; }

        [Range(0,20)]
        public byte NumbersAvailable { get; set; }
    }
}