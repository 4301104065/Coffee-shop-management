using QuanLyCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyCaPhe.DTO.Menu;

namespace QuanLyCaPhe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenyByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.NAME, bi.COUNT, f.PRICE, f.PRICE*bi.COUNT AS TOTALPRICE FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.IDBILL = b.ID AND bi.IDFOOD = f.ID AND b.TINHTRANG = 0 AND b.IDTABLE = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new DTO.Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
