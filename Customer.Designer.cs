namespace store
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lblordertype = new System.Windows.Forms.Label();
            this.btndirect = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.cbtnback2 = new cusbutton.customimage();
            this.cbtnexit = new cusbutton.customimage();
            this.cbtnmin = new cusbutton.customimage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtnmax = new cusbutton.customimage();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(191, 157);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(206, 28);
            this.txtname.TabIndex = 0;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(89, 157);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(84, 29);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name:";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(192, 215);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(558, 28);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(67, 215);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(108, 29);
            this.lbladdress.TabIndex = 4;
            this.lbladdress.Text = "Address:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.BackColor = System.Drawing.Color.Transparent;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(7, 278);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(175, 29);
            this.lbltel.TabIndex = 5;
            this.lbltel.Text = "Telephone No:";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(192, 278);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(206, 28);
            this.txttel.TabIndex = 6;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblordertype
            // 
            this.lblordertype.AutoSize = true;
            this.lblordertype.BackColor = System.Drawing.Color.Transparent;
            this.lblordertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordertype.Location = new System.Drawing.Point(27, 389);
            this.lblordertype.Name = "lblordertype";
            this.lblordertype.Size = new System.Drawing.Size(183, 36);
            this.lblordertype.TabIndex = 7;
            this.lblordertype.Text = "Order Type:";
            // 
            // btndirect
            // 
            this.btndirect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndirect.Location = new System.Drawing.Point(33, 462);
            this.btndirect.Name = "btndirect";
            this.btndirect.Size = new System.Drawing.Size(198, 97);
            this.btndirect.TabIndex = 8;
            this.btndirect.Text = "Direct Order";
            this.btndirect.UseVisualStyleBackColor = false;
            this.btndirect.Click += new System.EventHandler(this.btndirect_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(303, 462);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(198, 97);
            this.btnselect.TabIndex = 10;
            this.btnselect.Text = "Pre Order";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
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
            this.cbtnback2.TabIndex = 22;
            this.cbtnback2.TabStop = false;
            this.cbtnback2.Click += new System.EventHandler(this.cbtnback2_Click);
            // 
            // cbtnexit
            // 
            this.cbtnexit.BackColor = System.Drawing.Color.Transparent;
            this.cbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("cbtnexit.Image")));
            this.cbtnexit.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnexit.ImageHover")));
            this.cbtnexit.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnexit.ImageNormal")));
            this.cbtnexit.Location = new System.Drawing.Point(756, 9);
            this.cbtnexit.Name = "cbtnexit";
            this.cbtnexit.Size = new System.Drawing.Size(32, 32);
            this.cbtnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnexit.TabIndex = 23;
            this.cbtnexit.TabStop = false;
            this.cbtnexit.Click += new System.EventHandler(this.cbtnexit_Click);
            // 
            // cbtnmin
            // 
            this.cbtnmin.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmin.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmin.Image")));
            this.cbtnmin.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmin.ImageHover")));
            this.cbtnmin.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmin.ImageNormal")));
            this.cbtnmin.Location = new System.Drawing.Point(681, 9);
            this.cbtnmin.Name = "cbtnmin";
            this.cbtnmin.Size = new System.Drawing.Size(32, 32);
            this.cbtnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmin.TabIndex = 24;
            this.cbtnmin.TabStop = false;
            this.cbtnmin.Click += new System.EventHandler(this.cbtnmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 76);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbtnmax
            // 
            this.cbtnmax.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmax.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmax.Image")));
            this.cbtnmax.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageHover")));
            this.cbtnmax.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageNormal")));
            this.cbtnmax.Location = new System.Drawing.Point(715, 9);
            this.cbtnmax.Name = "cbtnmax";
            this.cbtnmax.Size = new System.Drawing.Size(39, 33);
            this.cbtnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmax.TabIndex = 38;
            this.cbtnmax.TabStop = false;
            this.cbtnmax.Click += new System.EventHandler(this.cbtnmax_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(566, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 97);
            this.button1.TabIndex = 39;
            this.button1.Text = "Make Bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbtnmax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtnmin);
            this.Controls.Add(this.cbtnexit);
            this.Controls.Add(this.cbtnback2);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btndirect);
            this.Controls.Add(this.lblordertype);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lblordertype;
        private System.Windows.Forms.Button btndirect;
        private System.Windows.Forms.Button btnselect;
        private cusbutton.customimage cbtnback2;
        private cusbutton.customimage cbtnexit;
        private cusbutton.customimage cbtnmin;
        private System.Windows.Forms.Label label1;
        private cusbutton.customimage cbtnmax;
        private System.Windows.Forms.Button button1;
    }
}