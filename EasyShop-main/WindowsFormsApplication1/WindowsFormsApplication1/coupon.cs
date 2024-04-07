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
        private void coupon_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from coupon where coupon_id = '" + code.Text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Coupon applied successfully");
                /*this.Hide();*/
            }
            else
            {
                MessageBox.Show("Invalid coupon");
            }
        }
    }
}
