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
    public class HoaDonRes : IHoaDonRes
    {
        MotorbikeDealerContext contexthd;
        public HoaDonRes()
        {
            contexthd = new MotorbikeDealerContext();
            LayHoaDons();
        }
        public List<HoaDon> LayHoaDons()
        {
            return contexthd.HoaDons.ToList();
        }

        public bool suahoadon(HoaDon hd)
        {
            contexthd.HoaDons.Update(hd);
            contexthd.SaveChanges();
            return true;
        }

        public bool themhoadon(HoaDon hd)
        {
            contexthd.HoaDons.Add(hd);
            contexthd.SaveChanges();
            return true;
        }

        public bool timhoadon(HoaDon hd)
        {
            contexthd.HoaDons.Find(hd);
            contexthd.SaveChanges();
            return true;
        }
    }
}