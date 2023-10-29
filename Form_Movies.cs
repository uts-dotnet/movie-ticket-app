using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using MovieTicketApp.src.Managers;

namespace MovieTicketApp
{
    public partial class Form_Movies : Form
    {
        private string _moviesFile = ".\\movies.txt";
        private string _sessionsFile = ".\\sessions.txt";

        List<Movie> movies = GlobalData.Movies;

        public Form_Movies()
        {
            InitializeComponent();

            //movies = LoadMovies(_moviesFile, _sessionsFile);
            // this string needs to match the name of a Movie field (i.e. Title, Genre, etc)
            listbox_Movies.DisplayMember = "Title";
            listbox_Movies.DataSource = movies;
        }

        public void Form_Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
                Form_Ticket_Selection sessionForm = new Form_Ticket_Selection(selectedMovie, selectedSession);
                sessionForm.Show();
                this.Hide();
            }
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            FileManager.Save();
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }

        private void btn_UserProfile_Click(object sender, EventArgs e)
        {

        }

        private void btn_UserProfile_Click_1(object sender, EventArgs e)
        {
            Form_UserProfile profile = new Form_UserProfile();
            profile.Show();
            this.Close();
        }


        //For testing only
        private void btn_TestDisplayGlobalData_Click(object sender, EventArgs e)
        {
            // Display all Movies
            string allData = "All Movies:\n";
            foreach (var movie in GlobalData.Movies)
            {
                allData += $"Movie ID: {movie.Id}, Title: {movie.Title}\n";
            }

            // Display all Bookings
            allData += "\nAll Bookings:\n";
            foreach (var booking in GlobalData.Bookings)
            {
                allData += $"Booking ID: {booking.BookingID}, Movie ID: {booking.MovieID}\n";
            }

            // Display all Sessions
            allData += "\nAll Sessions:\n";
            foreach (var session in GlobalData.Sessions)
            {
                allData += $"Movie ID: {session.MovieID}\n";
            }

            // Display all the data in a MessageBox
            MessageBox.Show(allData, "All Data");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
