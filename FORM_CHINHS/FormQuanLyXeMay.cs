using BUS.IServices;
using BUS.Services;
using DAL_CLASS.MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS_MAINS
{
    public partial class FormQuanLyXeMay : Form
    {
        IQuanLyXeMay xemayql;
        XeMay xemayform;
        public FormQuanLyXeMay()
        {
            xemayql = new QuanLyXeMay();
            xemayform = new XeMay();
            InitializeComponent();
        }
        private void FormQuanLyXeMay_Load(object sender, EventArgs e)
        {

        }
        private void LoadXeMay()
        {
            dgvXeMay.Rows.Clear();
            dgvXeMay.ColumnCount = 7;
            dgvXeMay.Columns[0].Name = "MaXe";
            dgvXeMay.Columns[1].Name = "TenXe";
            dgvXeMay.Columns[2].Name = "MauXe";
            dgvXeMay.Columns[3].Name = "LoaiXe";
            dgvXeMay.Columns[4].Name = "GiaXe";
            dgvXeMay.Columns[5].Name = "ThongSo";
            dgvXeMay.Columns[6].Name = "AnhXe";
            foreach (var x in xemayql.GetXeMays())
            {
                dgvXeMay.Rows.Add(x.MaXe,x.TenXe,x.MauXe,x.LoaiXe,x.GiaXe,x.ThongSo,pictureBox1.ToString());
            }
        }
        private void ChuyenAnhThanhChuoi()
        {
            // Lấy ảnh từ cột 7 của DataGridView
            Image image = (Image)dgvXeMay.CurrentRow.Cells[6].Value;

            // Chuyển đổi ảnh thành byte[]
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg); // hoặc ImageFormat.Png, ImageFormat.Gif, ...
                imageBytes = ms.ToArray();
            }

            // Chuyển đổi byte[] thành chuỗi base64
            string imageBase64 = Convert.ToBase64String(imageBytes);

            // Gán chuỗi base64 cho một ô cụ thể trong DataGridView
            dgvXeMay.CurrentRow.Cells[6].Value = imageBase64;
        }
        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";
            openFileDialog1.Title = "Chọn ảnh";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = image;
                    dgvXeMay.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            XeMay them = new XeMay()
            { 
                MaXe = Guid.NewGuid(),
                TenXe = textBoxTenXe.Text,
                MauXe = textBoxMauXe.Text,
                LoaiXe = textBoxLoaiXe.Text,
                GiaXe = decimal.Parse(textBoxGiaXe.Text),
                ThongSo = richTextBoxThongSoXe.Text,
            };
            xemayql.addxemay(them);
        }

        private void buttonSuaXe_Click(object sender, EventArgs e)
        {
            xemayform.TenXe = textBoxTenXe.Text;
            xemayform.MauXe = textBoxMauXe.Text;
            xemayform.LoaiXe = textBoxLoaiXe.Text;
            xemayform.GiaXe = Convert.ToDecimal(textBoxGiaXe.Text);
            xemayform.ThongSo = richTextBoxThongSoXe.Text;
            xemayql.updatexemay(xemayform);
        }

        private void buttonTimXe_Click(object sender, EventArgs e)
        {
            string searchText = textBoxTimXe.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Search for matching records based on the search text
                var searchResults = xemayql.GetXeMays().Where(x => x.TenXe.Contains(searchText) || x.MauXe.Contains(searchText) || x.LoaiXe.Contains(searchText) || x.ThongSo.Contains(searchText));

                // Display search results in the DataGridView
                dgvXeMay.Rows.Clear();
                dgvXeMay.ColumnCount = 7;
                dgvXeMay.Columns[0].Name = "MaXe";
                dgvXeMay.Columns[1].Name = "TenXe";
                dgvXeMay.Columns[2].Name = "MauXe";
                dgvXeMay.Columns[3].Name = "LoaiXe";
                dgvXeMay.Columns[4].Name = "GiaXe";
                dgvXeMay.Columns[5].Name = "ThongSo";
                dgvXeMay.Columns[6].Name = "AnhXe";
                foreach (var x in searchResults)
                {
                    dgvXeMay.Rows.Add(x.MaXe, x.TenXe, x.MauXe, x.LoaiXe, x.GiaXe, x.ThongSo);
                }
            }
            else
            {
                // If search text is empty or whitespace, display all records
                LoadXeMay();
            }
        }

        private void buttonXoaXe_Click(object sender, EventArgs e)
        {
            xemayql.deletexemay(xemayform);
        }

        private void buttonHienThiXe_Click(object sender, EventArgs e)
        {
            LoadXeMay();
        }

        private void dgvXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvXeMay.Rows[e.RowIndex];
            xemayform = xemayql.GetXeMays().FirstOrDefault(x => x.MaXe == Guid.Parse(row.Cells[0].Value.ToString()));
            textBoxMaXe.Text = xemayform.MaXe.ToString();
            textBoxTenXe.Text = xemayform.TenXe.ToString();
            textBoxMauXe.Text = xemayform.MauXe.ToString();
            textBoxLoaiXe.Text = xemayform.LoaiXe.ToString();
            textBoxGiaXe.Text = xemayform.GiaXe.Value.ToString();
            richTextBoxThongSoXe.Text = xemayform.ThongSo.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}