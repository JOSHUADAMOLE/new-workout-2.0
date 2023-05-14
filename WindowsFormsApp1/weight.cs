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
    public partial class weight : UserControl
    {
        public weight()
        {
            InitializeComponent();

            vScrollBar1.Value = flowLayoutPanel2.VerticalScroll.Value;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!Join.Instance.PnlContainer.Controls.ContainsKey("fitnesslvl"))
            {
                fitnesslvl fl = new fitnesslvl();
                fl.Dock = DockStyle.Fill;
                Join.Instance.PnlContainer.Controls.Add(fl);
            }
            Join.Instance.PnlContainer.Controls["fitnesslvl"].BringToFront();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel2.VerticalScroll.Value = vScrollBar1.Value;
            vScrollBar1.Visible = false;
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
