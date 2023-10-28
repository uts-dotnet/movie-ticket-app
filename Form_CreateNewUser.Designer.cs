namespace MovieTicketApp
{
    partial class Form_CreateNewUser
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
            lbl_Title_SignUp = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_firstName = new TextBox();
            textBox_username = new TextBox();
            textBox_lastName = new TextBox();
            textBox_password = new TextBox();
            btn_Save = new Button();
            btn_Cancel = new Button();
            label5 = new Label();
            textBox_email = new TextBox();
            textBox_confirmPW = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(305, 31);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(176, 40);
            lbl_Title_SignUp.TabIndex = 4;
            lbl_Title_SignUp.Text = "Create User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 107);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 107);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 205);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 308);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(109, 136);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(259, 23);
            textBox_firstName.TabIndex = 9;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(109, 234);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(259, 23);
            textBox_username.TabIndex = 10;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(449, 136);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(259, 23);
            textBox_lastName.TabIndex = 11;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(109, 336);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(259, 23);
            textBox_password.TabIndex = 12;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(671, 47);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 13;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(54, 47);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 14;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 205);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(449, 234);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(259, 23);
            textBox_email.TabIndex = 16;
            // 
            // textBox_confirmPW
            // 
            textBox_confirmPW.Location = new Point(449, 336);
            textBox_confirmPW.Name = "textBox_confirmPW";
            textBox_confirmPW.Size = new Size(259, 23);
            textBox_confirmPW.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 308);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 18;
            label6.Text = "Confirm Password";
            // 
            // Form_CreateNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox_confirmPW);
            Controls.Add(textBox_email);
            Controls.Add(label5);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(textBox_password);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_username);
            Controls.Add(textBox_firstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_CreateNewUser";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_firstName;
        private TextBox textBox_username;
        private TextBox textBox_lastName;
        private TextBox textBox_password;
        private Button btn_Save;
        private Button btn_Cancel;
        private Label label5;
        private TextBox textBox_email;
        private TextBox textBox_confirmPW;
        private Label label6;
    }
}