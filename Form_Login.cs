using System;
using System.Diagnostics;

namespace MovieTicketApp
{
    public partial class frm_Login : Form
    {
        string _loginFilePath = ".\\login-credentials.txt";

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string enteredUsername = txt_Username.Text;
            string enteredPassword = txt_Password.Text;

            if (ValidateCredentials(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            try
            {
                string[] lines = File.ReadAllLines(_loginFilePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split(",");

                    string storedUsername = data[1];
                    string storedPassword = data[2];

                    if (storedUsername == username && storedPassword == password)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(Directory.GetCurrentDirectory());
                return false;
            }
        }

        private void lbl_SignUp_Click(object sender, EventArgs e)
        {

        }
    }
}