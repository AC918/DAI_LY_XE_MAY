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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangNhapDK_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyDK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoanDK.Text == "" || txtMatKhauDK.Text == "" || txtMatKhauNhapLaiDK.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            if (txtMatKhauDK.Text != txtMatKhauNhapLaiDK.Text)
            {
                MessageBox.Show("Mat khau va nhap lai chua dung");
            }
            Form1 dn = new Form1();
            dn.Show();
            this.Hide();
        }

        private void btnDoiMatKhauDK_Click(object sender, EventArgs e)
        {

        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            btnDangNhapDK.Enabled = false;
            btnDoiMatKhauDK.Enabled = false;
        }
    }
}
