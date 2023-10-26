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
            btn_back = new Label();
            lbl_currentPW = new Label();
            label1 = new Label();
            label3 = new Label();
            txt_currentPW = new TextBox();
            txt_newPW = new TextBox();
            txt_confirmPW = new TextBox();
            btn_Submit = new Label();
            label5 = new Label();
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
            // btn_back
            // 
            btn_back.AutoSize = true;
            btn_back.BackColor = Color.Firebrick;
            btn_back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ButtonFace;
            btn_back.Location = new Point(34, 37);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(69, 21);
            btn_back.TabIndex = 14;
            btn_back.Text = "Go Back";
            // 
            // lbl_currentPW
            // 
            lbl_currentPW.AutoSize = true;
            lbl_currentPW.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentPW.Location = new Point(244, 120);
            lbl_currentPW.Name = "lbl_currentPW";
            lbl_currentPW.Size = new Size(138, 21);
            lbl_currentPW.TabIndex = 18;
            lbl_currentPW.Text = "Current Password";
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
            // txt_currentPW
            // 
            txt_currentPW.Location = new Point(244, 144);
            txt_currentPW.Name = "txt_currentPW";
            txt_currentPW.Size = new Size(298, 23);
            txt_currentPW.TabIndex = 21;
            // 
            // txt_newPW
            // 
            txt_newPW.Location = new Point(244, 229);
            txt_newPW.Name = "txt_newPW";
            txt_newPW.Size = new Size(298, 23);
            txt_newPW.TabIndex = 22;
            // 
            // txt_confirmPW
            // 
            txt_confirmPW.Location = new Point(244, 312);
            txt_confirmPW.Name = "txt_confirmPW";
            txt_confirmPW.Size = new Size(298, 23);
            txt_confirmPW.TabIndex = 23;
            // 
            // btn_Submit
            // 
            btn_Submit.AutoSize = true;
            btn_Submit.BackColor = Color.Firebrick;
            btn_Submit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Submit.ForeColor = SystemColors.ButtonFace;
            btn_Submit.Location = new Point(347, 373);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(62, 21);
            btn_Submit.TabIndex = 24;
            btn_Submit.Text = "Submit";
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
            // frm_ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btn_Submit);
            Controls.Add(txt_confirmPW);
            Controls.Add(txt_newPW);
            Controls.Add(txt_currentPW);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbl_currentPW);
            Controls.Add(btn_back);
            Controls.Add(lbl_Title_SignUp);
            Name = "frm_ChangePassword";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Label btn_back;
        private Label lbl_currentPW;
        private Label label1;
        private Label label3;
        private TextBox txt_currentPW;
        private TextBox txt_newPW;
        private TextBox txt_confirmPW;
        private Label btn_Submit;
        private Label label5;
    }
}