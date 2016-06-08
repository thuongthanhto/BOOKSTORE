using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        int _maKhachHang;

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        string _tenKhachHang;

        public string TenKhachHang
        {
            get { return _tenKhachHang; }
            set { _tenKhachHang = value; }
        }
        string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }


        string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        UInt64 _soTienNo;

        public UInt64 SoTienNo
        {
            get { return _soTienNo; }
            set { _soTienNo = value; }
        }
    }
}
