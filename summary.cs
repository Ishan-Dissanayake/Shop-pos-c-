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
    public partial class summary : Form
    {
        public summary()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            int typ = 1;
            var con_string5 = "server=127.0.0.1;user=root;" + "password=;database=project";
            MySqlConnection con5 = new MySqlConnection(con_string5);
          

            DateTime dtFrom = Convert.ToDateTime(dateTimePicker1.Text); //some DateTime value, e.g. DatePicker1.Text;
            DateTime dtTo = Convert.ToDateTime(dateTimePicker2.Text); //some DateTime value, e.g. 
           
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from orders where date between '" + dtFrom.ToString("yyyy/MM/dd") + "' and '" + dtTo.ToString("yyyy/MM/dd") + "' && type = "+ typ + " " , con5);

            System.Data.DataSet ds = new System.Data.DataSet();
            con5.Open();
            mda.Fill(ds, "root");
            dataGridView1.DataSource = ds.Tables["root"];
            dataGridView1.Refresh();
            con5.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }

        public void show()
        {
            int tp = 1;
            var con_string5 = "server=127.0.0.1;user=root;" + "password=;database=project";
            MySqlConnection con5 = new MySqlConnection(con_string5);
            con5.Open();

            string query = "SELECT * FROM orders where type = " + tp + "";
            MySqlCommand mySqlCommand = new MySqlCommand(query);
            mySqlCommand.Connection = con5;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = mySqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;


            // con5.Close();




        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {

            finance addi = new finance();
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
