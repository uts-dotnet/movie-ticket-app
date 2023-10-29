namespace MovieTicketApp
{
    partial class Form_Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Checkout = new Label();
            btn_Logout = new Button();
            lbl_YourOrder = new Label();
            lbl_CheckoutSubtitle = new Label();
            panel_YourOrder = new Panel();
            lbl_Subtotal_Value = new Label();
            lbl_Subtotal = new Label();
            lbl_MovieTitle = new Label();
            lbl_Line = new Label();
            lbl_TicketQuantity = new Label();
            lbl_TicketType = new Label();
            lbl_BookingFee_Value = new Label();
            lbl_BookingFee = new Label();
            lbl_Total_Value = new Label();
            lbl_Total = new Label();
            lbl_CardName = new Label();
            lbl_CardNumber = new Label();
            lbl_ExpiryDate = new Label();
            lbl_CVV = new Label();
            txt_CardName = new TextBox();
            txt_CardNumber = new TextBox();
            txt_ExpiryDate = new TextBox();
            btn_Pay = new Button();
            txt_CVV = new TextBox();
            btn_AutoFill = new Button();
            panel_YourOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Checkout
            // 
            lbl_Checkout.AutoSize = true;
            lbl_Checkout.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Checkout.ForeColor = Color.Firebrick;
            lbl_Checkout.Location = new Point(226, 38);
            lbl_Checkout.Name = "lbl_Checkout";
            lbl_Checkout.Size = new Size(145, 40);
            lbl_Checkout.TabIndex = 5;
            lbl_Checkout.Text = "Checkout";
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.Firebrick;
            btn_Logout.Location = new Point(469, 46);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(89, 35);
            btn_Logout.TabIndex = 22;
            btn_Logout.Text = "Log Out";
            btn_Logout.UseVisualStyleBackColor = true;
            // 
            // lbl_YourOrder
            // 
            lbl_YourOrder.AutoSize = true;
            lbl_YourOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_YourOrder.Location = new Point(28, 152);
            lbl_YourOrder.Name = "lbl_YourOrder";
            lbl_YourOrder.Size = new Size(90, 21);
            lbl_YourOrder.TabIndex = 23;
            lbl_YourOrder.Text = "Your Order";
            // 
            // lbl_CheckoutSubtitle
            // 
            lbl_CheckoutSubtitle.AutoSize = true;
            lbl_CheckoutSubtitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CheckoutSubtitle.Location = new Point(219, 91);
            lbl_CheckoutSubtitle.Name = "lbl_CheckoutSubtitle";
            lbl_CheckoutSubtitle.Size = new Size(157, 21);
            lbl_CheckoutSubtitle.TabIndex = 24;
            lbl_CheckoutSubtitle.Text = "Pay with Credit Card";
            // 
            // panel_YourOrder
            // 
            panel_YourOrder.BackColor = Color.White;
            panel_YourOrder.BorderStyle = BorderStyle.FixedSingle;
            panel_YourOrder.Controls.Add(lbl_Subtotal_Value);
            panel_YourOrder.Controls.Add(lbl_Subtotal);
            panel_YourOrder.Controls.Add(lbl_MovieTitle);
            panel_YourOrder.Controls.Add(lbl_Line);
            panel_YourOrder.Controls.Add(lbl_TicketQuantity);
            panel_YourOrder.Controls.Add(lbl_TicketType);
            panel_YourOrder.Controls.Add(lbl_BookingFee_Value);
            panel_YourOrder.Controls.Add(lbl_BookingFee);
            panel_YourOrder.Controls.Add(lbl_Total_Value);
            panel_YourOrder.Controls.Add(lbl_Total);
            panel_YourOrder.Location = new Point(32, 183);
            panel_YourOrder.Name = "panel_YourOrder";
            panel_YourOrder.Size = new Size(219, 221);
            panel_YourOrder.TabIndex = 25;
            // 
            // lbl_Subtotal_Value
            // 
            lbl_Subtotal_Value.AutoSize = true;
            lbl_Subtotal_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal_Value.Location = new Point(141, 82);
            lbl_Subtotal_Value.Name = "lbl_Subtotal_Value";
            lbl_Subtotal_Value.Size = new Size(59, 21);
            lbl_Subtotal_Value.TabIndex = 45;
            lbl_Subtotal_Value.Text = "$00.00";
            lbl_Subtotal_Value.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(15, 82);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(77, 21);
            lbl_Subtotal.TabIndex = 44;
            lbl_Subtotal.Text = "Sub Total";
            // 
            // lbl_MovieTitle
            // 
            lbl_MovieTitle.AutoSize = true;
            lbl_MovieTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MovieTitle.Location = new Point(15, 14);
            lbl_MovieTitle.Name = "lbl_MovieTitle";
            lbl_MovieTitle.Size = new Size(92, 21);
            lbl_MovieTitle.TabIndex = 43;
            lbl_MovieTitle.Text = "Movie Title";
            // 
            // lbl_Line
            // 
            lbl_Line.AutoSize = true;
            lbl_Line.ForeColor = Color.Silver;
            lbl_Line.Location = new Point(13, 110);
            lbl_Line.Name = "lbl_Line";
            lbl_Line.Size = new Size(192, 15);
            lbl_Line.TabIndex = 42;
            lbl_Line.Text = "_____________________________________";
            // 
            // lbl_TicketQuantity
            // 
            lbl_TicketQuantity.AutoSize = true;
            lbl_TicketQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TicketQuantity.Location = new Point(181, 48);
            lbl_TicketQuantity.Name = "lbl_TicketQuantity";
            lbl_TicketQuantity.Size = new Size(19, 21);
            lbl_TicketQuantity.TabIndex = 41;
            lbl_TicketQuantity.Text = "0";
            // 
            // lbl_TicketType
            // 
            lbl_TicketType.AutoSize = true;
            lbl_TicketType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TicketType.Location = new Point(15, 48);
            lbl_TicketType.Name = "lbl_TicketType";
            lbl_TicketType.Size = new Size(93, 21);
            lbl_TicketType.TabIndex = 40;
            lbl_TicketType.Text = "Ticket Type";
            // 
            // lbl_BookingFee_Value
            // 
            lbl_BookingFee_Value.AutoSize = true;
            lbl_BookingFee_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_BookingFee_Value.ForeColor = Color.Firebrick;
            lbl_BookingFee_Value.Location = new Point(151, 141);
            lbl_BookingFee_Value.Name = "lbl_BookingFee_Value";
            lbl_BookingFee_Value.Size = new Size(50, 21);
            lbl_BookingFee_Value.TabIndex = 39;
            lbl_BookingFee_Value.Text = "$0.00";
            lbl_BookingFee_Value.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_BookingFee
            // 
            lbl_BookingFee.AutoSize = true;
            lbl_BookingFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_BookingFee.ForeColor = Color.Firebrick;
            lbl_BookingFee.Location = new Point(15, 141);
            lbl_BookingFee.Name = "lbl_BookingFee";
            lbl_BookingFee.Size = new Size(99, 21);
            lbl_BookingFee.TabIndex = 37;
            lbl_BookingFee.Text = "Booking fee";
            // 
            // lbl_Total_Value
            // 
            lbl_Total_Value.AutoSize = true;
            lbl_Total_Value.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total_Value.Location = new Point(129, 177);
            lbl_Total_Value.Name = "lbl_Total_Value";
            lbl_Total_Value.Size = new Size(72, 25);
            lbl_Total_Value.TabIndex = 38;
            lbl_Total_Value.Text = "$00.00";
            lbl_Total_Value.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total.Location = new Point(15, 177);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(53, 25);
            lbl_Total.TabIndex = 37;
            lbl_Total.Text = "Total";
            // 
            // lbl_CardName
            // 
            lbl_CardName.AutoSize = true;
            lbl_CardName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CardName.Location = new Point(307, 152);
            lbl_CardName.Name = "lbl_CardName";
            lbl_CardName.Size = new Size(91, 21);
            lbl_CardName.TabIndex = 27;
            lbl_CardName.Text = "Card Name";
            // 
            // lbl_CardNumber
            // 
            lbl_CardNumber.AutoSize = true;
            lbl_CardNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CardNumber.Location = new Point(307, 246);
            lbl_CardNumber.Name = "lbl_CardNumber";
            lbl_CardNumber.Size = new Size(108, 21);
            lbl_CardNumber.TabIndex = 28;
            lbl_CardNumber.Text = "Card Number";
            // 
            // lbl_ExpiryDate
            // 
            lbl_ExpiryDate.AutoSize = true;
            lbl_ExpiryDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ExpiryDate.Location = new Point(307, 343);
            lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            lbl_ExpiryDate.Size = new Size(93, 21);
            lbl_ExpiryDate.TabIndex = 29;
            lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // lbl_CVV
            // 
            lbl_CVV.AutoSize = true;
            lbl_CVV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CVV.Location = new Point(450, 343);
            lbl_CVV.Name = "lbl_CVV";
            lbl_CVV.Size = new Size(40, 21);
            lbl_CVV.TabIndex = 30;
            lbl_CVV.Text = "CVV";
            // 
            // txt_CardName
            // 
            txt_CardName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CardName.Location = new Point(307, 183);
            txt_CardName.Name = "txt_CardName";
            txt_CardName.PlaceholderText = "JANE DOE";
            txt_CardName.Size = new Size(251, 27);
            txt_CardName.TabIndex = 31;
            // 
            // txt_CardNumber
            // 
            txt_CardNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CardNumber.Location = new Point(307, 279);
            txt_CardNumber.MaxLength = 16;
            txt_CardNumber.Name = "txt_CardNumber";
            txt_CardNumber.PlaceholderText = "XXXX XXXX XXXX XXXX";
            txt_CardNumber.Size = new Size(251, 27);
            txt_CardNumber.TabIndex = 32;
            // 
            // txt_ExpiryDate
            // 
            txt_ExpiryDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ExpiryDate.Location = new Point(307, 377);
            txt_ExpiryDate.MaxLength = 5;
            txt_ExpiryDate.Name = "txt_ExpiryDate";
            txt_ExpiryDate.PlaceholderText = "MM/YY";
            txt_ExpiryDate.Size = new Size(108, 27);
            txt_ExpiryDate.TabIndex = 33;
            // 
            // btn_Pay
            // 
            btn_Pay.BackColor = Color.Firebrick;
            btn_Pay.Cursor = Cursors.Hand;
            btn_Pay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Pay.ForeColor = Color.White;
            btn_Pay.Location = new Point(307, 450);
            btn_Pay.Name = "btn_Pay";
            btn_Pay.Size = new Size(251, 42);
            btn_Pay.TabIndex = 35;
            btn_Pay.Text = "Pay";
            btn_Pay.UseVisualStyleBackColor = false;
            btn_Pay.Click += btn_Pay_Click;
            // 
            // txt_CVV
            // 
            txt_CVV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CVV.Location = new Point(450, 377);
            txt_CVV.MaxLength = 3;
            txt_CVV.Name = "txt_CVV";
            txt_CVV.PlaceholderText = "XXX";
            txt_CVV.Size = new Size(108, 27);
            txt_CVV.TabIndex = 36;
            // 
            // btn_AutoFill
            // 
            btn_AutoFill.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AutoFill.ForeColor = Color.Firebrick;
            btn_AutoFill.Location = new Point(469, 143);
            btn_AutoFill.Name = "btn_AutoFill";
            btn_AutoFill.Size = new Size(89, 32);
            btn_AutoFill.TabIndex = 38;
            btn_AutoFill.Text = "Auto Fill";
            btn_AutoFill.UseVisualStyleBackColor = true;
            btn_AutoFill.Click += btn_AutoFill_Click;
            // 
            // Form_Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 518);
            Controls.Add(btn_AutoFill);
            Controls.Add(txt_CVV);
            Controls.Add(btn_Pay);
            Controls.Add(txt_ExpiryDate);
            Controls.Add(txt_CardNumber);
            Controls.Add(txt_CardName);
            Controls.Add(lbl_CVV);
            Controls.Add(lbl_ExpiryDate);
            Controls.Add(lbl_CardNumber);
            Controls.Add(lbl_CardName);
            Controls.Add(panel_YourOrder);
            Controls.Add(lbl_CheckoutSubtitle);
            Controls.Add(lbl_YourOrder);
            Controls.Add(btn_Logout);
            Controls.Add(lbl_Checkout);
            Name = "Form_Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            panel_YourOrder.ResumeLayout(false);
            panel_YourOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Checkout;
        private Button btn_Logout;
        private Label lbl_YourOrder;
        private Label lbl_CheckoutSubtitle;
        private Panel panel_YourOrder;
        private Label lbl_CardName;
        private Label lbl_CardNumber;
        private Label lbl_ExpiryDate;
        private Label lbl_CVV;
        private TextBox txt_CardName;
        private TextBox txt_CardNumber;
        private TextBox txt_ExpiryDate;
        private Button btn_Pay;
        private TextBox txt_CVV;
        private Label lbl_Total;
        private Label lbl_Total_Value;
        private Label lbl_BookingFee;
        private Label lbl_BookingFee_Value;
        private Label lbl_TicketQuantity;
        private Label lbl_TicketType;
        private Label lbl_Line;
        private Label lbl_MovieTitle;
        private Label lbl_Subtotal;
        private Label lbl_Subtotal_Value;
        private Button btn_AutoFill;
    }
}