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

        public Form_Checkout()
        {
            InitializeComponent();
            txt_CardNumber.MaxLength = 16;
            txt_CardName.TextChanged += TextFields_TextChanged;
            txt_CardNumber.TextChanged += TextFields_TextChanged;
            txt_ExpiryDate.TextChanged += TextFields_TextChanged;
            txt_CVV.TextChanged += TextFields_TextChanged;
            lbl_BookingFee_Value.Text = _bookingFee.ToString("C");
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            _cardName = txt_CardName.Text;
            _cardNumber = txt_CardNumber.Text;
            _expiryDate = txt_ExpiryDate.Text;
            _cvv = txt_CVV.Text;

            EnablePayButton();
        }

        private void EnablePayButton()
        {
            bool cardNameValid = Validators.ValidateCardName(_cardName);
            bool cardNumberValid = Validators.ValidateCardNumber(_cardNumber);
            bool expiryDateValid = Validators.ValidateExpiryDate(_expiryDate);
            bool cvvValid = Validators.ValidateCVV(_cvv);

            if (cardNameValid && cardNumberValid && expiryDateValid && cvvValid)
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
    }
}
