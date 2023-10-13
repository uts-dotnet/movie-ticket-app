using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    string[] data = lines[i].Split(",");

                    int id = Convert.ToInt32(data[0]);
                    string title = data[1];
                    string genre = data[2];
                    int hours = Convert.ToInt32(data[3]);
                    int minutes = Convert.ToInt32(data[4]);
                    string posterPath = data[5];

                    Duration duration = new Duration(hours, minutes);
                    Movie movie = new Movie(id, title, genre, duration, posterPath);

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
                Movie selectedMovie = (Movie)listbox_Movies.SelectedItem;
                string moviePosterPath = selectedMovie.PosterPath;
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, moviePosterPath);

                try
                {
                    picbox_Movie_Poster.Image = Image.FromFile(fullPath);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine("POSTER PATH: " + moviePosterPath);
                    Debug.WriteLine("FULL PATH " + fullPath);
                }
            }
        }
    }
}
