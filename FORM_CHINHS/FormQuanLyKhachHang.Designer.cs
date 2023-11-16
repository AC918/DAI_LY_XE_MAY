namespace FORMS_MAINS
{
    partial class FormQuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBoxGioiTinhKH = new TextBox();
            textBoxTDVKH = new TextBox();
            textBoxDiaChiKH = new TextBox();
            textBoxSDTKH = new TextBox();
            textBoxTenKH = new TextBox();
            textBoxMaKH = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBoxTimKH = new TextBox();
            buttonTimKH = new Button();
            buttonHienThiKH = new Button();
            buttonXoaKH = new Button();
            buttonSuaKH = new Button();
            pictureBoxAnhKH = new PictureBox();
            buttonThemKH = new Button();
            dgvKhachHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBoxGioiTinhKH);
            groupBox1.Controls.Add(textBoxTDVKH);
            groupBox1.Controls.Add(textBoxDiaChiKH);
            groupBox1.Controls.Add(textBoxSDTKH);
            groupBox1.Controls.Add(textBoxTenKH);
            groupBox1.Controls.Add(textBoxMaKH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 249);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // textBoxGioiTinhKH
            // 
            textBoxGioiTinhKH.Location = new Point(168, 89);
            textBoxGioiTinhKH.Name = "textBoxGioiTinhKH";
            textBoxGioiTinhKH.Size = new Size(209, 27);
            textBoxGioiTinhKH.TabIndex = 14;
            // 
            // textBoxTDVKH
            // 
            textBoxTDVKH.Location = new Point(168, 155);
            textBoxTDVKH.Name = "textBoxTDVKH";
            textBoxTDVKH.Size = new Size(209, 27);
            textBoxTDVKH.TabIndex = 11;
            // 
            // textBoxDiaChiKH
            // 
            textBoxDiaChiKH.Location = new Point(168, 188);
            textBoxDiaChiKH.Name = "textBoxDiaChiKH";
            textBoxDiaChiKH.Size = new Size(209, 27);
            textBoxDiaChiKH.TabIndex = 13;
            // 
            // textBoxSDTKH
            // 
            textBoxSDTKH.Location = new Point(168, 122);
            textBoxSDTKH.Name = "textBoxSDTKH";
            textBoxSDTKH.Size = new Size(209, 27);
            textBoxSDTKH.TabIndex = 12;
            // 
            // textBoxTenKH
            // 
            textBoxTenKH.Location = new Point(168, 59);
            textBoxTenKH.Name = "textBoxTenKH";
            textBoxTenKH.Size = new Size(209, 27);
            textBoxTenKH.TabIndex = 9;
            // 
            // textBoxMaKH
            // 
            textBoxMaKH.Location = new Point(168, 26);
            textBoxMaKH.Name = "textBoxMaKH";
            textBoxMaKH.Size = new Size(209, 27);
            textBoxMaKH.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 159);
            label6.Name = "label6";
            label6.Size = new Size(147, 23);
            label6.TabIndex = 6;
            label6.Text = "Tên dịch vụ dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(97, 192);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 63);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 126);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 92);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "Giới tính";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(textBoxTimKH);
            groupBox2.Controls.Add(buttonTimKH);
            groupBox2.Controls.Add(buttonHienThiKH);
            groupBox2.Controls.Add(buttonXoaKH);
            groupBox2.Controls.Add(buttonSuaKH);
            groupBox2.Controls.Add(pictureBoxAnhKH);
            groupBox2.Controls.Add(buttonThemKH);
            groupBox2.Location = new Point(509, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 249);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng nhỏ";
            // 
            // textBoxTimKH
            // 
            textBoxTimKH.Location = new Point(169, 52);
            textBoxTimKH.Name = "textBoxTimKH";
            textBoxTimKH.Size = new Size(206, 27);
            textBoxTimKH.TabIndex = 8;
            // 
            // buttonTimKH
            // 
            buttonTimKH.Location = new Point(232, 85);
            buttonTimKH.Name = "buttonTimKH";
            buttonTimKH.Size = new Size(96, 27);
            buttonTimKH.TabIndex = 6;
            buttonTimKH.Text = "Tìm";
            buttonTimKH.UseVisualStyleBackColor = true;
            buttonTimKH.Click += buttonTimKH_Click;
            // 
            // buttonHienThiKH
            // 
            buttonHienThiKH.Location = new Point(284, 192);
            buttonHienThiKH.Name = "buttonHienThiKH";
            buttonHienThiKH.Size = new Size(91, 44);
            buttonHienThiKH.TabIndex = 5;
            buttonHienThiKH.Text = "Hiển thị";
            buttonHienThiKH.UseVisualStyleBackColor = true;
            buttonHienThiKH.Click += buttonHienThiKH_Click;
            // 
            // buttonXoaKH
            // 
            buttonXoaKH.Location = new Point(156, 192);
            buttonXoaKH.Name = "buttonXoaKH";
            buttonXoaKH.Size = new Size(87, 44);
            buttonXoaKH.TabIndex = 4;
            buttonXoaKH.Text = "Xóa";
            buttonXoaKH.UseVisualStyleBackColor = true;
            buttonXoaKH.Click += buttonXoaKH_Click;
            // 
            // buttonSuaKH
            // 
            buttonSuaKH.Location = new Point(284, 134);
            buttonSuaKH.Name = "buttonSuaKH";
            buttonSuaKH.Size = new Size(91, 42);
            buttonSuaKH.TabIndex = 3;
            buttonSuaKH.Text = "Sửa";
            buttonSuaKH.UseVisualStyleBackColor = true;
            buttonSuaKH.Click += buttonSuaKH_Click;
            // 
            // pictureBoxAnhKH
            // 
            pictureBoxAnhKH.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxAnhKH.Location = new Point(17, 30);
            pictureBoxAnhKH.Name = "pictureBoxAnhKH";
            pictureBoxAnhKH.Size = new Size(133, 137);
            pictureBoxAnhKH.TabIndex = 1;
            pictureBoxAnhKH.TabStop = false;
            // 
            // buttonThemKH
            // 
            buttonThemKH.Location = new Point(156, 134);
            buttonThemKH.Name = "buttonThemKH";
            buttonThemKH.Size = new Size(87, 42);
            buttonThemKH.TabIndex = 0;
            buttonThemKH.Text = "Thêm";
            buttonThemKH.UseVisualStyleBackColor = true;
            buttonThemKH.Click += buttonThemKH_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvKhachHang.Location = new Point(12, 267);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new Size(937, 297);
            dgvKhachHang.TabIndex = 6;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã khách hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số điện thoại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Tên dịch vụ dùng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Địa chỉ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Ảnh";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 576);
            Controls.Add(dgvKhachHang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormQuanLyKhachHang";
            Text = "FormQuanLyKhachHang";
            Load += FormQuanLyKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnhKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxTDVKH;
        private TextBox textBoxDiaChiKH;
        private TextBox textBoxSDTKH;
        private TextBox textBoxTenKH;
        private TextBox textBoxMaKH;
        private Label label6;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBoxTimKH;
        private Button buttonTimKH;
        private Button buttonHienThiKH;
        private Button buttonXoaKH;
        private Button buttonSuaKH;
        private PictureBox pictureBoxAnhKH;
        private Button buttonThemKH;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox textBoxGioiTinhKH;
        private OpenFileDialog openFileDialog1;
    }
}