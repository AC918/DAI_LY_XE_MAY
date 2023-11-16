using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IBanHangRes
    {
        bool timbanhang(BanHang bh);
        List<BanHang> LayBanHangs();
    }
}