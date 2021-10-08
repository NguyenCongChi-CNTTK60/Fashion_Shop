CREATE DATABASE QuanLyCuaHangTienLoi
GO

USE QuanLyCuaHangTienLoi 
GO


CREATE TABLE dbo.NHANVIEN (
	TenDangNhap varchar(50) PRIMARY KEY,
	MatKhau varchar(50) NULL,
	TenNguoiDung nvarchar(50) NULL,
	Quyen nvarchar(20) NULL,

	)
GO


CREATE TABLE dbo.KHACHHANG (
	MaKH varchar(20) PRIMARY KEY,
	TenKH nvarchar(50) NOT NULL,
	GioiTinh bit NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(10) NOT NULL,
	Email nvarchar(50) NULL,
	)
GO


CREATE TABLE dbo.HANGHOA (
	MaHang nvarchar(50) PRIMARY KEY,
	TenHang nvarchar(50) NULL,
	DonVi nvarchar(20) NULL,
	GiaBan int NULL,
	SoLuong int NULL,
	)
GO



CREATE TABLE dbo.HOADON (
	MaHD nvarchar(50) NOT NULL,
	MaKH nchar(10) NULL,
	NgayTao date NOT NULL,
	TenDangNhap varchar(50) NOT NULL,
	TongTien int NOT NULL,
	PRIMARY KEY(MaHD, MaKH),
	FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH),
	)
GO



CREATE TABLE dbo.NHACUNGCAP (
	MaNCC nchar(10) PRIMARY KEY,
	TenNCC nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT int NULL,
	Email nvarchar(50) NULL,

	)
GO



CREATE TABLE dbo.PHIEUNHAP (
	MaPN nchar(10) NOT NULL,
	MaNCC nchar(10) NOT NULL,
	TenDangNhap varchar(50) NOT NULL,
	NgayNhap date NOT NULL,
	PRIMARY KEY(MaPN, MaNCC, TenDangNhap),
	FOREIGN KEY (MaNCC) REFERENCES dbo.NHACUNGCAP(MaNCC),
	FOREIGN KEY (TenDangNhap) REFERENCES dbo.NHANVIEN(TenDangNhap)

	)
GO



CREATE TABLE [dbo].[DonViTinh] (
	[MaDVT] [varchar](10) NOT NULL,
	[TenDVT] [nvarchar](20) NOT NULL,
)
GO



CREATE TABLE [dbo].[LoaiThanhVien] (
	[MaLoai] [nchar](10) NULL,
	[TenLoai] [nvarchar](50) NULL,
	[QuyenLoi] [int] NULL
)
GO


CREATE TABLE dbo.CTHD (
	MaHD nvarchar(50) NOT NULL,
	MaHang nvarchar(50) NOT NULL,
	SoLuong int NULL,
	DonGia float NULL,
	PRIMARY KEY(MaHD, MaHang),
	FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
	FOREIGN KEY (MaHang) REFERENCES dbo.HANGHOA(MaHang)
)
GO



CREATE TABLE dbo.CTPN (
	MaPN nchar(10) NOT NULL,
	MaHang nvarchar(50) NOT NULL,
	SoLuong int NULL,
	DonGia float NULL,
	PRIMARY KEY(MaPN, MaHang),
	FOREIGN KEY (MaPN) REFERENCES dbo.PHIEUNHAP(MaPN),
	FOREIGN KEY (MaHang) REFERENCES dbo.HANGHOA(MaHang)
	)
GO



