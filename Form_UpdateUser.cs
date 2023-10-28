using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MovieTicketApp.src.Managers;
using MovieTicketApp.src.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieTicketApp
{
    public partial class Form_UpdateUser : Form
    {
        public Form_UpdateUser()
        {
            InitializeComponent();
            userGrid.DataSource = GlobalData.UserData;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form_AdminView admin = new Form_AdminView();
            admin.Show();
            this.Close();
        }

        private void userGrid_CelLClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = userGrid.Rows[index];
            textBox_UserId.Text = selectedRow.Cells[0].Value.ToString();
            textBox_Username.Text = selectedRow.Cells[1].Value.ToString();
            textBox_Password.Text = selectedRow.Cells[2].Value.ToString();
            textBox_firstName.Text = selectedRow.Cells[3].Value.ToString();
            textBox_lastName.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void btn_UpdateData_Click(object sender, EventArgs e)
        {
            if (!ValidateUserData(int.Parse(textBox_UserId.Text), textBox_Username.Text, textBox_Password.Text, textBox_firstName.Text, textBox_lastName.Text))
            {
                return; // Validation failed, no need to proceed
            }

            // Find the user in the data source (e.g., a list or database)
            UserData? userToUpdate = GlobalData.UserData.FirstOrDefault(user => user.UserId == int.Parse(textBox_UserId.Text));

            if (userToUpdate == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            // Update user properties
            userToUpdate.Username = textBox_Username.Text;
            userToUpdate.Password = textBox_Password.Text;
            userToUpdate.FirstName = textBox_firstName.Text;
            userToUpdate.LastName = textBox_lastName.Text;

            // Refresh the DataGridView to reflect the changes
            userGrid.Refresh();

            // Notify the user of the successful update
            MessageBox.Show("User data updated successfully.");
        }

        private void btn_CreateNewUser_Click(object sender, EventArgs e)
        {
            if (!ValidateUserData(int.Parse(textBox_UserId.Text), textBox_Username.Text, textBox_Password.Text, textBox_firstName.Text, textBox_lastName.Text))
            {
                return; // Validation failed, no need to proceed
            }

            UserData.CreateNewUser(textBox_Username.Text, textBox_Password.Text, textBox_firstName.Text, textBox_lastName.Text);


            // Rebind data because refresh does not work
            userGrid.DataSource = null; // Unbind the data source
            userGrid.DataSource = GlobalData.UserData; // Rebind to the data source


            // Notify the user of the successful update
            MessageBox.Show("User added successfully.");




        }

        private bool ValidateUserData(int userId, string username, string password, string firstName, string lastName)
        {
            // Check if all fields are filled out
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("All fields must be filled out.");
                return false;
            }

            // Check if the UserID is a valid 5-character integer
            if (!int.TryParse(userId.ToString(), out int _userId) || userId.ToString().Length != 5)
            {
                MessageBox.Show("UserID must be a valid 5-character integer.");
                return false;
            }

            // Check if the password is at least 4 characters long
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.");
                return false;
            }

            return true; // Data is valid
        }
    }
}
