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
    public partial class buying : Form
    {
        public buying()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shop sh = new Shop();
            sh.Show();

            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buying_Load(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkout ck = new checkout();
            ck.Show();

            Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cyan;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Aquamarine;
        }
    }
}
