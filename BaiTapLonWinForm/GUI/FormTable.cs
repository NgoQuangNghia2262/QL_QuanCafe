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
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
            LoadTable();
        }
        public FormTable(int a)
        {
            InitializeComponent();
            LoadTable2();
        }
        
        void LoadTable() // Hàm này load bàn nhưng kh có sự kiện
        {
            List<Table> list = Table_BLL.Instance.LoadTable();
            foreach (Table item in list)
            {
                Button btn = new Button();
                btn.Text = item.Id.ToString();
                btn.Width = 149;
                btn.Height = 110;
                if (item.Status == 1)
                {
                    btn.BackColor = Color.DarkOrange;
                }
                flp.Controls.Add(btn);
            }
        }
        void LoadTable2() // Hàm này tạo danh sách bàn rồi thêm sự kiện click 
        {
            List<Table> list = Table_BLL.Instance.LoadTable();
            foreach (Table item in list)
            {
                Button btn = new Button();
                btn.Text = item.Id.ToString();
                btn.Width = 149;
                btn.Height = 110;
                if (item.Status == 1)
                {
                    btn.BackColor = Color.DarkOrange;
                }
                btn.Click += (object sender2, EventArgs e2) =>
                {
                    this.Hide();
                    FormBill formBill = new FormBill(btn.Text);
                    formBill.ShowDialog();
                };
                flp.Controls.Add(btn);
            }
        }
        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }
        public FlowLayoutPanel Get()
        {
            return flp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormButtonXem form = new FormButtonXem();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormThongKe form = new FormThongKe();
            form.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormButtonCaiDat form = new FormButtonCaiDat();
            form.Show();
            ////this.Close();
        }
    }
}
