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
    public partial class gender : UserControl
    {
        public gender()
        {
            InitializeComponent();
        }

        private void gender_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;

        }

        private void Save_btn_MouseHover(object sender, EventArgs e)
        {
            Save_btn.BackColor = Color.Red;
        }

        private void Save_btn_MouseLeave(object sender, EventArgs e)
        {
            Save_btn.BackColor = Color.Salmon;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!Join.Instance.PnlContainer.Controls.ContainsKey("height"))
            {
                height hg = new height();
                hg.Dock = DockStyle.Fill;
                Join.Instance.PnlContainer.Controls.Add(hg);
            }
            Join.Instance.PnlContainer.Controls["height"].BringToFront(); 
        }
    }
}
