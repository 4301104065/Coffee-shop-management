namespace QuanLyCaPhe
{
    partial class fAccountProfile
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbPassNewAgain = new System.Windows.Forms.TextBox();
            this.txbPassNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btnUpdatePass = new System.Windows.Forms.Button();
            this.lblpass = new System.Windows.Forms.Label();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.txbHienThi = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txbPassNewAgain);
            this.panel1.Controls.Add(this.txbPassNew);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.btnUpdatePass);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Controls.Add(this.txbuser);
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.txbHienThi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 264);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(376, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txbPassNewAgain
            // 
            this.txbPassNewAgain.HideSelection = false;
            this.txbPassNewAgain.Location = new System.Drawing.Point(200, 210);
            this.txbPassNewAgain.Name = "txbPassNewAgain";
            this.txbPassNewAgain.PasswordChar = '*';
            this.txbPassNewAgain.Size = new System.Drawing.Size(251, 20);
            this.txbPassNewAgain.TabIndex = 5;
            // 
            // txbPassNew
            // 
            this.txbPassNew.HideSelection = false;
            this.txbPassNew.Location = new System.Drawing.Point(200, 164);
            this.txbPassNew.Name = "txbPassNew";
            this.txbPassNew.PasswordChar = '*';
            this.txbPassNew.Size = new System.Drawing.Size(251, 20);
            this.txbPassNew.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập lại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txbPass
            // 
            this.txbPass.HideSelection = false;
            this.txbPass.Location = new System.Drawing.Point(200, 120);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(251, 20);
            this.txbPass.TabIndex = 3;
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(25, 68);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(135, 24);
            this.lblHienThi.TabIndex = 5;
            this.lblHienThi.Text = "Tên hiển thị:";
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.Location = new System.Drawing.Point(286, 238);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePass.TabIndex = 6;
            this.btnUpdatePass.Text = "Cập nhật";
            this.btnUpdatePass.UseVisualStyleBackColor = true;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(24, 115);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(102, 25);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Mật khẩu:";
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(200, 21);
            this.txbuser.Name = "txbuser";
            this.txbuser.ReadOnly = true;
            this.txbuser.Size = new System.Drawing.Size(251, 20);
            this.txbuser.TabIndex = 1;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(25, 16);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(169, 24);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Tên đăng nhập:";
            // 
            // txbHienThi
            // 
            this.txbHienThi.HideSelection = false;
            this.txbHienThi.Location = new System.Drawing.Point(200, 76);
            this.txbHienThi.Name = "txbHienThi";
            this.txbHienThi.Size = new System.Drawing.Size(251, 20);
            this.txbHienThi.TabIndex = 2;
            this.txbHienThi.TextChanged += new System.EventHandler(this.txbHienThi_TextChanged);
            // 
            // fAccountProfile
            // 
            this.AcceptButton = this.btnUpdatePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(585, 288);
            this.Controls.Add(this.panel1);
            this.Name = "fAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.fAccountProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbPassNewAgain;
        private System.Windows.Forms.TextBox txbPassNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnUpdatePass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txbHienThi;
    }
}