using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoai_DAO
    {
        //Lấy ra 1 đối tượng TheLoai_DTO bằng tên
        public static TheLoai_DTO GetTheLoaiByName(string Name)
        {
            string sql = "select * from THELOAI where TenTheLoai=N'" + Name + "'";
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
                return tl;
            }
        }
        //Thêm 1 thể loại
        public static string Insert(TheLoai_DTO tl)
        {
            string sql = "insert into THELOAI(TenTheLoai) values(N'" + tl.TenTheLoai + "')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy tất cả thông tin của bảng THELOAI
        public static DataTable GetTheLoaiAll()
        {
            string sql = "select * from THELOAI";
            return DataAccess.ThucThiQuery(sql);
        }        
        //Sửa 1 thể loại theo Mã thể loại
        public static string Update(TheLoai_DTO tl)
        {
            string sql = "Update  THELOAI set TenTheLoai =N'" + tl.TenTheLoai + "'where MaTheLoai=" + tl.MaTheLoai + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Xóa 1 thể loại theo Mã thể loai
        public static string Delete(TheLoai_DTO tl)
        {
            string sql = "delete from THELOAI where MaTheLoai=" + tl.MaTheLoai + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
