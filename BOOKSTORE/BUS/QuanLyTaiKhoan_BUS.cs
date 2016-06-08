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
    public class QuanLyTaiKhoan_BUS
    {
        //Lất tất cả bảng QUYEN
        public static DataTable getQuyen()
        {
            return QuanLyTaiKhoan_DAO.getQuyen();
        }
        //Phương thức trả về danh sách giới tính
        public DataTable getGioitinh()
        {
            DataTable gioitinh = new DataTable();
            gioitinh.Columns.Add("gt", typeof(string));
            gioitinh.Rows.Add("Nam");
            gioitinh.Rows.Add("Nữ");
            return gioitinh;
        }
        //Phương thức trả về bảng NGUOIDUNG
        public static DataTable GetNguoiDungAll()
        {
            return QuanLyTaiKhoan_DAO.GetNguoiDungAll();
        }
        //Thêm tài khoản
        public static string ThemTaikhoan(QuanLyTaiKhoan_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.ThemTaikhoan(obj);
        }
        //Phương thức sửa 
        public static string SuaTaikhoan(QuanLyTaiKhoan_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.SuaTaikhoan(obj);
        }
        //Phương thức xóa
        public static string XoaTaikhoan(QuanLyTaiKhoan_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.XoaTaikhoan(obj);
        }
    }
}
