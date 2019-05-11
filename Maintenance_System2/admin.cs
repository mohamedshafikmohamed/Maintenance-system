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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tech_signup_Click_1(object sender, EventArgs e)
        {
            if (tech_signup_password.Text != "" || tech_name.Text != "" || specialization.Text != "" ||
                tech_username.Text != "")
            {                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
                SqlCommand add_tec = new SqlCommand("add_tec", con);
                add_tec.CommandType = CommandType.StoredProcedure;
                con.Open();
                add_tec.Parameters.Add(new SqlParameter("@username", tech_username.Text));
                add_tec.Parameters.Add(new SqlParameter("@password", tech_signup_password.Text));
                add_tec.Parameters.Add(new SqlParameter("@name", tech_name.Text));
                add_tec.Parameters.Add(new SqlParameter("@spicialization", specialization.Text));
                add_tec.ExecuteNonQuery();
                con.Close();
            }
            else
                MessageBox.Show("enter a completed data please");
        }

        private void delete_Click(object sender, EventArgs e)
        {
          
        }

        private void tech_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (delete_tech.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
                SqlCommand delete_technician = new SqlCommand("delete_technician", con);
                delete_technician.CommandType = CommandType.StoredProcedure;
                con.Open();
                delete_technician.Parameters.Add(new SqlParameter("@username", delete_tech.Text));
                delete_technician.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("enter technical name !!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
