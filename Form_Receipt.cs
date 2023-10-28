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
    public partial class Form_Receipt : Form
    {
        private double _bookingFee = 1.63;
        private double _total;

        public Form_Receipt()
        {
            InitializeComponent();
            InitializeLabels();
            PopulateListView();
        }

        private void InitializeLabels()
        {
            lbl_MovieTitle.Text = TicketInfo.SelectedMovie.Title;
            lbl_SessionTime_Value.Text = TicketInfo.SelectedSession.Time.ToString("HH:mm");
            lbl_Subtotal_Value.Text = TicketInfo.SubTotal.ToString("C");
            lbl_BookingFee_Value.Text = _bookingFee.ToString("C");

            _total = TicketInfo.SubTotal + _bookingFee;
            lbl_Total_Value.Text = _total.ToString("C");
        }

        private void PopulateListView()
        {
            listview_Receipt.View = View.Details;
            listview_Receipt.Columns.Add("Item", 100);
            listview_Receipt.Columns.Add("Qty", 100);
            listview_Receipt.Columns.Add("Price", 100);
            listview_Receipt.Columns.Add("Amount", 100);

            ListViewItem item = new ListViewItem(TicketInfo.TicketType.ToString());
            item.SubItems.Add(TicketInfo.Quantity.ToString());
            item.SubItems.Add(TicketInfo.Price.ToString("C"));
            item.SubItems.Add(_total.ToString("C"));

            listview_Receipt.Items.Add(item);
        }
    }
}
