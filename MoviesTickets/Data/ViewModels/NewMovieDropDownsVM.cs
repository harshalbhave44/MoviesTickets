//This class is made for the dropdown while creating movie

using MoviesTickets.Models;

namespace MoviesTickets.Data.ViewModels
{
    public class NewMovieDropDownsVM
    {
        public NewMovieDropDownsVM()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }

        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
