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
    public class ThamSo_BUS
    {
        //Lấy tất cả các tham số trong bảng THAMSO
        public static DataTable GetThamSoAll()
        {
            return ThamSo_DAO.GetThamSoAll();
        }
        //Cập nhật lại bảng THAMSO
        public static string Update(ThamSo_DTO ts)
        {
            if (ThamSo_DAO.LayThamSoBangMa(ts.MaThamSo)==null)//Kiểm tra xem ts.MaThamSo đã có trong bảng THAMSO hay không
            {
                return ThamSo_DAO.Them(ts);//Không có trong bảng THAMSO thì thêm mới
            }
            else
            {
                return ThamSo_DAO.CapNhat(ts);//Có thì cập nhật lại bảng THAMSO
            }
        }
        //Cập nhật bảng THAMSO
        public static string CapNhat(ThamSo_DTO ts)
        {
            return ThamSo_DAO.CapNhat(ts);
        }
        //Lấy số lượng tồn từ bảng SACH theo MaSach
        public static DataTable SelectSoLuongTon(int masach)
        {
            return ThamSo_DAO.SelectSoLuongTon(masach);
        }
        //Lấy số tiền nợ của khách hàng theo MaKH
        static public DataTable SelectTienNoKH(int maKH)
        {
            return ThamSo_DAO.SelectTienNoKH(maKH);
        }
    }
}
