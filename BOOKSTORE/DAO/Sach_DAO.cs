using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Sach_DAO
    {
        //chọn ra thông tin của 1 cuốn sách từ 2 bảng DAUSACH và SACH
        public static DataTable SelectThongTinSach()
        {
            string sql = "select MaSach,DAUSACH.MaDauSach,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from SACH join DAUSACH on SACH.MaDauSach = DAUSACH.MaDauSach";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về thông tin sách Full
        public static DataTable SelectThongTinSachFull()
        {
            string sql = "select MaSach,ds.MaDauSach,TacGia,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from DAUSACH ds, CT_TACGIA ct,SACH s where ds.MaDauSach=ct.MaDauSach and ds.MaDauSach=s.MaDauSach";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về đối tượng SACH giống với tên
        public static string Insert(Sach_DTO s)
        {
            string sql = "insert into SACH(MaDauSach,NhaXuatBan,NamXuatBan,SoLuongTon,DonGiaBan) values('" + s.MaDauSach + "',N'" + s.NhaXuatBan + "'," + s.NamXuatBan + "," + s.SoLuongTon + "," + s.DonGiaBan + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Trả về đối tượng Sach_DTO bằng cách lọc theo mã sách chọn phần tử hàng đầu tiên
        public static Sach_DTO SelectSachTheoMa(int ma)
        {
            string sql = "select * from SACH where MaSach=" + ma + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                Sach_DTO s = new Sach_DTO();
                s.MaSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                return s;
            }
        }
        //Cập nhật 1 cuốn sách
        public static string Update(Sach_DTO s)
        {
            string sql = "update  SACH set MaDauSach = "+s.MaDauSach+",NhaXuatBan =N'"+s.NhaXuatBan+"',NamXuatBan="+s.NamXuatBan+" where MaSach = " + s.MaSach + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
        
        //Trả về bảng chứa thông tin các cột trong form DanhSachSach theo TenTacGia
        public static DataTable SelectSachLikeTacGiaDanhSachSach(CT_TacGia_DTO ct)
        {
            string sql = "select MaSach,ds.MaDauSach,TacGia,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from DAUSACH ds, CT_TACGIA ct,SACH s where ds.MaDauSach=ct.MaDauSach and ds.MaDauSach=s.MaDauSach and TacGia like N'%" + ct.TacGia + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về bảng chứa thông tin theo TenDauSach trong form DanhSachSach
        public static DataTable SelectSachLikeNameDanhSachSach(DauSach_DTO ds)
        {
            string sql = "select MaSach,ds.MaDauSach,TacGia,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from DAUSACH ds, CT_TACGIA ct,SACH s where ds.MaDauSach=ct.MaDauSach and ds.MaDauSach=s.MaDauSach and TenDauSach like N'%" + ds.TenDauSach + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về bảng chứa thông tin theo NhaXuatBan trong form DanhSachSach
        public static DataTable SelectSachLikeNhaXuatBanDanhSachSach(Sach_DTO s)
        {
            string sql = "select MaSach,ds.MaDauSach,TacGia,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from DAUSACH ds, CT_TACGIA ct,SACH s where ds.MaDauSach=ct.MaDauSach and ds.MaDauSach=s.MaDauSach and NhaXuatBan like N'%" + s.NhaXuatBan + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về bảng chứa thông tin theo MaTheLoai
        public static DataTable SelectSachLikeMaTheLoaiDanhSachSach(DauSach_DTO s)
        {
            string sql = "select MaSach,ds.MaDauSach,TacGia,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from DAUSACH ds, CT_TACGIA ct,SACH s where ds.MaDauSach=ct.MaDauSach and ds.MaDauSach=s.MaDauSach and MaTheLoai=" + s.MaTheLoai + "";
            return DataAccess.ThucThiQuery(sql);
        }
        //Trả về bảng null
        public static DataTable SelectSachNull()
        {
            string sql = "select MaSach,ds.MaDauSach,TacGia,MaTheLoai,NhaXuatBan,NamXuatBan,DonGiaBan,SoLuongTon from DAUSACH ds, CT_TACGIA ct,SACH s where ds.MaDauSach=ct.MaDauSach and ds.MaDauSach=s.MaDauSach and MaTheLoai=null";
            return DataAccess.ThucThiQuery(sql);
        }
        //Update thuộc tính số lượng tồn trong bảng SACH
        public static void UpdateSoLuongTonVaDonGiaBan(Sach_DTO s)
        {
            string sql = "update SACH set SoLuongTon=(" + s.SoLuongTon + "),DonGiaBan=("+s.DonGiaBan+") where MaSach = " + s.MaSach + "";
            DataAccess.ThucThiNonQuery(sql);
        }
        //Update thuộc tính số lượng tồn
        public static string UpdateSoLuongTon(Sach_DTO s)
        {
            string sql = "update SACH set SoLuongTon=(" + s.SoLuongTon + ") where MaSach = " + s.MaSach + "";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
