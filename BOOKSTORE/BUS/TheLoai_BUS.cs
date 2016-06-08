using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoai_BUS
    {

        //Thêm 1 thể loại vào bảng THELOAI
        public static string ThemTheLoai(TheLoai_DTO tl)
        {
            if (TheLoai_DAO.GetTheLoaiByName(tl.TenTheLoai) == null)
            {
               return TheLoai_DAO.Insert(tl);
            }
            else
            {
                return "Thể loại này đã có trong cơ sở dữ liệu";
            }
        }       
        //Sửa 1 thể loại
        public static string SuaTheLoai(TheLoai_DTO tl)
        {
            if (TheLoai_DAO.GetTheLoaiByName(tl.TenTheLoai) != null)
            {
                return "Thể loại này đã có trong cơ sở dữ liệu";
            }
            if (TheLoai_DAO.GetTheLoaiByMa(tl.MaTheLoai) != null)
            {
                return TheLoai_DAO.Update(tl);
            }
            else
            {
                return "Mã thể loại này không tồn tại trong CSDL";
            }
        }       
        //Lấy tất cả thông tin của bảng THELOAI
        public static DataTable GetTheLoaiAll()
        {
            return TheLoai_DAO.GetTheLoaiAll();
        }   
        //Lấy thể loại bằng Mã thể loại
        public static TheLoai_DTO GetTheLoaiByMa(int Ma)
        {
            string sql = "select * from THELOAI where MaTheLoai=" + Ma + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TheLoai_DTO tl = new TheLoai_DTO();
                tl.MaTheLoai = (int)dt.Rows[0].ItemArray[0];
                tl.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }
        }
    }
}
