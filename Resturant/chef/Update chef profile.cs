﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.chef
{
    public partial class Update_chef_profile : Form
    {
        public Update_chef_profile()
        {
            InitializeComponent();
        }

        private void lblUpdateName_Click(object sender, EventArgs e)
        {

        }

        private void btnBackUpdate_Click(object sender, EventArgs e)
        {
            ChefMainPage mainPage = new ChefMainPage();
            mainPage.Show();
            this.Hide();
        }

        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {

        }
    }
}