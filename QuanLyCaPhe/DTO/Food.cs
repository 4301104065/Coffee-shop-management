using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private int idcategory;
        private int price;
        public Food(int id, string name, int idcategory, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Idcategory = idcategory;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["NAME"].ToString();
            this.Idcategory = (int)row["IDCATEGORY"];
            this.Price = (int)row["PRICE"];

        }
        public int Id { get { return id; }set { id = value; }}
        public string Name { get { return name; }set { name = value;} }
        public int Idcategory { get { return idcategory;} set { idcategory = value; }}
        public int Price { get { return price; } set { price = value; } }
    }
}
