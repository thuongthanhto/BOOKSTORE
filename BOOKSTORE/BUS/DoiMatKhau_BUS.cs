using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DoiMatKhau_BUS
    {
        //Phương thức đổi mật khẩu
        public static string Doimatkhau_bool(DoiMatKhau_DTO ObjDoimatkhau)
        {
            return DoiMatKhau_DAO.Doimatkhau_bool(ObjDoimatkhau);
        }

        //Phương thức trả về mật khẩu của tài khoản
        public static string Matkhau_string(DoiMatKhau_DTO ObjDoimatkhau)
        {
            return DoiMatKhau_DAO.Matkhau_string(ObjDoimatkhau);
        }
    }
}
