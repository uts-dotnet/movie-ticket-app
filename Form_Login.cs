using System;
using System.Diagnostics;

namespace MovieTicketApp
{
    public partial class frm_Login : Form
    {
        string _loginFile = ".\\login-credentials.txt";
        string _usersFile = ".\\users.txt";

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // if the form is not closed it'll cause a conflict between Visual Studio and the executable file
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string enteredUsername = txt_Username.Text.Trim();
            string enteredPassword = txt_Password.Text.Trim();

            if (ValidateCredentials(enteredUsername, enteredPassword))
            {
                //MessageBox.Show("Login Successful!");
                Form_Movies frm_Movies = new Form_Movies();
                frm_Movies.Show();
                this.Hide();
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
                string[] lines = File.ReadAllLines(_loginFile);

                foreach (string line in lines)
                {
                    string[] data = line.Split(",");

                    int storedId = Convert.ToInt32(data[0]);
                    string storedUsername = data[1];
                    string storedPassword = data[2];
                    string storedFirstName = data[3];
                    string storedLastName = data[4];
                    string storedEmail = data[5];

                    if (storedUsername == username && storedPassword == password)
                    {
                        User user = new User(storedId, storedFirstName, storedLastName, storedEmail);
                        SaveUserToFile(user);
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

        private void SaveUserToFile(User user)
        {
            // setting StreamWriter to true appends a new line instead of overwritting existing lines
            using (StreamWriter writer = new StreamWriter(_usersFile, true))
            {
                writer.WriteLine($"{user.Id},{user.FirstName},{user.LastName},{user.Email}");
            }
        }

        private void lbl_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp signUpForm = new frm_SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}