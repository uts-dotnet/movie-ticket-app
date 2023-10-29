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
            textBox_Password = new TextBox();
            textBox_Username = new TextBox();
            textBox_UserId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_UpdateData = new Button();
            btn_Cancel = new Button();
            sessionGrid = new DataGridView();
            lbl_Title_SignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)sessionGrid).BeginInit();
            SuspendLayout();
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.Location = new Point(484, 163);
            btn_DeleteUser.Name = "btn_DeleteUser";
            btn_DeleteUser.Size = new Size(140, 23);
            btn_DeleteUser.TabIndex = 40;
            btn_DeleteUser.Text = "Delete Session";
            btn_DeleteUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_DeleteUser.UseVisualStyleBackColor = true;
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
            btn_CreateNewUser.Location = new Point(129, 163);
            btn_CreateNewUser.Name = "btn_CreateNewUser";
            btn_CreateNewUser.Size = new Size(128, 23);
            btn_CreateNewUser.TabIndex = 37;
            btn_CreateNewUser.Text = "Create New Session";
            btn_CreateNewUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_CreateNewUser.UseVisualStyleBackColor = true;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(460, 113);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(170, 23);
            textBox_Password.TabIndex = 34;
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(460, 76);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(170, 23);
            textBox_Username.TabIndex = 33;
            // 
            // textBox_UserId
            // 
            textBox_UserId.CausesValidation = false;
            textBox_UserId.Location = new Point(224, 76);
            textBox_UserId.Name = "textBox_UserId";
            textBox_UserId.ReadOnly = true;
            textBox_UserId.Size = new Size(93, 23);
            textBox_UserId.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 113);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 29;
            label3.Text = "Available Seats Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 79);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 28;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(164, 79);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 27;
            label1.Text = "Movie ID";
            // 
            // btn_UpdateData
            // 
            btn_UpdateData.Location = new Point(311, 163);
            btn_UpdateData.Name = "btn_UpdateData";
            btn_UpdateData.Size = new Size(129, 23);
            btn_UpdateData.TabIndex = 26;
            btn_UpdateData.Text = "Update Session";
            btn_UpdateData.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_UpdateData.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(29, 27);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(100, 23);
            btn_Cancel.TabIndex = 25;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Cancel.UseVisualStyleBackColor = true;
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
            // Form_UpdateSessions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DeleteUser);
            Controls.Add(label6);
            Controls.Add(btn_CreateNewUser);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(textBox_UserId);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DeleteUser;
        private Label label6;
        private Button btn_CreateNewUser;
        private TextBox textBox_Password;
        private TextBox textBox_Username;
        private TextBox textBox_UserId;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_UpdateData;
        private Button btn_Cancel;
        private DataGridView sessionGrid;
        private Label lbl_Title_SignUp;
    }
}