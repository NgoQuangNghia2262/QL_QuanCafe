using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Account_DAL
    {
        private static Account_DAL instance;
        public static Account_DAL Instance
        {
            get { if (instance == null) { instance = new Account_DAL(); } return Account_DAL.instance; }
            private set { Account_DAL.instance = value; }
        }
        public List<Account> Accounts()
        {
            List<Account> accounts = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT");
            foreach (DataRow item in data.Rows)
            {
                accounts.Add(new Account(item));
            }
            return accounts;
        }
    }
}
