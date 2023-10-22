namespace MovieTicketApp
{
    partial class frm_SignUp
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
            lbl_Become_Member = new Label();
            lbl_Username = new Label();
            lbl_Password = new Label();
            lbl_Min_Password_Length = new Label();
            lbl_LastName = new Label();
            btn_SignUp = new Button();
            lbl_FirstName = new Label();
            lbl_Already_Member = new Label();
            lbl_LogIn = new Label();
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(273, 38);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(255, 40);
            lbl_Title_SignUp.TabIndex = 0;
            lbl_Title_SignUp.Text = "DOTNET Cinemas";
            // 
            // lbl_Become_Member
            // 
            lbl_Become_Member.AutoSize = true;
            lbl_Become_Member.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Become_Member.Location = new Point(312, 91);
            lbl_Become_Member.Name = "lbl_Become_Member";
            lbl_Become_Member.Size = new Size(173, 25);
            lbl_Become_Member.TabIndex = 1;
            lbl_Become_Member.Text = "Become a Member";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Username.Location = new Point(69, 151);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(78, 20);
            lbl_Username.TabIndex = 2;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.Location = new Point(72, 223);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(73, 20);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Password";
            // 
            // lbl_Min_Password_Length
            // 
            lbl_Min_Password_Length.AutoSize = true;
            lbl_Min_Password_Length.Location = new Point(69, 278);
            lbl_Min_Password_Length.Name = "lbl_Min_Password_Length";
            lbl_Min_Password_Length.Size = new Size(140, 15);
            lbl_Min_Password_Length.TabIndex = 6;
            lbl_Min_Password_Length.Text = "Minimum of 4 characters";
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_LastName.Location = new Point(471, 223);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(77, 20);
            lbl_LastName.TabIndex = 8;
            lbl_LastName.Text = "Last name";
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.Firebrick;
            btn_SignUp.Cursor = Cursors.Hand;
            btn_SignUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SignUp.ForeColor = SystemColors.Window;
            btn_SignUp.Location = new Point(273, 374);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(255, 43);
            btn_SignUp.TabIndex = 11;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FirstName.Location = new Point(471, 151);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(85, 21);
            lbl_FirstName.TabIndex = 12;
            lbl_FirstName.Text = "First name";
            // 
            // lbl_Already_Member
            // 
            lbl_Already_Member.AutoSize = true;
            lbl_Already_Member.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Already_Member.Location = new Point(294, 324);
            lbl_Already_Member.Name = "lbl_Already_Member";
            lbl_Already_Member.Size = new Size(139, 20);
            lbl_Already_Member.TabIndex = 14;
            lbl_Already_Member.Text = "Already a member?";
            // 
            // lbl_LogIn
            // 
            lbl_LogIn.AutoSize = true;
            lbl_LogIn.Cursor = Cursors.Hand;
            lbl_LogIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_LogIn.ForeColor = Color.Firebrick;
            lbl_LogIn.Location = new Point(450, 324);
            lbl_LogIn.Name = "lbl_LogIn";
            lbl_LogIn.Size = new Size(60, 20);
            lbl_LogIn.TabIndex = 15;
            lbl_LogIn.Text = "LOG IN";
            lbl_LogIn.Click += lbl_LogIn_Click;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(471, 180);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(260, 23);
            txt_FirstName.TabIndex = 16;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(471, 252);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(260, 23);
            txt_LastName.TabIndex = 17;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(69, 180);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(260, 23);
            txt_Email.TabIndex = 18;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(69, 252);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(260, 23);
            txt_Password.TabIndex = 19;
            // 
            // frm_SignUp
            // 
            AcceptButton = btn_SignUp;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Controls.Add(lbl_LogIn);
            Controls.Add(lbl_Already_Member);
            Controls.Add(lbl_FirstName);
            Controls.Add(btn_SignUp);
            Controls.Add(lbl_LastName);
            Controls.Add(lbl_Min_Password_Length);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_Become_Member);
            Controls.Add(lbl_Title_SignUp);
            Name = "frm_SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up | DOTNET Cinemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Label lbl_Become_Member;
        private Label lbl_FirstName;
        private Label lbl_LastName;
        private Label lbl_Username;
        private Label lbl_Password;
        private Label lbl_Min_Password_Length;
        private Button btn_SignUp;
        private Label lbl_Already_Member;
        private Label lbl_LogIn;
        private TextBox txt_FirstName;
        private TextBox txt_LastName;
        private TextBox txt_Email;
        private TextBox txt_Password;
    }
}