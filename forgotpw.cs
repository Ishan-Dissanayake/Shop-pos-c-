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
    public partial class forgotpw : Form
    {
        public String search = "admin";
        public forgotpw()
        {
            InitializeComponent();
        }

        private void forgotpw_Load(object sender, EventArgs e)
        {

        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtnew.Text == txtretype.Text)
                {
                    String con_string = "server=127.0.0.1;user=root;" + "password=;database=project";
                    MySqlConnection con = new MySqlConnection(con_string);



                    String query = "UPDATE password SET psw =" + txtretype.Text + " where user_name= '" + search + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Password updated successfully!!");
                    log newitem = new log();
                    newitem.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("password are not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException exc)
            {
                txtretype.Clear(); txtretype.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {

                txtretype.Clear(); txtretype.Clear();
                MessageBox.Show(exc.Message);
            }
        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            log newitem = new log();
            newitem.Show();
            this.Hide();
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

        private void cbtnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
