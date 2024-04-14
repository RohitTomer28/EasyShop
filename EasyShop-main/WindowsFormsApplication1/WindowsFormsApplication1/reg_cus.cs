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
            try
            {
                OracleConnection app = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=system");
                app.Open();

                string n = name.Text;

                // parse ph.Text
                String phone = ph.Text;

                //check if only numbers are entered in phone number
                if (phone.Any(char.IsLetter))
                {
                    MessageBox.Show("Please enter only numbers in phone number");
                    return;
                }

                //check if phone number is 10 digits
                if (phone.Length != 10)
                {
                    MessageBox.Show("Please enter a valid phone number");
                    return;
                }

                string firstn = n.Split(' ')[0];

                //take last name only if n has more than 1 word
                string lastn = n.Split(' ').Length > 1 ? n.Split(' ')[1] : "";

                // take status from combobox
                string status = statusBox.Text;

                int randid = new Random().Next(100000, 999999);
                string custId = "CUST" + randid;

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = app;

                cmd.CommandText = "INSERT INTO customer_details VALUES('" + firstn + "','" + lastn + "','" + custId + "','" + phone + "','" + status + "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Registered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reg_cus_Load(object sender, EventArgs e)
        {

        }
    }
}
