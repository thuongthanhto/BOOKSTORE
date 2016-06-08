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
    public class PhieuThuTien_BUS
    {
        //Xóa phiếu thu tiền
        public static string XoaPhieuThu(PhieuThuTien_DTO pt)
        {
            if (PhieuThuTien_DAO.GetPhieuThuByMa(pt.MaPT) != null)
            {
                return PhieuThuTien_DAO.Delete(pt);              
            }
            else
            {
                return "Mã phiếu thu không tồn tại";
            }
        }
        //Lấy tất cả phiếu thu
        public static DataTable GetPhieuThuAll()
        {
            return PhieuThuTien_DAO.GetPhieuThuAll();
        }
        
        public static string SuaPhieuThu(PhieuThuTien_DTO pt)
        {
            if (PhieuThuTien_DAO.GetPhieuThuByMa(pt.MaPT) != null)
            {
                return PhieuThuTien_DAO.Update(pt);
            }
            else
            {
                return "Mã không tồn tại trong Cơ sở dữ liệu";
            }
        }
        public static string ThemPhieuThu(PhieuThuTien_DTO pt)
        {
            if (PhieuThuTien_DAO.GetPhieuThuByMa(pt.MaPT) == null)
            {
                return PhieuThuTien_DAO.Insert(pt);
            }
            else
            {
                return "Phiếu thu đã tồn tại trong cơ sở dữ liệu";
            }
        }
    }
}
