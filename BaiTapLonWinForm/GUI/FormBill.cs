using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }
        public FormBill(string idtb)
        {
            InitializeComponent();
            LoadCategory();
            LoadBill(idtb);
        }
        /*Phương thức void LoadCategory() này thực hiện
         * - danh sách Category+sự kiện 
         * - danh sách đồ uống theo từng loại+sự kiện
         * 
         */
        void LoadCategory()
        {
            List<Food> list = Food_BLL.Instance.listfood();
            for (int i = 0; i < list.Count; i++)
            {       
                
                //Tạo 1 Button mới rồi set thuộc tính ( Button loại đồ uống )
                Button btn = new Button();
                btn.Text = list[i].Category;
                //Duyệt Trong danh sách flpCategory nếu đã có button loại này rồi thì di chuyển đến loop
                foreach (Button btnCategory in flpCategory.Controls)
                {
                    if(list[i].Category == btnCategory.Text)
                    {                       
                        goto loop;
                    }
                }
                btn.Width = 143;
                btn.Height = 87;
                //Tạo sự kiện Click cho button ( Click thì hiện ra ds đồ uống theo từng loại )
                btn.Click += (object sender, EventArgs e) =>
                {
                    flpFood.Controls.Clear();//Mỗi lần Click Button loại đồ uống thì Làm mới phần hiển thị
                    foreach (Food item2 in list)
                    {
                        //Duyệt từ đầu đến cuối nếu thỏa mãn điều kiện thì thực hiện tiếp
                        if (item2.Category == btn.Text)
                        {
                            //Tạo Button mới và set thuộc tính( Button Đồ Uống )
                            Button button = new Button();
                            button.Text = item2.Name + "  " + item2.Price;
                            button.Width = 146;
                            button.Height = 87;
                            //Tạo Sự kiện 
                            button.Click += (object sender2, EventArgs e2) =>
                            {
                                int idBill = int.Parse(lbBill.Text);
                                Bill_BLL.Instance.AddBill_Info(idBill, item2.Name);
                                LoadBill(lbTable.Text);
                            };
                            //Thêm vào flp để hiển thị lên
                            flpFood.Controls.Add(button);
                        }
                    }
                };
            
                flpCategory.Controls.Add(btn);
            loop:;
            }
        } 

        void LoadGiaTri(Bill bill)//Phương Thức này hiển thị phần giá trị của bill (giảm giá , giá trị , tổng cộng)
        {
            double num = 0;
            double.TryParse(tbGiamGia.Text, out num);
            tbGiaTri.Text = bill.GiaTri.ToString();
            tbTongTien.Text = (bill.GiaTri * (1 - (num/100.0))).ToString();
        }

        void LoadBill(string idtb)//Hàm này đưa vào id bill rồi load (time vào , id bàn , id bill và danh sách đồ uống của bill)
        {
            flpBill.Controls.Clear();
            
            /*
             * Lấy ra Bill (gồm idbill , id bàn , danh sách món ăn , Thời gian vào)
             */
            Bill bill = Bill_BLL.Instance.LoadBill(idtb);
            LoadGiaTri(bill);
            lbTime.Text = bill.TimeIn.ToString();
            lbTable.Text = bill.IdTable.ToString();
            lbBill.Text = bill.Id.ToString();
            //Tạo button , set thuộc tính , sự kiện rồi thêm vào flpBill
            foreach (Bill_Info item in bill.BillList)
            {
                Button btn = new Button();
                btn.Text = item.Food + "      x" + item.Amount.ToString();
                btn.Width = 205;
                btn.Height = 30;
                btn.BackColor = Color.White;
                //Tạo sự kiện
                btn.Click += (object sender, EventArgs e) =>
                {
                    pnlTitle.Visible = false;//Ẩn pnlTitle đi
                    //đoạn này đổi màu khi click
                    if(btn.BackColor == Color.White)
                    {
                        btn.BackColor = Color.Aqua;
                    }    
                    else
                    {
                        btn.BackColor = Color.White;
                        
                    }

                    int i = 0;
                    foreach (Button bt in flpBill.Controls)
                    {
                        //Nếu có 1 button màu Aqua thì i++
                        if (bt.BackColor == Color.Aqua) { i++; }
                    }
                    //nếu kết thúc vòng lặp mà i vẫn = 0(tức là khống có button nào trạng thái màu xanh) thì pnlTitle hiển thị lên
                    if (i == 0)
                    {
                        pnlTitle.Visible = true;
                    }
                };              
                flpBill.Controls.Add(btn);
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTable formTable = new FormTable();
            FlowLayoutPanel flp = formTable.Get();//Lấy ra các button table (button này được thêm ở Phương Thức LoadTable)
            foreach (Button btn in flp.Controls)
            {
                btn.Click += (object sender2, EventArgs e2) =>//Thiết Lập sự kiện cho tất cả button này
                {
                    DialogResult GopBan = MessageBox.Show("Bạn có chắc là muốn gộp bàn hay không ?", "Gộp Bàn", MessageBoxButtons.OKCancel);
                    if (GopBan == DialogResult.OK)
                    {
                        formTable.Close();
                        Bill_BLL.Instance.GopBill(int.Parse(lbBill.Text) , int.Parse(btn.Text));//Phương thức này thực hiện thay đổi id bill ở Sql
                        FormTable f = new FormTable(1);
                        f.Show();
                    }
                    
                };
            }
            formTable.ShowDialog();
        }


        private void FormBill_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();        
            FormTable f = new FormTable(1);
            f.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            * Lấy ra Bill (gồm idbill , id bàn , danh sách món ăn , Thời gian vào)
            */
            Bill bill = Bill_BLL.Instance.LoadBill(lbTable.Text);
            List<Bill_Info> list = bill.BillList;
            foreach (Button bt in flpBill.Controls)
            {
                if (bt.BackColor == Color.Aqua) // Kiểm tra các button trong flpBill.Controls nếu button nào đang màu Aqua ( đang được chọn ) thì thwucj hiện lệnh bên dưới
                {
                    for (int i = 0; i <list.Count; i++)
                    {
                        if (bt.Text.Contains(list[i].Food.Name))
                        {
                            
                            Bill_BLL.Instance.AddBill_Info(int.Parse(lbBill.Text), list[i].Food.Name);
                            string s2 = bt.Text;
                            int num = int.Parse(s2[s2.Length - 1].ToString());//Lấy ra ký tự cuối rồi ép kiểu int
                            num++;//tăng số đó lên 1 đơn vị
                            string replacement = s2.Replace(s2[s2.Length - 1].ToString(), num.ToString());//rồi thay số cuối thành
                            bt.Text = replacement;
                        }
                        
                    }
                    
                }
               
            }
            

        }//Button + đồ uống (Bug khi số lượng món ăn > 19)

        private void FormBill_Click(object sender, EventArgs e)
        {
             pnlTitle.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bill bill = Bill_BLL.Instance.LoadBill(lbTable.Text);
            List<Bill_Info> list = bill.BillList;
            foreach (Button bt in flpBill.Controls)
            {
                if (bt.BackColor == Color.Aqua)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (bt.Text.Contains(list[i].Food.Name))
                        {

                            Bill_BLL.Instance.SubBill_Info(int.Parse(lbBill.Text), list[i].Food.Name); 
                            string s2 = bt.Text;
                            int num = int.Parse(s2[s2.Length - 1].ToString());
                            num--;
                            string replacement = s2.Replace(s2[s2.Length - 1].ToString(), num.ToString());
                            bt.Text = replacement;
                        }

                    }

                }

            }
        }//Button - đồ uống

        private void flpCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult GopBan = MessageBox.Show("Bạn có chắc là muốn xóa hay không ?", "Xóa", MessageBoxButtons.OKCancel);
            if (GopBan == DialogResult.OK)
            {
                Bill bill = Bill_BLL.Instance.LoadBill(lbTable.Text);
                List<Bill_Info> list = bill.BillList;
                foreach (Button bt in flpBill.Controls)
                {
                    if (bt.BackColor == Color.Aqua)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (bt.Text.Contains(list[i].Food.Name))
                            {

                                Bill_BLL.Instance.DelBill_Info(int.Parse(lbBill.Text), list[i].Food.Name);
                                flpBill.Controls.Remove(bt);
                            }

                        }

                    }

                }
            }
            
        } // Button xóa đồ uống trong bill

        private void button3_Click(object sender, EventArgs e)//Button Thanh Toán
        {
            double num = 0;
            double.TryParse(tbGiamGia.Text, out num);//Ép kiểu cho tb giảm giá
            //Thực hiện chuyển status của bill từ 0 thành 1 và update cột giảm giá thành num
            Bill_BLL.Instance.ThanhToanBill(int.Parse(lbBill.Text) , num);
            this.Hide();
            FormTable form = new FormTable(1);
            form.ShowDialog();
            this.Close();
        }

        private void tbGiamGia_TextChanged(object sender, EventArgs e)
        {
            Bill bill = Bill_BLL.Instance.LoadBill(lbTable.Text);
            LoadGiaTri(bill);
            
        }

        private void tbGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa Làm");
        }
    }
}




