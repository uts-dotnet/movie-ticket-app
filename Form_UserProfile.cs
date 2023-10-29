using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    //Form that displays for regular users when they access their profile. Allows users to see bookings and change their password.
    public partial class Form_UserProfile : Form
    {
        public Form_UserProfile()
        {
            InitializeComponent();

            //Initialize ticket image
            pic_Ticket.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Ticket.Image = Image.FromFile("ticket.png");
            pic_Ticket.Visible = false;

            //Set ticket labels to not be visible at first
            lbl_MovieName.Visible = false;
            lbl_MovieTime.Visible = false;
            lbl_Seats.Visible = false;


        }

        private void Form_UserProfile_Load(object sender, EventArgs e)
        {
            // Populate listBox_Bookings when the form loads
            PopulateListBox();
        }

        //Code that populates bookings into the list box
        private void PopulateListBox()
        {
            listBox_Bookings.Items.Clear(); // Clear the list before populating

            // Iterate through the bookings in GlobalData.Bookings
            foreach (Booking booking in GlobalData.Bookings)
            {
                // Find the associated Movie based on Movie ID
                Movie movie = GlobalData.Movies.FirstOrDefault(m => m.Id == booking.MovieID);

                // Create a string representation of the booking and add it to the ListBox
                string bookingInfo = $"Movie Title: {movie?.Title},  Booking ID: {booking.BookingID}";
                listBox_Bookings.Items.Add(bookingInfo);
            }
        }

        //Runs everytime someone selects a booking in the list box to update the ticket
        private void listBox_Bookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBox_Bookings.SelectedItem != null)
            {
                // Assuming that the selected item in the ListBox contains the booking information
                string selectedBookingInfo = listBox_Bookings.SelectedItem.ToString();

                // Split the selected booking information into parts
                string[] parts = selectedBookingInfo.Split(new[] { ", " }, StringSplitOptions.None);

                if (parts.Length >= 2)
                {
                    string part = parts[1]; // Assuming it's "Booking ID: 3"
                    string[] splitParts = part.Split(':');
                    if (splitParts.Length == 2)
                    {
                        if (int.TryParse(splitParts[1].Trim(), out int bookingID))
                        {
                            // Use LINQ to find the Booking object by bookingID
                            Booking? selectedBooking = GlobalData.Bookings.FirstOrDefault(booking => booking.BookingID == bookingID);

                            if (selectedBooking != null)
                            {
                                // Find the associated Movie based on Movie ID
                                Movie? movie = GlobalData.Movies.FirstOrDefault(m => m.Id == selectedBooking.MovieID);

                                // Get the movie title using LINQ
                                string movieTitle = movie != null ? movie.Title : "Movie Not Found";

                                // Now you have the selected Booking object, and you can access its properties
                                lbl_MovieName.Text = "Movie Title: " + movieTitle;
                                lbl_MovieTime.Text = "Time: " + selectedBooking.Session.ToString("HH:mm");
                                lbl_Seats.Text = "Seats: " + selectedBooking.SeatsBooked.Replace('-', ',');

                                // Initialize and hide PictureBox and labels
                                pic_Ticket.Visible = true;
                                lbl_MovieName.Visible = true;
                                lbl_MovieTime.Visible = true;
                                lbl_Seats.Visible = true;
                                lbl_Seats.BackColor = Color.Transparent;
                                lbl_MovieTime.BackColor = Color.Transparent;
                                lbl_Seats.BackColor = Color.Transparent;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }


        private void btn_BackToMovies_Click(object sender, EventArgs e)
        {
            // Return to the movies form
            Form_Movies movies = new Form_Movies();
            movies.Show();
            this.Close();
        }

        private void btn_GoToChangePW_Click(object sender, EventArgs e)
        {
            // Open the change password form
            Form_ChangePassword form = new Form_ChangePassword();
            form.Show();
            this.Close();
        }

    }
}
