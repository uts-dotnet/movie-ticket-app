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
            btn_Back = new Button();
            btn_Logout = new Button();
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
            listBox_Seats.Location = new Point(17, 124);
            listBox_Seats.Name = "listBox_Seats";
            listBox_Seats.SelectionMode = SelectionMode.MultiSimple;
            listBox_Seats.Size = new Size(215, 298);
            listBox_Seats.TabIndex = 6;
            // 
            // btn_Back
            // 
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.Firebrick;
            btn_Back.Location = new Point(17, 43);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 35);
            btn_Back.TabIndex = 21;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
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
            // 
            // Form_Seat_Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 434);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Back);
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
        private Button btn_Back;
        private Button btn_Logout;
    }
}