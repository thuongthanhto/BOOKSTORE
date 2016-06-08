using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        int _maHD;

        public int MaHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }
        int _maKhachHang;

        public int MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        string _ngayLap;

        public string NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
        UInt64 _tongTien;

        public UInt64 TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        UInt64 _thanhToan;

        public UInt64 ThanhToan
        {
            get { return _thanhToan; }
            set { _thanhToan = value; }
        }
        UInt64 _conLai;

        public UInt64 ConLai
        {
            get { return _conLai; }
            set { _conLai = value; }
        }
    }
}
