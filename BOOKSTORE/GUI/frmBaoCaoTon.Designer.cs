namespace GUI
{
    partial class frmBaoCaoTon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTon = new System.Windows.Forms.DataGridView();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm:";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(343, 69);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(114, 26);
            this.txtThang.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(539, 69);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(114, 26);
            this.txtNam.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.dgvTon);
            this.groupBox1.Location = new System.Drawing.Point(13, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tồn";
            // 
            // dgvTon
            // 
            this.dgvTon.AllowUserToAddRows = false;
            this.dgvTon.AllowUserToDeleteRows = false;
            this.dgvTon.AllowUserToResizeColumns = false;
            this.dgvTon.AllowUserToResizeRows = false;
            this.dgvTon.BackgroundColor = System.Drawing.Color.White;
            this.dgvTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThang,
            this.colNam,
            this.colMaSach,
            this.colTonDau,
            this.colPhatSinh,
            this.colTonCuoi});
            this.dgvTon.GridColor = System.Drawing.Color.Black;
            this.dgvTon.Location = new System.Drawing.Point(0, 26);
            this.dgvTon.Name = "dgvTon";
            this.dgvTon.Size = new System.Drawing.Size(896, 227);
            this.dgvTon.TabIndex = 0;
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
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaSach.Width = 200;
            // 
            // colTonDau
            // 
            this.colTonDau.DataPropertyName = "TonDau";
            this.colTonDau.HeaderText = "Tồn đầu";
            this.colTonDau.Name = "colTonDau";
            this.colTonDau.ReadOnly = true;
            this.colTonDau.Width = 150;
            // 
            // colPhatSinh
            // 
            this.colPhatSinh.DataPropertyName = "PhatSinh";
            this.colPhatSinh.HeaderText = "Phát sinh";
            this.colPhatSinh.Name = "colPhatSinh";
            this.colPhatSinh.ReadOnly = true;
            this.colPhatSinh.Width = 150;
            // 
            // colTonCuoi
            // 
            this.colTonCuoi.DataPropertyName = "TonCuoi";
            this.colTonCuoi.HeaderText = "Tồn cuối";
            this.colTonCuoi.Name = "colTonCuoi";
            this.colTonCuoi.ReadOnly = true;
            this.colTonCuoi.Width = 150;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(394, 118);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(109, 36);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(378, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "BÁO CÁO TỒN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(834, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCaoTon
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
            this.Name = "frmBaoCaoTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tồn";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTon;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonCuoi;
    }
}