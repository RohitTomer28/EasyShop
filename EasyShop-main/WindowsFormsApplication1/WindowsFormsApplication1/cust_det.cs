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
        int resx = 0;
        int resy = 0;

        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=system;Password=1234");
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

        private void cust_det_Load(object sender, EventArgs e)
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

                int newx = (int)(s.Location.X * 1.01 * dx);
                int newy = (int)(s.Location.Y * 1.03 * dy);

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
