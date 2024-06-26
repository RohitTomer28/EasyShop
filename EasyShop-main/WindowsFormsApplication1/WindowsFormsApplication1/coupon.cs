﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class coupon : Form
    {
        OracleConnection conn;
        public coupon()
        {
            InitializeComponent();
            //open connection
            conn = new OracleConnection("Data Source=localhost;User Id=system;Password=1234;");
            conn.Open();
        }
        public String order, cust;
        public double t;

        int resx = 0;
        int resy = 0;

        private void coupon_Load(object sender, EventArgs e)
        {
            total_label.Text = t.ToString();
            Form f = (Form)sender;

            resy = f.Size.Height;
            resx = f.Size.Width;

            f.WindowState = FormWindowState.Maximized;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //open feedback form
            feedback f = new feedback();
            f.order = order;
            f.cust = cust;
            f.Show();
            this.Close();
        }

        private void resChange(object sender, EventArgs e)
        {
            Form f = (Form)sender;

            float dx = f.Size.Width / (float)resx;
            float dy = f.Size.Height / (float)resy;



            Control s = GetNextControl(f, true);

            while (s != null)
            {


                Size size = new Size((int)(s.Size.Width * dx), (int)(s.Size.Height * dy));

                int newx = (int)(s.Location.X * 1.02 * dx);
                int newy = (int)(s.Location.Y * 1.04 * dy);

                Point p = new Point(newx, newy);


                s.Size = size;
                s.Location = p;
                s = f.GetNextControl(s, true);


            }

            resx = f.Size.Width;
            resy = f.Size.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select discount from coupon where coupon_code = '" + code.Text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Coupon applied successfully");
                // calculate new total by multiplying with discount and display in label
                t = t * Convert.ToDouble(dr.GetString(0));
                total_label.Text = t.ToString();

                //update transaction table with new total
                cmd.CommandText = "update transactions set total_amount = " + t + " where order_id = " + order;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Total amount updated successfully");
            }

            else
            {
                MessageBox.Show("Invalid coupon");
            }
        }
    }
}
