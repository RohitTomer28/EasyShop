namespace WindowsFormsApplication1
{
    partial class emp_det
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
            this.search = new System.Windows.Forms.Button();
            this.show_emp = new System.Windows.Forms.Button();
            this.disp_hr = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.empid = new System.Windows.Forms.TextBox();
            this.empgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(212, 373);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 54);
            this.search.TabIndex = 2;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // show_emp
            // 
            this.show_emp.BackColor = System.Drawing.Color.Transparent;
            this.show_emp.FlatAppearance.BorderSize = 0;
            this.show_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_emp.Location = new System.Drawing.Point(644, 125);
            this.show_emp.Margin = new System.Windows.Forms.Padding(2);
            this.show_emp.Name = "show_emp";
            this.show_emp.Size = new System.Drawing.Size(135, 59);
            this.show_emp.TabIndex = 3;
            this.show_emp.UseVisualStyleBackColor = false;
            this.show_emp.Click += new System.EventHandler(this.show_emp_Click);
            // 
            // disp_hr
            // 
            this.disp_hr.BackColor = System.Drawing.Color.Transparent;
            this.disp_hr.FlatAppearance.BorderSize = 0;
            this.disp_hr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disp_hr.Location = new System.Drawing.Point(479, 373);
            this.disp_hr.Margin = new System.Windows.Forms.Padding(2);
            this.disp_hr.Name = "disp_hr";
            this.disp_hr.Size = new System.Drawing.Size(135, 59);
            this.disp_hr.TabIndex = 4;
            this.disp_hr.UseVisualStyleBackColor = false;
            this.disp_hr.Click += new System.EventHandler(this.disp_hr_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(26, 386);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(78, 35);
            this.back.TabIndex = 5;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(309, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(647, 39);
            this.textBox1.TabIndex = 4;
            // 
            // empid
            // 
            this.empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.Location = new System.Drawing.Point(266, 139);
            this.empid.Margin = new System.Windows.Forms.Padding(2);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(349, 39);
            this.empid.TabIndex = 6;
            this.empid.TextChanged += new System.EventHandler(this.empid_TextChanged);
            // 
            // empgrid
            // 
            this.empgrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.empgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empgrid.Location = new System.Drawing.Point(113, 188);
            this.empgrid.Margin = new System.Windows.Forms.Padding(2);
            this.empgrid.Name = "empgrid";
            this.empgrid.RowHeadersWidth = 51;
            this.empgrid.RowTemplate.Height = 24;
            this.empgrid.Size = new System.Drawing.Size(570, 155);
            this.empgrid.TabIndex = 7;
            // 
            // emp_det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empgrid);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.back);
            this.Controls.Add(this.disp_hr);
            this.Controls.Add(this.show_emp);
            this.Controls.Add(this.search);
            this.DoubleBuffered = true;
            this.Name = "emp_det";
            this.Text = "emp_det";
            this.Load += new System.EventHandler(this.emp_det_Load);
            this.Resize += new System.EventHandler(this.resChange);
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button show_emp;
        private System.Windows.Forms.Button disp_hr;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.DataGridView empgrid;
    }
}