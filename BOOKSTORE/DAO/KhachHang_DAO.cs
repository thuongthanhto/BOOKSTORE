using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHang_DAO
    {
        //Lấy tất cả các thuộc tính có trong bảng KhachHang
        public static DataTable GetKhachHangAll()
        {
            string sql = "select * from KHACHHANG";
            return DataAccess.ThucThiQuery(sql);
        }
        //Thêm 1 khách hàng vào bang KHACHHANG
        public static string Insert(KhachHang_DTO kh)
        {
            string sql = "insert into KHACHHANG(TenKhachHang,SDT,DiaChi,Email,SoTienNo) values(N'" + kh.TenKhachHang + "',N'" + kh.SDT + "',N'" + kh.DiaChi + "',N'" + kh.Email + "',"+kh.SoTienNo+")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy ra đối tượng khách hàng bằng MaKhachHang
        public static KhachHang_DTO GetKhachHangByMa(int Ma)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + Ma + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.MaKhachHang = (int)dt.Rows[0].ItemArray[0];
                kh.TenKhachHang = dt.Rows[0].ItemArray[1].ToString();
                kh.SDT = dt.Rows[0].ItemArray[2].ToString();
                kh.DiaChi = dt.Rows[0].ItemArray[3].ToString();
                kh.Email = dt.Rows[0].ItemArray[4].ToString();
                return kh;
            }
        }
        //Xóa 1 khách hàng
        public static string Delete(KhachHang_DTO kh)
        {          
            string sql = "delete from KHACHHANG where MaKhachHang= " + kh.MaKhachHang + "";
            return DataAccess.ThucThiNonQuery(sql);           
        }
        //Cập nhật 1 khách hàng
        public static string Update(KhachHang_DTO kh)
        {
            string sql = "Update  KhachHang set TenKhachHang =(N'" + kh.TenKhachHang + "'),SDT=(N'" + kh.SDT + "'), DiaChi=(N'" + kh.DiaChi + "'),Email=(N'" + kh.Email + "') where MaKhachHang=" + kh.MaKhachHang + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống tên với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeTen(KhachHang_DTO kh)
        {
            string sql = "select * from KhachHang where TenKhachHang like N'%" + kh.TenKhachHang + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống địa chỉ với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeDiaChi(KhachHang_DTO kh)
        {
            string sql = "select * from KHACHHANG where DiaChi like N'%" + kh.DiaChi + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống Email với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeEmail(KhachHang_DTO kh)
        {
            string sql = "select * from KHACHHANG where Email like N'%" + kh.Email + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về 1 bảng chứa thông tin các khách hàng giống Số điện thoại với khách hàng cần tìm
        static public DataTable SelectKhachHangLikeDienThoai(KhachHang_DTO kh)
        {
            string sql = "select * from KHACHHANG where SDT like N'%" + kh.SDT + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Update số tiền nợ của 1 khách hàng
        public static string UpdateTienNo(KhachHang_DTO kh)
        {
            string sql = "Update  KHACHHANG set SoTienNo=(" + kh.SoTienNo + ") where MaKhachHang=" + kh.MaKhachHang + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
