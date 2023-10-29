namespace MovieTicketApp
{
    partial class Form_UpdateBookings
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
            textBox_Poster = new TextBox();
            label12 = new Label();
            label10 = new Label();
            btn_DeleteMovie = new Button();
            label7 = new Label();
            label6 = new Label();
            btn_CreateMovie = new Button();
            textBox_Description = new TextBox();
            textBox_Genre = new TextBox();
            textBox_Title = new TextBox();
            textBox_MovieID = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_UpdateMovie = new Button();
            button1 = new Button();
            bookingGrid = new DataGridView();
            label8 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookingGrid).BeginInit();
            SuspendLayout();
            // 
            // textBox_Poster
            // 
            textBox_Poster.Location = new Point(353, 69);
            textBox_Poster.Name = "textBox_Poster";
            textBox_Poster.Size = new Size(102, 23);
            textBox_Poster.TabIndex = 72;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(296, 73);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 71;
            label12.Text = "Movie ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 121);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 69;
            label10.Text = "Number of Attendees";
            // 
            // btn_DeleteMovie
            // 
            btn_DeleteMovie.Location = new Point(485, 200);
            btn_DeleteMovie.Name = "btn_DeleteMovie";
            btn_DeleteMovie.Size = new Size(161, 23);
            btn_DeleteMovie.TabIndex = 65;
            btn_DeleteMovie.Text = "Delete Selected Booking";
            btn_DeleteMovie.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.CausesValidation = false;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(106, 93);
            label7.Name = "label7";
            label7.Size = new Size(177, 13);
            label7.TabIndex = 64;
            label7.Text = "ID auto-generated for new bookings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 136);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 63;
            // 
            // btn_CreateMovie
            // 
            btn_CreateMovie.Location = new Point(159, 200);
            btn_CreateMovie.Name = "btn_CreateMovie";
            btn_CreateMovie.Size = new Size(129, 23);
            btn_CreateMovie.TabIndex = 62;
            btn_CreateMovie.Text = "Create New Booking";
            btn_CreateMovie.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_CreateMovie.UseVisualStyleBackColor = true;
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(159, 118);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(114, 23);
            textBox_Description.TabIndex = 61;
            // 
            // textBox_Genre
            // 
            textBox_Genre.Location = new Point(536, 69);
            textBox_Genre.Name = "textBox_Genre";
            textBox_Genre.Size = new Size(165, 23);
            textBox_Genre.TabIndex = 60;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(376, 117);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(189, 23);
            textBox_Title.TabIndex = 58;
            // 
            // textBox_MovieID
            // 
            textBox_MovieID.CausesValidation = false;
            textBox_MovieID.Location = new Point(178, 69);
            textBox_MovieID.Name = "textBox_MovieID";
            textBox_MovieID.ReadOnly = true;
            textBox_MovieID.Size = new Size(93, 23);
            textBox_MovieID.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 74);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 55;
            label4.Text = "Session";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 121);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 53;
            label2.Text = "Seats Booked";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(106, 72);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 52;
            label1.Text = "Booking ID";
            // 
            // btn_UpdateMovie
            // 
            btn_UpdateMovie.Location = new Point(325, 200);
            btn_UpdateMovie.Name = "btn_UpdateMovie";
            btn_UpdateMovie.RightToLeft = RightToLeft.Yes;
            btn_UpdateMovie.Size = new Size(129, 23);
            btn_UpdateMovie.TabIndex = 51;
            btn_UpdateMovie.Text = "Update Booking";
            btn_UpdateMovie.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_UpdateMovie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(29, 27);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 50;
            button1.Text = "Exit";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bookingGrid
            // 
            bookingGrid.AllowUserToAddRows = false;
            bookingGrid.AllowUserToDeleteRows = false;
            bookingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingGrid.Location = new Point(29, 240);
            bookingGrid.Name = "bookingGrid";
            bookingGrid.ReadOnly = true;
            bookingGrid.RowTemplate.Height = 25;
            bookingGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookingGrid.Size = new Size(742, 200);
            bookingGrid.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(286, 11);
            label8.Name = "label8";
            label8.Size = new Size(265, 40);
            label8.TabIndex = 48;
            label8.Text = "Manage Bookings";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(637, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 74;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(588, 122);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 73;
            label11.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 159);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 76;
            label3.Text = "Ticket Type";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 75;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(470, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 160);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 77;
            label5.Text = "Subtotal";
            // 
            // Form_UpdateBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(textBox_Poster);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(btn_DeleteMovie);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_CreateMovie);
            Controls.Add(textBox_Description);
            Controls.Add(textBox_Genre);
            Controls.Add(textBox_Title);
            Controls.Add(textBox_MovieID);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_UpdateMovie);
            Controls.Add(button1);
            Controls.Add(bookingGrid);
            Controls.Add(label8);
            Name = "Form_UpdateBookings";
            Text = "Form_UpdateBookings";
            ((System.ComponentModel.ISupportInitialize)bookingGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Poster;
        private Label label12;
        private Label label10;
        private Button btn_DeleteMovie;
        private Label label7;
        private Label label6;
        private Button btn_CreateMovie;
        private TextBox textBox_Description;
        private TextBox textBox_Genre;
        private TextBox textBox_Title;
        private TextBox textBox_MovieID;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btn_UpdateMovie;
        private Button button1;
        private DataGridView bookingGrid;
        private Label label8;
        private TextBox textBox1;
        private Label label11;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
    }
}