using System;
using System.Collections.Generic;

namespace DAL_CLASS.MainClass
{
    public partial class NhanVien
    {
        public Guid MaNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public string? GioiTinhNv { get; set; }
        public string? SdtnhanVien { get; set; }
        public string? EmailNhanVien { get; set; }
        public string? DiaChiNhanVien { get; set; }
        public int? Sttdn { get; set; }

        public virtual TaiKhoan? SttdnNavigation { get; set; }
    }
}
