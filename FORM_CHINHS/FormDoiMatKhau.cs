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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDangNhapDMK_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyDMK_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhauDMK_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoanDMK.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoiDMK.Text == "" || txtMatKhauNhapLaiDMK.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            if (txtMatKhauMoiDMK.Text != txtMatKhauNhapLaiDMK.Text)
            {
                MessageBox.Show("Mat khau moi hoac mat khau moi nhap lai sai");
            }
            Form1 dn2 = new Form1();
            dn2.Show();
            this.Hide();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            btnDangNhapDMK.Enabled = false;
            btnDangKyDMK.Enabled = false;
        }
    }
}
