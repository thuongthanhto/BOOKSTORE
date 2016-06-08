using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoCongNo_DTO
    {
        int _thang;

        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }
        int _nam;

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }
        int _maKhachHang;

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        UInt64 _noDau;

        public UInt64 NoDau
        {
            get { return _noDau; }
            set { _noDau = value; }
        }
        UInt64 _phatSinh;

        public UInt64 PhatSinh
        {
            get { return _phatSinh; }
            set { _phatSinh = value; }
        }
        UInt64 _noCuoi;

        public UInt64 NoCuoi
        {
            get { return _noCuoi; }
            set { _noCuoi = value; }
        }
    }
}
