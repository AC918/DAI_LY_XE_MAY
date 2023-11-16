using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class HoaDonChiTiet
    {
        public Guid? MaXeCt { get; set; }
        public Guid? TenXeCt { get; set; }
        public decimal? Gia { get; set; }
        public int? SoLuong { get; set; }
        public decimal? TongGia { get; set; }
        public Guid? MaXm { get; set; }

        public virtual XeMay? MaXmNavigation { get; set; }
    }
}
