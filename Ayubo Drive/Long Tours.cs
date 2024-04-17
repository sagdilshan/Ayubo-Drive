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
    public partial class Long_Tours : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DILSHAN;Initial Catalog=AyuboDriveTaxiService;Integrated Security=True");
        public Long_Tours()
        {
            InitializeComponent();
            displayAyuboDriveTaxiService();
        }


        public void displayAyuboDriveTaxiService()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Long Tour Hire Vehicle]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Long_Tours_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "")

            {
                MessageBox.Show("Please Enter the Value");
            }
            else
            {
                double txt1 = Convert.ToDouble(textBox6.Text);
                double txt2 = Convert.ToDouble(textBox4.Text);
                double txt3 = Convert.ToDouble(textBox5.Text);

                double sum = txt1 + txt2 + txt3;

                label14.Text = sum.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Visible = true;
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.Visible = true;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hire_A_Vehicle hv = new Hire_A_Vehicle();
            hv.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label14.Text = "";
            comboBox1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox7.Text != "" && comboBox1.Text != "")

            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Long Tour Hire Vehicle] ([Package_No],[Package_type],[Start_KM],[End_KM],[Start_Time],[End_Time]) values ('" + textBox1.Text + "' , '" + comboBox1.Text + "','" + int.Parse(textBox2.Text) + "','" + int.Parse(textBox7.Text) + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucecssfully Hired");
                con.Close();
                displayAyuboDriveTaxiService();
            }
            else
            {
                MessageBox.Show("Please Fiil in the Blanks");
            }
            textBox1.Clear();
            comboBox1.Text = "";

            textBox2.Clear();
            textBox7.Clear();
            textBox1.Focus();
        }
    }
}
