namespace GUI
{
    partial class frmLapPhieuThuTien
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.dtpNgayThuTien = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnMaKhachHang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieuThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuThuTien = new System.Windows.Forms.DataGridView();
            this.colMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgayThuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKhongluu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThuTien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(617, 442);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 33);
            this.btnthoat.TabIndex = 24;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dtpNgayThuTien
            // 
            this.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThuTien.Location = new System.Drawing.Point(193, 90);
            this.dtpNgayThuTien.Name = "dtpNgayThuTien";
            this.dtpNgayThuTien.Size = new System.Drawing.Size(162, 26);
            this.dtpNgayThuTien.TabIndex = 4;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(193, 154);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(162, 26);
            this.txtSoTien.TabIndex = 3;
            // 
            // btnMaKhachHang
            // 
            this.btnMaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnMaKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnMaKhachHang.Location = new System.Drawing.Point(361, 55);
            this.btnMaKhachHang.Name = "btnMaKhachHang";
            this.btnMaKhachHang.Size = new System.Drawing.Size(71, 31);
            this.btnMaKhachHang.TabIndex = 0;
            this.btnMaKhachHang.Text = "Chọn";
            this.btnMaKhachHang.UseVisualStyleBackColor = false;
            this.btnMaKhachHang.Click += new System.EventHandler(this.btnMaKhachHang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày thu tiền:";
            // 
            // txtMaPhieuThu
            // 
            this.txtMaPhieuThu.Location = new System.Drawing.Point(193, 26);
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.ReadOnly = true;
            this.txtMaPhieuThu.Size = new System.Drawing.Size(162, 26);
            this.txtMaPhieuThu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu thu(auto):";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(193, 58);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(162, 26);
            this.txtMaKhachHang.TabIndex = 3;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(42, 61);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(105, 19);
            this.la.TabIndex = 2;
            this.la.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvPhieuThuTien);
            this.groupBox2.Location = new System.Drawing.Point(18, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 175);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu thu tiền";
            // 
            // dgvPhieuThuTien
            // 
            this.dgvPhieuThuTien.AllowUserToAddRows = false;
            this.dgvPhieuThuTien.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPT,
            this.colMaKhachHang,
            this.colNgayThuTien,
            this.colSoTienThu});
            this.dgvPhieuThuTien.Location = new System.Drawing.Point(6, 25);
            this.dgvPhieuThuTien.Name = "dgvPhieuThuTien";
            this.dgvPhieuThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThuTien.Size = new System.Drawing.Size(714, 150);
            this.dgvPhieuThuTien.TabIndex = 10;
            this.dgvPhieuThuTien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThuTien_RowEnter);
            // 
            // colMaPT
            // 
            this.colMaPT.DataPropertyName = "MaPT";
            this.colMaPT.HeaderText = "Mã phiếu thu";
            this.colMaPT.Name = "colMaPT";
            this.colMaPT.Width = 130;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaKhachHang.DataPropertyName = "MaKhachHang";
            this.colMaKhachHang.HeaderText = "Khách hàng";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaKhachHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNgayThuTien
            // 
            this.colNgayThuTien.DataPropertyName = "NgayLap";
            this.colNgayThuTien.HeaderText = "Ngày thu";
            this.colNgayThuTien.Name = "colNgayThuTien";
            this.colNgayThuTien.Width = 150;
            // 
            // colSoTienThu
            // 
            this.colSoTienThu.DataPropertyName = "SoTienThu";
            this.colSoTienThu.HeaderText = "Số tiền thu";
            this.colSoTienThu.Name = "colSoTienThu";
            this.colSoTienThu.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(276, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "PHIẾU THU TIỀN";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(20, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(142, 29);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.btnKhongluu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(474, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 168);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các chức năng";
            // 
            // btnKhongluu
            // 
            this.btnKhongluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnKhongluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongluu.ForeColor = System.Drawing.Color.White;
            this.btnKhongluu.Location = new System.Drawing.Point(142, 70);
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.Size = new System.Drawing.Size(100, 35);
            this.btnKhongluu.TabIndex = 56;
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
            this.btnLuu.Location = new System.Drawing.Point(20, 70);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(20, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.txtSoTienNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNgayThuTien);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.btnMaKhachHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhieuThu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 193);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phiếu thu";
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Location = new System.Drawing.Point(193, 122);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.ReadOnly = true;
            this.txtSoTienNo.Size = new System.Drawing.Size(162, 26);
            this.txtSoTienNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tiền nợ:";
            // 
            // frmLapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(750, 487);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Thu Tiền";
            this.Load += new System.EventHandler(this.frmLapPhieuThuTien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThuTien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DateTimePicker dtpNgayThuTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnMaKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuThuTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhongluu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienThu;
        private System.Windows.Forms.TextBox txtSoTienNo;
        private System.Windows.Forms.Label label3;
    }
}