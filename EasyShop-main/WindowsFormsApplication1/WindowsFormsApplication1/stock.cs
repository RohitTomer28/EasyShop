﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            this.Close();
            employee.Show();
        }
    }
}
