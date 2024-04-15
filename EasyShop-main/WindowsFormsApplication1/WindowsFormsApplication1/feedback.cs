using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class feedback : Form
    {
        //open connection
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=system");
        private string placeholderText = "Enter comments(0/300)";

        public feedback()
        {
            InitializeComponent();

            commentBox.Text = "Enter comments(0/300)";
            commentBox.ForeColor = System.Drawing.SystemColors.GrayText;

            // Attach event handlers
            commentBox.GotFocus += RichTextBox_GotFocus;
            commentBox.LostFocus += RichTextBox_LostFocus;
            ratingBox.Focus();
        }

        public String cust, order;
        private void rating_TextChanged(object sender, EventArgs e)
        {

        }
        private void RichTextBox_GotFocus(object sender, EventArgs e)
        {
            if (commentBox.Text == placeholderText)
            {
                commentBox.Text = "";
                commentBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void RichTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(commentBox.Text))
            {
                commentBox.Text = placeholderText;
                commentBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void feedback_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Get rating and comments from textboxes
            String comments = commentBox.Text;

            bool result = double.TryParse(ratingBox.Text, out double rating);
            if (result == false)
            {
                MessageBox.Show("Please enter a valid rating!");
                // clear the text boxes
                ratingBox.Text = "";
                commentBox.Text = "";
                return;
            }


            // Insert order_id, customer_id, r, c into feedback table

            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "INSERT INTO feedback VALUES('" + order + "','" + cust + "','" + rating + "','" + comments + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Feedback Added Successfully");


            // open employee form
            employee emp = new employee();
            this.Close();
            emp.Show();
        }
    }
}
