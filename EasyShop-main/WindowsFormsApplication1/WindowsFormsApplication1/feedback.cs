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
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521;PASSWORD=1234;USER ID=project");
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            this.Close();
            employee.Show();

            transaction transaction = new transaction();

            String order_id = transaction.order;
            String customer_id = transaction.cust;

            // Get rating and comments from textboxes
            String comments = commentBox.Text;

            MessageBox.Show($"{ratingBox.Text}");

            bool result = double.TryParse(ratingBox.Text, out double rating);
            if (result == false)
            {
                MessageBox.Show("Please enter a valid rating");
                // clear the text boxes
                ratingBox.Text = "";
                commentBox.Text = "";
                return;
            }

            // Insert order_id, customer_id, r, c into feedback table

            conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO feedback VALUES('" + order_id + "','" + customer_id + "','" + rating + "','" + comments + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Feedback Added Successfully");
                

                // open employee form
                employee emp = new employee();
                this.Close();
                emp.Show();
        }
    }
}
