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
    public class PhieuNhapSach_BUS
    {
        //Trả về tất cả thông tin của bang PHIEUNHAPSACH
        public static DataTable SelectPhieuNhapSachAll()
        {
            return PhieuNhapSach_DAO.SelectPhieuNhapSachAll();
        }
        //Trả về tất cả thông tin của bảng CT_PHIEUNHAPSACH
        public static DataTable SelectCTPhieuNhapSachByMa(int maPNS)
        {
            return PhieuNhapSach_DAO.SelectCTPhieuNhapSachByMa(maPNS);
        }
        //Thêm 1 phiếu nhập sách
        public static string ThemPhieuNhap(PhieuNhapSach_DTO p)
        {
            return PhieuNhapSach_DAO.InsertPhieuNhap(p);
        }
        //Thêm vào bảng CHITIET_PHIEUNHAP
        public static string ThemChiTietPhieuNhap(CT_PhieuNhapSach_DTO p)
        {
            if (PhieuNhapSach_DAO.GetPhieuNhapByName(p.MaPNS, p.MaSach) == null)
            {
                return PhieuNhapSach_DAO.Insert(p);
            }
            else
            {
                return "Sách này đã có trong chi tiet phieu nhap";
            }
        }
        //Lấy ra tháng theo MaPNS
        public static DataTable GetThangByMaPNS(int ma)
        {
            return PhieuNhapSach_DAO.GetThangByMaPNS(ma);
        }
        //Lấy ra năm theo MaPNS
        public static DataTable GetNamByMaPNS(int ma)
        {
            return PhieuNhapSach_DAO.GetNamByMaPNS(ma);
        }
        //Cập nhật tổng tiền
        public static void CapNhatTongTien(PhieuNhapSach_DTO p)
        {
            p.TongTien = UInt64.Parse(PhieuNhapSach_DAO.GetTongThanhTien(p.MaPNS).Rows[0].ItemArray[0].ToString());
            PhieuNhapSach_DAO.UpdateTongTien(p);
        }
        //Kiểm tra có phải là PHIEUNHAPSACH đầu tiên
        public static bool KiemTraDauTien(int ngay, int thang, int nam,int maSach)
        {
            DataTable dt = PhieuNhapSach_DAO.KiemTraDauTien(ngay,thang,nam,maSach);
            if (int.Parse(dt.Rows[0].ItemArray[0].ToString()) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
