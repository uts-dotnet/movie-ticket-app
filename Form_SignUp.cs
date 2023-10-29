using System;
using System.Diagnostics;
using System.Linq;


namespace MovieTicketApp
{
    public partial class Form_SignUp : Form
    {
        private string loginCredentialsFile = ".\\login-credentials.txt";
        private string email = "";
        private string password = "";
        private string firstName = "";
        private string lastName = "";

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // if the form is not closed it'll cause a conflict between Visual Studio and the executable file
        }

        private void SaveCredentialsToFile()
        {
            try
            {
                int newUserId;

                string[] lines = File.ReadAllLines(loginCredentialsFile);

                if (lines.Length > 0)
                {
                    string[] lastLineData = lines[lines.Length - 1].Split(',');
                    int lastUserId = Convert.ToInt32(lastLineData[0]);
                    newUserId = lastUserId + 1;
                }
                else
                {
                    newUserId = 10001;
                }

                string newUserLine = $"{newUserId},{email},{password},{firstName},{lastName}" + Environment.NewLine;
                File.AppendAllText(loginCredentialsFile, newUserLine);
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txt_Email, txt_Password, txt_FirstName, txt_LastName };

            // Only save credentials if all input fields are filled in and not blank
            if (textBoxes.All(txt => !string.IsNullOrWhiteSpace(txt.Text)))
            {
                email = txt_Email.Text;
                password = txt_Password.Text;
                firstName = txt_FirstName.Text;
                lastName = txt_LastName.Text;

                SaveCredentialsToFile();
                MessageBox.Show("Sign up successfull!");

                Form_Login login = new Form_Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void lbl_LogIn_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login();
            loginForm.Show();
            this.Hide();
        }

    }
}
