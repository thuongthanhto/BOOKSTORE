using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCaoTon_DAO
    {
        //Lấy tất cả MaSach từ bảng DAUSACH
        public static DataTable GetMaSach()
        {
            string sql = "select MaSach from SACH";
            return DataAccess.ThucThiQuery(sql);
        }
        //Kiểm tra Thang,Nam,MaSach đã tồn tại trong BAOCAOTON chưa
        public static DataTable CheckThongTin(BaoCaoTon_DTO r)
        {
            string sql = "select * from BAOCAOTON where Thang="+r.Thang+" and Nam = "+r.Nam+" and MaSach="+r.MaSach+"";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy thuộc tính SoLuongTon theo MaSach
        public static int GetSoLuongTon(int maSach)
        {
            string sql = "select SoLuongTon from SACH where MaSach = " + maSach + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
        //Thêm tồn đầu của MaSach
        public static string ThemTonDau(BaoCaoTon_DTO r)
        {
            string sql = "insert into BAOCAOTON(Thang,Nam,MaSach,TonDau) values(" + r.Thang + "," + r.Nam + "," + r.MaSach + "," + r.TonDau + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra phát sinh của 1 mã sách
        public static int GetPhatSinh(int thang, int nam, int maSach)
        {
            string sql = "select sum(SoLuongNhap) from CT_PHIEUNHAPSACH ct, PHIEUNHAPSACH p where p.MaPNS = ct.MaPNS and MaSach="+maSach+" and month(NgayNhap) = "+thang+" and year(NgayNhap) = "+nam+"";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            try
            {
                return int.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                return 0;
            }
        }
        //Cập nhật tồn cuối và phát sinh
        public static string CapNhatTonCuoiPhatSinh(BaoCaoTon_DTO r)
        {
            string sql = "update BAOCAOTON set PhatSinh=" + r.PhatSinh + ", TonCuoi=" + r.TonCuoi + " where Thang=" + r.Thang + " and Nam=" + r.Nam + " and MaSach=" + r.MaSach + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Thêm tồn mới và phát sinh
        public static string ThemTonCuoiPhatSinh(BaoCaoTon_DTO r)
        {
            string sql = "insert into BAOCAOTON(Thang,Nam,MaSach,PhatSinh,TonCuoi) values(" + r.Thang + "," + r.Nam + "," + r.MaSach + "," + r.PhatSinh + ","+r.TonCuoi+")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra Báo cáo tồn theo tháng và năm
        public static DataTable GetBaoCaoTonByThangNam(BaoCaoTon_DTO r)
        {
            string sql = "select * from BAOCAOTON where Thang=" + r.Thang + " and Nam=" + r.Nam + "";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
