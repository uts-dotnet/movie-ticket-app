using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketApp
{
    /* Global Data variables are stored within this class */

    internal class GlobalData
    {

        //Stores Global List<T> variables for access across the software

        // List to store movie data
        public static List<Movie> Movies{ get; set; } = new List<Movie>();

        // List to store booking data
        public static List<Booking> Bookings { get; set; } = new List<Booking>();

        // List to store movie session data
        public static List<MovieSession> Sessions { get; set; } = new List<MovieSession>();

        // List to store user data
        public static List<UserData> UserData { get; set; } = new List<UserData>();

        // Clear or reset the data in the global lists
        public static void Clear()
        {
            Movies.Clear();
            Bookings.Clear();
            Sessions.Clear();
            UserData.Clear();
        }

    }
}
