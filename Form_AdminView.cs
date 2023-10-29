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

        private void button1_Click(object sender, EventArgs e)
        {
            Form_UpdateSessions form = new Form_UpdateSessions();
            form.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            FileManager.Save();
            frm_Login logout = new frm_Login();
            logout.Show();
            this.Hide();
        }
    }
}
