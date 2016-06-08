using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap_BUS
    {
        public static bool Kiemtrataikhoan_bool(DangNhap_DTO ObjDangnhap)
        {
            return DangNhap_DAO.Kiemtrataikhoan_bool(ObjDangnhap);
        }
        public static string Maquyen_string(DangNhap_DTO ObjDangnhap)
        {
            return DangNhap_DAO.Maquyen_string(ObjDangnhap);
        }
    }
}
