using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Food
    {
        private string _category;
        private string _name;
        private double _price;

        public Food(string category, string name, double price)
        {
            Category = category;
            Name = name;
            Price = price;
        }
        public Food(DataRow row)
        {
            this._name = row["NAME"].ToString();
            this._category =row["CATEGORY"].ToString();
            this._price =  double.Parse(row["PRICE"].ToString());
        }

        public string Category { get => _category; set => _category = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public override string ToString()
        {
            return $"{Name}     {Price}";

        }
    }
}
