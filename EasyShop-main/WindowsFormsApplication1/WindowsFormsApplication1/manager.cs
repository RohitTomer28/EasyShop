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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delivery delivery = new delivery();
            this.Close();
            delivery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emp_det emp = new emp_det();  
            this.Close();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cust_det cust = new cust_det();
            this.Close();
            cust.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            this.Close();
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            item_det item = new item_det(); 
            this.Close();
            item.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
