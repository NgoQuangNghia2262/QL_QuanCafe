using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Bill_DAL
    {
        private static Bill_DAL instance;
        public static Bill_DAL Instance
        {
            get { if (instance == null) { instance = new Bill_DAL(); } return Bill_DAL.instance; }
            private set { Bill_DAL.instance = value; }
        }
        public Bill_DAL() { }

        public void AddBill(string idtb)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_ADDBILL @IDTB", new object[] { idtb });
        }
        public void AddBill_Info(int idBill , string nameF)
        {
            #region 
            /*
        * CREATE PROC USP_ADDBILLINFO
@IDBILL INT , @NAMEF NVARCHAR(100)
AS
BEGIN
   DECLARE @I INT
   SET @I = 0;
   SELECT @I = SL FROM FoodInBill	WHERE IDBILL = @IDBILL AND NAMEF = @NAMEF
   IF @I<1
   BEGIN
       INSERT INTO FoodInBill(IDBILL,NAMEF) VALUES (@IDBILL , @NAMEF)
   END
   ELSE
   BEGIN
       --Sửa
       UPDATE FoodInBill SET SL = SL + 1 WHERE IDBILL = @IDBILL AND NAMEF = @NAMEF
   END
END
        */
            #endregion
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_ADDBILLINFO @IDBILL , @NAMEF" , new object[] {idBill , nameF});
        }
        public void SubBill_Info(int idBill, string nameF)
        {
            #region 
            /*
        * CREATE PROC USP_ADDBILLINFO
@IDBILL INT , @NAMEF NVARCHAR(100)
AS
BEGIN
   DECLARE @I INT
   SET @I = 0;
   SELECT @I = SL FROM FoodInBill	WHERE IDBILL = @IDBILL AND NAMEF = @NAMEF
   IF @I<1
   BEGIN
       INSERT INTO FoodInBill(IDBILL,NAMEF) VALUES (@IDBILL , @NAMEF)
   END
   ELSE
   BEGIN
       --Sửa
       UPDATE FoodInBill SET SL = SL + 1 WHERE IDBILL = @IDBILL AND NAMEF = @NAMEF
   END
END
        */
            #endregion
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_SUBBILLINFO @IDBILL , @NAMEF", new object[] { idBill, nameF });
        }
        public List<Bill_Info> list(int idbill)
        {
            List<Bill_Info> list = new List<Bill_Info>();
 //Lấy ra danh sách Bill_Info của Bill 
            //lấy danh sách bill_info của bill có id = idbill (lấy ra IDBILL , NAME , SL , PRICE , CATEGORY)
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_FOODINBILL @IDBILL", new object[] { idbill });
            foreach (DataRow row in data.Rows) // Mỗi vòng lặp lấy ra 1 row chứa thông tin {food(Tên đồ uống , giá , loại) , idbill , số lượng đồ uống}
            {
                Bill_Info newB = new Bill_Info(row);//Tạo bill_info tên newB ( cái này sẽ được thêm vào list nếu list chưa có newB này)
                for (int i = 0; i < list.Count; i++)//Tìm lại trong danh sách list nếu đã có bill_info rồi thì tăng số lượng lên rồi bỏ qua 
                {
                    // nếu row này ( row lấy từ Sql) có tên đồ uống đã nằm trong danh sách bill_info
                    // Thì tăng số lượng của bill_info đó lên rồi sau đó bỏ qua phần --list.Add(newB);
                    if (list[i].Food.Name == row["NAME"].ToString()) 
                    {
                        list[i].Amount += int.Parse(row["SL"].ToString());
                        goto ParallelLoopResult;
                    }
                }
                list.Add(newB);
            ParallelLoopResult:;//Dòng này để bỏ qua phần list.Add(newB) để tiếp tục vòng lặp nếu tên đồ uống đã nằm trong danh sách bill_info
            }
            return list;
        } // Truyền vào idbill để lấy ra danh sách bill_info của bill đó
        public void DelBill_Info(int idBill, string nameF)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_DELBILLINFO @IDBILL , @NAMEF", new object[] { idBill, nameF });
        }
        public void GopBill(int idbill , int idtable) // Gộp bill 2 ( @IDBILL2) vào bill 1 ( @IDBILL )
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_GOPBAN @IDBILL , @IDTABLE", new Object[] { idbill , idtable});
        }
        public void ThanhToanBill(int idbill , double GiamGia)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_THANHTOAN @IDBILL , @GiamGia", new object[] { idbill , GiamGia });
        }
        public List<Bill> DaThanhToan(DateTime time)//Hàm lấy ra bill đã thanh toán trong ngày để hiển thị lên thống kê
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_BILL_IN_DAY @TIME" , new object[] {time});
            foreach (DataRow row in data.Rows)
            {
                Bill bill = new Bill(row);
                list.Add(bill);
            }
            return list;
        }
        public List<Bill_Info> listBill_info(DateTime time)
        {
            List<Bill_Info> list = new List<Bill_Info>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_BILLINFO_IN_DAY @TIME" , new object[] {time});
            foreach (DataRow item in data.Rows)
            {
                Bill_Info newB = new Bill_Info(item);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Food.Name == newB.Food.Name)
                    {
                        list[i].Amount += newB.Amount;
                        goto loop;
                    }
                }
                list.Add(newB);
            loop:;
            }
            return list;
        }

    }
}
