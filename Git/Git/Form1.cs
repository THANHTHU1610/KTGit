﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( txtUsername.Text == "admin" && txtPassword.Text == "admin" )
            {
                Form2 t = new Form2();
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thất bại ");
            }
        }
    }
}
