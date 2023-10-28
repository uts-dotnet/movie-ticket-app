using System;
using System.Collections.Generic;

namespace MovieTicketApp.src.User
{
    public class UserBookings
    {
        public int UserId { get; set; }
        public string Bookings { get; set; }
        public static List<int> BookingList { get; set; }

        public UserBookings(int userId, string bookings)
        {
            UserId = userId;
            Bookings = bookings;
            BookingList = getBookingList(bookings);
        }

        // Convert the bookings string to a List<int> format
        public List<int> getBookingList(string bookings)
        {
            if (string.IsNullOrWhiteSpace(bookings))
            {
                return new List<int>();
            }

            string[] bookingParts = bookings.Split('-');
            List<int> bookingList = new List<int>();

            foreach (string booking in bookingParts)
            {
                if (int.TryParse(booking, out int bookingId))
                {
                    bookingList.Add(bookingId);
                }
            }

            return bookingList;
        }

    }
}
