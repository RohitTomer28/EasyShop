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
    public partial class emp_det : Form
    {
        OracleConnection conn;
        public emp_det()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=system;Password=1234");
            conn.Open();
        }
        private void disp_hr_Click(object sender, EventArgs e)
        {
            hoursheet hoursheet = new hoursheet();
            this.Close();  
            hoursheet.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            manager manager = new manager();
            manager.Show();
            this.Close();
        }

        private void empid_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            ConnectDB();

            using (OracleCommand cmd = new OracleCommand("Select * from employee", conn))
            {
                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    empgrid.DataSource = dt;
                }
            }
            conn.Close();
        }

        private void show_emp_Click(object sender, EventArgs e)
        {
            ConnectDB();

            // Assuming 'textBoxEmpId' is the TextBox where the emp_id is entered.
            string empId = empid.Text;

            using (OracleCommand cmd = new OracleCommand("SELECT * FROM employee WHERE emp_id = :empId", conn))
            {
                // Add the parameter to the command to filter by emp_id
                cmd.Parameters.Add(new OracleParameter("empId", empId));

                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    empgrid.DataSource = dt; // 'empgrid' is assumed to be the DataGridView
                }
            }
            conn.Close();
        }
    }
}
