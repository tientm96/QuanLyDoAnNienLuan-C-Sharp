
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyDANL.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            DataConfig con = new DataConfig();
            string query = "SELECT * FROM TAIKHOAN WHERE TaiKhoanID = '" + userName + "' AND Pass = '" + passWord + "' ";
            DataTable result = new DataTable();
            result = con.GetData(query);

            return result.Rows.Count > 0;
        }
    }
}
