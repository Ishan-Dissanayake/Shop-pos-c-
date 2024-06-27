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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace store
{
    public partial class Addemployee : Form
    {
        public Addemployee()
        {
            InitializeComponent();
        }

        private void lblempname_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                String name1 = txtempname.Text;
                String add = txtaddres.Text;
                String role = txtrole.Text;
                int tel = Convert.ToInt32(txttel.Text);



                //1.Connection
                String con_string = "server=127.0.0.1;user=root;" + "password=;database=kidsplanet";
                MySqlConnection con = new MySqlConnection(con_string);

                String query = "insert into employee(emp_name,emp_addres,Job_Role,emp_tel) " + "values('" + name1 + "','" + add + "','"+ role + "'," + tel + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);

                //3.Open the connection
                con.Open();

                //4.Execute Command
                cmd.ExecuteNonQuery();

                //5.Close the connection.
                con.Close();

                MessageBox.Show("Employee Inserted Successfully!!");
                txtempname.Clear(); txtaddres.Clear(); txtrole.Clear(); txttel.Clear();
            }
            catch (NullReferenceException exc)
            {
                txtempname.Clear(); txtaddres.Clear(); txtrole.Clear(); txttel.Clear();
                
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }


            
            txtempname.Clear(); txtaddres.Clear(); txtrole.Clear(); txttel.Clear();


        }

        private void txtempname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddres_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            Employee newitem = new Employee();
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

        private void customimage1_Click(object sender, EventArgs e)
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
