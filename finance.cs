using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store
{
    public partial class finance : Form
    {
        public finance()
        {
            InitializeComponent();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            

        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            Form1 inven = new Form1();
            inven.Show();
            this.Hide();
        }

        private void cbtnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cbtnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customimage1_Click(object sender, EventArgs e)
        {
            summary inven = new summary();
            inven.Show();
            this.Hide();

        }

        private void cbtnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
