using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyNhanVien
    {
        string addnhanvien(NhanVien nhanvien);
        string updatenhanvien(NhanVien nhanvien);
        string deletenhanvien(NhanVien nhanvien);
        string findnhanvien(NhanVien nhanvien);
        List<NhanVien> GetNhanViens();
    }
}