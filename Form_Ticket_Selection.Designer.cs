namespace MovieTicketApp
{
    partial class Form_Ticket_Selection
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
            listView_Session_Tickets = new ListView();
            lbl_Session_Time = new Label();
            lbl_Session_Time_Fomatted = new Label();
            lbl_Ticket_Selected = new Label();
            lbl_Ticket_Price_Value = new Label();
            lbl_Quantity = new Label();
            lbl_Quantity_Value = new Label();
            btn_Decrement = new Button();
            btn_Increment = new Button();
            btn_Continue = new Button();
            lbl_Sub_Total = new Label();
            lbl_Ticket_Price = new Label();
            lbl_Sub_Total_Value = new Label();
            btn_Back = new Button();
            btn_Logout = new Button();
            lbl_Movie = new Label();
            lbl_Movie_Title = new Label();
            SuspendLayout();
            // 
            // lbl_Title_Select_Ticket
            // 
            lbl_Title_Select_Ticket.AutoSize = true;
            lbl_Title_Select_Ticket.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_Select_Ticket.ForeColor = Color.Firebrick;
            lbl_Title_Select_Ticket.Location = new Point(163, 38);
            lbl_Title_Select_Ticket.Name = "lbl_Title_Select_Ticket";
            lbl_Title_Select_Ticket.Size = new Size(259, 40);
            lbl_Title_Select_Ticket.TabIndex = 4;
            lbl_Title_Select_Ticket.Text = "Select Your Ticket";
            // 
            // listView_Session_Tickets
            // 
            listView_Session_Tickets.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            listView_Session_Tickets.FullRowSelect = true;
            listView_Session_Tickets.Location = new Point(17, 176);
            listView_Session_Tickets.MultiSelect = false;
            listView_Session_Tickets.Name = "listView_Session_Tickets";
            listView_Session_Tickets.Size = new Size(263, 232);
            listView_Session_Tickets.TabIndex = 7;
            listView_Session_Tickets.TileSize = new Size(1, 1);
            listView_Session_Tickets.UseCompatibleStateImageBehavior = false;
            listView_Session_Tickets.SelectedIndexChanged += listView_Session_Tickets_SelectedIndexChanged;
            // 
            // lbl_Session_Time
            // 
            lbl_Session_Time.AutoSize = true;
            lbl_Session_Time.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Session_Time.Location = new Point(17, 140);
            lbl_Session_Time.Name = "lbl_Session_Time";
            lbl_Session_Time.Size = new Size(100, 20);
            lbl_Session_Time.TabIndex = 8;
            lbl_Session_Time.Text = "Session Time:";
            // 
            // lbl_Session_Time_Fomatted
            // 
            lbl_Session_Time_Fomatted.AutoSize = true;
            lbl_Session_Time_Fomatted.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Session_Time_Fomatted.ForeColor = Color.Firebrick;
            lbl_Session_Time_Fomatted.Location = new Point(118, 141);
            lbl_Session_Time_Fomatted.Name = "lbl_Session_Time_Fomatted";
            lbl_Session_Time_Fomatted.Size = new Size(61, 20);
            lbl_Session_Time_Fomatted.TabIndex = 9;
            lbl_Session_Time_Fomatted.Text = "HH:mm";
            // 
            // lbl_Ticket_Selected
            // 
            lbl_Ticket_Selected.AutoSize = true;
            lbl_Ticket_Selected.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Selected.Location = new Point(315, 176);
            lbl_Ticket_Selected.Name = "lbl_Ticket_Selected";
            lbl_Ticket_Selected.Size = new Size(154, 21);
            lbl_Ticket_Selected.TabIndex = 10;
            lbl_Ticket_Selected.Text = "Ticket Not Selected";
            // 
            // lbl_Ticket_Price_Value
            // 
            lbl_Ticket_Price_Value.AutoSize = true;
            lbl_Ticket_Price_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Price_Value.Location = new Point(366, 209);
            lbl_Ticket_Price_Value.Name = "lbl_Ticket_Price_Value";
            lbl_Ticket_Price_Value.Size = new Size(59, 21);
            lbl_Ticket_Price_Value.TabIndex = 11;
            lbl_Ticket_Price_Value.Text = "$00.00";
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Quantity.Location = new Point(315, 264);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(76, 21);
            lbl_Quantity.TabIndex = 12;
            lbl_Quantity.Text = "Quantity:";
            // 
            // lbl_Quantity_Value
            // 
            lbl_Quantity_Value.AutoSize = true;
            lbl_Quantity_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Quantity_Value.Location = new Point(448, 265);
            lbl_Quantity_Value.Name = "lbl_Quantity_Value";
            lbl_Quantity_Value.Size = new Size(19, 21);
            lbl_Quantity_Value.TabIndex = 13;
            lbl_Quantity_Value.Text = "0";
            // 
            // btn_Decrement
            // 
            btn_Decrement.BackColor = SystemColors.Control;
            btn_Decrement.FlatStyle = FlatStyle.System;
            btn_Decrement.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Decrement.Location = new Point(404, 260);
            btn_Decrement.Name = "btn_Decrement";
            btn_Decrement.Size = new Size(31, 32);
            btn_Decrement.TabIndex = 14;
            btn_Decrement.Text = "-";
            btn_Decrement.UseVisualStyleBackColor = false;
            btn_Decrement.Click += btn_Decrement_Click;
            // 
            // btn_Increment
            // 
            btn_Increment.FlatStyle = FlatStyle.System;
            btn_Increment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Increment.Location = new Point(480, 260);
            btn_Increment.Name = "btn_Increment";
            btn_Increment.Size = new Size(35, 32);
            btn_Increment.TabIndex = 15;
            btn_Increment.Text = "+";
            btn_Increment.UseVisualStyleBackColor = true;
            btn_Increment.Click += btn_Increment_Click;
            // 
            // btn_Continue
            // 
            btn_Continue.BackColor = Color.Firebrick;
            btn_Continue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Continue.ForeColor = SystemColors.Window;
            btn_Continue.Location = new Point(315, 367);
            btn_Continue.Name = "btn_Continue";
            btn_Continue.Size = new Size(259, 41);
            btn_Continue.TabIndex = 16;
            btn_Continue.Text = "Continue";
            btn_Continue.UseVisualStyleBackColor = false;
            btn_Continue.Click += btn_Continue_Click;
            // 
            // lbl_Sub_Total
            // 
            lbl_Sub_Total.AutoSize = true;
            lbl_Sub_Total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Sub_Total.Location = new Point(316, 320);
            lbl_Sub_Total.Name = "lbl_Sub_Total";
            lbl_Sub_Total.Size = new Size(81, 21);
            lbl_Sub_Total.TabIndex = 17;
            lbl_Sub_Total.Text = "Sub Total:";
            // 
            // lbl_Ticket_Price
            // 
            lbl_Ticket_Price.AutoSize = true;
            lbl_Ticket_Price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ticket_Price.Location = new Point(315, 209);
            lbl_Ticket_Price.Name = "lbl_Ticket_Price";
            lbl_Ticket_Price.Size = new Size(50, 21);
            lbl_Ticket_Price.TabIndex = 18;
            lbl_Ticket_Price.Text = "Price:";
            // 
            // lbl_Sub_Total_Value
            // 
            lbl_Sub_Total_Value.AutoSize = true;
            lbl_Sub_Total_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Sub_Total_Value.Location = new Point(399, 320);
            lbl_Sub_Total_Value.Name = "lbl_Sub_Total_Value";
            lbl_Sub_Total_Value.Size = new Size(59, 21);
            lbl_Sub_Total_Value.TabIndex = 19;
            lbl_Sub_Total_Value.Text = "$00.00";
            // 
            // btn_Back
            // 
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.Firebrick;
            btn_Back.Location = new Point(17, 42);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 35);
            btn_Back.TabIndex = 20;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.Firebrick;
            btn_Logout.Location = new Point(485, 42);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(89, 35);
            btn_Logout.TabIndex = 21;
            btn_Logout.Text = "Log Out";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Log_Out_Click;
            // 
            // lbl_Movie
            // 
            lbl_Movie.AutoSize = true;
            lbl_Movie.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie.Location = new Point(17, 115);
            lbl_Movie.Name = "lbl_Movie";
            lbl_Movie.Size = new Size(56, 20);
            lbl_Movie.TabIndex = 22;
            lbl_Movie.Text = "Movie:";
            // 
            // lbl_Movie_Title
            // 
            lbl_Movie_Title.AutoSize = true;
            lbl_Movie_Title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Movie_Title.ForeColor = Color.Firebrick;
            lbl_Movie_Title.Location = new Point(73, 115);
            lbl_Movie_Title.Name = "lbl_Movie_Title";
            lbl_Movie_Title.Size = new Size(50, 20);
            lbl_Movie_Title.TabIndex = 23;
            lbl_Movie_Title.Text = "Name";
            // 
            // Form_Movie_Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 434);
            Controls.Add(lbl_Movie_Title);
            Controls.Add(lbl_Movie);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Back);
            Controls.Add(lbl_Sub_Total_Value);
            Controls.Add(lbl_Ticket_Price);
            Controls.Add(lbl_Sub_Total);
            Controls.Add(btn_Continue);
            Controls.Add(btn_Increment);
            Controls.Add(btn_Decrement);
            Controls.Add(lbl_Quantity_Value);
            Controls.Add(lbl_Quantity);
            Controls.Add(lbl_Ticket_Price_Value);
            Controls.Add(lbl_Ticket_Selected);
            Controls.Add(lbl_Session_Time_Fomatted);
            Controls.Add(lbl_Session_Time);
            Controls.Add(listView_Session_Tickets);
            Controls.Add(lbl_Title_Select_Ticket);
            Name = "Form_Movie_Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tickets | DOTNET Cinemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_Select_Ticket;
        private ListView listView_Session_Tickets;
        private Label lbl_Session_Time;
        private Label lbl_Session_Time_Fomatted;
        private Label lbl_Ticket_Selected;
        private Label lbl_Ticket_Price_Value;
        private Label lbl_Quantity;
        private Label lbl_Quantity_Value;
        private Button btn_Decrement;
        private Button btn_Increment;
        private Button btn_Continue;
        private Label lbl_Sub_Total;
        private Label lbl_Ticket_Price;
        private Label lbl_Sub_Total_Value;
        private Button btn_Back;
        private Button btn_Logout;
        private Label lbl_Movie;
        private Label lbl_Movie_Title;
    }
}