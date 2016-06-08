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
    public partial class frmHoaDonBanSach : Form
    {
        public static string maKH;
        public static string maSach;
        public static string donGiaBan;
        public static int layMaHD;
        public frmHoaDonBanSach()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Size = new Size(570, 632);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1132, 632);
        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            this.Size = new Size(570, 632);
            HienThiDanhSachHoaDon();
            HienThiDanhSachChiTietHoaDon();
            gChucNangThanhToan.Enabled = false;
            gThanhToan.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void HienThiDanhSachHoaDon()
        {
            colMaKhachHang.ValueMember = "MaKhachHang";
            colMaKhachHang.DisplayMember = "TenKhachHang";
            colMaKhachHang.DataSource = KhachHang_BUS.GetKhachHangAll();

            dgvHoaDon.DataSource = HoaDon_BUS.SelectallHoaDon();
        }
        public void HienThiDanhSachChiTietHoaDon()
        {
            dgvChiTietHoaDon.DataSource = HoaDon_BUS.SelectHoaDonCTByMa(layMaHD);
        }        
        private void btnMaKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhSachKhachHang f = new frmDanhSachKhachHang();
            f.ShowDialog();//Lấy maKH từ form DanhSachKhachHang
            txtMaKhachHang.Text = maKH;            
        }
        
        private void btnMaSach_Click(object sender, EventArgs e)
        {
            frmDanhSachSach f = new frmDanhSachSach();
            f.ShowDialog();//Lấy maSach và donGiaBan từ form DanhSachSach
            txtMaSach.Text = maSach;
            txtDonGia.Text = donGiaBan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hd = new HoaDon_DTO();
            try
            {
                hd.MaKhachHang = int.Parse(txtMaKhachHang.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải chọn mã khách hàng từ danh sách khách hàng");
                btnMaKhachHang_Click(sender, e);
                return;
            }
            hd.TongTien = 0;
            hd.ThanhToan = 0;
            hd.ConLai = 0;
            //Vì trong sql ngày lưu dạng MM-dd-yy nên ta cần chuyển sang định dạng này mới lưu ngày chính sách được
            dtpNgayLapHD.Format = DateTimePickerFormat.Custom;
            dtpNgayLapHD.CustomFormat = "MM-dd-yy";
            hd.NgayLap = dtpNgayLapHD.Text;
            dtpNgayLapHD.Format = DateTimePickerFormat.Short;

            DataTable dt = ThamSo_BUS.GetThamSoAll();
            UInt64 noToiDa = UInt64.Parse(dt.Rows[0].ItemArray[5].ToString());//Số tiền nợ tối đa

            DataTable dt2 = ThamSo_BUS.SelectTienNoKH(int.Parse(txtMaKhachHang.Text));
            UInt64 tienNo = UInt64.Parse(dt2.Rows[0].ItemArray[5].ToString());
            if (tienNo > noToiDa)
            {
                MessageBox.Show("Số tiền nợ đã vượt quá số tiền nợ tối đa");
                return;
            }
            else
            {
                if (HoaDon_BUS.ThemHoaDon(hd) == false)
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
                HienThiDanhSachHoaDon();
                txtMaHoaDonCT.Text = txtMaHoaDon.Text;
                txtMaKhachHangCT.Text = txtMaKhachHangCT.Text;
                this.Size = new Size(1132, 632);
            }            
        }
        
        private void btnBoSung_Click(object sender, EventArgs e)
        {
            
            DataTable dt = ThamSo_BUS.GetThamSoAll();
            int noToiDa = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            int luongTonSauKhiBan = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            DataTable dt2 = ThamSo_BUS.SelectTienNoKH(int.Parse(txtMaKhachHangCT.Text));
            int tienNo = int.Parse(dt2.Rows[0].ItemArray[5].ToString());

            CT_HoaDon_DTO ct = new CT_HoaDon_DTO();
            try
            {
                ct.MaHD = int.Parse(txtMaHoaDonCT.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã hóa đơn không được để trống");
                return;
            }
            try
            {
                ct.MaSach = int.Parse(txtMaSach.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã sách phải được chọn từ danh sách");
                btnMaSach_Click(sender, e);
                return;
            }
            try
            {
                ct.SoLuong = uint.Parse(txtSoLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng mua phải là số và không được để trống");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số lượng không được âm");
                return;
            }
            if (tienNo <= noToiDa)
            {
                DataTable dt3 = ThamSo_BUS.SelectSoLuongTon(ct.MaSach);
                uint luongTon = uint.Parse(dt3.Rows[0].ItemArray[4].ToString());
                uint luongMua = 0;
                try
                {
                    luongMua = uint.Parse(txtSoLuong.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số lượng mua phải là số và không được để trống");
                    txtSoLuong.Text = "";
                    txtThanhTien.Text = "";
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Số lượng không được âm");
                    return;
                }
                ct.DonGia = UInt64.Parse(txtDonGia.Text);
                ct.ThanhTien = (UInt64)luongMua * ct.DonGia;
                txtThanhTien.Text = ct.ThanhTien.ToString();
                if ((luongTon - luongMua) < luongTonSauKhiBan)
                {
                    MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                    return;
                }
                string ketQua = HoaDon_BUS.ThemHoaDonChiTiet(ct);
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua);
                    txtMaSach.Text = "";
                    txtSoLuong.Text = "0";
                    txtDonGia.Text = "";
                    return;
                }
                else
                {
                    uint soluongtonnew = luongTon - luongMua;
                    Sach_DTO s = new Sach_DTO();
                    s.MaSach = int.Parse(txtMaSach.Text);
                    s.SoLuongTon = (int)soluongtonnew;
                    ketQua = Sach_BUS.UpdateSoLuongTon(s);
                    if (ketQua != "Success")
                    {
                        MessageBox.Show(ketQua);
                        return;
                    }
                    HoaDon_DTO hd = new HoaDon_DTO();
                    hd.MaHD = ct.MaHD;
                    hd.TongTien = UInt64.Parse(HoaDon_BUS.TongThanhTien(hd).Rows[0].ItemArray[0].ToString());
                    HoaDon_BUS.UpdateTongTien(hd);
                    HienThiDanhSachHoaDon();
                    MessageBox.Show("Thành công");
                    HienThiDanhSachChiTietHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Tiền nợ quý khách đã quá quy định để mua sách");
            }
        }

        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaHoaDon.Text = dgvHoaDon.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDonCT.Text = txtMaHoaDon.Text;
            txtMaKhachHang.Text = dgvHoaDon.Rows[dong].Cells[1].Value.ToString();
            txtMaKhachHangCT.Text = txtMaKhachHang.Text;
            dtpNgayLapHD.Text = dgvHoaDon.Rows[dong].Cells[2].Value.ToString();
            txtTongTien.Text = dgvHoaDon.Rows[dong].Cells[3].Value.ToString(); ;
            txtThanhToan.Text = dgvHoaDon.Rows[dong].Cells[4].Value.ToString();
            txtConLai.Text = dgvHoaDon.Rows[dong].Cells[5].Value.ToString();

            layMaHD = int.Parse(dgvHoaDon.Rows[dong].Cells[0].Value.ToString());
            HienThiDanhSachChiTietHoaDon();
        }

        private void dgvChiTietHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSach.Text = dgvChiTietHoaDon.Rows[dong].Cells[1].Value.ToString();
            txtDonGia.Text = dgvChiTietHoaDon.Rows[dong].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvChiTietHoaDon.Rows[dong].Cells[2].Value.ToString();
            txtThanhTien.Text = dgvChiTietHoaDon.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            txtThanhToan.Text = "0";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64 thanhToan = 0;
                try
                {
                    thanhToan = UInt64.Parse(txtThanhToan.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số tiền thanh toán phải là số và không được để trống");
                    return;
                }
                UInt64 tongTien = UInt64.Parse(txtTongTien.Text);
                if (thanhToan > tongTien)
                {
                    MessageBox.Show("Thanh toán không được lớn hơn tổng tiền");
                    return;
                }                
                UInt64 conLai = tongTien - thanhToan;
                txtConLai.Text = conLai.ToString();
                

                DataTable dt = ThamSo_BUS.GetThamSoAll();
                UInt64 noToiDa = UInt64.Parse(dt.Rows[0].ItemArray[5].ToString());
                DataTable dt2 = ThamSo_BUS.SelectTienNoKH(int.Parse(txtMaKhachHangCT.Text));
                UInt64 tienNo = UInt64.Parse(dt2.Rows[0].ItemArray[5].ToString());
                if ((conLai + tienNo) > noToiDa)
                {
                    string ketQua = HoaDon_BUS.XoaCTHoaDonByMa(int.Parse(txtMaHoaDon.Text));
                    if (ketQua != "Success")
                    {
                        MessageBox.Show(ketQua);
                        return;
                    }
                    ketQua = HoaDon_BUS.XoaHoaDonByMa(int.Parse(txtMaHoaDon.Text));
                    if (ketQua != "Success")
                    {
                        MessageBox.Show(ketQua);
                        return;
                    }
                    return;
                }
                else
                {
                    KhachHang_DTO kh = new KhachHang_DTO();
                    kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                    kh.SoTienNo = conLai + tienNo;
                    string ketQua = KhachHang_BUS.UpdateTienNo(kh);
                    if (ketQua != "Success")
                    {
                        MessageBox.Show(ketQua);
                        return;
                    }
                    MessageBox.Show("Thanh toán thành công");
                    Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Thanh toán phải là số và không được để trống");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Thanh toán không được âm");
                return;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            uint luongMua = 0;
            try
            {
                luongMua = uint.Parse(txtSoLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng mua phải là số và không được để trống");
                txtSoLuong.Text = "0";
                txtThanhTien.Text = "0";
                return;
            }
            UInt64 DonGia = UInt64.Parse(txtDonGia.Text);
            UInt64 ThanhTien = (UInt64)luongMua * DonGia;
            txtThanhTien.Text = ThanhTien.ToString();

            HoaDon_DTO hd = new HoaDon_DTO();
            hd.MaHD = layMaHD;
            if (HoaDon_BUS.SelectHoaDonCTByMa(hd.MaHD).Rows.Count > 0)
            {
                hd.TongTien = UInt64.Parse(HoaDon_BUS.TongThanhTien(hd).Rows[0].ItemArray[0].ToString()) + ThanhTien;
                txtTongTien.Text = hd.TongTien.ToString();
            }
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            UInt64 thanhToan = 0;
            try
            {
                thanhToan = UInt64.Parse(txtThanhToan.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng mua phải là số và không được để trống");
                txtThanhToan.Text = "0";
                return;
            }
        }

        private void btnTHThanhToan_Click(object sender, EventArgs e)
        {
            gThanhToan.Enabled = true;
            gChucNangThanhToan.Enabled = true;
            txtThanhToan.Focus();
        }
    }
}
