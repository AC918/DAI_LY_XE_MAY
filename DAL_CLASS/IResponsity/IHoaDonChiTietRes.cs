using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IHoaDonChiTietRes
    {
        bool themhoadonchitiet(HoaDonChiTiet hdct);
        bool suahoadonchitiet(HoaDonChiTiet hdct);
        bool timhoadonchitiet(HoaDonChiTiet hdct);
        List<HoaDonChiTiet> LayHoaDonChiTiets();
    }
}