using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class Bill_BLL
    {
        private static Bill_BLL instance;
        public static Bill_BLL Instance
        {
            get { if (instance == null) { instance = new Bill_BLL(); } return Bill_BLL.instance; }
            private set { Bill_BLL.instance = value; }
        }
        public Bill_BLL() { }
       
        public Bill LoadBill(string idtb)
        {
            // Lấy ra bill chưa thanh toán của bàn hiện tại
            Bill bill = DataProvider.Instance.ExecuteTest("EXEC USP_LISTTABLE @IDTB" , new object[] {idtb});
            if(bill == null) 
            {
                // Nếu kh có bill nào thì tạo mới rồi quay lại Sql đọc lần nữa
                Bill_DAL.Instance.AddBill(idtb);
                bill = DataProvider.Instance.ExecuteTest("EXEC USP_LISTTABLE @IDTB", new object[] { idtb });
            }
            
            //Lấy ra bill_info của bill này     
            bill.BillList = Bill_DAL.Instance.list(bill.Id);           
            return bill;
        }
        public void AddBill_Info(int idBill, string nameF)
        {
            Bill_DAL.Instance.AddBill_Info(idBill , nameF);
        }
        public void SubBill_Info(int idBill, string nameF)
        {
            Bill_DAL.Instance.SubBill_Info(idBill, nameF);
        }
        public void DelBill_Info(int idBill, string nameF)
        {
            Bill_DAL.Instance.DelBill_Info(idBill, nameF);
        }
        public void GopBill(int idbill, int idtable)
        {
            Bill_DAL.Instance.GopBill(idbill, idtable);
        }
        public void ThanhToanBill(int idbill , double GiamGia)
        {
            Bill_DAL.Instance.ThanhToanBill(idbill , GiamGia);
        }
        public List<Bill> DaThanhToan(DateTime time)//Hàm lấy ra bill đã thanh toán để hiển thị lên thống kê
        {
            List<Bill> list = new List<Bill>();
            list = Bill_DAL.Instance.DaThanhToan(time);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].BillList = Bill_DAL.Instance.list(list[i].Id);
            }
            return list;
        }
        public List<Bill_Info> listBill_info(DateTime time)
        {
            return Bill_DAL.Instance.listBill_info(time);
        }
    }
}
