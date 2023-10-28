using System;

namespace MovieTicketApp
{
    public class MovieSession
    {
        public int MovieID { get; set; }
        public DateTime Time { get; set; }
        public int AvailableSeats { get; set; }

        public MovieSession(int MovieID, DateTime time, int availableSeats)
        {
            this.MovieID = MovieID;
            this.Time = time;
            this.AvailableSeats = availableSeats;
        }
    }
}