using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieTicketApp.src.User;

namespace MovieTicketApp
{
    public partial class Form_CreateNewUser : Form
    {
        public Form_CreateNewUser()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string firstName = textBox_firstName.Text;
            string lastName = textBox_lastName.Text;
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string confirmPassword = textBox_confirmPW.Text;
            string username = textBox_username.Text;

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.");
                return; // Exit the method
            }

            // Validate password length and matching passwords
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.");
                return; // Exit the method
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
                return; // Exit the method
            }

            //If all validations pass, proceed with saving data
            Debug.WriteLine("Validations passed.");

            UserData.CreateNewUser(username, password, firstName, lastName);

            Form_AdminView form = new Form_AdminView();
            form.Show();
            MessageBox.Show("User created successfully.");
            this.Hide();

        }

        // Function to validate email format using regular expression
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form_AdminView form = new Form_AdminView();
            form.Show();
            this.Hide();
        }
    }
}
