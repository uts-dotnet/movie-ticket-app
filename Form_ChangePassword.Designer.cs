namespace MovieTicketApp
{
    partial class frm_ChangePassword
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
            lbl_FirstName = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox_currentPW = new TextBox();
            textBox_newPW = new TextBox();
            textBox_confirmPW = new TextBox();
            label5 = new Label();
            lbl_PWLengthWarning = new Label();
            lbl_PWMatchWarning = new Label();
            btn_ChangePW = new Button();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(263, 22);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(258, 40);
            lbl_Title_SignUp.TabIndex = 2;
            lbl_Title_SignUp.Text = "Change Password";
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.BackColor = Color.Firebrick;
            lbl_FirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FirstName.ForeColor = SystemColors.ButtonFace;
            lbl_FirstName.Location = new Point(34, 37);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(69, 21);
            lbl_FirstName.TabIndex = 14;
            lbl_FirstName.Text = "Go Back";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(244, 120);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 18;
            label2.Text = "Current Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 205);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 19;
            label1.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(244, 288);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 20;
            label3.Text = "Confirm Password";
            // 
            // textBox_currentPW
            // 
            textBox_currentPW.Location = new Point(244, 144);
            textBox_currentPW.Name = "textBox_currentPW";
            textBox_currentPW.Size = new Size(298, 23);
            textBox_currentPW.TabIndex = 21;
            // 
            // textBox_newPW
            // 
            textBox_newPW.Location = new Point(244, 229);
            textBox_newPW.Name = "textBox_newPW";
            textBox_newPW.Size = new Size(298, 23);
            textBox_newPW.TabIndex = 22;
            // 
            // textBox_confirmPW
            // 
            textBox_confirmPW.Location = new Point(244, 312);
            textBox_confirmPW.Name = "textBox_confirmPW";
            textBox_confirmPW.Size = new Size(298, 23);
            textBox_confirmPW.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(312, 62);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 25;
            label5.Text = "At least 4 characters";
            // 
            // lbl_PWLengthWarning
            // 
            lbl_PWLengthWarning.AutoSize = true;
            lbl_PWLengthWarning.ForeColor = Color.Firebrick;
            lbl_PWLengthWarning.Location = new Point(316, 255);
            lbl_PWLengthWarning.Name = "lbl_PWLengthWarning";
            lbl_PWLengthWarning.Size = new Size(226, 15);
            lbl_PWLengthWarning.TabIndex = 26;
            lbl_PWLengthWarning.Text = "Your new password be 4+ characters long";
            // 
            // lbl_PWMatchWarning
            // 
            lbl_PWMatchWarning.AutoSize = true;
            lbl_PWMatchWarning.ForeColor = Color.Firebrick;
            lbl_PWMatchWarning.Location = new Point(405, 338);
            lbl_PWMatchWarning.Name = "lbl_PWMatchWarning";
            lbl_PWMatchWarning.Size = new Size(137, 15);
            lbl_PWMatchWarning.TabIndex = 27;
            lbl_PWMatchWarning.Text = "Passwords do not match";
            // 
            // btn_ChangePW
            // 
            btn_ChangePW.Location = new Point(349, 387);
            btn_ChangePW.Name = "btn_ChangePW";
            btn_ChangePW.Size = new Size(75, 23);
            btn_ChangePW.TabIndex = 28;
            btn_ChangePW.Text = "Submit";
            btn_ChangePW.UseVisualStyleBackColor = true;
            btn_ChangePW.Click += btn_ChangePW_Click;
            // 
            // frm_ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ChangePW);
            Controls.Add(lbl_PWMatchWarning);
            Controls.Add(lbl_PWLengthWarning);
            Controls.Add(label5);
            Controls.Add(textBox_confirmPW);
            Controls.Add(textBox_newPW);
            Controls.Add(textBox_currentPW);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lbl_FirstName);
            Controls.Add(lbl_Title_SignUp);
            Name = "frm_ChangePassword";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Label lbl_FirstName;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox_currentPW;
        private TextBox textBox_newPW;
        private TextBox textBox_confirmPW;
        private Label label5;
        private Label lbl_PWLengthWarning;
        private Label lbl_PWMatchWarning;
        private Button btn_ChangePW;
    }
}