namespace WindowsFormsApplication1
{
    partial class feedback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(375, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 77);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(288, 154);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratingBox.Multiline = true;
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(158, 46);
            this.ratingBox.TabIndex = 4;
            this.ratingBox.Text = "l";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(350, 223);
            this.commentBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(526, 192);
            this.commentBox.TabIndex = 5;
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "feedback";
            this.Text = "feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox commentBox;
    }
}