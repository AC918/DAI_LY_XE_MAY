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
    public class QuanLyXeMay : IQuanLyXeMay
    {
        IXeMayRes xemayres;
        List<XeMay> xemaybus;
        public QuanLyXeMay()
        {
            xemayres = new XeMayRes();
            xemaybus = new List<XeMay>();
            GetXeMays();
        }
        public string addxemay(XeMay xemay)
        {
            if (xemayres.themxemay(xemay))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string deletexemay(XeMay xemay)
        {
            if (xemayres.xoaxemay(xemay))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string findxemay(XeMay xemay)
        {
            if (xemayres.timxemay(xemay))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<XeMay> GetXeMays()
        {
            xemaybus = xemayres.LayXeMays();
            return xemaybus;
        }

        public string updatexemay(XeMay xemay)
        {
            if (xemayres.suaxemay(xemay))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}