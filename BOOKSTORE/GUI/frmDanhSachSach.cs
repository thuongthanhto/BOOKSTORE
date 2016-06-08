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
    public partial class frmDanhSachSach : Form
    {
        public static string layMaSach;
        public static string layDonGiaBan;
        public frmDanhSachSach()
        {
            InitializeComponent();
        }
        public void HienThiThongTinSach()
        {
            dgvSach.DataSource = Sach_BUS.SelectThongTinSachFull();
        }

        private void frmDanhSachSach_Load(object sender, EventArgs e)
        {
            colMaTheLoai.ValueMember = "MaTheLoai";
            colMaTheLoai.DisplayMember = "TenTheLoai";
            colMaTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            cboTimTheLoai.ValueMember = "MaTheLoai";
            cboTimTheLoai.DisplayMember = "TenTheLoai";
            cboTimTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            colTenSach.ValueMember = "MaDauSach";
            colTenSach.DisplayMember = "TenDauSach";
            colTenSach.DataSource = DauSach_BUS.SelectDauSachAll();

            cboTimTheLoai.Text = "";
            HienThiThongTinSach();  
        }

        private void rdTacGia_CheckedChanged(object sender, EventArgs e)
        {
            CT_TacGia_DTO ct = new CT_TacGia_DTO();
            ct.TacGia = txtThongTinSach.Text;
            dgvSach.DataSource = Sach_BUS.SelectSachLikeTacGiaDanhSachSach(ct);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdTenSach_CheckedChanged(object sender, EventArgs e)
        {
            DauSach_DTO ds = new DauSach_DTO();
            ds.TenDauSach = txtThongTinSach.Text;
            dgvSach.DataSource = Sach_BUS.SelectSachLikeNameDanhSachSach(ds);
        }

        private void txtThongTinSach_TextChanged(object sender, EventArgs e)
        {           
            if (rdTacGia.Checked == true)
            {
                rdTacGia_CheckedChanged(sender, e);
            }
            if (rdTenSach.Checked == true)
            {
                rdTenSach_CheckedChanged(sender, e);
            }
            if (rdNhaXuatBan.Checked == true)
            {
                rdNhaXuatBan_CheckedChanged(sender, e);
            }
        }

        private void rdNhaXuatBan_CheckedChanged(object sender, EventArgs e)
        {
            Sach_DTO s = new Sach_DTO();
            s.NhaXuatBan = txtThongTinSach.Text;
            dgvSach.DataSource = Sach_BUS.SelectSachLikeNhaXuatBanDanhSachSach(s);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapSach.maSach = layMaSach;
            frmHoaDonBanSach.maSach = layMaSach;
            frmHoaDonBanSach.donGiaBan = layDonGiaBan;
            this.Close();
        }      
        public void HienThiDanhSachDauSachTheoMaTheLoai(string ma)
        {
            DauSach_DTO s = new DauSach_DTO();
            s.MaTheLoai = int.Parse(ma);
            DataTable dt = Sach_BUS.SelectSachLikeMaTheLoaiDanhSachSach(s);

            colTenSach.ValueMember = "MaDauSach";
            colTenSach.DisplayMember = "TenDauSach";
            colTenSach.DataSource = DauSach_BUS.SelectDauSachAll();

            if (dt.Rows.Count == 0)
            {
                dgvSach.DataSource = Sach_BUS.SelectSachNull();
            }
            dgvSach.DataSource = dt;
        }
        private void cboTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cboTimTheLoai.SelectedValue.ToString();
            HienThiDanhSachDauSachTheoMaTheLoai(i);
        }

        private void dgvSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            layMaSach = dgvSach.Rows[dong].Cells[0].Value.ToString();
            layDonGiaBan = dgvSach.Rows[dong].Cells[6].Value.ToString();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThiThongTinSach();
        }       
    }
}
