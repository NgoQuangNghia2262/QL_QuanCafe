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
    public partial class FormQuanLy : Form
    {
        class PhanTrang
        {
            public static int take = 3;
            public static int skip = 1;
            public List<Bill> Trang(List<Bill> list)
            {
                if (PhanTrang.skip < 1)
                {
                    PhanTrang.skip = 1;
                }
                else if (PhanTrang.skip > list.Count / PhanTrang.take)
                {
                    PhanTrang.skip = list.Count / PhanTrang.take + 1;
                }
                list = list.Skip((skip-1)*take).Take(take).ToList();
                return list;
            }

        }
        public FormQuanLy()
        {
            InitializeComponent();
            LoadThongKe();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            PhanTrang.skip ++;
            LoadThongKe();
        }
        void LoadThongKe()
        {
            List<Bill> list = new List<Bill>();
            list = Bill_BLL.Instance.DaThanhToan(new DateTime(1800, 1, 1));
            PhanTrang phanTrang = new PhanTrang();         
            list = phanTrang.Trang(list);
            dgvThongKe.DataSource = list;
            tbTrang.Text = PhanTrang.skip.ToString();
            
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
                PhanTrang.skip--;
                LoadThongKe();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
