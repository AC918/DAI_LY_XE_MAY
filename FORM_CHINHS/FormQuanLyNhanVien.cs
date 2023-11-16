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
    public partial class FormQuanLyNhanVien : Form
    {
        IQuanLyNhanVien nhanvienql;
        NhanVien nhanvienform;
        public FormQuanLyNhanVien()
        {
            nhanvienql = new QuanLyNhanVien();
            nhanvienform = new NhanVien();
            InitializeComponent();
        }
        private void LoadNhanVien()
        {
            dgvNhanVien.Rows.Clear();
            dgvNhanVien.ColumnCount = 7;
            dgvNhanVien.Columns[0].Name = "MaNhanVien";
            dgvNhanVien.Columns[1].Name = "TenNhanVien";
            dgvNhanVien.Columns[2].Name = "GioiTinhNV";
            dgvNhanVien.Columns[3].Name = "SDTNhanVien";
            dgvNhanVien.Columns[4].Name = "EmailNhanVien";
            dgvNhanVien.Columns[5].Name = "DiaChiNhanVien";
            dgvNhanVien.Columns[6].Name = "AnhNhanVien";
            foreach (var x in nhanvienql.GetNhanViens())
            {
                dgvNhanVien.Rows.Add(x.MaNhanVien,x.TenNhanVien,x.GioiTinhNv,x.SdtnhanVien,x.EmailNhanVien,x.DiaChiNhanVien,pictureBoxAnhNV.ToString());
            }
        }
        private void buttonThemNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";
            openFileDialog1.Title = "Chọn ảnh";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxAnhNV.Image = image;
                    dgvNhanVien.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            NhanVien them = new NhanVien()
            {
                MaNhanVien = Guid.NewGuid(),
                TenNhanVien = textBoxTenNV.Text,
                GioiTinhNv = textBoxGioiTinhNV.Text,
                SdtnhanVien = textBoxSDTNV.Text,
                EmailNhanVien = textBoxGmailNV.Text,
                DiaChiNhanVien = textBoxDiaChiNV.Text,
            };
            nhanvienql.addnhanvien(them);
        }

        private void buttonSuaNV_Click(object sender, EventArgs e)
        {
            nhanvienform.TenNhanVien = textBoxTenNV.Text;
            nhanvienform.GioiTinhNv = textBoxGioiTinhNV.Text;
            nhanvienform.SdtnhanVien = textBoxSDTNV.Text;
            nhanvienform.EmailNhanVien = textBoxGmailNV.Text;
            nhanvienform.DiaChiNhanVien = textBoxDiaChiNV.Text;
            nhanvienql.updatenhanvien(nhanvienform);
        }

        private void buttonXoaNV_Click(object sender, EventArgs e)
        {
            nhanvienql.deletenhanvien(nhanvienform);
        }

        private void buttonHienThiNV_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void buttonTimXe_Click(object sender, EventArgs e)
        {
            string searchText = textBoxTimNV.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Search for matching records based on the search text
                var searchResults = nhanvienql.GetNhanViens().Where(x => x.TenNhanVien.Contains(searchText) || x.EmailNhanVien.Contains(searchText) || x.DiaChiNhanVien.Contains(searchText));

                // Display search results in the DataGridView
                dgvNhanVien.Rows.Clear();
                dgvNhanVien.ColumnCount = 7;
                dgvNhanVien.Columns[0].Name = "MaNhanVien";
                dgvNhanVien.Columns[1].Name = "TenNhanVien";
                dgvNhanVien.Columns[2].Name = "GioiTinhNV";
                dgvNhanVien.Columns[3].Name = "SDTNhanVien";
                dgvNhanVien.Columns[4].Name = "EmailNhanVien";
                dgvNhanVien.Columns[5].Name = "DiaChiNhanVien";
                dgvNhanVien.Columns[6].Name = "AnhNhanVien";
                foreach (var x in nhanvienql.GetNhanViens())
                {
                    dgvNhanVien.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.SdtnhanVien,x.GioiTinhNv, x.EmailNhanVien, x.DiaChiNhanVien);
                }
            }
            else
            {
                // If search text is empty or whitespace, display all records
                LoadNhanVien();
            }
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            nhanvienform = nhanvienql.GetNhanViens().FirstOrDefault(x => x.MaNhanVien == Guid.Parse(row.Cells[0].Value.ToString()));
            textBoxMaNV.Text = nhanvienform.MaNhanVien.ToString();
            textBoxTenNV.Text = nhanvienform.TenNhanVien.ToString();
            textBoxGioiTinhNV.Text = nhanvienform.GioiTinhNv.ToString();
            textBoxSDTNV.Text = nhanvienform.SdtnhanVien.ToString();
            textBoxGmailNV.Text = nhanvienform.EmailNhanVien.ToString();
            textBoxDiaChiNV.Text = nhanvienform.DiaChiNhanVien.ToString();
        }
    }
}