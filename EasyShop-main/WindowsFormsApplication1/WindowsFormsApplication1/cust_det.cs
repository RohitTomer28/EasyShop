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
    public partial class cust_det : Form
    {
        OracleConnection conn;
        public cust_det()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=project;Password=1234");
            conn.Open();
        }
        private void back_Click(object sender, EventArgs e)
        {
            manager manager = new manager();
            this.Close();
            manager.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            ConnectDB();
            string phno = cusph.Text;

            using (OracleCommand cmd = new OracleCommand("SELECT * FROM customer_details WHERE phone_number= :phno", conn))
            {
                cmd.Parameters.Add(new OracleParameter("phno", phno));

                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    cusgrid.DataSource = dt; 
                }
            }
            conn.Close();
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            ConnectDB();

            using (OracleCommand cmd = new OracleCommand("Select * from customer_details", conn))
            {
                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    cusgrid.DataSource = dt;
                }
            }
            conn.Close();
        }
    }
}
