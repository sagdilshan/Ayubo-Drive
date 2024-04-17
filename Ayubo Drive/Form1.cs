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

namespace Ayubo_Drive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-DILSHAN;Initial Catalog=AyuboDriveTaxiService;Integrated Security=True";

            string user = textBox1.Text;
            string pass = textBox2.Text;

            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from [Login Details] where UserName='" + user + "'and Password='" + pass + "'", con);


            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome to Ayubo Drive Taxi Service", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_Menu lm = new Main_Menu();
                lm.Show();
                this.Hide();

            }
            else MessageBox.Show("Invalid Username or Password! Please Try Again.", "Unable to Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            textBox1.Clear();
            textBox2.Clear();
           
           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
