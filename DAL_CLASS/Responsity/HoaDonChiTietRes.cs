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
    public class HoaDonChiTietRes : IHoaDonChiTietRes
    {
        MotorbikeDealerContext contexthdct;
        public HoaDonChiTietRes()
        {
            contexthdct = new MotorbikeDealerContext();
            LayHoaDonChiTiets();
        }
        public List<HoaDonChiTiet> LayHoaDonChiTiets()
        {
            return contexthdct.HoaDonChiTiets.ToList();
        }

        public bool suahoadonchitiet(HoaDonChiTiet hdct)
        {
            contexthdct.HoaDonChiTiets.Update(hdct);
            contexthdct.SaveChanges();
            return true;
        }

        public bool themhoadonchitiet(HoaDonChiTiet hdct)
        {
            contexthdct.HoaDonChiTiets.Add(hdct);
            contexthdct.SaveChanges();
            return true;
        }

        public bool timhoadonchitiet(HoaDonChiTiet hdct)
        {
            contexthdct.HoaDonChiTiets.Find(hdct);
            contexthdct.SaveChanges();
            return true;
        }
    }
}