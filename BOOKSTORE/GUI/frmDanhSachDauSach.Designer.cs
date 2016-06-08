namespace GUI
{
    partial class frmDanhSachDauSach
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTenSach = new System.Windows.Forms.RadioButton();
            this.cboTimTheLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThongTinSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCTTacGia = new System.Windows.Forms.DataGridView();
            this.colMaDauSachCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTacGia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(815, 374);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(692, 374);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(98, 35);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.dgvDauSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết về đầu sách";
            // 
            // dgvDauSach
            // 
            this.dgvDauSach.AllowUserToAddRows = false;
            this.dgvDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.colTheLoai});
            this.dgvDauSach.Location = new System.Drawing.Point(6, 25);
            this.dgvDauSach.MultiSelect = false;
            this.dgvDauSach.Name = "dgvDauSach";
            this.dgvDauSach.ReadOnly = true;
            this.dgvDauSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDauSach.Size = new System.Drawing.Size(526, 165);
            this.dgvDauSach.TabIndex = 0;
            this.dgvDauSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDauSach_RowEnter);
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            this.MaDauSach.Width = 130;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            this.TenDauSach.Width = 200;
            // 
            // colTheLoai
            // 
            this.colTheLoai.DataPropertyName = "MaTheLoai";
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            this.colTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTheLoai.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.txtThongTinSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(82, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdTenSach
            // 
            this.rdTenSach.AutoSize = true;
            this.rdTenSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenSach.ForeColor = System.Drawing.Color.White;
            this.rdTenSach.Location = new System.Drawing.Point(234, 37);
            this.rdTenSach.Name = "rdTenSach";
            this.rdTenSach.Size = new System.Drawing.Size(114, 23);
            this.rdTenSach.TabIndex = 6;
            this.rdTenSach.TabStop = true;
            this.rdTenSach.Text = "Tên đầu sách";
            this.rdTenSach.UseVisualStyleBackColor = true;
            this.rdTenSach.CheckedChanged += new System.EventHandler(this.rdTenSach_CheckedChanged);
            // 
            // cboTimTheLoai
            // 
            this.cboTimTheLoai.FormattingEnabled = true;
            this.cboTimTheLoai.Location = new System.Drawing.Point(88, 34);
            this.cboTimTheLoai.Name = "cboTimTheLoai";
            this.cboTimTheLoai.Size = new System.Drawing.Size(115, 27);
            this.cboTimTheLoai.TabIndex = 3;
            this.cboTimTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTimTheLoai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể loại:";
            // 
            // txtThongTinSach
            // 
            this.txtThongTinSach.Location = new System.Drawing.Point(180, 34);
            this.txtThongTinSach.Name = "txtThongTinSach";
            this.txtThongTinSach.Size = new System.Drawing.Size(139, 26);
            this.txtThongTinSach.TabIndex = 1;
            this.txtThongTinSach.TextChanged += new System.EventHandler(this.txtThongTinSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 37);
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
            this.label1.Location = new System.Drawing.Point(324, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH ĐẦU SÁCH";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.dgvCTTacGia);
            this.groupBox3.Location = new System.Drawing.Point(556, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 190);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết tác giả";
            // 
            // dgvCTTacGia
            // 
            this.dgvCTTacGia.AllowUserToAddRows = false;
            this.dgvCTTacGia.AllowUserToDeleteRows = false;
            this.dgvCTTacGia.AllowUserToResizeColumns = false;
            this.dgvCTTacGia.AllowUserToResizeRows = false;
            this.dgvCTTacGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDauSachCT,
            this.colTacGia});
            this.dgvCTTacGia.Location = new System.Drawing.Point(7, 25);
            this.dgvCTTacGia.Name = "dgvCTTacGia";
            this.dgvCTTacGia.Size = new System.Drawing.Size(349, 165);
            this.dgvCTTacGia.TabIndex = 0;
            // 
            // colMaDauSachCT
            // 
            this.colMaDauSachCT.DataPropertyName = "MaDauSach";
            this.colMaDauSachCT.HeaderText = "Mã đầu sách";
            this.colMaDauSachCT.Name = "colMaDauSachCT";
            this.colMaDauSachCT.ReadOnly = true;
            this.colMaDauSachCT.Width = 130;
            // 
            // colTacGia
            // 
            this.colTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác Giả";
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rdTenSach);
            this.groupBox4.Controls.Add(this.cboTimTheLoai);
            this.groupBox4.Location = new System.Drawing.Point(473, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 91);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm theo";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(530, 374);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(140, 35);
            this.btnHienThiTatCa.TabIndex = 8;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // frmDanhSachDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(930, 421);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhSachDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đầu Sách";
            this.Load += new System.EventHandler(this.frmDanhSachDauSach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTacGia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDauSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTenSach;
        private System.Windows.Forms.ComboBox cboTimTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThongTinSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCTTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSachCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHienThiTatCa;
    }
}