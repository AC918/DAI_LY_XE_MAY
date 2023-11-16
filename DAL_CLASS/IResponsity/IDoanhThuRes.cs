using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IDoanhThuRes
    {
        bool timdoanhthu(DoanhThu dt);
        List<DoanhThu> LayDoanhThus();
    }
}