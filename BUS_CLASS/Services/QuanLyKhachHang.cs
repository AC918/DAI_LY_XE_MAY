using BUS.IServices;
using BUS_CLASS.ViewModel;
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
    public class QuanLyKhachHang : IQuanLyKhachHang
    {
        IKhachHangRes khachhangres;
        IDichVuBaoHanhBus bhbus;
        List<KhachHang> khachhangbus;
        List<ViewKhachHangVoiDVBH> hienthi;
        public QuanLyKhachHang()
        {
            khachhangres = new KhachHangRes();
            bhbus = new DichVuBaoHanhBus();
            khachhangbus = new List<KhachHang>();
            hienthi = new List<ViewKhachHangVoiDVBH>();
            GetKhachHangs();
        }
        public string addkhachhang(KhachHang khachhang)
        {
            if (khachhangres.themkhachhang(khachhang))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string deletekhachhang(KhachHang khachhang)
        {
            if (khachhangres.xoakhachhang(khachhang))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string findkhachhang(KhachHang khachhang)
        {
            if (khachhangres.timkhachhang(khachhang))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<KhachHang> GetKhachHangs()
        {
            khachhangbus = khachhangres.LayKhachHangs();
            return khachhangbus;
        }

        public List<ViewKhachHangVoiDVBH> GetViewKhachHangVoiDVBHs()
        {
            hienthi = (from a in GetKhachHangs()
                       join b in bhbus.GetDichVuBaoHanhs()
                       on a.MaKhachHang equals b.MaKhbh
                       select new ViewKhachHangVoiDVBH { kh = a,dvbh = b}).ToList();
            return hienthi;
        }

        public string updatekhachhang(KhachHang khachhang)
        {
            if (khachhangres.suakhachhang(khachhang))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}