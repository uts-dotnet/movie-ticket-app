using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    public class Movie
    {
        public int Id { get; set; } // Add a public setter
        public string Title { get; set; } // Add a public setter
        public string Genre { get; set; } // Add a public setter
        public int Hours { get; set; } // Add a public setter
        public int Minutes { get; set; } // Add a public setter
        public string Description { get; set; } // Add a public setter
        public string Poster { get; set; } // Add a public setter

        public Movie(string title, string genre, int hours, int minutes, string description, string poster)
        {
            Id = GenerateNewMovieId(); // Generate a new movie Id
            Title = title;
            Genre = genre;
            Hours = hours;
            Minutes = minutes;
            Description = description;
            Poster = poster;
        }

        private int GenerateNewMovieId()
        {
            int maxId = GlobalData.Movies.Max(m => m.Id); // Find the maximum Id among existing movies
            return maxId + 1;
        }

        public override string ToString()
        {
            return $"Movie: {this.Title}, Genre: {this.Genre}, Duration: {this.Hours}:{this.Minutes}, Description: {this.Description}";
        }
    }
}
