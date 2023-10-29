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
            listview_Receipt.Columns.Add("Item", 150);
            listview_Receipt.Columns.Add("Qty", 50);
            listview_Receipt.Columns.Add("Price", 100);
            listview_Receipt.Columns.Add("Amount", 100);

            ListViewItem item = new ListViewItem(TicketInfo.TicketType.ToString());
            item.SubItems.Add(TicketInfo.Quantity.ToString());
            item.SubItems.Add(TicketInfo.Price.ToString("C"));
            item.SubItems.Add(_total.ToString("C"));

            listview_Receipt.Items.Add(item);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            User user = CurrentUserManager.Instance.CurrentUser;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "receipt.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";

            string seats = string.Join(", ", TicketInfo.BookedSeats.Select(seat => seat.Name));

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;

                string content =
                    $"---- DOTNET Cinemas ----\n\n" +
                    $"Receipt for {user.FullName}\n\n" +
                    $"Movie: {TicketInfo.SelectedMovie.Title}\n" +
                    $"Session Time: {TicketInfo.SelectedSession.Time:HH:mm}\n" +
                    $"{TicketInfo.TicketType}\n" +
                    $"Price: {TicketInfo.Price:C}\n" +
                    $"Quantity: {TicketInfo.Quantity}\n" +
                    $"Seats: {seats}\n" +
                    $"Sub Total: {TicketInfo.SubTotal:C}\n" +
                    $"Booking Fee: {_bookingFee:C}\n" +
                    $"Total: {_total:C}\n"
                ;

                File.WriteAllText(file, content);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login form = new frm_Login();
            form.Show();
            this.Close();
        }
    }
}
