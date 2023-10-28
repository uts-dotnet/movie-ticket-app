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
    public partial class Form_UpdateUser : Form
    {
        public Form_UpdateUser()
        {
            InitializeComponent();
            userGrid.DataSource = GlobalData.UserData;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form_AdminView admin = new Form_AdminView();
            admin.Show();
            this.Close();
        }

        private void userGrid_CelLClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = userGrid.Rows[index];
            textBox_UserId.Text = selectedRow.Cells[0].Value.ToString();
            textBox_Username.Text = selectedRow.Cells[1].Value.ToString();
            textBox_Password.Text = selectedRow.Cells[2].Value.ToString();
            textBox_firstName.Text = selectedRow.Cells[3].Value.ToString();
            textBox_lastName.Text = selectedRow.Cells[4].Value.ToString();

        }
    }
}
