using System.Collections.Generic;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit" : "New";
            }
        }
    }
}