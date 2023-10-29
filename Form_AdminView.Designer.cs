namespace MovieTicketApp
{
    partial class Form_AdminView
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
            btn_EditUser = new Button();
            btn_EditMovie = new Button();
            btn_Log_Out = new Button();
            button1 = new Button();
            btn_TEST = new Button();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(309, 55);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(189, 40);
            lbl_Title_SignUp.TabIndex = 3;
            lbl_Title_SignUp.Text = "Admin Tasks";
            // 
            // btn_EditUser
            // 
            btn_EditUser.BackColor = Color.Firebrick;
            btn_EditUser.Cursor = Cursors.Hand;
            btn_EditUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EditUser.ForeColor = Color.White;
            btn_EditUser.Location = new Point(289, 146);
            btn_EditUser.Name = "btn_EditUser";
            btn_EditUser.Size = new Size(219, 39);
            btn_EditUser.TabIndex = 6;
            btn_EditUser.Text = "Manage Users";
            btn_EditUser.UseVisualStyleBackColor = false;
            btn_EditUser.Click += btn_EditUser_Click_1;
            // 
            // btn_EditMovie
            // 
            btn_EditMovie.BackColor = Color.Firebrick;
            btn_EditMovie.Cursor = Cursors.Hand;
            btn_EditMovie.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EditMovie.ForeColor = Color.White;
            btn_EditMovie.Location = new Point(289, 227);
            btn_EditMovie.Name = "btn_EditMovie";
            btn_EditMovie.Size = new Size(219, 40);
            btn_EditMovie.TabIndex = 9;
            btn_EditMovie.Text = "Manage Movies";
            btn_EditMovie.UseVisualStyleBackColor = false;
            btn_EditMovie.Click += btn_EditMovie_Click;
            // 
            // btn_Log_Out
            // 
            btn_Log_Out.Cursor = Cursors.Hand;
            btn_Log_Out.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Log_Out.ForeColor = Color.Firebrick;
            btn_Log_Out.Location = new Point(358, 342);
            btn_Log_Out.Name = "btn_Log_Out";
            btn_Log_Out.Size = new Size(87, 33);
            btn_Log_Out.TabIndex = 18;
            btn_Log_Out.Text = "Log Out";
            btn_Log_Out.UseVisualStyleBackColor = true;
            btn_Log_Out.Click += btn_Log_Out_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(514, 398);
            button1.Name = "button1";
            button1.Size = new Size(274, 40);
            button1.TabIndex = 19;
            button1.Text = "Manage Movie Sessions";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // btn_TEST
            // 
            btn_TEST.Location = new Point(701, 352);
            btn_TEST.Name = "btn_TEST";
            btn_TEST.Size = new Size(75, 23);
            btn_TEST.TabIndex = 20;
            btn_TEST.Text = "TEST";
            btn_TEST.UseVisualStyleBackColor = true;
            btn_TEST.Visible = false;
            // 
            // Form_AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_TEST);
            Controls.Add(button1);
            Controls.Add(btn_Log_Out);
            Controls.Add(btn_EditMovie);
            Controls.Add(btn_EditUser);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_AdminView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title_SignUp;
        private Button btn_Back;
        private Button btn_AddUser;
        private Button btn_EditUser;
        private Button btn_AddMovie;
        private Button btn_EditMovie;
        private Label label5;
        private Label label1;
        private Button btn_Log_Out;
        private Button button1;
        private Button btn_TEST;
    }
}