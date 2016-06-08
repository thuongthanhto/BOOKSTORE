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
    public class BaoCaoTon_BUS
    {
        //Lấy tất cả MaSach từ bảng DAUSACH
        public static DataTable GetMaSach()
        {
            return BaoCaoTon_DAO.GetMaSach();
        }
        //Kiểm tra Thang,Nam,MaSach đã tồn tại trong BAOCAOTON chưa
        public static bool CheckThongTin(BaoCaoTon_DTO r)
        {
            DataTable dt = BaoCaoTon_DAO.CheckThongTin(r);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        //Lấy thuộc tính SoLuongTon theo MaSach
        public static int GetSoLuongTon(int maSach)
        {
            return BaoCaoTon_DAO.GetSoLuongTon(maSach);
        }
        //Thêm tồn đầu của MaSach
        public static string ThemTonDau(BaoCaoTon_DTO r)
        {
            return BaoCaoTon_DAO.ThemTonDau(r);
        }
        //Lấy ra phát sinh của 1 mã sách
        public static int GetPhatSinh(int thang, int nam, int maSach)
        {
            return BaoCaoTon_DAO.GetPhatSinh(thang,nam,maSach);
        }
        //Cập nhật tồn cuối và phát sinh
        public static string CapNhatTonCuoiPhatSinh(BaoCaoTon_DTO r)
        {
            return BaoCaoTon_DAO.CapNhatTonCuoiPhatSinh(r);
        }
        //Thêm tồn mới và phát sinh
        public static string ThemTonCuoiPhatSinh(BaoCaoTon_DTO r)
        {
            return BaoCaoTon_DAO.ThemTonCuoiPhatSinh(r);
        }
        //Lấy ra Báo cáo tồn theo tháng và năm
        public static DataTable GetBaoCaoTonByThangNam(BaoCaoTon_DTO r)
        {
            return BaoCaoTon_DAO.GetBaoCaoTonByThangNam(r);
        }
    }
}
