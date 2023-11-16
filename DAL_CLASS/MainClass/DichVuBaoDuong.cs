using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class DichVuBaoDuong
    {
        public Guid MaBaoDuong { get; set; }
        public string? TenKhbaoDuong { get; set; }
        public string? SdtkhbaoDuong { get; set; }
        public DateTime? ThoiGianBaoDuong { get; set; }
        public Guid? MaKhbd { get; set; }

        public virtual KhachHang? MaKhbdNavigation { get; set; }
    }
}
