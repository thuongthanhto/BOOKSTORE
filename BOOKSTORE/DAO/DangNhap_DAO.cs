using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhap_DAO
    {
        public static bool Kiemtrataikhoan_bool(DangNhap_DTO ObjDangnhap)
        {
            string sql = string.Format("select * from NGUOIDUNG where TaiKhoan='{0}' and MatKhau='{1}'", ObjDangnhap.TaiKhoan, ObjDangnhap.MatKhau);
            if (DataAccess.ExcuteReader_bool(sql) == true)
                return true;
            else
                return false;
        }
        public static string Maquyen_string(DangNhap_DTO ObjDangnhap)
        {
            string sql = string.Format("select MaQuyen from NGUOIDUNG where TaiKhoan='{0}'", ObjDangnhap.TaiKhoan);
            return DataAccess.ExecuteScalar_string(sql);
        }
    }
}
