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
    public partial class frmDanhSachKhachHang : Form
    {
        private static string maKH;//Dùng để lấy mã khách hàng truyền cho form HoaDonBanSach và form LapPhieuThuTien
        private static string soTienNo;
        public frmDanhSachKhachHang()
        {
            InitializeComponent();
        }
        public void HienThiDanhSach()
        {
            dgvKhachHang.DataSource = KhachHang_BUS.GetKhachHangAll();
        }

        private void frmDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }        
        public void TimKiemTenKhachHang()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.TenKhachHang = txtTimKiem.Text;
            dgvKhachHang.DataSource = KhachHang_BUS.SelectKhachHangLikeTen(kh);
        }
        public void TimKiemDiaChi()
        {

            KhachHang_DTO kh = new KhachHang_DTO();
            kh.DiaChi = txtTimKiem.Text;
            dgvKhachHang.DataSource = KhachHang_BUS.SelectKhachHangLikeDiaChi(kh);
        }
        public void TimKiemEmail()
        {

            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Email = txtTimKiem.Text;
            dgvKhachHang.DataSource = KhachHang_BUS.SelectKhachHangLikeEmail(kh);
        }
        public void TimKiemDienThoai()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SDT = txtTimKiem.Text;
            dgvKhachHang.DataSource = KhachHang_BUS.SelectKhachHangLikeDienThoai(kh);
        }
        private void rdTenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemTenKhachHang();
        }

        private void rdDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemDiaChi();
        }

        private void rdEmail_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemEmail();
        }

        private void rdDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            TimKiemDienThoai();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTenKhachHang.Checked == true)
            {
                TimKiemTenKhachHang();
            }
            if (rdDiaChi.Checked == true)
            {
                TimKiemDiaChi();
            }
            if (rdDienThoai.Checked == true)
            {
                TimKiemDienThoai();
            }
            if (rdEmail.Checked == true)
            {
                TimKiemEmail();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frmHoaDonBanSach.maKH = maKH;
            frmLapPhieuThuTien.maKH = maKH;
            frmLapPhieuThuTien.soTienNo = soTienNo;
            this.Close();
        }

        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            maKH = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            soTienNo = dgvKhachHang.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

    }
}
