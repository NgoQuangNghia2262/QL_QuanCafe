using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        private int _id;
        private Bill _idBill;
        private int _status;
        public int Id { get => _id; set => _id = value; }
        public Bill IdBill { get => _idBill; set => _idBill = value; }
        public int Status { get => _status; set => _status = value; }
        public Table() { }
        public Table(int id, Bill idBill, int status)
        {
            _id = id;
            _idBill = idBill;
            _status = status;
        }
        public Table(DataRow row)
        {
            this.Id = int.Parse(row["ID"].ToString());
            this.Status = int.Parse(row["STATUS"].ToString());
        }
    }
}
