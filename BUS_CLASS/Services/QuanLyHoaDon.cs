using BUS.IServices;
using DAL.IResponsity;
using DAL.Responsity;
using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QuanLyHoaDon : IQuanLyHoaDon
    {
        IHoaDonRes hoadonres;
        List<HoaDon> hoadonbus;
        public QuanLyHoaDon()
        {
            hoadonres = new HoaDonRes();
            hoadonbus = new List<HoaDon>();
            GetHoaDons();
        }
        public string addhoadon(HoaDon hoadon)
        {
            if (hoadonres.themhoadon(hoadon))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string findhoadon(HoaDon hoadon)
        {
            if (hoadonres.timhoadon(hoadon))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<HoaDon> GetHoaDons()
        {
            hoadonbus = hoadonres.LayHoaDons();
            return hoadonbus;
        }

        public string updatehoadon(HoaDon hoadon)
        {
            if (hoadonres.suahoadon(hoadon))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}