using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    /*public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }*/
    public class Movies
    {
        public int Rating { get; set; }
        public string Movie { get; set; }
    }

    public class MovieDatabase : List<Movies>
    {

        public MovieDatabase()
        {
            Add(new Movies() { Rating = 3, Movie = "101 Dalmations" });
            Add(new Movies() { Rating = 5, Movie = "LOTR" });
            Add(new Movies() { Rating = 1, Movie = "Sharknado" });
        }
    }

}
