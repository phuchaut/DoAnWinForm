USE [master]
GO
/****** Object:  Database [QuanLyNhaHang]    Script Date: 16-May-24 4:17:29 PM ******/
CREATE DATABASE [QuanLyNhaHang] ON  PRIMARY 
( NAME = N'QuanLyNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QuanLyNhaHang.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QuanLyNhaHang_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhaHang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaHang] SET DB_CHAINING OFF 
GO
USE [QuanLyNhaHang]
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[MaBanAn] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[SoChoNgoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBanAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [nvarchar](255) NOT NULL,
	[MaMonAn] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[MaBanAn] [int] NULL,
	[TenKH] [nvarchar](255) NULL,
	[SDT] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Ngay] [datetime] NOT NULL,
	[TongDoanhThu] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](255) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
	[MaNV] [varchar](50) NOT NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[SDT] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichLamViecNV]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichLamViecNV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [varchar](50) NOT NULL,
	[Thu] [int] NOT NULL,
	[Ca] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[MaLoaiMA] [int] NOT NULL,
	[TenLoaiMA] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [int] NOT NULL,
	[TenMonAn] [nvarchar](255) NOT NULL,
	[MaLoaiMonAn] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[TrangThai] [int] NULL,
	[TenNguyenLieu] [nvarchar](255) NULL,
	[SoLuongNguyenLieu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [int] NOT NULL,
	[TenNguyenLieu] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaNguyenLieu] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu_MonAn]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu_MonAn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaMonAn] [int] NOT NULL,
	[MaNguyenLieu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 16-May-24 4:17:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[CCCD] [varchar](255) NOT NULL,
	[Phai] [nvarchar](3) NULL,
	[Luong] [float] NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[LoaiNhanVien] [varchar](50) NOT NULL,
	[MatKhauMH] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (1, 0, 0)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (2, 1, 6)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (3, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (4, 1, 2)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (5, 1, 8)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (6, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (7, 1, 6)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (8, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (9, 1, 2)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (10, 1, 6)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (11, 1, 2)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (12, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (13, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (14, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (15, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (16, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (17, 1, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (18, 0, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (19, 0, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (20, 0, 4)
INSERT [dbo].[BanAn] ([MaBanAn], [TrangThai], [SoChoNgoi]) VALUES (21, 0, 6)
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (432, N'1505123945432', 27, 1, 5000, 1, N'Hậu', N'0392644989')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (433, N'1505123945432', 3, 1, 150000, 1, N'Hậu', N'0392644989')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (434, N'1505123945432', 7, 1, 35000, 1, N'Hậu', N'0392644989')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (435, N'1505124132016', 5, 1, 90000, 2, N'Hoàng', N'0319494994')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (436, N'1505124132016', 10, 1, 150000, 2, N'Hoàng', N'0319494994')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (437, N'1505124132016', 20, 1, 90000, 2, N'Hoàng', N'0319494994')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (438, N'1505124149520', 4, 1, 80000, 3, N'Tâm', N'03949849844')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (439, N'1505124149520', 24, 1, 25000, 3, N'Tâm', N'03949849844')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (440, N'1505124149520', 28, 1, 80000, 3, N'Tâm', N'03949849844')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (441, N'1505124206046', 3, 3, 150000, 4, N'Ngọc', N'0619499447')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (442, N'1505124206046', 25, 1, 30000, 4, N'Ngọc', N'0619499447')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (443, N'1505124206046', 9, 1, 180000, 4, N'Ngọc', N'0619499447')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (444, N'1505124300560', 2, 1, 120000, 5, N'Thà', N'03294949595')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (445, N'1505124300560', 5, 1, 90000, 5, N'Thà', N'03294949595')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (446, N'1505124300560', 30, 1, 35000, 5, N'Thà', N'03294949595')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (447, N'1505124300560', 19, 1, 180000, 5, N'Thà', N'03294949595')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (448, N'1505124322107', 4, 1, 80000, 6, N'Hà', N'032949479794')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (449, N'1505124322107', 5, 1, 90000, 6, N'Hà', N'032949479794')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (450, N'1505124322107', 2, 1, 120000, 6, N'Hà', N'032949479794')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (451, N'1505124339543', 7, 1, 35000, 7, N'Nhanh', N'06949265949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (452, N'1505124339543', 26, 1, 25000, 7, N'Nhanh', N'06949265949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (453, N'1505124339543', 31, 1, 40000, 7, N'Nhanh', N'06949265949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (454, N'1505124356934', 4, 1, 80000, 8, N'Trâm', N'03161949629')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (455, N'1505124356934', 7, 1, 35000, 8, N'Trâm', N'03161949629')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (456, N'1505124356934', 24, 1, 25000, 8, N'Trâm', N'03161949629')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (457, N'1505124419119', 7, 1, 35000, 9, N'Huỳnh', N'01326494962')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (458, N'1505124419119', 2, 1, 120000, 9, N'Huỳnh', N'01326494962')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (459, N'1505124419119', 22, 1, 120000, 9, N'Huỳnh', N'01326494962')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (460, N'1505124437382', 24, 1, 25000, 10, N'Như', N'03164949459')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (461, N'1505124437382', 11, 1, 220000, 10, N'Như', N'03164949459')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (462, N'1505124437382', 14, 1, 90000, 10, N'Như', N'03164949459')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (463, N'1505124454376', 15, 1, 120000, 11, N'An', N'03294949797')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (464, N'1505124454376', 20, 1, 90000, 11, N'An', N'03294949797')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (465, N'1505124454376', 16, 1, 150000, 11, N'An', N'03294949797')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (466, N'1505124521646', 5, 1, 90000, 12, N'Phúc', N'01694594949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (467, N'1505124521646', 20, 1, 90000, 12, N'Phúc', N'01694594949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (468, N'1505124521646', 17, 1, 180000, 12, N'Phúc', N'01694594949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (469, N'1505131413433', 4, 1, 80000, 13, N'Lâm', N'03956446189')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (470, N'1505131413433', 7, 1, 35000, 13, N'Lâm', N'03956446189')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (471, N'1505131413433', 24, 1, 25000, 13, N'Lâm', N'03956446189')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (472, N'1505131436278', 14, 1, 90000, 14, N'Đại', N'06494962949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (473, N'1505131436278', 18, 1, 100000, 14, N'Đại', N'06494962949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (474, N'1505131436278', 10, 1, 150000, 14, N'Đại', N'06494962949')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (475, N'1505131451549', 1, 1, 100000, 15, N'Hậu', N'069494649849')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (476, N'1505131451549', 5, 1, 90000, 15, N'Hậu', N'069494649849')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (477, N'1505131451549', 20, 1, 90000, 15, N'Hậu', N'069494649849')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (478, N'1505131451549', 15, 1, 120000, 15, N'Hậu', N'069494649849')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (479, N'1505131851845', 7, 1, 35000, 16, N'Hiếu', N'03949495494')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (480, N'1505131851845', 20, 1, 90000, 16, N'Hiếu', N'03949495494')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (481, N'1505131851845', 11, 1, 220000, 16, N'Hiếu', N'03949495494')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (482, N'1505131909101', 7, 1, 35000, 17, N'Huy', N'0616496126494')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (483, N'1505131909101', 16, 1, 150000, 17, N'Huy', N'0616496126494')
INSERT [dbo].[ChiTietHoaDon] ([ID], [MaHoaDon], [MaMonAn], [SoLuong], [DonGia], [MaBanAn], [TenKH], [SDT]) VALUES (484, N'1505131909101', 14, 1, 90000, 17, N'Huy', N'0616496126494')
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505123945432', CAST(N'2024-05-14T00:00:00.000' AS DateTime), CAST(N'2024-05-15T00:00:00.000' AS DateTime), N'nv01', N'Đã phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124132016', CAST(N'2024-05-15T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124149520', CAST(N'2024-05-13T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124206046', CAST(N'2024-05-12T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124300560', CAST(N'2024-05-11T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124322107', CAST(N'2024-05-10T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124339543', CAST(N'2024-05-09T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124356934', CAST(N'2024-05-08T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124419119', CAST(N'2024-05-07T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124437382', CAST(N'2024-05-06T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124454376', CAST(N'2024-05-05T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505124521646', CAST(N'2024-05-10T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505131413433', CAST(N'2024-05-15T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505131436278', CAST(N'2024-05-15T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505131451549', CAST(N'2024-05-09T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505131851845', CAST(N'2024-05-15T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [NgayThanhToan], [MaNV], [TrangThai]) VALUES (N'1505131909101', CAST(N'2024-05-15T00:00:00.000' AS DateTime), NULL, N'nv01', N'Chưa phục vụ')
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (18, N'Hậu', N'0392644989')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (19, N'Hoàng', N'0319494994')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (20, N'Tâm', N'03949849844')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (21, N'Ngọc', N'0619499447')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (22, N'Thà', N'03294949595')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (23, N'Hà', N'032949479794')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (24, N'Nhanh', N'06949265949')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (25, N'Trâm', N'03161949629')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (26, N'Huỳnh', N'01326494962')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (27, N'Như', N'03164949459')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (28, N'An', N'03294949797')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (29, N'Phúc', N'01694594949')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (30, N'Lâm', N'03956446189')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (31, N'Đại', N'06494962949')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (32, N'Hậu', N'069494649849')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (33, N'Hiếu', N'03949495494')
INSERT [dbo].[KhachHang] ([ID], [HoTen], [SDT]) VALUES (34, N'Huy', N'0616496126494')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LichLamViecNV] ON 

INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (1, N'nv02', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (2, N'nv03', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (3, N'nv08', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (4, N'nv011', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (5, N'nv012', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (6, N'nv017', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (7, N'nv018', 2, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (8, N'nv04', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (9, N'nv05', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (10, N'nv09', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (11, N'nv013', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (12, N'nv014', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (13, N'nv019', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (14, N'nv020', 2, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (15, N'nv06', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (16, N'nv07', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (17, N'nv010', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (18, N'nv015', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (19, N'nv016', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (20, N'nv021', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (21, N'nv022', 2, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (22, N'nv02', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (23, N'nv03', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (24, N'nv08', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (25, N'nv011', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (26, N'nv012', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (27, N'nv017', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (28, N'nv018', 3, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (29, N'nv04', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (30, N'nv05', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (31, N'nv09', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (32, N'nv013', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (33, N'nv014', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (34, N'nv019', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (35, N'nv020', 3, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (36, N'nv06', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (37, N'nv07', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (38, N'nv010', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (39, N'nv015', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (40, N'nv016', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (41, N'nv021', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (42, N'nv022', 3, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (43, N'nv02', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (44, N'nv03', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (45, N'nv08', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (46, N'nv011', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (47, N'nv012', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (48, N'nv017', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (49, N'nv018', 4, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (50, N'nv04', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (51, N'nv05', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (52, N'nv09', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (53, N'nv013', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (54, N'nv014', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (55, N'nv019', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (56, N'nv020', 4, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (57, N'nv06', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (58, N'nv07', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (59, N'nv010', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (60, N'nv015', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (61, N'nv016', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (62, N'nv021', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (63, N'nv022', 4, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (64, N'nv02', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (65, N'nv03', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (66, N'nv08', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (67, N'nv011', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (68, N'nv012', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (69, N'nv017', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (70, N'nv018', 5, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (71, N'nv04', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (72, N'nv05', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (73, N'nv09', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (74, N'nv013', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (75, N'nv014', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (76, N'nv019', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (77, N'nv020', 5, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (78, N'nv06', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (79, N'nv07', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (80, N'nv010', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (81, N'nv015', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (82, N'nv016', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (83, N'nv021', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (84, N'nv022', 5, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (85, N'nv02', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (86, N'nv03', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (87, N'nv08', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (88, N'nv011', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (89, N'nv012', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (90, N'nv017', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (91, N'nv018', 6, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (92, N'nv04', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (93, N'nv05', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (94, N'nv09', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (95, N'nv013', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (96, N'nv014', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (97, N'nv019', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (98, N'nv020', 6, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (99, N'nv06', 6, 3)
GO
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (100, N'nv07', 6, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (101, N'nv010', 6, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (102, N'nv015', 6, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (103, N'nv016', 6, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (104, N'nv021', 6, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (105, N'nv022', 6, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (106, N'nv02', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (107, N'nv03', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (108, N'nv08', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (109, N'nv011', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (110, N'nv012', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (111, N'nv017', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (112, N'nv018', 7, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (113, N'nv04', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (114, N'nv05', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (115, N'nv09', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (116, N'nv013', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (117, N'nv014', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (118, N'nv019', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (119, N'nv020', 7, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (120, N'nv06', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (121, N'nv07', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (122, N'nv010', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (123, N'nv015', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (124, N'nv016', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (125, N'nv021', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (126, N'nv022', 7, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (127, N'nv02', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (128, N'nv03', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (129, N'nv08', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (130, N'nv011', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (131, N'nv012', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (132, N'nv017', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (133, N'nv018', 8, 1)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (134, N'nv04', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (135, N'nv05', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (136, N'nv09', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (137, N'nv013', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (138, N'nv014', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (139, N'nv019', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (140, N'nv020', 8, 2)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (141, N'nv07', 8, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (142, N'nv07', 8, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (143, N'nv07', 8, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (144, N'nv07', 8, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (145, N'nv07', 8, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (146, N'nv07', 8, 3)
INSERT [dbo].[LichLamViecNV] ([ID], [MaNhanVien], [Thu], [Ca]) VALUES (147, N'nv022', 3, 3)
SET IDENTITY_INSERT [dbo].[LichLamViecNV] OFF
GO
INSERT [dbo].[LoaiMonAn] ([MaLoaiMA], [TenLoaiMA]) VALUES (1, N'Món hấp xào')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMA], [TenLoaiMA]) VALUES (2, N'Món nóng')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMA], [TenLoaiMA]) VALUES (3, N'Món nướng')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMA], [TenLoaiMA]) VALUES (4, N'Món chiên')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMA], [TenLoaiMA]) VALUES (5, N'Món tráng miệng')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMA], [TenLoaiMA]) VALUES (6, N'Món uống')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (1, N'Nghêu hấp thái', 1, 100000, 1, N'Nghêu', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (2, N'Sò huyết xào me', 1, 120000, 1, N'Sò huyết', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (3, N'Chem chép hấp rau răm', 1, 150000, 1, N'Chem chép', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (4, N'Ốc dừa xào bơ', 1, 80000, 1, N'Ốc dừa', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (5, N'Ốc cà na rang muối', 1, 90000, 1, N'Ốc cà na', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (6, N'Hột vịt lộn', 1, 25000, 1, N'Hột vịt lộn', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (7, N'Há cảo, xíu mại', 1, 35000, 1, N'Há cảo, xíu mại', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (8, N'Gà ác tiềm thuốc bắc', 2, 200000, 1, N'Thịt gà ác', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (9, N'Cà ri dê lẩu', 2, 180000, 1, N'Thịt dê', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (10, N'Mì Ý sốt bò', 2, 150000, 1, N'Thịt bò', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (11, N'Lưỡi heo hầm rượu và đậu kiểu Pháp', 2, 220000, 1, N'Lưỡi heo', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (12, N'Cơm chiên lá sen', 2, 60000, 1, N'Gạo', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (13, N'Tôm nướng', 3, 80000, 1, N'Tôm', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (14, N'Hào nướng phô mai', 3, 90000, 1, N'Hào', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (15, N'Sườn nướng BBQ', 3, 120000, 1, N'Sườn', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (16, N'Gà nướng mật ong', 3, 150000, 1, N'Gà', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (17, N'Vịt nướng chao', 3, 180000, 1, N'Vịt', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (18, N'Sò điệp nướng', 3, 100000, 1, N'Sò điệp', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (19, N'Bò nướng sốt rượu', 3, 180000, 1, N'Thịt bò', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (20, N'Cá chiên cốm', 4, 90000, 1, N'Cá', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (21, N'Cánh gà chiên hạnh nhân', 4, 80000, 1, N'Cánh gà', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (22, N'Mực chiên giòn', 4, 120000, 1, N'Mực', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (23, N'Bánh đậu xanh', 5, 20000, 1, N'Đậu xanh', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (24, N'Bánh chanh dây', 5, 25000, 1, N'Chanh dây', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (25, N'Chè đậu đỏ', 5, 30000, 1, N'Đậu đỏ', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (26, N'Nước cam', 6, 25000, 1, N'Cam', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (27, N'Nước suối', 6, 5000, 1, N'Nước suối', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (28, N'Coctail', 6, 80000, 1, N'Rượu vodka', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (29, N'Cơm Sường', 3, 30000, 1, N'Sườn', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (30, N'Cơm gà', 3, 35000, 1, N'Gà', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (31, N'Bún bò', 2, 40000, 1, N'Thịt bò', 1)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn], [DonGia], [TrangThai], [TenNguyenLieu], [SoLuongNguyenLieu]) VALUES (32, N'Mì Quảng', 2, 30000, 1, N'Gà', 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (1, N'Nghêu', 79, 15000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (2, N'Sò huyết', 90, 130000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (3, N'Chem chép', 85, 20000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (4, N'Ốc dừa', 93, 145000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (5, N'Ốc cà na', 72, 135000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (6, N'Hột vịt lộn', 0, 7000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (7, N'Há cảo, xíu mại', 76, 52000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (9, N'Lưỡi heo', 94, 150000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (10, N'Thịt gà ác', 0, 200000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (11, N'Thịt dê', 92, 300000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (12, N'Thịt bò', 100, 450000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (13, N'Rượu vang Pháp', 100, 2000000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (14, N'Tôm', 100, 200000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (15, N'Hào', 97, 45000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (16, N'Sườn', 95, 200000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (17, N'Sò điệp', 98, 300000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (18, N'Rượu vodka', 98, 200000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (19, N'Rượu rum', 100, 380000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (21, N'Dứa', 100, 20000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (22, N'Xoài', 100, 60000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (23, N'Dừa', 100, 15000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (24, N'Nước ngọt', 100, 50000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (25, N'Cam', 98, 25000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (26, N'Nước suối', 99, 5000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (27, N'Gà', 95, 200000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (28, N'Vịt', 99, 50000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (30, N'Cá', 95, 90000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (31, N'Cánh gà', 100, 60000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (32, N'Mực', 99, 280000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (33, N'Gạo', 97, 5000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (34, N'Đậu xanh', 100, 0)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (35, N'Chanh dây', 45, 0)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (36, N'Đậu đỏ', 48, 0)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong], [DonGiaNguyenLieu]) VALUES (37, N'Thịt heo', 50, 100000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv01', N'Phạm Vĩ Đại', CAST(N'2000-09-27' AS Date), N'Bến Tre', N'23423421', N'Nam', 15000000, N'123', N'QL', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv010', N'Nguyễn Hữu Đăng', CAST(N'2003-08-28' AS Date), N'Ba Tri', N'4879564978', N'Nam', 1800000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv011', N'Hạ Thị Kim Thà', CAST(N'2002-05-27' AS Date), N'Đồng Tháp', N'12856134', N'Nữ', 5000000, N'123456', N'NVB', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv012', N'Trương Trần Trọng Phúc', CAST(N'2000-02-18' AS Date), N'TP HCM', N'987662134', N'Nam', 200000, N'123456', N'NVB', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv013', N'Phạm Minh Phúc', CAST(N'2002-05-27' AS Date), N'Thủ Đức', N'12856134', N'Nam', 5000000, N'123456', N'NVB', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv014', N'Võ Thị Diễm Trinh', CAST(N'2000-02-18' AS Date), N'Quận 2', N'987662134', N'Nữ', 200000, N'123456', N'NVB', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv015', N'Đỗ Huỳnh Ngọc Trâm', CAST(N'2002-05-27' AS Date), N'Tân Xuân', N'12856134', N'Nữ', 5000000, N'123456', N'NVB', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv016', N'Phạm Thị Tú Nguyên', CAST(N'2000-02-18' AS Date), N'Phước Ngãi', N'987662134', N'Nữ', 200000, N'123456', N'NVB', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv017', N'Nguyễn Văn Hậu', CAST(N'2004-11-29' AS Date), N'Bến Tre', N'17982998', N'Nam', 1000000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv018', N'Võ Quốc Toàn', CAST(N'2001-04-27' AS Date), N'Tiền Giang', N'890789564', N'Nam', 800000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv019', N'Nguyễn Thị Tuyết Nhi', CAST(N'2004-12-26' AS Date), N'Bình Tân', N'634232423', N'Nữ', 2500000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv02', N'Nguyễn Thị Nhung', CAST(N'2004-04-12' AS Date), N'Đắk Lắk', N'97973482', N'Nữ', 450000, N'123', N'TN', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv020', N'Trần Thị Tuyết Như', CAST(N'2002-07-01' AS Date), N'Vũng Tàu', N'234525134', N'Nữ', 1500000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv021', N'Dương Ngọc Trâm', CAST(N'2002-09-27' AS Date), N'Gia Lai', N'2346343234', N'Nữ', 900000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv022', N'Phan Thu An', CAST(N'2002-09-27' AS Date), N'Cần Thơ', N'2346343234', N'Nữ', 900000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv023', N'Trịnh Phúc Hậu', CAST(N'2004-04-30' AS Date), N'Bến Tre', N'213124123', N'Nam', 50000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv024', N'Huỳnh Hữu Phúc', CAST(N'2004-04-30' AS Date), N'Phước Ngãi', N'213124123', N'Nam', 550000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv03', N'Trần Thị Hoa', CAST(N'2004-04-12' AS Date), N'Bình Phước', N'27857857', N'Nữ', 450000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv032', N'Lê Thanh Lâm', CAST(N'2004-05-15' AS Date), N'Sa séc', N'948465465484', N'Nam', 500000000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv04', N'Nguyễn Văn Chiến', CAST(N'2004-04-12' AS Date), N'Bình Dương', N'875545877', N'Nam', 450000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv05', N'Trương Thị Cẩm Tú', CAST(N'2004-04-12' AS Date), N'Hải Phòng', N'676481157', N'Nữ', 450000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv06', N'Nguyễn Thị Tâm', CAST(N'2004-04-12' AS Date), N'Thái Bình', N'543482428', N'Nữ', 450000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv07', N'Võ Thị Huỳnh Nga', CAST(N'2004-04-12' AS Date), N'Quảng Nam', N'6434182404', N'Nữ', 450000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv08', N'Phạm Lê Nhanh', CAST(N'2003-08-28' AS Date), N'Thủ Đức', N'959634789', N'Nam', 1800000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv09', N'Võ Công Sơn', CAST(N'2003-08-28' AS Date), N'Bãi Ngao', N'156498636', N'Nam', 1800000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv25', N'Võ Thị Anh Thư', CAST(N'2004-05-06' AS Date), N'Bão Thuận', N'1231312', N'Nữ', 1800000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv26', N'Nguyễn Trung Huỳnh', CAST(N'2000-05-06' AS Date), N'Phước Ngãi', N'565463453', N'Nam', 1800000, N'123456', N'TT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv27', N'Trương Khánh Võ', CAST(N'2000-05-06' AS Date), N'Phước Ngãi', N'565463453', N'Nam', 1800000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv28', N'Hồ Tuấn Kiệt', CAST(N'2004-05-06' AS Date), N'Phước Ngãi', N'1231231241', N'Nam', 1800000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv30', N'Huỳnh Giao', CAST(N'2004-05-14' AS Date), N'Phước Tuy', N'12353222342', N'Nữ', 5000000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv31', N'Lê Thanh Lâm', CAST(N'2004-05-15' AS Date), N'Sa Đéc', N'949649766546', N'Nam', 5000000, N'123456', N'BT', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [CCCD], [Phai], [Luong], [MatKhau], [LoaiNhanVien], [MatKhauMH]) VALUES (N'nv32', N'Trịnh Phúc Hậu', CAST(N'2004-05-15' AS Date), N'Bếp Tre', N'392165455964', N'Nam', 50000000, N'123456', N'TN', N'e10adc3949ba59abbe56e057f20f883e')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH NOCHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH NOCHECK ADD FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ChiTietHoaDon_BanAn] FOREIGN KEY([MaBanAn])
REFERENCES [dbo].[BanAn] ([MaBanAn])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_ChiTietHoaDon_BanAn]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichLamViecNV]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[MonAn]  WITH NOCHECK ADD  CONSTRAINT [fk_MonAn_LoaiMonAn] FOREIGN KEY([MaLoaiMonAn])
REFERENCES [dbo].[LoaiMonAn] ([MaLoaiMA])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [fk_MonAn_LoaiMonAn]
GO
ALTER TABLE [dbo].[NguyenLieu_MonAn]  WITH CHECK ADD FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[NguyenLieu_MonAn]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaHang] SET  READ_WRITE 
GO
