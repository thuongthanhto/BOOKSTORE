using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DauSach_DAO
    {
        //Lấy tất cả thông tin của đầu sách
        public static DataTable SelectDauSachAll()
        {
            string sql = "select * from DAUSACH";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy ra bảng rỗng của bảng CT_TACGIA
        public static DataTable SelectCTTacGiaNull()
        {
            string sql = "select * from CT_TACGIA where MaDauSach=null";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về tên đối tượng đầu sách đầu tiên trùng với tên
        static public DauSach_DTO SelectDauSachByName(string name)
        {
            string sql = "select * from DAUSACH where TenDauSach=N'" + name + "'";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DauSach_DTO s = new DauSach_DTO();
                s.TenDauSach = dt.Rows[0].ItemArray[0].ToString();
                return s;
            }
        }
        //Trả về đối tượng CT_TacGia trùng với MaDauSach và TacGia
        public static CT_TacGia_DTO SelectCTTacGiaBy(CT_TacGia_DTO ct)
        {
            string sql = "select * from CT_TACGIA where MaDauSach=" + ct.MaDauSach + " and TacGia=N'" + ct.TacGia + "'";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                CT_TacGia_DTO t = new CT_TacGia_DTO();
                t.MaDauSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                t.TacGia = dt.Rows[0].ItemArray[1].ToString();
                return t;
            }
        }
        //Thêm đầu sách vào bảng DAUSACH
        static public string Insert(DauSach_DTO s)
        {
            string sql = "insert into DAUSACH(TenDauSach,MaTheLoai) values(N'" + s.TenDauSach + "'," + s.MaTheLoai + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Thêm 1 CT_TacGia vào bảng CT_TACGIA
        static public void Insert(CT_TacGia_DTO ct)
        {
            string sql = "insert into CT_TACGIA(MaDauSach,TacGia) values("+ct.MaDauSach+",N'" + ct.TacGia + "')";
            DataAccess.ThucThiNonQuery(sql);
        }
        //Trả về đối tượng DauSach_DTO với thuộc tính mã đầu sách
        static public DauSach_DTO SelectDauSachTheoMa(int ma)
        {
            string sql = "select * from DAUSACH where MaDauSach=" + ma + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DauSach_DTO s = new DauSach_DTO();
                s.MaDauSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                return s;
            }
        }
        //Xóa 1 đầu sách theo mã đầu sách
        public static bool Delete(DauSach_DTO ds)
        {
            try
            {
                string sql = "delete from DAUSACH where MaDauSach= " + ds.MaDauSach + "";
                DataAccess.ThucThiNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string Delete(CT_TacGia_DTO ct)
        {           
            string sql = "delete from CT_TACGIA where MaDauSach=" + ct.MaDauSach + " and TacGia=N'" + ct.TacGia + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Xóa tất cả các dòng trùng với ma của bảng CT_TACGIA
        public static bool DeleteAll(int ma)
        {
            try
            {
                string sql = "delete from CT_TACGIA where MaDauSach= " + ma + "";
                DataAccess.ThucThiNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Cập nhật 1 đầu sách theo mã đầu sách
        static public string Update(DauSach_DTO ds)
        {
            string sql = "update  DAUSACH set TenDauSach=(N'" + ds.TenDauSach + "'),MaTheLoai=(" + ds.MaTheLoai + ") where MaDauSach = " + ds.MaDauSach + "";
            return DataAccess.ThucThiNonQuery(sql);
        }      
        //Chọn ra đầu sách giống tên tác giả cần tìm trong danh sách đầu sách
        static public DataTable SelectDauSachLikeTacGiaDanhSachDauSach(DauSach_DTO ds)
        {
            string sql = "select * from DAUSACH where TacGia like N'%" + ds.TenDauSach + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Chọn ra đầu sách giống với tên đầu sách cần tìm trong danh sách đầu sách
        static public DataTable SelectDauSachLikeNameDanhSachDauSach(DauSach_DTO ds)
        {
            string sql = "select * from DAUSACH where TenDauSach like N'%" + ds.TenDauSach + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        static public DataTable SelectDauSachLikeMaTheLoaiDanhSachDauSach(DauSach_DTO ds)
        {
            string sql = "select * from DAUSACH where MaTheLoai like '%" + ds.MaTheLoai + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy tất cả thông tin của bảng CT_TACGIA
        public static DataTable SelectCTTacGiaAll()
        {
            string sql = "select * from CT_TACGIA";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy tất cả thông tin của bảng CT_TACGIA giống với mã
        public static DataTable SelectCTTacGiaByMa(int ma)
        {
            string sql = "select * from CT_TACGIA where MaDauSach="+ma+"";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
