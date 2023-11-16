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
    public class DoanhThuRes : IDoanhThuRes
    {
        MotorbikeDealerContext contextdt;
        public DoanhThuRes()
        {
            contextdt = new MotorbikeDealerContext();
            LayDoanhThus();
        }
        public List<DoanhThu> LayDoanhThus()
        {
            return contextdt.DoanhThus.ToList();
        }

        public bool timdoanhthu(DoanhThu dt)
        {
            contextdt.DoanhThus.Find(dt); 
            contextdt.SaveChanges();
            return true;
        }
    }
}