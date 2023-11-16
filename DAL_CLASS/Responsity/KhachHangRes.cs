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
    public class KhachHangRes : IKhachHangRes
    {
        MotorbikeDealerContext contextkh;
        public KhachHangRes()
        {
            contextkh = new MotorbikeDealerContext();
            LayKhachHangs();
        }
        public List<KhachHang> LayKhachHangs()
        {
            return contextkh.KhachHangs.ToList();
        }

        public bool suakhachhang(KhachHang kh)
        {
            contextkh.KhachHangs.Update(kh);
            contextkh.SaveChanges();
            return true;
        }

        public bool themkhachhang(KhachHang kh)
        {
            contextkh.KhachHangs.Add(kh);
            contextkh.SaveChanges();
            return true;
        }

        public bool timkhachhang(KhachHang kh)
        {
            contextkh.KhachHangs.Find(kh);
            contextkh.SaveChanges();
            return true;
        }

        public bool xoakhachhang(KhachHang kh)
        {
            contextkh.KhachHangs.Remove(kh);
            contextkh.SaveChanges();
            return true;
        }
    }
}