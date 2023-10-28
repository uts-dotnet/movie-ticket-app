using System;
using System.Diagnostics;

namespace MovieTicketApp
{
    public partial class Form_Confirm_Booking : Form
    {
        private string posterFilePath = "";
        private string moviesFile = "movies.txt";

        public Form_Confirm_Booking(TicketInfo ticket, List<Seat> bookedSeats)
        {
            InitializeComponent();
            LoadData(ticket);

            lbl_Booked_Seats_Value.Text = bookedSeats.Count.ToString();

            foreach (Seat seat in bookedSeats)
            {
                listBox_Seats.Items.Add(seat.Name);
            }
        }

        private void Form_Confirm_Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); 
        }

        private void LoadData(TicketInfo ticket)
        {
            lbl_Movie_Title.Text = ticket.SelectedMovie.Title;
            lbl_Session_Time.Text = ticket.SelectedSession.Time.ToString("HH:mm");
            lbl_Ticket_Type.Text = ticket.TicketType;
            lbl_Ticket_Price_Value.Text = ticket.Price.ToString("C");
            lbl_Quantity_Value.Text = ticket.Quantity.ToString();
            lbl_Subtotal_Value.Text = ticket.SubTotal.ToString("C");

            LoadMoviePoster(ticket);
        }

        private void LoadMoviePoster(TicketInfo ticket)
        {
            try
            {
                string[] lines = File.ReadAllLines(moviesFile);

                foreach (string line in lines.Skip(1))
                {
                    string[] data = line.Split(',');

                    int movieId = Convert.ToInt32(data[0]);
                    string posterFile = data[data.Length - 1];

                    if (ticket.SelectedMovie.Id == movieId)
                    {
                        this.posterFilePath += posterFile;
                    }
                }

                try
                {
                    picbox_Poster_Booking.Image = Image.FromFile(this.posterFilePath);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login form = new frm_Login();
            form.Show();
            this.Close();
        }
    }
}