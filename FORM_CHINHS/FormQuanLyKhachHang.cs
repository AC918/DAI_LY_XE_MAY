using BUS.IServices;
using BUS.Services;
using BUS_CLASS.ViewModel;
using DAL.Responsity;
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
    public partial class FormQuanLyKhachHang : Form
    {
        IQuanLyKhachHang khachhangql;
        KhachHang khachhangform;
        List<ViewKhachHangVoiDVBH> view;
        public FormQuanLyKhachHang()
        {
            khachhangql = new QuanLyKhachHang();
            khachhangform = new KhachHang();
            view = new List<ViewKhachHangVoiDVBH>();
            InitializeComponent();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void LoadKhachHangView()
        {
            dgvKhachHang.Rows.Clear();
            dgvKhachHang.ColumnCount = 7;
            dgvKhachHang.Columns[0].Name = "MaKhachHang";
            dgvKhachHang.Columns[1].Name = "TenKhachHang";
            dgvKhachHang.Columns[2].Name = "GioiTinhKH";
            dgvKhachHang.Columns[3].Name = "SDTKhachHang";
            dgvKhachHang.Columns[4].Name = "TenDichVuDung";
            dgvKhachHang.Columns[5].Name = "DiaChiKhachHang";
            dgvKhachHang.Columns[6].Name = "AnhKhachHang";
            foreach (var x in khachhangql.GetViewKhachHangVoiDVBHs())
            {
                dgvKhachHang.Rows.Add(x.kh.MaKhachHang, x.kh.GioiTinhKh, x.kh.SdtkhachHang, x.dvbh.TenBaoHanh, x.kh.DiaChiKhachHang, pictureBoxAnhKH.ToString());
            }
        }
        private void LoadKhachHang()
        {
            dgvKhachHang.Rows.Clear();
            dgvKhachHang.ColumnCount = 7;
            dgvKhachHang.Columns[0].Name = "MaKhachHang";
            dgvKhachHang.Columns[1].Name = "TenKhachHang";
            dgvKhachHang.Columns[2].Name = "GioiTinhKH";
            dgvKhachHang.Columns[3].Name = "SDTKhachHang";
            dgvKhachHang.Columns[4].Name = "TenDichVuDung";
            dgvKhachHang.Columns[5].Name = "DiaChiKhachHang";
            dgvKhachHang.Columns[6].Name = "AnhKhachHang";
            foreach (var x in khachhangql.GetKhachHangs())
            {
                dgvKhachHang.Rows.Add(x.MaKhachHang, x.TenKhachHang, x.GioiTinhKh, x.SdtkhachHang, x.TenDichVuDung, x.DiaChiKhachHang, pictureBoxAnhKH.ToString());
            }
        }
        private void buttonThemKH_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";
            openFileDialog1.Title = "Chọn ảnh";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxAnhKH.Image = image;
                    dgvKhachHang.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            KhachHang them = new KhachHang()
            {
                MaKhachHang = Guid.NewGuid(),
                TenKhachHang = textBoxTenKH.Text,
                GioiTinhKh = textBoxGioiTinhKH.Text,
                SdtkhachHang = textBoxSDTKH.Text,
                TenDichVuDung = textBoxTDVKH.Text,
                DiaChiKhachHang = textBoxDiaChiKH.Text,
            };
            khachhangql.addkhachhang(them);
        }

        private void buttonSuaKH_Click(object sender, EventArgs e)
        {
            khachhangform.TenKhachHang = textBoxTenKH.Text;
            khachhangform.GioiTinhKh = textBoxGioiTinhKH.Text;
            khachhangform.SdtkhachHang = textBoxTenKH.Text;
            khachhangform.TenDichVuDung = textBoxTenKH.Text;
            khachhangform.DiaChiKhachHang = textBoxTenKH.Text;
            khachhangql.updatekhachhang(khachhangform);
        }

        private void buttonXoaKH_Click(object sender, EventArgs e)
        {
            khachhangql.deletekhachhang(khachhangform);
        }

        private void buttonHienThiKH_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            //LoadKhachHangView();
        }

        private void buttonTimKH_Click(object sender, EventArgs e)
        {
            string searchText = textBoxTimKH.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Search for matching records based on the search text
                var searchResults = khachhangql.GetKhachHangs().Where(x => x.TenKhachHang.Contains(searchText) || x.TenDichVuDung.Contains(searchText) || x.DiaChiKhachHang.Contains(searchText));

                // Display search results in the DataGridView
                dgvKhachHang.Rows.Clear();
                dgvKhachHang.ColumnCount = 7;
                dgvKhachHang.Columns[0].Name = "MaKhachHang";
                dgvKhachHang.Columns[1].Name = "TenKhachHang";
                dgvKhachHang.Columns[2].Name = "GioiTinhKH";
                dgvKhachHang.Columns[3].Name = "SDTKhachHang";
                dgvKhachHang.Columns[4].Name = "TenDichVuDung";
                dgvKhachHang.Columns[5].Name = "DiaChiKhachHang";
                dgvKhachHang.Columns[6].Name = "AnhKhachHang";
                foreach (var x in searchResults)
                {
                    dgvKhachHang.Rows.Add(x.MaKhachHang, x.TenKhachHang, x.GioiTinhKh, x.DiaChiKhachHang, x.TenDichVuDung, x.DiaChiKhachHang, pictureBoxAnhKH.ToString());
                }
            }
            else
            {
                // If search text is empty or whitespace, display all records
                LoadKhachHang();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            khachhangform = khachhangql.GetKhachHangs().FirstOrDefault(x => x.MaKhachHang == Guid.Parse(row.Cells[0].Value.ToString()));
            textBoxMaKH.Text = khachhangform.MaKhachHang.ToString();
            textBoxTenKH.Text = khachhangform.TenKhachHang.ToString();
            textBoxGioiTinhKH.Text = khachhangform.GioiTinhKh.ToString();
            textBoxSDTKH.Text = khachhangform.SdtkhachHang.ToString();
            textBoxTDVKH.Text = khachhangform.TenDichVuDung.ToString();
            textBoxDiaChiKH.Text = khachhangform.DiaChiKhachHang.ToString();
        }
    }
}
