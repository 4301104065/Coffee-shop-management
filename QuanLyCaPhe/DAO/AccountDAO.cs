using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyCaPhe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance;  }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string hasPass;
            hasPass = MaHoaPass(password);
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{username, hasPass });
            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE USERNAME = '" + username+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null; 
        }
        public bool UpdateAccount(string username, string displayname, string pass, string newpass)
        {
            pass = MaHoaPass(pass);
            newpass = MaHoaPass(newpass);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { username, displayname, pass, newpass });
            return result > 0;
        }
        public List<Account> GetListAccount()
        {
            List<Account> accountList = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account");
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accountList.Add(account);
            }
            return accountList;
        }
        public List<int> GetListTypeAccount()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            return list;
        }
        public bool InsertAccount(string displayname,string username, string matkhau, int loai)
        {
            matkhau = MaHoaPass(matkhau);
            string query = string.Format("INSERT dbo.Account (DISPLAYNAME,USERNAME,MATKHAU,LOAI) VALUES(N'{0}',N'{1}',N'{2}',{3})", displayname,username,matkhau,loai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(int id, string displayname, string username, string matkhau, int loai)
        {
            matkhau = MaHoaPass(matkhau);
            string query = string.Format("UPDATE dbo.Account SET DISPLAYNAME = N'{0}', USERNAME =N'{1}', MATKHAU=N'{2}',LOAI={3} WHERE ID = {4}", displayname, username, matkhau, loai,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(int id)
        {
            string query = string.Format("DELETE FROM dbo.Account WHERE ID ={0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        string MaHoaPass(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }


    }
}
