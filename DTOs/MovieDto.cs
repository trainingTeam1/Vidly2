using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        public int NumbersInStock { get; set; }
    }
}