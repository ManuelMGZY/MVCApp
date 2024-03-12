using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;



namespace MVCApp.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies  { get; set; } //lista de la parte de la clase Movie, lleva ? porque puede que tenga o no datos
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }

        public string? SearchString { get; set; }
    
    }
}
