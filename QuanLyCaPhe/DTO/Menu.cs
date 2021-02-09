using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu (DataRow row)
        {
            this.FoodName = row["NAME"].ToString();
            this.Count = (int)row["COUNT"];
            this.Price = (int)row["PRICE"];
            this.TotalPrice = (int)row["TOTALPRICE"];

        }
        public string FoodName { get { return foodName;} set { foodName = value; }}
        public int Count { get { return count;} set { count = value;} }
        public float Price { get { return price; }set { price = value; }}
        public float TotalPrice { get { return totalPrice; } set { totalPrice = value; } }

    }
}
