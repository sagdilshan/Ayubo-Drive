using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Drive
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Rent_A_Vehicle rr = new Rent_A_Vehicle();
            rr.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loging Out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 sss = new Form1();
            sss.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hire_A_Vehicle hh = new Hire_A_Vehicle();
            hh.Visible = true;
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Package_Details pd = new Package_Details();
            pd.Visible = true;
            this.Hide();
        }
    }
}
