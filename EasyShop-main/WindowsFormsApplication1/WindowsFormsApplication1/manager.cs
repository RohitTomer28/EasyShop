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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delivery delivery = new delivery();
            this.Close();
            delivery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emp_det emp = new emp_det();  
            this.Close();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cust_det cust = new cust_det();
            this.Close();
            cust.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            this.Close();
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            item_det item = new item_det(); 
            this.Close();
            item.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void manager_Load(object sender, EventArgs e)
        {
            Form f = (Form)sender;

            int resy = f.Size.Height;
            int resx = f.Size.Width;

            f.WindowState = FormWindowState.Maximized;

            float dx = f.Size.Width / (float)resx;
            float dy = f.Size.Height / (float)resy;



            Control s = GetNextControl(f, true);

            while (s != null)
            {


                Size size = new Size((int)(s.Size.Width * dx), (int)(s.Size.Height * dy));

                int newx = (int)(s.Location.X * dx);
                int newy = (int)((s.Location.Y * 1.07) * dy);

                Point p = new Point(newx, newy);


                s.Size = size;
                s.Location = p;
                s = f.GetNextControl(s, true);


            }
        }
    }
}
