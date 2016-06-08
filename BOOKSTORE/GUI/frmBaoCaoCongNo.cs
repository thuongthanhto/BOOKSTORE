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
    public partial class frmBaoCaoCongNo : Form
    {
        public frmBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoCongNo_DTO r = new BaoCaoCongNo_DTO();
            try
            {
                r.Thang = int.Parse(txtThang.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Tháng không được để trống và phải là số");
                return;
            }
            try
            {
                r.Nam = int.Parse(txtNam.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Năm không được để trống và phải là số");
                return;
            }
            
            DataTable dt = BaoCaoCongNo_BUS.GetBaoCaoCongNoByThangNam(r);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tháng, năm này không có trong CSDL");
            }
            dgvCongNo.DataSource = dt;
        }
    }
}
