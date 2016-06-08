using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThamSo_DAO
    {
        //Lấy ra MaThamSo bằng ma không có thì trả về null
        public static ThamSo_DTO LayThamSoBangMa(int ma)
        {
            string sql = "select * from THAMSO where MaThamSo=" + ma + "";
            DataTable dt = DataAccess.ThucThiQuery(sql);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                ThamSo_DTO ts = new ThamSo_DTO();
                ts.MaThamSo = (int)dt.Rows[0].ItemArray[0];
                return ts;
            }
        }
        //Lấy tất cả các tham số trong bảng THAMSO
        public static DataTable GetThamSoAll()
        {
            string sql = "select * from THAMSO";
            return DataAccess.ThucThiQuery(sql);
        }
        //Cập nhật các cột trong bảng THAMSO
        public static string CapNhat(ThamSo_DTO ts)
        {
            string sql = "update THAMSO set TiLeTinhDonGiaBan="+ts.TiLeTinhDonGiaBan+",SoLuongNhapToiThieu="+ts.SoLuongNhapToiThieu+",SoLuongTonToiThieu="+ts.SoLuongTonToiThieu+",SoLuongTonToiDa="+ts.SoLuongTonToiDa+",SoTienNoToiDa="+ts.SoTienNoToiDa+",ApDungQuyDinh4="+ts.ApDungQuyDinh4+" where MaThamSo = "+ts.MaThamSo+"";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Thêm mới 1 tham số
        public static string Them(ThamSo_DTO ts)
        {
            string sql = "insert into THAMSO(TiLeTinhDonGiaBan,SoLuongNhapToiThieu,SoLuongTonToiThieu,SoLuongTonToiDa,SoTienNoToiDa,ApDungQuyDinh4) values (" + ts.TiLeTinhDonGiaBan + "," + ts.SoLuongNhapToiThieu + "," + ts.SoLuongTonToiThieu + "," + ts.SoLuongTonToiDa + "," + ts.SoTienNoToiDa + "," + ts.ApDungQuyDinh4 + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Lấy số lượng tồn từ bảng SACH theo MaSach
        public static DataTable SelectSoLuongTon(int masach)
        {
            string sql = "select * from SACH where MaSach=" + masach + "";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy số tiền nợ của khách hàng theo MaKH
        static public DataTable SelectTienNoKH(int maKH)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + maKH + "";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
