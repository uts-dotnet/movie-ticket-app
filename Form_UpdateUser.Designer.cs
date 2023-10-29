namespace MovieTicketApp
{
    partial class Form_UpdateUser
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
            components = new System.ComponentModel.Container();
            lbl_Title_SignUp = new Label();
            userGrid = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataBindingSource = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            btn_Cancel = new Button();
            btn_UpdateData = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            btn_CreateNewUser = new Button();
            label1 = new Label();
            textBox_UserId = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btn_DeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(294, 9);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(212, 40);
            lbl_Title_SignUp.TabIndex = 4;
            lbl_Title_SignUp.Text = "Manage Users";
            // 
            // userGrid
            // 
            userGrid.AllowUserToAddRows = false;
            userGrid.AllowUserToDeleteRows = false;
            userGrid.AutoGenerateColumns = false;
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            userGrid.DataSource = userDataBindingSource;
            userGrid.Location = new Point(37, 203);
            userGrid.Name = "userGrid";
            userGrid.ReadOnly = true;
            userGrid.RowTemplate.Height = 25;
            userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userGrid.Size = new Size(742, 235);
            userGrid.TabIndex = 5;
            userGrid.CellClick += userGrid_CelLClick;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataBindingSource
            // 
            userDataBindingSource.DataSource = typeof(src.User.UserData);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.Firebrick;
            btn_Cancel.Cursor = Cursors.Hand;
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(23, 25);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(148, 23);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Exit and Save Changes";
            btn_Cancel.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_UpdateData
            // 
            btn_UpdateData.BackColor = Color.Firebrick;
            btn_UpdateData.Cursor = Cursors.Hand;
            btn_UpdateData.ForeColor = Color.White;
            btn_UpdateData.Location = new Point(316, 159);
            btn_UpdateData.Name = "btn_UpdateData";
            btn_UpdateData.Size = new Size(129, 23);
            btn_UpdateData.TabIndex = 8;
            btn_UpdateData.Text = "Update User Data";
            btn_UpdateData.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_UpdateData.UseVisualStyleBackColor = false;
            btn_UpdateData.Click += btn_UpdateData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 76);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 117);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 13;
            label5.Text = "Last Name";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(294, 71);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(170, 23);
            textBox_Username.TabIndex = 15;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(294, 114);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(161, 23);
            textBox_Password.TabIndex = 16;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(545, 71);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(165, 23);
            textBox_firstName.TabIndex = 17;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(544, 114);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(165, 23);
            textBox_lastName.TabIndex = 18;
            // 
            // btn_CreateNewUser
            // 
            btn_CreateNewUser.BackColor = Color.Firebrick;
            btn_CreateNewUser.Cursor = Cursors.Hand;
            btn_CreateNewUser.ForeColor = Color.White;
            btn_CreateNewUser.Location = new Point(148, 159);
            btn_CreateNewUser.Name = "btn_CreateNewUser";
            btn_CreateNewUser.Size = new Size(114, 23);
            btn_CreateNewUser.TabIndex = 19;
            btn_CreateNewUser.Text = "Create New User";
            btn_CreateNewUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_CreateNewUser.UseVisualStyleBackColor = false;
            btn_CreateNewUser.Click += btn_CreateNewUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(69, 74);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "UserId";
            // 
            // textBox_UserId
            // 
            textBox_UserId.CausesValidation = false;
            textBox_UserId.Location = new Point(115, 71);
            textBox_UserId.Name = "textBox_UserId";
            textBox_UserId.ReadOnly = true;
            textBox_UserId.Size = new Size(93, 23);
            textBox_UserId.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(594, 51);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.CausesValidation = false;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(63, 97);
            label7.Name = "label7";
            label7.Size = new Size(145, 13);
            label7.TabIndex = 21;
            label7.Text = "Auto-generated for new users";
            // 
            // btn_DeleteUser
            // 
            btn_DeleteUser.BackColor = Color.Firebrick;
            btn_DeleteUser.Cursor = Cursors.Hand;
            btn_DeleteUser.ForeColor = Color.White;
            btn_DeleteUser.Location = new Point(489, 159);
            btn_DeleteUser.Name = "btn_DeleteUser";
            btn_DeleteUser.Size = new Size(140, 23);
            btn_DeleteUser.TabIndex = 22;
            btn_DeleteUser.Text = "Delete Selected User";
            btn_DeleteUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_DeleteUser.UseVisualStyleBackColor = false;
            btn_DeleteUser.Click += btn_DeleteUser_Click;
            // 
            // Form_UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DeleteUser);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_CreateNewUser);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(textBox_UserId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_UpdateData);
            Controls.Add(btn_Cancel);
            Controls.Add(userGrid);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_UpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private DataGridView dataGridView1;
        private Button btn_Cancel;
        private Button button1;
        private BindingSource userBindingSource;
        private BindingSource userDataBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_UserId;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private DataGridView userGrid;
        private Button btn_UpdateData;
        private Button button2;
        private Button btn_CreateNewUser;
        private Label label6;
        private Label label7;
        private Button button3;
        private Button btn_DeleteUser;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}