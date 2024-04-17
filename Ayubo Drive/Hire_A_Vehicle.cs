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
    public partial class Hire_A_Vehicle : Form
    {
        public Hire_A_Vehicle()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.Visible = true;
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Day_Tours dt = new Day_Tours();
            dt.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Long_Tours lt = new Long_Tours();
            lt.Visible = true;
            this.Hide();
        }

        private void Hire_A_Vehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
