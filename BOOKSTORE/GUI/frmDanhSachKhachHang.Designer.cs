namespace GUI
{
    partial class frmDanhSachKhachHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdDiaChi = new System.Windows.Forms.RadioButton();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdDienThoai = new System.Windows.Forms.RadioButton();
            this.rdTenKhachHang = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(931, 428);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(108, 34);
            this.btnDong.TabIndex = 9;
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
            this.btnChon.Location = new System.Drawing.Point(818, 428);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(107, 34);
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.dgvKhachHang);
            this.groupBox3.Location = new System.Drawing.Point(19, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1011, 222);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DienThoai,
            this.DiaChi,
            this.Email,
            this.TienNo});
            this.dgvKhachHang.Location = new System.Drawing.Point(7, 26);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(998, 190);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_RowEnter);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã KH";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "SDT";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // TienNo
            // 
            this.TienNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienNo.DataPropertyName = "SoTienNo";
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(92, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ khóa:";
            // 
            // rdDiaChi
            // 
            this.rdDiaChi.AutoSize = true;
            this.rdDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDiaChi.ForeColor = System.Drawing.Color.White;
            this.rdDiaChi.Location = new System.Drawing.Point(44, 38);
            this.rdDiaChi.Name = "rdDiaChi";
            this.rdDiaChi.Size = new System.Drawing.Size(73, 23);
            this.rdDiaChi.TabIndex = 1;
            this.rdDiaChi.TabStop = true;
            this.rdDiaChi.Text = "Địa chỉ";
            this.rdDiaChi.UseVisualStyleBackColor = true;
            this.rdDiaChi.CheckedChanged += new System.EventHandler(this.rdDiaChi_CheckedChanged);
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEmail.ForeColor = System.Drawing.Color.White;
            this.rdEmail.Location = new System.Drawing.Point(153, 38);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(64, 23);
            this.rdEmail.TabIndex = 1;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = true;
            this.rdEmail.CheckedChanged += new System.EventHandler(this.rdEmail_CheckedChanged);
            // 
            // rdDienThoai
            // 
            this.rdDienThoai.AutoSize = true;
            this.rdDienThoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDienThoai.ForeColor = System.Drawing.Color.White;
            this.rdDienThoai.Location = new System.Drawing.Point(249, 38);
            this.rdDienThoai.Name = "rdDienThoai";
            this.rdDienThoai.Size = new System.Drawing.Size(95, 23);
            this.rdDienThoai.TabIndex = 1;
            this.rdDienThoai.TabStop = true;
            this.rdDienThoai.Text = "Điện thoại";
            this.rdDienThoai.UseVisualStyleBackColor = true;
            this.rdDienThoai.CheckedChanged += new System.EventHandler(this.rdDienThoai_CheckedChanged);
            // 
            // rdTenKhachHang
            // 
            this.rdTenKhachHang.AutoSize = true;
            this.rdTenKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenKhachHang.ForeColor = System.Drawing.Color.White;
            this.rdTenKhachHang.Location = new System.Drawing.Point(350, 38);
            this.rdTenKhachHang.Name = "rdTenKhachHang";
            this.rdTenKhachHang.Size = new System.Drawing.Size(132, 23);
            this.rdTenKhachHang.TabIndex = 1;
            this.rdTenKhachHang.TabStop = true;
            this.rdTenKhachHang.Text = "Tên khách hàng";
            this.rdTenKhachHang.UseVisualStyleBackColor = true;
            this.rdTenKhachHang.CheckedChanged += new System.EventHandler(this.rdTenKhachHang_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(84, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(208, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(342, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.rdEmail);
            this.groupBox2.Controls.Add(this.rdTenKhachHang);
            this.groupBox2.Controls.Add(this.rdDiaChi);
            this.groupBox2.Controls.Add(this.rdDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(434, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(647, 428);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(165, 34);
            this.btnHienThiTatCa.TabIndex = 10;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // frmDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1050, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.frmDanhSachKhachHang_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdDiaChi;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdDienThoai;
        private System.Windows.Forms.RadioButton rdTenKhachHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHienThiTatCa;
    }
}