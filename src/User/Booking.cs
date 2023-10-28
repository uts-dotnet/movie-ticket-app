using System;

namespace MovieTicketApp
{
    public class Booking
    {
        private static int lastBookingId = 3; // Set to the highest existing BookingId

        public int BookingId { get; set; }
        public int MovieId { get; set; }
        public DateTime Session { get; set; }
        public int NumOfAttendees { get; set; }
        public string SeatsBooked { get; set; }

        public Booking(int movieId, DateTime session, int numOfAttendees, string seatsBooked)
        {
            this.BookingId = ++lastBookingId; // Auto-increment the BookingId
            this.MovieId = movieId;
            this.Session = session;
            this.NumOfAttendees = numOfAttendees;
            this.SeatsBooked = seatsBooked;
        }
    }
}
