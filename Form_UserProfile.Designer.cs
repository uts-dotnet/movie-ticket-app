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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lbl_FirstName = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(251, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 289);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.BackColor = Color.Firebrick;
            lbl_FirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FirstName.ForeColor = SystemColors.ButtonFace;
            lbl_FirstName.Location = new Point(39, 41);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(69, 21);
            lbl_FirstName.TabIndex = 13;
            lbl_FirstName.Text = "Go Back";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(553, 130);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 19;
            label4.Text = "Change Password";
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
            // Form_UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lbl_FirstName);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_UserProfile";
            Text = "Form1";
            Load += Form_UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Label label1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lbl_FirstName;
        private Label label4;
        private Label label3;
    }
}