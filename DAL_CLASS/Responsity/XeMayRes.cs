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
    public class XeMayRes : IXeMayRes
    {
        MotorbikeDealerContext contextxe;
        public XeMayRes()
        {
            contextxe = new MotorbikeDealerContext();
            LayXeMays();
        }
        public List<XeMay> LayXeMays()
        {
            return contextxe.XeMays.ToList();
        }

        public bool suaxemay(XeMay xm)
        {
            contextxe.XeMays.Update(xm);
            contextxe.SaveChanges();
            return true;
        }

        public bool themxemay(XeMay xm)
        {
            contextxe.XeMays.Add(xm);
            contextxe.SaveChanges();
            return true;
        }

        public bool timxemay(XeMay xm)
        {
            contextxe.XeMays.Find(xm);
            contextxe.SaveChanges();
            return true;
        }

        public bool xoaxemay(XeMay xm)
        {
            contextxe.XeMays.Remove(xm);
            contextxe.SaveChanges();
            return true;
        }
    }
}