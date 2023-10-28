using System;

namespace MovieTicketApp
{
    public static class TicketInfo
    {
        public static int MovieId { get; private set;  }
        public static Movie SelectedMovie { get; set; }
        public static MovieSession SelectedSession { get; set; }
        public static string TicketType { get; set; }
        public static double Price { get; set; }
        public static double SubTotal { get; set; }
        public static int Quantity { get; set; }

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
    }
}
