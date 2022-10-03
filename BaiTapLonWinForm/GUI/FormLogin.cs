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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            List<Account> list = Account_BLL.Instance.Accounts();//Lấy danh sách acc từ Sql
            foreach (Account account in list)
            {
                if(tbName.Text.Trim() == account.Username.Trim())
                {
                    if(tbPass.Text.Trim() == account.Password.Trim())//Kiểm tra tk , mk nếu đúng thì đi tiếp
                    {
                        this.Hide();
                        FormTable formTable = new FormTable(1);
                        if (account.Category != "admin")
                        {
                            formTable.btAdmin.Visible = false;
                        }
                        formTable.ShowDialog();
                        this.Close();
                         
                    }
                    else { MessageBox.Show("PassWord Sai"); }
                }
            }
            MessageBox.Show("Tên Tài Khoản Không Tồn Tại");
            
            
        } // Button logIn

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
