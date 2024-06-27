using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace store
{
    public partial class bill : Form
    {

        public double tt = 0.0;
        public String search = "";
        public double tot = 0.0;
        Double invoiceNumber = 0.0;
       
        public bill()
        {
            InitializeComponent();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            show();
        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnodradd_Click(object sender, EventArgs e)
        {

            try
            {

                String name = "";
                int price1 = 0;
                int qt = 0;
                double amount = 0;
                int icode = 0;
                int iqty = 0;
                int equalqt = 0;

                search = txtitem.Text;

                //1.Connection
                String con_string = "server=127.0.0.1;user=root;" + "password=;database=project";
                MySqlConnection con = new MySqlConnection(con_string);
                //2.Command
                String query = "select id,name,price,remainingStock from toys where id='" + search + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);


                
                con.Open();
            
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    icode = rdr.GetInt32("id");
                    name = rdr.GetString("name");
                    iqty = rdr.GetInt32("remainingStock");
                    price1 = rdr.GetInt32("price");
                    qt = Convert.ToInt32(txtqty1.Text);
                    amount = price1 * qt;

                    equalqt = iqty - qt;
                    tot = tot + amount;
                    txttotal.Text = Convert.ToString(tot);

                }
                rdr.Close();






                String con_string1 = "server=127.0.0.1;user=root;" + "password=;database=project";
                MySqlConnection con1 = new MySqlConnection(con_string1);
                con1.Open();

                String query1 = "insert into display(code,name,qty,priceQ,AMOUNT) " + "values(" + icode + ",'" + name + "'," + qt + "," + price1 + "," + amount + ")";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
            
            


                cmd1.ExecuteNonQuery();
              
               





              

                con.Close();

                show();
                txtitem.Clear(); txtqty1.Clear(); 
            }
            catch (NullReferenceException exc)
            {
                txtitem.Clear(); txtqty1.Clear(); txtinvoice.Clear();
                MessageBox.Show("NullReferenceException: " + exc.Message);

            }
            catch (FormatException exc)
            {
                MessageBox.Show("FormatException: " + exc.Message);
            }
            catch (Exception exc)
            {

                txtitem.Clear(); txtqty1.Clear(); txtinvoice.Clear();
                MessageBox.Show("Exception: " + exc.Message);
            }


        }
        

        public void cal()
        {


            

            var con_string6 = "server=127.0.0.1;user=root;" + "password=;database=project";
            MySqlConnection con5 = new MySqlConnection(con_string6);
            string query7 = " SELECT SUM(AMOUNT) FROM display";
            MySqlCommand cmd7 = new MySqlCommand(query7, con5);
            con5.Open();
            MySqlDataReader rdr1 = cmd7.ExecuteReader();
            while (rdr1.Read())
            {
                
                tt = rdr1.GetDouble(0);



            }
            rdr1.Close();


            cmd7.ExecuteNonQuery();
          

            con5.Close();

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

            cal();
            show();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintContent);

           
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            
            pd.Print();
            //EPSON TM-U220 Receipt
            // Microsoft Print to PDF
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                invoiceNumber = Convert.ToInt32(txtinvoice.Text);

                String con_string3 = "server=127.0.0.1;user=root;" + "password=;database=project";
                MySqlConnection con3 = new MySqlConnection(con_string3);

                con3.Open();
               
                String query11 = "insert into deliver(Invoice_no,amount) " + "values(" + invoiceNumber + "," + tt + ")";
                MySqlCommand cmd11 = new MySqlCommand(query11, con3);


               
                String query3 = "TRUNCATE TABLE display";
                MySqlCommand cmd3 = new MySqlCommand(query3, con3);






              

                cmd11.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                con3.Close();


                Customer cust = new Customer();
                cust.Show();
                this.Hide();

                txtqty1.Clear(); txtitem.Clear(); txttotal.Clear(); txtinvoice.Clear();
            }
            catch (Exception exc)
            {

                txtitem.Clear(); txtqty1.Clear(); txtinvoice.Clear();
                MessageBox.Show("Exception: " + exc.Message);
            }
        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {

            Customer newitem = new Customer();
            newitem.Show();
            this.Hide();

            txtqty1.Clear(); txtitem.Clear(); txtinvoice.Clear();
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
        public void show()
        {

            var con_string5 = "server=127.0.0.1;user=root;" + "password=;database=project";
            MySqlConnection con5 = new MySqlConnection(con_string5);
            con5.Open();

            string query = "SELECT * FROM display";
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
        private void PrintContent(object sender, PrintPageEventArgs e)
        {
            try
            {
                invoiceNumber = Convert.ToInt32(txtinvoice.Text);
                Graphics g = e.Graphics;
                Font font = new Font("Arial", 8);
                Brush brush = new SolidBrush(Color.Black);

               
                int leftMargin = e.MarginBounds.Left;
               

                float y = 5; 

                string ti = "KIDS PLANET";
                g.DrawString(ti, font, brush, 70, y);
                y += font.GetHeight();



                string tel = "0772343356";
                g.DrawString(tel, font, brush, 70, y);
                y += font.GetHeight();


                string invo = "Invoice No : " + invoiceNumber;
                g.DrawString(invo, font, brush, 10, y);
                y += font.GetHeight();

               
                string date = "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                g.DrawString(date, font, brush, 10, y);
                y += font.GetHeight();

             
                g.DrawLine(Pens.Black, 10, y, e.PageBounds.Width - 10, y);
                y += 5;

                
                DataTable dataTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user=root;" + "password=;database=project"))
                {
                    connection.Open();
                    string query = "SELECT * FROM display"; 
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                
                string header = "ID".PadRight(10) + "Name".PadRight(20) + "Qty".PadRight(10) + "Price".PadRight(10) + "Amount".PadRight(10); // Adjust column widths
                g.DrawString(header, font, brush, 10, y);
                y += font.GetHeight();

                
                foreach (DataRow row in dataTable.Rows)
                {
                    string rowText = row["item_no"].ToString().PadRight(10) + row["name"].ToString().PadRight(25) + row["qty"].ToString().PadRight(10) + row["priceQ"].ToString().PadRight(10) + row["AMOUNT"].ToString().PadRight(10); // Adjust column widths
                    g.DrawString(rowText, font, brush, 10, y);
                    y += font.GetHeight();
                }
                g.DrawLine(Pens.Black, 10, y, e.PageBounds.Width - 10, y);
                y += 5;


                string total = "Total = " + tt;
                g.DrawString(total, font, brush, 175, y);
                y += font.GetHeight();

                string thnk = "Thank You";
                g.DrawString(thnk, font, brush, 80, y);
                y += font.GetHeight();



               
                font.Dispose();
                brush.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Exception: " + exc.Message);
            }
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 0, 0);
        }
    }
}
