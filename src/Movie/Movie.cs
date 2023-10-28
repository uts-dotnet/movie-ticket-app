using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Movie(int id, string title, string genre, int hours, int minutes, string description, string poster)
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.Hours = hours;
            this.Minutes = minutes;
            this.Description = description;
            this.Poster = poster;
        }

        public override string ToString()
        {
            return $"Movie: {this.Title}, Genre: {this.Genre}, Duration: {this.Hours}:{this.Minutes}, Description: {this.Description}";
        }
    }
}
