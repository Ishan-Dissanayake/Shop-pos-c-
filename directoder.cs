using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace store
{
    public partial class directoder : Form
    {


        double tt = 0.0;
        public String search = "";
        public double tot = 0.0;
        Double invoiceNumber = 1;
        int user = 0;
        String username = "Local";

        
        public directoder()
        {
            InitializeComponent();
            

        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {

        }
        private void directoder_Load(object sender, EventArgs e)
        {
            show();
            Random random = new Random();

        // Generate a random invoice number between 1000 and 9999
        invoiceNumber = random.Next(1000, 10000);
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


                //3.Open Connection
                con.Open();
                //Data reader
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
                String query7 = "insert into quantitysold(user_id,invoice,product_id,qty) " + "values(" + user + ",'" + invoiceNumber + "'," + icode + "," + qt + ")";
                MySqlCommand cmd7 = new MySqlCommand(query7, con);

                String query8 = "UPDATE toys SET remainingStock=" + equalqt + " WHERE id= '" + search + "'";
                MySqlCommand cmdu = new MySqlCommand(query8, con1);

                
                cmd1.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmdu.ExecuteNonQuery();





              

                con.Close();

                show();
                txtitem.Clear(); txtqty1.Clear();
            }
            catch (NullReferenceException exc)
            {
                txtitem.Clear(); txtqty1.Clear();
                MessageBox.Show("NullReferenceException: " + exc.Message);

            }
            catch (FormatException exc)
            {
                MessageBox.Show("FormatException: " + exc.Message);
            }
            catch (Exception exc)
            {

                txtitem.Clear(); txtqty1.Clear();
                MessageBox.Show("Exception: " + exc.Message);
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
           

        }

        private void btndone_Click(object sender, EventArgs e)
        {


            int rowCount = 0;
            int totqty = 0;
            String no = "none";
            String stats = "Complete";
            int ty = 1;
            String mobile = "_";
            String con_string3 = "server=127.0.0.1;user=root;" + "password=;database=project";
            MySqlConnection con3 = new MySqlConnection(con_string3);

            con3.Open();

            
            string query = $"SELECT COUNT(*) FROM display";

            using (MySqlCommand command = new MySqlCommand(query, con3))
            {
                 rowCount = Convert.ToInt32(command.ExecuteScalar());
              
            }

            

           
            string query7 = " SELECT SUM(qty) FROM display";
            MySqlCommand cmd7 = new MySqlCommand(query7, con3);
            MySqlDataReader rdr1 = cmd7.ExecuteReader();
            while (rdr1.Read())
                        {
                
                totqty = rdr1.GetInt32(0);



                        }
             rdr1.Close();
            
            
            String query77 = "insert into orders(user_id,amount,item_types,total_items,invoice_num,status,address,postal,mobile,type) " + "values(" + user + "," + tot + "," + rowCount + "," + totqty + "," + invoiceNumber + ",'"+ stats + "','"+ no +"','"+ no + "','"+ mobile +"',"+ ty + ")";
            MySqlCommand cmd77 = new MySqlCommand(query77, con3);
            String query2 = "insert into payments(user_id,user,invoice,sub_total,grand_total) " + "values(" + user + ",'" + username + "'," + invoiceNumber + "," + tot + "," + tot + ")";
            MySqlCommand cmd2 = new MySqlCommand(query2, con3);
            


            
            String query3 = "TRUNCATE TABLE display";
            MySqlCommand cmd3 = new MySqlCommand(query3, con3);





          
            
            cmd3.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
           
            cmd77.ExecuteNonQuery();

            con3.Close();

            
            Customer cust = new Customer();
            cust.Show();
            this.Hide();

            txtqty1.Clear(); txtitem.Clear(); txttotal.Clear();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbtnback2_Click(object sender, EventArgs e)
        {
            Customer newitem = new Customer();
            newitem.Show();
            this.Hide();

            txtqty1.Clear(); txtitem.Clear();
        }

        private void cbtnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbtnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width,dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp,new Rectangle (0,0,dataGridView1.Width,dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 0, 0);

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            cal();
            show();
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            PaperSize customSize = new PaperSize("CustomSize", 800, 600); 
            pd.DefaultPageSettings.PaperSize = customSize;
            pd.PrintPage += new PrintPageEventHandler(PrintDataGridView);

           
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            
            pd.Print();
            //EPSON TM-U220 Receipt
           // Microsoft Print to PDF
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
        private void PrintDataGridView(object sender, PrintPageEventArgs e)
        {
            try
            {
                
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

                // Draw table header
                string header = "ID".PadRight(10) + "Name".PadRight(20) + "Qty".PadRight(10) + "Price".PadRight(10) + "Amount".PadRight(10); // Adjust column widths
                g.DrawString(header, font, brush, 10, y);
                y += font.GetHeight();

                // Draw table content
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


                // Clean up resources
                font.Dispose();
                brush.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Exception: " + exc.Message);
            }
        }


        private void btnend_Click(object sender, EventArgs e)
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

        private void lblcode_Click(object sender, EventArgs e)
        {

        }

        private void lblqty1_Click(object sender, EventArgs e)
        {

        }

        private void txtqty1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltot_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
    }
}
