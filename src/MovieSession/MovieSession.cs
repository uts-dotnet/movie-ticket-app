using System;

namespace MovieTicketApp
{
    public class MovieSession
    {
        public DateTime Date { get; private set; }
        public int AvailableSeats { get; private set; }

        public MovieSession(DateTime date, int availableSeats)
        {
            this.Date = date;
            this.AvailableSeats = availableSeats;
        }
    }
}
