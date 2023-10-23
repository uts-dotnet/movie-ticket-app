using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApp
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        private void frm_SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close(); // if the form is not closed it'll cause a conflict between Visual Studio and the executable file
        }

        private void lbl_LogIn_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            loginForm.Show();
            this.Hide();
        }

    }
}
