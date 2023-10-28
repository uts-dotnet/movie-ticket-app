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
    public partial class Form_Receipt : Form
    {
        public Form_Receipt()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void PopulateListView()
        {
            listview_Receipt.View = View.Details;
            listview_Receipt.Columns.Add("Item", 100);
            listview_Receipt.Columns.Add("Qty", 100);
            listview_Receipt.Columns.Add("Price", 100);
            listview_Receipt.Columns.Add("Amount", 100);
        }
    }
}
