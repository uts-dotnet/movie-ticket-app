using System;
using System.Diagnostics;
using System.Globalization;

namespace MovieTicketApp
{
    public partial class Form_Ticket_Selection : Form
    {
        public Form_Ticket_Selection()
        {
            InitializeComponent();
            InitializeLabels();

            LoadListView();
            PopulateListView();

            EnableQuantityButtons(true);
            EnableContinueButton(true);
        }

        public Form_Ticket_Selection(Movie selectedMovie, MovieSession selectedSession)
        {
            InitializeComponent();

            TicketInfo.SetTicket(selectedMovie, selectedSession, 0, 0, 0, string.Empty);

            TicketInfo.TicketType = string.Empty;

            lbl_Movie_Title.Text = TicketInfo.SelectedMovie.Title;
            lbl_Session_Time_Fomatted.Text = TicketInfo.SelectedSession.Time.ToString("HH:mm");

            LoadListView();
            PopulateListView();

            EnableQuantityButtons(false);
            EnableContinueButton(false);
        }

        private void Form_Ticket_Selection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void InitializeLabels()
        {
            lbl_Movie_Title.Text = TicketInfo.SelectedMovie.Title;
            lbl_Session_Time_Fomatted.Text = TicketInfo.SelectedSession.Time.ToString("HH:mm");
            lbl_Ticket_Price_Value.Text = TicketInfo.Price.ToString("C");
            lbl_Ticket_Selected.Text = TicketInfo.TicketType;
            lbl_Quantity_Value.Text = TicketInfo.Quantity.ToString();
            lbl_Sub_Total_Value.Text = TicketInfo.SubTotal.ToString("C");
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
                TicketInfo.TicketType = lbl_Ticket_Selected.Text;

                string priceString = selectedItem.SubItems[1].Text;

                TicketInfo.Price = double.Parse(priceString, NumberStyles.Currency);
                TicketInfo.SubTotal = TicketInfo.Price;

                lbl_Ticket_Price_Value.Text = TicketInfo.Price.ToString("C");
                lbl_Sub_Total_Value.Text = TicketInfo.Price.ToString("C");
                lbl_Quantity_Value.Text = "1";

                TicketInfo.Quantity = Convert.ToInt32(lbl_Quantity_Value.Text);
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
            TicketInfo.Quantity = Convert.ToInt32(lbl_Quantity_Value.Text);
            TicketInfo.Price = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            TicketInfo.SubTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (TicketInfo.Quantity < 10)
            {
                TicketInfo.Quantity++;
                lbl_Quantity_Value.Text = TicketInfo.Quantity.ToString();

                TicketInfo.SubTotal += TicketInfo.Price;
                lbl_Sub_Total_Value.Text = TicketInfo.SubTotal.ToString("C");

                EnableContinueButton(true);
            }
            else
            {
                MessageBox.Show($"You can only purchase 10 {lbl_Ticket_Selected.Text} tickets");
            }
        }

        private void btn_Decrement_Click(object sender, EventArgs e)
        {
            TicketInfo.Quantity = Convert.ToInt32(lbl_Quantity_Value.Text);
            TicketInfo.Price = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            TicketInfo.SubTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (TicketInfo.Quantity > 0)
            {
                TicketInfo.Quantity--;
                lbl_Quantity_Value.Text = TicketInfo.Quantity.ToString();

                TicketInfo.SubTotal -= TicketInfo.Price;
                lbl_Sub_Total_Value.Text = TicketInfo.SubTotal.ToString("C");

                if (TicketInfo.Quantity == 0)
                    EnableContinueButton(false);
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            Form_Seat_Selection form = new Form_Seat_Selection();
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