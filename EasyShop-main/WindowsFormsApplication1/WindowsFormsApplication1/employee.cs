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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transaction trans1 = new transaction();
            this.Close();
            trans1.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
        reg_cus reg_Cus = new reg_cus();    
        this.Close();
        reg_Cus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        stock stock = new stock();
            this.Close();
            stock.Show();
        }
        int resx = 0;
        int resy = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

            Form f = (Form)sender;

            resy = f.Size.Height;
            resx = f.Size.Width;

            f.WindowState = FormWindowState.Maximized;

        }



        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
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

                int newx = (int)(s.Location.X * 1.02 * dx);
                int newy = (int)(s.Location.Y * 1.07 * dy);

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
