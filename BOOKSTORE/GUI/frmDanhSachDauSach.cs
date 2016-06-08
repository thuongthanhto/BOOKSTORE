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
    public partial class frmDanhSachDauSach : Form
    {
        DauSach_DTO ds = new DauSach_DTO();
        public frmDanhSachDauSach()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachDauSach()
        {
            dgvDauSach.DataSource = DauSach_BUS.SelectDauSachAll();
        }       
        public void HienThiDanhSachDauSachTheoMaTheLoai(string ma)
        {
            DauSach_DTO s = new DauSach_DTO();
            s.MaTheLoai = int.Parse(ma);
            DataTable dt = DauSach_BUS.SelectDauSachLikeMaTheLoaiDanhSachDauSach(s);
            if (dt.Rows.Count == 0)
            {
                dgvCTTacGia.DataSource = DauSach_BUS.SelectCTTacGiaNull();
            }
            dgvDauSach.DataSource = dt;
        }
        private void frmDanhSachDauSach_Load(object sender, EventArgs e)
        {
            colTheLoai.ValueMember = "MaTheLoai";
            colTheLoai.DisplayMember = "TenTheLoai";
            colTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            cboTimTheLoai.ValueMember = "MaTheLoai";
            cboTimTheLoai.DisplayMember = "TenTheLoai";
            cboTimTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            HienThiDanhSachDauSach();
        }             
        private void rdTenSach_CheckedChanged(object sender, EventArgs e)
        {
            DauSach_DTO ds = new DauSach_DTO();
            ds.TenDauSach = txtThongTinSach.Text;
            dgvDauSach.DataSource = DauSach_BUS.SelectDauSachLikeNameDanhSachDauSach(ds);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cboTimTheLoai.SelectedValue.ToString();
            HienThiDanhSachDauSachTheoMaTheLoai(i);
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            frmQuanLySach.tenDauSach = ds.TenDauSach;
            frmQuanLySach.maDauSach = ds.MaDauSach;
            frmQuanLySach.maTheLoai = ds.MaTheLoai;
            btnThoat_Click(sender, e);
        }

        private void txtThongTinSach_TextChanged(object sender, EventArgs e)
        {                       
            if (rdTenSach.Checked == true)
            {
                rdTenSach_CheckedChanged(sender, e);
            }
        }

        private void dgvDauSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            ds.MaDauSach = int.Parse(dgvDauSach.Rows[dong].Cells[0].Value.ToString());
            ds.TenDauSach = dgvDauSach.Rows[dong].Cells[1].Value.ToString();
            ds.MaTheLoai = (int)dgvDauSach.Rows[dong].Cells[2].Value;
            dgvCTTacGia.DataSource = DauSach_BUS.SelectCTTacGiaByMa(ds.MaDauSach);
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThiDanhSachDauSach();
        }
    }
}
