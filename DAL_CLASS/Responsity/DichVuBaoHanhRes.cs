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
    public class DichVuBaoHanhRes : IBaoHanhRes
    {
        MotorbikeDealerContext contextbhres;
        public DichVuBaoHanhRes()
        {
            contextbhres = new MotorbikeDealerContext();
            LayDichVuBaoHanhs();
        }
        public List<DichVuBaoHanh> LayDichVuBaoHanhs()
        {
            return contextbhres.DichVuBaoHanhs.ToList();
        }

        public bool suabaohanh(DichVuBaoHanh dvbh)
        {
            contextbhres.DichVuBaoHanhs.Update(dvbh);
            contextbhres.SaveChanges();
            return true;
        }

        public bool thembaohanh(DichVuBaoHanh dvbh)
        {
            contextbhres.DichVuBaoHanhs.Add(dvbh);
            contextbhres.SaveChanges();
            return true;
        }

        public bool xoabaohanh(DichVuBaoHanh dvbh)
        {
            contextbhres.DichVuBaoHanhs.Remove(dvbh);
            contextbhres.SaveChanges();
            return true;
        }
    }
}