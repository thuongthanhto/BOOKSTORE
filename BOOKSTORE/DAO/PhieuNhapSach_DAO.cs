using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapSach_DAO
    {
        //Trả về tất cả thông tin của bảng PHIEUNHAPSACH
        public static DataTable SelectPhieuNhapSachAll()
        {
            string sql = "select * from PHIEUNHAPSACH";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về tất cả thông tin của bảng CT_PHIEUNHAPSACH
        public static DataTable SelectCTPhieuNhapSachByMa(int maPNS)
        {
            string sql = "select * from CT_PHIEUNHAPSACH where MaPNS = "+maPNS+"";
            return DataAccess.ThucThiQuery(sql);
        }
        //Thêm 1 phiếu nhập
        static public string InsertPhieuNhap(PhieuNhapSach_DTO p)
        {           
            string sql = "insert into PHIEUNHAPSACH(NgayNhap,TongTien) values('" + p.NgayNhap+ "'," + p.TongTien + ")";         
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra đối tượng CT_PhieuNhapSach_DTO bằng MaPhieuNhap và MaSach
        public static CT_PhieuNhapSach_DTO GetPhieuNhapByName(int maphieunhap, int masach)
        {
            string sql = "select * from CT_PHIEUNHAPSACH where ((MaPNS=" + maphieunhap + ")AND(MaSach = " + masach + "))";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                CT_PhieuNhapSach_DTO pn = new CT_PhieuNhapSach_DTO();
                pn.MaPNS = (int)dt.Rows[0].ItemArray[0];
                return pn;
            }
        }
        //Thêm vào bảng CT_PHIEUNHAPSACH
        static public string Insert(CT_PhieuNhapSach_DTO p)
        {
            string sql = "insert into CT_PHIEUNHAPSACH(MaPNS,MaSach,SoLuongNhap,DonGiaNhap,ThanhTien) values(" + p.MaPNS + "," + p.MaSach + "," + p.SoLuongNhap + ","+p.DonGiaNhap+","+p.ThanhTien+")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra tháng theo MaPNS
        static public DataTable GetThangByMaPNS(int ma)
        {
            string sql = "select Month(NgayNhap) from PHIEUNHAPSACH where MaPNS = " + ma + "";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy ra năm theo MaPNS
        static public DataTable GetNamByMaPNS(int ma)
        {
            string sql = "select year(NgayNhap) from PHIEUNHAPSACH where MaPNS = " + ma + "";
            return DataAccess.ThucThiQuery(sql);
        }

        //Lấy ra tổng thành tiền của các CT_PHIEUNHAPSACH theo MaPNS
        static public DataTable GetTongThanhTien(int maPNS)
        {
            string sql = "select sum(ThanhTien) from CT_PHIEUNHAPSACH where MaPNS=" + maPNS + "";
            return DataAccess.ThucThiQuery(sql);
        }
        //Cập nhật tổng tiền của PHIEUNHAPSACH theo MaPNS
        static public void UpdateTongTien(PhieuNhapSach_DTO p)
        {
            string sql = "update PHIEUNHAPSACH set TongTien="+p.TongTien+" where MaPNS=" + p.MaPNS + "";
            DataAccess.ThucThiNonQuery(sql);
        }   
        //Kiểm tra có phải là PHIEUNHAPSACH đầu tiên
        static public DataTable KiemTraDauTien(int ngay, int thang, int nam,int maSach)
        {
            string sql = "select count(*) from PHIEUNHAPSACH p, CT_PHIEUNHAPSACH c where c.MaPNS=p.MaPNS and day(NgayNhap) between 1 and " + ngay + " and year(NgayNhap) = " + nam + " and MONTH(NgayNhap) = " + thang + " and MaSach="+maSach+"";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
