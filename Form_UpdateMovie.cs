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
    public partial class Form_UpdateMovie : Form
    {
        public Form_UpdateMovie()
        {
            InitializeComponent();
            movieGrid.DataSource = GlobalData.Movies;
        }

        private void Form_UpdateMovie_Load(object sender, EventArgs e)
        {

        }

        private void movieGrid_CelLClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = movieGrid.Rows[index];
            textBox_MovieID.Text = selectedRow.Cells[0].Value.ToString();
            textBox_Title.Text = selectedRow.Cells[1].Value.ToString();
            textBox_Genre.Text = selectedRow.Cells[2].Value.ToString();
            textBox_Hours.Text = selectedRow.Cells[3].Value.ToString();
            textBox_Minutes.Text = selectedRow.Cells[4].Value.ToString();
            textBox_Description.Text = selectedRow.Cells[8].Value.ToString();
            textBox_Poster.Text = selectedRow.Cells[10].Value.ToString();

            int year = int.Parse(selectedRow.Cells[5].Value.ToString());
            int month = int.Parse(selectedRow.Cells[6].Value.ToString());
            int day = int.Parse(selectedRow.Cells[7].Value.ToString());

            DateTime selectedDate = new DateTime(year, month, day);
            dateTimePicker_ReleaseDate.Value = selectedDate;
        }

    }
}
