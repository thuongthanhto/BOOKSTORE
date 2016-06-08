using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
        int _maSach;

        public int MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        int _maDauSach;

        public int MaDauSach
        {
            get { return _maDauSach; }
            set { _maDauSach = value; }
        }
        string _nhaXuatBan;

        public string NhaXuatBan
        {
            get { return _nhaXuatBan; }
            set { _nhaXuatBan = value; }
        }
        int _namXuatBan;

        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set { _namXuatBan = value; }
        }
        int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }
        UInt64 _donGiaBan;

        public UInt64 DonGiaBan
        {
            get { return _donGiaBan; }
            set { _donGiaBan = value; }
        }
    }
}
