CREATE DATABASE QuanLyKinhDoanhVangBacDaQuy
USE QuanLyKinhDoanhVangBacDaQuy

Create table PHIEUMUAHANG
(
	MaPhieuMua int primary key,
	MaNhaCungCap int,
	MaSanPham int,
	NgayMua date,
	SoLuong int,
	DonGia float,
)


Create table NHACUNGCAP
(
	MaNhaCungCap int primary key,
	TenNhaCungCap nvarchar(50),
	SoDienThoai nvarchar(50),
	DiaChi  nvarchar(50)

)

Create table SANPHAM
(
	MaSanPham int primary key,
	TenSanPham nvarchar(50),
	MaLoai int,
	SoLuong int,
	DonGia float,
	TinhTrang bit,
	NgayThayDoiSoLuong date,
	SoLuongTruoc int
)

Create table LICHSUKHO
(
	Ma int primary key,
	MaSanPham int,
	LoaiGiaoDich nvarchar(50),
	Ngay date,
	SoLuongTruoc int,
	SoLuongSau int
)

Create table LOAISANPHAM
(
	MaLoaiSP int primary key,
	TenLoaiSanPham nvarchar(50),
	DonViTinh nvarchar(10),
	LoiNhuan int
)


Create table PHIEUBANHANG
(
	MaPhieuBan int primary key,
	MaKhachHang int,
	MaNhanVien int,
	MaSanPham int,
	SoLuong int,
	NgayBan date
)

Create table KHACHHANG
(
	MaKhachHang int primary key,
	SoDienThoai nvarchar(50),
	TenKhachHang nvarchar(50),
)

Create table PHIEUDICHVU
(
	MaPhieuDichVu int primary key,
	MaKhachHang int,
	MaNhanVien int,
	MaDichVu int,
	SoLuong int,
	DonGia float,
	TraTruoc float,
	TinhTrang nvarchar(50),
	NgayBan date
)

Create table LOAIDICHVU
(
	MaDichVu int primary key,
	TenLoaiDichVu nvarchar(50),
	DonGia float
)

Create table NHANVIEN
(
	MaNhanVien int primary key,
	TenNhanVien nvarchar(50),
	TaiKhoan nvarchar(50),
	MatKhau nvarchar(50),
	ChucVu nvarchar(50)
)

/*Foreign key*/

Alter table PHIEUMUAHANG
Add constraint FK_PHIEUMUAHANG_SANPHAM_MaSanPham 
Foreign Key(MaSanPham) References SANPHAM(MaSanPham)

Alter table PHIEUMUAHANG
Add constraint FK_PHIEUMUAHANG_NHACUNGCAP_MaNhaCungCap
Foreign Key(MaNhaCungCap) References NHACUNGCAP(MaNhaCungCap)

Alter table SANPHAM
Add constraint FK_SANPHAM_LOAISANPHAM_MaLoai
Foreign Key(MaLoai) References LOAISANPHAM(MaLoaiSP)

Alter table LICHSUKHO
Add constraint FK_LICHSUKHO_SANPHAM_MaSanPham
Foreign Key(MaSanPham) References SANPHAM(MaSanPham)

Alter table PHIEUBANHANG
Add constraint FK_PHIEUBANHANG_SANPHAM_MaSanPham
Foreign Key(MaSanPham) References SANPHAM(MaSanPham)

Alter table PHIEUBANHANG
Add constraint FK_PHIEUBANHANG_KHACHHANG_MaKhachHang
Foreign Key(MaKhachHang) References KHACHHANG(MaKhachHang)

Alter table PHIEUDICHVU
Add constraint FK_PHIEUDICHVU_KHACHHANG_MaKhachHang
Foreign Key(MaKhachHang) References KHACHHANG(MaKhachHang)

Alter table PHIEUDICHVU
Add constraint FK_PHIEUDICHVU_LOAIDICHVU_MaLoaiDV
Foreign Key(MaDichVu) References LOAIDICHVU(MaDichVu)

Alter table PHIEUDICHVU
Add constraint FK_PHIEUDICHVU_NHANVIEN_MaNhanVien
Foreign Key(MaNhanVien) References NHANVIEN(MaNhanVien)

Alter table PHIEUBANHANG
Add constraint FK_PHIEUBANHANG_NHANVIEN_MaNhanVien
Foreign Key(MaNhanVien) References NHANVIEN(MaNhanVien)

/*Insert data*/
INSERT INTO NHACUNGCAP (MaNhaCungCap,TenNhaCungCap, SoDienThoai, DiaChi)
VALUES
    (1,'PNJ', '0886134456', N'214 Đường Hồ Gươm, Q.1, TP.HCM'),
    (2,'DOJI', '0909100900', N'412 Võ Nguyên Giáp, Q.5, TP.HCM'),
    (3,'SJC','0931224301', N'92 Đường Phan Xích Long, Q.1, TP.HCM'),
    (4,N'Bảo Tín Minh Châu','0966146979', N'24 Đường Lý Thường Kiệt, Q.9, TP.HCM');

INSERT INTO LOAIDICHVU (MaDichVu, TenLoaiDichVu, DonGia)
VALUES
	(1, N'Dịch vụ định giá và kiểm định', 200000),
    (2, N'Dịch vụ khôi phục', 400000),
    (3, N'Dịch vụ vệ sinh', 400000),
    (4, N'Dịch vụ đánh bóng', 500000);

