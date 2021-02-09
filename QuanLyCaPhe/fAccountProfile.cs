using QuanLyCaPhe.DAO;
using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void ChangeAccount(Account acc) 
            {
            txbuser.Text = acc.UserName;
            txbHienThi.Text = acc.DisplayName;
            } 
        void UpdateAccountInfo()
        {
            string displayname = txbHienThi.Text;
            string password = txbPass.Text;
            string newpass = txbPassNew.Text;
            string reenterpass = txbPassNewAgain.Text;
            string username = txbuser.Text;
            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show(" Bạn hãy nhập lại mật khẩu đúng với mật khẩu mới!!!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, displayname, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null) updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value;}
            remove { UpdateAccount -= value; }
        }

        private void txbHienThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }
        
    }
    public class AccountEvent : EventArgs
        {
            private Account acc;
            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }
            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }
}
