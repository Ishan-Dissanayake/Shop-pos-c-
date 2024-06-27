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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace store
{
    public partial class log : Form
    {
        
        public String search= "admin";

        public log()
        {
            InitializeComponent();
        }

        private void btnpw_Click(object sender, EventArgs e)
        {
            int pw = 0;
            try
            {

                

                if (txtuser.Text == search)
                {

                    //1.Connection
                    String con_string = "server=127.0.0.1;user=root;" + "password=;database=project";
                    MySqlConnection con = new MySqlConnection(con_string);
                    //2.Command
                    String query = "select psw from password where" + " user_name='" + search + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);


                    //3.Open Connection
                    con.Open();
                    //Data reader
                    MySqlDataReader rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {

                        pw = rdr.GetInt32("psw");


                    }
                    rdr.Close();
                    if (txtpw.Text == "")
                    {
                        MessageBox.Show("Please enter password");
                    }
                    else if (Convert.ToInt32(txtpw.Text) == pw)
                    {
                        Form1 f = new Form1();
                        this.Hide();
                        f.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                else
                {
                    MessageBox.Show("Wrong User name");
                }
            }
            catch (NullReferenceException exc)
            {
                txtuser.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
               
                txtuser.Clear();
                txtpw.Clear();

                MessageBox.Show(exc.Message);
            }


        }

        private void lblforget_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == search)
                {
                    forgotpw f = new forgotpw();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("User Name Wrong!!");
                }
            }catch (NullReferenceException exc)
            {
                txtuser.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {

                txtuser.Clear();
                txtpw.Clear();

                MessageBox.Show(exc.Message);
            }
        }
    }
}
