CREATE DATABASE QLCuaHangThoiTrang 
GO


USE QLCuaHangThoiTrang
GO


-- 1
CREATE TABLE NhaCungCap (
	MaNCC varchar(10) PRIMARY KEY,
	TenNCC nvarchar(50) NOT NULL,
	DiaChi nvarchar(50) NOT NULL,
	SDT varchar(10) NOT NULL,
	Email nvarchar(50) NULL,
) 
GO


-- 2
CREATE TABLE KhachHang (
	MaKH varchar(10) PRIMARY KEY,
	TenKH nvarchar(50) NOT NULL,
	GioiTinh nvarchar (10) NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(10) NOT NULL,
	Email nvarchar(50) NULL,

) 
GO


-- 3
create table CaLamViec (
    MaCLV varchar(10)  PRIMARY KEY,
	Ca nvarchar(10) NOT NULL,
)
GO


-- 4
CREATE TABLE NhanVien (
    MaNV varchar(10) PRIMARY KEY,
	TenHienThi nvarchar(50) NULL,
	GioiTinh nvarchar (20) NULL,
	DiaChi nvarchar(50) NULL,
	SDT nvarchar(10) NOT NULL,
	Quyen nvarchar(20) NULL,
	TenDangNhap varchar(50) NOT NULL,
	MatKhau varchar(50) NOT NULL,
) 
GO


--- 5
CREATE TABLE GiamGia(
     MaGG varchar (10) PRIMARY KEY,
	 PhanTram int,
)


--- 6
CREATE TABLE LoaiHang(
     MaLH varchar (10) PRIMARY KEY NOT NULL,
	 TenLH nvarchar (50),
)

-- 7
CREATE TABLE MatHang (
	MaMH varchar(10) PRIMARY KEY,
	TenMH nvarchar(50) NOT NULL,
	DonVi nvarchar (10) NULL,
	GiaBan int  NULL,
	SoLuong int NULL,
	MaLH varchar (10),
	Anh image NULL, 

	FOREIGN KEY(MaLH) REFERENCES LoaiHang(MaLH),
) 
GO


-- 8
CREATE TABLE HoaDon (
	MaHD varchar(10) PRIMARY KEY,
	MaKH varchar(10) NOT NULL,
	NgayTao date NOT NULL,
	MaNV varchar(10) NOT NULL,
	TongTien int NOT NULL,
	FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
	FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)

) 
GO


-- 9
CREATE TABLE PhieuNhap (
	MaPN varchar(10) PRIMARY KEY,
	MaNCC varchar(10) NOT NULL,
	NgayNhap date NOT NULL,
	MaNV varchar(10) NOT NULL,
	FOREIGN KEY(MaNCC) REFERENCES NhaCungCap(MaNCC),
	FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
) 
GO


-- 10
CREATE TABLE ChiTietHD (
	MaHD varchar(10) NOT NULL,
	MaMH varchar(10) NOT NULL,
	SoLuong int NOT NULL,
	DonGia float NOT NULL,
    FOREIGN KEY(MaMH) REFERENCES MatHang(MaMH),
	FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD)
) 
GO



-- 11
CREATE TABLE ChiTietPN (
	MaPN varchar(10),
	MaMH varchar(10) NOT NULL,
	SoLuong int NULL,
	DonGia float NULL,
    FOREIGN KEY(MaMH) REFERENCES MatHang(MaMH),
	FOREIGN KEY(MaPN) REFERENCES PhieuNhap(MaPN)
) 
GO


-- 12
CREATE TABLE ChiTietCLV (
	MaCLV varchar(10) NOT NULL,
	MaNV varchar(10) NOT NULL,
	NgayLam date NOT NULL,
	FOREIGN KEY(MaCLV) REFERENCES CaLamViec(MaCLV),
    FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
) 
GO



--- 13
CREATE TABLE ChiTietGiamGia(
       MaMH varchar (10) NOT NULL,
	   MaGG varchar (10) NOT NULL,
	   NgayBD date,
	   NgayKT date,

	   FOREIGN KEY(MaMH) REFERENCES MatHang(MaMH),
       FOREIGN KEY(MaGG) REFERENCES GiamGia(MaGG),
)



---
--- 1. INSERT GIẢM GIÁ 
---
INSERT GiamGia (MaGG,PhanTram)
VALUES ('GG001',10)
INSERT GiamGia (MaGG,PhanTram)
VALUES ('GG002',15)
INSERT GiamGia (MaGG,PhanTram)
VALUES ('GG003',20)
INSERT GiamGia (MaGG,PhanTram)
VALUES ('GG004',25)


