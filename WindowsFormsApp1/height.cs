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
    public partial class height : UserControl
    {
        public height()
        {
            InitializeComponent();

            vScrollBar1.Value = flowLayoutPanel2.VerticalScroll.Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel2.VerticalScroll.Value = vScrollBar1.Value;
            vScrollBar1.Visible = false;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!Join.Instance.PnlContainer.Controls.ContainsKey("weight"))
            {
                weight wg = new weight();
                wg.Dock = DockStyle.Fill;
                Join.Instance.PnlContainer.Controls.Add(wg);
            }
            Join.Instance.PnlContainer.Controls["weight"].BringToFront();
        }

        private void height_Load(object sender, EventArgs e)
        {

        }

        private void Save_btn_MouseHover(object sender, EventArgs e)
        {
            Save_btn.BackColor = Color.Red;
        }

        private void Save_btn_MouseLeave(object sender, EventArgs e)
        {
            Save_btn.BackColor = Color.Salmon;
        }
    }
}
