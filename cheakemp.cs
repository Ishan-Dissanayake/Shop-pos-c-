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

namespace store
{
    public partial class cheakemp : Form
    {
        public cheakemp()
        {
            InitializeComponent();
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            show();
        }
        public void show()
        {
            try
            {
                String code = txtcode.Text;

                var con_string5 = "server=127.0.0.1;user=root;" + "password=;database=kidsplanet";
                MySqlConnection con5 = new MySqlConnection(con_string5);
                con5.Open();

                string query = "select * from employee where" + " emp_id='" + code + "'"; ;
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = con5;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

            }
            catch (NullReferenceException exc)
            {
                txtcode.Clear();

            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc)
            {
               
                txtcode.Clear();

                MessageBox.Show(exc.Message);
            }
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
