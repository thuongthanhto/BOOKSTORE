namespace GUI
{
    partial class frmLapPhieuNhapSach
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetText = new System.Windows.Forms.Button();
            this.btnBoSung = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMaSach = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhapCT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPNSCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox5.Controls.Add(this.btnResetText);
            this.groupBox5.Controls.Add(this.btnBoSung);
            this.groupBox5.Location = new System.Drawing.Point(86, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các chức năng";
            // 
            // btnResetText
            // 
            this.btnResetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnResetText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetText.ForeColor = System.Drawing.Color.White;
            this.btnResetText.Location = new System.Drawing.Point(216, 34);
            this.btnResetText.Name = "btnResetText";
            this.btnResetText.Size = new System.Drawing.Size(121, 43);
            this.btnResetText.TabIndex = 0;
            this.btnResetText.Text = "Xóa trắng";
            this.btnResetText.UseVisualStyleBackColor = false;
            this.btnResetText.Click += new System.EventHandler(this.btnResetText_Click);
            // 
            // btnBoSung
            // 
            this.btnBoSung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnBoSung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoSung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoSung.ForeColor = System.Drawing.Color.White;
            this.btnBoSung.Location = new System.Drawing.Point(44, 34);
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.Size = new System.Drawing.Size(121, 43);
            this.btnBoSung.TabIndex = 0;
            this.btnBoSung.Text = "Thêm";
            this.btnBoSung.UseVisualStyleBackColor = false;
            this.btnBoSung.Click += new System.EventHandler(this.btnBoSung_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.btnMaSach);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.txtMaSach);
            this.groupBox4.Controls.Add(this.txtDonGiaNhap);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtMaPhieuNhapCT);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(16, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(527, 105);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bổ sung";
            // 
            // btnMaSach
            // 
            this.btnMaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnMaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaSach.ForeColor = System.Drawing.Color.White;
            this.btnMaSach.Location = new System.Drawing.Point(459, 26);
            this.btnMaSach.Name = "btnMaSach";
            this.btnMaSach.Size = new System.Drawing.Size(62, 32);
            this.btnMaSach.TabIndex = 9;
            this.btnMaSach.Text = "Chọn";
            this.btnMaSach.UseVisualStyleBackColor = false;
            this.btnMaSach.Click += new System.EventHandler(this.btnMaSach_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(367, 61);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(134, 26);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(367, 29);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(86, 26);
            this.txtMaSach.TabIndex = 7;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(129, 61);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(148, 26);
            this.txtDonGiaNhap.TabIndex = 6;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "(Auto)";
            // 
            // txtMaPhieuNhapCT
            // 
            this.txtMaPhieuNhapCT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaPhieuNhapCT.Enabled = false;
            this.txtMaPhieuNhapCT.Location = new System.Drawing.Point(129, 29);
            this.txtMaPhieuNhapCT.Name = "txtMaPhieuNhapCT";
            this.txtMaPhieuNhapCT.ReadOnly = true;
            this.txtMaPhieuNhapCT.Size = new System.Drawing.Size(93, 26);
            this.txtMaPhieuNhapCT.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã phiếu nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(110, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "CHI TIẾT PHIẾU NHẬP SÁCH";
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvChiTietPhieuNhap.AllowUserToResizeRows = false;
            this.dgvChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPNSCT,
            this.colMaSach,
            this.colSoLuongNhap,
            this.colDonGiaNhap,
            this.colThanhTien});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(6, 26);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(515, 216);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            this.dgvChiTietPhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_RowEnter);
            // 
            // colMaPNSCT
            // 
            this.colMaPNSCT.DataPropertyName = "MaPNS";
            this.colMaPNSCT.HeaderText = "Mã PN";
            this.colMaPNSCT.Name = "colMaPNSCT";
            this.colMaPNSCT.ReadOnly = true;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.colSoLuongNhap.HeaderText = "Số lượng";
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            this.colSoLuongNhap.ReadOnly = true;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.colDonGiaNhap.HeaderText = "Đơn giá";
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 598);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(410, 545);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.dgvPhieuNhap);
            this.groupBox3.Location = new System.Drawing.Point(28, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 242);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu nhập sách";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AllowUserToResizeColumns = false;
            this.dgvPhieuNhap.AllowUserToResizeRows = false;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuNhap,
            this.colNgayNhap,
            this.colTongTien});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(28, 26);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(443, 216);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_RowEnter);
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.DataPropertyName = "MaPNS";
            this.colMaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.ReadOnly = true;
            this.colMaPhieuNhap.Width = 150;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.DataPropertyName = "NgayNhap";
            this.colNgayNhap.HeaderText = "Ngày nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Width = 150;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.btnChiTiet);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(108, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(187, 34);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(119, 43);
            this.btnChiTiet.TabIndex = 0;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập phiếu nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Auto)";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(185, 67);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(216, 26);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaPhieuNhap.Enabled = false;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(185, 30);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ReadOnly = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(137, 26);
            this.txtMaPhieuNhap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(192, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP SÁCH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(561, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 598);
            this.panel2.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(400, 545);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 38);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox6.Controls.Add(this.dgvChiTietPhieuNhap);
            this.groupBox6.Location = new System.Drawing.Point(16, 288);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(527, 242);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi tiết phiếu nhập sách";
            // 
            // frmLapPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapPhieuNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Nhập Sách";
            this.Load += new System.EventHandler(this.frmLapPhieuNhapSach_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResetText;
        private System.Windows.Forms.Button btnBoSung;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMaSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaPhieuNhapCT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPNSCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}