CREATE DATABASE QLCHDH
GO 

USE QLCHDH
GO 

CREATE TABLE KHACHHANG(
	MAKH VARCHAR(10) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(200) NOT NULL,
	NGSINH DATE NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	SDT VARCHAR(10) NOT NULL
)
GO 

CREATE TABLE NHANVIEN(
	MANV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNV NVARCHAR(200) NOT NULL,
	NGAYSINH DATE NOT NULL,
	DIACHI NVARCHAR(40) NOT NULL,
	SDT VARCHAR(20) NOT NULL,
	NGAYVAOLAM DATE NOT NULL
)
GO 

CREATE TABLE CHAMCONG
(	
	MANV VARCHAR(10) NOT NULL,
	NGAYLAM DATE NOT NULL,
	TIENLUONG DECIMAL NULL,

	PRIMARY KEY (MANV, NGAYLAM),
	FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV)
)
GO 

CREATE TABLE NHACUNGCAP(
	MANCC VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNCC NVARCHAR(200) NOT NULL
)
GO 

CREATE TABLE LOAISANPHAM(
	MALSP VARCHAR(10) NOT NULL PRIMARY KEY,
	TENLSP NVARCHAR(200) NOT NULL
)
GO 

CREATE TABLE SANPHAM(	
	MASP VARCHAR(10) NOT NULL PRIMARY KEY,
	TENSP NVARCHAR(200) NOT NULL,
	SOLUONG INT NOT NULL,
	GIAMUA DECIMAL NOT NULL,
	GIABAN DECIMAL NOT NULL,	
	MALSP VARCHAR(10) NOT NULL,
	MANCC VARCHAR(10) NOT NULL,
	HinhAnh IMAGE NULL,
	FOREIGN KEY (MALSP) REFERENCES LOAISANPHAM,
	FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP
)
GO 

CREATE TABLE HOADON(
	SOHD INT IDENTITY PRIMARY KEY, 
	MANV VARCHAR(10) NOT NULL,
	MAKH VARCHAR(10) NOT NULL,
	NGAYLAPHOADON DATETIME NOT NULL,
	THANHTIENHD DECIMAL NULL,
	TRANGTHAI NVARCHAR(30) NULL,
	FOREIGN KEY (MANV) REFERENCES NHANVIEN,
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG
)
GO 

CREATE TABLE CTHD(
	SOHD INT NOT NULL, 
	MASP VARCHAR(10) NOT NULL, 	
	SOLUONG INT NOT NULL, 
	DONGIASP DECIMAL NULL,
	THANHTIENSP DECIMAL NULL
	PRIMARY KEY(MASP, SOHD),
	
	FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP),
	FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD)
)
GO 

CREATE TABLE [USER]
(
	IDUSER INT PRIMARY KEY IDENTITY,
	UserName VARCHAR(20) NOT NULL,
	[Password] VARCHAR(20) NOT NULL,
	HOTEN NVARCHAR(100) NOT NULL,
	QUYEN NVARCHAR(20) NOT NULL
)
GO 

INSERT INTO dbo.NHANVIEN(MANV, TENNV, NGAYSINH, DIACHI, SDT, NGAYVAOLAM)
VALUES('NV1', N'Nhân viên A', '1/1/2001', N'Q1 - TP.HCM', '0123456788', '10/10/2020'),
	('NV2', N'Nhân viên B', '2/2/2001', N'Q2 - TP.HCM', '0234567891', '8/8/2020')

