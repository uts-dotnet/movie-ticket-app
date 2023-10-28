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
            dataGridView1 = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            SecurityLevel = new DataGridViewComboBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            btn_SaveChanges = new Button();
            btn_Cancel = new Button();
            button1 = new Button();
            userDataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(294, 9);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(187, 40);
            lbl_Title_SignUp.TabIndex = 4;
            lbl_Title_SignUp.Text = "Update User";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, SecurityLevel, Username, Password, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userDataBindingSource;
            dataGridView1.Location = new Point(26, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 336);
            dataGridView1.TabIndex = 5;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            // 
            // SecurityLevel
            // 
            SecurityLevel.HeaderText = "Security Level";
            SecurityLevel.Name = "SecurityLevel";
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
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
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // btn_SaveChanges
            // 
            btn_SaveChanges.Location = new Point(668, 26);
            btn_SaveChanges.Name = "btn_SaveChanges";
            btn_SaveChanges.Size = new Size(100, 23);
            btn_SaveChanges.TabIndex = 6;
            btn_SaveChanges.Text = "Save Changes";
            btn_SaveChanges.UseVisualStyleBackColor = true;
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
            button1.Location = new Point(318, 64);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 8;
            button1.Text = "Update Password";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // userDataBindingSource
            // 
            userDataBindingSource.DataSource = typeof(src.User.UserData);
            // 
            // Form_UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_SaveChanges);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_UpdateUser";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewComboBoxColumn SecurityLevel;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private Button btn_SaveChanges;
        private Button btn_Cancel;
        private Button button1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private BindingSource userDataBindingSource;
    }
}