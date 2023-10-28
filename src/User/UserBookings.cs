using System;
using System.Collections.Generic;

namespace MovieTicketApp.src.User
{
    public class UserBookings
    {
        public int UserId { get; set; }
        public List<int> Bookings { get; set; }

        public UserBookings(int userId, List<int> bookings)
        {
            UserId = userId;
            Bookings = bookings;
        }
    }
}
