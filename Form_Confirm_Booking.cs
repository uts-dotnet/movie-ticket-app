using System;
using System.Diagnostics;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    public partial class Form_Confirm_Booking : Form
    {
        private string posterFilePath = "";
        private string moviesFile = ".\\movies.txt";

        public Form_Confirm_Booking()
        {
            InitializeComponent();
            LoadData();

            lbl_Booked_Seats_Value.Text = TicketInfo.BookedSeats.Count.ToString();

            foreach (Seat seat in TicketInfo.BookedSeats)
            {
                listBox_Seats.Items.Add(seat.Name);
            }

            FileManager.Save();
        }

        private void Form_Confirm_Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            lbl_Movie_Title.Text = TicketInfo.SelectedMovie.Title;
            lbl_Session_Time.Text = TicketInfo.SelectedSession.Time.ToString("HH:mm");
            lbl_Ticket_Type.Text = TicketInfo.TicketType;
            lbl_Ticket_Price_Value.Text = TicketInfo.Price.ToString("C");
            lbl_Quantity_Value.Text = TicketInfo.Quantity.ToString();
            lbl_Subtotal_Value.Text = TicketInfo.SubTotal.ToString("C");

            LoadMoviePoster();
        }

        private void LoadMoviePoster()
        {
            try
            {
                string[] lines = File.ReadAllLines(moviesFile);

                foreach (string line in lines.Skip(1))
                {
                    string[] data = line.Split(',');
                    int movieId = Convert.ToInt32(data[0]);

                    // the poster file is written as name.jpg and is the last part of each line of the the movies file
                    string posterFile = data[data.Length - 1];

                    if (TicketInfo.SelectedMovie.Id == movieId)
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
            Form_Login form = new Form_Login();
            form.Show();
            this.Close();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            // Getting the details of the currently logged in user
            User currentUser = CurrentUserManager.Instance.CurrentUser;

            // When seats are selected they are formatted as "Seat 1". This extracts only the seat number
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

            FileManager.SaveBookings();

            Form_Checkout form = new Form_Checkout();
            form.Show();
            this.Close();
        }
    }
}