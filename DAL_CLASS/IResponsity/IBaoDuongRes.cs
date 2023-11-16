using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IBaoDuongRes
    {
        bool thembaoduong(DichVuBaoDuong dvbd);
        bool suabaoduong(DichVuBaoDuong dvbd);
        bool xoabaoduong(DichVuBaoDuong dvbd);
        List<DichVuBaoDuong> LayDichVuBaoDuongs();
    }
}