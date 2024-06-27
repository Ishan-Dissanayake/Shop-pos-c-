using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace store
{
    public partial class selectitems : Form
    {
        public selectitems()
        {
            InitializeComponent();
        }
        DataSet ds;

        public object ExcelReaderFactory { get; private set; }

        private void selectitems_Load(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                axAcroPDF1.LoadFile(dlg.FileName);
            }

        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }

        private void cbtnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
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
