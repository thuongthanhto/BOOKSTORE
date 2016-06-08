using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_HoaDon_DTO
    {
        int _maHD;

        public int MaHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }
        int _maSach;

        public int MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        uint _soLuong;

        public uint SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        UInt64 _donGia;

        public UInt64 DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        UInt64 _thanhTien;

        public UInt64 ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
