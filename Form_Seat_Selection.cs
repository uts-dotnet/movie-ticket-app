using System;

namespace MovieTicketApp
{
    public partial class Form_Seat_Selection : Form
    {
        private Movie _movie;
        private MovieSession _session;

        public Form_Seat_Selection(Movie selectedMovie, MovieSession selectedSession)
        {
            InitializeComponent();

            this._movie = selectedMovie;
            this._session = selectedSession;

            LoadSeats();
        }

        private void LoadSeats()
        {
            int availableSeats = this._session.AvailableSeats;

            listBox_Seats.Items.Clear();

            for (int i = 0; i < availableSeats; i++)
            {
                listBox_Seats.Items.Add($"Seat {i + 1}");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_Movie_Ticket form = new Form_Movie_Ticket(this._movie, this._session);
            form.Show();
            this.Close();
        }
    }
}
