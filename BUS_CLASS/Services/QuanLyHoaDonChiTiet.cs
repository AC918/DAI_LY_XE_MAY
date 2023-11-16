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
    public class QuanLyHoaDonChiTiet : IQuanLyHoaDonChiTiet
    {
        IHoaDonChiTietRes hoadonchitietres;
        List<HoaDonChiTiet> hoadonchitietbus;
        public QuanLyHoaDonChiTiet()
        {
            hoadonchitietres = new HoaDonChiTietRes();
            hoadonchitietbus = new List<HoaDonChiTiet>();
            GetHoaDonChiTiets();
        }
        public string addhoadonchititiet(HoaDonChiTiet hoadonchitiet)
        {
            if (hoadonchitietres.themhoadonchitiet(hoadonchitiet))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string findhoadonchititiet(HoaDonChiTiet hoadonchitiet)
        {
            if (hoadonchitietres.timhoadonchitiet(hoadonchitiet))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiets()
        {
            hoadonchitietbus = hoadonchitietres.LayHoaDonChiTiets();
            return hoadonchitietbus;
        }

        public string updatehoadonchititiet(HoaDonChiTiet hoadonchitiet)
        {
            if (hoadonchitietres.suahoadonchitiet(hoadonchitiet))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}