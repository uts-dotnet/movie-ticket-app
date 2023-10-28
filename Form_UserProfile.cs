using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    public partial class Form_UserProfile : Form
    {

        string[] dataArray = { "Button 1", "Button 2", "Button 3", "Button 4", "Button 5" };


        public Form_UserProfile()
        {

            foreach (string item in dataArray)
            {
                Button button = new Button
                {
                    Text = item,
                    Width = 100, // Set the width as per your preference
                    Height = 30   // Set the height as per your preference
                };

                button.Click += Button_Click; // Add a click event handler for each butt
                //panel_MovieButtons.Controls.Add(button); // Add the button to the FlowLayoutPanel
            }

            InitializeComponent();

            pic_Ticket.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Ticket.Image = Image.FromFile("ticket.png");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //Add code to open the movie ticket view here!

            // Handle the button click event here
            // You can access the button's Text property to identify which button was clicked
            Button clickedButton = (Button)sender;
            MessageBox.Show("You clicked: " + clickedButton.Text);
        }


        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            frm_ChangePassword changePasswordForm = new frm_ChangePassword();
            changePasswordForm.Show();
            this.Hide();
        }

        private void Form_UserProfile_Load(object sender, EventArgs e)
        {
            // Populate listBox_Bookings when the form loads
            PopulateListBox();
        }

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

        private void listBox_Bookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBox_Bookings.SelectedItem != null)
            {
                // Assuming that the selected item in the ListBox contains the booking information
                string selectedBookingInfo = listBox_Bookings.SelectedItem.ToString();

                // Split the selected booking information into parts
                string[] parts = selectedBookingInfo.Split(new[] { ", " }, StringSplitOptions.None);

                // Assuming that the title, session, and seats are displayed in this order in the string
                if (parts.Length >= 3)
                {
                    // Update the labels with the selected booking information
                    lbl_MovieName.Text = "";
                    lbl_MovieTime.Text = "";
                    lbl_Seats.Text = "";
                }
            }
        }

        private void btn_BackToMovies_Click(object sender, EventArgs e)
        {
            Form_Movies movies = new Form_Movies();
            movies.Show();
            this.Close();
        }

        private void btn_GoToChangePW_Click(object sender, EventArgs e)
        {
            frm_ChangePassword form = new frm_ChangePassword();
            form.Show();
            this.Close();
        }
    }
}
