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
            OracleConnection app = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=system");
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
        int resx = 0;
        int resy = 0;
        private void delivery_Load(object sender, EventArgs e)
        {

            Form f = (Form)sender;

            resy = f.Size.Height;
            resx = f.Size.Width;

            f.WindowState = FormWindowState.Maximized;

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

                int newx = (int)(s.Location.X * dx);
                int newy = (int)(s.Location.Y * dy);

                Point p = new Point(newx, newy);


                s.Size = size;
                s.Location = p;
                s = f.GetNextControl(s, true);


            }

            resx = f.Size.Width;
            resy = f.Size.Height;
        }
    }
}
