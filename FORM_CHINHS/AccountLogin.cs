using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORM_CHINHS
{
    public class AccountLogin
    {
        private string tenTaiKhoan;
        private string matKhau;
        private bool loaiTaiKhoan;
        public AccountLogin()
        {
            
        }

        public AccountLogin(string tenTaiKhoan, string matKhau, bool loaiTaiKhoan)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
    }
}