INSERT INTO NHANVIEN(MaNhanVien, TenNhanVien, TaiKhoan, MatKhau, ChucVu)
VALUES
    (1, N'Nguyễn Thị Ánh', N'nguyenthianh', N'nta', N'Nhân viên bán hàng'),
	(2, N'Cao Bảo Hà', N'caobaoha', N'cbh', N'Nhân viên thu ngân'),
    (3, N'Trần Nhật Long', N'trannhatlong', N'tnl', N'Quản lý');

INSERT INTO KHACHHANG(MaKhachHang, SoDienThoai,TenKhachHang)
VALUES
    (1, '0913987654', N'Nguyễn Hồng Loan'),
    (2, '0913765432', N'Cao Quang Long'),
    (3, '0913554321', N'Huỳnh Anh Minh'),
    (4, '0913123456', N'Trần Minh Hiếu');

INSERT INTO LOAISANPHAM (MaLoaiSP, TenLoaiSanPham, DonViTinh, LoiNhuan)
VALUES
    (1, N'Dây chuyền kim cương', N'chiếc', 25 ),
    (2, N'Nhẫn vàng', N'chiếc', 30),
    (3, N'Vòng tay vàng', N'chiếc', 20),
    (4, N'Nhẫn kim cương', N'cặp', 35),
    (5, N'Dây chuyền đá quý', N'chiếc', 40);

INSERT INTO PHIEUDICHVU (MaPhieuDichVu, MaKhachHang, MaNhanVien, MaDichVu, SoLuong, DonGia, TraTruoc, TinhTrang, NgayBan)
VALUES
    (1, 1, 3, 1, 3, 400000, 0, N'Chưa thanh toán', '2024-08-11'),
    (2, 2, 2, 2, 2, 400000, 200000, N'Hoàn thành', '2024-08-05'),
    (3, 3, 1, 3, 4, 200000, 100000, N'Đang xử lý', '2024-10-3'),
    (4, 4, 3, 4, 7, 1000000, 500000, N'Hoàn thành', '2024-03-09');

INSERT INTO SANPHAM (MaSanPham, TenSanPham, MaLoai, SoLuong, DonGia, TinhTrang, NgayThayDoiSoLuong, SoLuongTruoc)
VALUES
    (1, N'Dây chuyền kim cương nam', 1, 11, 10000000, 1, '2023-11-02', 18),
    (2, N'Nhẫn vàng nam', 2, 6, 2000000, 1, '2023-08-21', 8),
    (3, N'Vòng tay vàng nam', 3, 18, 2000000, 1, '2023-08-12', 28),
    (4, N'Nhẫn kim cương nữ', 4, 6, 5000000, 1, '2023-08-20', 16),
    (5, N'Dây chuyền hồng ngọc', 5, 6, 6000000, 0, '2023-10-16', 8);

INSERT INTO PHIEUMUAHANG (MaPhieuMua, MaNhaCungCap, MaSanPham, NgayMua, SoLuong, DonGia)
VALUES
    (1, 1, 1, '2023-08-02', 12, 9000000),
    (2, 2, 2, '2023-10-12', 8, 1400000),
    (3, 3, 3, '2023-10-01', 16, 1000000),
    (4, 4, 4, '2023-08-20', 8, 4500000),
    (5, 4, 5, '2023-06-23', 6, 5000000);

INSERT INTO LICHSUKHO (Ma, MaSanPham, LoaiGiaoDich, Ngay, SoLuongTruoc, SoLuongSau)
VALUES
    (1, 1, N'Xuất hàng', '2023-03-02', 11, 18),
    (2, 2, N'Mua hàng', '2023-02-01', 6, 8),
    (3, 3, N'Xuất hàng', '2023-07-04', 18, 24),
    (4, 4, N'Mua hàng', '2023-06-10', 6, 16),
    (5, 5, N'Mua hàng', '2023-12-10', 2, 6);

INSERT INTO PHIEUBANHANG(MaPhieuBan, MaKhachHang, MaNhanVien, MaSanPham, SoLuong, NgayBan)
VALUES
    (1, 1, 3, 1, 2, '2023-09-10'),
    (2, 2, 2, 2, 3, '2023-10-05'),
    (3, 3, 1, 3, 2, '2023-09-20'),
    (4, 4, 3, 4, 1, '2023-09-25');

select * from PHIEUBANHANG
select * from PHIEUDICHVU
select * from KHACHHANG
select * from LICHSUKHO
select * from LOAIDICHVU
select * from LOAISANPHAM
select * from NHACUNGCAP
select * from NHANVIEN
select * from PHIEUMUAHANG
select * from SANPHAM

--use master
--ALTER DATABASE QuanLyKinhDoanhVangBacDaQuy SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--DROP DATABASE QuanLyKinhDoanhVangBacDaQuy;

GO
CREATE PROCEDURE Danh_Sach_Nhan_Vien_Theo_ID @MaNhanVien int
AS
BEGIN
    SELECT * FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien;
END;
GO

EXEC Danh_Sach_Nhan_Vien_Theo_ID @MaNhanVien = 1

GO
CREATE PROC USP_Login
@TaiKhoan nvarchar(50), @MatKhau nvarchar(50)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE TaiKhoan = @TaiKhoan And MatKhau = @MatKhau
END
Go
