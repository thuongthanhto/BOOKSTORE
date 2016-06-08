using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoiMatKhau_DAO
    {
        //Phương thức đổi mật khẩu
        public static string Doimatkhau_bool(DoiMatKhau_DTO ObjDoimatkhau)
        {
            string sql = string.Format("UPDATE NGUOIDUNG SET MatKhau='{0}' WHERE TaiKhoan = '{1}'", ObjDoimatkhau.MatKhauMoi, ObjDoimatkhau.TaiKhoan);
            return DataAccess.ThucThiNonQuery(sql);
        }

        //Phương thức trả về mật khẩu của tài khoản
        public static string Matkhau_string(DoiMatKhau_DTO ObjDoimatkhau)
        {
            string sql = string.Format("SELECT MatKhau FROM NGUOIDUNG WHERE TaiKhoan='{0}'", ObjDoimatkhau.TaiKhoan);
            return DataAccess.ExecuteScalar_string(sql);
        }
    }
}