---
--- 2. INSERT CA LÀM VIỆC
---
INSERT CaLamViec (MaCLV, Ca )VALUES (N'CLV01', N'Sáng')
INSERT CaLamViec (MaCLV, Ca )VALUES (N'CLV02', N'Chiều')
INSERT CaLamViec (MaCLV, Ca )VALUES (N'CLV03', N'Tối')
GO

---
--- 3. INSERT NHÀ CUNG CẤP 
---
INSERT NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email) VALUES (N'NCC001  ', N'Công ty thời trang Elise', N'Quận 1, Hồ Chí Minh', N'0123456789', N'ctyelise@gmail.com')
INSERT NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email) VALUES (N'NCC002  ', N'Công ty thời trang H&A', N'Quận 3, Hồ Chí Minh', N'0123456789', N'h&a@gmail.com')
INSERT NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email) VALUES (N'NCC003  ', N'Công ty thời trang Hạnh', N'Quận 8, Hồ Chí Minh', N'0123456789', N'hanh@gmail.com')
INSERT NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email) VALUES (N'NCC004  ', N'Công ty may thời trang An Phước.', N'Quận 9, Hồ Chí Minh', N'0123456789', N'anphuoc@gmail.com')
GO


-----
----- 4. INSERT KHÁCH HÀNG
-----
INSERT KhachHang (MaKH, TenKH, GioiTinh, DiaChi, SDT, Email) VALUES (N'KH001', N'Phan Thị Cẩm', N'Nữ', N'Quận 9 , TP.Hồ Chí Minh', N'0235958952', N'phamthicam@gmail.com') 
INSERT KhachHang (MaKH, TenKH, GioiTinh, DiaChi, SDT, Email) VALUES (N'KH002', N'Nguyễn Thị Hồng',N'Nữ', N'Quận 8, TP.Hồ Chí Minh', N'0365895744', N'nguyenthihong@gmail.com') 
INSERT KhachHang (MaKH, TenKH, GioiTinh, DiaChi, SDT, Email) VALUES (N'KH003', N'Nguyễn Thị Quỳnh Như', N'Nữ', N'Quận 4, Hồ Chí Minh', N'0325895852', N'nguyenthiquynhu@gmail.com') 
INSERT KhachHang (MaKH, TenKH, GioiTinh, DiaChi, SDT, Email) VALUES (N'KH004', N'Trần Thị Hà Trinh', N'Nữ', N'Quận 8, Hồ Chí Minh', N'0365895532', N'tranthihatrinh@gmail.com') 
GO


-----
----- 5. INSERT NHÂN VIÊN ------
----  
INSERT NhanVien(MaNV, TenHienThi, DiaChi,SDT, Quyen,TenDangNhap, MatKhau) 
VALUES (N'NV001', N'Bùi Văn Tân', N'Quận 9, TP.Hồ Chí Minh','0963528491', N'Quản lý', N'tan', N'123')
INSERT NhanVien(MaNV, TenHienThi, DiaChi,SDT, Quyen,TenDangNhap, MatKhau) 
VALUES (N'NV002', N'Võ Văn Trí', N'Quận 8, TP.Hồ Chí Minh','0328644278', N'Nhân Viên', N'tri', N'1234')
INSERT NhanVien(MaNV, TenHienThi, DiaChi,SDT, Quyen, TenDangNhap, MatKhau)
VALUES (N'NV003', N'Nguyễn Công Chí', N'Quận 9, TP.Hồ Chí Minh','0328644258', N'Nhân Viên', N'chi', N'123')
INSERT NhanVien(MaNV, TenHienThi, DiaChi,SDT, Quyen, TenDangNhap, MatKhau)
VALUES (N'NV004', N'Huỳnh Xuân Lãm', N'Quận 9, TP.Hồ Chí Minh','0987528554', N'Nhân Viên', N'lam', N'123')
INSERT NhanVien(MaNV, TenHienThi, DiaChi,SDT, Quyen, TenDangNhap, MatKhau)
VALUES (N'NV005', N'Hồ Ngọc Thống', N'Quận 9, TP.Hồ Chí Minh','0966522011', N'Nhân Viên', N'thong', N'123')




---
--- 6. INSERT LOẠI HÀNG 
---
INSERT LoaiHang(MaLH,TenLH)
VALUES ('LH001',N'Đầm')
INSERT LoaiHang(MaLH,TenLH)
VALUES ('LH002',N'Áo')
INSERT LoaiHang(MaLH,TenLH)
VALUES ('LH003',N'Quần')
INSERT LoaiHang(MaLH,TenLH)
VALUES ('LH004',N'Váy')



