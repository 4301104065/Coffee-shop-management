using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class Table
    {
        private int id;
        


        private string name;
      
        private string status;

        public string Status { get { return status; }set { status = value;} }
        public string Name { get { return name;} set { name = value;} }
        public int Id { get { return id; } set { id = value; } }
        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        public Table(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["NAME"].ToString();
            this.Status = row["TINHTRANG"].ToString();
        }
    }
}
