using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            set { instance = value; }
        }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM dbo.Food WHERE IDCATEGORY = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;

        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM dbo.Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;

        }
        public void DeleteFoodByCategoryID(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByCategoryID(id);
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Food WHERE IDCATEGORY = " + id);
        }
    

        public bool InsertFood(string name, int idcategory, float price)
        {
            string query = string.Format("INSERT dbo.Food (NAME,IDCATEGORY,PRICE) VALUES(N'{0}',{1},{2})", name, idcategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateFood(int idfood,string name, int idcategory, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET NAME = N'{0}',IDCATEGORY = {1}, PRICE = {2} WHERE ID = {3}", name, idcategory, price,idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int idfood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idfood);
            string query = string.Format("DELETE FROM Food WHERE ID ={0}", idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Food>SearchFoodByname(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(NAME) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public int GetFoodIDByFoodName(string name)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT dbo.Food.ID FROM dbo.Food WHERE NAME = '" + name+"'");
        }
    }

}
