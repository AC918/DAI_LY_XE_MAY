namespace FORM_CHINHS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            btnDoiMatKhau = new Button();
            btnDangKy = new Button();
            btnDangNhap = new Button();
            cbNhoThongTin = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 29);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 121;
            label1.Text = "Đăng nhập";
            label1.UseWaitCursor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(284, 201);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(301, 34);
            txtMatKhau.TabIndex = 120;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Location = new Point(284, 118);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(301, 34);
            txtTaiKhoan.TabIndex = 119;
            txtTaiKhoan.UseWaitCursor = true;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.SkyBlue;
            btnDoiMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoiMatKhau.Location = new Point(532, 324);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(165, 63);
            btnDoiMatKhau.TabIndex = 118;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.UseWaitCursor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.SkyBlue;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangKy.Location = new Point(315, 324);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(177, 63);
            btnDangKy.TabIndex = 117;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.UseWaitCursor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SkyBlue;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(93, 324);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(185, 63);
            btnDangNhap.TabIndex = 116;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.UseWaitCursor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // cbNhoThongTin
            // 
            cbNhoThongTin.AutoSize = true;
            cbNhoThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbNhoThongTin.Location = new Point(306, 264);
            cbNhoThongTin.Name = "cbNhoThongTin";
            cbNhoThongTin.Size = new Size(158, 32);
            cbNhoThongTin.TabIndex = 115;
            cbNhoThongTin.Text = "Nhớ thông tin";
            cbNhoThongTin.UseVisualStyleBackColor = true;
            cbNhoThongTin.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(162, 204);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 114;
            label2.Text = "Mật khẩu";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(161, 121);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 113;
            label3.Text = "Tài khoản";
            label3.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(cbNhoThongTin);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Button btnDoiMatKhau;
        private Button btnDangKy;
        private Button btnDangNhap;
        private CheckBox cbNhoThongTin;
        private Label label2;
        private Label label3;
    }
}