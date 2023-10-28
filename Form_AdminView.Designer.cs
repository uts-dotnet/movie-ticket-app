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
            btn_Back = new Button();
            btn_AddUser = new Button();
            btn_EditUser = new Button();
            btn_AddMovie = new Button();
            btn_EditMovie = new Button();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_Title_SignUp
            // 
            lbl_Title_SignUp.AutoSize = true;
            lbl_Title_SignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title_SignUp.ForeColor = Color.Firebrick;
            lbl_Title_SignUp.Location = new Point(311, 40);
            lbl_Title_SignUp.Name = "lbl_Title_SignUp";
            lbl_Title_SignUp.Size = new Size(182, 40);
            lbl_Title_SignUp.TabIndex = 3;
            lbl_Title_SignUp.Text = "Admin View";
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(38, 40);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 4;
            btn_Back.Text = "Go Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_AddUser
            // 
            btn_AddUser.Location = new Point(145, 188);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(127, 23);
            btn_AddUser.TabIndex = 5;
            btn_AddUser.Text = "Add New User";
            btn_AddUser.UseVisualStyleBackColor = true;
            btn_AddUser.Click += btn_AddUser_Click;
            // 
            // btn_EditUser
            // 
            btn_EditUser.Location = new Point(145, 237);
            btn_EditUser.Name = "btn_EditUser";
            btn_EditUser.Size = new Size(127, 23);
            btn_EditUser.TabIndex = 6;
            btn_EditUser.Text = "Edit or Delete User";
            btn_EditUser.UseVisualStyleBackColor = true;
            // 
            // btn_AddMovie
            // 
            btn_AddMovie.Location = new Point(501, 188);
            btn_AddMovie.Name = "btn_AddMovie";
            btn_AddMovie.Size = new Size(127, 23);
            btn_AddMovie.TabIndex = 8;
            btn_AddMovie.Text = "Add New Movie";
            btn_AddMovie.UseVisualStyleBackColor = true;
            btn_AddMovie.Click += btn_AddMovie_Click;
            // 
            // btn_EditMovie
            // 
            btn_EditMovie.Location = new Point(501, 237);
            btn_EditMovie.Name = "btn_EditMovie";
            btn_EditMovie.Size = new Size(127, 23);
            btn_EditMovie.TabIndex = 9;
            btn_EditMovie.Text = "Edit or Delete Movie";
            btn_EditMovie.UseVisualStyleBackColor = true;
            btn_EditMovie.Click += btn_EditMovie_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(159, 140);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 26;
            label5.Text = "Manage Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(502, 140);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 27;
            label1.Text = "Manage Movies";
            // 
            // Form_AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btn_EditMovie);
            Controls.Add(btn_AddMovie);
            Controls.Add(btn_EditUser);
            Controls.Add(btn_AddUser);
            Controls.Add(btn_Back);
            Controls.Add(lbl_Title_SignUp);
            Name = "Form_AdminView";
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
    }
}