﻿using System;
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
            userGrid.DataSource = GlobalData.Movies;
        }

        private void Form_UpdateMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
