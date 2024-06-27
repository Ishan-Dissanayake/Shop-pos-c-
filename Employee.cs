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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnaddemp_Click(object sender, EventArgs e)
        {
           
        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            Form1 newitem = new Form1();
            newitem.Show();
            this.Hide();
        }

        private void customimage1_Click(object sender, EventArgs e)
        {
            Addemployee newitem = new Addemployee();
            newitem.Show();
            this.Hide();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {

        }

        private void cbtncheckemp_Click(object sender, EventArgs e)
        {
            cheakemp newitem = new cheakemp();
            newitem.Show();
            this.Hide();
        }

        private void cbtnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbtnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
