using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace store
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btndirect_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtname.Text;
                String add = txtaddress.Text;
                int tel = Convert.ToInt32(txttel.Text);


                //1.Connection
                String con_string = "server=127.0.0.1;user=root;" + "password=;database=project;";
                MySqlConnection con = new MySqlConnection(con_string);

                String query = "insert into local_customer(Customer_Name,Address,Telephone) " + "values('" + name + "','" + add + "'," + tel + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);

                //3.Open the connection
                con.Open();

                //4.Execute Command
                cmd.ExecuteNonQuery();

                //5.Close the connection.
                con.Close();


                // txtname.Clear(); txtaddress.Clear(); txttel.Clear();

                MessageBox.Show("Customer Details Inserted Successfully!!");
                txtname.Clear(); txtaddress.Clear(); txttel.Clear();

                directoder cust = new directoder();
                cust.Show();
                this.Hide();

            }
            catch (NullReferenceException exc)
            {
                txtname.Clear(); txtaddress.Clear(); txttel.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
               
                txtname.Clear(); txtaddress.Clear(); txttel.Clear();

                MessageBox.Show(exc.Message);
            }
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            Form1 newitem = new Form1();
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

        private void btnselect_Click(object sender, EventArgs e)
        {

            selctdata newitem = new selctdata();
            newitem.Show();
            this.Hide();


            selectitems a = new selectitems();
            a.Show();

            
            //pdf opening in second screen


            //if you do not have a secondary screen,comment down the below part
           Screen[] screens = Screen.AllScreens;
            selectitems aoc = new selectitems();
            aoc.Show();
            aoc.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncall_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            bill bil = new bill();
            bil.Show();
            this.Hide();
        }
    }
}
