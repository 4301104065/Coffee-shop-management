namespace QuanLyCaPhe
{
    partial class fTableManager
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.USP_GetListMenuByTableForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyCaPheDataSet = new QuanLyCaPhe.QuanLyCaPheDataSet();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTableList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.nmbAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.cmbChangeTable = new System.Windows.Forms.ComboBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.nmbDisCount = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetListMenuByTableForReportTableAdapter = new QuanLyCaPhe.QuanLyCaPheDataSetTableAdapters.USP_GetListMenuByTableForReportTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLogOut = new System.Windows.Forms.ToolStripButton();
            this.tsbAdminManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.USP_GetTableListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetListBillByDateForReport = new QuanLyCaPhe.GetListBillByDateForReport();
            this.USP_GetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_GetListBillByDateForReportTableAdapter = new QuanLyCaPhe.GetListBillByDateForReportTableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.QuanLyCaPheDataSet1 = new QuanLyCaPhe.QuanLyCaPheDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListMenuByTableForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCaPheDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabTableList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbAmount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDisCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetTableListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetListBillByDateForReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCaPheDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_GetListMenuByTableForReportBindingSource
            // 
            this.USP_GetListMenuByTableForReportBindingSource.DataMember = "USP_GetListMenuByTableForReport";
            this.USP_GetListMenuByTableForReportBindingSource.DataSource = this.QuanLyCaPheDataSet;
            // 
            // QuanLyCaPheDataSet
            // 
            this.QuanLyCaPheDataSet.DataSetName = "QuanLyCaPheDataSet";
            this.QuanLyCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(7, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(409, 247);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đồ uống";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 103;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.adminToolStripMenuItem.Text = "Quản Lý";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem1});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem1
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem1.Name = "thôngTinTàiKhoảnToolStripMenuItem1";
            this.thôngTinTàiKhoảnToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.thôngTinTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem1.Text = "Cập nhật tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem1_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem,
            this.chuyểnBànToolStripMenuItem,
            this.chỉnhMónToolStripMenuItem,
            this.xóaMónToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thanhToánToolStripMenuItem.Text = "Thêm món";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.btnThemmon_Click);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thêmMónToolStripMenuItem.Text = "Thanh toán";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // chỉnhMónToolStripMenuItem
            // 
            this.chỉnhMónToolStripMenuItem.Name = "chỉnhMónToolStripMenuItem";
            this.chỉnhMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.chỉnhMónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.chỉnhMónToolStripMenuItem.Text = "Chỉnh món";
            // 
            // xóaMónToolStripMenuItem
            // 
            this.xóaMónToolStripMenuItem.Name = "xóaMónToolStripMenuItem";
            this.xóaMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaMónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.xóaMónToolStripMenuItem.Text = "Xóa món";
            // 
            // tabTableList
            // 
            this.tabTableList.Controls.Add(this.tabPage1);
            this.tabTableList.Controls.Add(this.tabPage2);
            this.tabTableList.Location = new System.Drawing.Point(4, 71);
            this.tabTableList.Name = "tabTableList";
            this.tabTableList.SelectedIndex = 0;
            this.tabTableList.Size = new System.Drawing.Size(802, 443);
            this.tabTableList.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpTable);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh Sách Bàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.SystemColors.MenuBar;
            this.flpTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Location = new System.Drawing.Point(8, 9);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(345, 385);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditFood);
            this.panel1.Controls.Add(this.btnDeleteFood);
            this.panel1.Controls.Add(this.nmbAmount);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.cmbFood);
            this.panel1.Controls.Add(this.cmbFoodCategory);
            this.panel1.Location = new System.Drawing.Point(359, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditFood.Location = new System.Drawing.Point(257, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(65, 48);
            this.btnEditFood.TabIndex = 6;
            this.btnEditFood.Text = "Chỉnh món";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteFood.Location = new System.Drawing.Point(328, 4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(61, 48);
            this.btnDeleteFood.TabIndex = 5;
            this.btnDeleteFood.Text = "Xóa món";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // nmbAmount
            // 
            this.nmbAmount.Location = new System.Drawing.Point(392, 20);
            this.nmbAmount.Name = "nmbAmount";
            this.nmbAmount.Size = new System.Drawing.Size(40, 20);
            this.nmbAmount.TabIndex = 4;
            this.nmbAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddFood.Location = new System.Drawing.Point(186, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(65, 48);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnThemmon_Click);
            // 
            // cmbFood
            // 
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(4, 31);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(176, 21);
            this.cmbFood.TabIndex = 2;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(4, 4);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(176, 21);
            this.cmbFoodCategory.TabIndex = 1;
            this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFoodCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(359, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 325);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.cmbChangeTable);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Controls.Add(this.nmbDisCount);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(3, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 66);
            this.panel3.TabIndex = 2;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(183, 24);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(128, 20);
            this.txbTotalPrice.TabIndex = 10;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.txbTotalPrice_TextChanged);
            // 
            // cmbChangeTable
            // 
            this.cmbChangeTable.FormattingEnabled = true;
            this.cmbChangeTable.Location = new System.Drawing.Point(4, 33);
            this.cmbChangeTable.Name = "cmbChangeTable";
            this.cmbChangeTable.Size = new System.Drawing.Size(75, 21);
            this.cmbChangeTable.TabIndex = 7;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChuyenBan.Location = new System.Drawing.Point(4, 4);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenBan.TabIndex = 5;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // nmbDisCount
            // 
            this.nmbDisCount.Location = new System.Drawing.Point(102, 33);
            this.nmbDisCount.Name = "nmbDisCount";
            this.nmbDisCount.Size = new System.Drawing.Size(75, 20);
            this.nmbDisCount.TabIndex = 8;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiamGia.Location = new System.Drawing.Point(102, 3);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(75, 23);
            this.btnGiamGia.TabIndex = 6;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = false;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.Location = new System.Drawing.Point(317, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(93, 59);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "In Hóa Đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListMenuByTableForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCaPhe.fTabReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(791, 378);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_GetListMenuByTableForReportTableAdapter
            // 
            this.USP_GetListMenuByTableForReportTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogOut,
            this.tsbAdminManagement,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 40);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLogOut
            // 
            this.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLogOut.Image = global::QuanLyCaPhe.Properties.Resources.logout;
            this.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogOut.Name = "tsbLogOut";
            this.tsbLogOut.Size = new System.Drawing.Size(59, 37);
            this.tsbLogOut.Text = "Log Out";
            this.tsbLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogOut.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tsbAdminManagement
            // 
            this.tsbAdminManagement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAdminManagement.Image = global::QuanLyCaPhe.Properties.Resources.my_account_login_icon;
            this.tsbAdminManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdminManagement.Name = "tsbAdminManagement";
            this.tsbAdminManagement.Size = new System.Drawing.Size(49, 37);
            this.tsbAdminManagement.Text = "Admin";
            this.tsbAdminManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdminManagement.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = global::QuanLyCaPhe.Properties.Resources.update;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(101, 37);
            this.toolStripButton3.Text = "UpdateAccount";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem1_Click);
            // 
            // USP_GetTableListBindingSource
            // 
            this.USP_GetTableListBindingSource.DataMember = "USP_GetTableList";
            // 
            // GetListBillByDateForReport
            // 
            this.GetListBillByDateForReport.DataSetName = "GetListBillByDateForReport";
            this.GetListBillByDateForReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_GetListBillByDateForReportBindingSource
            // 
            this.USP_GetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.USP_GetListBillByDateForReportBindingSource.DataSource = this.GetListBillByDateForReport;
            // 
            // USP_GetListBillByDateForReportTableAdapter
            // 
            this.USP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyCaPheDataSet1
            // 
            this.QuanLyCaPheDataSet1.DataSetName = "QuanLyCaPheDataSet1";
            this.QuanLyCaPheDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 489);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabTableList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListMenuByTableForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCaPheDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabTableList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmbAmount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDisCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetTableListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetListBillByDateForReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateForReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCaPheDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tabTableList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.BindingSource USP_GetTableListBindingSource;
        public System.Windows.Forms.BindingSource USP_GetListMenuByTableForReportBindingSource;
        public QuanLyCaPheDataSet QuanLyCaPheDataSet;
        public QuanLyCaPheDataSetTableAdapters.USP_GetListMenuByTableForReportTableAdapter USP_GetListMenuByTableForReportTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.ComboBox cmbChangeTable;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.NumericUpDown nmbDisCount;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmbAmount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.ComboBox cmbFoodCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.ToolStripMenuItem chỉnhMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaMónToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLogOut;
        private System.Windows.Forms.ToolStripButton tsbAdminManagement;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateForReportBindingSource;
        private GetListBillByDateForReport GetListBillByDateForReport;
        private GetListBillByDateForReportTableAdapters.USP_GetListBillByDateForReportTableAdapter USP_GetListBillByDateForReportTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyCaPheDataSet1 QuanLyCaPheDataSet1;
    }
}