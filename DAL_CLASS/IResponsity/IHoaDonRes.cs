using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IHoaDonRes
    {
        bool themhoadon(HoaDon hd);
        bool suahoadon(HoaDon hd);
        bool timhoadon(HoaDon hd);
        List<HoaDon> LayHoaDons();
    }
}