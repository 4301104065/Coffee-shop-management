using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class Bill
    {
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;
        private int discout;
        public int ID { get { return iD;} set { iD = value;} }
        public DateTime? DateCheckIn { get { return dateCheckIn; }set { dateCheckIn = value;} }
        public DateTime? DateCheckOut { get { return dateCheckOut;} set { dateCheckOut = value;} }
        public int Status { get {return status; }set { status = value;} }
        public int Discout { get { return discout; } set { discout = value; } }

        public Bill(int id, DateTime? datecheckin, DateTime? datecheckout, int status, int discount)
        {
            this.ID = id;
            this.DateCheckIn = datecheckin;
            this.DateCheckOut = datecheckout;
            this.Status = status;
            this.Discout = discount;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.DateCheckIn = (DateTime?)row["DATECHECKIN"];
            var DateCheckOutTemp = row["DATECHECKOUT"];
            if (DateCheckOutTemp.ToString() != "")
            { this.DateCheckOut = (DateTime?)DateCheckOutTemp; }
            this.Status = (int)row["TINHTRANG"];
            if (row["DISCOUNT"].ToString() != "")
            {
                this.Discout = (int)row["DISCOUNT"];
            }
           

        }
    }
}
