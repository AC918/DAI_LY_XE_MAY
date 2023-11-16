using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyBanHang
    {
        string findbanhang(BanHang banhang);
        List<BanHang> GetBanHangs();
    }
}