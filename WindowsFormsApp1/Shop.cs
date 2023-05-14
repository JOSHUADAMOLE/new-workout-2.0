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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            label1.Parent = panel1;
            label1.BackColor = Color.Transparent;
            button1.Parent = panel1;
            button1.BackColor = Color.Transparent;
            button2.Parent = panel1;
            button2.BackColor = Color.Transparent;

            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
    
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            buying by = new buying();
            by.Show();

            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();

            Visible = false;
        }
    }
}
