using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Table_BLL
    {
        private static Table_BLL instance;
        public static Table_BLL Instance
        {
            get { if (instance == null) { instance = new Table_BLL(); } return Table_BLL.instance; }
            private set { Table_BLL.instance = value; }
        }
        public Table_BLL() { }

        public List<Table> LoadTable()
        {
            List<Table> list = Table_DAL.Instance.ListTable();
            return list;
        }
       
    }
}
