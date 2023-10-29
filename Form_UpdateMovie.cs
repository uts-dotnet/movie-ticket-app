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
    public partial class Form_UpdateMovie : Form
    {
        public Form_UpdateMovie()
        {
            InitializeComponent();
            movieGrid.DataSource = GlobalData.Movies;
        }

        private void Form_UpdateMovie_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            FileManager.SaveMovies();
            Form_AdminView admin = new Form_AdminView();
            admin.Show();
            this.Close();
        }

        private void movieGrid_CelLClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = movieGrid.Rows[index];
            textBox_MovieID.Text = selectedRow.Cells[0].Value.ToString();
            textBox_Title.Text = selectedRow.Cells[1].Value.ToString();
            textBox_Genre.Text = selectedRow.Cells[2].Value.ToString();
            textBox_Hours.Text = selectedRow.Cells[3].Value.ToString();
            textBox_Minutes.Text = selectedRow.Cells[4].Value.ToString();
            textBox_Description.Text = selectedRow.Cells[8].Value.ToString();
            textBox_Poster.Text = selectedRow.Cells[9].Value.ToString();

            int year = int.Parse(selectedRow.Cells[5].Value.ToString());
            int month = int.Parse(selectedRow.Cells[6].Value.ToString());
            int day = int.Parse(selectedRow.Cells[7].Value.ToString());

            DateTime selectedDate = new DateTime(year, month, day);
            dateTimePicker_ReleaseDate.Value = selectedDate;
        }

        private void btn_UpdateMovie_Click(object sender, EventArgs e)
        {
            // Find the movie in the data source (e.g., a list or database)
            Movie movieToUpdate = GlobalData.Movies.FirstOrDefault(movie => movie.Id == int.Parse(textBox_MovieID.Text));

            if (movieToUpdate == null)
            {
                MessageBox.Show("Movie not found.");
                return;
            }

            // Parse and validate the input data
            string title = textBox_Title.Text;
            string genre = textBox_Genre.Text;
            int hours = int.Parse(textBox_Hours.Text);
            int minutes = int.Parse(textBox_Minutes.Text);
            int year = dateTimePicker_ReleaseDate.Value.Year;
            int month = dateTimePicker_ReleaseDate.Value.Month;
            int day = dateTimePicker_ReleaseDate.Value.Day;
            string description = textBox_Description.Text;
            string poster = textBox_Poster.Text;

            DateTime selectedDate = new DateTime(year, month, day);

            if (!ValidateMovieData(title, genre, hours, minutes, selectedDate, description, poster))
            {
                return; // Validation failed, no need to proceed
            }

            // Update movie properties
            movieToUpdate.Title = title;
            movieToUpdate.Genre = genre;
            movieToUpdate.Hours = hours;
            movieToUpdate.Minutes = minutes;
            movieToUpdate.Year = year;
            movieToUpdate.Month = month;
            movieToUpdate.Day = day;
            movieToUpdate.Description = description;
            movieToUpdate.Poster = poster;

            // Update Duration and ReleaseDate
            movieToUpdate.Duration = new Duration(hours, minutes);
            movieToUpdate.ReleaseDate = new DateTime(year, month, day);

            // Refresh the DataGridView to reflect the changes
            movieGrid.Refresh();

            // Notify the user of the successful update
            MessageBox.Show("Movie data updated successfully.");
        }

        // Create a new movie
        private void btn_CreateNewMovie_Click(object sender, EventArgs e)
        {
            // Parse and validate the input data
            string title = textBox_Title.Text;
            string genre = textBox_Genre.Text;
            int hours = int.Parse(textBox_Hours.Text);
            int minutes = int.Parse(textBox_Minutes.Text);
            int year = dateTimePicker_ReleaseDate.Value.Year;
            int month = dateTimePicker_ReleaseDate.Value.Month;
            int day = dateTimePicker_ReleaseDate.Value.Day;
            string description = textBox_Description.Text;
            string poster = textBox_Poster.Text;

            DateTime selectedDate = new DateTime(year, month, day);

            if (!ValidateMovieData(title, genre, hours, minutes, selectedDate, description, poster))
            {
                return; // Validation failed, no need to proceed
            }

            // Create a new movie
            Movie.CreateNewMovie(title, genre, hours, minutes, year, month, day, description, poster);

            // Rebind data because refresh does not work
            movieGrid.DataSource = null; // Unbind the data source
            movieGrid.DataSource = GlobalData.Movies; // Rebind to the data source

            // Notify the user of the successful creation
            MessageBox.Show("Movie added successfully.");
        }

        // Delete a movie
        private void btn_DeleteMovie_Click(object sender, EventArgs e)
        {
            // Find the movie in the data source (e.g., a list or database)
            Movie movieToDelete = GlobalData.Movies.FirstOrDefault(movie => movie.Id == int.Parse(textBox_MovieID.Text));

            if (movieToDelete == null)
            {
                MessageBox.Show("Movie not found.");
                return;
            }

            // Check if there are associated sessions
            bool hasAssociatedSessions = movieToDelete.Sessions.Count > 0;

            if (hasAssociatedSessions)
            {
                MessageBox.Show("This movie has associated sessions and cannot be deleted until the sessions are resolved.", "Movie Deletion Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Movie deletion is restricted
            }

            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User confirmed deletion
                // Delete the movie from the data source
                GlobalData.Movies.Remove(movieToDelete);

                // Rebind data because refresh does not work
                movieGrid.DataSource = null; // Unbind the data source
                movieGrid.DataSource = GlobalData.Movies; // Rebind to the data source

                // Notify the user of the successful deletion
                MessageBox.Show("Movie deleted successfully.");
            }
            else
            {
                // User chose not to delete the movie (do nothing)
            }
        }



        private bool ValidateMovieData(string title, string genre, int hours, int minutes, DateTime releaseDate, string description, string poster)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(genre) || hours < 0 || hours >= 10 || minutes < 0 || minutes >= 60 || releaseDate == DateTime.MinValue)
            {
                MessageBox.Show("Please fill out all required fields and ensure the movie duration is valid.");
                return false;
            }

            string[] allowedExtensions = { ".png", ".jpg" };
            string fileExtension = Path.GetExtension(poster);

            if (string.IsNullOrWhiteSpace(poster) || !allowedExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please provide a valid poster file with a .png or .jpg extension.");
                return false;
            }

            // Check for duplicate movies
            bool isDuplicateMovie = GlobalData.Movies.Any(movie => movie.Title == title);

            if (isDuplicateMovie)
            {
                MessageBox.Show("Movie with the same title already exists.");
                return false;
            }

            return true;
        }


    }
}
