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
    public partial class additem : Form
    {
        public additem()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(txtcode.Text);
                String name1 = txtitemname.Text;
                int qut = Convert.ToInt32(txtqut.Text);
                double price = Convert.ToDouble(txtitemprice.Text);


                //1.Connection
                String con_string = "server=127.0.0.1;user=root;" + "password=;database=kidsplanet";
                MySqlConnection con = new MySqlConnection(con_string);

                String query = "insert into items(item_code,item_name,quantity,price) " + "values(" + code + ",'" + name1 + "','" + qut + "'," + price + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);

                //3.Open the connection
                con.Open();

                //4.Execute Command
                cmd.ExecuteNonQuery();

                //5.Close the connection.
                con.Close();

                MessageBox.Show("Item Inserted Successfully!!");
                txtcode.Clear(); txtitemname.Clear(); txtqut.Clear(); txtitemprice.Clear();

            }
            catch (NullReferenceException exc)
            {
                txtcode.Clear(); txtitemname.Clear(); txtqut.Clear(); txtitemprice.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
               
                txtcode.Clear(); txtitemname.Clear(); txtqut.Clear(); txtitemprice.Clear();

                MessageBox.Show(exc.Message);
            }
        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            
        }

        private void cbtnback2_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcode_Click(object sender, EventArgs e)
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
    }
}
