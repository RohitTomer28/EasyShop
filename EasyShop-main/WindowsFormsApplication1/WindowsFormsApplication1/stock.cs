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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        OracleConnection conn;

        private void back_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            this.Close();
            employee.Show();
        }

        public void ConnectDB()
        {
            conn = new OracleConnection("Data Source=localhost:1521;Persist Security Info=True;User ID=system;Password=1234");
            conn.Open();
        }

        private void show_all_Click(object sender, EventArgs e)
        {

            ConnectDB();

            using (OracleCommand cmd = new OracleCommand("Select * from stock", conn))
            {
                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    stockgrid.DataSource = dt;
                }
            }
            conn.Close();

        }

        private void search_Click(object sender, EventArgs e)
        {
            ConnectDB();

            string item_id = itemid.Text;

            using (OracleCommand cmd = new OracleCommand("SELECT * FROM stock WHERE item_id= :itemid", conn))
            {
                cmd.Parameters.Add(new OracleParameter("item_id", item_id));

                using (OracleDataAdapter oda = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    stockgrid.DataSource = dt;
                }
            }
        }

        private void stock_Load(object sender, EventArgs e)
        {
            Form f = (Form)sender;

            int resy = f.Size.Height;
            int resx = f.Size.Width;

            f.WindowState = FormWindowState.Maximized;

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
        }
    }
}
