namespace WindowsFormsApplication1
{
    partial class cust_det
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
            this.show_all = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.cusgrid = new System.Windows.Forms.DataGridView();
            this.cusph = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cusgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(996, 172);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(201, 86);
            this.search.TabIndex = 2;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // show_all
            // 
            this.show_all.BackColor = System.Drawing.Color.Transparent;
            this.show_all.FlatAppearance.BorderSize = 0;
            this.show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_all.Location = new System.Drawing.Point(501, 580);
            this.show_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(201, 86);
            this.show_all.TabIndex = 3;
            this.show_all.UseVisualStyleBackColor = false;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(32, 599);
            this.back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 48);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // cusgrid
            // 
            this.cusgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusgrid.Location = new System.Drawing.Point(264, 266);
            this.cusgrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusgrid.Name = "cusgrid";
            this.cusgrid.RowHeadersWidth = 51;
            this.cusgrid.RowTemplate.Height = 24;
            this.cusgrid.Size = new System.Drawing.Size(806, 266);
            this.cusgrid.TabIndex = 9;
            // 
            // cusph
            // 
            this.cusph.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusph.Location = new System.Drawing.Point(393, 189);
            this.cusph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusph.Name = "cusph";
            this.cusph.Size = new System.Drawing.Size(571, 56);
            this.cusph.TabIndex = 8;
            // 
            // cust_det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cusgrid);
            this.Controls.Add(this.cusph);
            this.Controls.Add(this.back);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.search);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cust_det";
            this.Text = "cust_det";
            ((System.ComponentModel.ISupportInitialize)(this.cusgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView cusgrid;
        private System.Windows.Forms.TextBox cusph;
    }
}