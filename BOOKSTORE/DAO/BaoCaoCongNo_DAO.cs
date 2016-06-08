using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCaoCongNo_DAO
    {
        //Lấy tất cả MaKhachHang từ bảng KhachHang
        public static DataTable GetMaKhachHang()
        {
            string sql = "select MaKhachHang from KHACHHANG";
            return DataAccess.ThucThiQuery(sql);
        }
        //Kiểm tra Thang,Nam,MaKhachHang đã tồn tại trong BaoCaoCongNo chưa
        public static DataTable CheckThongTin(BaoCaoCongNo_DTO r)
        {
            string sql = "select * from BAOCAOCONGNO where Thang=" + r.Thang + " and Nam = " + r.Nam + " and MaKhachHang=" + r.MaKhachHang + "";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy thuộc tính SoTienNo theo MaKhachHang
        public static UInt64 GetSoTienNo(int maKhachHang)
        {
            string sql = "select SoTienNo from KhachHang where MaKhachHang = " + maKhachHang + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            return UInt64.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
        //Thêm NoDau cua KhachHang
        public static string ThemTonDau(BaoCaoCongNo_DTO r)
        {
            string sql = "insert into BAOCAOCONGNO(Thang,Nam,MaKhachHang,NoDau) values(" + r.Thang + "," + r.Nam + "," + r.MaKhachHang + "," + r.NoDau + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra phát sinh của 1 MaKhachHang
        public static UInt64 GetPhatSinh(int thang, int nam, int maKhachHang)
        {
            string sql = "select sum(ConLai) from HOADON where MaKhachHang=" + maKhachHang + " and month(NgayLap) = " + thang + " and year(NgayLap) = " + nam + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            try
            {
                return UInt64.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                return 0;
            }
        }
        //Cập nhật nợ cuối và phát sinh
        public static string CapNhatNoCuoiPhatSinh(BaoCaoCongNo_DTO r)
        {
            string sql = "update BAOCAOCONGNO set PhatSinh=" + r.PhatSinh + ", NoCuoi=" + r.NoCuoi + " where Thang=" + r.Thang + " and Nam=" + r.Nam + " and MaKhachHang=" + r.MaKhachHang + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Thêm nợ cuối và phát sinh
        public static string ThemNoCuoiPhatSinh(BaoCaoCongNo_DTO r)
        {
            string sql = "insert into BAOCAOCONGNO(Thang,Nam,MaKhachHang,PhatSinh,NoCuoi) values(" + r.Thang + "," + r.Nam + "," + r.MaKhachHang + "," + r.PhatSinh + "," + r.NoCuoi + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra Báo cáo tồn theo tháng và năm
        public static DataTable GetBaoCaoCongNoByThangNam(BaoCaoCongNo_DTO r)
        {
            string sql = "select * from BAOCAOCONGNO where Thang=" + r.Thang + " and Nam=" + r.Nam + "";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
