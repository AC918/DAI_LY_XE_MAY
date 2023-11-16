using BUS_CLASS.ViewModel;
using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyKhachHang
    {
        string addkhachhang(KhachHang khachhang);
        string updatekhachhang(KhachHang khachhang);
        string deletekhachhang(KhachHang khachhang);
        string findkhachhang(KhachHang khachhang);
        List<KhachHang> GetKhachHangs();
        List<ViewKhachHangVoiDVBH> GetViewKhachHangVoiDVBHs();
    }
}