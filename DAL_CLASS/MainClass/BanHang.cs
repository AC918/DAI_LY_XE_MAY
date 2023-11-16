using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class BanHang
    {
        public int Stt { get; set; }
        public string? TenXeBan { get; set; }
        public decimal? DonGia { get; set; }
        public string? MauXeBan { get; set; }
        public string? LoaiXeBan { get; set; }
        public int? SoLuongBan { get; set; }
        public Guid? MaXmb { get; set; }

        public virtual XeMay? MaXmbNavigation { get; set; }
    }
}
