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
    public partial class frmLapPhieuThuTien : Form
    {
        public UInt64 luusotienthu;
        public static string maKH;
        public static string soTienNo;
        public frmLapPhieuThuTien()
        {
            InitializeComponent();
        }
        public void Enable(bool a)
        {
            txtSoTien.ReadOnly = !a;
           
            btnLuu.Enabled = a;
            btnKhongluu.Enabled = a;
        }
        public void HienThiPhieuThu()
        {
            Enable(false);
            dgvPhieuThuTien.DataSource = PhieuThuTien_BUS.GetPhieuThuAll();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }      
        private void frmLapPhieuThuTien_Load(object sender, EventArgs e)
        {
            colMaKhachHang.ValueMember = "MaKhachHang";
            colMaKhachHang.DisplayMember = "TenKhachHang";
            colMaKhachHang.DataSource = KhachHang_BUS.GetKhachHangAll();
            HienThiPhieuThu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuThuTien_DTO pt = new PhieuThuTien_DTO();
            pt.MaPT = int.Parse(txtMaPhieuThu.Text);
            string ketQua = PhieuThuTien_BUS.XoaPhieuThu(pt);
            if ( ketQua != "Success" )
            {
                MessageBox.Show(ketQua);
                return;
            }
            MessageBox.Show("Xóa thành công");
            HienThiPhieuThu();
        }
        public void CapNhat()
        {
            PhieuThuTien_DTO pt = new PhieuThuTien_DTO();
            pt.MaPT = int.Parse(txtMaPhieuThu.Text);

            dtpNgayThuTien.Format = DateTimePickerFormat.Custom;
            dtpNgayThuTien.CustomFormat = "MM-dd-yy";
            pt.NgayLap = dtpNgayThuTien.Text;
            dtpNgayThuTien.Format = DateTimePickerFormat.Short;

            try
            {
                int kh = int.Parse(txtMaKhachHang.Text);
                pt.MaKhachHang = kh;
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống");
                return;
            }
            DataTable dt = ThamSo_BUS.GetThamSoAll();
            int ktchophep = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            DataTable dt2 = ThamSo_BUS.SelectTienNoKH(int.Parse(txtMaKhachHang.Text));
            UInt64 tienno = UInt64.Parse(dt2.Rows[0].ItemArray[5].ToString());
            UInt64 tienthu = 0;
            try
            {
                pt.SoTienThu = UInt64.Parse(txtSoTien.Text);
                tienthu = UInt64.Parse(txtSoTien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thu chưa nhập đúng quy định");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiền thu không được âm");
                return;
            }
            if (ktchophep == 1)
            {
                if (tienno < tienthu)
                {
                    MessageBox.Show("Tiền thu đã lớn hơn tiền khách hàng đang nợ");
                    return;
                }
            }
            UInt64 tienthunew = (tienthu - luusotienthu);
            UInt64 tiennonew = (UInt64)(tienno) - tienthunew;

            string ketQua = PhieuThuTien_BUS.SuaPhieuThu(pt);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua, "Lỗi");
            }
            else
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                kh.SoTienNo = tiennonew;
                KhachHang_BUS.UpdateTienNo(kh);               
                MessageBox.Show("Thành công");
                HienThiPhieuThu();
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKhachHang.Text = "";            
            txtSoTien.Text = "";
        }        
        private void btnMaKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhSachKhachHang f = new frmDanhSachKhachHang();
            f.ShowDialog();
            txtMaKhachHang.Text = maKH;
            txtSoTienNo.Text = soTienNo;
        }
        public void Them()
        {
            PhieuThuTien_DTO pt = new PhieuThuTien_DTO();
            try
            {
                pt.MaKhachHang = int.Parse(txtMaKhachHang.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống");
                return;
            }

            dtpNgayThuTien.Format = DateTimePickerFormat.Custom;
            dtpNgayThuTien.CustomFormat = "MM-dd-yy";
            pt.NgayLap = dtpNgayThuTien.Text;
            dtpNgayThuTien.Format = DateTimePickerFormat.Short;

            DataTable dt = ThamSo_BUS.GetThamSoAll();
            int ktchophep = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            DataTable dt2 = ThamSo_BUS.SelectTienNoKH(int.Parse(txtMaKhachHang.Text));
            UInt64 tienno = UInt64.Parse(dt2.Rows[0].ItemArray[5].ToString());
            UInt64 tienthu = UInt64.Parse(txtSoTien.Text);

            try
            {
                pt.SoTienThu = UInt64.Parse(txtSoTien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thu chưa nhập đúng quy định");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiền thu không được âm");
                return;
            }
            if (ktchophep == 1)
            {
                if (tienno < tienthu)
                {
                    MessageBox.Show("Tiền thu đã lớn hơn tiền khách hàng đang nợ");
                    return;
                }
            }
            UInt64 tiennonew = tienno - tienthu;

            string ketQua = PhieuThuTien_BUS.ThemPhieuThu(pt);
            if ( ketQua != "Success")
            {
                MessageBox.Show(ketQua, "Lỗi");
            }
            else
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                kh.SoTienNo = tiennonew;
                KhachHang_BUS.UpdateTienNo(kh);
                MessageBox.Show("Thành công");
                HienThiPhieuThu();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKhachHang.Text = "";
            txtMaPhieuThu.Text = "";
            txtSoTien.Text = "";
        }

        private void dgvPhieuThuTien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaKhachHang.Text = dgvPhieuThuTien.Rows[dong].Cells[1].Value.ToString();
            txtMaPhieuThu.Text = dgvPhieuThuTien.Rows[dong].Cells[0].Value.ToString();
            luusotienthu = UInt64.Parse(dgvPhieuThuTien.Rows[dong].Cells[3].Value.ToString());
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            HienThiPhieuThu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Enabled == false)
            {
                Them();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            if (btnThem.Enabled == false)
            {
                CapNhat();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}