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
    public partial class Rent_A_Vehicle : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DILSHAN;Initial Catalog=AyuboDriveTaxiService;Integrated Security=True");
        public Rent_A_Vehicle()
        {
            InitializeComponent();
            displayAyuboDriveTaxiService();
            
        }

        public void displayAyuboDriveTaxiService()
        {
            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Rented Vehicle Details]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.Visible = true;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Rent_A_Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Rented Vehicle Details] ([Vehicle_Type],[Rented_Date],[Return_Date],[Driver_With/Without],[Total_Charges]) values ('" + comboBox1.Text + "' ,'" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "', '" + comboBox2.Text + "','" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucecssfully Rented");
                con.Close();
                displayAyuboDriveTaxiService();

            }
            else
            {
                MessageBox.Show("Please Fiil in the blanks");
            }

            textBox1.Clear();
            comboBox1.Text = "";

            
            comboBox1.Focus();
        }
    }
}
