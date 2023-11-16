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
    public class ThongKeDoanhThu : IThongKeDoanhThu
    {
        IDoanhThuRes doanhthures;
        List<DoanhThu> doanhthubus;
        public ThongKeDoanhThu()
        {
            doanhthures = new DoanhThuRes();
            doanhthubus= new List<DoanhThu>();
            GetDoanhThus();
        }
        public string finddoanhthu(DoanhThu doanhthu)
        {
            if (doanhthures.timdoanhthu(doanhthu))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<DoanhThu> GetDoanhThus()
        {
            doanhthubus = doanhthures.LayDoanhThus();
            return doanhthubus;
        }
    }
}