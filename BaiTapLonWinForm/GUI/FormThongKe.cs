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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            LoadThongKe();
        }
        void LoadThongKe()
        {
            DateTime time = DateTime.Now;
            List<Bill> list = Bill_BLL.Instance.DaThanhToan(new DateTime(time.Year, time.Month, time.Day));
            foreach (Bill item in list)
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 80;
                btn.Text = "Bàn" + item.IdTable + " :  " + item.GiaTri;
                btn.Click += (object sender, EventArgs e) =>
                {
                    lbTable.Text = item.IdTable.ToString();
                    lbBill.Text = item.Id.ToString();
                    lbTime.Text = item.TimeIn.ToString();
                    lbTimeOut.Text = item.TimeOut.ToString();
                    dgvBill.DataSource = item.BillList;
                };
                flpThongKe.Controls.Add(btn);
            }
        }
        private void flpThongKe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//Button Đóng
        {
            Hide();
            FormTable formTable = new FormTable(1);
            formTable.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormButtonCaiDat formTable = new FormButtonCaiDat();
            formTable.ShowDialog();
            Close();
        } //Button Chi Tiết

        private void button2_Click(object sender, EventArgs e)
        {
            flpThongKe.Controls.Clear();
            DateTime time = DateTime.Now;
            List<Bill_Info> list = Bill_BLL.Instance.listBill_info(new DateTime(time.Year, time.Month, time.Day));
            foreach (Bill_Info item in list)
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 80;
                btn.Text = item.Food.Name + "     " + item.Amount;
                flpThongKe.Controls.Add(btn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }
}
