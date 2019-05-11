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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            if (Convert.ToInt32(rate.Text) > 5) { MessageBox.Show("Enter Number Between 0 To 5"); }
            else
            {
                SqlCommand add_rate;
                add_rate = new SqlCommand("add_rate", con);
                add_rate.CommandType = CommandType.StoredProcedure;
                con.Open();
                add_rate.Parameters.Add(new SqlParameter("@username", username.Text));
                add_rate.Parameters.Add(new SqlParameter("@rate", rate.Text));
                add_rate.ExecuteNonQuery();
            }


            con.Close();
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

