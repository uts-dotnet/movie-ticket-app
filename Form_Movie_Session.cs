﻿using System;
using System.Globalization;

namespace MovieTicketApp
{
    public partial class Form_Movie_Session : Form
    {
        private Movie _movie;
        private MovieSession _session;

        public Form_Movie_Session(Movie selectedMovie, MovieSession selectedSession)
        {
            InitializeComponent();

            _movie = selectedMovie;
            _session = selectedSession;

            lbl_Title_MovieSession.Text = _movie.Title;
            lbl_Session_Time_Fomatted.Text = _session.Date.ToString("HH:mm tt");

            LoadListView();
            PopulateListView();

            EnableQuantityButtons(false);
            EnableContinueButton(false);
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
                lbl_Ticket_Selected.Text = selectedItem.Text;

                string priceString = selectedItem.SubItems[1].Text;
                double price = double.Parse(priceString, NumberStyles.Currency);

                lbl_Ticket_Price_Value.Text = price.ToString("C");
                lbl_Sub_Total_Value.Text = price.ToString("C");
                lbl_Quantity_Value.Text = "1";
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
            }
        }
    }
}