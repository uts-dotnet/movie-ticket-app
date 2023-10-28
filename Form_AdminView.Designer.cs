﻿namespace MovieTicketApp
{
    partial class Form_AdminView
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
            btn_EditUser = new Button();
            btn_EditMovie = new Button();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(311, 40);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(189, 40);
            lbl_Title_SignUp.TabIndex = 3;
            lbl_Title_SignUp.Text = "Admin Tasks";
            // 
            // btn_EditUser
            // 
            btn_EditUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EditUser.Location = new Point(294, 150);
            btn_EditUser.Name = "btn_EditUser";
            btn_EditUser.Size = new Size(219, 39);
            btn_EditUser.TabIndex = 6;
            btn_EditUser.Text = "Manage Users";
            btn_EditUser.UseVisualStyleBackColor = true;
            btn_EditUser.Click += btn_EditUser_Click_1;
            // 
            // btn_EditMovie
            // 
            btn_EditMovie.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EditMovie.Location = new Point(294, 209);
            btn_EditMovie.Name = "btn_EditMovie";
            btn_EditMovie.Size = new Size(219, 40);
            btn_EditMovie.TabIndex = 9;
            btn_EditMovie.Text = "Manage Movies";
            btn_EditMovie.UseVisualStyleBackColor = true;
            btn_EditMovie.Click += btn_EditMovie_Click;
            // 
            // Form_AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_EditMovie);
            Controls.Add(btn_EditUser);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_AdminView";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Button btn_Back;
        private Button btn_AddUser;
        private Button btn_EditUser;
        private Button btn_AddMovie;
        private Button btn_EditMovie;
        private Label label5;
        private Label label1;
    }
}