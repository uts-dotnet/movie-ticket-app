using System;
using System.Diagnostics;
using System.Globalization;

namespace MovieTicketApp
{
    public partial class Form_Movie_Ticket : Form
    {
        private Movie _movie;
        private MovieSession _session;
        public static int SelectedTicketQuantity { get; private set; }


        public Form_Movie_Ticket(Movie selectedMovie, MovieSession selectedSession)
        {
            InitializeComponent();

            _movie = selectedMovie;
            _session = selectedSession;

            lbl_Movie_Title.Text = _movie.Title;
            lbl_Session_Time_Fomatted.Text = _session.Time.ToString("HH:mm");

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

                string priceString = selectedItem.SubItems[1].Text;
                double price = double.Parse(priceString, NumberStyles.Currency);

                lbl_Ticket_Price_Value.Text = price.ToString("C");
                lbl_Sub_Total_Value.Text = price.ToString("C");
                lbl_Quantity_Value.Text = "1";

                SelectedTicketQuantity = Convert.ToInt32(lbl_Quantity_Value.Text);
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
            double ticketPrice = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            double subTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (quantity < 10)
            {
                quantity++;
                subTotal += ticketPrice;
                lbl_Sub_Total_Value.Text = $"{subTotal:C}";

                EnableContinueButton(true);

                SelectedTicketQuantity = quantity;
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
            double ticketPrice = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            double subTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (quantity > 0)
            {
                quantity--;

                subTotal -= ticketPrice;
                lbl_Sub_Total_Value.Text = $"{subTotal:C}";
                lbl_Quantity_Value.Text = quantity.ToString();

                if (quantity == 0)
                    EnableContinueButton(false);

                SelectedTicketQuantity = quantity;
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            string sessionTime = lbl_Session_Time_Fomatted.Text;
            Form_Seat_Selection form = new Form_Seat_Selection(this._movie, this._session, SelectedTicketQuantity);
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