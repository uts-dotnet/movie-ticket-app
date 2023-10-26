namespace MovieTicketApp
{
    partial class frm_Movies
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
            btn_Profile = new Button();
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
            picbox_Movie_Poster.Location = new Point(248, 113);
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
            // btn_Profile
            // 
            btn_Profile.BackColor = Color.Firebrick;
            btn_Profile.ForeColor = Color.WhiteSmoke;
            btn_Profile.Location = new Point(655, 54);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(102, 23);
            btn_Profile.TabIndex = 10;
            btn_Profile.Text = "View Profile";
            btn_Profile.UseVisualStyleBackColor = false;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // frm_Movies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Profile);
            Controls.Add(lbl_Movie_Release_Date);
            Controls.Add(txt_Movie_Description);
            Controls.Add(lbl_Movie_Duration_Genre);
            Controls.Add(lbl_Movie_Title);
            Controls.Add(picbox_Movie_Poster);
            Controls.Add(lbl_Title_Login);
            Controls.Add(listbox_Movies);
            Name = "frm_Movies";
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
        private Button btn_Profile;
    }
}