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
    public partial class frmDangNhap : Form
    {
        DangNhap_DTO ObjDangnhap = new DangNhap_DTO();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //Cái này là ủy quyền
        public delegate void RunMAIN(int Quyen);
        public RunMAIN Run_MAIN;

        public static string taiKhoan;
        public static string matKhau;
        public static string maQuyen;

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ObjDangnhap.TaiKhoan = txtTaiKhoan.Text;
            ObjDangnhap.MatKhau = txtMatKhau.Text;

            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTaiKhoan.Text == "")
                    txtTaiKhoan.Focus();
                else txtMatKhau.Focus();
            }
            else
            {
                if (DangNhap_BUS.Kiemtrataikhoan_bool(ObjDangnhap) == true)
                {

                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";

                    taiKhoan = ObjDangnhap.TaiKhoan;
                    matKhau = ObjDangnhap.MatKhau;
                    maQuyen = DangNhap_BUS.Maquyen_string(ObjDangnhap);

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Run_MAIN(int.Parse(maQuyen));

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
        }

    }
}
