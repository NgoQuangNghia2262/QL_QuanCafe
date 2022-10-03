using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Food_DAL
    {
        private static Food_DAL instance;
        public static Food_DAL Instance
        {
            get { if (instance == null) { instance = new Food_DAL(); } return Food_DAL.instance; }
            private set { Food_DAL.instance = value; }
        }
        public Food_DAL() { }
        public List<Food> ListFood()
        {
            List<Food> list = new List<Food>();
            //Lấy ra danh sách food trong Sql
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM FOOD");
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public void AddCategory(string category)
        {
            DataProvider.Instance.ExecuteNonQuery($"INSERT INTO FOODCATEGORY(NAME) VALUES(N'{category}')");
        }
        public void AddFood(string name , string price , string category)
        {
            DataProvider.Instance.ExecuteNonQuery($"INSERT INTO FOOD(NAME,PRICE,CATEGORY) VALUES(N'{name}',{price},N'{category}')");
        }
        public int UpDateFood(string name, string price, string category)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC USP_UPDATEFOOD @NAMEF , @PRICE , @CATEGORY" , new object[] {name , price , category});
        }
    }
}
