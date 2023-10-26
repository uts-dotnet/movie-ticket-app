using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class Form_UserProfile : Form
    {

        string[] dataArray = { "Button 1", "Button 2", "Button 3", "Button 4", "Button 5" };


        public Form_UserProfile()
        {

            foreach (string item in dataArray)
            {
                Button button = new Button
                {
                    Text = item,
                    Width = 100, // Set the width as per your preference
                    Height = 30   // Set the height as per your preference
                };

                button.Click += Button_Click; // Add a click event handler for each butt
                //panel_MovieButtons.Controls.Add(button); // Add the button to the FlowLayoutPanel
            }

            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //Add code to open the movie ticket view here!

            // Handle the button click event here
            // You can access the button's Text property to identify which button was clicked
            Button clickedButton = (Button)sender;
            MessageBox.Show("You clicked: " + clickedButton.Text);
        }


        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            frm_ChangePassword changePasswordForm = new frm_ChangePassword();
            changePasswordForm.Show();
            this.Hide();
        }

        private void Form_UserProfile_Load(object sender, EventArgs e)
        {
            // Populate listBox1 when the form loads
            PopulateListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when an item in listBox1 is selected
            string selectedBooking = listBox1.SelectedItem as string;

            if (selectedBooking != null)
            {
                // You can perform some action based on the selected booking here
                MessageBox.Show("You selected: " + selectedBooking);
            }
        }

        private void PopulateListBox()
        {
            string filePath = "bookings.txt"; // Replace with the actual file path

            if (File.Exists(filePath))
            {
                // Read the file's content line by line and add it to listBox1
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        private void btn_ChangePW_Click(object sender, EventArgs e)
        {

        }
    }
}
