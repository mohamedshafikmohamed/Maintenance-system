using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Maintenance_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tech_choice_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tech_choice.Checked == true)
            {
                TechnicianGB.Visible = true;
                customerGB.Visible = false;
                adminGB.Visible = false;
            }
           
        }
        private void admin_choice_CheckedChanged_1(object sender, EventArgs e)
        {
            if (admin_choice.Checked == true)
            {
                customerGB.Visible = false;
                TechnicianGB.Visible = false;
                adminGB.Visible = true;
            }
        }
        private void cus_choice_CheckedChanged_1(object sender, EventArgs e)
        {
            if(cus_choice.Checked==true)
            {
                customerGB.Visible = true;
                TechnicianGB.Visible = false;
                adminGB.Visible = false;
            }
        }

      private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

     
     
        private void cus_Signup_Click_1(object sender, EventArgs e)
        {
            

            if (cus_signup_password.Text != ""|| cus_name.Text!=""|| cus_phone.Text!=""|| cus_address.Text!=""||
                cus_signup_email.Text!=""|| cus_username.Text!="")
            {
                cus_Signup.Enabled =false;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
                SqlCommand insert_cus = new SqlCommand("cus_sign_up", con);
                insert_cus.CommandType = CommandType.StoredProcedure;
                con.Open();
                insert_cus.Parameters.Add(new SqlParameter("@password", cus_signup_password.Text));
                insert_cus.Parameters.Add(new SqlParameter("@name", cus_name.Text));
                insert_cus.Parameters.Add(new SqlParameter("@phone", cus_phone.Text));
                insert_cus.Parameters.Add(new SqlParameter("@address", cus_address.Text));
                insert_cus.Parameters.Add(new SqlParameter("@email", cus_signup_email.Text));
                insert_cus.Parameters.Add(new SqlParameter("@username", cus_username.Text));
                insert_cus.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("enter full data !!");
            }
            
        }
        private void cus_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            SqlCommand cus_pass_varifay = new SqlCommand("select dbo.cus_login_varifay(@username,@cus_password)", con);
            cus_pass_varifay.Parameters.AddWithValue("@username", cus_login_email.Text.Trim());
            cus_pass_varifay.Parameters.AddWithValue("@cus_password", cus_login_password.Text.Trim());

            con.Open();
            int x = Convert.ToInt32(cus_pass_varifay.ExecuteScalar().ToString());
            if (x == 0)
            {
                MessageBox.Show("password or username is incorrect try agian");
            }
            else if (x == 1)
            {
                MessageBox.Show("successful login");
            }
            con.Close();
            Search f6 = new Search(cus_login_email.Text);
            f6.Show();
        }
        private void admin_login_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            SqlCommand admin_pass_varifay = new SqlCommand("select dbo.admin_login_varifay(@username,@password)", con);
            admin_pass_varifay.Parameters.AddWithValue("@username", admin_login_email.Text.Trim());
            admin_pass_varifay.Parameters.AddWithValue("@password", admin_login_password.Text.Trim());

            con.Open();
            int x = Convert.ToInt32(admin_pass_varifay.ExecuteScalar().ToString());
            if (x == 0)
            {
                MessageBox.Show("password or username is incorrect try agian");
            }
            else if (x == 1)
            {

                new admin().Show();
                this.Hide();
            }
            con.Close();
        }

        private void tech_login_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            SqlCommand tech_pass_varifay = new SqlCommand("select dbo.tec_login_varifay(@username,@tech_password)", con);
            tech_pass_varifay.Parameters.AddWithValue("@username", tech_login_email.Text.Trim());
            tech_pass_varifay.Parameters.AddWithValue("@tech_password", tech_login_password.Text.Trim());

            con.Open();
            int x = Convert.ToInt32(tech_pass_varifay.ExecuteScalar().ToString());
            if (x == 0)
            {
                MessageBox.Show("password or username is incorrect try agian");
            }
            else if (x == 1)
            {
                MessageBox.Show("successful login");
                Form5 f = new Form5(tech_login_email.Text);
            f.Show();
            

            }

         
            con.Close();

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cus_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void cus_login_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
