using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int _id;
        private int _idTable;
        private int _status;
        private DateTime _timeIn;
        private DateTime _timeOut;
        private List<Bill_Info> _billList;
        private Double _giamGia;
        

        public double GiaTri  
        {
            get
            {
                double giaTri = 0;
                if(_billList != null)
                {
                    foreach (Bill_Info item in _billList)
                    {
                        giaTri += (item.Food.Price * item.Amount);
                    }
                }
                
                return giaTri*(1 - _giamGia/100.0);
            }
        }
       

        public int Id { get => _id; set => _id = value; }
        public int IdTable { get => _idTable; set => _idTable = value; }
        public int Status { get => _status; set => _status = value; }
        public DateTime TimeIn { get => _timeIn; set => _timeIn = value; }
        public DateTime TimeOut { get => _timeOut; set => _timeOut = value; }
        public List<Bill_Info> BillList { get => _billList; set => _billList = value; }
        public double GiamGia { get => _giamGia; set => _giamGia = value; }
        
        public Bill() { }
        public Bill(int id, int idTable, int status, DateTime timeIn, DateTime timeOut)
        {
            _id = id;
            _idTable = idTable;
            _status = status;
            _timeIn = timeIn;
            _timeOut = timeOut;
        }
        public Bill(DataRow row)// Lấy ra Bill đã thanh toán từu Sql
        {
            Id = int.Parse(row["ID"].ToString());
            IdTable = int.Parse(row["IDTB"].ToString());
            TimeIn = DateTime.Parse(row["DATEIN"].ToString());
            TimeOut = DateTime.Parse(row["DATEOUT"].ToString());
            GiamGia = double.Parse(row["GIAMGIA"].ToString());
        }
    }
}
