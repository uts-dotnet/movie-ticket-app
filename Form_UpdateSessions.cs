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
using static System.Collections.Specialized.BitVector32;

namespace MovieTicketApp
{
    public partial class Form_UpdateSessions : Form
    {
        public Form_UpdateSessions()
        {
            InitializeComponent();
            sessionGrid.DataSource = GlobalData.Sessions;

            dateTimePicker_SessionTime.Format = DateTimePickerFormat.Custom;
            dateTimePicker_SessionTime.CustomFormat = "hh:mm tt";
            dateTimePicker_SessionTime.ShowUpDown = true;

        }

        private void sessionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = sessionGrid.Rows[index];

            if (selectedRow != null)
            {
                textBox_MovieID.Text = selectedRow.Cells[0].Value.ToString();

                // Retrieve the DateTime value from the DataGridView cell
                if (DateTime.TryParse(selectedRow.Cells[1].Value.ToString(), out DateTime sessionTime))
                {
                    dateTimePicker_SessionTime.Value = sessionTime;
                }

                // Use the Value property of numericUpDown_seats
                int availableSeats = (int)numericUpDown_seats.Value;

                numericUpDown_seats.Value = (int)selectedRow.Cells[2].Value;
            }
        }

        private void sessionGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column you want to format is the Time column (replace with the actual column index)
            if (e.ColumnIndex == 1)
            {
                if (e.Value is DateTime dateTimeValue)
                {
                    // Format the DateTime as just the time without seconds
                    e.Value = dateTimeValue.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_CreateNewSession_Click(object sender, EventArgs e)
        {
            if (!ValidateSessionData())
            {
                return; // Validation failed, no need to proceed
            }

            int movieID = int.Parse(textBox_MovieID.Text);
            DateTime sessionTime = dateTimePicker_SessionTime.Value;
            int availableSeats = (int)numericUpDown_seats.Value; // Use the NumericUpDown control

            // Check if there's already a session with the same movie and time
            bool sessionExists = GlobalData.Sessions.Any(session =>
                session.MovieID == movieID && session.Time == sessionTime);

            if (sessionExists)
            {
                MessageBox.Show("A session with the same movie and time already exists.");
                return;
            }

            // Create the new session
            MovieSession newSession = new MovieSession(movieID, sessionTime, availableSeats);
            GlobalData.Sessions.Add(newSession);

            // Refresh the DataGridView to reflect the changes
            sessionGrid.DataSource = null;
            sessionGrid.DataSource = GlobalData.Sessions;
            sessionGrid.Refresh();

            // Notify the user of the successful creation
            MessageBox.Show("Session added successfully.");
        }

        private void btn_UpdateSession_Click(object sender, EventArgs e)
        {
            if (!ValidateSessionData())
            {
                return; // Validation failed, no need to proceed
            }

            // Find the session in the data source (e.g., a list or database)
            // Note: You may need to replace "Session" with the appropriate session class name
            MovieSession? sessionToUpdate = GlobalData.Sessions.FirstOrDefault(session =>
                session.MovieID == int.Parse(textBox_MovieID.Text) && session.Time == dateTimePicker_SessionTime.Value);

            if (sessionToUpdate == null)
            {
                MessageBox.Show("Session not found.");
                return;
            }

            // Update session properties
            sessionToUpdate.AvailableSeats = (int)numericUpDown_seats.Value;

            // Refresh the DataGridView to reflect the changes
            sessionGrid.DataSource = null;
            sessionGrid.DataSource = GlobalData.Sessions;
            sessionGrid.Refresh();

            // Notify the user of the successful update
            MessageBox.Show("Session data updated successfully.");
        }


        private void btn_DeleteSession_Click(object sender, EventArgs e)
        {
            int movieIDToDelete = int.Parse(textBox_MovieID.Text);
            DateTime sessionTimeToDelete = dateTimePicker_SessionTime.Value;

            // Find the index of the session to delete using FindIndex method
            int sessionIndexToDelete = GlobalData.Sessions.FindIndex(session =>
                session.MovieID == movieIDToDelete && session.Time == sessionTimeToDelete);

            if (sessionIndexToDelete == -1)
            {
                MessageBox.Show("Session not found.");
                return;
            }

            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to delete this session?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Session confirmed for deletion
                // Delete the session from the data source
                GlobalData.Sessions.RemoveAt(sessionIndexToDelete);

                // Refresh the DataGridView to reflect the changes
                sessionGrid.DataSource = null;
                sessionGrid.DataSource = GlobalData.Sessions;
                sessionGrid.Refresh();

                // Notify the user of the successful deletion
                MessageBox.Show("Session deleted successfully.");
            }
        }



        private bool ValidateSessionData()
        {
            int movieID;
            if (!int.TryParse(textBox_MovieID.Text, out movieID))
            {
                MessageBox.Show("Movie ID must be a valid integer.");
                return false;
            }

            int availableSeats = (int)numericUpDown_seats.Value;
            if (availableSeats < 0 || availableSeats > 20) // Assuming a range of 1 to 20 seats
            {
                MessageBox.Show("Available seats must be between 0 and 20.");
                return false;
            }

            return true; // Data is valid
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            FileManager.SaveSessions();
            Form_AdminView form = new Form_AdminView();
            form.Show();
            this.Hide();
        }
    }
}
