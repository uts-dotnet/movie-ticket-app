﻿namespace MovieTicketApp
{
    partial class Form_UserProfile
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
            lbl_Title_SignUp = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            pic_Ticket = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btn_GoToChangePW = new Button();
            btn_BackToMovies = new Button();
            lbl_MovieName = new Label();
            lbl_MovieTime = new Label();
            lbl_Seats = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Ticket).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(311, 26);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(178, 40);
            lbl_Title_SignUp.TabIndex = 1;
            lbl_Title_SignUp.Text = "User Profile\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 106);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(39, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(192, 289);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pic_Ticket
            // 
            pic_Ticket.Location = new Point(251, 130);
            pic_Ticket.Name = "pic_Ticket";
            pic_Ticket.Size = new Size(238, 289);
            pic_Ticket.TabIndex = 16;
            pic_Ticket.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 106);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 17;
            label2.Text = "View Bookings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 66);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 20;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_GoToChangePW
            // 
            btn_GoToChangePW.Location = new Point(575, 130);
            btn_GoToChangePW.Name = "btn_GoToChangePW";
            btn_GoToChangePW.Size = new Size(143, 23);
            btn_GoToChangePW.TabIndex = 21;
            btn_GoToChangePW.Text = "Change Password";
            btn_GoToChangePW.UseVisualStyleBackColor = true;
            // 
            // btn_BackToMovies
            // 
            btn_BackToMovies.Location = new Point(45, 30);
            btn_BackToMovies.Name = "btn_BackToMovies";
            btn_BackToMovies.Size = new Size(75, 23);
            btn_BackToMovies.TabIndex = 22;
            btn_BackToMovies.Text = "Go Back";
            btn_BackToMovies.UseVisualStyleBackColor = true;
            btn_BackToMovies.Click += btn_BackToMovies_Click;
            // 
            // lbl_MovieName
            // 
            lbl_MovieName.AutoSize = true;
            lbl_MovieName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MovieName.Location = new Point(311, 221);
            lbl_MovieName.Name = "lbl_MovieName";
            lbl_MovieName.Size = new Size(123, 25);
            lbl_MovieName.TabIndex = 23;
            lbl_MovieName.Text = "Movie Name";
            // 
            // lbl_MovieTime
            // 
            lbl_MovieTime.AutoSize = true;
            lbl_MovieTime.Location = new Point(331, 260);
            lbl_MovieTime.Name = "lbl_MovieTime";
            lbl_MovieTime.Size = new Size(53, 15);
            lbl_MovieTime.TabIndex = 24;
            lbl_MovieTime.Text = "Time: XX";
            // 
            // lbl_Seats
            // 
            lbl_Seats.AutoSize = true;
            lbl_Seats.Location = new Point(331, 287);
            lbl_Seats.Name = "lbl_Seats";
            lbl_Seats.Size = new Size(62, 15);
            lbl_Seats.TabIndex = 25;
            lbl_Seats.Text = "Seat(s): XX";
            lbl_Seats.UseWaitCursor = true;
            // 
            // Form_UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Seats);
            Controls.Add(lbl_MovieTime);
            Controls.Add(lbl_MovieName);
            Controls.Add(btn_BackToMovies);
            Controls.Add(btn_GoToChangePW);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pic_Ticket);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_UserProfile";
            Text = "Form1";
            Load += Form_UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Ticket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Label label1;
        private ListBox listBox1;
        private PictureBox pic_Ticket;
        private Label label2;
        private Label btn_ChangePW;
        private Label label3;
        private Button btn_GoToChangePW;
        private Button btn_BackToMovies;
        private Label lbl_MovieName;
        private Label lbl_MovieTime;
        private Label lbl_Seats;
    }
}