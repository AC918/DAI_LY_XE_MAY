using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponsity
{
    public interface IXeMayRes
    {
        bool themxemay(XeMay xm);
        bool suaxemay(XeMay xm);
        bool xoaxemay(XeMay xm);
        bool timxemay(XeMay xm);
        List<XeMay> LayXeMays();
    }
}