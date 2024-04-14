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
    public partial class hoursheet : Form
    {
        OracleConnection conn;
        public hoursheet()
        {
            InitializeComponent();
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=system;Password=1234");
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            emp_det emp_Det = new emp_det();
            this.Close();
            emp_Det.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
                ConnectDB();

                //select month from combo box
                string month = comboBox1.Text;

                // display the hours worked by employees in the selected month(January, february, etc) from employee_hours table
                using (OracleCommand cmd = new OracleCommand("Select * from employee_hours where trim(to_char(w_date, 'Month')) = '" + month + "'", conn))
                {
                    using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();

            using (OracleCommand cmd = new OracleCommand("Select * from employee_hours", conn))
            {
                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            conn.Close();
        }

        private void show_all_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
