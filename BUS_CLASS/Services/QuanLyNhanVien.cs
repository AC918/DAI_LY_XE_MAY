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
    public class QuanLyNhanVien : IQuanLyNhanVien
    {
        INhanVienRes nhanvienres;
        List<NhanVien> nhanvienbus;
        public QuanLyNhanVien()
        {
            nhanvienres = new NhanVienRes();
            nhanvienbus = new List<NhanVien>();
            GetNhanViens();
        }
        public string addnhanvien(NhanVien nhanvien)
        {
            if (nhanvienres.themnhanvien(nhanvien))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string deletenhanvien(NhanVien nhanvien)
        {
            if (nhanvienres.xoanhanvien(nhanvien))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string findnhanvien(NhanVien nhanvien)
        {
            if (nhanvienres.timnhanvien(nhanvien))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<NhanVien> GetNhanViens()
        {
            nhanvienbus = nhanvienres.LayNhanViens();
            return nhanvienbus;
        }

        public string updatenhanvien(NhanVien nhanvien)
        {
            if (nhanvienres.suanhanvien(nhanvien))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}