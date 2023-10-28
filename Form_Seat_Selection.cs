using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Form_Seat_Selection : Form
    {
        private int _availableSeats;
        private int _ticketsRemaining;
        private int _totalSeatsSelected = 0;
        private List<Seat> _bookedSeats = new List<Seat>();

        public Form_Seat_Selection()
        {
            InitializeComponent();

            this._availableSeats = TicketInfo.SelectedSession.AvailableSeats;
            this._ticketsRemaining = TicketInfo.Quantity;
            LoadSeats();
        }

        private void Form_Seat_Selection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // if the form is not closed it'll cause a conflict between Visual Studio and the executable file
        }

        private void LoadSeats()
        {
            lbl_Seats_Available_Value.Text = this._availableSeats.ToString();
            lbl_Total_Seats_Remaining_Value.Text = TicketInfo.Quantity.ToString();

            listBox_Seats.Items.Clear();

            for (int i = 0; i < this._availableSeats; i++)
            {
                string seat = $"Seat {i + 1}";
                listBox_Seats.Items.Add(seat);
            }
        }

        private void listBox_Seats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Seats.SelectedItem != null)
            {
                string seat = listBox_Seats.SelectedItem.ToString();
                listBox_Selected_Seats.Items.Add(seat);
                _bookedSeats.Add(new Seat(seat));

                _totalSeatsSelected++;

                UpdateLabels();

                // disable the list box if the user can't select any more seats
                if (_totalSeatsSelected == TicketInfo.Quantity)
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

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            User currentUser = CurrentUserManager.Instance.CurrentUser;

            // Format booked seats
            string seatsBooked = string.Join("-", _bookedSeats.Select(seat => seat.Name.Split().Last()));

            //Create a new booking object
            Booking newBooking = Booking.CreateNewBooking(
                TicketInfo.MovieId,  // Use your movie ID here
                TicketInfo.SelectedSession.Time,
                TicketInfo.Quantity,
                seatsBooked,
                TicketInfo.SubTotal,
                TicketInfo.TicketType,
                currentUser.Id
            );

            Form_Confirm_Booking form = new Form_Confirm_Booking(_bookedSeats);
            form.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_Ticket_Selection form = new Form_Ticket_Selection();
            form.Show();
            this.Close();
        }
    }
}