INSERT INTO dbo.KHACHHANG(MAKH, TENKH, NGSINH, DIACHI, SDT)
VALUES('KH1', N'Khách hàng 01', '11/11/2001', N'Q.Đống Đa - Hà Nội', '0868686868'),
	('KH2', N'Khách hàng 02', '12/12/2001', N'Q.Hai Bà Trưng - Hà Nội', '0969969696'),
	('KH3', N'Khách hàng 03', '11/11/2002', N'Q.Cầu Giấy - Hà Nội', '0585858585'),
	('KH4', N'Khách hàng 04', '12/12/2002', N'Q.Long Biên - Hà Nội', '0686868686'),
	('KH5', N'Khách hàng 05', '1/11/2003', N'Q.Hoàn Kiếm - Hà Nội', '0245454545'),
	('KH6', N'Khách hàng 06', '12/12/2003', N'Q.Long Biên - Hà Nội', '0679797979')

INSERT INTO dbo.LOAISANPHAM(MALSP, TENLSP)
VALUES('DH1', N'Đồng hồ thạch anh'),
	('DH0', N'Đồng hồ cơ'),
	('DH3', N'Đồng hồ Chronograph'),
	('DH4', N'Đồng hồ solar'),
	('DH5', N'Đồng hồ đeo tay thông minh')

INSERT INTO dbo.[User](UserName, [Password], HOTEN, QUYEN)
VALUES('Admin', 'Admin', N'Sếp', 'Admin'),
	('nv1', '12345', N'Nhân viên 1', 'User'),
	('nv2', '54321', N'Nhân viên 2', 'User')

INSERT INTO dbo.NHACUNGCAP(MANCC, TENNCC)
VALUES('NCC01', N'Xưởng Đồng Hồ Luxury Fashion'),
	('NCC02', N'Xưởng Đồng Hồ Giá Sỉ Zwatch'),
	('NCC03', N'Đồng hồ Tân Thế Kỷ')

