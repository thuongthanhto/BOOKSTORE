namespace GUI
{
    partial class frmDoiMatKhau
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
            this.txtReMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.butThoat = new System.Windows.Forms.Button();
            this.butXoatrang = new System.Windows.Forms.Button();
            this.butDoiMK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReMKmoi
            // 
            this.txtReMKmoi.Location = new System.Drawing.Point(202, 93);
            this.txtReMKmoi.Name = "txtReMKmoi";
            this.txtReMKmoi.Size = new System.Drawing.Size(219, 26);
            this.txtReMKmoi.TabIndex = 11;
            this.txtReMKmoi.UseSystemPasswordChar = true;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(202, 61);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(219, 26);
            this.txtMKmoi.TabIndex = 8;
            this.txtMKmoi.UseSystemPasswordChar = true;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(202, 29);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(219, 26);
            this.txtMKcu.TabIndex = 6;
            this.txtMKcu.UseSystemPasswordChar = true;
            // 
            // butThoat
            // 
            this.butThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.butThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThoat.ForeColor = System.Drawing.Color.White;
            this.butThoat.Location = new System.Drawing.Point(319, 137);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(100, 38);
            this.butThoat.TabIndex = 13;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = false;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // butXoatrang
            // 
            this.butXoatrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.butXoatrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butXoatrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoatrang.ForeColor = System.Drawing.Color.White;
            this.butXoatrang.Location = new System.Drawing.Point(211, 137);
            this.butXoatrang.Name = "butXoatrang";
            this.butXoatrang.Size = new System.Drawing.Size(106, 38);
            this.butXoatrang.TabIndex = 14;
            this.butXoatrang.Text = "Xóa Trắng";
            this.butXoatrang.UseVisualStyleBackColor = false;
            this.butXoatrang.Click += new System.EventHandler(this.butXoatrang_Click);
            // 
            // butDoiMK
            // 
            this.butDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.butDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDoiMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDoiMK.ForeColor = System.Drawing.Color.White;
            this.butDoiMK.Location = new System.Drawing.Point(59, 137);
            this.butDoiMK.Name = "butDoiMK";
            this.butDoiMK.Size = new System.Drawing.Size(150, 38);
            this.butDoiMK.TabIndex = 12;
            this.butDoiMK.Text = "Đổi mật khẩu";
            this.butDoiMK.UseVisualStyleBackColor = false;
            this.butDoiMK.Click += new System.EventHandler(this.butDoiMK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(473, 204);
            this.Controls.Add(this.txtReMKmoi);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butXoatrang);
            this.Controls.Add(this.butDoiMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoiMatKhau_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReMKmoi;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button butXoatrang;
        private System.Windows.Forms.Button butDoiMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}