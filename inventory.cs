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
    public partial class inventory : Form
    {

        public inventory()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
           
        }

        private void btnupd_Click(object sender, EventArgs e)
        {


            

        }

        private void cbtnadditm_Click(object sender, EventArgs e)
        {
          
        }

        private void cbtnupdte_Click(object sender, EventArgs e)
        {
            
        }

        private void customimage1_Click(object sender, EventArgs e)
        {
            checkitem addi = new checkitem();
            addi.Show();
            this.Hide();
        }

        private void cbtnback1_Click(object sender, EventArgs e)
        {
            Form1 addi = new Form1();
            addi.Show();
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

        private void customimage2_Click(object sender, EventArgs e)
        {
            Deliverys newitem = new Deliverys();
            newitem.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblcuss_Click(object sender, EventArgs e)
        {

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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void customimage3_Click(object sender, EventArgs e)
        {
            pending pend = new pending();
            pend.Show();
            this.Hide();
        }
    }
}
