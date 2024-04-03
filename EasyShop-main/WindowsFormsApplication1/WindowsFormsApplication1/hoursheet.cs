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

                // Assuming 'textBoxMonth' is the TextBox where the month is entered.
                string month = textBox1.Text;

                // Modify the SQL command to filter by the month.
                // The 'TO_CHAR' function is used to extract the month part from the date.
                // Ensure the date format 'MM' matches the format in which the month is entered.
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM employee_hours WHERE TO_CHAR(w_date, 'MM') = :month", conn))
                {
                    // Add the parameter to the command to filter by month
                    cmd.Parameters.Add(new OracleParameter("month", month));

                    using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        dataGridView1.DataSource = dt; // 'dataGridView1' is assumed to be the DataGridView
                    }
                }
                conn.Close();
            

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
    }
}
