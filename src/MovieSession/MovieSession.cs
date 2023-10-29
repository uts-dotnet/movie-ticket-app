using System;

namespace MovieTicketApp
{
    public class MovieSession
    {
        // Properties to store movie session information

        // The unique identifier of the associated movie
        public int MovieID { get; set; }

        // The date and time of the movie session
        public DateTime Time { get; set; }

        // The number of available seats for the session
        public int AvailableSeats { get; set; }

        // Constructor to initialize movie session properties
        public MovieSession(int MovieID, DateTime time, int availableSeats)
        {
            this.MovieID = MovieID;
            this.Time = time;
            this.AvailableSeats = availableSeats;
        }
    }
}