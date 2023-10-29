namespace MovieTicketApp
{
    partial class Form_Seat_Selection
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
            lbl_Title_Seat_Selection = new Label();
            listBox_Seats = new ListBox();
            btn_Logout = new Button();
            lbl_Seats_Available = new Label();
            lbl_Seats_Available_Value = new Label();
            lbl_Total_Seats_Remaining = new Label();
            lbl_Total_Seats_Remaining_Value = new Label();
            listBox_Selected_Seats = new ListBox();
            label1 = new Label();
            lbl_Edit_Seats = new Label();
            btn_Continue = new Button();
            SuspendLayout();
            // 
            // lbl_Title_Seat_Selection
            // 
            lbl_Title_Seat_Selection.Anchor = AnchorStyles.None;
            lbl_Title_Seat_Selection.AutoSize = true;
            lbl_Title_Seat_Selection.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_Seat_Selection.ForeColor = Color.Firebrick;
            lbl_Title_Seat_Selection.Location = new Point(183, 38);
            lbl_Title_Seat_Selection.Name = "lbl_Title_Seat_Selection";
            lbl_Title_Seat_Selection.Size = new Size(224, 40);
            lbl_Title_Seat_Selection.TabIndex = 5;
            lbl_Title_Seat_Selection.Text = "Pick Your Seats";
            lbl_Title_Seat_Selection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox_Seats
            // 
            listBox_Seats.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox_Seats.FormattingEnabled = true;
            listBox_Seats.ItemHeight = 21;
            listBox_Seats.Location = new Point(17, 119);
            listBox_Seats.Name = "listBox_Seats";
            listBox_Seats.Size = new Size(215, 298);
            listBox_Seats.TabIndex = 6;
            listBox_Seats.SelectedIndexChanged += listBox_Seats_SelectedIndexChanged;
            // 
            // btn_Logout
            // 
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.Firebrick;
            btn_Logout.Location = new Point(479, 43);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(89, 35);
            btn_Logout.TabIndex = 22;
            btn_Logout.Text = "Log Out";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // lbl_Seats_Available
            // 
            lbl_Seats_Available.AutoSize = true;
            lbl_Seats_Available.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Seats_Available.Location = new Point(253, 124);
            lbl_Seats_Available.Name = "lbl_Seats_Available";
            lbl_Seats_Available.Size = new Size(123, 21);
            lbl_Seats_Available.TabIndex = 23;
            lbl_Seats_Available.Text = "Seats Available:";
            // 
            // lbl_Seats_Available_Value
            // 
            lbl_Seats_Available_Value.AutoSize = true;
            lbl_Seats_Available_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Seats_Available_Value.Location = new Point(380, 125);
            lbl_Seats_Available_Value.Name = "lbl_Seats_Available_Value";
            lbl_Seats_Available_Value.Size = new Size(19, 21);
            lbl_Seats_Available_Value.TabIndex = 24;
            lbl_Seats_Available_Value.Text = "0";
            // 
            // lbl_Total_Seats_Remaining
            // 
            lbl_Total_Seats_Remaining.AutoSize = true;
            lbl_Total_Seats_Remaining.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total_Seats_Remaining.Location = new Point(255, 167);
            lbl_Total_Seats_Remaining.Name = "lbl_Total_Seats_Remaining";
            lbl_Total_Seats_Remaining.Size = new Size(173, 21);
            lbl_Total_Seats_Remaining.TabIndex = 25;
            lbl_Total_Seats_Remaining.Text = "Total Seats Remaining:";
            // 
            // lbl_Total_Seats_Remaining_Value
            // 
            lbl_Total_Seats_Remaining_Value.AutoSize = true;
            lbl_Total_Seats_Remaining_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total_Seats_Remaining_Value.Location = new Point(434, 168);
            lbl_Total_Seats_Remaining_Value.Name = "lbl_Total_Seats_Remaining_Value";
            lbl_Total_Seats_Remaining_Value.Size = new Size(19, 21);
            lbl_Total_Seats_Remaining_Value.TabIndex = 26;
            lbl_Total_Seats_Remaining_Value.Text = "0";
            // 
            // listBox_Selected_Seats
            // 
            listBox_Selected_Seats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_Selected_Seats.FormattingEnabled = true;
            listBox_Selected_Seats.ItemHeight = 20;
            listBox_Selected_Seats.Location = new Point(256, 264);
            listBox_Selected_Seats.Name = "listBox_Selected_Seats";
            listBox_Selected_Seats.Size = new Size(312, 84);
            listBox_Selected_Seats.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 230);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 28;
            label1.Text = "Selected Seats";
            // 
            // lbl_Edit_Seats
            // 
            lbl_Edit_Seats.Location = new Point(0, 0);
            lbl_Edit_Seats.Name = "lbl_Edit_Seats";
            lbl_Edit_Seats.Size = new Size(100, 23);
            lbl_Edit_Seats.TabIndex = 31;
            // 
            // btn_Continue
            // 
            btn_Continue.BackColor = Color.Firebrick;
            btn_Continue.Cursor = Cursors.Hand;
            btn_Continue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Continue.ForeColor = Color.White;
            btn_Continue.Location = new Point(256, 378);
            btn_Continue.Name = "btn_Continue";
            btn_Continue.Size = new Size(312, 39);
            btn_Continue.TabIndex = 30;
            btn_Continue.Text = "Continue";
            btn_Continue.UseVisualStyleBackColor = false;
            btn_Continue.Click += btn_Confirm_Click;
            // 
            // Form_Seat_Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 434);
            Controls.Add(btn_Continue);
            Controls.Add(lbl_Edit_Seats);
            Controls.Add(label1);
            Controls.Add(listBox_Selected_Seats);
            Controls.Add(lbl_Total_Seats_Remaining_Value);
            Controls.Add(lbl_Total_Seats_Remaining);
            Controls.Add(lbl_Seats_Available_Value);
            Controls.Add(lbl_Seats_Available);
            Controls.Add(btn_Logout);
            Controls.Add(listBox_Seats);
            Controls.Add(lbl_Title_Seat_Selection);
            Name = "Form_Seat_Selection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seats | DOTNET Cinemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_Seat_Selection;
        private ListBox listBox_Seats;
        private Button btn_Logout;
        private Label lbl_Seats_Available;
        private Label lbl_Seats_Available_Value;
        private Label lbl_Total_Seats_Remaining;
        private Label lbl_Total_Seats_Remaining_Value;
        private ListBox listBox_Selected_Seats;
        private Label label1;
        private Label lbl_Edit_Seats;
        private Button btn_Continue;
    }
}