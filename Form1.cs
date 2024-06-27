using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {

        }

        private void btnfinance_Click(object sender, EventArgs e)
        {
            
        }

        private void customimage1_Click(object sender, EventArgs e)
        {
            Customer newitem = new Customer();
            newitem.Show();
            this.Hide();
           

            /*Screen[] screens = Screen.AllScreens;
            Customer aoc = new Customer();
            aoc.Show();
            aoc.Location = Screen.AllScreens[1].WorkingArea.Location;
           // aoc.Location = Screen.AllScreens[1].WorkingArea.Location;
            */
        }

        private void customimage2_Click(object sender, EventArgs e)
        {
            
        }

        private void customimage3_Click(object sender, EventArgs e)
        {
            inventory inven = new inventory();
            inven.Show();
            this.Hide();
        }

        private void customimage4_Click(object sender, EventArgs e)
        {
            finance fin = new finance();
            fin.Show();
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
