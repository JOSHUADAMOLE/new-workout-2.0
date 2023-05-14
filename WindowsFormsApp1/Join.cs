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
    public partial class Join : Form
    {
        static Join _obj;
        
        public static Join Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Join();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Join()
        {
            InitializeComponent();
        }

        private void Join_Load(object sender, EventArgs e)
        {

            _obj = this;

            gender gn = new gender();
            gn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(gn);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
