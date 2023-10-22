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
            button1 = new Button();
            picbox_Poster_Booking = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbox_Poster_Booking).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title_Select_Ticket
            // 
            lbl_Title_Select_Ticket.AutoSize = true;
            lbl_Title_Select_Ticket.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_Select_Ticket.ForeColor = Color.Firebrick;
            lbl_Title_Select_Ticket.Location = new Point(154, 38);
            lbl_Title_Select_Ticket.Name = "lbl_Title_Select_Ticket";
            lbl_Title_Select_Ticket.Size = new Size(323, 40);
            lbl_Title_Select_Ticket.TabIndex = 5;
            lbl_Title_Select_Ticket.Text = "Confirm Your Booking";
            // 
            // lbl_Movie
            // 
            lbl_Movie.AutoSize = true;
            lbl_Movie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie.Location = new Point(210, 120);
            lbl_Movie.Name = "lbl_Movie";
            lbl_Movie.Size = new Size(60, 21);
            lbl_Movie.TabIndex = 6;
            lbl_Movie.Text = "Movie:";
            // 
            // lbl_Movie_Title
            // 
            lbl_Movie_Title.AutoSize = true;
            lbl_Movie_Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie_Title.Location = new Point(278, 120);
            lbl_Movie_Title.Name = "lbl_Movie_Title";
            lbl_Movie_Title.Size = new Size(92, 21);
            lbl_Movie_Title.TabIndex = 7;
            lbl_Movie_Title.Text = "Movie Title";
            // 
            // lbl_Session
            // 
            lbl_Session.AutoSize = true;
            lbl_Session.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Session.Location = new Point(210, 151);
            lbl_Session.Name = "lbl_Session";
            lbl_Session.Size = new Size(109, 21);
            lbl_Session.TabIndex = 8;
            lbl_Session.Text = "Session Time:";
            // 
            // lbl_Session_Time
            // 
            lbl_Session_Time.AutoSize = true;
            lbl_Session_Time.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Session_Time.Location = new Point(325, 151);
            lbl_Session_Time.Name = "lbl_Session_Time";
            lbl_Session_Time.Size = new Size(66, 21);
            lbl_Session_Time.TabIndex = 9;
            lbl_Session_Time.Text = "HH:mm";
            // 
            // lbl_Ticket
            // 
            lbl_Ticket.AutoSize = true;
            lbl_Ticket.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket.Location = new Point(210, 183);
            lbl_Ticket.Name = "lbl_Ticket";
            lbl_Ticket.Size = new Size(97, 21);
            lbl_Ticket.TabIndex = 10;
            lbl_Ticket.Text = "Ticket Type:";
            // 
            // lbl_Ticket_Type
            // 
            lbl_Ticket_Type.AutoSize = true;
            lbl_Ticket_Type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Type.Location = new Point(313, 183);
            lbl_Ticket_Type.Name = "lbl_Ticket_Type";
            lbl_Ticket_Type.Size = new Size(54, 21);
            lbl_Ticket_Type.TabIndex = 11;
            lbl_Ticket_Type.Text = "Ticket";
            // 
            // lbl_Ticket_Price
            // 
            lbl_Ticket_Price.AutoSize = true;
            lbl_Ticket_Price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Price.Location = new Point(210, 217);
            lbl_Ticket_Price.Name = "lbl_Ticket_Price";
            lbl_Ticket_Price.Size = new Size(98, 21);
            lbl_Ticket_Price.TabIndex = 12;
            lbl_Ticket_Price.Text = "Ticket Price:";
            // 
            // lbl_Ticket_Price_Value
            // 
            lbl_Ticket_Price_Value.AutoSize = true;
            lbl_Ticket_Price_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Price_Value.Location = new Point(313, 217);
            lbl_Ticket_Price_Value.Name = "lbl_Ticket_Price_Value";
            lbl_Ticket_Price_Value.Size = new Size(59, 21);
            lbl_Ticket_Price_Value.TabIndex = 13;
            lbl_Ticket_Price_Value.Text = "$00.00";
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Quantity.Location = new Point(210, 251);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(76, 21);
            lbl_Quantity.TabIndex = 14;
            lbl_Quantity.Text = "Quantity:";
            // 
            // lbl_Quantity_Value
            // 
            lbl_Quantity_Value.AutoSize = true;
            lbl_Quantity_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Quantity_Value.Location = new Point(288, 251);
            lbl_Quantity_Value.Name = "lbl_Quantity_Value";
            lbl_Quantity_Value.Size = new Size(19, 21);
            lbl_Quantity_Value.TabIndex = 15;
            lbl_Quantity_Value.Text = "0";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(210, 286);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(76, 21);
            lbl_Subtotal.TabIndex = 16;
            lbl_Subtotal.Text = "Subtotal:";
            // 
            // lbl_Subtotal_Value
            // 
            lbl_Subtotal_Value.AutoSize = true;
            lbl_Subtotal_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal_Value.Location = new Point(292, 286);
            lbl_Subtotal_Value.Name = "lbl_Subtotal_Value";
            lbl_Subtotal_Value.Size = new Size(59, 21);
            lbl_Subtotal_Value.TabIndex = 17;
            lbl_Subtotal_Value.Text = "$00.00";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(210, 370);
            button1.Name = "button1";
            button1.Size = new Size(267, 42);
            button1.TabIndex = 18;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = false;
            // 
            // picbox_Poster_Booking
            // 
            picbox_Poster_Booking.Location = new Point(29, 121);
            picbox_Poster_Booking.Name = "picbox_Poster_Booking";
            picbox_Poster_Booking.Size = new Size(150, 200);
            picbox_Poster_Booking.TabIndex = 19;
            picbox_Poster_Booking.TabStop = false;
            // 
            // Form_Confirm_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 447);
            Controls.Add(picbox_Poster_Booking);
            Controls.Add(button1);
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
        private Button button1;
        private PictureBox picbox_Poster_Booking;
    }
}