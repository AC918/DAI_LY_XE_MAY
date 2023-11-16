using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public int Id { get; set; }
        public string? TenTaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public string? VaiTro { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
