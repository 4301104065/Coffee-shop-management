using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public static int TableHeight=50;
        public static int TableWidth=50;
        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);  
            }
            return tableList;
        }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        public List<string> GetListStatusTable()
        {
            List<string> list = new List<string>();
            list.Add("Trống");
            list.Add("Có người");
            return list;
        }
        public Table GetStatusTableByID(int id)
        {
            Table table = null;
            string query = "SELECT * FROM dbo.TableFood WHERE ID = " + id;
            DataTable data=DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                table = new Table(item);
                return table;
            }
            return table;


        }
        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT dbo.TableFood (NAME,TINHTRANG) VALUES(N'{0}',N'Trống')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(int id, string name,string status)
        {
            string query = string.Format("UPDATE dbo.TableFood SET NAME = N'{0}', TINHTRANG =N'{2}' WHERE ID = {1}", name, id,status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
           
            string query = string.Format("DELETE FROM TableFood WHERE ID ={0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
