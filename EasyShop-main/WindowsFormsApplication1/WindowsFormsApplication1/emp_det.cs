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
    public partial class emp_det : Form
    {
        public emp_det()
        {
            InitializeComponent();
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
    }
}
