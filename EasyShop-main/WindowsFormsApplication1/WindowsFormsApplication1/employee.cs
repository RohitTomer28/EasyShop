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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transaction transaction = new transaction();
            this.Close();
            transaction.Show(); 
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
