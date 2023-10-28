using System;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    [Serializable]

    public class Booking
    {
        public int BookingID { get; set; }
        public int MovieID { get; set; }
        public DateTime Session { get; set; }
        public int NumOfAttendees { get; set; }
        public string SeatsBooked { get; set; }

        public Booking(int movieId, DateTime session, int numOfAttendees, string seatsBooked)
        {
            this.BookingID = GenerateNewBookingId(); ; // Auto-increment the BookingId
            this.MovieID = movieId;
            this.Session = session;
            this.NumOfAttendees = numOfAttendees;
            this.SeatsBooked = seatsBooked;
        }

        private int GenerateNewBookingId()
        {
            int maxId = GlobalData.Bookings.Max(b => b.BookingID); // Find the maximum BookingId among existing bookings
            return maxId + 1;
        }
    }
}
