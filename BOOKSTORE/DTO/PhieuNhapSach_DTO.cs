using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapSach_DTO
    {
        int _maPNS;

        public int MaPNS
        {
            get { return _maPNS; }
            set { _maPNS = value; }
        }
       string _ngayNhap;

        public string NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }
        UInt64 _tongTien;

        public UInt64 TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
    }
}
