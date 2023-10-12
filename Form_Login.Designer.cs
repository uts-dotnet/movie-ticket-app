namespace MovieTicketApp
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Username = new Label();
            lbl_Password = new Label();
            lbl_Title_Login = new Label();
            btn_Login = new Button();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            lbl_No_Account = new Label();
            label2 = new Label();
            lbl_SignUp = new Label();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Username.Location = new Point(260, 126);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(83, 21);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.Location = new Point(260, 205);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(79, 21);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // lbl_Title_Login
            // 
            lbl_Title_Login.AutoSize = true;
            lbl_Title_Login.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_Login.ForeColor = Color.Firebrick;
            lbl_Title_Login.Location = new Point(273, 38);
            lbl_Title_Login.Name = "lbl_Title_Login";
            lbl_Title_Login.Size = new Size(255, 40);
            lbl_Title_Login.TabIndex = 2;
            lbl_Title_Login.Text = "DOTNET Cinemas";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Firebrick;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.Window;
            btn_Login.Location = new Point(258, 356);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(283, 43);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(260, 159);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(283, 23);
            txt_Username.TabIndex = 5;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(260, 238);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(281, 23);
            txt_Password.TabIndex = 6;
            // 
            // lbl_No_Account
            // 
            lbl_No_Account.AutoSize = true;
            lbl_No_Account.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_No_Account.Location = new Point(275, 300);
            lbl_No_Account.Name = "lbl_No_Account";
            lbl_No_Account.Size = new Size(163, 20);
            lbl_No_Account.TabIndex = 7;
            lbl_No_Account.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // lbl_SignUp
            // 
            lbl_SignUp.AutoSize = true;
            lbl_SignUp.Cursor = Cursors.Hand;
            lbl_SignUp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_SignUp.ForeColor = Color.Firebrick;
            lbl_SignUp.Location = new Point(455, 301);
            lbl_SignUp.Name = "lbl_SignUp";
            lbl_SignUp.Size = new Size(69, 20);
            lbl_SignUp.TabIndex = 8;
            lbl_SignUp.Text = "SIGN UP";
            lbl_SignUp.Click += lbl_SignUp_Click;
            // 
            // frm_Login
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_SignUp);
            Controls.Add(label2);
            Controls.Add(lbl_No_Account);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Title_Login);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login | DOTNET Cinemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_Login;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button btn_Login;
        private Label lbl_No_Account;
        private Label label2;
        private Label lbl_SignUp;
    }
}