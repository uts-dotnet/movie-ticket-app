using System;

namespace MovieTicketApp
{
    // Represents a booking made by a user for a movie session
    public class Booking
    {
        // Properties to store booking information

        // The unique identifier of the booking
        public int BookingID { get; set; }

        // The unique identifier of the associated movie
        public int MovieID { get; set; }

        // The date and time of the movie session
        public DateTime Session { get; set; }

        // The number of tickets booked for the session
        public int NumOfTickets { get; set; }

        // A string representing the seats booked for the session
        public string SeatsBooked { get; set; }

        // The subtotal cost of the booking
        public double Subtotal { get; set; }

        // The type of ticket booked (e.g., adult, child, senior)
        public string TicketType { get; set; }

        // The unique identifier of the user who made the booking
        public int UserID { get; set; }

        // Constructor to initialize booking properties
        public Booking(int bookingID, int movieID, DateTime session, int numOfAttendees, string seatsBooked
            , double subtotal, string ticketType, int userID)
        {
            this.BookingID = bookingID;
            this.MovieID = movieID;
            this.Session = session;
            this.NumOfTickets = numOfAttendees;
            this.SeatsBooked = seatsBooked;
            this.TicketType = ticketType;
            this.UserID = userID;
            this.Subtotal = subtotal;
        }

        // Use this method to create new bookings to ensure ID increment and addition to global list
        public static Booking CreateNewBooking(int movieId, DateTime session, int numOfAttendees, string seatsBooked
            , double subtotal, string ticketType, int userID)
        {
            int newBookingId = GenerateNewBookingId();
            Booking booking = new Booking(newBookingId, movieId, session, 
                numOfAttendees, seatsBooked, subtotal, ticketType, userID);
            GlobalData.Bookings.Add(booking);
            return booking;
        }

        // Generate a new unique booking ID based on existing bookings
        private static int GenerateNewBookingId()
        {
            int maxId = GlobalData.Bookings.Max(b => b.BookingID); // Find the maximum BookingId among existing bookings
            return maxId + 1;
        }
    }
}
