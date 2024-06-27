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
    public partial class pending : Form
    {
        public pending()
        {
            InitializeComponent();
        }

        private void pending_Load(object sender, EventArgs e)
        {

        }

        private void btnserch_Click(object sender, EventArgs e)
        {

            var con_string5 = "server=127.0.0.1;user=root;" + "password=;database=project";
            MySqlConnection con5 = new MySqlConnection(con_string5);


            DateTime dtFrom = Convert.ToDateTime(dateTimePicker1.Text); //some DateTime value, e.g. DatePicker1.Text;
            DateTime dtTo = Convert.ToDateTime(dateTimePicker2.Text); //some DateTime value, e.g. 

            MySqlDataAdapter mda = new MySqlDataAdapter("select * from select_orders where DATE between '" + dtFrom.ToString("yyyy/MM/dd") + "' and '" + dtTo.ToString("yyyy/MM/dd") + "' ", con5);

            System.Data.DataSet ds = new System.Data.DataSet();
            con5.Open();
            mda.Fill(ds, "root");
            dataGridView1.DataSource = ds.Tables["root"];
            dataGridView1.Refresh();
            con5.Close();


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

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            inventory newitem = new inventory();
            newitem.Show();
            this.Hide();
        }
    }
}
