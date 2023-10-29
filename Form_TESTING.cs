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
using MovieTicketApp.src.User;

namespace MovieTicketApp
{
    public partial class Form_TESTING : Form
    {
        public Form_TESTING()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new Movie object
            Movie newMovie = new Movie(
                // Fill in the parameters as needed
                movieID: 10000, // You need to define a method to get the next available movie ID
                title: "New Movie",
                genre: "Action",
                hours: 2,
                minutes: 15,
                year: 2023,
                month: 10,
                day: 29,
                description: "A new action movie",
                poster: "new_movie_poster.jpg"
            );

            GlobalData.Movies.Clear();

            // Add the new movie to the GlobalData.Movies list
            GlobalData.Movies.Add(newMovie);

            // Save the updated movie list to the file
            FileManager.SaveMovies();

            // Optionally, you can display a message to indicate success
            MessageBox.Show("New movie added and saved successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new Booking object
            Booking newBooking = new Booking(
                // Fill in the parameters as needed
                bookingID: 1000000, // You need to define a method to get the next available booking ID
                movieID: 40001, // Specify the movie ID for the booking
                session: DateTime.Now.AddHours(2), // Set the session time
                numOfAttendees: 2, // Specify the number of tickets
                seatsBooked: "A1, A2", // Specify the seats booked
                subtotal: 20.0, // Specify the subtotal
                ticketType: "Standard", // Specify the ticket type
                userID: 10001 // Specify the user ID
            );

            GlobalData.Bookings.Clear();

            // Add the new booking to the GlobalData.Bookings list
            GlobalData.Bookings.Add(newBooking);

            // Save the updated booking list to the file
            FileManager.SaveBookings();

            // Optionally, you can display a message to indicate success
            MessageBox.Show("New booking added and saved successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new MovieSession object
            MovieSession newSession = new MovieSession(
                // Fill in the parameters as needed
                MovieID: 111111, // Specify the movie ID for the session
                time: DateTime.Now.AddHours(2), // Set the session time
                availableSeats: 100 // Set the available seats
            );

            GlobalData.Sessions.Clear();

            // Add the new session to the GlobalData.Sessions list
            GlobalData.Sessions.Add(newSession);

            // Save the updated session list to the file
            FileManager.SaveSessions();

            // Optionally, you can display a message to indicate success
            MessageBox.Show("New movie session added and saved successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            {
                // Create a new UserData object
                UserData newUser = new UserData(
                    // Fill in the parameters as needed
                    userId: 2312321, // You need to define a method to get the next available user ID
                    username: "newuser",
                    password: "password",
                    firstName: "New",
                    lastName: "User"
                );

                GlobalData.UserData.Clear();

                // Add the new user to the GlobalData.UserData list
                GlobalData.UserData.Add(newUser);



                // Save the updated user data list to the file
                FileManager.SaveUserData();

                // Optionally, you can display a message to indicate success
                MessageBox.Show("New user data added and saved successfully!");
            }

        }
    }
}