---
--- 7. INSERT HÀNG HÓA
---
INSERT MatHang(MaMH, TenMH, DonVi, GiaBan, SoLuong,MaLH,Anh) 
VALUES (N'SP001', N'Đầm tím tay lửng',N'Chiếc', 399000,185,'LH001',null)
INSERT MatHang(MaMH, TenMH, DonVi, GiaBan, SoLuong,MaLH,Anh) 
VALUES (N'SP002', N'Đầm kẻ cổ trắng',N'Chiếc', 399000,190,'LH001',null)
INSERT MatHang(MaMH, TenMH, DonVi, GiaBan, SoLuong,MaLH,Anh) 
VALUES (N'SP003', N'Áo thum đỏ tay',N'Chiếc', 145000,200,'LH002',null)
INSERT MatHang(MaMH, TenMH, DonVi, GiaBan, SoLuong,MaLH,Anh) 
VALUES (N'SP004', N'Áo thum tay trắng',N'Chiếc', 199000,200,'LH002',null)
INSERT MatHang(MaMH, TenMH, DonVi, GiaBan, SoLuong,MaLH,Anh) 
VALUES (N'SP005', N'Quần dài nâu đậm',N'Chiếc', 199000,200,'LH003',null)
INSERT MatHang(MaMH, TenMH, DonVi, GiaBan, SoLuong,MaLH,Anh) 
VALUES (N'SP006', N'Quần sooc xanh ly',N'Chiếc', 199000,200,'LH003',null)
GO



-----
----- 8. INSERT HÓA ĐƠN  (TỔNG TIỀN = SL * ĐƠN GIÁ) Ở BẢNG CTHOADON
-----
INSERT HoaDon (MaHD, MaKH, NgayTao, MaNV, TongTien) VALUES (N'HD001', N'KH001     ', CAST(N'2021-11-20' AS Date), N'NV001', 2000000)
INSERT HoaDon (MaHD, MaKH, NgayTao, MaNV, TongTien) VALUES (N'HD002', N'KH002     ', CAST(N'2021-11-21' AS Date), N'NV003', 1200000)
INSERT HoaDon (MaHD, MaKH, NgayTao, MaNV, TongTien) VALUES (N'HD003', N'KH003     ', CAST(N'2021-11-21' AS Date), N'NV003', 2800000)
INSERT HoaDon (MaHD, MaKH, NgayTao, MaNV, TongTien) VALUES (N'HD004', N'KH004     ', CAST(N'2021-11-22' AS Date), N'NV003', 3200000)
INSERT HoaDon (MaHD, MaKH, NgayTao, MaNV, TongTien) VALUES (N'HD005', N'KH004     ', CAST(N'2021-11-23' AS Date), N'NV004', 800000)




-----
----- 9. INSERT PHIỂU NHẬP   (NGÀY NHẬP HÀNG PHẢI TRƯỚC NGÀY BÁN)
-----
INSERT PhieuNhap (MaPN, MaNCC, NgayNhap, MaNV) VALUES (N'PN001     ', N'NCC001    ', CAST(N'2021-11-19' AS Date), N'NV001')
INSERT PhieuNhap (MaPN, MaNCC, NgayNhap, MaNV) VALUES (N'PN002     ', N'NCC002    ', CAST(N'2021-11-19' AS Date), N'NV001')
INSERT PhieuNhap (MaPN, MaNCC, NgayNhap, MaNV) VALUES (N'PN003     ', N'NCC003    ', CAST(N'2021-11-19' AS Date), N'NV001')
INSERT PhieuNhap (MaPN, MaNCC, NgayNhap, MaNV) VALUES (N'PN004     ', N'NCC004    ', CAST(N'2021-11-19' AS Date), N'NV001')



---- 
---- 10. INSERT CHI TIẾT HÓA ĐƠN 
----
INSERT ChiTietHD (MaHD, MaMH, SoLuong, DonGia) VALUES (N'HD001', N'SP001', 5, 400000)   
INSERT ChiTietHD (MaHD, MaMH, SoLuong, DonGia) VALUES (N'HD002', N'SP001', 3, 400000)  
INSERT ChiTietHD (MaHD, MaMH, SoLuong, DonGia) VALUES (N'HD003', N'SP001', 7, 400000)    
INSERT ChiTietHD (MaHD, MaMH, SoLuong, DonGia) VALUES (N'HD004', N'SP002', 8, 400000)  
INSERT ChiTietHD (MaHD, MaMH, SoLuong, DonGia) VALUES (N'HD005', N'SP002', 2, 400000)
GO


