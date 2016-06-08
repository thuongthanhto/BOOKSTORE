using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo_DTO
    {
        int _maThamSo;

        public int MaThamSo
        {
            get { return _maThamSo; }
            set { _maThamSo = value; }
        }
        UInt32 _tiLeTinhDonGiaBan;

        public UInt32 TiLeTinhDonGiaBan
        {
            get { return _tiLeTinhDonGiaBan; }
            set { _tiLeTinhDonGiaBan = value; }
        }
        UInt32 _SoLuongNhapToiThieu;

        public UInt32 SoLuongNhapToiThieu
        {
            get { return _SoLuongNhapToiThieu; }
            set { _SoLuongNhapToiThieu = value; }
        }
        UInt32 _SoLuongTonToiThieu;

        public UInt32 SoLuongTonToiThieu
        {
            get { return _SoLuongTonToiThieu; }
            set { _SoLuongTonToiThieu = value; }
        }
        UInt32 _SoLuongTonToiDa;

        public UInt32 SoLuongTonToiDa
        {
            get { return _SoLuongTonToiDa; }
            set { _SoLuongTonToiDa = value; }
        }
        UInt64 _SoTienNoToiDa;

        public UInt64 SoTienNoToiDa
        {
            get { return _SoTienNoToiDa; }
            set { _SoTienNoToiDa = value; }
        }
        int _ApDungQuyDinh4;

        public int ApDungQuyDinh4
        {
            get { return _ApDungQuyDinh4; }
            set { _ApDungQuyDinh4 = value; }
        }
    }
}
