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
    public class NhanVienRes : INhanVienRes
    {
        MotorbikeDealerContext contextnv;
        public NhanVienRes()
        {
            contextnv = new MotorbikeDealerContext();
            LayNhanViens();
        }
        public List<NhanVien> LayNhanViens()
        {
            return contextnv.NhanViens.ToList();
        }

        public bool suanhanvien(NhanVien nv)
        {
            contextnv.NhanViens.Update(nv);
            contextnv.SaveChanges();
            return true;
        }

        public bool themnhanvien(NhanVien nv)
        {
            contextnv.NhanViens.Add(nv);
            contextnv.SaveChanges();
            return true;
        }

        public bool timnhanvien(NhanVien nv)
        {
            contextnv.NhanViens.Find(nv);
            contextnv.SaveChanges();
            return true;
        }

        public bool xoanhanvien(NhanVien nv)
        {
            contextnv.NhanViens.Remove(nv);
            contextnv.SaveChanges();
            return true;
        }
    }
}