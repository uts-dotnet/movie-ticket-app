using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketApp
{
    public class Movie
    {
        public int Id { get; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public Duration Duration { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Description { get; private set; }
        public string Poster { get; private set; }

        public Movie(int id, string title, string genre, Duration duration, DateTime releaseDate, string description, string poster)
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.Duration = duration;
            this.Description = description;
            this.ReleaseDate = releaseDate;
            this.Poster = poster;
        }

        public override string ToString()
        {
            return $"Movie: {this.Title}, Genre: {this.Genre}, Duration: {this.Duration}, Release Date: {this.ReleaseDate}";
        }
    }
}
