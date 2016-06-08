using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTon_DTO
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
        int _maSach;

        public int MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        int _tonDau;

        public int TonDau
        {
            get { return _tonDau; }
            set { _tonDau = value; }
        }
        int _phatSinh;

        public int PhatSinh
        {
            get { return _phatSinh; }
            set { _phatSinh = value; }
        }
        int _tonCuoi;

        public int TonCuoi
        {
            get { return _tonCuoi; }
            set { _tonCuoi = value; }
        }
    }
}
