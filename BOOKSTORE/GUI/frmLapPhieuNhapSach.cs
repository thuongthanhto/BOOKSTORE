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
    public partial class frmLapPhieuNhapSach : Form
    {
        private static int layNgay;
        private static int layThang;
        private static int layNam;
        public static int layMaPN;
        public frmLapPhieuNhapSach()
        {
            InitializeComponent();
        }
        public static string maSach;
        public void HienThiDanhSachPhieuNhap()
        {
            dgvPhieuNhap.DataSource = PhieuNhapSach_BUS.SelectPhieuNhapSachAll();
        }
        public void HienThiCTPhieuNhap()
        {
            dgvChiTietPhieuNhap.DataSource = PhieuNhapSach_BUS.SelectCTPhieuNhapSachByMa(layMaPN);
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1132, 632);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Size = new Size(568, 632);
        }

        private void frmLapPhieuNhapSach_Load(object sender, EventArgs e)
        {
            this.Size = new Size(568, 632);            
            HienThiDanhSachPhieuNhap();
            dtpNgayNhap.Value = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPhieuNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPhieuNhap.Text = dgvPhieuNhap.Rows[dong].Cells[0].Value.ToString();
            txtMaPhieuNhapCT.Text = dgvPhieuNhap.Rows[dong].Cells[0].Value.ToString();
            DateTime day = dtpNgayNhap.Value;
            layNgay = day.Day;
            layThang = day.Month;
            layNam = day.Year;

            layMaPN = int.Parse(dgvPhieuNhap.Rows[dong].Cells[0].Value.ToString());
            HienThiCTPhieuNhap();
        }

        private void dgvChiTietPhieuNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPhieuNhap.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[0].Value.ToString();
            txtMaSach.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[2].Value.ToString();
            txtDonGiaNhap.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1132, 632);
            PhieuNhapSach_DTO p = new PhieuNhapSach_DTO();
            p.TongTien = 0;

            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "MM-dd-yy";
            p.NgayNhap = dtpNgayNhap.Text;
            dtpNgayNhap.Format = DateTimePickerFormat.Short;

            string ketQua = PhieuNhapSach_BUS.ThemPhieuNhap(p);
            if (ketQua == "Success")
            {
                MessageBox.Show("Tạo phiếu thành công");
            }
            else
            {
                MessageBox.Show(ketQua);
            }
            HienThiDanhSachPhieuNhap();
        }

        private void btnMaSach_Click(object sender, EventArgs e)
        {
            frmDanhSachSach f = new frmDanhSachSach();
            f.ShowDialog();
            txtMaSach.Text = maSach;
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text ="0";
            txtMaSach.Clear();
        } 
             
        private void btnBoSung_Click(object sender, EventArgs e)
        {
            DataTable dt = ThamSo_BUS.GetThamSoAll();
            if (dt.Rows.Count != 0)
            {
                int nhapMin = int.Parse(dt.Rows[0].ItemArray[2].ToString());
                int luongTonMax = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                int tiLeDonGiaBan = int.Parse(dt.Rows[0].ItemArray[1].ToString());
                CT_PhieuNhapSach_DTO c = new CT_PhieuNhapSach_DTO();               
                try
                {
                    c.MaPNS = int.Parse(txtMaPhieuNhap.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống");
                    return;
                }
                try
                {
                    c.MaSach = int.Parse(txtMaSach.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Mã sách không được để trống");
                    return;
                }                
                try
                {
                    if (int.Parse(txtSoLuong.Text) < nhapMin)
                    {
                        MessageBox.Show(string.Format("Số lượng phải lớn hơn số lượng quy định ({0} quyển)", nhapMin));
                        return;
                    }
                    else
                    {
                        c.SoLuongNhap = int.Parse(txtSoLuong.Text);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số lượng phải là kiểu số");
                    return;
                }
                try
                {
                    if (txtDonGiaNhap.Text != "")
                    {
                        c.DonGiaNhap = UInt64.Parse(txtDonGiaNhap.Text);
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá nhập không được để trống");
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Đơn giá nhập phải là kiểu số");
                    return;
                }
                DataTable dt2 = ThamSo_BUS.SelectSoLuongTon(c.MaSach);
                int luongTon = int.Parse(dt2.Rows[0].ItemArray[4].ToString());
                int soLuongTonNew = luongTon + int.Parse(txtSoLuong.Text);
                c.ThanhTien = (UInt64)c.SoLuongNhap * c.DonGiaNhap;
                if (luongTon < luongTonMax)
                {
                    string ketQua = PhieuNhapSach_BUS.ThemChiTietPhieuNhap(c);
                    if (ketQua != "Success")
                    {
                        MessageBox.Show(ketQua);
                    }
                    else
                    {
                        Sach_DTO s = new Sach_DTO();
                        s.MaSach = int.Parse(txtMaSach.Text);
                        s.SoLuongTon = soLuongTonNew;
                        s.DonGiaBan = (UInt64)(double.Parse(txtDonGiaNhap.Text) * (double)tiLeDonGiaBan/100);
                        Sach_BUS.UpdateSoLuongTonVaDonGiaBan(s);

                        PhieuNhapSach_DTO p = new PhieuNhapSach_DTO();
                        p.MaPNS = int.Parse(txtMaPhieuNhapCT.Text);
                        PhieuNhapSach_BUS.CapNhatTongTien(p);
                        HienThiCTPhieuNhap();
                        MessageBox.Show("Thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ nhập các đầu sách có lượng tồn ít hơn theo quy định");
                }
            }
            else
            {
                MessageBox.Show("Không lấy được các tham số");
                return;
            }
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt64 tem = UInt64.Parse(txtDonGiaNhap.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Đơn giá nhập phải là số!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtDonGiaNhap.Text = "0";
                txtDonGiaNhap.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Đơn giá nhập không được âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGiaNhap.Text = "0";
                txtDonGiaNhap.Focus();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint tem = uint.Parse(txtSoLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Text = "0";
                txtSoLuong.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số lượng không được âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Text = "0";
                txtSoLuong.Focus();
            }
        }
    }
}
