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
    public partial class Long_Hire_Packages : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DILSHAN;Initial Catalog=AyuboDriveTaxiService;Integrated Security=True");
        public Long_Hire_Packages()
        {
            InitializeComponent();
            displayAyuboDriveTaxiService();
        }

        public void displayAyuboDriveTaxiService()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Long Hire Package Details]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
            Hire_Package hp = new Hire_Package();
            hp.Visible = true;
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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox1.Focus();
        }

        private void Long_Hire_Packages_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")

            {
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Long Hire Package Details] ([L_H_Package_No],[Vehicle_Type],[Package_Type],[Package_Rates],[Max_KM],[Min_KM],[Extra_KM],[Extra_Hour],[Night_Charges],[Night_Parking]) values ('" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "','" + int.Parse(textBox4.Text) + "','" + int.Parse(textBox5.Text) + "','" + int.Parse(textBox6.Text) + "','" + int.Parse(textBox7.Text) + "','" + int.Parse(textBox8.Text) + "','" + int.Parse(textBox9.Text) + "','" + int.Parse(textBox10.Text) + "')";
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
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please Fiil in the Blanks");
            }

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Long Hire Package Details] where [L_H_Package_No]='" + textBox1.Text + "'";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")

            {
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Long Hire Package Details] set [L_H_Package_No]='" + textBox1.Text + "' ,[Vehicle_Type]='" + textBox2.Text + "',[Package_Type]='" + textBox3.Text + "',[Package_Rates]='" + int.Parse(textBox4.Text) + "',[Max_KM]='" + int.Parse(textBox5.Text) + "',[Min_KM]='" + int.Parse(textBox6.Text) + "',[Extra_KM]='" + int.Parse(textBox7.Text) + "',[Extra_Hour]='" + int.Parse(textBox8.Text) + "',[Night_Charges]='" + int.Parse(textBox9.Text) + "',[Night_Parking]='" + int.Parse(textBox10.Text) + "'where [L_H_Package_No]='" + textBox1.Text + "'";
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
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please Fiil in the Blanks");
            }
            
        }
    }
}
