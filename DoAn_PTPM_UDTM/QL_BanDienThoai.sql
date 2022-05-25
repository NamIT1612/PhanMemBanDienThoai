Create database QL_BanDienThoai
use QL_BanDienThoai
go
create table TAIKHOAN
(
tk nvarchar(50) not null,
mk nvarchar(100),
SDT varchar(10),
DiaChi nvarchar(100),
GioiTinh nvarchar(100),
quyen int,
Constraint pk_tk primary key(tk)
)
Insert into TaiKhoan values
(N'admin',N'admin','0339906489',N'Kinh Xuôi - Thanh Mỹ - Châu Thành - Trà Vinh',N'Nam',1)
Insert into TaiKhoan values
(N'user',N'user','0338906489',N'Kinh Xuôi - Thanh Mỹ - Châu Thành - Quãng Ngãi',N'Nam',0)
Insert into TaiKhoan values
(N'Nam',N'Nam','0339906589',N'Kinh Xuôi - Thanh Mỹ - Châu Thành - Trà Vinh',N'Nam',0)
Insert into TaiKhoan values
(N'Thai',N'Thai','0338806489',N'Kinh Xuôi - Thanh Mỹ - Châu Thành - Trà Vinh',N'Nam',0)
CREATE TABLE LOAISANPHAM
(
	MaLoai varchar(20) NOT NULL,
	TenLoaiSP nvarchar(50) NULL
	Constraint pk_lsp primary key(MaLoai)
)
Insert into LOAISANPHAM values
('L001',N'Android')
Insert into LOAISANPHAM values
('L002',N'Iphone')
Insert into LOAISANPHAM values
('L003',N'Oppo')
Insert into LOAISANPHAM values
('L004',N'SamSung')
CREATE TABLE SANPHAM
(
	MaSP varchar(50) NOT NULL,
	TenSP nvarchar(100) NULL,
	GiaBan int NULL,
	GiaCu int NULL,
	MoTa nvarchar(max) NULL,
	HinhAnh varchar(100) NULL,
	MaLoai varchar(20) NULL,
	constraint pk_sp primary key(MaSP),
	constraint fk_sp foreign key(MaLoai) references LOAISANPHAM(MaLoai)
)
insert into SANPHAM values
('SP001',N'Samsung Galaxy A73 5G',10990000,10190000,
N'Bộ nhớ trong: 128 GB.
Camera sau: Chính 108 MP & Phụ 12 MP, 5 MP, 5 MP.
Camera trước: 32 MP.
CPU: Snapdragon 778G 5G 8 nhân.
Dung lượng pin: 5000 mAh 25 W.
Hệ điều hành: Android 12.
Màn hình: Super AMOLED Plus6.7 Full HD+.
RAM: 8 GB.
Thẻ SIM: 2 Nano SIM (SIM 2 chung khe thẻ nhớ) Hỗ trợ 5G.
Thương hiệu: Samsung.'
,'Samsung01.jpg','L004');
insert into SANPHAM values
('SP002',N'OPPO Reno7 Z 5G',10940000,9990000,N'Bộ nhớ trong: 128 GB.
Camera sau: Chính 64 MP & Phụ 2 MP, 2 MP.
Camera trước: 16 MP.
CPU: Snapdragon 695 5G 8 nhân.
Dung lượng pin: 4500 mAh - Hỗ trợ sạc 33w.
Màn hình: 6.43" AMOLED - Tần số quét 60 Hz Full HD+ (1080 x 2400 Pixels).
RAM: 8 GB.
Thẻ SIM: 2 Nano SIM (SIM 2 chung khe thẻ nhớ) Hỗ trợ 5G.
Trọng lượng: Dài 159.85 mm - Ngang 73.17 mm - Dày 7.49 mm - Nặng 173 g.
Thương hiệu: Oppo.
Thiết kế: Nguyên khối.
Chất liệu mặt: Khung nhựa & Mặt lưng thuỷ tinh hữu cơ.
Cổng kết nối: Type-C.'
,'Oppo01.jpg','L003');
insert into SANPHAM values
('SP003',N'iPhone 11 64GB',9140000,13490000,N'Bộ nhớ trong: 64 GB.
Camera sau: Chính 12 MP & Phụ 12 MP.
Camera trước: 12 MP.
CPU: Apple A13 Bionic 6 nhân.
Dung lượng pin: 3110 mAh, có sạc nhanh.
Hệ điều hành: iOS 13.
Màn hình: IPS LCD, 6.1", Liquid Retina.
RAM: 4 GB.
Thẻ SIM: 1 eSIM & 1 Nano SIM, Hỗ trợ 4G.
Thương hiệu: Apple.'
,'Iphone01.jpg','L002');
insert into SANPHAM values
('SP004',N'iPhone Xs Max 64GB',8940000,13990000,N'Bộ nhớ trong: 64 GB.
Camera sau: Chính 12 MP & Phụ 12 MP.
Camera trước: 7 MP.
CPU: Apple A12 Bionic 6 nhân.
Dung lượng pin: 3174 mAh, có sạc nhanh.
Hệ điều hành: iOS 13.
Màn hình: OLED, 6.5, Super Retina.
RAM: 3 GB.
Thẻ SIM: 1 eSIM & 1 Nano SIM, Hỗ trợ 4G.
Trọng lượng: 208 g.
Thương hiệu: Apple.'
,'Iphone02.png','L002');
insert into SANPHAM values
('SP005',N'Samsung Galaxy A52s 5G',8840000,10190000,N'Bộ nhớ trong: 128 GB.
Camera sau: 64.0 MP + 12.0 MP + 5.0 MP + 5.0 MP.
Camera trước: 32.0 MP.
CPU: Snapdragon 778G.
Dung lượng pin: 4500 mAh.
Màn hình: 6.5", FHD+, Super AMOLED, 1080 x 2400 Pixel.
RAM: 8 GB.
Thẻ SIM: 2 SIM, Nano SIM.
Thương hiệu: Samsung.'
,'Samsung02.png','L004');
CREATE TABLE KHO
(
	MaSP varchar(50) NOT NULL,
	SoLuongTonKho int NULL,
	constraint pk_K primary key(MaSP),
	constraint fk_k foreign key(MaSP) references SANPHAM(MaSP)
)
insert into KHO values
('SP001',100)
insert into KHO values
('SP002',100)
insert into KHO values
('SP003',100)
insert into KHO values
('SP004',100)
insert into KHO values
('SP005',100)

create table KHACHHANG
(
MaKhachHang varchar(50) not null,
TenKhachHang nvarChar(50),
SDT varchar(10) unique,
DiaChi nvarchar(100),
TrangThai int,
constraint pk_kh primary key(MakhachHang)
)
insert into KHACHHANG values
('KH01',N'Nguyễn Nhựt Nam','0339906489','Trà Vinh',0)

set dateformat dmy
create table HOADON
(
MaKhachHang varchar(50) not null,
MaSP varchar(50) not null,
tk nvarchar(50) not null,
SoLuongBan int ,
GiaBan int,
NgayBan Datetime,
TrangThai int,
constraint pk_HD primary key(MaKhachHang,NgayBan),
constraint fk_HD1 foreign key(MaSP) references SANPHAM(MaSP),
constraint fk_HD2 foreign key(tk) references TAIKHOAN(tk),
constraint fk_HD3 foreign key(MaKhachHang) references KHACHHANG(MaKhachHang)
)
select*from HOADON 