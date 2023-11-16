using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IBaoHanhRes
    {
        bool thembaohanh(DichVuBaoHanh dvbh);
        bool suabaohanh(DichVuBaoHanh dvbh);
        bool xoabaohanh(DichVuBaoHanh dvbh);
        List<DichVuBaoHanh> LayDichVuBaoHanhs();
    }
}