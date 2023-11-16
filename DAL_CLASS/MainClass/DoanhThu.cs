using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class DoanhThu
    {
        public int Stt { get; set; }
        public int? SoHoaDon { get; set; }
        public DateTime? NgayBan { get; set; }
        public int? SoLuongBan { get; set; }
        public bool? TrangThaiDt { get; set; }
        public decimal? TongDoanhThu { get; set; }
        public Guid? MaHd { get; set; }
        public Guid? MaXmtk { get; set; }

        public virtual HoaDon? MaHdNavigation { get; set; }
        public virtual XeMay? MaXmtkNavigation { get; set; }
    }
}
