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
    public class QuanLyBanHang : IQuanLyBanHang
    {
        IBanHangRes banhangres;
        List<BanHang> banhangbus;
        public QuanLyBanHang()
        {
            banhangres = new BanHangRes();
            banhangbus = new List<BanHang>();
            GetBanHangs();
        }
        public string findbanhang(BanHang banhang)
        {
            if (banhangres.timbanhang(banhang))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<BanHang> GetBanHangs()
        {
            banhangbus = banhangres.LayBanHangs();
            return banhangbus;
        }
    }
}