using DAL.IResponsity;
using DAL_CLASS.Context;
using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsity
{
    public class BanHangRes : IBanHangRes
    {
        MotorbikeDealerContext contextbh;
        public BanHangRes()
        {
            contextbh = new MotorbikeDealerContext();
            LayBanHangs();
        }
        public List<BanHang> LayBanHangs()
        {
            return contextbh.BanHangs.ToList();
        }

        public bool timbanhang(BanHang bh)
        {
            contextbh.BanHangs.Find(bh);
            contextbh.SaveChanges();
            return true;
        }
    }
}