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
    public class DauSach_BUS
    {
         //Lấy tất cả thông tin của đầu sách
        public static DataTable SelectDauSachAll()
        {
            return DauSach_DAO.SelectDauSachAll();
        }
        //Lấy ra bảng rỗng của bảng CT_TACGIA
        public static DataTable SelectCTTacGiaNull()
        {
            return DauSach_DAO.SelectCTTacGiaNull();
        }
        //Lấy tất cả thông tin của bảng CT_TACGIA
        public static DataTable SelectCTTacGiaAll()
        {
            return DauSach_DAO.SelectCTTacGiaAll();
        }
        //Lấy tất cả thông tin của bảng CT_TACGIA giống với mã
        public static DataTable SelectCTTacGiaByMa(int ma)
        {
            return DauSach_DAO.SelectCTTacGiaByMa(ma);
        }
        //Thêm đầu sách vào cơ sở dữ liệu
        public static string ThemDauSach(DauSach_DTO ds)
        {
            if (DauSach_DAO.SelectDauSachByName(ds.TenDauSach) == null)
            {
                return DauSach_DAO.Insert(ds);
            }
            else
            {
                return "Đầu sách đã tồn tại trong CSDL";
            }
        }
        //Thêm CT_TacGia vào bảng CT_TACGIA
        public static bool ThemCTTacGia(CT_TacGia_DTO ct)
        {
            if (DauSach_DAO.SelectCTTacGiaBy(ct) == null)
            {
                DauSach_DAO.Insert(ct);
                return true;
            }
            else
                return false;
        }        
        //Xóa tác giả
        public static string XoaDauSach(CT_TacGia_DTO ct)
        {
            if (DauSach_DAO.SelectCTTacGiaBy(ct) != null)
            {
                return DauSach_DAO.Delete(ct);
            }
            else
            {
                return "Sách này không có tác giả";
            }
        }
        //Cập nhật đầu sách
        public static string CapNhatDauSach(DauSach_DTO ds)
        {
            if (DauSach_DAO.SelectDauSachTheoMa(ds.MaDauSach) != null)
            {
                return DauSach_DAO.Update(ds);
            }
            else
            {
                return "Mã đầu sách không tồn tại trong CSDL";
            }
        }        
        //Chọn ra đầu sách giống tên tác giả cần tìm trong danh sách đầu sách
        static public DataTable SelectDauSachLikeTacGiaDanhSachDauSach(DauSach_DTO ds)
        {
            return DauSach_DAO.SelectDauSachLikeTacGiaDanhSachDauSach(ds);
        }
        //Chọn ra đầu sách giống với tên đầu sách cần tìm trong danh sách đầu sách
        static public DataTable SelectDauSachLikeNameDanhSachDauSach(DauSach_DTO ds)
        {
            return DauSach_DAO.SelectDauSachLikeNameDanhSachDauSach(ds);
        }
        //Chọn ra đầu sách theo mã thể loại
        static public DataTable SelectDauSachLikeMaTheLoaiDanhSachDauSach(DauSach_DTO ds)
        {
            return DauSach_DAO.SelectDauSachLikeMaTheLoaiDanhSachDauSach(ds);
        }
        
    }
}
