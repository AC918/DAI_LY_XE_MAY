using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyHoaDon
    {
        string addhoadon(HoaDon hoadon);
        string updatehoadon(HoaDon hoadon);
        string findhoadon(HoaDon hoadon);
        List<HoaDon> GetHoaDons();
    }
}