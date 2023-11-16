using FORM_CHINHS;
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
    public partial class FormTrangChu : Form
    {
        private Form currentformchild;
        public FormTrangChu()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childform)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childform);
            panelForm.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void PhanQuyen()
        {
            if (BangTam.LoaiTaiKhoan == true)
            {
                buttonQLXM.Enabled = true;
                buttonQLNV.Enabled = true;
                buttonQLKH.Enabled = false;
                buttonTKDT.Enabled = true;
                buttonQLHD.Enabled = false;
                buttonQLBH.Enabled = false;
                buttonDVBH.Enabled = true;
                buttonDVBD.Enabled = true;
            }
            if (BangTam.LoaiTaiKhoan == false)
            {
                buttonQLXM.Enabled = false;
                buttonQLNV.Enabled = false;
                buttonQLKH.Enabled = true;
                buttonTKDT.Enabled = false;
                buttonQLHD.Enabled = true;
                buttonQLBH.Enabled = true;
                buttonDVBH.Enabled = false;
                buttonDVBD.Enabled = false;
            }
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void buttonQLXM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyXeMay());
            labelText.Text = buttonQLXM.Text;
        }

        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 dx = new Form1();
            dx.Show();
            this.Hide();
        }

        private void buttonQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyNhanVien());
            labelText.Text = buttonQLNV.Text;
        }

        private void buttonQLKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyKhachHang());
            labelText.Text = buttonQLKH.Text;
        }

        private void buttonTKDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeDoanhThu());
            labelText.Text = buttonTKDT.Text;
        }

        private void buttonQLHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyHoaDon());
            labelText.Text = buttonQLHD.Text;
        }

        private void buttonQLBH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyBanHang());
            labelText.Text = buttonQLBH.Text;
        }

        private void buttonDVBH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDichVuBaoHanh());
            labelText.Text = buttonDVBH.Text;
        }

        private void buttonDVBD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDichVuBaoDuong());
            labelText.Text = buttonDVBD.Text;
        }
    }
}