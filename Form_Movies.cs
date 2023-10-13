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
    public partial class frm_Movies : Form
    {
        List<Movie> movies;

        public frm_Movies()
        {
            InitializeComponent();

            movies = new List<Movie>()
            {
                new Movie("Expend4ables", "Action", new Duration(2, 43)),
                new Movie("Barbie", "Adventure", new Duration(1, 54)),
            };

            // this string needs to match the name of a Movie field (i.e. Title, Genre, etc)
            listbox_Movies.DisplayMember = "Title"; 
            listbox_Movies.DataSource = movies;
        }

        public void frm_Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
