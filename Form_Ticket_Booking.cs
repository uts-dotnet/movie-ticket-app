using System;
using System.Diagnostics;
using System.Globalization;

namespace MovieTicketApp
{
    public partial class Form_Ticket_Booking : Form
    {
        private string _ticketInfoFile = ".\\ticket-info.txt";
        public TicketInfo TicketInfo { get; private set; }

        public Form_Ticket_Booking(Movie selectedMovie, MovieSession selectedSession)
        {
            InitializeComponent();

            TicketInfo = new TicketInfo(selectedMovie, selectedSession, 0, 0, 0);

            this.TicketInfo.TicketSelected = string.Empty;

            lbl_Movie_Title.Text = TicketInfo.SelectedMovie.Title;
            lbl_Session_Time_Fomatted.Text = TicketInfo.SelectedSession.Time.ToString("HH:mm");

            LoadListView();
            PopulateListView();

            EnableQuantityButtons(false);
            EnableContinueButton(false);
        }

        public void Form_Movie_Session_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LoadListView()
        {
            listView_Session_Tickets.View = View.Details;
            listView_Session_Tickets.Columns.Add("Ticket Type", 150);
            listView_Session_Tickets.Columns.Add("Price", 100);
        }

        private void PopulateListView()
        {
            Dictionary<string, double> ticketTypes = new Dictionary<string, double>()
            {
                { "Adult", 22.05 },
                { "Child", 17.55 },
                { "Student", 19.35 },
                { "Concession", 19.35 },
            };

            foreach (var ticketType in ticketTypes)
            {
                ListViewItem item = new ListViewItem(ticketType.Key);
                item.SubItems.Add(ticketType.Value.ToString("C")); // "C" formats the string into a currency value, including the $ sign
                listView_Session_Tickets.Items.Add(item);
            }
        }

        private void listView_Session_Tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableQuantityButtons(true);
            EnableContinueButton(true);

            if (listView_Session_Tickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_Session_Tickets.SelectedItems[0];
                lbl_Ticket_Selected.Text = $"{selectedItem.Text} Ticket";
                this.TicketInfo.TicketSelected = lbl_Ticket_Selected.Text;

                string priceString = selectedItem.SubItems[1].Text;

                this.TicketInfo.Price = double.Parse(priceString, NumberStyles.Currency);
                this.TicketInfo.SubTotal = this.TicketInfo.Price;

                lbl_Ticket_Price_Value.Text = this.TicketInfo.Price.ToString("C");
                lbl_Sub_Total_Value.Text = this.TicketInfo.Price.ToString("C");
                lbl_Quantity_Value.Text = "1";

                this.TicketInfo.Quantity = Convert.ToInt32(lbl_Quantity_Value.Text);
            }

            if (listView_Session_Tickets.SelectedItems.Count == 0)
            {
                ResetTicketDetails();
            }
        }

        private void ResetTicketDetails()
        {
            lbl_Ticket_Selected.Text = "Ticket Not Selected";
            lbl_Ticket_Price_Value.Text = "$00.00";
            lbl_Quantity_Value.Text = "0";
            lbl_Sub_Total_Value.Text = "$00.00";
            EnableQuantityButtons(false);
            EnableContinueButton(false);
        }

        private void EnableQuantityButtons(bool value)
        {
            btn_Increment.Enabled = value;
            btn_Decrement.Enabled = value;
        }

        private void EnableContinueButton(bool value)
        {
            bool isEnabled = btn_Continue.Enabled = value;

            if (isEnabled)
            {
                btn_Continue.BackColor = Color.Firebrick;
                btn_Continue.ForeColor = Color.White;

            }
            else
            {
                btn_Continue.BackColor = Color.White;
                btn_Continue.ForeColor = Color.Gray;
            }
        }

        private void btn_Increment_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(lbl_Quantity_Value.Text);
            this.TicketInfo.Price = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            this.TicketInfo.SubTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (quantity < 10)
            {
                quantity++;
                TicketInfo.SubTotal += TicketInfo.Price;
                lbl_Sub_Total_Value.Text = TicketInfo.SubTotal.ToString("C");

                EnableContinueButton(true);

                this.TicketInfo.Quantity = quantity;
            }
            else
            {
                MessageBox.Show($"You can only purchase 10 {lbl_Ticket_Selected.Text} tickets");
            }

            lbl_Quantity_Value.Text = quantity.ToString();
        }

        private void btn_Decrement_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(lbl_Quantity_Value.Text);
            this.TicketInfo.Price = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            this.TicketInfo.SubTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (quantity > 0)
            {
                quantity--;

                this.TicketInfo.SubTotal -= this.TicketInfo.Price;
                lbl_Sub_Total_Value.Text = $"{this.TicketInfo.SubTotal:C}";
                lbl_Quantity_Value.Text = quantity.ToString();

                if (quantity == 0)
                    EnableContinueButton(false);

                this.TicketInfo.Quantity = quantity;
            }
        }

        private void SaveTicketToFile()
        {
            User currentUser = CurrentUserManager.Instance.CurrentUser;

            if (currentUser != null)
            {
                int newTicketId;

                try
                {
                    string[] lines = File.ReadAllLines(_ticketInfoFile);

                    if (lines.Length > 0 && !string.IsNullOrEmpty(lines[0]))
                    {
                        string lastLine = lines[lines.Length - 1];
                        string[] lastLineData = lastLine.Split(',');

                        if (lastLineData.Length > 0)
                        {
                            int lastTicketId = int.Parse(lastLineData[0]);
                            newTicketId = lastTicketId + 1;
                        }
                        else
                        {
                            newTicketId = 90001;
                        }
                    }
                    else
                    {
                        newTicketId = 90001;
                    }

                    // setting StreamWriter to true appends a new line instead of overwriting existing lines
                    using (StreamWriter writer = new StreamWriter(_ticketInfoFile, true))
                    {
                        writer.WriteLine(
                            $"{newTicketId}," +
                            $"{this.TicketInfo.SelectedMovie.Title}," +
                            $"{this.TicketInfo.SelectedSession.Time.ToString("HH:mm")}," +
                            $"{this.TicketInfo.Price:F2}," + // two decimal digits without the $ sign
                            $"{this.TicketInfo.SubTotal:F2}," +
                            $"{this.TicketInfo.Quantity}," +
                            $"{this.TicketInfo.TicketSelected}," +
                            $"{this.TicketInfo.MovieId}," +
                            $"{currentUser.Id}"
                        );
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(Directory.GetCurrentDirectory());
                    return;
                }  
            }
            else
            {
                MessageBox.Show("There is no user currently logged in!");
            }
        }



        private void btn_Continue_Click(object sender, EventArgs e)
        {
            SaveTicketToFile();
            Form_Seat_Selection form = new Form_Seat_Selection(this.TicketInfo);
            form.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_Movies form = new Form_Movies();
            form.Show();
            this.Close();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login form = new frm_Login();
            form.Show();
            this.Close();
        }
    }
}