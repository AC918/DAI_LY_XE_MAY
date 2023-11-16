using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface INhanVienRes
    {
        bool themnhanvien(NhanVien nv);
        bool suanhanvien(NhanVien nv);
        bool xoanhanvien(NhanVien nv);
        bool timnhanvien(NhanVien nv);
        List<NhanVien> LayNhanViens();
    }
}