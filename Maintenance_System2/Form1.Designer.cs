namespace Maintenance_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tech_choice = new System.Windows.Forms.RadioButton();
            this.admin_choice = new System.Windows.Forms.RadioButton();
            this.TechnicianGB = new System.Windows.Forms.GroupBox();
            this.tech_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tech_login_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tech_login_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cus_choice = new System.Windows.Forms.RadioButton();
            this.adminGB = new System.Windows.Forms.GroupBox();
            this.admin_login = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.admin_login_password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.admin_login_email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.customerGB = new System.Windows.Forms.GroupBox();
            this.cus_login = new System.Windows.Forms.Button();
            this.pass_login = new System.Windows.Forms.Label();
            this.cus_login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cus_login_email = new System.Windows.Forms.TextBox();
            this.cus_Signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.cus_signup_password = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.cus_signup_email = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.cus_username = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.cus_address = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.cus_phone = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.cus_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.TechnicianGB.SuspendLayout();
            this.adminGB.SuspendLayout();
            this.customerGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ControlText;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Image = global::Maintenance_System.Properties.Resources.remove_button1;
            this.exit.Location = new System.Drawing.Point(975, -4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 40);
            this.exit.TabIndex = 70;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tech_choice);
            this.panel1.Controls.Add(this.admin_choice);
            this.panel1.Controls.Add(this.cus_choice);
            this.panel1.Controls.Add(this.adminGB);
            this.panel1.Controls.Add(this.customerGB);
            this.panel1.Location = new System.Drawing.Point(262, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 652);
            this.panel1.TabIndex = 71;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tech_choice
            // 
            this.tech_choice.AutoSize = true;
            this.tech_choice.Location = new System.Drawing.Point(40, 5);
            this.tech_choice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tech_choice.Name = "tech_choice";
            this.tech_choice.Size = new System.Drawing.Size(113, 27);
            this.tech_choice.TabIndex = 68;
            this.tech_choice.Text = "technician";
            this.tech_choice.UseVisualStyleBackColor = true;
            this.tech_choice.CheckedChanged += new System.EventHandler(this.tech_choice_CheckedChanged_1);
            // 
            // admin_choice
            // 
            this.admin_choice.AutoSize = true;
            this.admin_choice.Checked = true;
            this.admin_choice.Location = new System.Drawing.Point(188, 5);
            this.admin_choice.Name = "admin_choice";
            this.admin_choice.Size = new System.Drawing.Size(81, 27);
            this.admin_choice.TabIndex = 71;
            this.admin_choice.TabStop = true;
            this.admin_choice.Text = "Admin";
            this.admin_choice.UseVisualStyleBackColor = true;
            this.admin_choice.CheckedChanged += new System.EventHandler(this.admin_choice_CheckedChanged_1);
            // 
            // TechnicianGB
            // 
            this.TechnicianGB.Controls.Add(this.tech_login);
            this.TechnicianGB.Controls.Add(this.label3);
            this.TechnicianGB.Controls.Add(this.tech_login_password);
            this.TechnicianGB.Controls.Add(this.label5);
            this.TechnicianGB.Controls.Add(this.tech_login_email);
            this.TechnicianGB.Controls.Add(this.label9);
            this.TechnicianGB.Location = new System.Drawing.Point(262, 471);
            this.TechnicianGB.Name = "TechnicianGB";
            this.TechnicianGB.Size = new System.Drawing.Size(484, 207);
            this.TechnicianGB.TabIndex = 72;
            this.TechnicianGB.TabStop = false;
            this.TechnicianGB.Visible = false;
            // 
            // tech_login
            // 
            this.tech_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tech_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.tech_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tech_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_login.Image = global::Maintenance_System.Properties.Resources.enter;
            this.tech_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tech_login.Location = new System.Drawing.Point(333, 149);
            this.tech_login.Name = "tech_login";
            this.tech_login.Size = new System.Drawing.Size(111, 35);
            this.tech_login.TabIndex = 58;
            this.tech_login.TabStop = false;
            this.tech_login.Text = "Login";
            this.tech_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tech_login.UseVisualStyleBackColor = false;
            this.tech_login.Click += new System.EventHandler(this.tech_login_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "password";
            // 
            // tech_login_password
            // 
            this.tech_login_password.Location = new System.Drawing.Point(161, 107);
            this.tech_login_password.Name = "tech_login_password";
            this.tech_login_password.Size = new System.Drawing.Size(240, 30);
            this.tech_login_password.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Username";
            // 
            // tech_login_email
            // 
            this.tech_login_email.Location = new System.Drawing.Point(161, 65);
            this.tech_login_email.Name = "tech_login_email";
            this.tech_login_email.Size = new System.Drawing.Size(240, 30);
            this.tech_login_email.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Technician";
            // 
            // cus_choice
            // 
            this.cus_choice.AutoSize = true;
            this.cus_choice.Location = new System.Drawing.Point(296, 5);
            this.cus_choice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cus_choice.Name = "cus_choice";
            this.cus_choice.Size = new System.Drawing.Size(105, 27);
            this.cus_choice.TabIndex = 69;
            this.cus_choice.Text = "customer";
            this.cus_choice.UseVisualStyleBackColor = true;
            this.cus_choice.CheckedChanged += new System.EventHandler(this.cus_choice_CheckedChanged_1);
            // 
            // adminGB
            // 
            this.adminGB.Controls.Add(this.admin_login);
            this.adminGB.Controls.Add(this.label11);
            this.adminGB.Controls.Add(this.admin_login_password);
            this.adminGB.Controls.Add(this.label13);
            this.adminGB.Controls.Add(this.admin_login_email);
            this.adminGB.Controls.Add(this.label16);
            this.adminGB.Location = new System.Drawing.Point(5, 251);
            this.adminGB.Name = "adminGB";
            this.adminGB.Size = new System.Drawing.Size(490, 203);
            this.adminGB.TabIndex = 73;
            this.adminGB.TabStop = false;
            this.adminGB.Visible = false;
            // 
            // admin_login
            // 
            this.admin_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login.Image = ((System.Drawing.Image)(resources.GetObject("admin_login.Image")));
            this.admin_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin_login.Location = new System.Drawing.Point(301, 140);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(118, 35);
            this.admin_login.TabIndex = 64;
            this.admin_login.TabStop = false;
            this.admin_login.Text = "Login";
            this.admin_login.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.admin_login.UseVisualStyleBackColor = false;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 63;
            this.label11.Text = "password";
            // 
            // admin_login_password
            // 
            this.admin_login_password.Location = new System.Drawing.Point(126, 99);
            this.admin_login_password.Name = "admin_login_password";
            this.admin_login_password.Size = new System.Drawing.Size(261, 30);
            this.admin_login_password.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 23);
            this.label13.TabIndex = 61;
            this.label13.Text = "Username";
            // 
            // admin_login_email
            // 
            this.admin_login_email.Location = new System.Drawing.Point(126, 57);
            this.admin_login_email.Name = "admin_login_email";
            this.admin_login_email.Size = new System.Drawing.Size(261, 30);
            this.admin_login_email.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(169, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 23);
            this.label16.TabIndex = 59;
            this.label16.Text = "Admin";
            // 
            // customerGB
            // 
            this.customerGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerGB.Controls.Add(this.cus_login);
            this.customerGB.Controls.Add(this.pass_login);
            this.customerGB.Controls.Add(this.cus_login_password);
            this.customerGB.Controls.Add(this.label4);
            this.customerGB.Controls.Add(this.cus_login_email);
            this.customerGB.Controls.Add(this.cus_Signup);
            this.customerGB.Controls.Add(this.label2);
            this.customerGB.Controls.Add(this.label1);
            this.customerGB.Controls.Add(this.label8);
            this.customerGB.Controls.Add(this.l6);
            this.customerGB.Controls.Add(this.cus_signup_password);
            this.customerGB.Controls.Add(this.l5);
            this.customerGB.Controls.Add(this.cus_signup_email);
            this.customerGB.Controls.Add(this.l4);
            this.customerGB.Controls.Add(this.cus_username);
            this.customerGB.Controls.Add(this.l3);
            this.customerGB.Controls.Add(this.cus_address);
            this.customerGB.Controls.Add(this.l2);
            this.customerGB.Controls.Add(this.cus_phone);
            this.customerGB.Controls.Add(this.l1);
            this.customerGB.Controls.Add(this.cus_name);
            this.customerGB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customerGB.Location = new System.Drawing.Point(21, 34);
            this.customerGB.Name = "customerGB";
            this.customerGB.Size = new System.Drawing.Size(439, 603);
            this.customerGB.TabIndex = 70;
            this.customerGB.TabStop = false;
            this.customerGB.Visible = false;
            this.customerGB.Enter += new System.EventHandler(this.customerGB_Enter);
            // 
            // cus_login
            // 
            this.cus_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cus_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cus_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_login.Image = global::Maintenance_System.Properties.Resources.enter;
            this.cus_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cus_login.Location = new System.Drawing.Point(315, 562);
            this.cus_login.Name = "cus_login";
            this.cus_login.Size = new System.Drawing.Size(113, 35);
            this.cus_login.TabIndex = 37;
            this.cus_login.TabStop = false;
            this.cus_login.Text = "Login";
            this.cus_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cus_login.UseVisualStyleBackColor = false;
            this.cus_login.Click += new System.EventHandler(this.cus_login_Click);
            // 
            // pass_login
            // 
            this.pass_login.AutoSize = true;
            this.pass_login.Location = new System.Drawing.Point(13, 507);
            this.pass_login.Name = "pass_login";
            this.pass_login.Size = new System.Drawing.Size(89, 23);
            this.pass_login.TabIndex = 36;
            this.pass_login.Text = "password";
            // 
            // cus_login_password
            // 
            this.cus_login_password.Location = new System.Drawing.Point(161, 507);
            this.cus_login_password.Name = "cus_login_password";
            this.cus_login_password.Size = new System.Drawing.Size(240, 30);
            this.cus_login_password.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Username";
            // 
            // cus_login_email
            // 
            this.cus_login_email.Location = new System.Drawing.Point(161, 465);
            this.cus_login_email.Name = "cus_login_email";
            this.cus_login_email.Size = new System.Drawing.Size(240, 30);
            this.cus_login_email.TabIndex = 33;
            this.cus_login_email.TextChanged += new System.EventHandler(this.cus_login_email_TextChanged);
            // 
            // cus_Signup
            // 
            this.cus_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cus_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cus_Signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_Signup.Image = global::Maintenance_System.Properties.Resources.upload_arrow_with_bar;
            this.cus_Signup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cus_Signup.Location = new System.Drawing.Point(310, 350);
            this.cus_Signup.Name = "cus_Signup";
            this.cus_Signup.Size = new System.Drawing.Size(111, 35);
            this.cus_Signup.TabIndex = 32;
            this.cus_Signup.TabStop = false;
            this.cus_Signup.Text = "SignUp";
            this.cus_Signup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cus_Signup.UseVisualStyleBackColor = false;
            this.cus_Signup.Click += new System.EventHandler(this.cus_Signup_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "______________OR_______________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Custommer";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(13, 297);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(89, 23);
            this.l6.TabIndex = 28;
            this.l6.Text = "password";
            // 
            // cus_signup_password
            // 
            this.cus_signup_password.Location = new System.Drawing.Point(161, 297);
            this.cus_signup_password.Name = "cus_signup_password";
            this.cus_signup_password.Size = new System.Drawing.Size(240, 30);
            this.cus_signup_password.TabIndex = 27;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(13, 255);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(61, 23);
            this.l5.TabIndex = 26;
            this.l5.Text = "E-Mail";
            // 
            // cus_signup_email
            // 
            this.cus_signup_email.Location = new System.Drawing.Point(161, 255);
            this.cus_signup_email.Name = "cus_signup_email";
            this.cus_signup_email.Size = new System.Drawing.Size(240, 30);
            this.cus_signup_email.TabIndex = 25;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(13, 214);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(93, 23);
            this.l4.TabIndex = 24;
            this.l4.Text = "username";
            // 
            // cus_username
            // 
            this.cus_username.Location = new System.Drawing.Point(161, 214);
            this.cus_username.Name = "cus_username";
            this.cus_username.Size = new System.Drawing.Size(240, 30);
            this.cus_username.TabIndex = 23;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(13, 173);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(76, 23);
            this.l3.TabIndex = 22;
            this.l3.Text = "Address";
            // 
            // cus_address
            // 
            this.cus_address.Location = new System.Drawing.Point(161, 173);
            this.cus_address.Name = "cus_address";
            this.cus_address.Size = new System.Drawing.Size(240, 30);
            this.cus_address.TabIndex = 21;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(13, 132);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(62, 23);
            this.l2.TabIndex = 20;
            this.l2.Text = "Phone";
            // 
            // cus_phone
            // 
            this.cus_phone.Location = new System.Drawing.Point(161, 132);
            this.cus_phone.Name = "cus_phone";
            this.cus_phone.Size = new System.Drawing.Size(240, 30);
            this.cus_phone.TabIndex = 19;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(13, 82);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(59, 23);
            this.l1.TabIndex = 18;
            this.l1.Text = "Name";
            // 
            // cus_name
            // 
            this.cus_name.Location = new System.Drawing.Point(161, 82);
            this.cus_name.Name = "cus_name";
            this.cus_name.Size = new System.Drawing.Size(240, 30);
            this.cus_name.TabIndex = 17;
            this.cus_name.TextChanged += new System.EventHandler(this.cus_name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1009, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.TechnicianGB);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TechnicianGB.ResumeLayout(false);
            this.TechnicianGB.PerformLayout();
            this.adminGB.ResumeLayout(false);
            this.adminGB.PerformLayout();
            this.customerGB.ResumeLayout(false);
            this.customerGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton tech_choice;
        private System.Windows.Forms.RadioButton admin_choice;
        private System.Windows.Forms.RadioButton cus_choice;
        private System.Windows.Forms.GroupBox adminGB;
        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox admin_login_password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox admin_login_email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox TechnicianGB;
        private System.Windows.Forms.Button tech_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tech_login_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tech_login_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox customerGB;
        private System.Windows.Forms.Button cus_login;
        private System.Windows.Forms.Label pass_login;
        private System.Windows.Forms.TextBox cus_login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cus_login_email;
        private System.Windows.Forms.Button cus_Signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox cus_signup_password;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox cus_signup_email;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox cus_username;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox cus_address;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox cus_phone;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox cus_name;
    }
}

