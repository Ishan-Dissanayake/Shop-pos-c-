namespace store
{
    partial class checkitem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkitem));
            this.btncheck = new System.Windows.Forms.Button();
            this.Itemid = new System.Windows.Forms.Label();
            this.txtchekname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbtnback2 = new cusbutton.customimage();
            this.cbtnexit = new cusbutton.customimage();
            this.cbtnmin = new cusbutton.customimage();
            this.lblcheckitem = new System.Windows.Forms.Label();
            this.cbtnmax = new cusbutton.customimage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).BeginInit();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(947, 642);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(113, 46);
            this.btncheck.TabIndex = 0;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // Itemid
            // 
            this.Itemid.AutoSize = true;
            this.Itemid.BackColor = System.Drawing.Color.Transparent;
            this.Itemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemid.Location = new System.Drawing.Point(71, 129);
            this.Itemid.Name = "Itemid";
            this.Itemid.Size = new System.Drawing.Size(94, 29);
            this.Itemid.TabIndex = 1;
            this.Itemid.Text = "Item ID:";
            // 
            // txtchekname
            // 
            this.txtchekname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchekname.Location = new System.Drawing.Point(171, 129);
            this.txtchekname.Name = "txtchekname";
            this.txtchekname.Size = new System.Drawing.Size(390, 34);
            this.txtchekname.TabIndex = 2;
            this.txtchekname.TextChanged += new System.EventHandler(this.txtchekname_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 396);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbtnback2
            // 
            this.cbtnback2.BackColor = System.Drawing.Color.Transparent;
            this.cbtnback2.Image = ((System.Drawing.Image)(resources.GetObject("cbtnback2.Image")));
            this.cbtnback2.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnback2.ImageHover")));
            this.cbtnback2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnback2.ImageNormal")));
            this.cbtnback2.Location = new System.Drawing.Point(12, 12);
            this.cbtnback2.Name = "cbtnback2";
            this.cbtnback2.Size = new System.Drawing.Size(40, 33);
            this.cbtnback2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnback2.TabIndex = 20;
            this.cbtnback2.TabStop = false;
            this.cbtnback2.Click += new System.EventHandler(this.cbtnback2_Click);
            // 
            // cbtnexit
            // 
            this.cbtnexit.BackColor = System.Drawing.Color.Transparent;
            this.cbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("cbtnexit.Image")));
            this.cbtnexit.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnexit.ImageHover")));
            this.cbtnexit.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnexit.ImageNormal")));
            this.cbtnexit.Location = new System.Drawing.Point(1061, 13);
            this.cbtnexit.Name = "cbtnexit";
            this.cbtnexit.Size = new System.Drawing.Size(32, 32);
            this.cbtnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnexit.TabIndex = 21;
            this.cbtnexit.TabStop = false;
            this.cbtnexit.Click += new System.EventHandler(this.cbtnexit_Click);
            // 
            // cbtnmin
            // 
            this.cbtnmin.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmin.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmin.Image")));
            this.cbtnmin.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmin.ImageHover")));
            this.cbtnmin.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmin.ImageNormal")));
            this.cbtnmin.Location = new System.Drawing.Point(987, 13);
            this.cbtnmin.Name = "cbtnmin";
            this.cbtnmin.Size = new System.Drawing.Size(32, 32);
            this.cbtnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmin.TabIndex = 22;
            this.cbtnmin.TabStop = false;
            this.cbtnmin.Click += new System.EventHandler(this.cbtnmin_Click);
            // 
            // lblcheckitem
            // 
            this.lblcheckitem.AutoSize = true;
            this.lblcheckitem.BackColor = System.Drawing.Color.Transparent;
            this.lblcheckitem.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckitem.Location = new System.Drawing.Point(203, 9);
            this.lblcheckitem.Name = "lblcheckitem";
            this.lblcheckitem.Size = new System.Drawing.Size(391, 76);
            this.lblcheckitem.TabIndex = 30;
            this.lblcheckitem.Text = "Inventory Status";
            // 
            // cbtnmax
            // 
            this.cbtnmax.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmax.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmax.Image")));
            this.cbtnmax.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageHover")));
            this.cbtnmax.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageNormal")));
            this.cbtnmax.Location = new System.Drawing.Point(1021, 12);
            this.cbtnmax.Name = "cbtnmax";
            this.cbtnmax.Size = new System.Drawing.Size(39, 33);
            this.cbtnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmax.TabIndex = 37;
            this.cbtnmax.TabStop = false;
            this.cbtnmax.Click += new System.EventHandler(this.cbtnmax_Click);
            // 
            // checkitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1103, 700);
            this.Controls.Add(this.cbtnmax);
            this.Controls.Add(this.lblcheckitem);
            this.Controls.Add(this.cbtnmin);
            this.Controls.Add(this.cbtnexit);
            this.Controls.Add(this.cbtnback2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtchekname);
            this.Controls.Add(this.Itemid);
            this.Controls.Add(this.btncheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkitem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label Itemid;
        private System.Windows.Forms.TextBox txtchekname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cusbutton.customimage cbtnback2;
        private cusbutton.customimage cbtnexit;
        private cusbutton.customimage cbtnmin;
        private System.Windows.Forms.Label lblcheckitem;
        private cusbutton.customimage cbtnmax;
    }
}