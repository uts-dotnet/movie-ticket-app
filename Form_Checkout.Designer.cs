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
            btn_Back = new Button();
            lbl_CardName = new Label();
            lbl_CardNumber = new Label();
            lbl_ExpiryDate = new Label();
            lbl_CVV = new Label();
            txt_CardName = new TextBox();
            txt_CardNumber = new TextBox();
            txt_ExpiryDate = new TextBox();
            btn_Checkout = new Button();
            txt_CVV = new TextBox();
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
            btn_Logout.Click += btn_Logout_Click;
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
            panel_YourOrder.Location = new Point(32, 183);
            panel_YourOrder.Name = "panel_YourOrder";
            panel_YourOrder.Size = new Size(219, 256);
            panel_YourOrder.TabIndex = 25;
            // 
            // btn_Back
            // 
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.Firebrick;
            btn_Back.Location = new Point(28, 46);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 35);
            btn_Back.TabIndex = 26;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
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
            lbl_CardNumber.Location = new Point(307, 229);
            lbl_CardNumber.Name = "lbl_CardNumber";
            lbl_CardNumber.Size = new Size(108, 21);
            lbl_CardNumber.TabIndex = 28;
            lbl_CardNumber.Text = "Card Number";
            // 
            // lbl_ExpiryDate
            // 
            lbl_ExpiryDate.AutoSize = true;
            lbl_ExpiryDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ExpiryDate.Location = new Point(307, 311);
            lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            lbl_ExpiryDate.Size = new Size(93, 21);
            lbl_ExpiryDate.TabIndex = 29;
            lbl_ExpiryDate.Text = "Expiry Date";
            // 
            // lbl_CVV
            // 
            lbl_CVV.AutoSize = true;
            lbl_CVV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CVV.Location = new Point(450, 311);
            lbl_CVV.Name = "lbl_CVV";
            lbl_CVV.Size = new Size(40, 21);
            lbl_CVV.TabIndex = 30;
            lbl_CVV.Text = "CVV";
            // 
            // txt_CardName
            // 
            txt_CardName.Location = new Point(307, 183);
            txt_CardName.Name = "txt_CardName";
            txt_CardName.Size = new Size(251, 23);
            txt_CardName.TabIndex = 31;
            // 
            // txt_CardNumber
            // 
            txt_CardNumber.Location = new Point(307, 262);
            txt_CardNumber.Name = "txt_CardNumber";
            txt_CardNumber.Size = new Size(251, 23);
            txt_CardNumber.TabIndex = 32;
            // 
            // txt_ExpiryDate
            // 
            txt_ExpiryDate.Location = new Point(307, 345);
            txt_ExpiryDate.Name = "txt_ExpiryDate";
            txt_ExpiryDate.Size = new Size(108, 23);
            txt_ExpiryDate.TabIndex = 33;
            // 
            // btn_Checkout
            // 
            btn_Checkout.BackColor = Color.Firebrick;
            btn_Checkout.Cursor = Cursors.Hand;
            btn_Checkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Checkout.ForeColor = Color.White;
            btn_Checkout.Location = new Point(307, 397);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(251, 42);
            btn_Checkout.TabIndex = 35;
            btn_Checkout.Text = "Checkout";
            btn_Checkout.UseVisualStyleBackColor = false;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // txt_CVV
            // 
            txt_CVV.Location = new Point(450, 345);
            txt_CVV.Name = "txt_CVV";
            txt_CVV.Size = new Size(108, 23);
            txt_CVV.TabIndex = 36;
            // 
            // Form_Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 467);
            Controls.Add(txt_CVV);
            Controls.Add(btn_Checkout);
            Controls.Add(txt_ExpiryDate);
            Controls.Add(txt_CardNumber);
            Controls.Add(txt_CardName);
            Controls.Add(lbl_CVV);
            Controls.Add(lbl_ExpiryDate);
            Controls.Add(lbl_CardNumber);
            Controls.Add(lbl_CardName);
            Controls.Add(btn_Back);
            Controls.Add(panel_YourOrder);
            Controls.Add(lbl_CheckoutSubtitle);
            Controls.Add(lbl_YourOrder);
            Controls.Add(btn_Logout);
            Controls.Add(lbl_Checkout);
            Name = "Form_Checkout";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Checkout;
        private Button btn_Logout;
        private Label lbl_YourOrder;
        private Label lbl_CheckoutSubtitle;
        private Panel panel_YourOrder;
        private Button btn_Back;
        private Label lbl_CardName;
        private Label lbl_CardNumber;
        private Label lbl_ExpiryDate;
        private Label lbl_CVV;
        private TextBox txt_CardName;
        private TextBox txt_CardNumber;
        private TextBox txt_ExpiryDate;
        private Button btn_Checkout;
        private TextBox txt_CVV;
    }
}