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
    public class DichVuBaoHanhBus : IDichVuBaoHanhBus
    {
        IBaoHanhRes baohanhres;
        List<DichVuBaoHanh> baohanhbus;
        public DichVuBaoHanhBus()
        {
            baohanhres = new DichVuBaoHanhRes();
            baohanhbus = new List<DichVuBaoHanh>();
            GetDichVuBaoHanhs();
        }
        public string addbaohanh(DichVuBaoHanh dichvubaohanh)
        {
            if (baohanhres.thembaohanh(dichvubaohanh)) 
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string deletebaohanh(DichVuBaoHanh dichvubaohanh)
        {
            if (baohanhres.xoabaohanh(dichvubaohanh))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<DichVuBaoHanh> GetDichVuBaoHanhs()
        {
            baohanhbus = baohanhres.LayDichVuBaoHanhs();
            return baohanhbus;
        }

        public string updatebaohanh(DichVuBaoHanh dichvubaohanh)
        {
            if (baohanhres.suabaohanh(dichvubaohanh))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}