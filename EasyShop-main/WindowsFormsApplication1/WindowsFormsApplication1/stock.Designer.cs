namespace WindowsFormsApplication1
{
    partial class stock
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
            this.show_all = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.stockgrid = new System.Windows.Forms.DataGridView();
            this.itemid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // show_all
            // 
            this.show_all.BackColor = System.Drawing.Color.Transparent;
            this.show_all.FlatAppearance.BorderSize = 0;
            this.show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_all.Location = new System.Drawing.Point(518, 585);
            this.show_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(200, 92);
            this.show_all.TabIndex = 0;
            this.show_all.UseVisualStyleBackColor = false;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(28, 50);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 46);
            this.back.TabIndex = 1;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(932, 160);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(196, 94);
            this.search.TabIndex = 2;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // stockgrid
            // 
            this.stockgrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.stockgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockgrid.Location = new System.Drawing.Point(271, 248);
            this.stockgrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stockgrid.Name = "stockgrid";
            this.stockgrid.RowHeadersWidth = 51;
            this.stockgrid.RowTemplate.Height = 24;
            this.stockgrid.Size = new System.Drawing.Size(618, 287);
            this.stockgrid.TabIndex = 11;
            // 
            // itemid
            // 
            this.itemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemid.Location = new System.Drawing.Point(234, 169);
            this.itemid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(680, 71);
            this.itemid.TabIndex = 10;
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 704);
            this.Controls.Add(this.stockgrid);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.show_all);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "stock";
            this.Text = "stock";
            ((System.ComponentModel.ISupportInitialize)(this.stockgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView stockgrid;
        private System.Windows.Forms.TextBox itemid;
    }
}