namespace GUI
{
    partial class frmBaoCaoCongNo
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(836, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 36);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(351, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "BÁO CÁO CÔNG NỢ";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(400, 124);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(109, 36);
            this.btnBaoCao.TabIndex = 14;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.dgvCongNo);
            this.groupBox1.Location = new System.Drawing.Point(15, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 259);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin công nợ";
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AllowUserToAddRows = false;
            this.dgvCongNo.AllowUserToDeleteRows = false;
            this.dgvCongNo.AllowUserToResizeColumns = false;
            this.dgvCongNo.AllowUserToResizeRows = false;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThang,
            this.colNam,
            this.colMaKhachHang,
            this.colNoDau,
            this.colPhatSinh,
            this.colNoCuoi});
            this.dgvCongNo.Location = new System.Drawing.Point(0, 26);
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.Size = new System.Drawing.Size(896, 227);
            this.dgvCongNo.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(541, 75);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(114, 26);
            this.txtNam.TabIndex = 11;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(345, 75);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(114, 26);
            this.txtThang.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tháng:";
            // 
            // colThang
            // 
            this.colThang.DataPropertyName = "Thang";
            this.colThang.HeaderText = "Tháng";
            this.colThang.Name = "colThang";
            this.colThang.ReadOnly = true;
            // 
            // colNam
            // 
            this.colNam.DataPropertyName = "Nam";
            this.colNam.HeaderText = "Năm";
            this.colNam.Name = "colNam";
            this.colNam.ReadOnly = true;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.DataPropertyName = "MaKhachHang";
            this.colMaKhachHang.HeaderText = "Mã khách hàng";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.ReadOnly = true;
            this.colMaKhachHang.Width = 200;
            // 
            // colNoDau
            // 
            this.colNoDau.DataPropertyName = "NoDau";
            this.colNoDau.HeaderText = "Nợ đầu";
            this.colNoDau.Name = "colNoDau";
            this.colNoDau.ReadOnly = true;
            this.colNoDau.Width = 150;
            // 
            // colPhatSinh
            // 
            this.colPhatSinh.DataPropertyName = "PhatSinh";
            this.colPhatSinh.HeaderText = "Phát sinh";
            this.colPhatSinh.Name = "colPhatSinh";
            this.colPhatSinh.ReadOnly = true;
            this.colPhatSinh.Width = 150;
            // 
            // colNoCuoi
            // 
            this.colNoCuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoCuoi.DataPropertyName = "NoCuoi";
            this.colNoCuoi.HeaderText = "Nợ cuối";
            this.colNoCuoi.Name = "colNoCuoi";
            this.colNoCuoi.ReadOnly = true;
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(940, 479);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoCaoCongNo";
            this.Text = "Báo Cáo Công Nợ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCongNo;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoCuoi;
    }
}