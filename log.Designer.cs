namespace store
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.lblpw = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnpw = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblforget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.BackColor = System.Drawing.Color.Transparent;
            this.lblpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(24, 61);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(109, 25);
            this.lblpw.TabIndex = 0;
            this.lblpw.Text = " Password:";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(151, 62);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(220, 22);
            this.txtpw.TabIndex = 4;
            // 
            // btnpw
            // 
            this.btnpw.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpw.Location = new System.Drawing.Point(309, 111);
            this.btnpw.Name = "btnpw";
            this.btnpw.Size = new System.Drawing.Size(82, 35);
            this.btnpw.TabIndex = 2;
            this.btnpw.Text = "Log";
            this.btnpw.UseVisualStyleBackColor = false;
            this.btnpw.Click += new System.EventHandler(this.btnpw_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(24, 27);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(59, 25);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "User:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(151, 30);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(220, 22);
            this.txtuser.TabIndex = 1;
            // 
            // lblforget
            // 
            this.lblforget.AutoSize = true;
            this.lblforget.BackColor = System.Drawing.Color.Transparent;
            this.lblforget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforget.ForeColor = System.Drawing.Color.Red;
            this.lblforget.Location = new System.Drawing.Point(12, 144);
            this.lblforget.Name = "lblforget";
            this.lblforget.Size = new System.Drawing.Size(121, 18);
            this.lblforget.TabIndex = 5;
            this.lblforget.Text = "Forgot password";
            this.lblforget.Click += new System.EventHandler(this.lblforget_Click);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(402, 171);
            this.Controls.Add(this.lblforget);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnpw);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.lblpw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btnpw;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblforget;
    }
}