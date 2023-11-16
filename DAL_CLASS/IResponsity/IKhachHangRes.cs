using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IKhachHangRes
    {
        bool themkhachhang(KhachHang kh);
        bool suakhachhang(KhachHang kh);
        bool xoakhachhang(KhachHang kh);
        bool timkhachhang(KhachHang kh);
        List<KhachHang> LayKhachHangs();
    }
}