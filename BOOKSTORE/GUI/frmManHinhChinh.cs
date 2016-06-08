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
    public partial class frmManHinhChinh : Form
    {
        DangNhap_DTO Main = new DangNhap_DTO();
        public frmManHinhChinh()
        {
            InitializeComponent();
        }
        public void hienthi(int q)
        {
            if (q == 1)
            {
                baoCaoTônToolStripMenuItem.Enabled = true;
                danhSachKhachHangToolStripMenuItem1.Enabled = true;
                baoCaoCôngNơToolStripMenuItem.Enabled = true;
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = true;
                khachHangToolStripMenuItem.Enabled = true;
                hoaĐơnBanSachToolStripMenuItem.Enabled = true;
                thêLoaiToolStripMenuItem.Enabled = true;
                phiêuNhâpSachToolStripMenuItem.Enabled = true;
                quanLyĐâuSachToolStripMenuItem.Enabled = true;
                quanLySachToolStripMenuItem.Enabled = true;

                đăngNhâpToolStripMenuItem.Enabled = false;
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
                đôiMâtKhâuToolStripMenuItem.Enabled = true;
                quanLyTaiKhoanToolStripMenuItem.Enabled = true;
                quanLyToolStripMenuItem.Enabled = true;
                traCưuToolStripMenuItem.Enabled = true;
                lâpBaoCaoToolStripMenuItem.Enabled = true;              
            }
            else if (q == 2)
            {
                khachHangToolStripMenuItem.Enabled = true;
                hoaĐơnBanSachToolStripMenuItem.Enabled = true;
                quanLyTaiKhoanToolStripMenuItem.Enabled = true;
                đăngNhâpToolStripMenuItem.Enabled = true;
                danhSachKhachHangToolStripMenuItem1.Enabled = true;
                baoCaoCôngNơToolStripMenuItem.Enabled = true;
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = true;
                phiêuNhâpSachToolStripMenuItem.Enabled = true;
                quanLySachToolStripMenuItem.Enabled = true;
                quanLyĐâuSachToolStripMenuItem.Enabled = true;
                thêLoaiToolStripMenuItem.Enabled = true;

             
                đăngXuâtToolStripMenuItem.Enabled = true;
                đôiMâtKhâuToolStripMenuItem.Enabled = true;
                quanLyTaiKhoanToolStripMenuItem.Enabled = true;
                quanLyToolStripMenuItem.Enabled = true;
                traCưuToolStripMenuItem.Enabled = true;
                lâpBaoCaoToolStripMenuItem.Enabled = true;    

                khachHangToolStripMenuItem.Enabled = false;
                hoaĐơnBanSachToolStripMenuItem.Enabled = false;
                quanLyTaiKhoanToolStripMenuItem.Enabled = false;
                đăngNhâpToolStripMenuItem.Enabled = false;
                danhSachKhachHangToolStripMenuItem1.Enabled = false;
                baoCaoCôngNơToolStripMenuItem.Enabled = false;
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = false;
            }
            else if (q == 3)
            {
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = true;
                đăngXuâtToolStripMenuItem.Enabled = true;
                đôiMâtKhâuToolStripMenuItem.Enabled = true;
                quanLyTaiKhoanToolStripMenuItem.Enabled = true;
                quanLyToolStripMenuItem.Enabled = true;
                traCưuToolStripMenuItem.Enabled = true;
                lâpBaoCaoToolStripMenuItem.Enabled = true;
                danhSachKhachHangToolStripMenuItem1.Enabled = true;
                khachHangToolStripMenuItem.Enabled = true;
                hoaĐơnBanSachToolStripMenuItem.Enabled = true;


                quanLyTaiKhoanToolStripMenuItem.Enabled = false;
                đăngNhâpToolStripMenuItem.Enabled = false;
                baoCaoTônToolStripMenuItem.Enabled = false;
                baoCaoCôngNơToolStripMenuItem.Enabled = false;
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = false;
                phiêuNhâpSachToolStripMenuItem.Enabled = false;
                quanLySachToolStripMenuItem.Enabled = false;
                quanLyĐâuSachToolStripMenuItem.Enabled = false;
                thêLoaiToolStripMenuItem.Enabled = false;
            }
            else
            {
                đăngNhâpToolStripMenuItem.Enabled = true;
                thayĐôiQuyĐinhToolStripMenuItem.Enabled = false;
                đăngXuâtToolStripMenuItem.Enabled = false;
                đôiMâtKhâuToolStripMenuItem.Enabled = false;
                quanLyTaiKhoanToolStripMenuItem.Enabled = false;
                quanLyToolStripMenuItem.Enabled = false;
                traCưuToolStripMenuItem.Enabled = false;
                lâpBaoCaoToolStripMenuItem.Enabled = false;
            }
        }
        private void thayĐôiQuyĐinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quanLyThêLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTheLoai frm = new frmQuanLyTheLoai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quanLyĐâuSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDauSach frm = new frmQuanLyDauSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachDauSach frm = new frmDanhSachDauSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSachSachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDanhSachSach frm = new frmDanhSachSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSachKhachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDanhSachKhachHang frm = new frmDanhSachKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phiêuNhâpSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapSach frm = new frmLapPhieuNhapSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hoaĐơnBanSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBanSach frm = new frmHoaDonBanSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void baoCaoTônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTon frm = new frmBaoCaoTon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void baoCaoCôngNơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoCongNo frm = new frmBaoCaoCongNo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lâpPhiêuThuTiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapPhieuThuTien frm = new frmLapPhieuThuTien();
            frm.MdiParent = this;
            frm.Show();
        }
        //Cập nhật tồn đầu
        public void CapNhatTonDau()
        {
            BaoCaoTon_DTO r = new BaoCaoTon_DTO();
            r.Thang = DateTime.Now.Month;
            r.Nam = DateTime.Now.Year;
            DataTable dt = BaoCaoTon_BUS.GetMaSach();
            int n = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i<n; i++)
                {
                    r.MaSach = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                    if (BaoCaoTon_BUS.CheckThongTin(r) == false)
                    {
                        r.TonDau = BaoCaoTon_BUS.GetSoLuongTon(r.MaSach);
                        string ketQua = BaoCaoTon_BUS.ThemTonDau(r);
                        if (ketQua != "Success")
                        {
                            MessageBox.Show(ketQua);
                            return;
                        }
                    }
                }
            }
        }
        public void CapNhatNoDau()
        {
            BaoCaoCongNo_DTO r = new BaoCaoCongNo_DTO();
            r.Thang = DateTime.Now.Month;
            r.Nam = DateTime.Now.Year;
            DataTable dt = BaoCaoCongNo_BUS.GetMaKhachHang();
            int n = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    r.MaKhachHang = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                    if (BaoCaoCongNo_BUS.CheckThongTin(r) == false)
                    {
                        r.NoDau = BaoCaoCongNo_BUS.GetSoTienNo(r.MaKhachHang);
                        string ketQua = BaoCaoCongNo_BUS.ThemTonDau(r);
                        if (ketQua != "Success")
                        {
                            MessageBox.Show(ketQua);
                            return;
                        }
                    }
                }
            }
        }
        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            CapNhatTonDau();
            CapNhatNoDau();
            //Hiển thị với quyền 4 (ko có trong CSDL <=> Khách)
            hienthi(4);
            Program.frm_Dangnhap.MdiParent = this;
            Program.frm_Dangnhap.Run_MAIN = new frmDangNhap.RunMAIN(hienthi);
            Program.frm_Dangnhap.Show();
        }

        private void đăngNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_Dangnhap.MdiParent = this;
            Program.frm_Dangnhap.Run_MAIN = new frmDangNhap.RunMAIN(hienthi);
            Program.frm_Dangnhap.Show(); 
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_Doimatkhau.MdiParent = this;
            Program.frm_Doimatkhau.Show();
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frm_Quanlytaikhoan.MdiParent = this;
            Program.frm_Quanlytaikhoan.Show();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Đóng tất cả các form đang chạy
            //Duyệt qua tất cả các form là form con của form đang chạy rồi đóng
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }

            hienthi(4);
            Program.frm_Dangnhap.MdiParent = this;
            Program.frm_Dangnhap.Run_MAIN = new frmDangNhap.RunMAIN(hienthi);

            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Program.frm_Dangnhap.Show();
        }
        public void CapNhatPhatSinhTonCuoi()
        {
            BaoCaoTon_DTO r = new BaoCaoTon_DTO();
            r.Thang = DateTime.Now.Month;
            r.Nam = DateTime.Now.Year;
            DataTable dt = BaoCaoTon_BUS.GetMaSach();
            int n = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    r.MaSach = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                    r.TonCuoi = BaoCaoTon_BUS.GetSoLuongTon(r.MaSach);
                    r.PhatSinh = BaoCaoTon_BUS.GetPhatSinh(r.Thang, r.Nam, r.MaSach);
                    if (BaoCaoTon_BUS.CheckThongTin(r) == false)
                    {
                        string ketQua = BaoCaoTon_BUS.ThemTonCuoiPhatSinh(r);
                        if (ketQua != "Success")
                        {
                            MessageBox.Show(ketQua);
                            return;
                        }
                    }
                    else
                    {
                        string ketQua = BaoCaoTon_BUS.CapNhatTonCuoiPhatSinh(r);
                        if (ketQua != "Success")
                        {
                            MessageBox.Show(ketQua);
                            return;
                        }
                    }
                }
            }            
        }
        public void CapNhatPhatSinhNoCuoi()
        {
            BaoCaoCongNo_DTO r = new BaoCaoCongNo_DTO();
            r.Thang = DateTime.Now.Month;
            r.Nam = DateTime.Now.Year;
            DataTable dt = BaoCaoCongNo_BUS.GetMaKhachHang();
            int n = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    r.MaKhachHang = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                    r.NoCuoi = BaoCaoCongNo_BUS.GetSoTienNo(r.MaKhachHang);
                    r.PhatSinh = BaoCaoCongNo_BUS.GetPhatSinh(r.Thang, r.Nam, r.MaKhachHang);
                    if (BaoCaoCongNo_BUS.CheckThongTin(r) == false)
                    {
                        string ketQua = BaoCaoCongNo_BUS.ThemNoCuoiPhatSinh(r);
                        if (ketQua != "Success")
                        {
                            MessageBox.Show(ketQua);
                            return;
                        }
                    }
                    else
                    {
                        string ketQua = BaoCaoCongNo_BUS.CapNhatNoCuoiPhatSinh(r);
                        if (ketQua != "Success")
                        {
                            MessageBox.Show(ketQua);
                            return;
                        }
                    }

                }
            }
        }
        
        private void frmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            CapNhatPhatSinhTonCuoi();
            CapNhatPhatSinhNoCuoi();
            foreach (Form frm in this.MdiChildren)
                frm.Hide();
        }

        private void trơGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTroGiup f = new frmTroGiup();
            f.Show();
        }
    }
}
