﻿namespace WindowsFormsApplication1
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
            this.itemgrid = new System.Windows.Forms.DataGridView();
            this.itemid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(22, 48);
            this.back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 44);
            this.back.TabIndex = 0;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(929, 158);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(201, 86);
            this.search.TabIndex = 1;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // show_all
            // 
            this.show_all.BackColor = System.Drawing.Color.Transparent;
            this.show_all.FlatAppearance.BorderSize = 0;
            this.show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_all.Location = new System.Drawing.Point(518, 575);
            this.show_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(201, 88);
            this.show_all.TabIndex = 2;
            this.show_all.UseVisualStyleBackColor = false;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // itemgrid
            // 
            this.itemgrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.itemgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemgrid.Location = new System.Drawing.Point(123, 262);
            this.itemgrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemgrid.Name = "itemgrid";
            this.itemgrid.RowHeadersWidth = 51;
            this.itemgrid.RowTemplate.Height = 24;
            this.itemgrid.Size = new System.Drawing.Size(936, 274);
            this.itemgrid.TabIndex = 9;
            // 
            // itemid
            // 
            this.itemid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemid.Location = new System.Drawing.Point(246, 169);
            this.itemid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(666, 56);
            this.itemid.TabIndex = 8;
            // 
            // item_det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.itemgrid);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "item_det";
            this.Text = "item_det";
            ((System.ComponentModel.ISupportInitialize)(this.itemgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.DataGridView itemgrid;
        private System.Windows.Forms.TextBox itemid;
    }
}