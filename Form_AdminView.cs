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
    public partial class Form_AdminView : Form
    {
        public Form_AdminView()
        {
            InitializeComponent();
        }

        private void btn_EditMovie_Click(object sender, EventArgs e)
        {
            Form_UpdateMovie form = new Form_UpdateMovie();
            form.Show();
            this.Hide();

        }

        private void btn_EditUser_Click_1(object sender, EventArgs e)
        {
            Form_UpdateUser form = new Form_UpdateUser();
            form.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            frm_Login login = new frm_Login();
            login.Show();
            this.Close();


        }

    }
}
