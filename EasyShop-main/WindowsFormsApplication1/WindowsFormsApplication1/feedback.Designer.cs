﻿namespace WindowsFormsApplication1
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
            this.rating = new System.Windows.Forms.TextBox();
            this.comments = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rating
            // 
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rating.Location = new System.Drawing.Point(248, 124);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(385, 41);
            this.rating.TabIndex = 1;
            this.rating.TextChanged += new System.EventHandler(this.rating_TextChanged);
            // 
            // comments
            // 
            this.comments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments.Location = new System.Drawing.Point(317, 195);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(460, 152);
            this.comments.TabIndex = 2;
            this.comments.Text = "";
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.rating);
            this.DoubleBuffered = true;
            this.Name = "feedback";
            this.Text = "feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.RichTextBox comments;
    }
}