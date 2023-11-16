using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DichVuBaoDuongs = new HashSet<DichVuBaoDuong>();
            DichVuBaoHanhs = new HashSet<DichVuBaoHanh>();
            HoaDons = new HashSet<HoaDon>();
        }

        public Guid MaKhachHang { get; set; }
        public string? TenKhachHang { get; set; }
        public string? GioiTinhKh { get; set; }
        public string? SdtkhachHang { get; set; }
        public string? DiaChiKhachHang { get; set; }
        public string? TenDichVuDung { get; set; }

        public virtual ICollection<DichVuBaoDuong> DichVuBaoDuongs { get; set; }
        public virtual ICollection<DichVuBaoHanh> DichVuBaoHanhs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
