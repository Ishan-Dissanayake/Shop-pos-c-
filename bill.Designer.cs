namespace store
{
    partial class bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            this.cbtnmax = new cusbutton.customimage();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbltitle = new System.Windows.Forms.Label();
            this.cbtnmin = new cusbutton.customimage();
            this.cbtnexit = new cusbutton.customimage();
            this.cbtnback2 = new cusbutton.customimage();
            this.lbltot = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btndone = new System.Windows.Forms.Button();
            this.txtqty1 = new System.Windows.Forms.TextBox();
            this.lblqty1 = new System.Windows.Forms.Label();
            this.btnodradd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblcode = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbtnmax
            // 
            this.cbtnmax.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmax.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmax.Image")));
            this.cbtnmax.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageHover")));
            this.cbtnmax.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageNormal")));
            this.cbtnmax.Location = new System.Drawing.Point(1232, 10);
            this.cbtnmax.Name = "cbtnmax";
            this.cbtnmax.Size = new System.Drawing.Size(39, 33);
            this.cbtnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmax.TabIndex = 53;
            this.cbtnmax.TabStop = false;
            this.cbtnmax.Click += new System.EventHandler(this.cbtnmax_Click);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(1031, 97);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(89, 48);
            this.btnprint.TabIndex = 51;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(590, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(160, 76);
            this.lbltitle.TabIndex = 52;
            this.lbltitle.Text = "Order";
            // 
            // cbtnmin
            // 
            this.cbtnmin.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmin.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmin.Image")));
            this.cbtnmin.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmin.ImageHover")));
            this.cbtnmin.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmin.ImageNormal")));
            this.cbtnmin.Location = new System.Drawing.Point(1196, 11);
            this.cbtnmin.Name = "cbtnmin";
            this.cbtnmin.Size = new System.Drawing.Size(32, 32);
            this.cbtnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmin.TabIndex = 50;
            this.cbtnmin.TabStop = false;
            this.cbtnmin.Click += new System.EventHandler(this.cbtnmin_Click);
            // 
            // cbtnexit
            // 
            this.cbtnexit.BackColor = System.Drawing.Color.Transparent;
            this.cbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("cbtnexit.Image")));
            this.cbtnexit.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnexit.ImageHover")));
            this.cbtnexit.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnexit.ImageNormal")));
            this.cbtnexit.Location = new System.Drawing.Point(1273, 11);
            this.cbtnexit.Name = "cbtnexit";
            this.cbtnexit.Size = new System.Drawing.Size(32, 32);
            this.cbtnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnexit.TabIndex = 49;
            this.cbtnexit.TabStop = false;
            this.cbtnexit.Click += new System.EventHandler(this.cbtnexit_Click);
            // 
            // cbtnback2
            // 
            this.cbtnback2.BackColor = System.Drawing.Color.Transparent;
            this.cbtnback2.Image = ((System.Drawing.Image)(resources.GetObject("cbtnback2.Image")));
            this.cbtnback2.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnback2.ImageHover")));
            this.cbtnback2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnback2.ImageNormal")));
            this.cbtnback2.Location = new System.Drawing.Point(3, 9);
            this.cbtnback2.Name = "cbtnback2";
            this.cbtnback2.Size = new System.Drawing.Size(41, 34);
            this.cbtnback2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnback2.TabIndex = 48;
            this.cbtnback2.TabStop = false;
            this.cbtnback2.Click += new System.EventHandler(this.cbtnback2_Click);
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.BackColor = System.Drawing.Color.Transparent;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltot.Location = new System.Drawing.Point(818, 18);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(74, 29);
            this.lbltot.TabIndex = 47;
            this.lbltot.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(907, 15);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(278, 28);
            this.txttotal.TabIndex = 46;
            // 
            // btndone
            // 
            this.btndone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.Location = new System.Drawing.Point(1143, 95);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(85, 52);
            this.btndone.TabIndex = 45;
            this.btndone.Text = "Done";
            this.btndone.UseVisualStyleBackColor = true;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // txtqty1
            // 
            this.txtqty1.BackColor = System.Drawing.SystemColors.Window;
            this.txtqty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty1.Location = new System.Drawing.Point(167, 117);
            this.txtqty1.Name = "txtqty1";
            this.txtqty1.Size = new System.Drawing.Size(278, 28);
            this.txtqty1.TabIndex = 44;
            this.txtqty1.TextChanged += new System.EventHandler(this.txtqty1_TextChanged);
            // 
            // lblqty1
            // 
            this.lblqty1.AutoSize = true;
            this.lblqty1.BackColor = System.Drawing.Color.Transparent;
            this.lblqty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblqty1.Location = new System.Drawing.Point(14, 120);
            this.lblqty1.Name = "lblqty1";
            this.lblqty1.Size = new System.Drawing.Size(106, 29);
            this.lblqty1.TabIndex = 43;
            this.lblqty1.Text = "Quantity:";
            // 
            // btnodradd
            // 
            this.btnodradd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnodradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnodradd.Location = new System.Drawing.Point(462, 105);
            this.btnodradd.Name = "btnodradd";
            this.btnodradd.Size = new System.Drawing.Size(93, 40);
            this.btnodradd.TabIndex = 42;
            this.btnodradd.Text = "Add";
            this.btnodradd.UseVisualStyleBackColor = false;
            this.btnodradd.Click += new System.EventHandler(this.btnodradd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 934);
            this.dataGridView1.TabIndex = 41;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.BackColor = System.Drawing.Color.Transparent;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.ForeColor = System.Drawing.Color.Black;
            this.lblcode.Location = new System.Drawing.Point(14, 83);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(130, 29);
            this.lblcode.TabIndex = 40;
            this.lblcode.Text = "Item Code:";
            // 
            // txtitem
            // 
            this.txtitem.BackColor = System.Drawing.SystemColors.Window;
            this.txtitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Location = new System.Drawing.Point(167, 83);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(278, 28);
            this.txtitem.TabIndex = 39;
            this.txtitem.TextChanged += new System.EventHandler(this.txtitem_TextChanged);
            // 
            // txtinvoice
            // 
            this.txtinvoice.BackColor = System.Drawing.SystemColors.Window;
            this.txtinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.Location = new System.Drawing.Point(167, 49);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(278, 28);
            this.txtinvoice.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Invoice No:";
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 1102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.cbtnmax);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.cbtnmin);
            this.Controls.Add(this.cbtnexit);
            this.Controls.Add(this.cbtnback2);
            this.Controls.Add(this.lbltot);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.txtqty1);
            this.Controls.Add(this.lblqty1);
            this.Controls.Add(this.btnodradd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.txtitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bill";
            this.Text = "bill";
            this.Load += new System.EventHandler(this.bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cusbutton.customimage cbtnmax;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbltitle;
        private cusbutton.customimage cbtnmin;
        private cusbutton.customimage cbtnexit;
        private cusbutton.customimage cbtnback2;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btndone;
        private System.Windows.Forms.TextBox txtqty1;
        private System.Windows.Forms.Label lblqty1;
        private System.Windows.Forms.Button btnodradd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label label1;
    }
}