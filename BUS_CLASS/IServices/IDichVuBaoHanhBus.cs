using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IDichVuBaoHanhBus
    {
        string addbaohanh(DichVuBaoHanh dichvubaohanh);
        string updatebaohanh(DichVuBaoHanh dichvubaohanh);
        string deletebaohanh(DichVuBaoHanh dichvubaohanh);
        List<DichVuBaoHanh> GetDichVuBaoHanhs();
    }
}