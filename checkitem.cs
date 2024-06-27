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
    public partial class checkitem : Form
    {
        public checkitem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();


        }

        private void txtchekname_TextChanged(object sender, EventArgs e)
        {




        }

        public void show()
        {
            String name = txtchekname.Text;

            var con_string5 = "server=127.0.0.1;user=root;" + "password=;database= project";
            MySqlConnection con5 = new MySqlConnection(con_string5);
            con5.Open();

            string query = "select * from toys where" + " id='" + name + "'"; ;
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
