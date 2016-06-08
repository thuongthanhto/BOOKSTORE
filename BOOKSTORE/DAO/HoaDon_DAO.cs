using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDon_DAO
    {
        //Hiển thị tất cả hóa đơn
        public static DataTable SelectallHoaDon()
        {
            string sql = "select * from HOADON";
            return DataAccess.ThucThiQuery(sql);
        }
        //Hiển thị tất cả CT_HOADON
        public static DataTable SelectHoaDonCTByMa(int maHD)
        {
            string sql = "select * from CT_HOADON where MaHD = "+maHD+"";
            return DataAccess.ThucThiQuery(sql);
        }
        //Thêm 1 hóa đơn
        public static string Insert(HoaDon_DTO hd)
        {
            string sql = "insert into HOADON(MaKhachHang,NgayLap,TongTien,ThanhToan,ConLai) values(" +hd.MaKhachHang + ",'" + hd.NgayLap + "',"+hd.TongTien+","+hd.ThanhToan+","+hd.ConLai+")";
            return DataAccess.ThucThiNonQuery(sql);
        }

        //Trả về đối tượng CT_HoaDon_DTO theo Mã sách và Mã hóa đơn
        static public CT_HoaDon_DTO SelectSachLikeMaSach(int mahoadon, int masach)
        {
            string sql = "select * from CT_HOADON where ((MaHD=" + mahoadon + ")AND(MaSach=" + masach + ") )";

            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                CT_HoaDon_DTO ct = new CT_HoaDon_DTO();
                ct.MaSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                return ct;
            }
        }
        //Thêm 1 Chi tiết hóa đơn
        public static string InsertChitiet(CT_HoaDon_DTO ct)
        {
            string sql = "insert into CT_HOADON(MaHD,MaSach,SoLuong,DonGia,ThanhTien) values(" + ct.MaHD + "," + ct.MaSach + "," + ct.SoLuong + ","+ct.DonGia+","+ct.ThanhTien+")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Update thuộc tính tổng tiền của hóa đơn
        public static void UpdateTongTien(HoaDon_DTO hd)
        {
            string sql = "update HOADON set TongTien="+hd.TongTien+" where MaHD="+hd.MaHD+"";
            DataAccess.ThucThiNonQuery(sql);
        }
        //Trả về tổng thành tiền của các CT_HoaDon
        public static DataTable TongThanhTien(HoaDon_DTO hd)
        {
            string sql = "select sum(ThanhTien) from CT_HOADON where MaHD = "+hd.MaHD+"";
            return DataAccess.ThucThiQuery(sql);
        }
        //Xóa hóa đơn bằng mã 
        public static string XoaHoaDonByMa(int ma)
        {
            string sql = "delete from HOADON where MaHD=" + ma + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Xóa chi tiết hóa đơn bằng mã
        public static string XoaCTHoaDonByMa(int ma)
        {
            string sql = "delete from CT_HOADON where MaHD=" + ma + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Kiểm tra có phải là HOADON đầu tiên
        static public DataTable KiemTraDauTien(int ngay, int thang, int nam)
        {
            string sql = "select count(*) from HOADON where day(NgayLap) between 1 and "+ngay+" and year(NgayLap) = "+nam+" and MONTH(NgayLap) = "+thang+"";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
