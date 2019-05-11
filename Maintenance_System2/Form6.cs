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
    public partial class Search : Form
    { 
        public Search(string s)
        {
            InitializeComponent();
            selection.Items.Add("Username");
            selection.Items.Add("Specilization");
            selection.Items.Add("Rate");
            label2.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TFIQG3L\\SQLEXPRESS;Initial Catalog=maintaince_tech;Integrated Security=True");
            con.Open();
            string choice = selection.Text;
            if (choice == "Specilization")
            {
                SqlCommand search = new SqlCommand("search_by_spicialization", con);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.Add(new SqlParameter("@spicialization", textBox1.Text));
                SqlDataReader read = search.ExecuteReader();

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
                    spec.Text = Convert.ToString(read["spicialization"]);
                    gb.Controls.Add(spec);

                    Label rate = new Label();
                    rate.AutoSize = true;
                    rate.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    rate.Location = new Point(80, 5);
                    rate.Text = "Rate " + Convert.ToString(read["rate"]);
                    gb.Controls.Add(rate);

                    Label freetime = new Label();
                    freetime.AutoSize = true;
                    freetime.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    freetime.Location = new Point(80, 20);
                    freetime.Text = "Free Time " + Convert.ToString(read["free_time"]);
                    gb.Controls.Add(freetime);

                    Button add = new Button();
                    add.Size = new Size(128, 23);
                    add.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    add.Location = new Point(23, 40);
                    add.FlatStyle = FlatStyle.Flat;
                    add.Text = "Request";
                    add.Click += new System.EventHandler(this.add_Click);
                    gb.Controls.Add(add);

                    container.Controls.Add(gb);
                }
            }
            else if (choice == "Rate")
            {
                SqlCommand search = new SqlCommand("search_by_rate", con);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.Add(new SqlParameter("@rate", textBox1.Text));
                SqlDataReader read = search.ExecuteReader();

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
                    spec.Text = Convert.ToString(read["spicialization"]);
                    gb.Controls.Add(spec);

                    Label rate = new Label();
                    rate.AutoSize = true;
                    rate.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    rate.Location = new Point(80, 5);
                    rate.Text = "Rate " + Convert.ToString(read["rate"]);
                    gb.Controls.Add(rate);

                    Label freetime = new Label();
                    freetime.AutoSize = true;
                    freetime.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    freetime.Location = new Point(80, 20);
                    freetime.Text = "Free Time " + Convert.ToString(read["free_time"]);
                    gb.Controls.Add(freetime);

                    Button add = new Button();
                    add.Size = new Size(128, 23);
                    add.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    add.Location = new Point(23, 40);
                    add.FlatStyle = FlatStyle.Flat;
                    add.Text = "Request";
                    add.Click += new System.EventHandler(this.add_Click);
                    gb.Controls.Add(add);

                    container.Controls.Add(gb);
                }
            }
            else if (choice == "Username")
            {
                SqlCommand search = new SqlCommand("search_by_name", con);
                search.CommandType = CommandType.StoredProcedure;
                search.Parameters.Add(new SqlParameter("@name", textBox1.Text));
                SqlDataReader read = search.ExecuteReader();
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
                    spec.Text = Convert.ToString(read["spicialization"]);
                    gb.Controls.Add(spec);

                    Label rate = new Label();
                    rate.AutoSize = true;
                    rate.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    rate.Location = new Point(80, 5);
                    rate.Text = "Rate " + Convert.ToString(read["rate"]);
                    gb.Controls.Add(rate);

                    Label freetime = new Label();
                    freetime.AutoSize = true;
                    freetime.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    freetime.Location = new Point(80, 20);
                    freetime.Text = "Free Time " + Convert.ToString(read["free_time"]);
                    gb.Controls.Add(freetime);

                    Button add = new Button();
                    add.Size = new Size(128, 23);
                    add.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                    add.Location = new Point(23, 40);
                    add.FlatStyle = FlatStyle.Flat;
                    add.Text = "Requist";
                    add.Click += new System.EventHandler(this.add_Click);
                    gb.Controls.Add(add);

                    container.Controls.Add(gb);
                }
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(label2.Text);
            f.Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
        }
    }

