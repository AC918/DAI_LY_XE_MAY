using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            DoanhThus = new HashSet<DoanhThu>();
        }

        public Guid MaHoaDon { get; set; }
        public string? TenKh { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? TrangThai { get; set; }
        public Guid? MaKh { get; set; }

        public virtual KhachHang? MaKhNavigation { get; set; }
        public virtual ICollection<DoanhThu> DoanhThus { get; set; }
    }
}
