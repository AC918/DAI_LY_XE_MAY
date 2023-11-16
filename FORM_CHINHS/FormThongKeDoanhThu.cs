using BUS.IServices;
using BUS.Services;
using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS_MAINS
{
    public partial class FormThongKeDoanhThu : Form
    {
        IThongKeDoanhThu doanhthuql;
        DoanhThu doanhthuform;
        public FormThongKeDoanhThu()
        {
            doanhthuql = new ThongKeDoanhThu();
            doanhthuform= new DoanhThu();
            InitializeComponent();
        }
        private void LoadDoanhThu()
        {
            dgvDoanhThu.Rows.Clear();
            dgvDoanhThu.ColumnCount = 6;
            dgvDoanhThu.Columns[0].Name = "STT";
            dgvDoanhThu.Columns[1].Name = "SoHoaDon";
            dgvDoanhThu.Columns[2].Name = "NgayBan";
            dgvDoanhThu.Columns[3].Name = "SoLuongBan";
            dgvDoanhThu.Columns[4].Name = "TrangThaiDT";
            dgvDoanhThu.Columns[5].Name = "TongDoanhThu";
            foreach (var x in doanhthuql.GetDoanhThus())
            {
                dgvDoanhThu.Rows.Add(x.Stt,x.SoHoaDon,x.NgayBan,x.SoLuongBan,x.TrangThaiDt,x.TongDoanhThu);
            }
        }
        private void buttonTimDT_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            
        }
    }
}