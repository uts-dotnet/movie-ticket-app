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

        public Booking(int bookingID, int movieId, DateTime session, int numOfAttendees, string seatsBooked)
        {
            this.BookingID = bookingID;
            this.MovieID = movieId;
            this.Session = session;
            this.NumOfAttendees = numOfAttendees;
            this.SeatsBooked = seatsBooked;
        }

        // Must use this method to create bookings or else it won't increment ID or add to global
        public static Booking CreateNewBooking(int movieId, DateTime session, int numOfAttendees, string seatsBooked)
        {
            int newBookingId = GenerateNewBookingId();
            Booking booking = new Booking(newBookingId, movieId, session, numOfAttendees, seatsBooked);
            GlobalData.Bookings.Add(booking);
            return booking;
        }

        private static int GenerateNewBookingId()
        {
            int maxId = GlobalData.Bookings.Max(b => b.BookingID); // Find the maximum BookingId among existing bookings
            return maxId + 1;
        }
    }
}
