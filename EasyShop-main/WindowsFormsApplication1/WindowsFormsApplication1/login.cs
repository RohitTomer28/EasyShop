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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToLower()) == "manager" && textBox2.Text == "mpass")
            {
                manager m=new manager();
                MessageBox.Show("Manager Logged In!");
                m.Show();

            }
            else if ((textBox1.Text.ToLower()) == "employee" && textBox2.Text == "epass")
            {
                MessageBox.Show("Employee Logged In!");
                employee form2 = new employee();
                form2.Show();
               
            }
            else
                MessageBox.Show("Incorrect Username or Password");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
