namespace MovieTicketApp
{
    partial class Form_Confirm_Booking
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
            lbl_Title_Select_Ticket = new Label();
            lbl_Movie = new Label();
            lbl_Movie_Title = new Label();
            lbl_Session = new Label();
            lbl_Session_Time = new Label();
            lbl_Ticket = new Label();
            lbl_Ticket_Type = new Label();
            lbl_Ticket_Price = new Label();
            lbl_Ticket_Price_Value = new Label();
            lbl_Quantity = new Label();
            lbl_Quantity_Value = new Label();
            lbl_Subtotal = new Label();
            lbl_Subtotal_Value = new Label();
            btn_Checkout = new Button();
            picbox_Poster_Booking = new PictureBox();
            listBox_Seats = new ListBox();
            lbl_Booked_Seats = new Label();
            lbl_Booked_Seats_Value = new Label();
            btn_Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox_Poster_Booking).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title_Select_Ticket
            // 
            lbl_Title_Select_Ticket.AutoSize = true;
            lbl_Title_Select_Ticket.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_Select_Ticket.ForeColor = Color.Firebrick;
            lbl_Title_Select_Ticket.Location = new Point(164, 38);
            lbl_Title_Select_Ticket.Name = "lbl_Title_Select_Ticket";
            lbl_Title_Select_Ticket.Size = new Size(323, 40);
            lbl_Title_Select_Ticket.TabIndex = 5;
            lbl_Title_Select_Ticket.Text = "Confirm Your Booking";
            // 
            // lbl_Movie
            // 
            lbl_Movie.AutoSize = true;
            lbl_Movie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie.Location = new Point(210, 122);
            lbl_Movie.Name = "lbl_Movie";
            lbl_Movie.Size = new Size(60, 21);
            lbl_Movie.TabIndex = 6;
            lbl_Movie.Text = "Movie:";
            // 
            // lbl_Movie_Title
            // 
            lbl_Movie_Title.AutoSize = true;
            lbl_Movie_Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie_Title.ForeColor = Color.Firebrick;
            lbl_Movie_Title.Location = new Point(269, 122);
            lbl_Movie_Title.Name = "lbl_Movie_Title";
            lbl_Movie_Title.Size = new Size(92, 21);
            lbl_Movie_Title.TabIndex = 7;
            lbl_Movie_Title.Text = "Movie Title";
            // 
            // lbl_Session
            // 
            lbl_Session.AutoSize = true;
            lbl_Session.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Session.Location = new Point(210, 152);
            lbl_Session.Name = "lbl_Session";
            lbl_Session.Size = new Size(109, 21);
            lbl_Session.TabIndex = 8;
            lbl_Session.Text = "Session Time:";
            // 
            // lbl_Session_Time
            // 
            lbl_Session_Time.AutoSize = true;
            lbl_Session_Time.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Session_Time.ForeColor = Color.Firebrick;
            lbl_Session_Time.Location = new Point(315, 152);
            lbl_Session_Time.Name = "lbl_Session_Time";
            lbl_Session_Time.Size = new Size(66, 21);
            lbl_Session_Time.TabIndex = 9;
            lbl_Session_Time.Text = "HH:mm";
            // 
            // lbl_Ticket
            // 
            lbl_Ticket.AutoSize = true;
            lbl_Ticket.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket.Location = new Point(210, 182);
            lbl_Ticket.Name = "lbl_Ticket";
            lbl_Ticket.Size = new Size(58, 21);
            lbl_Ticket.TabIndex = 10;
            lbl_Ticket.Text = "Ticket:";
            // 
            // lbl_Ticket_Type
            // 
            lbl_Ticket_Type.AutoSize = true;
            lbl_Ticket_Type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Type.ForeColor = Color.Firebrick;
            lbl_Ticket_Type.Location = new Point(265, 182);
            lbl_Ticket_Type.Name = "lbl_Ticket_Type";
            lbl_Ticket_Type.Size = new Size(54, 21);
            lbl_Ticket_Type.TabIndex = 11;
            lbl_Ticket_Type.Text = "Ticket";
            // 
            // lbl_Ticket_Price
            // 
            lbl_Ticket_Price.AutoSize = true;
            lbl_Ticket_Price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Price.Location = new Point(210, 214);
            lbl_Ticket_Price.Name = "lbl_Ticket_Price";
            lbl_Ticket_Price.Size = new Size(50, 21);
            lbl_Ticket_Price.TabIndex = 12;
            lbl_Ticket_Price.Text = "Price:";
            // 
            // lbl_Ticket_Price_Value
            // 
            lbl_Ticket_Price_Value.AutoSize = true;
            lbl_Ticket_Price_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Price_Value.ForeColor = Color.Firebrick;
            lbl_Ticket_Price_Value.Location = new Point(258, 215);
            lbl_Ticket_Price_Value.Name = "lbl_Ticket_Price_Value";
            lbl_Ticket_Price_Value.Size = new Size(59, 21);
            lbl_Ticket_Price_Value.TabIndex = 13;
            lbl_Ticket_Price_Value.Text = "$00.00";
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Quantity.Location = new Point(209, 245);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(76, 21);
            lbl_Quantity.TabIndex = 14;
            lbl_Quantity.Text = "Quantity:";
            // 
            // lbl_Quantity_Value
            // 
            lbl_Quantity_Value.AutoSize = true;
            lbl_Quantity_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Quantity_Value.ForeColor = Color.Firebrick;
            lbl_Quantity_Value.Location = new Point(281, 245);
            lbl_Quantity_Value.Name = "lbl_Quantity_Value";
            lbl_Quantity_Value.Size = new Size(19, 21);
            lbl_Quantity_Value.TabIndex = 15;
            lbl_Quantity_Value.Text = "0";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(209, 301);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(89, 25);
            lbl_Subtotal.TabIndex = 16;
            lbl_Subtotal.Text = "Subtotal:";
            // 
            // lbl_Subtotal_Value
            // 
            lbl_Subtotal_Value.AutoSize = true;
            lbl_Subtotal_Value.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal_Value.ForeColor = Color.Firebrick;
            lbl_Subtotal_Value.Location = new Point(296, 301);
            lbl_Subtotal_Value.Name = "lbl_Subtotal_Value";
            lbl_Subtotal_Value.Size = new Size(72, 25);
            lbl_Subtotal_Value.TabIndex = 17;
            lbl_Subtotal_Value.Text = "$00.00";
            // 
            // btn_Checkout
            // 
            btn_Checkout.BackColor = Color.Firebrick;
            btn_Checkout.Cursor = Cursors.Hand;
            btn_Checkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Checkout.ForeColor = Color.White;
            btn_Checkout.Location = new Point(181, 379);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(288, 42);
            btn_Checkout.TabIndex = 18;
            btn_Checkout.Text = "Checkout";
            btn_Checkout.UseVisualStyleBackColor = false;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // picbox_Poster_Booking
            // 
            picbox_Poster_Booking.Location = new Point(31, 122);
            picbox_Poster_Booking.Name = "picbox_Poster_Booking";
            picbox_Poster_Booking.Size = new Size(150, 200);
            picbox_Poster_Booking.TabIndex = 19;
            picbox_Poster_Booking.TabStop = false;
            // 
            // listBox_Seats
            // 
            listBox_Seats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_Seats.FormattingEnabled = true;
            listBox_Seats.ItemHeight = 20;
            listBox_Seats.Location = new Point(471, 158);
            listBox_Seats.Name = "listBox_Seats";
            listBox_Seats.Size = new Size(150, 164);
            listBox_Seats.TabIndex = 20;
            // 
            // lbl_Booked_Seats
            // 
            lbl_Booked_Seats.AutoSize = true;
            lbl_Booked_Seats.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Booked_Seats.Location = new Point(471, 122);
            lbl_Booked_Seats.Name = "lbl_Booked_Seats";
            lbl_Booked_Seats.Size = new Size(114, 21);
            lbl_Booked_Seats.TabIndex = 21;
            lbl_Booked_Seats.Text = "Booked Seats:";
            // 
            // lbl_Booked_Seats_Value
            // 
            lbl_Booked_Seats_Value.AutoSize = true;
            lbl_Booked_Seats_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Booked_Seats_Value.ForeColor = Color.Firebrick;
            lbl_Booked_Seats_Value.Location = new Point(582, 122);
            lbl_Booked_Seats_Value.Name = "lbl_Booked_Seats_Value";
            lbl_Booked_Seats_Value.Size = new Size(19, 21);
            lbl_Booked_Seats_Value.TabIndex = 22;
            lbl_Booked_Seats_Value.Text = "0";
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.Firebrick;
            btn_Logout.Location = new Point(532, 43);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(89, 35);
            btn_Logout.TabIndex = 23;
            btn_Logout.Text = "Log Out";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // Form_Confirm_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 447);
            Controls.Add(btn_Logout);
            Controls.Add(lbl_Booked_Seats_Value);
            Controls.Add(lbl_Booked_Seats);
            Controls.Add(listBox_Seats);
            Controls.Add(picbox_Poster_Booking);
            Controls.Add(btn_Checkout);
            Controls.Add(lbl_Subtotal_Value);
            Controls.Add(lbl_Subtotal);
            Controls.Add(lbl_Quantity_Value);
            Controls.Add(lbl_Quantity);
            Controls.Add(lbl_Ticket_Price_Value);
            Controls.Add(lbl_Ticket_Price);
            Controls.Add(lbl_Ticket_Type);
            Controls.Add(lbl_Ticket);
            Controls.Add(lbl_Session_Time);
            Controls.Add(lbl_Session);
            Controls.Add(lbl_Movie_Title);
            Controls.Add(lbl_Movie);
            Controls.Add(lbl_Title_Select_Ticket);
            Name = "Form_Confirm_Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm Booking | DOTNET Cinemas";
            ((System.ComponentModel.ISupportInitialize)picbox_Poster_Booking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_Select_Ticket;
        private Label lbl_Movie;
        private Label lbl_Movie_Title;
        private Label lbl_Session;
        private Label lbl_Session_Time;
        private Label lbl_Ticket;
        private Label lbl_Ticket_Type;
        private Label lbl_Ticket_Price;
        private Label lbl_Ticket_Price_Value;
        private Label lbl_Quantity;
        private Label lbl_Quantity_Value;
        private Label lbl_Subtotal;
        private Label lbl_Subtotal_Value;
        private Button btn_Checkout;
        private PictureBox picbox_Poster_Booking;
        private ListBox listBox_Seats;
        private Label lbl_Booked_Seats;
        private Label lbl_Booked_Seats_Value;
        private Button btn_Logout;
    }
}