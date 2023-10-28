using System;

namespace MovieTicketApp
{
    public class TicketInfo
    {
        public int MovieId { get; }
        public Movie SelectedMovie { get; set; }
        public MovieSession SelectedSession { get; set; }
        public string TicketType { get; set; }
        public double Price { get; set; }
        public double SubTotal { get; set; }
        public int Quantity { get; set; }

        public TicketInfo(Movie selectedMovie, MovieSession selectedSession, double price, double subTotal, int quantity)
        {
            SelectedMovie = selectedMovie;
            SelectedSession = selectedSession;
            Price = price;
            SubTotal = subTotal;
            Quantity = quantity;
            TicketType = string.Empty;
            MovieId = selectedMovie.Id;
        }

        public TicketInfo(Movie selectedMovie, MovieSession selectedSession, double price, double subTotal, int quantity, string ticketSelected)
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
