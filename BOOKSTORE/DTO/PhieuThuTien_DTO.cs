using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTien_DTO
    {
        int _maPT;

        public int MaPT
        {
            get { return _maPT; }
            set { _maPT = value; }
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
        UInt64 _soTienThu;

        public UInt64 SoTienThu
        {
            get { return _soTienThu; }
            set { _soTienThu = value; }
        }
    }
}
