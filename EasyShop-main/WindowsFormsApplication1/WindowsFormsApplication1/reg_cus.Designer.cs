namespace WindowsFormsApplication1
{
    partial class reg_cus
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
            this.register = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.ph = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(24, 312);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(61, 30);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Location = new System.Drawing.Point(247, 304);
            this.register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(107, 47);
            this.register.TabIndex = 3;
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(117, 121);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(437, 37);
            this.name.TabIndex = 8;
            // 
            // ph
            // 
            this.ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph.Location = new System.Drawing.Point(218, 179);
            this.ph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ph.Multiline = true;
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(336, 35);
            this.ph.TabIndex = 9;
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Normal",
            "Loyalty"});
            this.statusBox.Location = new System.Drawing.Point(247, 234);
            this.statusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(141, 33);
            this.statusBox.TabIndex = 10;
            this.statusBox.Text = "Normal";
            // 
            // reg_cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.WhatsApp_Image_2024_04_07_at_17_47_18_9ba544e3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.name);
            this.Controls.Add(this.register);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Name = "reg_cus";
            this.Text = "reg_cus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox ph;
        private System.Windows.Forms.ComboBox statusBox;
    }
}