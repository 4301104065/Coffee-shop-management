using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class Category
    {
        public Category(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["NAME"].ToString();
        }
        public Category (int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        private int id;
        private string name;

        public int Id { get { return id; }set { id = value;} }
        public string Name { get { return name; } set { name = value; } }

    }
}
