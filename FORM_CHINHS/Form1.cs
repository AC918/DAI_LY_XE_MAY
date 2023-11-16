using FORMS_MAINS;

namespace FORM_CHINHS
{
    public partial class Form1 : Form
    {
        List<AccountLogin> listTaiKhoan = ListsAccounts.Instance.ListTaiKhoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                FormTrangChu home = new FormTrangChu();
                home.Show();
                this.Hide();
            }
            string thongbao;
            thongbao = "Ten dang nhap la: ";
            thongbao += this.txtTaiKhoan.Text;
            thongbao += "\nMat khau la: ";
            thongbao += this.txtMatKhau.Text;
            if (cbNhoThongTin.Checked == true)
            {
                thongbao += "\nBan co ghi nho thong tin ?";
            }
            MessageBox.Show(thongbao, "Thong bao");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
        bool KiemTraDangNhap(string tentk, string mk)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentk == listTaiKhoan[i].TenTaiKhoan || mk == listTaiKhoan[i].MatKhau)
                {
                    BangTam.LoaiTaiKhoan = listTaiKhoan[i].LoaiTaiKhoan;
                    return true;
                }
            }
            return false;
        }
    }
}