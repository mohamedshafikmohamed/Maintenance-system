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
    public partial class Form5 : Form
    {
        string str;
        public Form5(string s)
        {
            InitializeComponent();
            str = s;
            label1.Text = str;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            con.Open();

            SqlCommand Get_cus = new SqlCommand("get_cus", con);
            Get_cus.CommandType = CommandType.StoredProcedure;
            Get_cus.Parameters.Add(new SqlParameter("@username", label1.Text));
            SqlDataReader read = Get_cus.ExecuteReader();

            while (read.Read())
            {
                Panel gb = new Panel();
                gb.Size = new Size(200, 65);
                gb.Font = new Font("Microsoft Sans Serif", 12);
                //gb.FlatStyle = FlatStyle.Standard;
                gb.BackColor = Color.Gray;

                Label name = new Label();
                name.AutoSize = true;
                name.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Italic);
                name.Location = new Point(5, 5);
                name.Text = Convert.ToString(read["username"]);

                gb.Controls.Add(name);


                Label spec = new Label();
                spec.AutoSize = true;
                spec.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Italic);
                spec.Location = new Point(5, 20);
                spec.Text = Convert.ToString(read["phone_num"]);
                gb.Controls.Add(spec);

                Label rate = new Label();
                rate.AutoSize = true;
                rate.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                rate.Location = new Point(80, 5);
                rate.Text = "Address " + Convert.ToString(read["address"]);
                gb.Controls.Add(rate);



                Button add = new Button();
                add.Size = new Size(128, 23);
                add.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                add.Location = new Point(23, 40);
                add.FlatStyle = FlatStyle.Flat;
                add.Text = "Accept";
                add.Click += new System.EventHandler(this.add_Click);
                gb.Controls.Add(add);
                flowLayoutPanel1.Controls.Add(gb);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True";
            con.Open();
            SqlCommand insert = new SqlCommand("accept", con);
            insert.CommandType = CommandType.StoredProcedure;
            insert.Parameters.Add(new SqlParameter("@name", label1.Text));
            SqlCommand get_hour = new SqlCommand("select dbo.geth(@id)", con);

            SqlCommand get_techid = new SqlCommand("select dbo.getid(@username)", con);
            get_techid.Parameters.AddWithValue("@username", str);
            int tech_id = Convert.ToInt32(get_techid.ExecuteScalar().ToString());


            get_hour.Parameters.Add(new SqlParameter("@id", tech_id));
            int geth = Convert.ToInt32(get_hour.ExecuteScalar().ToString());

            insert.Parameters.Add(new SqlParameter("@hours", geth));
            
            insert.ExecuteNonQuery();
            con.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
