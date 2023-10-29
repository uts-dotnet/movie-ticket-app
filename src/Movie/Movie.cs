using MovieTicketApp;
using Microsoft.VisualBasic.Devices;

// Class representing a movie and its details
public class Movie
{
    public int Id { get; set; }       // Unique identifier for the movie
    public string Title { get; set; }  // Title of the movie
    public string Genre { get; set; }  // Genre of the movie
    public int Hours { get; set; }     // Duration in hours
    public int Minutes { get; set; }   // Duration in minutes
    public int Year { get; set; }      // Release year
    public int Month { get; set; }     // Release month
    public int Day { get; set; }       // Release day
    public string Description { get; set; } // Movie description
    public string Poster { get; set; }     // File path to the movie poster

    public Duration Duration { get; set; }     // Represents movie duration
    public DateTime ReleaseDate { get; set; }  // Release date
    public List<MovieSession> Sessions = new List<MovieSession>(); // List of sessions for this movie

    // Constructor to initialize a movie object with provided details
    public Movie(int movieID, string title, string genre, int hours, int minutes, int year, int month, int day, string description, string poster)
    {
        this.Id = movieID;
        this.Title = title;
        this.Genre = genre;
        this.Hours = hours;
        this.Minutes = minutes;
        this.Year = year;
        this.Month = month;
        this.Day = day;
        this.Description = description;
        this.Poster = poster;

        this.Duration = new Duration(Hours, Minutes);
        this.ReleaseDate = new DateTime(Year, Month, Day);
        LoadSessionsFromFile("sessions.txt");
    }

    // Method to create a new movie instance and add it to the global list
    public static Movie CreateNewMovie(string title, string genre, int hours, int minutes, int year, int month, int day, string description, string poster)
    {
        int newMovieId = GenerateNewMovieId();
        Movie movie = new Movie(newMovieId, title, genre, hours, minutes, year, month, day, description, poster);
        GlobalData.Movies.Add(movie);
        return movie;
    }

    // Generate a new unique movie ID based on existing IDs
    private static int GenerateNewMovieId()
    {
        int maxId = GlobalData.Movies.Max(m => m.Id);
        return maxId + 1;
    }

    // Method to load sessions from a file and populate the Sessions property
    public void LoadSessionsFromFile(string sessionsFilePath)
    {
        if (File.Exists(sessionsFilePath))
        {
            string[] sessionLines = File.ReadAllLines(sessionsFilePath);

            foreach (string line in sessionLines)
            {
                string[] parts = line.Split(','); // Split the line into parts based on the delimiter (',')

                if (parts.Length == 3)
                {
                    // Assuming the format is "movieId,sessionTime,availableSeats"
                    if (int.TryParse(parts[0], out int movieId) &&
                        DateTime.TryParse(parts[1], out DateTime sessionTime) &&
                        int.TryParse(parts[2], out int availableSeats))
                    {
                        // Check if this session belongs to the current movie
                        if (movieId == this.Id)
                        {
                            // Create a MovieSession object and add it to the Sessions list
                            AddSession(movieId, sessionTime, availableSeats);
                        }
                    }
                }
            }
        }
    }

    // Method to add a new session to the Sessions list
    public void AddSession(int movieID, DateTime date, int availableSeats)
    {
        MovieSession session = new MovieSession(movieID, date, availableSeats);
        this.Sessions.Add(session);
    }

    // Override the ToString method to provide a user-friendly string representation
    public override string ToString()
    {
        return $"Movie: {this.Title}, Genre: {this.Genre}, Duration: {this.Hours}:{this.Minutes}, Description: {this.Description}";
    }
}
