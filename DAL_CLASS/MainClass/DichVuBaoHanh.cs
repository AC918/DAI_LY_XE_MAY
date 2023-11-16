using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class DichVuBaoHanh
    {
        public Guid MaBaoHanh { get; set; }
        public string? TenBaoHanh { get; set; }
        public DateTime? ThoiGianBan { get; set; }
        public DateTime? HanBaoHanh { get; set; }
        public string? TenXeBaoHanh { get; set; }
        public string? TenKhbaoHanh { get; set; }
        public Guid? MaXmbh { get; set; }
        public Guid? MaKhbh { get; set; }

        public virtual KhachHang? MaKhbhNavigation { get; set; }
        public virtual XeMay? MaXmbhNavigation { get; set; }
    }
}
