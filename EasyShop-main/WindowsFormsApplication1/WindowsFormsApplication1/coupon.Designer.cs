namespace WindowsFormsApplication1
{
    partial class coupon
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
            this.code = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.code.Location = new System.Drawing.Point(417, 242);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(374, 50);
            this.code.TabIndex = 0;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F);
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(125)))), ((int)(((byte)(96)))));
            this.total.Location = new System.Drawing.Point(246, 371);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 51);
            this.total.TabIndex = 1;
            this.total.Click += new System.EventHandler(this.label1_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Location = new System.Drawing.Point(978, 231);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(146, 63);
            this.check.TabIndex = 2;
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Location = new System.Drawing.Point(488, 523);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(226, 105);
            this.submit.TabIndex = 3;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.BackColor = System.Drawing.Color.Transparent;
            this.total_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.Green;
            this.total_label.Location = new System.Drawing.Point(246, 371);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(152, 51);
            this.total_label.TabIndex = 4;
            this.total_label.Text = "label1";
            // 
            // coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.coupon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 691);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.check);
            this.Controls.Add(this.total);
            this.Controls.Add(this.code);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "coupon";
            this.Text = "coupon";
            this.Load += new System.EventHandler(this.coupon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label total_label;
    }
}