using System;

namespace MovieTicketApp
{
    public partial class Form_Seat_Selection : Form
    {
        private Movie _movie;
        private MovieSession _session;
        private int _availableSeats;
        private int _ticketQuantity;
        private int _ticketsRemaining;
        private int _totalSeatsSelected = 0;

        public Form_Seat_Selection(Movie selectedMovie, MovieSession selectedSession, int ticketQuantity)
        {
            InitializeComponent();

            this._movie = selectedMovie;
            this._session = selectedSession;
            this._availableSeats = selectedSession.AvailableSeats;
            this._ticketQuantity = ticketQuantity;
            this._ticketsRemaining = this._ticketQuantity;

            LoadSeats();
        }

        private void LoadSeats()
        {
            lbl_Seats_Available_Value.Text = this._availableSeats.ToString();
            lbl_Total_Seats_Remaining_Value.Text = this._ticketQuantity.ToString();

            listBox_Seats.Items.Clear();

            for (int i = 0; i < this._availableSeats; i++)
            {
                listBox_Seats.Items.Add($"Seat {i + 1}");
            }
        }

        private void listBox_Seats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Seats.SelectedItem != null)
            {
                _totalSeatsSelected++;

                UpdateLabels();

                // disable the list box if the user can't select any more seats
                if (_totalSeatsSelected == this._ticketQuantity)
                {
                    listBox_Seats.Enabled = false;
                }
            }
        }

        private void UpdateLabels()
        {
            int seatsAvailable = Convert.ToInt32(_availableSeats.ToString());
            seatsAvailable--;
            lbl_Seats_Available_Value.Text = seatsAvailable.ToString();

            this._ticketsRemaining--;
            lbl_Total_Seats_Remaining_Value.Text = _ticketsRemaining.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_Movie_Ticket form = new Form_Movie_Ticket(this._movie, this._session);
            form.Show();
            this.Close();
        }
    }
}
