using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketApp
{
    public class Movie
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public Duration Duration { get; private set; }

        public Movie(string title, string genre, Duration duration)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"Movie: {Title}, Genre: {Genre}, Duration: {Duration}";
        }
    }
}
