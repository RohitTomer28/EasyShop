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
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class delivery : Form
    {
        public delivery()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            manager manager = new manager();
            this.Close();
            manager.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            OracleConnection app = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=project");
            app.Open();

            string itemid = item_id.Text;

            int qty = int.Parse(quantity.Text);

            // get date from datetimepicker1
            DateTime date = dateTimePicker1.Value;
            string date1 = date.ToString("dd-MMM-yy");
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = app;

            cmd.CommandText = "INSERT INTO delivery VALUES('" + qty + "','" + itemid + "','" + date1 + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delivery Added Successfully");
        }
    }
}
