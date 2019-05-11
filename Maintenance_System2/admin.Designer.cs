namespace Maintenance_System
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.del_tech = new System.Windows.Forms.GroupBox();
            this.remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_tech = new System.Windows.Forms.TextBox();
            this.add_tech = new System.Windows.Forms.GroupBox();
            this.tech_signup = new System.Windows.Forms.Button();
            this.l6 = new System.Windows.Forms.Label();
            this.tech_signup_password = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.tech_username = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.tech_name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.del_tech.SuspendLayout();
            this.add_tech.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.InfoText;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = global::Maintenance_System.Properties.Resources.remove_button1;
            this.exit.Location = new System.Drawing.Point(831, -2);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 28);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.del_tech);
            this.panel1.Controls.Add(this.add_tech);
            this.panel1.Location = new System.Drawing.Point(220, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 543);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "Admin page";
            // 
            // del_tech
            // 
            this.del_tech.Controls.Add(this.remove);
            this.del_tech.Controls.Add(this.label1);
            this.del_tech.Controls.Add(this.delete_tech);
            this.del_tech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_tech.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_tech.Location = new System.Drawing.Point(3, 434);
            this.del_tech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_tech.Name = "del_tech";
            this.del_tech.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_tech.Size = new System.Drawing.Size(399, 98);
            this.del_tech.TabIndex = 57;
            this.del_tech.TabStop = false;
            this.del_tech.Text = "Delete technician";
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(303, 47);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 26);
            this.remove.TabIndex = 57;
            this.remove.Text = "remove";
            this.remove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Enter username";
            // 
            // delete_tech
            // 
            this.delete_tech.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_tech.Location = new System.Drawing.Point(151, 47);
            this.delete_tech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_tech.Name = "delete_tech";
            this.delete_tech.Size = new System.Drawing.Size(146, 25);
            this.delete_tech.TabIndex = 55;
            // 
            // add_tech
            // 
            this.add_tech.Controls.Add(this.tech_signup);
            this.add_tech.Controls.Add(this.l6);
            this.add_tech.Controls.Add(this.tech_signup_password);
            this.add_tech.Controls.Add(this.l5);
            this.add_tech.Controls.Add(this.specialization);
            this.add_tech.Controls.Add(this.l4);
            this.add_tech.Controls.Add(this.tech_username);
            this.add_tech.Controls.Add(this.l1);
            this.add_tech.Controls.Add(this.tech_name);
            this.add_tech.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_tech.Location = new System.Drawing.Point(3, 102);
            this.add_tech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_tech.Name = "add_tech";
            this.add_tech.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_tech.Size = new System.Drawing.Size(399, 292);
            this.add_tech.TabIndex = 56;
            this.add_tech.TabStop = false;
            this.add_tech.Text = "Add Technician";
            // 
            // tech_signup
            // 
            this.tech_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tech_signup.FlatAppearance.BorderSize = 0;
            this.tech_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tech_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_signup.Image = global::Maintenance_System.Properties.Resources.upload_arrow_with_bar;
            this.tech_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tech_signup.Location = new System.Drawing.Point(151, 226);
            this.tech_signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tech_signup.Name = "tech_signup";
            this.tech_signup.Size = new System.Drawing.Size(206, 31);
            this.tech_signup.TabIndex = 60;
            this.tech_signup.TabStop = false;
            this.tech_signup.Text = "SignUp";
            this.tech_signup.UseVisualStyleBackColor = false;
            this.tech_signup.Click += new System.EventHandler(this.tech_signup_Click_1);
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(24, 175);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(76, 19);
            this.l6.TabIndex = 59;
            this.l6.Text = "password";
            // 
            // tech_signup_password
            // 
            this.tech_signup_password.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_signup_password.Location = new System.Drawing.Point(151, 175);
            this.tech_signup_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tech_signup_password.Name = "tech_signup_password";
            this.tech_signup_password.Size = new System.Drawing.Size(206, 25);
            this.tech_signup_password.TabIndex = 58;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(24, 141);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(102, 19);
            this.l5.TabIndex = 57;
            this.l5.Text = "specialization";
            // 
            // specialization
            // 
            this.specialization.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization.Location = new System.Drawing.Point(151, 141);
            this.specialization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(206, 25);
            this.specialization.TabIndex = 56;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(24, 107);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(78, 19);
            this.l4.TabIndex = 55;
            this.l4.Text = "username";
            // 
            // tech_username
            // 
            this.tech_username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_username.Location = new System.Drawing.Point(151, 107);
            this.tech_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tech_username.Name = "tech_username";
            this.tech_username.Size = new System.Drawing.Size(206, 25);
            this.tech_username.TabIndex = 54;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(26, 70);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(50, 19);
            this.l1.TabIndex = 53;
            this.l1.Text = "Name";
            // 
            // tech_name
            // 
            this.tech_name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_name.Location = new System.Drawing.Point(151, 70);
            this.tech_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tech_name.Name = "tech_name";
            this.tech_name.Size = new System.Drawing.Size(206, 25);
            this.tech_name.TabIndex = 52;
            this.tech_name.TextChanged += new System.EventHandler(this.tech_name_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = global::Maintenance_System.Properties.Resources.arr;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(-4, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 40);
            this.button2.TabIndex = 73;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.del_tech.ResumeLayout(false);
            this.del_tech.PerformLayout();
            this.add_tech.ResumeLayout(false);
            this.add_tech.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox del_tech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delete_tech;
        private System.Windows.Forms.GroupBox add_tech;
        private System.Windows.Forms.Button tech_signup;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox tech_signup_password;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox specialization;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox tech_username;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox tech_name;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button button2;
    }
}