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
    public partial class fitnesslvl : UserControl
    {
        public fitnesslvl()
        {
            InitializeComponent();

            vScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value;
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

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!Join.Instance.PnlContainer.Controls.ContainsKey("max"))
            {
                max mx = new max();
                mx.Dock = DockStyle.Fill;
                Join.Instance.PnlContainer.Controls.Add(mx);
            }
            Join.Instance.PnlContainer.Controls["max"].BringToFront();
        }
    }
}
