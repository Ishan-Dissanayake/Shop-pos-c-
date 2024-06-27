using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace store
{
    public partial class selctdata : Form
    {
        public selctdata()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtname.Text;
                String add = txtadd.Text;
                int tel = Convert.ToInt32(txttel.Text);
                String item = txtitem.Text;
                // double price =Convert.ToDouble(txtprice.Text);


                String con_string1 = "server=127.0.0.1;user=root;" + "password=;database=project";
                MySqlConnection con = new MySqlConnection(con_string1);
                con.Open();

                String query1 = "insert into select_orders(Name,Address,Telephone,Items) " + "values('" + name + "','" + add + "'," + tel + ",'" + item + "')";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Order  Added Successfully!!");
                txtname.Clear(); txtadd.Clear(); txttel.Clear(); txtitem.Clear();
            }
            catch (NullReferenceException exc)
            {
                txtitem.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {

                txtitem.Clear();

                MessageBox.Show(exc.Message);
            }
        }

        private void lbltel_Click(object sender, EventArgs e)
        {

        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            Customer newitem = new Customer();
            newitem.Show();
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
            selectitems c = new selectitems();
            c.Close();
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