INSERT INTO	dbo.SANPHAM(MASP, TENSP, SOLUONG, GIAMUA, GIABAN, MALSP, MANCC, HinhAnh)
VALUES('DH1', N'Đồng Hồ nam Thạch Anh', 5, 450000, 467000, 'DH01', 'NCC02', (SELECT * FROM	OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng Hồ Đeo Tay Nam Thạch Anh.png', SINGLE_BLOB) IMAGE)),
	('DH2', N'Đồng Hồ nam Quartz', 5, 400000, 450000, 'DH01', 'NCC02', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng Hồ Nam Quartz Thời Trang Nam Ochstin.png', SINGLE_BLOB) IMAGE)),
	('DH3', N'Đồng Hồ nam Hannah Martin Men Leather', 5, 300000, 312000, 'DH01', 'NCC03', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng Hồ Đeo Tay Nam Hannah Martin Men Leather.png', SINGLE_BLOB) IMAGE)),
	('DH4', N'Đồng hồ FREDERIQUE CONSTANT 40 mm', 5, 45000000, 48016000, 'DH02', 'NCC01', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\FREDERIQUE CONSTANT 40 mm Automatic kính sapphire Classics.png', SINGLE_BLOB) IMAGE)),
	('DH5', N'Đồng Hồ nữ Bulova', 5, 8500000, 9035000, 'DH02', 'NCC01', (SELECT * FROM	OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng hồ Nữ Bulova.png', SINGLE_BLOB) IMAGE)),
	('DH6', N'Đồng Hồ ORIENT 39.3 mm', 5, 9500000, 10829000, 'DH02', 'NCC01', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\ORIENT 39.3 mm Automatic kính sapphire Nam.png', SINGLE_BLOB) IMAGE)),
	('DH7', N'Đồng Hồ nam Tissot T/Classic', 5, 5800000, 6100000, 'DH03', 'NCC03', (SELECT * FROM	OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng hồ nam Tissot TClassic.png', SINGLE_BLOB) IMAGE)),
	('DH8', N'Đồng Hồ nam Citizen Eco-Drive', 5, 10000000, 11500500, 'DH03', 'NCC03', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng Hồ Nam Citizen Eco-Drive.png', SINGLE_BLOB) IMAGE)),
	('DH9', N'Đồng Hồ nam TISSOT SPECIAL COLLECTIONS', 5, 6000000, 6332000, 'DH03', 'NCC01', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng hồ nam TISSOT SPECIAL COLLECTIONS.png', SINGLE_BLOB) IMAGE)),
	('DH10', N'Đồng Hồ nam Seiko Prospex', 5, 14000000, 14985000, 'DH04', 'NCC02', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng hồ nam Seiko Prospex.png', SINGLE_BLOB) IMAGE)),
	('DH11', N'Đồng Hồ nam Seiko Solar', 5, 4000000, 4284000, 'DH04', 'NCC02', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng hồ Nam Seiko Solar.png', SINGLE_BLOB) IMAGE)),
	('DH12', N'Đồng Hồ nam Seiko 5 Sports', 5, 7200000, 7857000, 'DH04', 'NCC02', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Đồng hồ nam Seiko 5 Sports.png', SINGLE_BLOB) IMAGE)),
	('DH13', N'Samsung Galaxy Watch 4 Classic', 5, 7500000, 7990000, 'DH05', 'NCC01', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Samsung Galaxy Watch 4 Classic.png', SINGLE_BLOB) IMAGE)),
	('DH14', N'Xiaomi Mi Watch', 5, 2000000, 2390000, 'DH05', 'NCC01', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Xiaomi Mi Watch.png', SINGLE_BLOB) IMAGE)),
	('DH15', N'Apple Watch SE 40mm', 5, 6500000, 6890000, 'DH05', 'NCC03', (SELECT * FROM OPENROWSET(BULK N'D:\DA-PTTKHT\Hình đồng hồ\Apple Watch SE 40mm.png', SINGLE_BLOB) IMAGE))
	

-------HẾT NHẬP
SELECT * FROM dbo.KHACHHANG
SELECT * FROM dbo.NHANVIEN
SELECT * FROM dbo.SANPHAM
SELECT * FROM dbo.LOAISANPHAM
SELECT * FROM dbo.NHACUNGCAP
SELECT * FROM dbo.HOADON
SELECT * FROM dbo.CTHD
SELECT * FROM dbo.[USER]

---- TRIGGER
-- Nhân viên trên 18 tuổi mới được vào làm
CREATE TRIGGER TR_NgayVL ON dbo.NHANVIEN FOR  INSERT, UPDATE 
AS 
BEGIN 
	DECLARE @NgaySinh DATE
	DECLARE @NgayVL DATE
    SELECT @NgaySinh = INSERTED.NGAYSINH, @NgayVL = Inserted.NGAYVAOLAM FROM INSERTED 

	IF(YEAR(@NgayVL) - YEAR(@NgaySinh) <= 18)
		ROLLBACK TRAN
END 
GO 

-- Khách hàng trên 4 tuổi mới được đăng ký thành viên
CREATE TRIGGER TR_NgaySinhKH ON dbo.KHACHHANG FOR  INSERT, UPDATE 
AS 
BEGIN 
	DECLARE @NgaySinhKH DATE
    SELECT @NgaySinhKH = INSERTED.NGSINH FROM INSERTED 

	IF(YEAR(GETDATE()) - YEAR(@NgaySinhKH) <= 3)
		ROLLBACK TRAN
END 
GO 

-- Set lại số hóa đơn khi xóa hóa đơn
CREATE TRIGGER TR_SetIdentitySoHD ON HOADON FOR DELETE
AS
BEGIN
	DECLARE @SOHD INT 
	DECLARE @NewSOHD INT 
	SELECT @SOHD = Deleted.SOHD FROM Deleted
	SET @NewSOHD = @SOHD - 1
	DBCC CHECKIDENT (HOADON, RESEED, @NewSOHD);
END 
GO 

-- Giảm số lượng trong kho khi thêm sản phẩm vào CTHD
CREATE TRIGGER TR_GiamSLKho_UpdateGia_ThanhTiep_SP_Insert ON CTHD FOR INSERT
AS 
BEGIN 
	DECLARE @SoLuongTon INT
	DECLARE @SoLuongBan INT
	DECLARE @MaSP VARCHAR(10)
	
	SELECT @MaSP = Inserted.MASP FROM INSERTED
	SELECT @SoLuongBan = Inserted.SOLUONG FROM Inserted	 		
	SELECT @SoLuongTon = SANPHAM.SOLUONG FROM SANPHAM, Inserted WHERE dbo.SANPHAM.MASP = Inserted.MASP

	IF(@SoLuongTon >= @SoLuongBan)		
	BEGIN
		UPDATE SANPHAM SET SANPHAM.SOLUONG = @SoLuongTon - @SoLuongBan WHERE SANPHAM.MASP = @MaSP		
	END 
	ELSE 
		ROLLBACK TRAN

	DECLARE @SOHD INT
	SELECT @SOHD = Inserted.SOHD FROM Inserted
	-- Update gia san pham
	UPDATE CTHD SET DONGIASP = GIABAN 
				FROM SANPHAM 
				WHERE @MaSP = SANPHAM.MASP AND @SOHD = SOHD AND SANPHAM.MASP = CTHD.MASP
	-- Update thanh tien san pham
	UPDATE CTHD SET THANHTIENSP = @SoLuongBan * DONGIASP 
				WHERE SOHD = @SOHD AND MASP = @MaSP 
END
GO

-- Điều chỉnh số lượng trong kho khi thay đổi số lượng sản phẩm trong CTHD
CREATE TRIGGER TR_GiamSLKho_UpdateGia_ThanhTiep_SP_Update ON CTHD FOR UPDATE
AS 
BEGIN 
	DECLARE @SoLuongTon INT
	DECLARE @SoLuongBanCu INT
	DECLARE @SoLuongBanMoi INT
	DECLARE @MaSP VARCHAR(10)
	       
	SELECT @MaSP = Inserted.MASP FROM INSERTED
	SELECT @SoLuongBanCu = Deleted.SOLUONG FROM Deleted
	SELECT @SoLuongBanMoi = Inserted.SOLUONG FROM Inserted	
	SELECT @SoLuongTon = SANPHAM.SOLUONG FROM SANPHAM, Inserted WHERE SANPHAM.MASP = Inserted.MASP 
		
	BEGIN
		UPDATE SANPHAM SET SANPHAM.SOLUONG = (@SoLuongTon + @SoLuongBanCu - @SoLuongBanMoi) WHERE SANPHAM.MASP = @MaSP		
		IF ((SELECT SANPHAM.SOLUONG FROM sanpham WHERE MASP = @MaSP) < 0)
			ROLLBACK TRAN
	END 

	DECLARE @SOHD INT
	SELECT @SOHD = Inserted.SOHD FROM Inserted
	-- Update gia san pham
	UPDATE CTHD SET DONGIASP = GIABAN 
				FROM SANPHAM 
				WHERE @MaSP = SANPHAM.MASP AND @SOHD = SOHD AND SANPHAM.MASP = CTHD.MASP
	-- Update thanh tien san pham
	UPDATE CTHD SET THANHTIENSP = @SoLuongBanMoi * DONGIASP 
				WHERE SOHD = @SOHD AND MASP = @MaSP 
END
GO

-- Tăng số lượng trong kho khi xóa sản phẩm khỏi CTHD
CREATE TRIGGER TR_GiamSLKho_UpdateGia_ThanhTiep_SP_Delete ON CTHD FOR DELETE
AS 
BEGIN 
	DECLARE @SoLuongTon INT
	DECLARE @SoLuongTraLai INT
	DECLARE @MaSP VARCHAR(10)
	
	SELECT @MaSP = Deleted.MASP FROM Deleted
	SELECT @SoLuongTraLai = Deleted.SOLUONG FROM Deleted	 		
	SELECT @SoLuongTon = SANPHAM.SOLUONG FROM SANPHAM, Deleted WHERE dbo.SANPHAM.MASP = Deleted.MASP

	UPDATE SANPHAM SET SANPHAM.SOLUONG = @SoLuongTon + @SoLuongTraLai  WHERE SANPHAM.MASP = @MaSP		

END
GO

-- Set thành tiền hóa đơn khi thêm chi tiết hóa đơn
CREATE TRIGGER TR_SetThanhTienHD ON dbo.CTHD FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @SoHD INT
    SELECT @SoHD = Inserted.SOHD FROM Inserted
	UPDATE HOADON SET THANHTIENHD = (SELECT SUM(CTHD.THANHTIENSP) FROM dbo.CTHD, Inserted WHERE CTHD.SOHD = @SoHD)
					FROM CTHD 
					WHERE HOADON.SOHD = CTHD.SOHD AND CTHD.SOHD = @SoHD
END
GO 

-- Set lại thành tiền hóa đơn khi xóa chi tiết hóa đơn
CREATE TRIGGER TR_DeleteThanhTienHD ON dbo.CTHD FOR DELETE
AS
BEGIN
	DECLARE @SoHD INT
    SELECT @SoHD = Deleted.SOHD FROM Deleted
	UPDATE HOADON SET THANHTIENHD = (SELECT SUM(CTHD.THANHTIENSP) FROM dbo.CTHD, Deleted WHERE CTHD.SOHD = @SoHD)
					FROM CTHD 
					WHERE HOADON.SOHD = CTHD.SOHD AND CTHD.SOHD = @SoHD
END
GO 

CREATE VIEW View_ShowBill
AS  
	SELECT CTHD.SOHD, TENNV, TENKH, NGAYLAPHOADON, SANPHAM.MASP, TENSP, CTHD.SOLUONG, DONGIASP, THANHTIENSP, THANHTIENHD, TRANGTHAI
	FROM dbo.CTHD, dbo.SANPHAM, dbo.NHANVIEN, dbo.KHACHHANG, dbo.HOADON 
	WHERE CTHD.SOHD = HOADON.SOHD AND HOADON.MANV = NHANVIEN.MANV AND HOADON.MAKH = KHACHHANG.MAKH AND CTHD.MASP = SANPHAM.MASP 
GO 

CREATE PROC SP_ThongKe
AS 
BEGIN 
	SELECT TENSP, SUM(CTHD.SOLUONG) AS 'SL' FROM CTHD, SANPHAM WHERE CTHD.MASP = SANPHAM.MASP
	GROUP BY TENSP
	ORDER BY 'SL' DESC
END
GO 

CREATE PROC SP_ThongKeSP_Theo_NamThang
(
	@Thang INT,
	@Nam int
)
AS
BEGIN
	SELECT TENSP AS N'Tên đồng hồ', SUM(CTHD.SOLUONG) AS SL, MONTH(NGAYLAPHOADON) AS N'Tháng', YEAR(NGAYLAPHOADON) AS N'Năm' 
	FROM CTHD, SANPHAM, HOADON 
	WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD = HOADON.SOHD AND MONTH(NGAYLAPHOADON) = @Thang AND YEAR(NGAYLAPHOADON) = @Nam
	GROUP BY TENSP, NGAYLAPHOADON
	ORDER BY 'SL' DESC
END
GO

/*
EXEC dbo.SP_ThongKeSP_Theo_NamThang @Thang = 12, -- int
                                    @Nam = 2021    -- int
*/

CREATE PROC SP_ThongKeSP_Theo_Nam
(
	@Nam int
)
AS
BEGIN
	SELECT TENSP AS N'Tên đồng hồ', SUM(CTHD.SOLUONG) AS SL, YEAR(NGAYLAPHOADON) AS N'Năm' 
	FROM CTHD, SANPHAM, HOADON 
	WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD = HOADON.SOHD AND YEAR(NGAYLAPHOADON) = @Nam
	GROUP BY TENSP, NGAYLAPHOADON
	ORDER BY 'SL' DESC
END
GO

-- EXEC dbo.SP_ThongKeSP_Theo_Nam @Nam = 0

CREATE PROC SP_DoanhThu_Nam
(
	@Nam INT 
)
AS
BEGIN
	SELECT YEAR(NGAYLAPHOADON) AS N'Năm' , SUM(THANHTIENHD) AS N'Thành tiền' FROM HOADON WHERE YEAR(NGAYLAPHOADON) = @Nam
	GROUP BY YEAR(NGAYLAPHOADON)
END
GO

-- EXEC dbo.SP_DoanhThu_Nam  2021


CREATE PROC SP_DoanhThu_ThangNam
(
	@Thang INT,
	@Nam INT 
)
AS
BEGIN
	SELECT MONTH(NGAYLAPHOADON) AS N'Tháng', YEAR(NGAYLAPHOADON) AS N'Năm', SUM(THANHTIENHD) AS N'Thành tiền' FROM HOADON WHERE YEAR(NGAYLAPHOADON) = @Nam AND MONTH(NGAYLAPHOADON) = @Thang
	GROUP BY YEAR(NGAYLAPHOADON), MONTH(NGAYLAPHOADON)
END
GO

--EXEC dbo.SP_DoanhThu_ThangNam @Thang = 12, @Nam = 2021


CREATE PROC SP_TienLuong
(
	@Nam INT
)
AS
BEGIN	
	SELECT TENNV AS N'Tên nhân viên', SUM(TIENLUONG) AS N'Tiền lương' FROM CHAMCONG, NHANVIEN WHERE YEAR(NGAYLAM) = @Nam AND NHANVIEN.MANV = CHAMCONG.MANV
	GROUP BY TENNV
END
GO

-- EXEC dbo.SP_TienLuong @Nam = 2021 -- int

CREATE PROC SP_TimHDTuNgayDenNgay
(
	@TuNgay NVARCHAR(20),
	@DENNGAY NVARCHAR(20)
)
AS
BEGIN 
	select sohd, tennv, tenkh, ngaylaphoadon, thanhtienhd, trangthai from hoadon, khachhang, nhanvien 
	where format(ngaylaphoadon, 'dd/MM/yyyy') between @TUNGAY and @DENNGAY and hoadon.manv = nhanvien.manv and hoadon.makh = khachhang.makh
END
GO 

--EXEC SP_TimHDTuNgayDenNgay '25/12/2021', '26/12/2021'

CREATE TRIGGER TR_TinhTienNgayLam ON dbo.CHAMCONG FOR INSERT
AS
BEGIN
	DECLARE @MaNV VARCHAR(10)
	DECLARE @NgayLam DATE

	SELECT @MaNV = Inserted.MANV, @NgayLam = Inserted.NGAYLAM FROM Inserted
	UPDATE dbo.CHAMCONG SET TIENLUONG = 300000 WHERE MANV = @MaNV AND NGAYLAM = @NgayLam
END
GO 
delete from cthd delete from hoadon
select * from hoadon
select * from chamcong
insert into chamcong(manv,ngaylam) values('nv1', '2020-5-25')
insert into chamcong(manv,ngaylam) values('nv1', '2020-8-27')
insert into chamcong(manv,ngaylam) values('nv2', '2020-9-2')
insert into chamcong(manv,ngaylam) values('nv2', '2020-9-28')
insert into chamcong(manv,ngaylam) values('nv2', '2020-9-29')
insert into chamcong(manv,ngaylam) values('nv2', '2021-10-29')
insert into chamcong(manv,ngaylam) values('nv2', '2021-10-20')
insert into chamcong(manv,ngaylam) values('nv2', '2021-12-20')
insert into chamcong(manv,ngaylam) values('nv2', '2021-12-22')
select * from khachhang
select * from cthd
select * from sanpham
select * from chamcong
update sanpham set soluong = 5
insert into hoadon(manv, makh, ngaylaphoadon) values ('NV01', 'KH04', '2021-12-22 21:25:17.067')
update nhanvien set manv = 'NV2' where manv = 'NV02'
update nhanvien set makh = 'KH2' where makh = 'kh02'
update nhanvien set makh = 'KH3' where makh = 'kh03'
update nhanvien set makh = 'KH4' where makh = 'kh04'
update nhanvien set makh = 'KH5' where makh = 'kh05'
update khachhang set makh = 'KH6' where makh = 'kh06'
update khachhang set makh = 'KH' where makh = 'kh01'
select * from sanpham
update sanpham set masp = 'DH1' where masp = 'DH01'
update sanpham set masp = 'DH2' where masp = 'DH02'
update sanpham set masp = 'DH3' where masp = 'DH03'
update sanpham set masp = 'DH4' where masp = 'DH04'
update sanpham set masp = 'DH5' where masp = 'DH05'
update sanpham set masp = 'DH6' where masp = 'DH06'
update sanpham set masp = 'DH7' where masp = 'DH07'
update sanpham set masp = 'DH8' where masp = 'DH08'
update sanpham set masp = 'DH9' where masp = 'DH09'
update sanpham set masp = 'DH1' where masp = 'DH01'
update sanpham set masp = 'DH1' where masp = 'DH01'
update hoadon set trangthai = N'Đã thanh toán'
update hoadon set trangthai = N'Chưa thanh toán' where sohd = 9 and sohd = 4
insert into cthd(sohd, masp, soluong)
Values(1, 'DH7', 1)
insert into cthd(sohd, masp, soluong)
Values(2, 'DH3', 1)
insert into cthd(sohd, masp, soluong)
Values(3, 'DH2', 2)
insert into cthd(sohd, masp, soluong)
Values(3, 'DH4', 1)
insert into cthd(sohd, masp, soluong)
Values(4, 'DH7', 4)
insert into cthd(sohd, masp, soluong)
Values(5, 'DH1', 2)
insert into cthd(sohd, masp, soluong)
Values(6, 'DH3', 2)
insert into cthd(sohd, masp, soluong)
Values(7, 'DH3', 2)
insert into cthd(sohd, masp, soluong)
Values(7, 'DH11', 2)
insert into cthd(sohd, masp, soluong)
Values(8, 'DH12',1)
insert into cthd(sohd, masp, soluong)
Values(8, 'DH01', 1)
insert into cthd(sohd, masp, soluong)
Values(8, 'DH2', 1)
insert into cthd(sohd, masp, soluong)
Values(9, 'DH6', 1)
insert into cthd(sohd, masp, soluong)
Values(9, 'DH5', 1)
insert into cthd(sohd, masp, soluong)
Values(9, 'DH4', 1)
insert into cthd(sohd, masp, soluong)
Values(9, 'DH01', 1)
DBCC CHECKIDENT (HOADON, RESEED, 0);

insert into hoadon(manv, makh, ngaylaphoadon) 
values ('NV1', 'KH2','2020-05-25 15:36:41.067'),
(	'NV1',	'KH2',	'2020-08-27 11:39:41.067'),
('NV2',	'KH4',	'2020-09-27 11:39:41.067'),
('NV2',	'KH1',	'2020-09-28 09:30:41.067'),
(	'NV2',	'KH1',	'2020-09-29 21:57:11.067'),
(	'NV2',	'KH1',	'2021-10-29 21:57:11.067'),
(	'NV2',	'KH1',	'2021-10-20 01:15:18.067'),
(	'NV2',	'KH3',	'2021-12-20 16:25:17.067'),
(	'NV1',	'KH4',	'2021-12-22 21:25:17.067')