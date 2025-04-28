Create Database NguyenHoangNguyen_2025

use NguyenHoangNguyen_2025

CREATE TABLE LOAITK (
    MALOAI VARCHAR(10) PRIMARY KEY,
    TENLOAI NVARCHAR(100) NOT NULL,
    KYHAN INT NOT NULL, 
    LOAITIEN VARCHAR(10) NOT NULL,
    LAISUAT INT NOT NULL)

CREATE TABLE PHONGGD (
    MAPHONG VARCHAR(10) PRIMARY KEY,
    TENPHONG NVARCHAR(100) NOT NULL,
    DIADIEM NVARCHAR(100),
    DIENTHOAI VARCHAR(12))

CREATE TABLE NHANVIEN ( 
    MANV VARCHAR(10) PRIMARY KEY,
    HOTEN NVARCHAR(50) NOT NULL, 	
    NGAYSINH DATETIME,
    DIACHI NVARCHAR(100),
    DIENTHOAI VARCHAR(12),
    MAPHONG VARCHAR(10) NOT NULL,
    FOREIGN KEY (MAPHONG) REFERENCES PHONGGD(MAPHONG))

CREATE TABLE LOGIN (
    MATK VARCHAR(50) PRIMARY KEY,
    MATKHAU NVARCHAR(100) NULL)

-- Insert data into LOAITK table
INSERT INTO LOAITK (MALOAI, TENLOAI, KYHAN, LOAITIEN, LAISUAT) VALUES
('TK1', N'Tai khoan khong ki han', 0, 'VND', 2),
('TK2', N'Tai khoan tiet kiem 3 thang', 3, 'VND', 3),
('TK3', N'Tai khoan tiet kiem 6 thang', 6, 'VND', 7),
('TK4', N'Tai khoan tiet kiem 12 tháng', 12, 'VND', 10),
('TK5', N'Tai khoan ngoai te USD', 0, 'USD', 1);

-- Insert data into PHONGGD table (need to insert this first since NHANVIEN references it)
INSERT INTO PHONGGD (MAPHONG, TENPHONG, DIADIEM, DIENTHOAI) VALUES
('P1', N'Phong giao dich Quan 1', N'100 Nguyen Huy, Quan 1, TP.HCM', '0982148689'),
('P2', N'Phong giao dich Quan 3', N'211 Vo Van Ton, Quan 3, TP.HCM', '0982561486'),
('P3', N'Phong giao dich Ha Noi', N'121 Nguyen Trai, Thanh Xuan, Ha Noi', '0356814775'),
('P4', N'Phong giao dich Ha Noi', N'50 Lý Thuong Kiet, Hoan Kiem, Hà Noi', '0336894715'),
('P5', N'Phong giao dich Da Nang', N'150 Bich Dong, Hai Chau, Da Nang', '0968424555');

-- Insert data into NHANVIEN table
INSERT INTO NHANVIEN (MANV, HOTEN, NGAYSINH, DIACHI, DIENTHOAI, MAPHONG) VALUES
('NV001', N'Nguyen Van An', '2001-08-15', N'45 Tran Hung Dao, Quan 1, TP.HCM', '0986556721', 'P1'),
('NV002', N'Tran Thi Banh', '2002-08-27', N'78 Le Lai, Quan 3, TP.HCM', '0912558221', 'P2'),
('NV003', N'Le Van Cuong', '1999-02-10', N'135 Pham Ngu Lao, Quan 1, TP.HCM', '0925563589', 'P3'),
('NV004', N'Pham Thi Dung', '1995-08-15', N'246 Nguyen Cu Trinh, Quan 1, TP.HCM', '0938854620', 'P4'),
('NV005', N'Hoang Van Em', '2004-11-05', N'357 Dien Bien Phu, Quan 3, TP.HCM', '0945645555', 'P5');

-- Insert data into LOGIN table
INSERT INTO LOGIN (MATK, MATKHAU) VALUES
('admin', 'passwordadmin'),
('nguyen', 'passwordnguyen'),
('hoang', 'passwordhoang'),
('huy', 'passwordhuy'),
('quynh', 'passwordquynh');

select * from LOAITK
select * from PHONGGD
select * from NHANVIEN
select * from LOGIN