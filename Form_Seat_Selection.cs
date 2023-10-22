using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Form_Seat_Selection : Form
    {
        private Movie _movie;
        private MovieSession _session;
        private int _availableSeats;
        private int _ticketQuantity;
        private double _ticketPrice;
        private double _subTotal;
        private string _ticketSelected;
        private int _ticketsRemaining;
        private int _totalSeatsSelected = 0;

        public Form_Seat_Selection(TicketInfo ticketInfo)
        {
            InitializeComponent();

            this._movie = ticketInfo.SelectedMovie;
            this._session = ticketInfo.SelectedSession;
            this._availableSeats = this._session.AvailableSeats;
            this._ticketQuantity = ticketInfo.Quantity;
            this._ticketPrice = ticketInfo.Price;
            this._subTotal = ticketInfo.SubTotal;
            this._ticketSelected = ticketInfo.TicketSelected;
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
                string seat = listBox_Seats.SelectedItem.ToString();
                listBox_Selected_Seats.Items.Add(seat);

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
            TicketInfo ticketInfo = new TicketInfo(this._movie, this._session, this._ticketPrice, this._subTotal, this._ticketQuantity, this._ticketSelected);
            Form_Ticket_Booking form = new Form_Ticket_Booking(ticketInfo);
            form.Show();
            this.Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }
    }
}
