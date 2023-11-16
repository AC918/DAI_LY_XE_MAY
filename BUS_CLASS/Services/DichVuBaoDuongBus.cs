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
    public class DichVuBaoDuongBus : IDichVuBaoDuongBus
    {
        IBaoDuongRes baoduongres;
        List<DichVuBaoDuong> baoduongbus;
        public DichVuBaoDuongBus()
        {
            baoduongres = new DichVuBaoDuongRes();
            baoduongbus = new List<DichVuBaoDuong>();
            GetDichVuBaoDuongs();
        }
        public string addbaoduong(DichVuBaoDuong dichvubaoduong)
        {
            if (baoduongres.thembaoduong(dichvubaoduong))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public string deletebaoduong(DichVuBaoDuong dichvubaoduong)
        {
            if (baoduongres.xoabaoduong(dichvubaoduong))
            {
                return "thanh cong";
            }
            return "thu lai";
        }

        public List<DichVuBaoDuong> GetDichVuBaoDuongs()
        {
            baoduongbus = baoduongres.LayDichVuBaoDuongs();
            return baoduongbus;
        }

        public string updatebaoduong(DichVuBaoDuong dichvubaoduong)
        {
            if (baoduongres.suabaoduong(dichvubaoduong))
            {
                return "thanh cong";
            }
            return "thu lai";
        }
    }
}