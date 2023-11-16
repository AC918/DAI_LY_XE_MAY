using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class XeMay
    {
        public XeMay()
        {
            BanHangs = new HashSet<BanHang>();
            DichVuBaoHanhs = new HashSet<DichVuBaoHanh>();
            DoanhThus = new HashSet<DoanhThu>();
        }

        public Guid MaXe { get; set; }
        public string? TenXe { get; set; }
        public string? MauXe { get; set; }
        public string? LoaiXe { get; set; }
        public decimal? GiaXe { get; set; }
        public string? ThongSo { get; set; }

        public virtual ICollection<BanHang> BanHangs { get; set; }
        public virtual ICollection<DichVuBaoHanh> DichVuBaoHanhs { get; set; }
        public virtual ICollection<DoanhThu> DoanhThus { get; set; }
    }
}
