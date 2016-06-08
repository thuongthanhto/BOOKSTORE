using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiMatKhau_DTO
    {
        private string _taiKhoan;

        public string TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }
        private string _matKhauCu;

        public string MatKhauCu
        {
            get { return _matKhauCu; }
            set { _matKhauCu = value; }
        }
        private string _matKhauMoi;

        public string MatKhauMoi
        {
            get { return _matKhauMoi; }
            set { _matKhauMoi = value; }
        }
        private string _nhapLaiMatKhauMoi;

        public string NhapLaiMatKhauMoi
        {
            get { return _nhapLaiMatKhauMoi; }
            set { _nhapLaiMatKhauMoi = value; }
        }
    }
}
