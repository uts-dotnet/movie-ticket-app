﻿using System;

namespace MovieTicketApp
{
    public static class TicketInfo
    {
        /*
         * This static class stores data related to a movie ticket in order to allow for reusability of data across the app.
         * Since we are not using databases, this seemed like a suitable alternative.
         * Please note that not every field is initialised in the constructor, but instead reserved for when they are truly needed.
         */
        public static int MovieId { get; private set;  }
        public static Movie SelectedMovie { get; set; }
        public static MovieSession SelectedSession { get; set; }
        public static string TicketType { get; set; }
        public static double Price { get; set; }
        public static double SubTotal { get; set; }
        public static int Quantity { get; set; }
        public static List<Seat> BookedSeats { get; set; } = new List<Seat>();
        public static int TotalAvailableSeats { get; set; }
        public static int SeatsRemaining { get; set; }

        public static void SetTicket(Movie selectedMovie, MovieSession selectedSession, double price, double subTotal, int quantity, string ticketSelected)
        {
            SelectedMovie = selectedMovie;
            SelectedSession = selectedSession;
            Price = price;
            SubTotal = subTotal;
            Quantity = quantity;
            TicketType = ticketSelected;
            MovieId = selectedMovie.Id;
        }

        public static void AddSeat(Seat seat)
        {
            BookedSeats.Add(seat);
            BookedSeats.Sort((s1, s2) => CompareSeats(s1.Name, s2.Name));
        }

        private static int CompareSeats(string s1, string s2)
        {
            // Compare the seat number before sorting
            int seatNum1 = int.Parse(s1.Split(" ")[1]);
            int seatNum2 = int.Parse(s2.Split(" ")[1]);

            return seatNum1.CompareTo(seatNum2);
        }
    }
}
