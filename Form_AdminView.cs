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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form_UserProfile form = new Form_UserProfile();
            form.Show();
            this.Close();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            Form_UpdateUser form = new Form_UpdateUser();
            form.Show();
            this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            Form_CreateNewUser form = new Form_CreateNewUser();
            form.Show();
            this.Close();
        }

        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            Form_CreateMovie form = new Form_CreateMovie();
            form.Show();
            this.Close();
        }

        private void btn_EditMovie_Click(object sender, EventArgs e)
        {
            Form_UpdateMovie form = new Form_UpdateMovie();
            form.Show();
            this.Close();
   
        }
    }
}
