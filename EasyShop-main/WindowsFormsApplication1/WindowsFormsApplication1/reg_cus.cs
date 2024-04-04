using Oracle.ManagedDataAccess.Client;
using System;
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
    public partial class reg_cus : Form
    {
        public reg_cus()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            this.Close();
            employee.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {

            OracleConnection app = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=project");
            app.Open();

            string n = name.Text;
            
            // parse ph.Text
            String phone = ph.Text;

            string firstn = n.Split(' ')[0];
            string lastn = n.Split(' ')[1];

            int randid = new Random().Next(100000, 999999);

            string status = "normal";
            string custId = "C" + randid;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = app;

            cmd.CommandText = "INSERT INTO customer_details VALUES('" + firstn + "','" + lastn + "','" + custId + "','" + phone + "','" + status + "')";


            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Registered Successfully");



        }
    }
}
