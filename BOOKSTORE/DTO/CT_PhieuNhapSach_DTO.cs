using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_PhieuNhapSach_DTO
    {
        int _maPNS;

        public int MaPNS
        {
            get { return _maPNS; }
            set { _maPNS = value; }
        }
        int _maSach;

        public int MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        int _soLuongNhap;

        public int SoLuongNhap
        {
            get { return _soLuongNhap; }
            set { _soLuongNhap = value; }
        }
        UInt64 _donGiaNhap;

        public UInt64 DonGiaNhap
        {
            get { return _donGiaNhap; }
            set { _donGiaNhap = value; }
        }
        UInt64 _thanhTien;

        public UInt64 ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
