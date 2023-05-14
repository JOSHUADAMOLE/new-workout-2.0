using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleTurquoise;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.PaleTurquoise;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.PaleTurquoise;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.PaleTurquoise;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setting1.Show();
            schedule1.Hide();
            achievements1.Hide();
            home1.Hide();

            setting1.BringToFront();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Silver;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.PaleTurquoise;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            Visible = false;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Silver;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.PaleTurquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.Show();
            schedule1.Hide();
            achievements1.Hide();
            setting1.Hide();

            home1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedule1.Show();
            achievements1.Hide();
            home1.Hide();
            setting1.Hide();

            schedule1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            achievements1.Show();
            schedule1.Hide();
            home1.Hide();
            setting1.Hide();

            achievements1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shop sh = new Shop();
            sh.Show();

            Visible = false;
        }
    }
}
