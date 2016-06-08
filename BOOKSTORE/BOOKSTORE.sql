create database BOOKSTORE
go
use BOOKSTORE
go

create table THELOAI
(
	MaTheLoai int identity(1,1) not null,
	TenTheLoai nvarchar(50),

	constraint PK_THELOAI primary key(MaTheLoai)
)
go
create table DAUSACH
(
	MaDauSach int identity(1,1) not null,
	TenDauSach nvarchar(50),
	MaTheLoai int,
		
	constraint PK_DAUSACH primary key(MaDauSach),
	constraint FK_DAUSACH_THELOAI foreign key(MaTheLoai) references THELOAI(MaTheLoai)
)
go
create table CT_TACGIA
(
	MaDauSach int not null,
	TacGia nvarchar(50) not null,

	constraint PK_CT_TACGIA primary key(MaDauSach,TacGia),
	constraint FK_CT_TACGIA_DAUSACH foreign key(MaDauSach) references DAUSACH(MaDauSach)
)
go
create table SACH
(
	MaSach int identity(1,1) not null,
	MaDauSach int,
	NhaXuatBan nvarchar(100),
	NamXuatBan int,
	SoLuongTon int,
	DonGiaBan bigint,

	constraint PK_SACH primary key(MaSach),
	constraint FK_SACH_DAUSACH foreign key(MaDauSach) references DAUSACH(MaDauSach)
)
go
create table PHIEUNHAPSACH
(
	MaPNS int identity(1,1) not null,
	NgayNhap datetime,
	TongTien bigint,

	constraint PK_PHIEUNHAPSACH primary key(MaPNS),
)
go
create table CT_PHIEUNHAPSACH
(
	MaPNS int not null,
	MaSach int not null,
	SoLuongNhap int, 
	DonGiaNhap bigint,
	ThanhTien bigint,

	constraint PK_CT_PHIEUNHAPSACH primary key(MaPNS,MaSach),
	constraint FK_CT_PHIEUNHAPSACH_PHIEUNHAPSACH foreign key(MaPNS) references PHIEUNHAPSACH(MaPNS),
	constraint FK_CT_PHIEUNHAPSACH_SACH foreign key(MaSach) references SACH(MaSach)
)
go
create table KHACHHANG
(
	MaKhachHang int identity(1,1) not null,
	TenKhachHang nvarchar(50),
	DiaChi nvarchar(100),
	SDT nvarchar(50),
	Email nvarchar(50),
	SoTienNo bigint,

	constraint PK_KHACHHANG primary key(MaKhachHang)
)
go
create table HOADON
(
	MaHD int identity(1,1) not null,
	MaKhachHang int,
	NgayLap datetime,
	TongTien bigint,
	ThanhToan bigint,
	ConLai bigint,

	constraint PK_HOADON primary key(MaHD),
	constraint FK_HOADON_KHACHHANG foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)
)
go
create table CT_HOADON 
(
	MaHD int not null,
	MaSach int not null,
	SoLuong int,
	DonGia bigint,
	ThanhTien bigint,

	constraint PK_CT_HOADON primary key(MaHD,MaSach),
	constraint FK_CT_HOADON_SACH foreign key(MaSach) references SACH(MaSach),
	constraint FK_CT_HOADON_HOADON foreign key(MaHD) references HOADON(MAHD)
)
go
create table PHIEUTHUTIEN
(
	MaPT int identity(1,1) not null,
	MaKhachHang int,
	NgayLap datetime,
	SoTienThu bigint,

	constraint PK_PHIEUTHUTIEN primary key(MaPT),
	constraint FK_PHIEUTHUTIEN foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)
)
go
create table BAOCAOTON
(
	Thang int not null,
	Nam int not null,
	MaSach int not null,
	TonDau int default 0,
	PhatSinh int default 0,
	TonCuoi int default 0,

	constraint PK_BAOCAOTON primary key(Thang,Nam,MaSach),
	constraint FK_BAOCAOTON foreign key(MaSach) references SACH(MaSach)
)
go
create table BAOCAOCONGNO
(
	Thang int not null,
	Nam int not null,
	MaKhachHang int not null,
	NoDau bigint default 0,
	PhatSinh bigint default 0,
	NoCuoi bigint default 0,

	constraint PK_BAOCAOCONGNO primary key(Thang,Nam,MaKhachHang),
	constraint FK_BAOCAOCONGNO foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)
)
go
create table THAMSO
(
	MaThamSo int identity not null,
	TiLeTinhDonGiaBan int,
	SoLuongNhapToiThieu int,
	SoLuongTonToiThieu int,
	SoLuongTonToiDa int,
	SoTienNoToiDa bigint,
	ApDungQuyDinh4 int,

	constraint PK_THAMSO primary key(MaThamSo)
)
go
create table QUYEN
(
	MaQuyen int not null, 
	TenQuyen nvarchar(50),

	constraint PK_QUYEN primary key(MaQuyen)
)
go
create table NGUOIDUNG
(
	TaiKhoan nvarchar(50) not null,
	MatKhau nvarchar(50),	
	MaQuyen int,

	constraint PK_NGUOIDUNG primary key(TaiKhoan),
	constraint FK_NGUOIDUNG_QUYEN foreign key(MaQuyen) references QUYEN(MaQuyen)
)
go
insert into QUYEN values(1,N'Quản lý nhà sách')
insert into QUYEN values(2,N'Thủ kho')
insert into QUYEN values(3,N'Nhân viên bán hàng')
insert into NGUOIDUNG values('Admin',123456,1)

insert into THELOAI values(N'Truyện tranh')
insert into THELOAI values(N'Tiểu thuyết')
insert into THELOAI values(N'Công nghệ thông tin')
insert into THELOAI values(N'Kinh tế')

