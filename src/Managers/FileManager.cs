using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MovieTicketApp.src.User;

namespace MovieTicketApp.src.Managers
{
    public class FileManager
    {
        public static void Load()
        {
            LoadSessions(false);
            LoadMovies(false);
            LoadUserData(false);
            LoadBookings(false);
        }

        // Implement the Save method similarly
        public static void Save()
        {
            SaveMovies();
            SaveSessions();
            SaveUserData();
            SaveBookings();
        }

        /* MOVIE HANDLING */
        public static void LoadMovies(bool skipHeaders = true)
        {
            string filePath = "movies.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (skipHeaders && lines.Length > 0)
                {
                    lines = lines.Skip(1).ToArray(); // Skip the headers
                }

                foreach (string line in lines)
                {
                    string[] parts = ParseCsvLine(line); // Custom CSV parsing

                    if (parts.Length == 10)
                    {
                        int id;
                        if (int.TryParse(parts[0], out id))
                        {
                            string title = parts[1];
                            string genre = parts[2];
                            int hours;
                            if (int.TryParse(parts[3], out hours))
                            {
                                int minutes;
                                if (int.TryParse(parts[4], out minutes))
                                {
                                    int year;
                                    if (int.TryParse(parts[5], out year))
                                    {
                                        int month;
                                        if (int.TryParse(parts[6], out month))
                                        {
                                            int day;
                                            if (int.TryParse(parts[7], out day))
                                            {
                                                string description = parts[8];
                                                string poster = parts[9];

                                                // Create a Movie object with the provided 'id'
                                                Movie movie = new Movie(id, title, genre, hours, minutes, year, month, day, description, poster);

                                                GlobalData.Movies.Add(movie);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void SaveMovies()
        {
            using (StreamWriter writer = new StreamWriter("movies.txt", false))
            {
                // Write headers
                writer.WriteLine("id,title,genre,hours,minutes,year,month,day,description,poster");

                // Write all movies in GlobalData
                foreach (Movie movie in GlobalData.Movies)
                {
                    string line = $"{movie.Id},{movie.Title},{movie.Genre},{movie.Hours},{movie.Minutes},{movie.Year},{movie.Month},{movie.Day},{movie.Description},{movie.Poster}";
                    writer.WriteLine(line);
                }
            }
        }

        // Custom CSV parsing that handles double quotes
        private static string[] ParseCsvLine(string line)
        {
            var parts = new List<string>();
            int start = 0;
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '"')
                {
                    inQuotes = !inQuotes;
                }

                if (line[i] == ',' && !inQuotes)
                {
                    string part = line.Substring(start, i - start).Trim(' ', ',');
                    parts.Add(part);
                    start = i + 1;
                }
            }

            // Add the last part
            parts.Add(line.Substring(start).Trim(' ', ','));

            return parts.ToArray();
        }


        /* MOVIE SESSION HANDLING */
        public static void LoadSessions(bool skipHeaders = true)
        {
            string filePath = "Sessions.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                if (skipHeaders && lines.Length > 0)
                {
                    lines = lines.Skip(1).ToArray(); // Skip the headers
                }


                foreach (var line in lines)
                {
                    var parts = line.Split(','); // Split the line into parts based on the delimiter (',')

                    if (parts.Length == 3)
                    {
                        if (int.TryParse(parts[0], out int movieId) &&
                            DateTime.TryParse(parts[1], out DateTime time) &&
                            int.TryParse(parts[2], out int availableSeats))
                        {
                            // Create a MovieSession object and add it to the sessions list
                            MovieSession session = new MovieSession(movieId, time, availableSeats);
                            GlobalData.Sessions.Add(session);
                        }
                    }
                }

            }

        }

        public static void SaveSessions()
        {
            using (StreamWriter writer = new StreamWriter("Sessions.txt", false))
            {
                // Write headers
                writer.WriteLine("movieId,time,totalAvailableSeats");

                // Write all sessions
                foreach (MovieSession session in GlobalData.Sessions)
                {
                    string line = $"{session.MovieID},{session.Time},{session.AvailableSeats}";
                    writer.WriteLine(line);
                }
            }
        }


        /* USER CREDENTIALS DATA HANDLING */
        public static void LoadUserData(bool skipHeaders = true)
        {
            string filePath = "login-credentials.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                if (skipHeaders && lines.Length > 0)
                {
                    lines = lines.Skip(1).ToArray(); // Skip the headers
                }

                foreach (var line in lines)
                {
                    var parts = line.Split(','); // Split the line into parts based on the delimiter (',')

                    if (parts.Length == 5)
                    {
                        if (int.TryParse(parts[0], out int userId))
                        {
                            string username = parts[1];
                            string password = parts[2];
                            string firstName = parts[3];
                            string lastName = parts[4];

                            // Create a UserData object and add it to the GlobalData.UserData list
                            UserData userData = new UserData(userId, username, password, firstName, lastName);
                            GlobalData.UserData.Add(userData);
                        }
                    }
                }
            }
        }

        public static void SaveUserData()
        {
            string filePath = "login-credentials.txt";

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                // Write headers
                writer.WriteLine("UserId,Username,Password,FirstName,LastName");

                // Write all user data in GlobalData
                foreach (UserData userData in GlobalData.UserData)
                {
                    string line = $"{userData.UserId},{userData.Username},{userData.Password},{userData.FirstName},{userData.LastName}";
                    writer.WriteLine(line);
                }
            }
        }

        /* BOOKING DETAILS HANDLING */
        public static void LoadBookings(bool skipHeaders = true)
        {
            string filePath = "bookings.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                if (skipHeaders && lines.Length > 0)
                {
                    lines = lines.Skip(1).ToArray(); // Skip the headers
                }

                foreach (var line in lines)
                {
                    var parts = line.Split(','); // Split the line into parts based on the delimiter (',')

                    if (parts.Length == 8) // Update the length to match the new format
                    {
                        if (int.TryParse(parts[0], out int bookingID) &&
                            int.TryParse(parts[1], out int movieID) &&
                            DateTime.TryParse(parts[2], out DateTime session) &&
                            int.TryParse(parts[3], out int numOfTickets) &&
                            double.TryParse(parts[5], out double subtotal)) // Parse the new subtotal field
                        {
                            string seatsBooked = parts[4];
                            string ticketType = parts[6];
                            int userID = int.Parse(parts[7]); // Parse the user ID

                            // Create a Booking object and add it to the GlobalData.Bookings list
                            Booking booking = new Booking(bookingID, movieID, session, numOfTickets, seatsBooked, subtotal, ticketType, userID);
                            GlobalData.Bookings.Add(booking);
                        }
                    }
                }
            }
        }


        public static void SaveBookings()
        {
            string filePath = "bookings.txt";

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                // Write headers
                writer.WriteLine("bookingID,movieID,session,numberOfTickets,seatsBooked,subtotal,ticketType,userID");

                // Write all booking data in GlobalData
                foreach (Booking booking in GlobalData.Bookings)
                {
                    string line = $"{booking.BookingID},{booking.MovieID},{booking.Session.ToString("HH:mm")},{booking.NumOfTickets},{booking.SeatsBooked},{booking.Subtotal:F2},{booking.TicketType},{booking.UserID}";
                    writer.WriteLine(line);
                }
            }
        }

    }
}
