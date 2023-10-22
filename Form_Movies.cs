using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MovieTicketApp
{
    public partial class Form_Movies : Form
    {
        private string _moviesFile = ".\\movies.txt";
        private string _sessionsFile = ".\\sessions.txt";

        List<Movie> movies;

        public Form_Movies()
        {
            InitializeComponent();

            movies = LoadMovies(_moviesFile, _sessionsFile);

            // this string needs to match the name of a Movie field (i.e. Title, Genre, etc)
            listbox_Movies.DisplayMember = "Title";
            listbox_Movies.DataSource = movies;
        }

        public void Form_Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public List<Movie> LoadMovies(string moviesPath, string sessionsPath)
        {
            List<Movie> movies = new List<Movie>();

            try
            {
                string[] movieLines = File.ReadAllLines(moviesPath);
                string[] sessionLines = File.ReadAllLines(sessionsPath);

                for (int i = 1; i < movieLines.Length; i++)
                {
                    /*
                     * This regex splits a string by a comma but ignores commas enclosed in " ".
                     * This is needed for movie descriptions that have comma.
                     * 
                     * Reference: Rohit Jain. (2013, September 19). Comment on "Splitting on comma outside quotes." Stack Overflow. https://stackoverflow.com/questions/18893390/splitting-on-comma-outside-quotes
                     */
                    string regex = ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
                    string[] movieData = Regex.Split(movieLines[i], regex);
                    int movieId = Convert.ToInt32(movieData[0]);

                    string sessions = sessionLines.FirstOrDefault(line => line.StartsWith(movieId.ToString()));

                    try
                    {
                        string[] sessionData = sessions.Split(',');
                        int availableSeats = Convert.ToInt32(sessionData[sessionData.Length - 1]); // get the available seats (last item)

                        string title = movieData[1];
                        string genre = movieData[2];
                        int hours = Convert.ToInt32(movieData[3]);
                        int minutes = Convert.ToInt32(movieData[4]);
                        int year = Convert.ToInt32(movieData[5]);
                        int month = Convert.ToInt32(movieData[6]);
                        int day = Convert.ToInt32(movieData[7]);
                        string description = movieData[8].Trim('"'); // remove the double quotes from the description
                        string poster = movieData[9];

                        Duration duration = new Duration(hours, minutes);
                        DateTime releasedate = new DateTime(year, month, day);
                        Movie movie = new Movie(movieId, title, genre, duration, releasedate, description, poster);

                        for (int j = 1; j < sessionData.Length - 1; j++) // Start at index 1 to skip the movie ID and last time (available seats)
                        {
                            DateTime sessionTime = DateTime.ParseExact(sessionData[j], "HH:mm", CultureInfo.InvariantCulture);
                            movie.AddSession(sessionTime, availableSeats);
                        }

                        movies.Add(movie);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }

            return movies;
        }

        private void listbox_Movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_Movies.SelectedIndex >= 0)
            {
                // need to cast the list item into a Movie object in order access its properties
                Movie selectedMovie = (Movie)listbox_Movies.SelectedItem;

                lbl_Movie_Title.Text = selectedMovie.Title;
                lbl_Movie_Duration_Genre.Text = $"{selectedMovie.Duration}, {selectedMovie.Genre}";
                lbl_Movie_Release_Date.Text = $"Released on {selectedMovie.ReleaseDate.ToString("dd MMM yyyy")}";
                txt_Movie_Description.Text = selectedMovie.Description;

                string moviePoster = selectedMovie.Poster;

                try
                {
                    picbox_Movie_Poster.Image = Image.FromFile(moviePoster);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                }

                Button[] sessionBtns = new Button[]
                {
                    btn_Session_Time_1,
                    btn_Session_Time_2,
                    btn_Session_Time_3,
                    btn_Session_Time_4,
                    btn_Session_Time_5,
                };

                int x = 266; // x position of the first button (it increments in the for loop)
                int y = 381; // y position of all the buttons (it doesn't increment in the for loop)

                for (int i = 0; i < selectedMovie.Sessions.Count && i < sessionBtns.Length; i++)
                {
                    sessionBtns[i].Text = selectedMovie.Sessions[i].Time.ToString("HH:mm");
                    sessionBtns[i].Tag = selectedMovie.Sessions[i];
                    sessionBtns[i].Cursor = Cursors.Hand;

                    sessionBtns[i].Location = new Point(x, y);
                    x += 106; // increase the x position of each subsequent button by 106px

                    sessionBtns[i].Click += SessionButton_Click;
                }
            }
        }

        private void SessionButton_Click(object? sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)listbox_Movies.SelectedItem;

            if (sender is Button button && button.Tag is MovieSession selectedSession)
            {
                Form_Ticket_Booking sessionForm = new Form_Ticket_Booking(selectedMovie, selectedSession);
                sessionForm.Show();
                this.Hide();
            }
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }
    }
}
