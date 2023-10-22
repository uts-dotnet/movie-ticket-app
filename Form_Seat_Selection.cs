using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Form_Seat_Selection : Form
    {
        public TicketInfo TicketInfo { get; set; }
        private int _availableSeats;
        private int _ticketsRemaining;
        private int _totalSeatsSelected = 0;

        public Form_Seat_Selection(TicketInfo ticket)
        {
            InitializeComponent();

            TicketInfo = new TicketInfo(ticket.SelectedMovie, ticket.SelectedSession, ticket.Price, ticket.SubTotal, ticket.Quantity, ticket.TicketSelected);

            this._availableSeats = this.TicketInfo.SelectedSession.AvailableSeats;
            this._ticketsRemaining = this.TicketInfo.Quantity;

            LoadSeats();
        }

        private void LoadSeats()
        {
            lbl_Seats_Available_Value.Text = this._availableSeats.ToString();
            lbl_Total_Seats_Remaining_Value.Text = this.TicketInfo.Quantity.ToString();

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
                if (_totalSeatsSelected == this.TicketInfo.Quantity)
                {
                    listBox_Seats.Enabled = false;
                }
            }
        }

        private void UpdateLabels()
        {
            this._availableSeats--;
            lbl_Seats_Available_Value.Text = this._availableSeats.ToString();

            this._ticketsRemaining--;
            lbl_Total_Seats_Remaining_Value.Text = _ticketsRemaining.ToString();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }
    }
}
