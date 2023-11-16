using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyHoaDonChiTiet
    {
        string addhoadonchititiet(HoaDonChiTiet hoadonchitiet);
        string updatehoadonchititiet(HoaDonChiTiet hoadonchitiet);
        string findhoadonchititiet(HoaDonChiTiet hoadonchitiet);
        List<HoaDonChiTiet> GetHoaDonChiTiets();
    }
}