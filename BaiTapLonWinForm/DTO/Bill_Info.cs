using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill_Info
    {
        private int _idBill;
        private int _amount;
        private Food _food;

        public Bill_Info() { }

        public Bill_Info(int idBill, int amount, Food food)
        {
            IdBill = idBill;
            Amount = amount;
            Food = food;
        }
        public Bill_Info(int amount, Food food)
        {
            Amount = amount;
            Food = food;
        }
        public Bill_Info(DataRow row)
        {
            IdBill = int.Parse(row["IDBILL"].ToString());
            Amount = int.Parse(row["SL"].ToString());
            Food = new Food(row);
        }

        public int IdBill { get => _idBill; set => _idBill = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public Food Food { get => _food; set => _food = value; }
    }
}
