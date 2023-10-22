using System;

namespace MovieTicketApp
{
    public partial class Form_Confirm_Booking : Form
    {
        public Form_Confirm_Booking(TicketInfo ticket)
        {
            InitializeComponent();

            lbl_Movie_Title.Text = ticket.SelectedMovie.Title;
            lbl_Session_Time.Text = ticket.SelectedSession.Time.ToString("HH:mm");
            lbl_Ticket_Type.Text = ticket.TicketSelected;
            lbl_Ticket_Price_Value.Text = ticket.Price.ToString("C");
            lbl_Quantity_Value.Text = ticket.Quantity.ToString();
            lbl_Subtotal_Value.Text = ticket.SubTotal.ToString("C");
        }
    }
}
