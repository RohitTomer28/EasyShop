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
            this.back.Location = new System.Drawing.Point(38, 481);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 46);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Location = new System.Drawing.Point(370, 468);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(160, 72);
            this.register.TabIndex = 3;
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(176, 186);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(654, 55);
            this.name.TabIndex = 8;
            // 
            // ph
            // 
            this.ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph.Location = new System.Drawing.Point(327, 275);
            this.ph.Multiline = true;
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(502, 52);
            this.ph.TabIndex = 9;
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Normal",
            "Loyalty"});
            this.statusBox.Location = new System.Drawing.Point(370, 360);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(210, 45);
            this.statusBox.TabIndex = 10;
            this.statusBox.Text = "Normal";
            this.statusBox.SelectedIndexChanged += new System.EventHandler(this.statusBox_SelectedIndexChanged);
            // 
            // reg_cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.WhatsApp_Image_2024_04_07_at_17_47_18_9ba544e3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.ph);
            this.Controls.Add(this.name);
            this.Controls.Add(this.register);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reg_cus";
            this.Text = "reg_cus";
            this.Load += new System.EventHandler(this.reg_cus_Load);
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