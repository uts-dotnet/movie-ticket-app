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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // lbl_ReceiptTitle
            // 
            lbl_ReceiptTitle.AutoSize = true;
            lbl_ReceiptTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ReceiptTitle.ForeColor = Color.Firebrick;
            lbl_ReceiptTitle.Location = new Point(24, 38);
            lbl_ReceiptTitle.Name = "lbl_ReceiptTitle";
            lbl_ReceiptTitle.Size = new Size(255, 40);
            lbl_ReceiptTitle.TabIndex = 6;
            lbl_ReceiptTitle.Text = "DOTNET Cinemas";
            // 
            // listview_Receipt
            // 
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(355, 413);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 9;
            label2.Text = "$00.00";
            label2.TextAlign = ContentAlignment.TopRight;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(366, 455);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 11;
            label4.Text = "$0.00";
            label4.TextAlign = ContentAlignment.TopRight;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(349, 509);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 13;
            label6.Text = "$00.00";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 107);
            label7.Name = "label7";
            label7.Size = new Size(135, 32);
            label7.TabIndex = 14;
            label7.Text = "Movie Title";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 165);
            label8.Name = "label8";
            label8.Size = new Size(160, 32);
            label8.TabIndex = 15;
            label8.Text = "Session Time:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(189, 165);
            label9.Name = "label9";
            label9.Size = new Size(98, 32);
            label9.TabIndex = 16;
            label9.Text = "HH:mm";
            // 
            // Form_Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 583);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}