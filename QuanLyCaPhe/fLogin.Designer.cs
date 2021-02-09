namespace QuanLyCaPhe
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpass = new System.Windows.Forms.Label();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbuser);
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Controls.Add(this.txbpass);
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 176);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogout.Location = new System.Drawing.Point(354, 113);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(97, 50);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Thoát";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(245, 113);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(103, 50);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(13, 70);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(102, 25);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Mật khẩu:";
            this.lblpass.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbpass
            // 
            this.txbpass.HideSelection = false;
            this.txbpass.Location = new System.Drawing.Point(194, 76);
            this.txbpass.Name = "txbpass";
            this.txbpass.PasswordChar = '*';
            this.txbpass.Size = new System.Drawing.Size(262, 20);
            this.txbpass.TabIndex = 1;
            this.txbpass.UseSystemPasswordChar = true;
            this.txbpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCaPhe.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(162, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(194, 28);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(262, 20);
            this.txbuser.TabIndex = 0;
            this.txbuser.TextChanged += new System.EventHandler(this.txbuser_TextChanged);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(14, 23);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(169, 24);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Tên đăng nhập:";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnlogout;
            this.ClientSize = new System.Drawing.Size(498, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.Label lbluser;
    }
}

