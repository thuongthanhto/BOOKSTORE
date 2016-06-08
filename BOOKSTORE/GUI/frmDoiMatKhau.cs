using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        DoiMatKhau_BUS LogicDoimatkhau = new DoiMatKhau_BUS();
        DoiMatKhau_DTO ObjDoimatkhau = new DoiMatKhau_DTO();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butXoatrang_Click(object sender, EventArgs e)
        {
            txtMKcu.Text = "";
            txtMKmoi.Text = "";
            txtReMKmoi.Text = "";
        }

        private void butDoiMK_Click(object sender, EventArgs e)
        {
            ObjDoimatkhau.TaiKhoan = frmDangNhap.taiKhoan;
            ObjDoimatkhau.MatKhauCu = txtMKcu.Text;
            ObjDoimatkhau.MatKhauMoi = txtMKmoi.Text;
            ObjDoimatkhau.NhapLaiMatKhauMoi = txtReMKmoi.Text;

            if (txtMKcu.Text == "" || txtMKmoi.Text == "" || txtReMKmoi.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtMKcu.Text == "")
                    txtMKcu.Focus();
                else
                    if (txtMKmoi.Text == "")
                        txtMKmoi.Focus();
                    else
                        txtReMKmoi.Focus();
            }
            else
            {
                if (txtMKcu.Text != DoiMatKhau_BUS.Matkhau_string(ObjDoimatkhau))
                {
                    MessageBox.Show("Mật khẩu cũ nhập không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKcu.Text = "";
                    txtMKcu.Focus();
                }
                else
                {
                    if (txtMKmoi.Text != txtReMKmoi.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtReMKmoi.Text = "";
                        txtReMKmoi.Focus();
                    }
                    else
                    {
                        if (DoiMatKhau_BUS.Doimatkhau_bool(ObjDoimatkhau) == "Success")
                        {
                            txtMKcu.Text = "";
                            txtMKmoi.Text = "";
                            txtReMKmoi.Text = "";
                            DialogResult r = MessageBox.Show("Đã đổi mật khẩu thành công","Thành Công",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                            if (r == DialogResult.OK)
                                Close();
                        }
                    }
                }
            }
        }
    }
}
