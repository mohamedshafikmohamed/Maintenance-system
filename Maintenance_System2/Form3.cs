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
using System.Data.Sql;
namespace Maintenance_System
{
    public partial class Form3 : Form
    {
        string str;
        public Form3(string s)
        {
            
            InitializeComponent();
            str = s;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            SqlCommand get_cusid = new SqlCommand("select dbo.geti(@username)", con);
            SqlCommand get_techid = new SqlCommand("select dbo.getid(@username)", con);
            get_cusid.Parameters.AddWithValue("@username", str);
            get_techid.Parameters.AddWithValue("@username", textBox1.Text);
           
            con.Open();
            int cus_id = Convert.ToInt32(get_cusid.ExecuteScalar().ToString());
            int tech_id = Convert.ToInt32(get_techid.ExecuteScalar().ToString());
            SqlCommand insert = new SqlCommand("inser", con);
            insert.CommandType = CommandType.StoredProcedure;
            insert.Parameters.Add(new SqlParameter("@cusid", cus_id));

            insert.Parameters.Add(new SqlParameter("@techid", tech_id));
            insert.Parameters.Add(new SqlParameter("@hr",Convert.ToInt32( hours.Text)));

            insert.ExecuteNonQuery();
            Form5 f = new Form5(hours.Text);
                con.Close();
                Form2 f2 = new Form2();
                f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hours_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           
           
       
        }
    }
}
