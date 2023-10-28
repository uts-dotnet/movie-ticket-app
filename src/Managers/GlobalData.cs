using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MovieTicketApp.src.User;

namespace MovieTicketApp.src.Managers
{
    internal class GlobalData
    {

        //Stores Global List<T> variables for access across the software
        public static List<Movie> Movies{ get; set; } = new List<Movie>();
        public static List<Booking> Bookings { get; set; } = new List<Booking>();
        public static List<MovieSession> Sessions { get; set; } = new List<MovieSession>();
        public static List<UserData> UserData { get; set; } = new List<UserData>();
        public static List<MovieTicketApp.User> Users { get; set; } = new List<MovieTicketApp.User>();
        public static List<UserBookings> UserBookingsList { get; set; } = new List<UserBookings>();


        // Clear or reset the data in the global lists
        public static void Clear()
        {
            Movies.Clear();
            Bookings.Clear();
            Sessions.Clear();
            UserData.Clear();
            Users.Clear();
            UserBookingsList.Clear();
        }

        // Load data from text files and populate the global lists
        public static void LoadData()
        {
            // Load movies from movies.txt
            FileManager<Movie> movieFileManager = new FileManager<Movie>("movies.txt");
            Movies = movieFileManager.Load();

            // Load bookings from bookings.txt
            FileManager<Booking> bookingFileManager = new FileManager<Booking>("bookings.txt");
            Bookings = bookingFileManager.Load();

            // Load sessions from Sessions.txt
            FileManager<MovieSession> sessionFileManager = new FileManager<MovieSession>("Sessions.txt");
            Sessions = sessionFileManager.Load();

            // Load credentials from login-credentials.txt
            FileManager<UserData> credentialsFileManager = new FileManager<UserData>("credentials.txt");
            UserData = credentialsFileManager.Load();

            // Load user bookings from user-bookings.txt
            FileManager<UserBookings> userBookingsFileManager = new FileManager<UserBookings>("user-bookings.txt");
            UserBookingsList = userBookingsFileManager.Load();
        }


    }
}
