using System;
using System.Text.RegularExpressions;

namespace MovieTicketApp
{
    public partial class Form_Checkout : Form
    {
        private string _cardName = "";
        private string _cardNumber = "";
        private string _expiryDate = "";
        private string _cvv = "";
        private double _bookingFee = 1.63;
        private double _total;

        public Form_Checkout(TicketInfo ticket)
        {
            InitializeComponent();
            _total = ticket.SubTotal + _bookingFee;

            lbl_MovieTitle.Text = ticket.SelectedMovie.Title;
            lbl_TicketType.Text = ticket.TicketType;
            lbl_Subtotal_Value.Text = ticket.SubTotal.ToString("C");
            lbl_BookingFee_Value.Text = _bookingFee.ToString("C");
            lbl_Total_Value.Text = _total.ToString("C");

            txt_CardNumber.MaxLength = 16;
            txt_CardName.TextChanged += TextFields_TextChanged;
            txt_CardNumber.TextChanged += TextFields_TextChanged;
            txt_ExpiryDate.TextChanged += TextFields_TextChanged;
            txt_CVV.TextChanged += TextFields_TextChanged;

            btn_Pay.Enabled = false;
            btn_Pay.BackColor = Color.White;
            btn_Pay.ForeColor = Color.Gray;

            txt_CardName.Enter += TextField_Enter;
            txt_CardNumber.Enter += TextField_Enter;
            txt_ExpiryDate.Enter += TextField_Enter;
            txt_CVV.Enter += TextField_Enter;
        }

        private void TextField_Enter(object sender, EventArgs e)
        {
            btn_Pay.Enabled = true;
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            _cardName = txt_CardName.Text;
            _cardNumber = txt_CardNumber.Text;
            _expiryDate = txt_ExpiryDate.Text;
            _cvv = txt_CVV.Text;

            EnablePayment();
        }

        private void EnablePayment()
        {
            bool cardNameValid = Validators.ValidateCardName(_cardName);
            bool cardNumberValid = Validators.ValidateCardNumber(_cardNumber);
            bool expiryDateValid = Validators.ValidateExpiryDate(_expiryDate);
            bool cvvValid = Validators.ValidateCVV(_cvv);

            if (cardNameValid && cardNumberValid && expiryDateValid && cvvValid)
                SetPayButton(true);
            else
                SetPayButton(false);
        }

        private void SetPayButton(bool value)
        {
            if (value)
            {
                btn_Pay.Enabled = true;
                btn_Pay.BackColor = Color.Firebrick;
                btn_Pay.ForeColor = Color.White;
            }
            else
            {
                btn_Pay.Enabled = false;
                btn_Pay.BackColor = Color.White;
                btn_Pay.ForeColor = Color.Gray;
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }
    }
}
