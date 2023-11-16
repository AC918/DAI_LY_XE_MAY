using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyXeMay
    {
        string addxemay(XeMay xemay);
        string updatexemay(XeMay xemay);
        string deletexemay(XeMay xemay);
        string findxemay(XeMay xemay);
        List<XeMay> GetXeMays();
    }
}