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
            Delete = new DataGridViewButtonColumn();
            userDataBindingSource = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            btn_Cancel = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_UserId = new TextBox();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
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
            lbl_Title_SignUp.Location = new Point(317, 13);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(187, 40);
            lbl_Title_SignUp.TabIndex = 4;
            lbl_Title_SignUp.Text = "Update User";
            // 
            // userGrid
            // 
            userGrid.AllowUserToAddRows = false;
            userGrid.AllowUserToDeleteRows = false;
            userGrid.AutoGenerateColumns = false;
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, Delete });
            userGrid.DataSource = userDataBindingSource;
            userGrid.Location = new Point(37, 168);
            userGrid.Name = "userGrid";
            userGrid.RowTemplate.Height = 25;
            userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userGrid.Size = new Size(742, 270);
            userGrid.TabIndex = 5;
            userGrid.CellClick += userGrid_CelLClick;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
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
            btn_Cancel.Location = new Point(37, 25);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(100, 23);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(670, 25);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 8;
            button1.Text = "Update Data";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 73);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "UserId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 73);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 113);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 74);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 115);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 13;
            label5.Text = "Last Name";
            // 
            // textBox_UserId
            // 
            textBox_UserId.Location = new Point(338, 70);
            textBox_UserId.Name = "textBox_UserId";
            textBox_UserId.Size = new Size(190, 23);
            textBox_UserId.TabIndex = 14;
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(106, 70);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(170, 23);
            textBox_Username.TabIndex = 15;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(106, 113);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(161, 23);
            textBox_Password.TabIndex = 16;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(614, 69);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(165, 23);
            textBox_firstName.TabIndex = 17;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(613, 112);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(165, 23);
            textBox_lastName.TabIndex = 18;
            // 
            // Form_UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(button1);
            Controls.Add(btn_Cancel);
            Controls.Add(userGrid);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_UpdateUser";
            Text = "Form1";
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
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
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
        private DataGridViewButtonColumn Delete;
    }
}