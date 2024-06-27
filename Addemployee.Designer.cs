namespace store
{
    partial class Addemployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addemployee));
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtaddres = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lblempname = new System.Windows.Forms.Label();
            this.lbladdres = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.cbtnback2 = new cusbutton.customimage();
            this.cbtnexit = new cusbutton.customimage();
            this.cbtnmin = new cusbutton.customimage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.cbtnmax = new cusbutton.customimage();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).BeginInit();
            this.SuspendLayout();
            // 
            // txtempname
            // 
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(352, 229);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(295, 34);
            this.txtempname.TabIndex = 0;
            this.txtempname.TextChanged += new System.EventHandler(this.txtempname_TextChanged);
            // 
            // txtaddres
            // 
            this.txtaddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddres.Location = new System.Drawing.Point(352, 295);
            this.txtaddres.Name = "txtaddres";
            this.txtaddres.Size = new System.Drawing.Size(428, 34);
            this.txtaddres.TabIndex = 1;
            this.txtaddres.TextChanged += new System.EventHandler(this.txtaddres_TextChanged);
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(352, 425);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(295, 34);
            this.txttel.TabIndex = 2;
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.BackColor = System.Drawing.Color.Transparent;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(197, 229);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(132, 36);
            this.lblempname.TabIndex = 3;
            this.lblempname.Text = "Name    :";
            this.lblempname.Click += new System.EventHandler(this.lblempname_Click);
            // 
            // lbladdres
            // 
            this.lbladdres.AutoSize = true;
            this.lbladdres.BackColor = System.Drawing.Color.Transparent;
            this.lbladdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdres.Location = new System.Drawing.Point(197, 293);
            this.lbladdres.Name = "lbladdres";
            this.lbladdres.Size = new System.Drawing.Size(134, 36);
            this.lbladdres.TabIndex = 4;
            this.lbladdres.Text = "Address:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.BackColor = System.Drawing.Color.Transparent;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(197, 425);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(136, 36);
            this.lbltel.TabIndex = 5;
            this.lbltel.Text = "Tel         :";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(583, 582);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(125, 53);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
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
            this.cbtnexit.Location = new System.Drawing.Point(756, 12);
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
            this.cbtnmin.Location = new System.Drawing.Point(678, 11);
            this.cbtnmin.Name = "cbtnmin";
            this.cbtnmin.Size = new System.Drawing.Size(32, 35);
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
            this.label1.Location = new System.Drawing.Point(223, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 76);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtrole
            // 
            this.txtrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrole.Location = new System.Drawing.Point(354, 368);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(295, 34);
            this.txtrole.TabIndex = 32;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.BackColor = System.Drawing.Color.Transparent;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(190, 365);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(150, 36);
            this.lblrole.TabIndex = 33;
            this.lblrole.Text = "Job Role :";
            // 
            // cbtnmax
            // 
            this.cbtnmax.BackColor = System.Drawing.Color.Transparent;
            this.cbtnmax.Image = ((System.Drawing.Image)(resources.GetObject("cbtnmax.Image")));
            this.cbtnmax.ImageHover = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageHover")));
            this.cbtnmax.ImageNormal = ((System.Drawing.Image)(resources.GetObject("cbtnmax.ImageNormal")));
            this.cbtnmax.Location = new System.Drawing.Point(711, 11);
            this.cbtnmax.Name = "cbtnmax";
            this.cbtnmax.Size = new System.Drawing.Size(42, 34);
            this.cbtnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cbtnmax.TabIndex = 34;
            this.cbtnmax.TabStop = false;
            this.cbtnmax.Click += new System.EventHandler(this.customimage1_Click);
            // 
            // Addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.cbtnmax);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtnmin);
            this.Controls.Add(this.cbtnexit);
            this.Controls.Add(this.cbtnback2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lbladdres);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtaddres);
            this.Controls.Add(this.txtempname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addemployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addemployee";
            ((System.ComponentModel.ISupportInitialize)(this.cbtnback2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtnmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtaddres;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lbladdres;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Button btnsave;
        private cusbutton.customimage cbtnback2;
        private cusbutton.customimage cbtnexit;
        private cusbutton.customimage cbtnmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.Label lblrole;
        private cusbutton.customimage cbtnmax;
    }
}