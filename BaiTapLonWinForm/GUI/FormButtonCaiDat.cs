using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormButtonCaiDat : Form
    {
        public FormButtonCaiDat()
        {
            InitializeComponent();
            LoadThongKe(1);
            LoadMonAn();
            LoadTable(1);
            LoadAccount(1);
        }
        class PhanTrang<T>
        {
            public int take { get; set; }
            public int skip { get; set; }

            public PhanTrang()
            {
                take = 3;
                skip = 1;
            }

            public PhanTrang(int take, int skip)
            {
                this.take = take;
                this.skip = skip;
            }

            public List<T> Trang(List<T> list)
            {
                if (skip < 1)
                {
                    skip = 1;
                }
                else if (skip > list.Count / take)
                {
                    skip = list.Count / take + 1;
                }
                list = list.Skip((skip - 1) * take).Take(take).ToList();
                return list;
            }

        }
        void LoadThongKe(int sotrang , string time = null)
        {
            List<Bill> list = new List<Bill>();
            if (time == null) { list = Bill_BLL.Instance.DaThanhToan(new DateTime(1800, 1, 1)); }
            else { list = Bill_BLL.Instance.DaThanhToan(DateTime.Parse(time)); };
            PhanTrang<Bill> phanTrang = new PhanTrang<Bill>(3,sotrang);
            list = phanTrang.Trang(list);
            dgvThongKe.DataSource = list;
            tbTrang.Text = phanTrang.skip.ToString();

        }
        void LoadMonAn()
        {
            List<Food> list = Food_BLL.Instance.listfood();
            dgvMonAn.DataSource = list;
            foreach (Food item in list)
            {
                
                for (int i = 0; i < ccbCategory.Items.Count; i++)
                {
                    
                    if (ccbCategory.Items[i].ToString() == item.Category)
                    {
                        goto loop;
                    }
                }
                ccbCategory.Items.Add(item.Category);
            loop:;
            }
        }

        void LoadTable(int soTrang)
        {
            List<Table> list = Table_BLL.Instance.LoadTable();                        
            int i = 0;
            foreach (DataGridView item in flpDSTable.Controls)
            {
                PhanTrang<Table> phanTrang = new PhanTrang<Table>(5, soTrang + i);
                List<Table> trang = phanTrang.Trang(list);
                item.DataSource = trang;
                i++;
            }
            tbTrangTable.Text = soTrang.ToString();
            
        }
        void LoadAccount(int sotrang)
        {
            List<Account> list = Account_BLL.Instance.Accounts();
            dgvAccount.DataSource = list;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tbTrang.Text) - 1;
            LoadThongKe(i);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tbTrang.Text) + 1;
            LoadThongKe(i);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //PhanTrang.skip = 1;
            //LoadThongKe(dtpDau.Text);// Kh đebug dc chỗ này nó bị đứng máy

        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbName.Text = dgvMonAn.Rows[i].Cells[1].Value.ToString();
            tbPrice.Text = dgvMonAn.Rows[i].Cells[2].Value.ToString();
            ccbCategory.Text = dgvMonAn.Rows[i].Cells[0].Value.ToString();
            Console.WriteLine();
        }//--------------------------

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTable newf = new FormTable(1);
            newf.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTable newf = new FormTable(1);
            newf.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Food_BLL.Instance.AddCategory(ccbCategory.Text);
            MessageBox.Show("Thêm Thành Công");
            LoadMonAn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Food_BLL.Instance.AddFood(tbName.Text , tbPrice.Text , ccbCategory.Text);
            MessageBox.Show("Thêm Thành Công");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn Có chắc muốn sửa hay không" , "sửa" , MessageBoxButtons.OKCancel);
            if(dialog == DialogResult.OK)
            {

                    int i = Food_BLL.Instance.UpDateFood(tbName.Text, tbPrice.Text, ccbCategory.Text);
                    if(i == 0)
                    {
                        MessageBox.Show("Không Được Sửa Tên Đồ Uống");
                    }
                    else { MessageBox.Show("Sửa thành Công"); LoadMonAn(); }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tbTrangTable.Text) - 4;
            int trang = int.Parse(tbTrangTable.Text) - 1;
            LoadTable(i);
            tbTrangTable.Text = trang.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tbTrangTable.Text) + 4;
            int trang = int.Parse(tbTrangTable.Text) + 1;
            LoadTable(i);
            tbTrangTable.Text = trang.ToString();
        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
