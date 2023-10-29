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
            SetContinueButton(false);
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

                if (seatsRemaining == 0)
                {
                    SetContinueButton(true);
                }

                // Remove the selected seat from the list after selecting it
                listBox_Seats.Items.Remove(seat);
            }
        }

        private void SetContinueButton(bool value)
        {
            if (value)
            {
                btn_Continue.Enabled = true;
                btn_Continue.BackColor = Color.Firebrick;
                btn_Continue.ForeColor = Color.White;
            }
            else
            {
                btn_Continue.Enabled = false;
                btn_Continue.BackColor = Color.White;
                btn_Continue.ForeColor = Color.Gray;
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
                        Form_Confirm_Booking form = new Form_Confirm_Booking();
            form.Show();
            this.Close();
        }
    }
}
