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
    public class KhachHang_BUS
    {
        //Trả về bảng chứa toàn bộ thông tin của bảng KHACHHANG
        public static DataTable GetKhachHangAll()
        {
            return KhachHang_DAO.GetKhachHangAll();
        }
        //Thêm dữ liệu vào bảng KHACHHANG và kiểm tra xem có thêm thành công hay không
        public static string ThemKhachHang(KhachHang_DTO kh)
        {          
                return KhachHang_DAO.Insert(kh);          
        }
        
        //Sửa thông tin khách hàng trong bảng KHACHHANG
        public static string SuaKhachHang(KhachHang_DTO kh)
        {
            if (KhachHang_DAO.GetKhachHangByMa(kh.MaKhachHang) != null)
            {
                return KhachHang_DAO.Update(kh);
            }
            else
            {
                return "Mã khách hàng không có trong CSDL";
            }
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống tên với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeTen(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SelectKhachHangLikeTen(kh);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống địa chỉ với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeDiaChi(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SelectKhachHangLikeDiaChi(kh);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống Email với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeEmail(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SelectKhachHangLikeEmail(kh);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống Số điện thoại với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeDienThoai(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SelectKhachHangLikeDienThoai(kh);
        }
        //Update số tiền nợ của 1 khách hàng
        public static string UpdateTienNo(KhachHang_DTO kh)
        {
            return KhachHang_DAO.UpdateTienNo(kh);
        }
    }
}
