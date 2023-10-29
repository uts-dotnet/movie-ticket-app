namespace MovieTicketApp
{
    partial class Form_Receipt
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
            lbl_ReceiptTitle = new Label();
            listview_Receipt = new ListView();
            label1 = new Label();
            lbl_Subtotal_Value = new Label();
            label3 = new Label();
            lbl_BookingFee_Value = new Label();
            label5 = new Label();
            lbl_Total_Value = new Label();
            lbl_MovieTitle = new Label();
            lbl_SessionTime = new Label();
            lbl_SessionTime_Value = new Label();
            btn_Save = new Button();
            btn_Logout = new Button();
            SuspendLayout();
            // 
            // lbl_ReceiptTitle
            // 
            lbl_ReceiptTitle.AutoSize = true;
            lbl_ReceiptTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ReceiptTitle.ForeColor = Color.Firebrick;
            lbl_ReceiptTitle.Location = new Point(24, 38);
            lbl_ReceiptTitle.Name = "lbl_ReceiptTitle";
            lbl_ReceiptTitle.Size = new Size(118, 40);
            lbl_ReceiptTitle.TabIndex = 6;
            lbl_ReceiptTitle.Text = "Receipt";
            // 
            // listview_Receipt
            // 
            listview_Receipt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listview_Receipt.Location = new Point(24, 232);
            listview_Receipt.Name = "listview_Receipt";
            listview_Receipt.Size = new Size(403, 159);
            listview_Receipt.TabIndex = 7;
            listview_Receipt.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 414);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 8;
            label1.Text = "Sub Total:";
            // 
            // lbl_Subtotal_Value
            // 
            lbl_Subtotal_Value.AutoSize = true;
            lbl_Subtotal_Value.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal_Value.Location = new Point(355, 413);
            lbl_Subtotal_Value.Name = "lbl_Subtotal_Value";
            lbl_Subtotal_Value.Size = new Size(72, 25);
            lbl_Subtotal_Value.TabIndex = 9;
            lbl_Subtotal_Value.Text = "$00.00";
            lbl_Subtotal_Value.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(224, 455);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 10;
            label3.Text = "Booking fee:";
            // 
            // lbl_BookingFee_Value
            // 
            lbl_BookingFee_Value.AutoSize = true;
            lbl_BookingFee_Value.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_BookingFee_Value.ForeColor = Color.Firebrick;
            lbl_BookingFee_Value.Location = new Point(366, 455);
            lbl_BookingFee_Value.Name = "lbl_BookingFee_Value";
            lbl_BookingFee_Value.Size = new Size(61, 25);
            lbl_BookingFee_Value.TabIndex = 11;
            lbl_BookingFee_Value.Text = "$0.00";
            lbl_BookingFee_Value.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(223, 509);
            label5.Name = "label5";
            label5.Size = new Size(66, 30);
            label5.TabIndex = 12;
            label5.Text = "Total:";
            // 
            // lbl_Total_Value
            // 
            lbl_Total_Value.AutoSize = true;
            lbl_Total_Value.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total_Value.Location = new Point(349, 509);
            lbl_Total_Value.Name = "lbl_Total_Value";
            lbl_Total_Value.Size = new Size(78, 30);
            lbl_Total_Value.TabIndex = 13;
            lbl_Total_Value.Text = "$00.00";
            lbl_Total_Value.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_MovieTitle
            // 
            lbl_MovieTitle.AutoSize = true;
            lbl_MovieTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MovieTitle.Location = new Point(23, 107);
            lbl_MovieTitle.Name = "lbl_MovieTitle";
            lbl_MovieTitle.Size = new Size(135, 32);
            lbl_MovieTitle.TabIndex = 14;
            lbl_MovieTitle.Text = "Movie Title";
            // 
            // lbl_SessionTime
            // 
            lbl_SessionTime.AutoSize = true;
            lbl_SessionTime.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SessionTime.Location = new Point(23, 165);
            lbl_SessionTime.Name = "lbl_SessionTime";
            lbl_SessionTime.Size = new Size(160, 32);
            lbl_SessionTime.TabIndex = 15;
            lbl_SessionTime.Text = "Session Time:";
            // 
            // lbl_SessionTime_Value
            // 
            lbl_SessionTime_Value.AutoSize = true;
            lbl_SessionTime_Value.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SessionTime_Value.Location = new Point(189, 165);
            lbl_SessionTime_Value.Name = "lbl_SessionTime_Value";
            lbl_SessionTime_Value.Size = new Size(98, 32);
            lbl_SessionTime_Value.TabIndex = 16;
            lbl_SessionTime_Value.Text = "HH:mm";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Firebrick;
            btn_Save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(223, 569);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(204, 39);
            btn_Save.TabIndex = 18;
            btn_Save.Text = "Save Receipt";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.Firebrick;
            btn_Logout.Location = new Point(338, 43);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(89, 35);
            btn_Logout.TabIndex = 23;
            btn_Logout.Text = "Log Out";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // Form_Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 635);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Save);
            Controls.Add(lbl_SessionTime_Value);
            Controls.Add(lbl_SessionTime);
            Controls.Add(lbl_MovieTitle);
            Controls.Add(lbl_Total_Value);
            Controls.Add(label5);
            Controls.Add(lbl_BookingFee_Value);
            Controls.Add(label3);
            Controls.Add(lbl_Subtotal_Value);
            Controls.Add(label1);
            Controls.Add(listview_Receipt);
            Controls.Add(lbl_ReceiptTitle);
            Name = "Form_Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt | DOTNET Cinemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ReceiptTitle;
        private ListView listview_Receipt;
        private Label label1;
        private Label lbl_Subtotal_Value;
        private Label label3;
        private Label lbl_BookingFee_Value;
        private Label label5;
        private Label lbl_Total_Value;
        private Label lbl_MovieTitle;
        private Label lbl_SessionTime;
        private Label lbl_SessionTime_Value;
        private Button btn_Save;
        private Button btn_Logout;
    }
}