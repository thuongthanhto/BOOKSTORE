using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_TacGia_DTO
    {
        int _maDauSach;

        public int MaDauSach
        {
            get { return _maDauSach; }
            set { _maDauSach = value; }
        }
        string _tacGia;

        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
    }
}
