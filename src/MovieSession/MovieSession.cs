using System;

namespace MovieTicketApp
{
    public class MovieSession
    {
        public DateTime Time { get; private set; }
        public int AvailableSeats { get; private set; }

        public MovieSession(DateTime time, int availableSeats)
        {
            this.Time = time;
            this.AvailableSeats = availableSeats;
        }
    }
}
