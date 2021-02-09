using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE IDBILL = " + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;

        }
        public void InsertBillInfo(int idbill, int idfood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count ", new object[] { idbill, idfood, count });
        }
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.BillInfo WHERE IDFOOD = " + id);
        }
        public void DeleteBillInfoByCategoryID(int id)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM dbo.BillInfo WHERE IDFOOD IN (SELECT ID FROM dbo.Food WHERE IDCATEGORY = {0})",id));
        }
        public void DeleteFoodByIDBillAndFoodName(int id, string foodname)
        {
            int idfood=FoodDAO.Instance.GetFoodIDByFoodName(foodname);
            DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM dbo.BillInfo WHERE IDBILL = {0} AND IDFOOD = {1}", id, idfood));
        }
        public void EditFoodByIDBillAndFoodName(int id, string foodname,int count)
        {
            int idfood = FoodDAO.Instance.GetFoodIDByFoodName(foodname);
            DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE dbo.BillInfo SET COUNT = {0} FROM dbo.BillInfo WHERE IDBILL = {1} AND IDFOOD = {2}",count,id,idfood));
        }

   
    }
}
