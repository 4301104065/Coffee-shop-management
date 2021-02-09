using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int foodID;
        private int count;

        public int ID { get { return iD;}  set { iD = value; }}
        public int BillID { get {return billID;} set {billID = value;} }
        public int FoodID { get { return foodID;} set { foodID = value;} }
        public int Count { get { return count; } set { count = value; } }
        public BillInfo(int id, int billid, int foodid, int count)
        {
            this.ID = id;
            this.BillID = billid;
            this.FoodID = foodid;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.BillID = (int)row["IDBILL"];
            this.FoodID = (int)row["IDFOOD"];
            this.Count = (int)row["COUNT"];

        }
    }
}
