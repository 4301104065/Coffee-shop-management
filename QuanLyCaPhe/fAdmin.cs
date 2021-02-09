using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCaPhe.DAO;
using QuanLyCaPhe.DTO;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace QuanLyCaPhe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            ///// Trang thống kê
            LoadDateTimePicker();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            //// Trang Food
            dtgvFood.DataSource = foodList;
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
            //// Trang Category
            dtgvCategory.DataSource = categoryList;
            LoadListCategory();
            AddCategoryBinding();
            //// Trang Table
            dtgvTable.DataSource = tableList;
            LoadListTable();
            LoadTableIntoCombobox(cbStatusTable);
            AddTableBinding();
            // Trang account
            dtgvAccount.DataSource = accountList;
            LoadListAccount();
            LoadAccountIntoCombobox(cmbAccountType);
            AddAccountBinding();

        }
        #region property
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByname(name);

            return listFood;
        }
        /// Phương thức của trang Thống kê
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            //dtpkToDate.Value.AddMonths(1).AddDays(2);
            dtpkToDate.Value = new DateTime(today.Year, today.Month, today.Day+1);
        }
        /// <summary>
        /// Phương thức của trang Food
        /// </summary>
       void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txbNameFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name",true,DataSourceUpdateMode.Never));
            txbIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbPriceFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox (ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        /// Phương thức của trang Category
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddCategoryBinding()
        {
            txbIDCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbCategoryCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            
        }
        /// Phương thức của Table
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }
        void AddTableBinding()
        {
            txbIDTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNameTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            
            
            
        }
        void LoadTableIntoCombobox(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.GetListStatusTable();
 
        }
        // Phương thức của Account
        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName",true,DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName",true,DataSourceUpdateMode.Never));
            txbPassword.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
            txbIDAccount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void LoadAccountIntoCombobox(ComboBox cb)
        {
            cb.DataSource = AccountDAO.Instance.GetListTypeAccount();

        }
        #endregion
        #region dont touch
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region event_ThongKe&Food
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            // TODO: This line of code loads data into the 'GetListBillByDateForReport.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.
            this.USP_GetListBillByDateForReportTableAdapter.Fill(this.GetListBillByDateForReport.USP_GetListBillByDateForReport, dtpkFromDate.Value, dtpkToDate.Value);

            this.reportViewer1.RefreshReport();
            GetSumOfTotalPriceByDate();
            
        }

        private void btnWatchFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txbIDFood_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IDCATEGORY"].Value;
                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                cbFoodCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach(Category item in cbFoodCategory.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbFoodCategory.SelectedIndex = index;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int categoryid = (cbFoodCategory.SelectedItem as Category).Id;
            float price = Convert.ToInt32(txbPriceFood.Text);
            if (FoodDAO.Instance.InsertFood(name, categoryid, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null) insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int categoryid = (cbFoodCategory.SelectedItem as Category).Id;
            float price = Convert.ToInt32(txbPriceFood.Text);
            int idfood = Convert.ToInt32(txbIDFood.Text);
            if (FoodDAO.Instance.UpdateFood(idfood,name, categoryid, price))
            {
                MessageBox.Show("Đã chỉnh sửa món thành công");
                LoadListFood();
                if (updateFood != null) updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi chỉnh sửa món");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int idfood = Convert.ToInt32(txbIDFood.Text);
            if (FoodDAO.Instance.DeleteFood(idfood))
            {
                MessageBox.Show("Đã xóa món thành công");
                LoadListFood();
                if (deleteFood != null) deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearch.Text);
        }
        #endregion
        #region eventcategory
        private void btnWatchCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryCategory.Text;
            
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadListCategory();
                LoadListFood();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (insertCategory != null) insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryCategory.Text;
            int id = Convert.ToInt32(txbIDCategory.Text);
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show(" Sửa danh mục thành công");
                LoadListCategory();
                LoadListFood();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (updateCategory != null) updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show(" Có lỗi khi sửa danh mục");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int idfood = Convert.ToInt32(txbIDCategory.Text);
            if (CategoryDAO.Instance.DeleteFoodCategory(idfood))
            {
                MessageBox.Show("Đã xóa danh mục thành công");
                LoadListCategory();
                LoadListFood();
                LoadCategoryIntoCombobox(cbFoodCategory);

                if (deleteCategory != null) deleteCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục");
            }
        }
       



        #endregion
        #region eventtable
        private void txbIDTable_TextChanged(object sender, EventArgs e)
        {
            if (dtgvTable.SelectedCells.Count > 0)
            {
                string status = dtgvTable.SelectedCells[0].OwningRow.Cells["STATUS"].Value.ToString();
                int index = -1;
                int i = 0;
                foreach (string item in cbStatusTable.Items)
                {
                    if (item == status)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbStatusTable.SelectedIndex = index;
            }
        }
        private void btnWatchTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbNameTable.Text;

            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadListTable();
                
                
                if (insertTable != null) insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDTable.Text);
            string name = txbNameTable.Text;
            string status = cbStatusTable.SelectedItem.ToString();
           
            if (TableDAO.Instance.UpdateTable(id, name,status))
            {
                MessageBox.Show(" Sửa bàn thành công");
                LoadListTable();
                
                
                if (updateTable != null) updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show(" Có lỗi khi sửa bàn");
            }
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int idfood = Convert.ToInt32(txbIDTable.Text);
            if (TableDAO.Instance.DeleteTable(idfood))
            {
                MessageBox.Show("Đã xóa bàn thành công");
                LoadListTable();
                
                

                if (deleteTable != null) deleteTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa bàn");
            }
        }
        #endregion


        #region eventaccount
        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count > 0)
            {
                int type = (int)dtgvAccount.SelectedCells[0].OwningRow.Cells["LOAI"].Value;
                int index = -1;
                int i = 0;
                foreach (int item in cmbAccountType.Items)
                {
                    if (item == type)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cmbAccountType.SelectedIndex = index;
            }
        }


        #endregion
        private void btnWatchAccount_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            
            string displayname = txbDisplayName.Text;
            string username = txbUserName.Text;
            string matkhau = txbPassword.Text;
            int loai = Convert.ToInt32(cmbAccountType.SelectedItem.ToString());
            if (AccountDAO.Instance.InsertAccount(displayname, username, matkhau, loai))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show(" Có lỗi khi thêm tài khoản");
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDAccount.Text);
            string displayname = txbDisplayName.Text;
            string username = txbUserName.Text;
            string matkhau = txbPassword.Text;
            int loai = Convert.ToInt32(cmbAccountType.SelectedItem.ToString());
            if (AccountDAO.Instance.UpdateAccount(id,displayname, username, matkhau, loai))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show(" Có lỗi khi sửa tài khoản");
            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDAccount.Text);
            if (id == 1)
            {
                MessageBox.Show(" Không thể xóa tài khoản ADMIN mặc định. Xin hãy chọn tài khoản khác!!!!");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(id))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show(" Có lỗi khi xóa tài khoản");
            }
        }

        

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txbPage.Text = "1";
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                lastPage++;
            txbPage.Text = lastPage.ToString();

        }

        private void txbPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPage.Text));

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPage.Text);
            if (page > 1) page--;
            txbPage.Text = page.ToString();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPage.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                lastPage++;
            if (page < lastPage)
                page++;

            txbPage.Text = page.ToString();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GetListBillByDateForReport.USP_GetListBillByDateForReport' table. You can move, or remove it, as needed.
            this.USP_GetListBillByDateForReportTableAdapter.Fill(this.GetListBillByDateForReport.USP_GetListBillByDateForReport,dtpkFromDate.Value,dtpkToDate.Value);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
        private double GetSumOfTotalPriceByDate()
        {
            double TotalPriceBill = 0;
            TotalPriceBill = BillDAO.Instance.GetSumofTotalPriceByDate(dtpkFromDate.Value , dtpkToDate.Value);
            CultureInfo culture = new CultureInfo("vi-VN");
            ReportParameter pricebill = new ReportParameter("TOTALPRICEBILL", TotalPriceBill.ToString("c",culture));

            this.reportViewer1.LocalReport.SetParameters(pricebill) ;
            this.reportViewer1.RefreshReport();
            txbTongDoanhThu.Text = "Doanh Thu = " + TotalPriceBill.ToString("c",culture);
            return TotalPriceBill;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbPriceFood_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPriceFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
