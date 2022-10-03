using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Table_DAL
    {
        private static Table_DAL instance;
        public static Table_DAL Instance
        {
            get { if (instance == null) { instance = new Table_DAL(); } return Table_DAL.instance; }
            private set { Table_DAL.instance = value; }
        }
        public Table_DAL() { }
        public List<Table> ListTable()
        {
            List<Table> list = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood");
            foreach (DataRow dr in data.Rows)
            {
                Table table = new Table(dr);
                list.Add(table);
            }
            return list;
        }
    }
}
