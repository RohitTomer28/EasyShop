namespace WindowsFormsApplication1
{
    partial class item_det
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
            this.back = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.show_all = new System.Windows.Forms.Button();
            this.empgrid = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(20, 38);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 35);
            this.back.TabIndex = 0;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(826, 126);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(179, 69);
            this.search.TabIndex = 1;
            this.search.UseVisualStyleBackColor = false;
            // 
            // show_all
            // 
            this.show_all.BackColor = System.Drawing.Color.Transparent;
            this.show_all.FlatAppearance.BorderSize = 0;
            this.show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_all.Location = new System.Drawing.Point(460, 460);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(179, 70);
            this.show_all.TabIndex = 2;
            this.show_all.UseVisualStyleBackColor = false;
            // 
            // empgrid
            // 
            this.empgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empgrid.Location = new System.Drawing.Point(109, 210);
            this.empgrid.Name = "empgrid";
            this.empgrid.RowHeadersWidth = 51;
            this.empgrid.RowTemplate.Height = 24;
            this.empgrid.Size = new System.Drawing.Size(832, 219);
            this.empgrid.TabIndex = 9;
            // 
            // empid
            // 
            this.empid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.Location = new System.Drawing.Point(219, 135);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(592, 48);
            this.empid.TabIndex = 8;
            // 
            // item_det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.empgrid);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "item_det";
            this.Text = "item_det";
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.DataGridView empgrid;
        private System.Windows.Forms.TextBox empid;
    }
}