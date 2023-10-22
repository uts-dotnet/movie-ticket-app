using System;
using System.Diagnostics;
using System.Globalization;

namespace MovieTicketApp
{
    public partial class Form_Ticket_Booking : Form
    {
        private Movie _movie;
        private MovieSession _session;
        public string TicketSelected { get; private set; }
        public double TicketPrice { get; private set; }
        public double SubTotal { get; private set; }
        public int TicketQuantity { get; private set; }
        public static int SelectedTicketQuantity { get; private set; }


        public Form_Ticket_Booking(Movie selectedMovie, MovieSession selectedSession)
        {
            InitializeComponent();

            this._movie = selectedMovie;
            this._session = selectedSession;
            this.TicketSelected = string.Empty;

            lbl_Movie_Title.Text = _movie.Title;
            lbl_Session_Time_Fomatted.Text = _session.Time.ToString("HH:mm");

            LoadListView();
            PopulateListView();

            EnableQuantityButtons(false);
            EnableContinueButton(false);
        }

        public Form_Ticket_Booking(TicketInfo ticketInfo)
        {
            InitializeComponent();

            this._movie = ticketInfo.SelectedMovie;
            this._session = ticketInfo.SelectedSession;
            this.TicketSelected = ticketInfo.TicketSelected;
            this.TicketPrice = ticketInfo.Price;
            this.TicketQuantity = ticketInfo.Quantity;
            this.SubTotal = ticketInfo.SubTotal;

            lbl_Movie_Title.Text = this._movie.Title;
            lbl_Session_Time_Fomatted.Text = this._session.Time.ToString("HH:mm");

            LoadListView();
            PopulateListView();

            lbl_Ticket_Selected.Text = this.TicketSelected;
            lbl_Ticket_Price_Value.Text = this.TicketPrice.ToString("C");
            lbl_Quantity_Value.Text = this.TicketQuantity.ToString();
            lbl_Sub_Total_Value.Text = this.SubTotal.ToString("C");

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
                this.TicketSelected = lbl_Ticket_Selected.Text;

                string priceString = selectedItem.SubItems[1].Text;
                TicketPrice = double.Parse(priceString, NumberStyles.Currency);

                lbl_Ticket_Price_Value.Text = TicketPrice.ToString("C");
                lbl_Sub_Total_Value.Text = TicketPrice.ToString("C");
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
            this.TicketPrice = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            this.SubTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (quantity < 10)
            {
                quantity++;
                this.SubTotal += TicketPrice;
                lbl_Sub_Total_Value.Text = $"{this.SubTotal:C}";

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
            this.TicketPrice = Convert.ToDouble(lbl_Ticket_Price_Value.Text.Trim('$'));
            this.SubTotal = Convert.ToDouble(lbl_Sub_Total_Value.Text.Trim('$'));

            if (quantity > 0)
            {
                quantity--;

                this.SubTotal -= this.TicketPrice;
                lbl_Sub_Total_Value.Text = $"{this.SubTotal:C}";
                lbl_Quantity_Value.Text = quantity.ToString();

                if (quantity == 0)
                    EnableContinueButton(false);

                SelectedTicketQuantity = quantity;
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            string sessionTime = lbl_Session_Time_Fomatted.Text;

            TicketInfo ticketInfo = new TicketInfo(this._movie, this._session, this.TicketPrice, this.SubTotal, SelectedTicketQuantity, this.TicketSelected);
            Form_Seat_Selection form = new Form_Seat_Selection(ticketInfo);

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