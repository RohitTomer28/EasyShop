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
    public partial class feedback : Form
    {
        private string placeholderText = "Enter comments(0/300)";

        public feedback()
        {
            InitializeComponent();

            comments.Text = "Enter comments(0/300)";
            comments.ForeColor = System.Drawing.SystemColors.GrayText;

            // Attach event handlers
            comments.GotFocus += RichTextBox_GotFocus;
            comments.LostFocus += RichTextBox_LostFocus;
            rating.Focus();
        }
        private void rating_TextChanged(object sender, EventArgs e)
        {

        }
        private void RichTextBox_GotFocus(object sender, EventArgs e)
        {
            if (comments.Text == placeholderText)
            {
                comments.Text = "";
                comments.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void RichTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comments.Text))
            {
                comments.Text = placeholderText;
                comments.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }
    }
}
