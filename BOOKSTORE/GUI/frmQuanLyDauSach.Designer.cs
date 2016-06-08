namespace GUI
{
    partial class frmQuanLyDauSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhongluu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChiTietTacGia = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.colMaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTenDauSach = new System.Windows.Forms.TextBox();
            this.txtMaDauSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCT_TacGia = new System.Windows.Forms.DataGridView();
            this.colMaDauSachCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaTacGia = new System.Windows.Forms.Button();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSachCT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_TacGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnKhongluu);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnChiTietTacGia);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 584);
            this.panel1.TabIndex = 6;
            // 
            // btnKhongluu
            // 
            this.btnKhongluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnKhongluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongluu.ForeColor = System.Drawing.Color.White;
            this.btnKhongluu.Location = new System.Drawing.Point(480, 200);
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.Size = new System.Drawing.Size(100, 33);
            this.btnKhongluu.TabIndex = 54;
            this.btnKhongluu.Text = "Không lưu";
            this.btnKhongluu.UseVisualStyleBackColor = false;
            this.btnKhongluu.Click += new System.EventHandler(this.btnKhongluu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(374, 200);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 33);
            this.btnLuu.TabIndex = 53;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(589, 518);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChiTietTacGia
            // 
            this.btnChiTietTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnChiTietTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietTacGia.ForeColor = System.Drawing.Color.White;
            this.btnChiTietTacGia.Location = new System.Drawing.Point(297, 239);
            this.btnChiTietTacGia.Name = "btnChiTietTacGia";
            this.btnChiTietTacGia.Size = new System.Drawing.Size(152, 33);
            this.btnChiTietTacGia.TabIndex = 7;
            this.btnChiTietTacGia.Text = "Chi tiết tác giả";
            this.btnChiTietTacGia.UseVisualStyleBackColor = false;
            this.btnChiTietTacGia.Click += new System.EventHandler(this.btnChiTietTacGia_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(268, 200);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 33);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvDauSach);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(49, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đầu sách";
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToAddRows = false;
            this.dgvDauSach.AllowUserToResizeRows = false;
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDauSach,
            this.colTenDauSach,
            this.colMaTheLoai});
            this.dgvDauSach.Location = new System.Drawing.Point(0, 26);
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.Size = new System.Drawing.Size(657, 192);
            this.dgvDauSach.TabIndex = 0;
            this.dgvDauSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_RowEnter);
            // 
            // colMaDauSach
            // 
            this.colMaDauSach.DataPropertyName = "MaDauSach";
            this.colMaDauSach.HeaderText = "Mã đầu sách";
            this.colMaDauSach.Name = "colMaDauSach";
            this.colMaDauSach.ReadOnly = true;
            this.colMaDauSach.Width = 120;
            // 
            // colTenDauSach
            // 
            this.colTenDauSach.DataPropertyName = "TenDauSach";
            this.colTenDauSach.HeaderText = "Tên đầu sách";
            this.colTenDauSach.Name = "colTenDauSach";
            this.colTenDauSach.ReadOnly = true;
            this.colTenDauSach.Width = 230;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaTheLoai.DataPropertyName = "MaTheLoai";
            this.colMaTheLoai.HeaderText = "Thể loại";
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.ReadOnly = true;
            this.colMaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(162, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 33);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboTheLoai);
            this.groupBox1.Controls.Add(this.txtTenDauSach);
            this.groupBox1.Controls.Add(this.txtMaDauSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(49, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đầu sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "(Auto)";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(423, 30);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(191, 27);
            this.cboTheLoai.TabIndex = 6;
            // 
            // txtTenDauSach
            // 
            this.txtTenDauSach.Location = new System.Drawing.Point(123, 67);
            this.txtTenDauSach.Name = "txtTenDauSach";
            this.txtTenDauSach.Size = new System.Drawing.Size(196, 26);
            this.txtTenDauSach.TabIndex = 4;
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaDauSach.Enabled = false;
            this.txtMaDauSach.Location = new System.Drawing.Point(123, 31);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.ReadOnly = true;
            this.txtMaDauSach.Size = new System.Drawing.Size(113, 26);
            this.txtMaDauSach.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đầu sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đầu sách: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(243, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ ĐẦU SÁCH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.btnXoaTrang);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.btnXoaTacGia);
            this.panel2.Controls.Add(this.btnThemTacGia);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(750, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 584);
            this.panel2.TabIndex = 7;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnXoaTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTrang.ForeColor = System.Drawing.Color.White;
            this.btnXoaTrang.Location = new System.Drawing.Point(316, 218);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(111, 33);
            this.btnXoaTrang.TabIndex = 11;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = false;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(344, 518);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 41);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(150, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "CHI TIẾT TÁC GIẢ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.dgvCT_TacGia);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(27, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 221);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết tác giả";
            // 
            // dgvCT_TacGia
            // 
            this.dgvCT_TacGia.AllowUserToAddRows = false;
            this.dgvCT_TacGia.AllowUserToDeleteRows = false;
            this.dgvCT_TacGia.AllowUserToResizeColumns = false;
            this.dgvCT_TacGia.AllowUserToResizeRows = false;
            this.dgvCT_TacGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvCT_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_TacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDauSachCT,
            this.colTenTacGia});
            this.dgvCT_TacGia.Location = new System.Drawing.Point(0, 30);
            this.dgvCT_TacGia.Name = "dgvCT_TacGia";
            this.dgvCT_TacGia.Size = new System.Drawing.Size(428, 192);
            this.dgvCT_TacGia.TabIndex = 0;
            this.dgvCT_TacGia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_TacGia_RowEnter);
            // 
            // colMaDauSachCT
            // 
            this.colMaDauSachCT.DataPropertyName = "MaDauSach";
            this.colMaDauSachCT.HeaderText = "Mã đầu sách";
            this.colMaDauSachCT.Name = "colMaDauSachCT";
            this.colMaDauSachCT.ReadOnly = true;
            this.colMaDauSachCT.Width = 150;
            // 
            // colTenTacGia
            // 
            this.colTenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenTacGia.DataPropertyName = "TacGia";
            this.colTenTacGia.HeaderText = "Tên tác giả";
            this.colTenTacGia.Name = "colTenTacGia";
            this.colTenTacGia.ReadOnly = true;
            // 
            // btnXoaTacGia
            // 
            this.btnXoaTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnXoaTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTacGia.ForeColor = System.Drawing.Color.White;
            this.btnXoaTacGia.Location = new System.Drawing.Point(187, 218);
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.Size = new System.Drawing.Size(123, 33);
            this.btnXoaTacGia.TabIndex = 7;
            this.btnXoaTacGia.Text = "Xóa tác giả";
            this.btnXoaTacGia.UseVisualStyleBackColor = false;
            this.btnXoaTacGia.Click += new System.EventHandler(this.btnXoaTacGia_Click);
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThemTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTacGia.ForeColor = System.Drawing.Color.White;
            this.btnThemTacGia.Location = new System.Drawing.Point(64, 218);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(117, 33);
            this.btnThemTacGia.TabIndex = 7;
            this.btnThemTacGia.Text = "Thêm tác giả";
            this.btnThemTacGia.UseVisualStyleBackColor = false;
            this.btnThemTacGia.Click += new System.EventHandler(this.btnThemTacGia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.txtTacGia);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtMaSachCT);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(49, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết tác giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(115, 67);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(209, 26);
            this.txtTacGia.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tác giả:";
            // 
            // txtMaSachCT
            // 
            this.txtMaSachCT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaSachCT.Enabled = false;
            this.txtMaSachCT.Location = new System.Drawing.Point(115, 30);
            this.txtMaSachCT.Name = "txtMaSachCT";
            this.txtMaSachCT.ReadOnly = true;
            this.txtMaSachCT.Size = new System.Drawing.Size(118, 26);
            this.txtMaSachCT.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã đầu sách: ";
            // 
            // frmQuanLyDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đầu Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyDauSach_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyDauSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_TacGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.TextBox txtTenDauSach;
        private System.Windows.Forms.TextBox txtMaDauSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCT_TacGia;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSachCT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChiTietTacGia;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSachCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDauSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTheLoai;
        private System.Windows.Forms.Button btnKhongluu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;

    }
}