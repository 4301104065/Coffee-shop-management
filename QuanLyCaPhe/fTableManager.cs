using Microsoft.Reporting.WinForms;
using QuanLyCaPhe.DAO;
using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class fTableManager : Form
    {
        public Account loginAccount;
        public int tableID;
        public int idBill;
        public double totalPrice;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Loai); }
        }
        public int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        public int IDBill
        {
            get { return idBill; }
            set { idBill = value; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadCombobox(cmbChangeTable);

        }
        void ChangeAccount( int loai)
        {
            adminToolStripMenuItem.Enabled = loai == 1;
            tsbAdminManagement.Enabled = loai == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> list = CategoryDAO.Instance.GetListCategory();
            cmbFoodCategory.DataSource = list;
            cmbFoodCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> list = FoodDAO.Instance.GetFoodByCategoryID(id);
            cmbFood.DataSource = list;
            cmbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach(Table table in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += Btn_Click;
                btn.Tag = table;
                switch (table.Status)
                {
                    case "Trống": btn.BackColor = Color.AliceBlue;
                        break;
                    default: btn.BackColor = Color.LightBlue;
                        break;


                }
                flpTable.Controls.Add(btn);
                
            }
        }
        void LoadCombobox (ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyCaPhe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenyByTable(id);
            float totalPrice = 0;
            foreach(QuanLyCaPhe.DTO.Menu item in listBillInfo)
            {
                
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            
            txbTotalPrice.Text = totalPrice.ToString("c",culture);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            tableID = ((sender as Button).Tag as Table).Id ;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            idBill = BillDAO.Instance.GetUnCheckedBillByTableID(tableID);
            if (idBill == -1)
            {
                ReportParameter checkin = new ReportParameter("CHECKIN", " ");
                ReportParameter checkout = new ReportParameter("CHECKOUT", " ");
                this.reportViewer1.LocalReport.SetParameters(checkin);
                this.reportViewer1.LocalReport.SetParameters(checkout);
            }
            passParametersforReportByTable(tableID);

            
            // TODO: This line of code loads data into the 'QuanLyCaPheDataSet1.USP_GetTableList' table. You can move, or remove it, as needed.



            



            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();

        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.InsertFood += f_InsertFood;
            f.UpdateFood += f_UpdateFood;
            f.DeleteFood += f_DeleteFood;
            f.InsertCategory += f_InsertCategory;
            f.UpdateCategory += f_UpdateCategory;
            f.DeleteCategory += f_DeleteCategory;
            f.InsertTable += f_InsertTable;
            f.UpdateTable += f_UpdateTable;
            f.DeleteTable += f_DeleteTable;
            f.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cmbFoodCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }
        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cmbFoodCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }
        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cmbFoodCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }
        void f_UpdateCategory(object sender, EventArgs e)
        {
            LoadCategory();
            
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }
        void f_InsertCategory(object sender, EventArgs e)
        {
            LoadCategory();
            
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }
        void f_DeleteCategory(object sender, EventArgs e)
        {
            LoadCategory();
            
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }
        void f_UpdateTable(object sender, EventArgs e)
        {
            

            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }
        void f_InsertTable(object sender, EventArgs e)
        {
            

            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }
        void f_DeleteTable(object sender, EventArgs e)
        {
            

            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyCaPheDataSet1.USP_GetListMenuByTableForReport' table. You can move, or remove it, as needed.
            //this.USP_GetListMenuByTableForReportTableAdapter.Fill(this.QuanLyCaPheDataSet1.USP_GetListMenuByTableForReport,tableID);
            // TODO: This line of code loads data into the 'GetListBillByDateForReport.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'QuanLyCaPheDataSet.USP_GetListMenuByTableForReport' table. You can move, or remove it, as needed.


            // TODO: This line of code loads data into the 'QuanLyCaPheDataSet1.USP_GetTableList' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodListByCategoryID(id);
        }

        private void btnThemmon_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            { MessageBox.Show("Hãy chọn 1 bàn cần thêm món!!!!!!", "Thông Báo", MessageBoxButtons.OK); return; }
            Table table = lsvBill.Tag as Table;
            tableID = table.Id;
            idBill = BillDAO.Instance.GetUnCheckedBillByTableID(tableID);
            int foodid = (cmbFood.SelectedItem as Food).Id;
            int count = (int)nmbAmount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(tableID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodid, count);
                ReportParameter checkin= new ReportParameter("CHECKIN", DateTime.Now.ToLongTimeString());
                this.reportViewer1.LocalReport.SetParameters(checkin);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodid, count);

            }
            passParametersforReportByTable(tableID);
            ShowBill(tableID);
            LoadTable();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            { MessageBox.Show("Hãy chọn 1 bàn để xóa món!!!!!!", "Thông Báo", MessageBoxButtons.OK); return; }
            Table table = lsvBill.Tag as Table;
            tableID = table.Id;
            
            idBill = BillDAO.Instance.GetUnCheckedBillByTableID(tableID);
            if (idBill == -1)
            {
                MessageBox.Show("Không thể xóa do menu trống!!!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string foodName;
                for (int i = 0; i < lsvBill.Items.Count; i++) //duyệt tất cả các item trong list
                {

                    if (lsvBill.Items[i].Selected)//nếu item đó dc check
                    {
                        
                        foodName = lsvBill.Items[i].SubItems[0].Text.ToString();
                        BillInfoDAO.Instance.DeleteFoodByIDBillAndFoodName(idBill, foodName);
                        lsvBill.Items[i].Remove();//xóa item đó đi
                        i--;
                        passParametersforReportByTable(tableID);

                    }
                }
                ShowBill(tableID);
                
            }


        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            { MessageBox.Show("Hãy chọn 1 bàn để chỉnh sửa món!!!!!!", "Thông Báo", MessageBoxButtons.OK); return; }
            Table table = lsvBill.Tag as Table;
            tableID = table.Id;

            idBill = BillDAO.Instance.GetUnCheckedBillByTableID(tableID);
            if (idBill == -1)
            {
                MessageBox.Show("Không thể chỉnh sửa do menu trống!!!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string foodName;
                int count = (int)nmbAmount.Value;
                
                
                   
                
                for (int i = 0; i < lsvBill.Items.Count; i++) //duyệt tất cả các item trong list
                {

                    if (lsvBill.Items[i].Selected)//nếu item đó dc check
                    {
                        
                        foodName = lsvBill.Items[i].SubItems[0].Text.ToString();
                        if (count == 0)
                        {
                            BillInfoDAO.Instance.DeleteFoodByIDBillAndFoodName(idBill, foodName);
                        }
                        else
                        BillInfoDAO.Instance.EditFoodByIDBillAndFoodName(idBill, foodName, count);
                        
                        passParametersforReportByTable(tableID);

                    }
                }
                
                ShowBill(tableID);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            { MessageBox.Show("Hãy chọn 1 bàn cần thanh toán!!!!!!", "Thông Báo", MessageBoxButtons.OK); return; }
                Table table = lsvBill.Tag as Table;
            tableID = table.Id;
            int idBill = BillDAO.Instance.GetUnCheckedBillByTableID(tableID);
            int discount = (int)nmbDisCount.Value;
            string temp = txbTotalPrice.Text.Split(',')[0];
            temp = temp.Replace(".","");
            double totalprice = Convert.ToDouble(temp);
            double discountprice = (totalprice/100)*discount;
            totalPrice = totalprice - discountprice;
            CultureInfo culture = new CultureInfo("vi-VN");
            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có thật sự muốn thanh toán bàn " + table.Id +" không? \nTiền phải thanh toán là "+totalPrice.ToString("c",culture),"Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    
                    ReportParameter checkout = new ReportParameter("CHECKOUT", DateTime.Now.ToString());
                    this.reportViewer1.LocalReport.SetParameters(checkout);
                    this.reportViewer1.RefreshReport();
                    passParametersforReportByTable(tableID);
                    BillDAO.Instance.CheckOut(idBill,discount,(float)totalPrice);
                    this.reportViewer1.RefreshReport();
                    ShowBill(tableID);
                    LoadTable();
                    nmbDisCount.Value = 0;

                }
            }

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null) { MessageBox.Show("Hãy chọn 1 bàn cần chuyển!!!!!!", "Thông Báo", MessageBoxButtons.OK); return; }
            int id1 = (lsvBill.Tag as Table).Id;
            int id2 = (cmbChangeTable.SelectedItem as Table).Id;
           
           
            
                if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển từ bàn {0} qua bàn {1} không?",(lsvBill.Tag as Table).Name,(cmbChangeTable.SelectedItem as Table).Name),"Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                            {
                                TableDAO.Instance.SwitchTable(id1, id2);
                                LoadTable();
                                lsvBill.Tag = cmbChangeTable.SelectedItem;
                            }
            
            
            
        }
        public void passParametersforReportByTable(int tableID)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            int discount = (int)nmbDisCount.Value;
            string temp = txbTotalPrice.Text.Split(',')[0];
            temp = temp.Replace(".", "");
            double totalprice = Convert.ToDouble(temp);
            double discountprice = (totalprice / 100) * discount;
            double finalPrice = totalprice - discountprice;
            this.USP_GetListMenuByTableForReportTableAdapter.Fill(this.QuanLyCaPheDataSet.USP_GetListMenuByTableForReport, tableID);

            ReportParameter[] parameters = new ReportParameter[6];
            
            int idbill = BillDAO.Instance.GetUnCheckedBillByTableID(tableID);

            parameters[0] = new ReportParameter("IDBILL", idbill.ToString());
            parameters[1] = new ReportParameter("IDTABLE", tableID.ToString());
            parameters[2] = new ReportParameter("NHANVIEN", LoginAccount.DisplayName);
            parameters[3] = new ReportParameter("TOTALPRICE", finalPrice.ToString("c",culture));
            parameters[4] = new ReportParameter("THANHTIEN", txbTotalPrice.Text);
            parameters[5] = new ReportParameter("GIAMGIA", string.Format("{0}%", discount));
            
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            int discount = (int)nmbDisCount.Value;
            string temp = txbTotalPrice.Text.Split(',')[0];
            temp = temp.Replace(".", "");
            double totalprice = Convert.ToDouble(temp);
            double discountprice = (totalprice / 100) * discount;
            double finalprice = totalprice - discountprice;
            if (totalprice == 0) return;
            ReportParameter finalPrice= new ReportParameter("TOTALPRICE", finalprice.ToString("c",culture));
            ReportParameter totalPrice = new ReportParameter("THANHTIEN", totalprice.ToString("c", culture)); 
            this.reportViewer1.LocalReport.SetParameters(finalPrice);
            this.reportViewer1.LocalReport.SetParameters(totalPrice);
            this.reportViewer1.RefreshReport();
            
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            int discount = (int)nmbDisCount.Value;
            ReportParameter giamgia = new ReportParameter("GIAMGIA", string.Format("{0}%", discount));

            this.reportViewer1.LocalReport.SetParameters(giamgia);
            this.reportViewer1.RefreshReport();
        }
    }
}
