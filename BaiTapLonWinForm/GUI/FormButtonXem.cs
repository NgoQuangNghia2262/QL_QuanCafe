using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class FormButtonXem : Form
    {
        public FormButtonXem()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadForm()//Hàm này có sự kiện click na ná LoadTable nhưng chỉ hiển thị các bàn Color.DarkOrange (Bàn có khách) 
        {
            FormTable formTable = new FormTable();
            FlowLayoutPanel flp = formTable.Get();
            foreach (Button item in flp.Controls)
            {
               if(item.BackColor == Color.DarkOrange)
                {
                    Bill bill = Bill_BLL.Instance.LoadBill(item.Text);
                    Button button = new Button();
                    button.Height = 90;
                    button.Width = 120;
                    button.BackColor = item.BackColor;
                    button.Text = item.Text + "         " + bill.GiaTri;
                    button.Click += (object sender, EventArgs e) =>
                    {
                        this.Close();
                        FormBill formBill = new FormBill(item.Text);
                        formBill.ShowDialog();
                    };
                    flpButtonXem.Controls.Add(button);
                }
               
            }
        }

        private void FormButtonXem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTable frmTable = new FormTable();
            frmTable.ShowDialog();
            this.Close();
        }
    }
}
