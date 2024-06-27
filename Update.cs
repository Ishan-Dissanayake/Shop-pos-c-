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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace store
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void lblqty1_Click(object sender, EventArgs e)
        {

        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            try
            {
                int qt = 0;
                int qty = 0;
                String eqty = txtqty1.Text;



                String con_string = "server=127.0.0.1;user=root;" + "password=;database=kidsplanet";
                MySqlConnection con = new MySqlConnection(con_string);


                String query1 = "select quantity from items where" + " item_code=" + txtucode.Text + "";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                //3.Open Connection
                con.Open();
                //Data reader
                MySqlDataReader rdr = cmd1.ExecuteReader();


                while (rdr.Read())
                {
                    qt = rdr.GetInt32("quantity");

                    qty = qt + Convert.ToInt32(eqty);

                }
                rdr.Close();
                con.Close();

                String query = "UPDATE items SET quantity=" + qty + ", price=" + txtpriceu.Text + " WHERE item_code= " + txtucode.Text + "";
                MySqlCommand cmd = new MySqlCommand(query, con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtqty1.Clear(); txtpriceu.Clear(); txtucode.Clear();
            }
            catch (NullReferenceException exc)
            {
                txtqty1.Clear(); txtpriceu.Clear(); txtucode.Clear(); 

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {

                txtqty1.Clear(); txtpriceu.Clear(); txtucode.Clear(); 

                MessageBox.Show(exc.Message);
            }

        }

        private void btnbk_Click(object sender, EventArgs e)
        {
            
        }

        private void customimage1_Click(object sender, EventArgs e)
        {
            inventory addi = new inventory();
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
