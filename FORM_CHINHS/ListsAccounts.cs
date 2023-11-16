using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORM_CHINHS
{
    public class ListsAccounts
    {
        private static ListsAccounts instance;
        internal static ListsAccounts Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListsAccounts();
                return instance;
            }
            set => instance = value;
        }
        List<AccountLogin> listTaiKhoan;
        public List<AccountLogin> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }
        public ListsAccounts()
        {
            listTaiKhoan = new List<AccountLogin>()
            {
                new AccountLogin("quanly","quanly",true),
                new AccountLogin("nhanvien","nhanvien",false),
            };
        }
    }
}