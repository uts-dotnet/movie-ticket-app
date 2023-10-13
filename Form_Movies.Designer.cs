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
            // frm_Movies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picbox_Movie_Poster);
            Controls.Add(lbl_Title_Login);
            Controls.Add(listbox_Movies);
            Name = "frm_Movies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Movies";
            ((System.ComponentModel.ISupportInitialize)picbox_Movie_Poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_Movies;
        private Label lbl_Title_Login;
        private PictureBox picbox_Movie_Poster;
    }
}