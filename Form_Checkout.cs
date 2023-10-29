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

        public Form_Checkout()
        {
            InitializeComponent();
            _total = TicketInfo.SubTotal + _bookingFee;

            lbl_MovieTitle.Text = TicketInfo.SelectedMovie.Title;
            lbl_TicketType.Text = TicketInfo.TicketType;
            lbl_TicketQuantity.Text = TicketInfo.Quantity.ToString();
            lbl_Subtotal_Value.Text = TicketInfo.SubTotal.ToString("C");
            lbl_BookingFee_Value.Text = _bookingFee.ToString("C");
            lbl_Total_Value.Text = _total.ToString("C");

            txt_CardNumber.MaxLength = 16;
            txt_ExpiryDate.MaxLength = 5;
            txt_CVV.MaxLength = 3;
            txt_CardName.TextChanged += TextFields_TextChanged;
            txt_CardNumber.TextChanged += TextFields_TextChanged;
            txt_ExpiryDate.TextChanged += TextFields_TextChanged;
            txt_CVV.TextChanged += TextFields_TextChanged;

            btn_Pay.Enabled = false;
            btn_Pay.BackColor = Color.White;
            btn_Pay.ForeColor = Color.Gray;
        }

        private void Form_Checkout_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
            Form_Receipt form = new Form_Receipt();
            form.Show();
            this.Close();
        }

        private void btn_AutoFill_Click(object sender, EventArgs e)
        {
            User user = CurrentUserManager.Instance.CurrentUser;
            txt_CardName.Text = user.FullName;
            txt_CardNumber.Text = string.Concat(Enumerable.Repeat("1234", 4)); // just to make sure that there are 16 numbers
            txt_ExpiryDate.Text = "01/25";
            txt_CVV.Text = "444";

            EnablePayment();
        }
    }
}
