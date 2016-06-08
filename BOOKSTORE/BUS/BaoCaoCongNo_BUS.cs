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
    public class BaoCaoCongNo_BUS
    {
        //Lấy tất cả MaSach từ bảng DAUSACH
        public static DataTable GetMaKhachHang()
        {
            return BaoCaoCongNo_DAO.GetMaKhachHang();
        }
        //Kiểm tra Thang,Nam,MaSach đã tồn tại trong BAOCAOTON chưa
        public static bool CheckThongTin(BaoCaoCongNo_DTO r)
        {
            DataTable dt = BaoCaoCongNo_DAO.CheckThongTin(r);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        //Lấy thuộc tính SoTienNo theo MaKhachHang
        public static UInt64 GetSoTienNo(int maKhachHang)
        {
            return BaoCaoCongNo_DAO.GetSoTienNo(maKhachHang);
        }
         //Thêm NoDau cua KhachHang
        public static string ThemTonDau(BaoCaoCongNo_DTO r)
        {
            return BaoCaoCongNo_DAO.ThemTonDau(r);
        }
        //Lấy ra phát sinh của 1 MaKhachHang
        public static UInt64 GetPhatSinh(int thang, int nam, int maKhachHang)
        {
            return BaoCaoCongNo_DAO.GetPhatSinh(thang, nam, maKhachHang);
        }
        //Cập nhật nợ cuối và phát sinh
        public static string CapNhatNoCuoiPhatSinh(BaoCaoCongNo_DTO r)
        {
            return BaoCaoCongNo_DAO.CapNhatNoCuoiPhatSinh(r);
        }
        //Thêm nợ cuối và phát sinh
        public static string ThemNoCuoiPhatSinh(BaoCaoCongNo_DTO r)
        {
            return BaoCaoCongNo_DAO.ThemNoCuoiPhatSinh(r);
        }
        //Lấy ra Báo cáo tồn theo tháng và năm
        public static DataTable GetBaoCaoCongNoByThangNam(BaoCaoCongNo_DTO r)
        {
            return BaoCaoCongNo_DAO.GetBaoCaoCongNoByThangNam(r);
        }
    }
}
