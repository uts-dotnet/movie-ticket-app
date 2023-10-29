using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieTicketApp.src.Managers;
using MovieTicketApp.src.User;

namespace MovieTicketApp
{
    public partial class frm_ChangePassword : Form
    {
        public frm_ChangePassword()
        {
            InitializeComponent();
            lbl_PWLengthWarning.Visible = false;
            lbl_PWMatchWarning.Visible = false;
        }

        private void btn_ChangePW_Click(object sender, EventArgs e)
        {
            string newPassword = textBox_newPW.Text;
            string confirmNewPassword = textBox_confirmPW.Text;

            // Check if the new password is at least 4 characters long
            if (newPassword.Length < 4)
            {
                lbl_PWLengthWarning.Visible = true;
                return;
            }
            else
            {
                lbl_PWLengthWarning.Visible = false;
            }

            // Check if the new password and confirm new password match
            if (newPassword != confirmNewPassword)
            {
                lbl_PWMatchWarning.Visible = true;
                return;
            }
            else
            {
                lbl_PWMatchWarning.Visible = false;
            }

            // If input is valid, update the password and perform any necessary actions
            User currentUser = CurrentUserManager.Instance.CurrentUser;

            if (currentUser != null)
            {
                UserData.ChangePassword(currentUser.Id, newPassword);
            }

            // Provide feedback to the user (e.g., show a success message)
            Form_UserProfile form = new Form_UserProfile();
            form.Show();
            this.Close();

            FileManager.SaveUserData();
            MessageBox.Show("Password changed successfully.");
        }

        private void btn_BackToMovies_Click(object sender, EventArgs e)
        {
            Form_UserProfile profile = new Form_UserProfile();
            profile.Show();
            this.Close();
        }
    }
}
