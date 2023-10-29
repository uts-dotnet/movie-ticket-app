namespace MovieTicketApp
{
    partial class Form_Movies
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
            listbox_Movies = new ListBox();
            lbl_Title_Login = new Label();
            picbox_Movie_Poster = new PictureBox();
            lbl_Movie_Title = new Label();
            lbl_Movie_Duration_Genre = new Label();
            txt_Movie_Description = new TextBox();
            lbl_Movie_Release_Date = new Label();
            lbl_Sessions = new Label();
            btn_Session_Time_1 = new Button();
            btn_Session_Time_2 = new Button();
            btn_Session_Time_3 = new Button();
            btn_Session_Time_4 = new Button();
            btn_Session_Time_5 = new Button();
            btn_Log_Out = new Button();
            btn_UserProfile = new Button();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox_Movie_Poster).BeginInit();
            SuspendLayout();
            // 
            // listbox_Movies
            // 
            listbox_Movies.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            listbox_Movies.FormattingEnabled = true;
            listbox_Movies.ItemHeight = 20;
            listbox_Movies.Location = new Point(19, 113);
            listbox_Movies.Name = "listbox_Movies";
            listbox_Movies.Size = new Size(207, 304);
            listbox_Movies.TabIndex = 0;
            listbox_Movies.SelectedIndexChanged += listbox_Movies_SelectedIndexChanged;
            // 
            // lbl_Title_Login
            // 
            lbl_Title_Login.AutoSize = true;
            lbl_Title_Login.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_Login.ForeColor = Color.Firebrick;
            lbl_Title_Login.Location = new Point(12, 38);
            lbl_Title_Login.Name = "lbl_Title_Login";
            lbl_Title_Login.Size = new Size(207, 40);
            lbl_Title_Login.TabIndex = 3;
            lbl_Title_Login.Text = "Now Showing";
            // 
            // picbox_Movie_Poster
            // 
            picbox_Movie_Poster.Location = new Point(268, 113);
            picbox_Movie_Poster.MaximumSize = new Size(150, 200);
            picbox_Movie_Poster.Name = "picbox_Movie_Poster";
            picbox_Movie_Poster.Size = new Size(150, 200);
            picbox_Movie_Poster.SizeMode = PictureBoxSizeMode.AutoSize;
            picbox_Movie_Poster.TabIndex = 4;
            picbox_Movie_Poster.TabStop = false;
            // 
            // lbl_Movie_Title
            // 
            lbl_Movie_Title.AutoSize = true;
            lbl_Movie_Title.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie_Title.Location = new Point(442, 105);
            lbl_Movie_Title.Name = "lbl_Movie_Title";
            lbl_Movie_Title.Size = new Size(49, 25);
            lbl_Movie_Title.TabIndex = 5;
            lbl_Movie_Title.Text = "Title";
            // 
            // lbl_Movie_Duration_Genre
            // 
            lbl_Movie_Duration_Genre.AutoSize = true;
            lbl_Movie_Duration_Genre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Movie_Duration_Genre.Location = new Point(445, 177);
            lbl_Movie_Duration_Genre.Name = "lbl_Movie_Duration_Genre";
            lbl_Movie_Duration_Genre.Size = new Size(100, 17);
            lbl_Movie_Duration_Genre.TabIndex = 7;
            lbl_Movie_Duration_Genre.Text = "Duration, Genre";
            // 
            // txt_Movie_Description
            // 
            txt_Movie_Description.BackColor = SystemColors.Control;
            txt_Movie_Description.BorderStyle = BorderStyle.None;
            txt_Movie_Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Movie_Description.Location = new Point(445, 209);
            txt_Movie_Description.Multiline = true;
            txt_Movie_Description.Name = "txt_Movie_Description";
            txt_Movie_Description.Size = new Size(312, 104);
            txt_Movie_Description.TabIndex = 8;
            txt_Movie_Description.Text = "Description";
            // 
            // lbl_Movie_Release_Date
            // 
            lbl_Movie_Release_Date.AutoSize = true;
            lbl_Movie_Release_Date.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Movie_Release_Date.Location = new Point(445, 144);
            lbl_Movie_Release_Date.Name = "lbl_Movie_Release_Date";
            lbl_Movie_Release_Date.Size = new Size(191, 17);
            lbl_Movie_Release_Date.TabIndex = 9;
            lbl_Movie_Release_Date.Text = "Released on (Day, Month, Year)";
            // 
            // lbl_Sessions
            // 
            lbl_Sessions.AutoSize = true;
            lbl_Sessions.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Sessions.Location = new Point(268, 337);
            lbl_Sessions.Name = "lbl_Sessions";
            lbl_Sessions.Size = new Size(83, 25);
            lbl_Sessions.TabIndex = 11;
            lbl_Sessions.Text = "Sessions";
            // 
            // btn_Session_Time_1
            // 
            btn_Session_Time_1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Session_Time_1.Location = new Point(266, 381);
            btn_Session_Time_1.Name = "btn_Session_Time_1";
            btn_Session_Time_1.Size = new Size(85, 36);
            btn_Session_Time_1.TabIndex = 12;
            btn_Session_Time_1.Text = "HH:mm";
            btn_Session_Time_1.UseVisualStyleBackColor = true;
            // 
            // btn_Session_Time_2
            // 
            btn_Session_Time_2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Session_Time_2.Location = new Point(372, 381);
            btn_Session_Time_2.Name = "btn_Session_Time_2";
            btn_Session_Time_2.Size = new Size(85, 36);
            btn_Session_Time_2.TabIndex = 13;
            btn_Session_Time_2.Text = "HH:mm";
            btn_Session_Time_2.UseVisualStyleBackColor = true;
            // 
            // btn_Session_Time_3
            // 
            btn_Session_Time_3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Session_Time_3.Location = new Point(478, 381);
            btn_Session_Time_3.Name = "btn_Session_Time_3";
            btn_Session_Time_3.Size = new Size(85, 36);
            btn_Session_Time_3.TabIndex = 14;
            btn_Session_Time_3.Text = "HH:mm";
            btn_Session_Time_3.UseVisualStyleBackColor = true;
            // 
            // btn_Session_Time_4
            // 
            btn_Session_Time_4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Session_Time_4.Location = new Point(584, 381);
            btn_Session_Time_4.Name = "btn_Session_Time_4";
            btn_Session_Time_4.Size = new Size(85, 36);
            btn_Session_Time_4.TabIndex = 15;
            btn_Session_Time_4.Text = "HH:mm";
            btn_Session_Time_4.UseVisualStyleBackColor = true;
            // 
            // btn_Session_Time_5
            // 
            btn_Session_Time_5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Session_Time_5.Location = new Point(690, 381);
            btn_Session_Time_5.Name = "btn_Session_Time_5";
            btn_Session_Time_5.Size = new Size(85, 36);
            btn_Session_Time_5.TabIndex = 16;
            btn_Session_Time_5.Text = "HH:mm";
            btn_Session_Time_5.UseVisualStyleBackColor = true;
            // 
            // btn_Log_Out
            // 
            btn_Log_Out.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Log_Out.ForeColor = Color.Firebrick;
            btn_Log_Out.Location = new Point(688, 45);
            btn_Log_Out.Name = "btn_Log_Out";
            btn_Log_Out.Size = new Size(87, 33);
            btn_Log_Out.TabIndex = 17;
            btn_Log_Out.Text = "Log Out";
            btn_Log_Out.UseVisualStyleBackColor = true;
            btn_Log_Out.Click += btn_Log_Out_Click;
            // 
            // btn_UserProfile
            // 
            btn_UserProfile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UserProfile.ForeColor = Color.Firebrick;
            btn_UserProfile.Location = new Point(595, 45);
            btn_UserProfile.Name = "btn_UserProfile";
            btn_UserProfile.Size = new Size(87, 33);
            btn_UserProfile.TabIndex = 18;
            btn_UserProfile.Text = "Profile";
            btn_UserProfile.UseVisualStyleBackColor = true;
            btn_UserProfile.Click += btn_UserProfile_Click_1;
            // 
            // Exit
            // 
            Exit.Location = new Point(595, 93);
            Exit.Name = "Exit";
            Exit.Size = new Size(170, 23);
            Exit.TabIndex = 20;
            Exit.Text = "Exit and Save Changes";
            Exit.UseVisualStyleBackColor = true;
            Exit.Visible = false;
            Exit.Click += Exit_Click;
            // 
            // Form_Movies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(Exit);
            Controls.Add(btn_UserProfile);
            Controls.Add(btn_Log_Out);
            Controls.Add(btn_Session_Time_5);
            Controls.Add(btn_Session_Time_4);
            Controls.Add(btn_Session_Time_3);
            Controls.Add(btn_Session_Time_2);
            Controls.Add(btn_Session_Time_1);
            Controls.Add(lbl_Sessions);
            Controls.Add(lbl_Movie_Release_Date);
            Controls.Add(txt_Movie_Description);
            Controls.Add(lbl_Movie_Duration_Genre);
            Controls.Add(lbl_Movie_Title);
            Controls.Add(picbox_Movie_Poster);
            Controls.Add(lbl_Title_Login);
            Controls.Add(listbox_Movies);
            Name = "Form_Movies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movies | DOTNET Cinemas";
            ((System.ComponentModel.ISupportInitialize)picbox_Movie_Poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_Movies;
        private Label lbl_Title_Login;
        private PictureBox picbox_Movie_Poster;
        private Label lbl_Movie_Title;
        private Label lbl_Movie_Duration_Genre;
        private TextBox txt_Movie_Description;
        private Label lbl_Movie_Release_Date;
        private Label lbl_Sessions;
        private Button btn_Session_Time_1;
        private Button btn_Session_Time_2;
        private Button btn_Session_Time_3;
        private Button btn_Session_Time_4;
        private Button btn_Session_Time_5;
        private Button btn_Log_Out;
        private Button Exit;
        private Button btn_UserProfile;
    }
}