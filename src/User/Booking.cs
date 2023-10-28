using System;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int MovieId { get; set; }
        public DateTime Session { get; set; }
        public int NumOfAttendees { get; set; }
        public string SeatsBooked { get; set; }

        public Booking(int movieId, DateTime session, int numOfAttendees, string seatsBooked)
        {
            this.BookingId = GenerateNewBookingId(); ; // Auto-increment the BookingId
            this.MovieId = movieId;
            this.Session = session;
            this.NumOfAttendees = numOfAttendees;
            this.SeatsBooked = seatsBooked;
        }

        private int GenerateNewBookingId()
        {
            int maxId = GlobalData.Bookings.Max(b => b.BookingId); // Find the maximum BookingId among existing bookings
            return maxId + 1;
        }
    }
}
