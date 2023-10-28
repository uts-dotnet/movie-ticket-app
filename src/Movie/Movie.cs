using MovieTicketApp.src.Managers;
using MovieTicketApp;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public string Description { get; set; }
    public string Poster { get; set; }

    public Duration Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<MovieSession> Sessions { get; set; }

    public Movie()
    {
        // Initialize properties in the parameterless constructor
        Duration = new Duration();
        ReleaseDate = DateTime.MinValue;
        Sessions = new List<MovieSession>();
    }

    public Movie(int movieID, string title, string genre, int hours, int minutes, int year, int month, int day, string description, string poster)
    {
        Id = movieID;
        Title = title;
        Genre = genre;
        Hours = hours;
        Minutes = minutes;
        Year = year;
        Month = month;
        Day = day;
        Description = description;
        Poster = poster;

        Duration = new Duration(Hours, Minutes);
        ReleaseDate = new DateTime(Year, Month, Day);
        Sessions = new List<MovieSession>();
    }

    // Must use this method to create movies or else it won't increment ID or add to global
    public static Movie CreateNewMovie(int movieId, string title, string genre, int hours, int minutes, int year, int month, int day, string description, string poster)
    {
        int newMovieId = GenerateNewMovieId();
        Movie movie = new Movie(newMovieId, title, genre, hours, minutes, year, month, day, description, poster);
        GlobalData.Movies.Add(movie);
        return movie;
    }

    private static int GenerateNewMovieId()
    {
        int maxId = GlobalData.Movies.Max(m => m.Id);
        return maxId + 1;
    }

    public void AddSession(int movieID, DateTime date, int availableSeats)
    {
        MovieSession session = new MovieSession(movieID, date, availableSeats);
        GlobalData.Sessions.Add(session);
    }

    public override string ToString()
    {
        return $"Movie: {this.Title}, Genre: {this.Genre}, Duration: {this.Hours}:{this.Minutes}, Description: {this.Description}";
    }
}
