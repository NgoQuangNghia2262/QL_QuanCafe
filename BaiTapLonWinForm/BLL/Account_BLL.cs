using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Account_BLL
    {
        private static Account_BLL instance;
        public static Account_BLL Instance
        {
            get { if (instance == null) { instance = new Account_BLL(); } return Account_BLL.instance; }
            private set { Account_BLL.instance = value; }
        }
        public List<Account> Accounts()
        {
            return Account_DAL.Instance.Accounts();
        }
    }
}
