using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DauSach_DTO
    {
        int _maDauSach;

        public int MaDauSach
        {
            get { return _maDauSach; }
            set { _maDauSach = value; }
        }
        string _tenDauSach;

        public string TenDauSach
        {
            get { return _tenDauSach; }
            set { _tenDauSach = value; }
        }
        int _maTheLoai;

        public int MaTheLoai
        {
            get { return _maTheLoai; }
            set { _maTheLoai = value; }
        }       
    }
}
