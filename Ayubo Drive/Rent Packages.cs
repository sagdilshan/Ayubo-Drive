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
    public partial class Rent_Packages : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DILSHAN;Initial Catalog=AyuboDriveTaxiService;Integrated Security=True");
        public Rent_Packages()
        {
            InitializeComponent();
            displayAyuboDriveTaxiService();
        }
        public void displayAyuboDriveTaxiService()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Rent Package Details]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Package_Details pd = new Package_Details();
            pd.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")

            {
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Rent Package Details] set [Vehicle_No]='" + textBox1.Text + "' ,[Vehicle_Type]='" + textBox2.Text + "',[Daily_Rates]='" + int.Parse(textBox3.Text) + "',[Weekly_Rates]='" + int.Parse(textBox4.Text) + "',[Monthly_Rates]='" + int.Parse(textBox5.Text) + "',[Driver_Salary]='" + int.Parse(textBox6.Text) +  "'where [Vehicle_No]='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully Updated");
            con.Close();
            displayAyuboDriveTaxiService();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please Fiil in the Blanks");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Visible = true;
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Rent Package Details] where [Vehicle_No]='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted");
                con.Close();
                displayAyuboDriveTaxiService();
            }
            else
            {
                MessageBox.Show("Please Enter Delete ID");
            }
                textBox1.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""  && textBox5.Text != "" && textBox6.Text != "" )

            {
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Rent Package Details] ([Vehicle_No],[Vehicle_Type],[Daily_Rates],[Weekly_Rates],[Monthly_Rates],[Driver_Salary]) values ('" + textBox1.Text + "' , '" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "','" + int.Parse(textBox4.Text) + "','" + int.Parse(textBox5.Text) + "','" + int.Parse(textBox6.Text) + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucecssfully Inserted");
            con.Close();
            displayAyuboDriveTaxiService();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
            textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please Fiil in the Blanks");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rent_Packages_Load(object sender, EventArgs e)
        {

        }
    }
}
