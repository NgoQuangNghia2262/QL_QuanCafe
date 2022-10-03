using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Food_BLL
    {
        private static Food_BLL instance;
        public static Food_BLL Instance
        {
            get { if (instance == null) { instance = new Food_BLL(); } return Food_BLL.instance; }
            private set { Food_BLL.instance = value; }
        }
        public Food_BLL() { }
        public void LoadCategory(FlowLayoutPanel flp , FlowLayoutPanel flpFood)
        {
            //Lấy ra ds Food rồi lưu vào list
            List<Food> list = Food_DAL.Instance.ListFood();
            //Duyệt từ đầu đến cuối ds
            
            
        }
        public List<Food> listfood()
        {
            List<Food> list = Food_DAL.Instance.ListFood();
            return list;
        }
        public void AddCategory(string category)
        {
            Food_DAL.Instance.AddCategory(category);
        }
        public void AddFood(string name, string price, string category)
        {
            Food_DAL.Instance.AddFood(name,price,category);
        }
        public int UpDateFood(string name, string price, string category)
        {
            return Food_DAL.Instance.UpDateFood(name , price , category);
        }
    }
}
