namespace GUI
{
    partial class frmDanhSachSach
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThongTinSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdTacGia = new System.Windows.Forms.RadioButton();
            this.rdTenSach = new System.Windows.Forms.RadioButton();
            this.cboTimTheLoai = new System.Windows.Forms.ComboBox();
            this.rdNhaXuatBan = new System.Windows.Forms.RadioButton();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1071, 462);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 34);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(949, 461);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(98, 35);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.txtThongTinSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(99, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtThongTinSach
            // 
            this.txtThongTinSach.Location = new System.Drawing.Point(143, 50);
            this.txtThongTinSach.Name = "txtThongTinSach";
            this.txtThongTinSach.Size = new System.Drawing.Size(139, 26);
            this.txtThongTinSach.TabIndex = 1;
            this.txtThongTinSach.TextChanged += new System.EventHandler(this.txtThongTinSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ khóa tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(501, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "DANH SÁCH SÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1159, 222);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sách";
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
            this.colTenSach,
            this.colTacGia,
            this.colMaTheLoai,
            this.colNhaXuatBan,
            this.colNamXuatBan,
            this.colDonGiaBan,
            this.colSoLuongTon});
            this.dgvSach.Location = new System.Drawing.Point(6, 25);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSach.Size = new System.Drawing.Size(1147, 197);
            this.dgvSach.TabIndex = 2;
            this.dgvSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_RowEnter);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "MaDauSach";
            this.colTenSach.HeaderText = "Tên đầu sách";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            this.colTenSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenSach.Width = 150;
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            this.colTacGia.Width = 150;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.DataPropertyName = "MaTheLoai";
            this.colMaTheLoai.HeaderText = "Thể loại";
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.ReadOnly = true;
            this.colMaTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaTheLoai.Width = 150;
            // 
            // colNhaXuatBan
            // 
            this.colNhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.colNhaXuatBan.HeaderText = "Nhà xuất bản";
            this.colNhaXuatBan.Name = "colNhaXuatBan";
            this.colNhaXuatBan.ReadOnly = true;
            this.colNhaXuatBan.Width = 130;
            // 
            // colNamXuatBan
            // 
            this.colNamXuatBan.DataPropertyName = "NamXuatBan";
            this.colNamXuatBan.HeaderText = "Năm xuất bản";
            this.colNamXuatBan.Name = "colNamXuatBan";
            this.colNamXuatBan.ReadOnly = true;
            this.colNamXuatBan.Width = 130;
            // 
            // colDonGiaBan
            // 
            this.colDonGiaBan.DataPropertyName = "DonGiaBan";
            this.colDonGiaBan.HeaderText = "Giá bán";
            this.colDonGiaBan.Name = "colDonGiaBan";
            this.colDonGiaBan.ReadOnly = true;
            this.colDonGiaBan.Width = 150;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.rdNhaXuatBan);
            this.groupBox3.Controls.Add(this.cboTimTheLoai);
            this.groupBox3.Controls.Add(this.rdTenSach);
            this.groupBox3.Controls.Add(this.rdTacGia);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(437, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 116);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể loại:";
            // 
            // rdTacGia
            // 
            this.rdTacGia.AutoSize = true;
            this.rdTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTacGia.ForeColor = System.Drawing.Color.White;
            this.rdTacGia.Location = new System.Drawing.Point(341, 52);
            this.rdTacGia.Name = "rdTacGia";
            this.rdTacGia.Size = new System.Drawing.Size(75, 23);
            this.rdTacGia.TabIndex = 5;
            this.rdTacGia.TabStop = true;
            this.rdTacGia.Text = "Tác giả";
            this.rdTacGia.UseVisualStyleBackColor = true;
            this.rdTacGia.CheckedChanged += new System.EventHandler(this.rdTacGia_CheckedChanged);
            // 
            // rdTenSach
            // 
            this.rdTenSach.AutoSize = true;
            this.rdTenSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenSach.ForeColor = System.Drawing.Color.White;
            this.rdTenSach.Location = new System.Drawing.Point(418, 53);
            this.rdTenSach.Name = "rdTenSach";
            this.rdTenSach.Size = new System.Drawing.Size(86, 23);
            this.rdTenSach.TabIndex = 6;
            this.rdTenSach.TabStop = true;
            this.rdTenSach.Text = "Tên sách";
            this.rdTenSach.UseVisualStyleBackColor = true;
            this.rdTenSach.CheckedChanged += new System.EventHandler(this.rdTenSach_CheckedChanged);
            // 
            // cboTimTheLoai
            // 
            this.cboTimTheLoai.FormattingEnabled = true;
            this.cboTimTheLoai.Location = new System.Drawing.Point(104, 50);
            this.cboTimTheLoai.Name = "cboTimTheLoai";
            this.cboTimTheLoai.Size = new System.Drawing.Size(197, 27);
            this.cboTimTheLoai.TabIndex = 3;
            this.cboTimTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTimTheLoai_SelectedIndexChanged);
            // 
            // rdNhaXuatBan
            // 
            this.rdNhaXuatBan.AutoSize = true;
            this.rdNhaXuatBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdNhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNhaXuatBan.ForeColor = System.Drawing.Color.White;
            this.rdNhaXuatBan.Location = new System.Drawing.Point(505, 53);
            this.rdNhaXuatBan.Name = "rdNhaXuatBan";
            this.rdNhaXuatBan.Size = new System.Drawing.Size(115, 23);
            this.rdNhaXuatBan.TabIndex = 7;
            this.rdNhaXuatBan.TabStop = true;
            this.rdNhaXuatBan.Text = "Nhà xuất bản";
            this.rdNhaXuatBan.UseVisualStyleBackColor = true;
            this.rdNhaXuatBan.CheckedChanged += new System.EventHandler(this.rdNhaXuatBan_CheckedChanged);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(760, 461);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(161, 35);
            this.btnHienThiTatCa.TabIndex = 5;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // frmDanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1198, 519);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnChon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhSachSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sách";
            this.Load += new System.EventHandler(this.frmDanhSachSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThongTinSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdNhaXuatBan;
        private System.Windows.Forms.ComboBox cboTimTheLoai;
        private System.Windows.Forms.RadioButton rdTenSach;
        private System.Windows.Forms.RadioButton rdTacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHienThiTatCa;
    }
}