----
---- 11. INSERT CHI TIẾT PHIỂU NHẬP 
----
INSERT ChiTietPN (MaPN, MaMH, SoLuong, DonGia) VALUES (N'PN001     ', N'SP001', 200, 350000) -- 1
INSERT ChiTietPN (MaPN, MaMH, SoLuong, DonGia) VALUES (N'PN001     ', N'SP002', 200, 360000) -- 1
INSERT ChiTietPN (MaPN, MaMH, SoLuong, DonGia) VALUES (N'PN001     ', N'SP003', 200, 110000) -- 1
INSERT ChiTietPN (MaPN, MaMH, SoLuong, DonGia) VALUES (N'PN002     ', N'SP004', 200, 170000) -- 1
INSERT ChiTietPN (MaPN, MaMH, SoLuong, DonGia) VALUES (N'PN003     ', N'SP005', 200, 160000) -- 2
INSERT ChiTietPN (MaPN, MaMH, SoLuong, DonGia) VALUES (N'PN004     ', N'SP006', 200, 150000)  -- 2
GO


---
--- 12. INSERT CHI TIẾT GIẢM GIÁ 
---
INSERT ChiTietGiamGia (MaMH,MaGG,NgayBD,NgayKT)
VALUES ('SP002','GG001',CAST(N'2021-12-2' AS Date),CAST(N'2021-12-5' AS Date))


---
--- 13. INSERT CHI TIẾT CA LÀM VIỆC
---
INSERT ChiTietCLV(MaCLV,MaNV,NgayLam)
VALUES ('CLV01','NV001',CAST(N'2021-11-19' AS Date))
INSERT ChiTietCLV(MaCLV,MaNV,NgayLam)
VALUES ('CLV01','NV001',CAST(N'2021-11-20' AS Date))
INSERT ChiTietCLV(MaCLV,MaNV,NgayLam)
VALUES ('CLV02','NV002',CAST(N'2021-11-20' AS Date))
INSERT ChiTietCLV(MaCLV,MaNV,NgayLam)
VALUES ('CLV02','NV003',CAST(N'2021-11-20' AS Date))
INSERT ChiTietCLV(MaCLV,MaNV,NgayLam)
VALUES ('CLV03','NV004',CAST(N'2021-11-21' AS Date))





---- PTROC

--- 1
CREATE PROC USP_TKPhieuNhap
as 
select MaPN as [Mã phiểu nhập], NgayNhap as[ Ngày nhập hàng],TenNCC as [Nhà cung cấp],TenHienThi as [Nhân viên nhập] 
from PhieuNhap inner join NhaCungCap on PhieuNhap.MaNCC = NhaCungCap.MaNCC inner join NhanVien on PhieuNhap.MaNV = NhanVien.MaNV


--- 2 
create proc [dbo].[USP_XemChiTietPN](
   @mapn nchar (10)
)
as
select ChiTietPN.MaPN,ChiTietPN.MaMH,MatHang.TenMH,ChiTietPN.SoLuong,ChiTietPN.DonGia,PhieuNhap.MaNV,NhanVien.TenHienThi,NhanVien.Quyen,PhieuNhap.MaNCC,NhaCungCap.TenNCC,PhieuNhap.NgayNhap
from  ChiTietPN inner join MatHang on ChiTietPN.MaMH = MatHang.MaMH inner join PhieuNhap on ChiTietPN.MaPN = PhieuNhap.MaPN inner join NhanVien on NhanVien.MaNV = PhieuNhap.MaNV inner join NhaCungCap on PhieuNhap.MaNCC = NhaCungCap.MaNCC
where ChiTietPN.MaPN = @mapn


--- 3
create proc [dbo].[USP_TKMatHang]
as
select MatHang.MaMH as [Mã hàng hóa],MatHang.TenMH as [Tên hàng hóa],DonVi as [Đơn vị],sum(ChitietPN.Soluong) as [Số lượng nhập],MatHang.SoLuong as [Số lượng tồn], (sum(ChitietPN.Soluong) - MatHang.SoLuong) as [Số lượng bán],MatHang.GiaBan as [Giá bán]
from MatHang inner join ChiTietPN on MatHang.MaMH = ChiTietPN.MaMH 
group by MatHang.MaMH,MatHang.SoLuong,MatHang.TenMH,MatHang.DonVi,DonVi,MatHang.GiaBan


--- 4
CREATE PROCEDURE [dbo].[USP_TKKhachHang]
AS
BEGIN
select KhachHang.MaKH as [Mã khách hàng], KhachHang.TenKH as [Tên khách hàng], KhachHang.SDT as [Số điện thoại],SUM(HoaDon.TongTien) AS [Tổng Tiền], COUNT(HoaDon.MaHD) AS [Số lần mua hàng]
from HoaDon, KhachHang
where KhachHang.MaKH = HoaDon.MaKH
group by KhachHang.TenKH, KhachHang.MaKH, KhachHang.SDT, KhachHang.DiaChi, KhachHang.Email
END








