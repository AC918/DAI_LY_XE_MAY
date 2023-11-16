using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IDichVuBaoDuongBus
    {
        string addbaoduong(DichVuBaoDuong dichvubaoduong);
        string updatebaoduong(DichVuBaoDuong dichvubaoduong);
        string deletebaoduong(DichVuBaoDuong dichvubaoduong);
        List<DichVuBaoDuong> GetDichVuBaoDuongs();
    }
}