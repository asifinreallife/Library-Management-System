namespace csharpproject
{
    partial class Admin_Panel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminlogoutbutton = new System.Windows.Forms.Button();
            this.userregbutton = new System.Windows.Forms.Button();
            this.addremovebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.adminlogoutbutton);
            this.panel1.Controls.Add(this.userregbutton);
            this.panel1.Controls.Add(this.addremovebutton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 522);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csharpproject.Properties.Resources.admin_logo;
            this.pictureBox1.Location = new System.Drawing.Point(403, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 109);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // adminlogoutbutton
            // 
            this.adminlogoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlogoutbutton.Location = new System.Drawing.Point(462, 351);
            this.adminlogoutbutton.Name = "adminlogoutbutton";
            this.adminlogoutbutton.Size = new System.Drawing.Size(98, 31);
            this.adminlogoutbutton.TabIndex = 2;
            this.adminlogoutbutton.Text = "Log Out";
            this.adminlogoutbutton.UseVisualStyleBackColor = true;
            this.adminlogoutbutton.Click += new System.EventHandler(this.adminlogoutbutton_Click);
            // 
            // userregbutton
            // 
            this.userregbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userregbutton.Location = new System.Drawing.Point(364, 253);
            this.userregbutton.Name = "userregbutton";
            this.userregbutton.Size = new System.Drawing.Size(277, 32);
            this.userregbutton.TabIndex = 1;
            this.userregbutton.Text = "USER REGISTRATION";
            this.userregbutton.UseVisualStyleBackColor = true;
            this.userregbutton.Click += new System.EventHandler(this.userregbutton_Click);
            // 
            // addremovebutton
            // 
            this.addremovebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addremovebutton.Location = new System.Drawing.Point(364, 198);
            this.addremovebutton.Name = "addremovebutton";
            this.addremovebutton.Size = new System.Drawing.Size(277, 33);
            this.addremovebutton.TabIndex = 0;
            this.addremovebutton.Text = "ADD/REMOVE BOOKS";
            this.addremovebutton.UseVisualStyleBackColor = true;
            this.addremovebutton.Click += new System.EventHandler(this.addremovebutton_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 523);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Panel";
            this.Text = "Admin Panel";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminlogoutbutton;
        private System.Windows.Forms.Button userregbutton;
        private System.Windows.Forms.Button addremovebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}