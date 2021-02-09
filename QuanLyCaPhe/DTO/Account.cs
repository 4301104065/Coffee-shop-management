using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class Account
    {
        private int iD;
        private string userName;
        private string displayName;
        private string matKhau;
        private int loai;
        public Account(int id, string username, string displayname, string matkhau, int loai)
        {
            this.ID = id;
            this.UserName = username;
            this.DisplayName = displayname;
            this.MatKhau = matkhau;
            this.Loai = loai;
        }
        public Account(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.UserName = row["USERNAME"].ToString();
            this.DisplayName = row["DISPLAYNAME"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();
            this.Loai = (int)row["LOAI"];
        }

        public int ID { get { return iD;} set { iD = value;} }
        public string UserName { get {return userName;} set { userName = value; }}
        public string DisplayName { get { return displayName; }set { displayName = value; }}
        public string MatKhau { get { return matKhau;} set { matKhau = value;} }
        public int Loai { get { return loai; } set { loai = value; } }
    }
}
