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
    public partial class max : UserControl
    {
        public max()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!Join.Instance.PnlContainer.Controls.ContainsKey("CreateAccount"))
            {
                CreateAccount ca = new CreateAccount();
                ca.Dock = DockStyle.Fill;
                Join.Instance.PnlContainer.Controls.Add(ca);
            }
            Join.Instance.PnlContainer.Controls["CreateAccount"].BringToFront();
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
