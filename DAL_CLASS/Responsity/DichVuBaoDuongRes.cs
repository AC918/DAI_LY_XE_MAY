using DAL.IResponsity;
using DAL_CLASS.Context;
using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Responsity
{
    public class DichVuBaoDuongRes : IBaoDuongRes
    {
        MotorbikeDealerContext contextbd;
        public DichVuBaoDuongRes()
        {
            contextbd = new MotorbikeDealerContext();
            LayDichVuBaoDuongs();
        }
        public List<DichVuBaoDuong> LayDichVuBaoDuongs()
        {
            return contextbd.DichVuBaoDuongs.ToList();
        }

        public bool suabaoduong(DichVuBaoDuong dvbd)
        {
            contextbd.DichVuBaoDuongs.Update(dvbd);
            contextbd.SaveChanges();
            return true;
        }

        public bool thembaoduong(DichVuBaoDuong dvbd)
        {
            contextbd.DichVuBaoDuongs.Add(dvbd);
            contextbd.SaveChanges();
            return true;
        }

        public bool xoabaoduong(DichVuBaoDuong dvbd)
        {
            contextbd.DichVuBaoDuongs.Remove(dvbd);
            contextbd.SaveChanges();
            return true;
        }
    }
}