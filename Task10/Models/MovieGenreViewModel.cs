using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Task10.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
    }
}
