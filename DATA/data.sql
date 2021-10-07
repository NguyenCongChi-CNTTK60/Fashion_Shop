CREATE DATABASE QuanLyCuaHangTienLoi
GO

USE QuanLyCuaHangTienLoi 
GO

CREATE TABLE dbo.ChiTietHD(
	MaHD nvarchar(50) NOT NULL,
	MaHang nvarchar(50) NOT NULL,
	SoLuong int NULL,
	DonGia float NULL,
)
GO

CREATE TABLE dbo.ChiTietPN(
	MaPN nchar(10) NOT NULL,
	MaHang nvarchar(50) NOT NULL,
	SoLuong int NULL,
	DonGia float NULL,
	)
GO

CREATE TABLE dbo.HangHoa(
	MaHang nvarchar(50) NOT NULL,
	TenHang nvarchar(50) NULL,
	DonVi nvarchar(20) NULL,
	GiaBan int NULL,
	SoLuong int NULL,
	)
GO


	CREATE TABLE dbo.HoaDon(
	MaHD nvarchar(50) NOT NULL,
	MaKH nchar(10) NULL,
	NgayTao date NOT NULL,
	TenDangNhap varchar(50) NOT NULL,
	TongTien int NOT NULL,
	)
GO


	CREATE TABLE dbo.KhachHang(
	MaKH varchar(20) NOT NULL,
	TenKH nvarchar(50) NOT NULL,
	GioiTinh bit NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(10) NOT NULL,
	Email nvarchar(50) NULL,
	)
GO

	CREATE TABLE dbo.NhaCungCap(
	MaNCC nchar(10) NOT NULL,
	TenNCC nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT int NULL,
	Email nvarchar(50) NULL,

	)
GO

	CREATE TABLE dbo.NhanVien(
	TenDangNhap varchar(50) NOT NULL,
	MatKhau varchar(50) NULL,
	TenNguoiDung nvarchar(50) NULL,
	Quyen nvarchar(20) NULL,

	)
GO

	CREATE TABLE dbo.PhieuNhap(
	MaPN nchar(10) NOT NULL,
	MaNCC nchar(10) NOT NULL,
	NgayNhap date NOT NULL,
	TenDangNhap varchar(50) NOT NULL,
	)
GO