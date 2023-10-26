using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MovieTicketApp
{
    public partial class frm_Movies : Form
    {
        private string _moviesFilePath = ".\\movies.txt";

        List<Movie> movies;

        public frm_Movies()
        {
            InitializeComponent();

            movies = LoadMovies(_moviesFilePath);

            // this string needs to match the name of a Movie field (i.e. Title, Genre, etc)
            listbox_Movies.DisplayMember = "Title";
            listbox_Movies.DataSource = movies;
        }

        public void frm_Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public List<Movie> LoadMovies(string filepath)
        {
            List<Movie> movies = new List<Movie>();

            try
            {
                string[] lines = File.ReadAllLines(filepath);

                for (int i = 1; i < lines.Length; i++)
                {
                    /*
                     * This regex splits a string by a comma but ignores commas enclosed in " ".
                     * This is needed for movie descriptions that have comma.
                     * 
                     * Reference: Rohit Jain. (2013, September 19). Comment on "Splitting on comma outside quotes." Stack Overflow. https://stackoverflow.com/questions/18893390/splitting-on-comma-outside-quotes
                     */
                    string regex = ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
                    string[] data = Regex.Split(lines[i], regex);


                    int id = Convert.ToInt32(data[0]);
                    string title = data[1];
                    string genre = data[2];
                    int hours = Convert.ToInt32(data[3]);
                    int minutes = Convert.ToInt32(data[4]);
                    int year = Convert.ToInt32(data[5]);
                    int month = Convert.ToInt32(data[6]);
                    int day = Convert.ToInt32(data[7]);
                    string description = data[8].Trim('"'); // remove the double quotes from the description
                    string poster = data[9];

                    Duration duration = new Duration(hours, minutes);
                    DateTime releasedate = new DateTime(year, month, day);
                    Movie movie = new Movie(id, title, genre, duration, releasedate, description, poster);

                    movies.Add(movie);
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
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
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form_UserProfile userProfile = new Form_UserProfile();
            userProfile.Show();
            this.Hide();
        }
    }
}
