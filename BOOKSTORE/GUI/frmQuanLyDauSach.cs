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
    public partial class frmQuanLyDauSach : Form
    {
        public static CT_TacGia_DTO c = new CT_TacGia_DTO();
        public frmQuanLyDauSach()
        {
            InitializeComponent();
        }
        public void Enable(bool a)
        {
            txtTenDauSach.ReadOnly = !a;

            cboTheLoai.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongluu.Enabled = a;
        }
        public void HienThiDauSach()
        {
            Enable(false);
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            dgvDauSach.DataSource = DauSach_BUS.SelectDauSachAll();
        }
        public void HienThiCTTacGia()
        {
            dgvCT_TacGia.DataSource = DauSach_BUS.SelectCTTacGiaAll();
        }
        private void frmQuanLyDauSach_Load(object sender, EventArgs e)
        {
            this.Size = new Size(750, 615);           
            colMaTheLoai.ValueMember = "MaTheLoai";
            colMaTheLoai.DisplayMember = "TenTheLoai";
            colMaTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            cboTheLoai.ValueMember = "MaTheLoai";
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            HienThiDauSach();
            cboTheLoai.Text = "";
        }
        private void btnChiTietTacGia_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1248, 615);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Size = new Size(750, 615);
        }

        private void dgvDauSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaDauSach.Text = dgvDauSach.Rows[dong].Cells[0].Value.ToString();
            txtMaSachCT.Text = dgvDauSach.Rows[dong].Cells[0].Value.ToString();
            txtTenDauSach.Text = dgvDauSach.Rows[dong].Cells[1].Value.ToString();
            cboTheLoai.SelectedValue = (int)(dgvDauSach.Rows[dong].Cells[2].Value);
            TheLoai_DTO tl = TheLoai_BUS.GetTheLoaiByMa((int)(dgvDauSach.Rows[dong].Cells[2].Value));
            cboTheLoai.Text = tl.TenTheLoai;
            dgvCT_TacGia.DataSource = DauSach_BUS.SelectCTTacGiaByMa(int.Parse(dgvDauSach.Rows[dong].Cells[0].Value.ToString()));
        }
        public void Them()
        {
            DauSach_DTO ds = new DauSach_DTO();
            ds.MaTheLoai = int.Parse(cboTheLoai.SelectedValue.ToString());
            ds.TenDauSach = txtTenDauSach.Text;
            string ketQua = DauSach_BUS.ThemDauSach(ds);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua);
                return;
            }
            HienThiDauSach();
            MessageBox.Show("Thêm đầu sách thành công");
            this.Size = new Size(1248, 615);
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Enable(true);
            btnCapNhat.Enabled = false;
            txtTenDauSach.Text = "";
            txtMaDauSach.Text = "";
            txtTacGia.Text = "";
            txtTenDauSach.Focus();
        }
        public void CapNhat()
        {
            DauSach_DTO ds = new DauSach_DTO();
            ds.MaDauSach = int.Parse(txtMaDauSach.Text);
            ds.MaTheLoai = int.Parse(cboTheLoai.SelectedValue.ToString());
            ds.TenDauSach = txtTenDauSach.Text;
            string ketQua = DauSach_BUS.CapNhatDauSach(ds);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua);
                return;
            }
            HienThiDauSach();
            MessageBox.Show("Cập nhật thành công");
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThem.Enabled = false;
            txtTenDauSach.Text = "";
            cboTheLoai.Text = "";
            txtTacGia.Text = "";
            txtTenDauSach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvCT_TacGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTacGia.Text = dgvCT_TacGia.Rows[dong].Cells[1].Value.ToString();
            c.MaDauSach = int.Parse(dgvCT_TacGia.Rows[dong].Cells[0].Value.ToString());
            c.TacGia = dgvCT_TacGia.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            CT_TacGia_DTO ct = new CT_TacGia_DTO();
            ct.MaDauSach = int.Parse(txtMaSachCT.Text);
            if (txtTacGia.Text == "")
            {
                MessageBox.Show("Tên tác giả không được để trống");
                return;
            }
            ct.TacGia = txtTacGia.Text;
            if (DauSach_BUS.ThemCTTacGia(ct) == false)
            {
                MessageBox.Show("Mã sách và Tác giả đã tồn tại trong CSDL");
                return;
            }
            HienThiCTTacGia();
            MessageBox.Show("Thêm tác giả thành công");
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            CT_TacGia_DTO ct = new CT_TacGia_DTO();
            try
            {
                ct.MaDauSach = c.MaDauSach;
                ct.TacGia = c.TacGia;
            }
            catch
            {
                MessageBox.Show("Mã sách và Tác giả không được rỗng chọn từ danh sách bên dưới để cập nhật");
            }
            string ketQua = DauSach_BUS.XoaDauSach(ct);
            if ( ketQua != "Success")
            {
                MessageBox.Show(ketQua,"Đã có lỗi");
                return;
            }
            HienThiCTTacGia();
            MessageBox.Show("Xóa thành công");
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            HienThiDauSach();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Enabled == false)
            {
                Them();
                btnChiTietTacGia_Click(sender, e);
            }
            if (btnThem.Enabled == false)
            {
                CapNhat();
                btnChiTietTacGia_Click(sender, e);
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtTacGia.Clear();
        }
        public static bool CloseCancel()
        {
            const string message = "Bạn có thật sự muốn thoát hay không?";
            const string caption = "Thoát";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
        
        private void frmQuanLyDauSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }
    }
}
