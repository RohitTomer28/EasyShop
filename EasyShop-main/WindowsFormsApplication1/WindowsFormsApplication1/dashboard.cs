using System;
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
    public partial class dashboard : Form
    {
        //open connection
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=system");
        public dashboard()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            manager manager = new manager();
            this.Close();
            manager.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //display number of customers in label1
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from customer_details";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr.GetString(0);
            }
            conn.Close();

            //display percentage of special customers/total customers in label2
            conn.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select count(*) from customer_details where status = 'loyalty'";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                double special = Convert.ToDouble(dr1.GetString(0));
                double total = Convert.ToDouble(label1.Text);
                double percent = (special / total) * 100;
                percent = Math.Round(percent, 2); //display percentage with 2 decimal places
                //display percentage with 2 decimal places
                label2.Text = percent.ToString() + "%";
            }
            conn.Close();

            // display sum of all transactions in label3
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select sum(total_amount) from transactions";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                label3.Text = dr2.GetString(0);
            }
            conn.Close();

            // display average rating in label4
            conn.Open();
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "select avg(rating) from feedback";
            cmd3.CommandType = CommandType.Text;
            OracleDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                label4.Text = dr3.GetString(0);
            }
            conn.Close();

            // display number of transactions in label5
            conn.Open();
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "select count(*) from transactions";
            cmd4.CommandType = CommandType.Text;
            OracleDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                label5.Text = dr4.GetString(0);
            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
