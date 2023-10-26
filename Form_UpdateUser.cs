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
    public partial class Form_UpdateUser : Form
    {
        public Form_UpdateUser()
        {
            InitializeComponent();

            // Create a list of available security levels.
            List<string> securityLevels = new List<string>
        {
            "Admin",
            "User"
        };

            // Set the data source for the ComboBox column.
            (dataGridView1.Columns["SecurityLevel"] as DataGridViewComboBoxColumn).DataSource = securityLevels;


            List<User> users = new List<User>();
            //populate the list to show the content in the Data grid

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form_AdminView admin = new Form_AdminView();
            admin.Show();
            this.Close();
        }
    }
}
