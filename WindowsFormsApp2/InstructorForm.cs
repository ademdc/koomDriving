﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }
    }
}
