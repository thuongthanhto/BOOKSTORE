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
    public partial class frmQuanLySach : Form
    {
        public static int maDauSach;
        public static int maTheLoai;
        public static string tenDauSach;
        public frmQuanLySach()
        {
            InitializeComponent();
        }
        public void Enable(bool a)
        {
            txtNhaXuatBan.ReadOnly = !a;
            txtNamXuatBan.ReadOnly = !a;

            btnLuu.Enabled = a;
            btnKhongluu.Enabled = a;
        }
        public void HienThiThongTinSach()
        {
            Enable(false);
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            dgvSach.DataSource = Sach_BUS.SelectThongTinSach();
        }
        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            colMaTheLoai.ValueMember = "MaTheLoai";
            colMaTheLoai.DisplayMember = "TenTheLoai";
            colMaTheLoai.DataSource = TheLoai_BUS.GetTheLoaiAll();

            colTenDauSach.ValueMember = "MaDauSach";
            colTenDauSach.DisplayMember = "TenDauSach";
            colTenDauSach.DataSource = DauSach_BUS.SelectDauSachAll();

            HienThiThongTinSach();   
        }
        public void HienThiMaDauSach()
        {
            txtMaDauSach.Text = maDauSach.ToString();
        }
        private void btnMaDauSach_Click(object sender, EventArgs e)
        {
            frmDanhSachDauSach frm = new frmDanhSachDauSach();
            frm.ShowDialog();
            HienThiMaDauSach();
        }
        public void Them()
        {
            Sach_DTO s = new Sach_DTO();
            try
            {
                s.MaDauSach = int.Parse(txtMaDauSach.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã đầu sách không được để trống");
                return;
            }
            s.SoLuongTon = 0;
            s.DonGiaBan = 0;
            if (txtNhaXuatBan.Text == "")
            {
                MessageBox.Show("Nhà xuất bản không được để trống");
                txtNhaXuatBan.Focus();
                return;
            }
            else
            {
                s.NhaXuatBan = txtNhaXuatBan.Text;
            }
            try
            {
                s.NamXuatBan = int.Parse(txtNamXuatBan.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Năm xuất bản không được để trống");
                txtNamXuatBan.Focus();
                return;
            }
            string ketQua = Sach_BUS.Insert(s);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua);
                return;
            }
            MessageBox.Show("Thêm thành công");
            HienThiThongTinSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnCapNhat.Enabled = false;
            txtMaDauSach.Text = "";
            txtGiaBan.Text = "";
            txtMaSach.Text = "";
            txtNamXuatBan.Text = "";
            txtNhaXuatBan.Text = "";
            txtSoLuongTon.Text = "";
            txtNhaXuatBan.Focus();
        }

        private void btnResetText_Click(object sender, EventArgs e)
        {
            txtMaDauSach.Clear();
            txtGiaBan.Clear();
            txtMaSach.Clear();
            txtNamXuatBan.Clear();
            txtNhaXuatBan.Clear();
            txtSoLuongTon.Clear();
        }
        public void CapNhat()
        {
            Sach_DTO s = new Sach_DTO();
            try
            {
                s.MaSach = int.Parse(txtMaSach.Text);
            }
            catch
            {
                MessageBox.Show("Mã sách không được rỗng! Hãy chọn từ danh sách bên dưới để cập nhật");
                return;
            }
            try
            {
                s.MaDauSach = int.Parse(txtMaDauSach.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã đầu sách không được để trống");
                return;
            }
            if (txtNhaXuatBan.Text == "")
            {
                MessageBox.Show("Nhà xuất bản không được để trống");
                txtNhaXuatBan.Focus();
                return;
            }
            else
            {
                s.NhaXuatBan = txtNhaXuatBan.Text;
            }
            try
            {
                s.NamXuatBan = int.Parse(txtNamXuatBan.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Năm xuất bản không được để trống");
                txtNamXuatBan.Focus();
                return;
            }
            string ketQua = Sach_BUS.CapNhatSach(s);
            if (ketQua != "Success")
            {
                MessageBox.Show(ketQua);
                return;
            }
            HienThiThongTinSach();
            MessageBox.Show("Cập nhật thành công");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnThem.Enabled = false;
            txtGiaBan.Text = "";
            txtNamXuatBan.Text = "";
            txtMaDauSach.Text = "";
            txtNhaXuatBan.Text = "";
            txtSoLuongTon.Text = "";
            txtNhaXuatBan.Focus();
        }

        private void dgvSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSach.Text = dgvSach.Rows[dong].Cells[0].Value.ToString();
            txtMaDauSach.Text = dgvSach.Rows[dong].Cells[1].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.Rows[dong].Cells[3].Value.ToString();
            txtNamXuatBan.Text = dgvSach.Rows[dong].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvSach.Rows[dong].Cells[5].Value.ToString();
            txtSoLuongTon.Text = dgvSach.Rows[dong].Cells[6].Value.ToString();            
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKhongluu_Click(object sender, EventArgs e)
        {
            HienThiThongTinSach();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Enabled == false)
            {
                Them();
            }
            if (btnThem.Enabled == false)
            {
                CapNhat();
            }
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

        private void frmQuanLySach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }
    }
}
