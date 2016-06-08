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
    public partial class frmThayDoiQuyDinh : Form
    {
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtSoLuongNhapToiThieu.Text = "150";
            txtSoLuongTonToiThieu.Text = "20";
            txtSoLuongTonToiDa.Text = "300";
            txtSoTienNoToiDa.Text = "20000";
            txtTiLeTinhDonGiaBan.Text = "105";
            chkApDungQD4.Checked = true;

            int maThamSo;
            DataTable dt = ThamSo_BUS.GetThamSoAll();//Lấy tất cả tham số trong bảng THAMSO
            //Kiểm tra xem trong dt trả về có dữ liệu hay không
            if (dt.Rows.Count == 0)
            {
                maThamSo = 0;
            }
            else
            {
                maThamSo= int.Parse(dt.Rows[0].ItemArray[0].ToString());//Gán bằng giá trị đầu tiên của đối tượng dt chính là MaThamSo trong bảng THAMSO
            }

            ThamSo_DTO ts = new ThamSo_DTO();
            ts.MaThamSo = maThamSo;
            ts.SoLuongNhapToiThieu = UInt32.Parse(txtSoLuongNhapToiThieu.Text);
            ts.SoLuongTonToiDa = UInt32.Parse(txtSoLuongTonToiDa.Text);
            ts.SoTienNoToiDa = UInt64.Parse(txtSoTienNoToiDa.Text);
            ts.SoLuongTonToiThieu = UInt32.Parse(txtSoLuongTonToiThieu.Text);
            ts.TiLeTinhDonGiaBan = UInt32.Parse(txtTiLeTinhDonGiaBan.Text);
            ts.ApDungQuyDinh4 = 1;
            //Kiểm tra thử khôi phục mặc định có thành công không
            string ketQua = ThamSo_BUS.Update(ts);
            if ( ketQua == "Success")
            {
                MessageBox.Show("Đã khôi phục về mặc định!");
            }
            else
            {
                MessageBox.Show(ketQua);
            }
            HienThiGiaTriHienTai();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            DataTable dt = ThamSo_BUS.GetThamSoAll();//Lấy tất cả tham số trong bảng THAMSO
            int maThamSo;
            if (dt.Rows.Count == 0)//Kiểm tra xem trong bảng THAMSO đã có dữ liệu hay chưa
            {
                MessageBox.Show("Bạn phải khôi phục về mặc định trước khi thay đổi");
                btnMacDinh_Click(sender, e);
                return;
            }
            else
            {
                maThamSo = int.Parse(dt.Rows[0].ItemArray[0].ToString());//Gán bằng giá trị đầu tiên của đối tượng dt chính là MaThamSo trong bảng THAMSO
            }
            ThamSo_DTO ts = new ThamSo_DTO();
            ts.MaThamSo = maThamSo;

            if (chkApDungQD4.Checked == true)
            {
                ts.ApDungQuyDinh4 = 1;
            }
            else
            {
                ts.ApDungQuyDinh4 = 0;
            }

            try
            {
                ts.SoLuongNhapToiThieu = UInt32.Parse(txtSoLuongNhapToiThieu.Text);
                ts.SoLuongTonToiDa = UInt32.Parse(txtSoLuongTonToiDa.Text);
                ts.SoTienNoToiDa = UInt64.Parse(txtSoTienNoToiDa.Text);
                ts.SoLuongTonToiThieu = UInt32.Parse(txtSoLuongTonToiThieu.Text);
                ts.TiLeTinhDonGiaBan = UInt32.Parse(txtTiLeTinhDonGiaBan.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập vào tất cả các tham số");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số không được âm");
                return;
            }
            //Kiểm tra xem việc thay đổi có thành công hay không
            string ketQua = ThamSo_BUS.CapNhat(ts);
            if (ketQua == "Success")
            {
                MessageBox.Show("Thay đổi thành công");
            }
            else
            {
                MessageBox.Show(ketQua,"Lỗi");
            }
            HienThiGiaTriHienTai();
        }
        public void HienThiGiaTriHienTai()
        {
            DataTable dt = ThamSo_BUS.GetThamSoAll();
            if (dt.Rows.Count > 0)
            {
                txtTiLeTinhDonGiaBanCu.Text = dt.Rows[0].ItemArray[1].ToString();
                txtSoLuongNhapToiThieuCu.Text = dt.Rows[0].ItemArray[2].ToString();
                txtSoLuongTonToiThieuCu.Text = dt.Rows[0].ItemArray[3].ToString();
                txtSoLuongTonToiDaCu.Text = dt.Rows[0].ItemArray[4].ToString();           
                txtSoTienNoToiDaCu.Text = dt.Rows[0].ItemArray[5].ToString();
                int check = int.Parse(dt.Rows[0].ItemArray[6].ToString());
                if (check == 1)
                {
                    chkApDungQD4.Checked = true;
                }
                else
                    chkApDungQD4.Checked = false;    
            }
        }
        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            HienThiGiaTriHienTai();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtSoLuongTonToiDa.Text = "0";
            txtSoLuongNhapToiThieu.Text = "0";
            txtSoLuongTonToiThieu.Text = "0";
            txtSoTienNoToiDa.Text = "0";
            txtTiLeTinhDonGiaBan.Text = "0";
            chkApDungQD4.Checked = false;
        }

        private void txtSoLuongNhapToiThieu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt32 temp = UInt32.Parse(txtSoLuongNhapToiThieu.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn cần nhập số","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSoLuongNhapToiThieu.Text = "0";
                txtSoLuongNhapToiThieu.Focus();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập không được âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongNhapToiThieu.Text = "0";
                txtSoLuongNhapToiThieu.Focus();
                return;
            }
        }

        private void txtSoLuongTonToiDa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt32 temp = UInt32.Parse(txtSoLuongTonToiDa.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn cần nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongTonToiDa.Text = "0";
                txtSoLuongTonToiDa.Focus();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập không được âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongTonToiDa.Text = "0";
                txtSoLuongTonToiDa.Focus();
                return;
            }
        }

        private void txtSoTienNoToiDa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt32 temp = UInt32.Parse(txtSoTienNoToiDa.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn cần nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTienNoToiDa.Text = "0";
                txtSoTienNoToiDa.Focus();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập không được âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTienNoToiDa.Text = "0";
                txtSoTienNoToiDa.Focus();
                return;
            }
        }

        private void txtSoLuongTonToiThieu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt32 temp = UInt32.Parse(txtSoLuongTonToiThieu.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn cần nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongTonToiThieu.Text = "0";
                txtSoLuongTonToiThieu.Focus();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập không được âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongTonToiThieu.Text = "0";
                txtSoLuongTonToiThieu.Focus();
                return;
            }
        }

        private void txtTiLeTinhDonGiaBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UInt32 temp = UInt32.Parse(txtTiLeTinhDonGiaBan.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn cần nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiLeTinhDonGiaBan.Text = "0";
                txtTiLeTinhDonGiaBan.Focus();
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập không được âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiLeTinhDonGiaBan.Text = "0";
                txtTiLeTinhDonGiaBan.Focus();
                return;
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
       
        private void frmThayDoiQuyDinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }
    }
}
