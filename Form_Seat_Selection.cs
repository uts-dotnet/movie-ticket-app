using System;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Form_Seat_Selection : Form
    {
        private static int seatsRemaining = TicketInfo.Quantity;
        private int _totalSeatsSelected = 0;

        public Form_Seat_Selection()
        {
            InitializeComponent();

            LoadSeats();

            if (seatsRemaining == 0)
            {
                listBox_Seats.Enabled = false;
            }
        }

        private void Form_Seat_Selection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LoadSeats()
        {
            lbl_Seats_Available_Value.Text = TicketInfo.SelectedSession.AvailableSeats.ToString();
            lbl_Total_Seats_Remaining_Value.Text = seatsRemaining.ToString();

            listBox_Seats.Items.Clear();

            for (int i = 0; i < TicketInfo.SelectedSession.AvailableSeats; i++)
            {
                string seat = $"Seat {i + 1}";
                listBox_Seats.Items.Add(seat);
            }

            foreach (var seat in TicketInfo.BookedSeats)
            {
                // add selected seats to the corresponding listbox and remove them from the list of available seats
                listBox_Selected_Seats.Items.Add(seat.Name);
                listBox_Seats.Items.Remove(seat.Name);
            }
        }

        private void listBox_Seats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Seats.SelectedItem != null)
            {
                string seat = listBox_Seats.SelectedItem.ToString();
                listBox_Selected_Seats.Items.Add(seat);
                TicketInfo.AddSeat(new Seat(seat));

                _totalSeatsSelected++;

                TicketInfo.SelectedSession.AvailableSeats--;
                lbl_Seats_Available_Value.Text = TicketInfo.SelectedSession.AvailableSeats.ToString();

                seatsRemaining--;
                lbl_Total_Seats_Remaining_Value.Text = seatsRemaining.ToString();

                // disable the list box if the user can't select any more seats
                if (_totalSeatsSelected == TicketInfo.Quantity)
                {
                    listBox_Seats.Enabled = false;
                }

                // Remove the selected seat from the list after selecting it
                listBox_Seats.Items.Remove(seat);
            }
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
            string seatsBooked = string.Join("-", TicketInfo.BookedSeats.Select(seat => seat.Name.Split().Last()));

            //Create a new booking object
            Booking newBooking = Booking.CreateNewBooking(
                TicketInfo.MovieId,
                TicketInfo.SelectedSession.Time,
                TicketInfo.Quantity,
                seatsBooked,
                TicketInfo.SubTotal,
                TicketInfo.TicketType,
                currentUser.Id
            );

            Form_Confirm_Booking form = new Form_Confirm_Booking(TicketInfo.BookedSeats);
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
