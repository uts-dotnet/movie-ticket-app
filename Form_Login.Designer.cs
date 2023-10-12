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
            lbl_Login_Title = new Label();
            btn_Login = new Button();
            btn_SignUp = new Button();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Username.Location = new Point(131, 174);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(106, 30);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Password.Location = new Point(131, 233);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(99, 30);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // lbl_Login_Title
            // 
            lbl_Login_Title.AutoSize = true;
            lbl_Login_Title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Login_Title.Location = new Point(269, 68);
            lbl_Login_Title.Name = "lbl_Login_Title";
            lbl_Login_Title.Size = new Size(255, 40);
            lbl_Login_Title.TabIndex = 2;
            lbl_Login_Title.Text = "DOTNET Cinemas";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(247, 339);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(123, 41);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SignUp.Location = new Point(429, 339);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(123, 41);
            btn_SignUp.TabIndex = 4;
            btn_SignUp.Text = "SignUp";
            btn_SignUp.UseVisualStyleBackColor = true;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(269, 181);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(283, 23);
            txt_Username.TabIndex = 5;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(271, 238);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(281, 23);
            txt_Password.TabIndex = 6;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(btn_SignUp);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Login_Title);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login_Title;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button btn_Login;
        private Button btn_SignUp;
    }
}