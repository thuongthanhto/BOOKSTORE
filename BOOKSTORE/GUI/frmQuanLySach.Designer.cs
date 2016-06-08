namespace GUI
{
    partial class frmQuanLySach
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDauSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKhongluu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaDauSach = new System.Windows.Forms.Button();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtMaDauSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.dgvSach);
            this.groupBox4.Location = new System.Drawing.Point(27, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1125, 190);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết về cuốn sách";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenDauSach,
            this.colMaTheLoai,
            this.colNhaXuatBan,
            this.colNamXuatBan,
            this.colSoLuongTon,
            this.colDonGiaBan});
            this.dgvSach.Location = new System.Drawing.Point(0, 25);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSach.Size = new System.Drawing.Size(1125, 165);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_RowEnter);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            // 
            // colTenDauSach
            // 
            this.colTenDauSach.DataPropertyName = "MaDauSach";
            this.colTenDauSach.HeaderText = "Tên đầu sách";
            this.colTenDauSach.Name = "colTenDauSach";
            this.colTenDauSach.ReadOnly = true;
            this.colTenDauSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenDauSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenDauSach.Width = 200;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.DataPropertyName = "MaTheLoai";
            this.colMaTheLoai.HeaderText = "Thể loại";
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.ReadOnly = true;
            this.colMaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaTheLoai.Width = 170;
            // 
            // colNhaXuatBan
            // 
            this.colNhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.colNhaXuatBan.HeaderText = "Nhà xuất bản";
            this.colNhaXuatBan.Name = "colNhaXuatBan";
            this.colNhaXuatBan.ReadOnly = true;
            this.colNhaXuatBan.Width = 170;
            // 
            // colNamXuatBan
            // 
            this.colNamXuatBan.DataPropertyName = "NamXuatBan";
            this.colNamXuatBan.HeaderText = "Năm xuất bản";
            this.colNamXuatBan.Name = "colNamXuatBan";
            this.colNamXuatBan.ReadOnly = true;
            this.colNamXuatBan.Width = 130;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Width = 150;
            // 
            // colDonGiaBan
            // 
            this.colDonGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDonGiaBan.DataPropertyName = "DonGiaBan";
            this.colDonGiaBan.HeaderText = "Giá bán";
            this.colDonGiaBan.Name = "colDonGiaBan";
            this.colDonGiaBan.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.btnKhongluu);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(816, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 155);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnKhongluu
            // 
            this.btnKhongluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnKhongluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongluu.ForeColor = System.Drawing.Color.White;
            this.btnKhongluu.Location = new System.Drawing.Point(145, 90);
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
            this.btnLuu.Location = new System.Drawing.Point(27, 90);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(145, 47);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 37);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(27, 47);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.btnMaDauSach);
            this.groupBox1.Controls.Add(this.txtNamXuatBan);
            this.groupBox1.Controls.Add(this.txtNhaXuatBan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.txtMaDauSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Location = new System.Drawing.Point(80, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sách";
            // 
            // btnMaDauSach
            // 
            this.btnMaDauSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnMaDauSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaDauSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaDauSach.ForeColor = System.Drawing.Color.White;
            this.btnMaDauSach.Location = new System.Drawing.Point(314, 66);
            this.btnMaDauSach.Name = "btnMaDauSach";
            this.btnMaDauSach.Size = new System.Drawing.Size(66, 29);
            this.btnMaDauSach.TabIndex = 24;
            this.btnMaDauSach.Text = "Chọn";
            this.btnMaDauSach.UseVisualStyleBackColor = false;
            this.btnMaDauSach.Click += new System.EventHandler(this.btnMaDauSach_Click);
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(496, 106);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(148, 26);
            this.txtNamXuatBan.TabIndex = 23;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(160, 106);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(144, 26);
            this.txtNhaXuatBan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Năm xuất bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nhà xuất bản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = " (Auto)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giá bán:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoLuongTon.Enabled = false;
            this.txtSoLuongTon.Location = new System.Drawing.Point(496, 69);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(148, 26);
            this.txtSoLuongTon.TabIndex = 15;
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaDauSach.Enabled = false;
            this.txtMaDauSach.Location = new System.Drawing.Point(160, 69);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.ReadOnly = true;
            this.txtMaDauSach.Size = new System.Drawing.Size(144, 26);
            this.txtMaDauSach.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã đầu sách:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(496, 34);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(148, 26);
            this.txtGiaBan.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(160, 34);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(144, 26);
            this.txtMaSach.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(486, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1055, 452);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(111, 42);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1178, 506);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLySach_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtMaDauSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaDauSach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenDauSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private System.Windows.Forms.Button btnKhongluu;
        private System.Windows.Forms.Button btnLuu;
    }
}