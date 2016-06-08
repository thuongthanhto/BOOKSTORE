using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        private string _taiKhoan;

        public string TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
    }
}
