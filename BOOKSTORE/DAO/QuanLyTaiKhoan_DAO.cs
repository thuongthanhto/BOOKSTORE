using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyTaiKhoan_DAO
    {       
        public static DataTable getQuyen()
        {
            string sql = string.Format("select * from QUYEN");
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức trả về bảng NGUOIDUNG
        public static DataTable GetNguoiDungAll()
        {
            string sql = "select * FROM NGUOIDUNG";
            return DataAccess.ThucThiQuery(sql);
        }
        public static string ThemTaikhoan(QuanLyTaiKhoan_DTO obj)
        {
            string sql = "insert into NGUOIDUNG values (N'" + obj.TaiKhoan + "',N'" + obj.MatKhau + "'," + obj.MaQuyen + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string SuaTaikhoan(QuanLyTaiKhoan_DTO obj)
        {
            string sql = "update NGUOIDUNG set MatKhau=N'" + obj.MatKhau + "',MaQuyen=" + obj.MaQuyen + "where  TaiKhoan=N'" + obj.TaiKhoan + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string XoaTaikhoan(QuanLyTaiKhoan_DTO obj)
        {
            string sql = string.Format("DELETE NGUOIDUNG WHERE TaiKhoan = N'{0}'", obj.TaiKhoan);
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
