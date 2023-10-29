namespace MovieTicketApp
{
    partial class Form_UpdateSessions
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
            btn_DeleteUser = new Button();
            label6 = new Label();
            btn_CreateNewUser = new Button();
            textBox_MovieID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_UpdateData = new Button();
            btn_Cancel = new Button();
            sessionGrid = new DataGridView();
            lbl_Title_SignUp = new Label();
            dateTimePicker_SessionTime = new DateTimePicker();
            numericUpDown_seats = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)sessionGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_seats).BeginInit();
            SuspendLayout();
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.Location = new Point(495, 163);
            btn_DeleteUser.Name = "btn_DeleteUser";
            btn_DeleteUser.Size = new Size(140, 23);
            btn_DeleteUser.TabIndex = 40;
            btn_DeleteUser.Text = "Delete Session";
            btn_DeleteUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_DeleteUser.UseVisualStyleBackColor = true;
            btn_DeleteUser.Click += btn_DeleteSession_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(586, 53);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 38;
            // 
            // btn_CreateNewUser
            // 
            btn_CreateNewUser.Location = new Point(140, 163);
            btn_CreateNewUser.Name = "btn_CreateNewUser";
            btn_CreateNewUser.Size = new Size(128, 23);
            btn_CreateNewUser.TabIndex = 37;
            btn_CreateNewUser.Text = "Create New Session";
            btn_CreateNewUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_CreateNewUser.UseVisualStyleBackColor = true;
            btn_CreateNewUser.Click += btn_CreateNewSession_Click;
            // 
            // textBox_MovieID
            // 
            textBox_MovieID.CausesValidation = false;
            textBox_MovieID.Location = new Point(223, 85);
            textBox_MovieID.Name = "textBox_MovieID";
            textBox_MovieID.Size = new Size(93, 23);
            textBox_MovieID.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 122);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 29;
            label3.Text = "Available Seats Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 88);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 28;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(163, 88);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 27;
            label1.Text = "Movie ID";
            // 
            // btn_UpdateData
            // 
            btn_UpdateData.Location = new Point(322, 163);
            btn_UpdateData.Name = "btn_UpdateData";
            btn_UpdateData.Size = new Size(129, 23);
            btn_UpdateData.TabIndex = 26;
            btn_UpdateData.Text = "Update Seat Count";
            btn_UpdateData.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_UpdateData.UseVisualStyleBackColor = true;
            btn_UpdateData.Click += btn_UpdateSession_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(29, 27);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(154, 23);
            btn_Cancel.TabIndex = 25;
            btn_Cancel.Text = "Exit and Save Changes";
            btn_Cancel.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // sessionGrid
            // 
            sessionGrid.AllowUserToAddRows = false;
            sessionGrid.AllowUserToDeleteRows = false;
            sessionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionGrid.Location = new Point(29, 205);
            sessionGrid.Name = "sessionGrid";
            sessionGrid.ReadOnly = true;
            sessionGrid.RowTemplate.Height = 25;
            sessionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sessionGrid.Size = new Size(742, 235);
            sessionGrid.TabIndex = 24;
            sessionGrid.CellClick += sessionGrid_CellClick;
            sessionGrid.CellFormatting += sessionGrid_CellFormatting;
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(286, 11);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(252, 40);
            lbl_Title_SignUp.TabIndex = 23;
            lbl_Title_SignUp.Text = "Manage Sessions";
            // 
            // dateTimePicker_SessionTime
            // 
            dateTimePicker_SessionTime.CustomFormat = "hh:mm tt";
            dateTimePicker_SessionTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_SessionTime.Location = new Point(459, 85);
            dateTimePicker_SessionTime.Name = "dateTimePicker_SessionTime";
            dateTimePicker_SessionTime.Size = new Size(200, 23);
            dateTimePicker_SessionTime.TabIndex = 41;
            dateTimePicker_SessionTime.Value = new DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // numericUpDown_seats
            // 
            numericUpDown_seats.Location = new Point(459, 120);
            numericUpDown_seats.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown_seats.Name = "numericUpDown_seats";
            numericUpDown_seats.Size = new Size(120, 23);
            numericUpDown_seats.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(196, 53);
            label4.Name = "label4";
            label4.Size = new Size(443, 15);
            label4.TabIndex = 43;
            label4.Text = "To edit session time/movie ID, you must delete the old session and create a new one";
            // 
            // Form_UpdateSessions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(numericUpDown_seats);
            Controls.Add(dateTimePicker_SessionTime);
            Controls.Add(btn_DeleteUser);
            Controls.Add(label6);
            Controls.Add(btn_CreateNewUser);
            Controls.Add(textBox_MovieID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_UpdateData);
            Controls.Add(btn_Cancel);
            Controls.Add(sessionGrid);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_UpdateSessions";
            Text = "Form_UpdateSessions";
            ((System.ComponentModel.ISupportInitialize)sessionGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_seats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DeleteUser;
        private Label label6;
        private Button btn_CreateNewUser;
        private TextBox textBox_MovieID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_UpdateData;
        private Button btn_Cancel;
        private DataGridView sessionGrid;
        private Label lbl_Title_SignUp;
        private DateTimePicker dateTimePicker_SessionTime;
        private NumericUpDown numericUpDown_seats;
        private Label label4;
    }
}