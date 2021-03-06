USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='[QuanLyNhanVien]')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'[QuanLyNhanVien]') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QuanLyNhanVien]
END
/****** Object:  Database [QuanLyNhanVien]    Script Date: 26/12/2019 10:29:35 SA ******/
CREATE DATABASE [QuanLyNhanVien]
GO


USE [QuanLyNhanVien]
GO
/****** Object:  Table [dbo].[BAC]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAC](
	[MaBac] [nvarchar](50) NOT NULL,
	[TenBac] [nvarchar](50) NULL,
 CONSTRAINT [PK_BAC] PRIMARY KEY CLUSTERED 
(
	[MaBac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBoPhan] [nvarchar](50) NOT NULL,
	[TenBoPhan] [nvarchar](50) NULL,
	[PhongBan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BoPhan] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cong]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cong](
	[MaNhanVien] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[NgayCong] [int] NULL,
	[MaHSPC] [nvarchar](50) NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nvarchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANTOC]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANTOC](
	[MaDT] [nvarchar](50) NOT NULL,
	[TenDT] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANTOC] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HESOLUONGNHANVIEN]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HESOLUONGNHANVIEN](
	[MaHSLuong] [nvarchar](50) NOT NULL,
	[MaNgachLuong] [nvarchar](50) NULL,
	[MaBAC] [nvarchar](50) NULL,
	[HSLuong] [float] NULL,
 CONSTRAINT [PK_HESOLUONGNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaHSLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HESOPHUCAP]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HESOPHUCAP](
	[MaHSPC] [nvarchar](50) NOT NULL,
	[HSPC] [float] NULL,
 CONSTRAINT [PK_HESOPHUCAP] PRIMARY KEY CLUSTERED 
(
	[MaHSPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HONNHAN]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HONNHAN](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenVoChong] [nvarchar](50) NULL,
	[NTDuoi15] [smallint] NULL,
	[NTTren15] [smallint] NULL,
	[NTTren60] [smallint] NULL,
 CONSTRAINT [PK_HONNHAN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGACH]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGACH](
	[MaNgach] [nvarchar](50) NOT NULL,
	[TenNgach] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGACH] PRIMARY KEY CLUSTERED 
(
	[MaNgach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[MaBac] [nvarchar](50) NULL,
	[MaBoPhan] [nvarchar](50) NULL,
	[MaCV] [nvarchar](50) NULL,
	[MaHSLuong] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaNgach] [nvarchar](50) NULL,
	[MaPB] [nvarchar](50) NULL,
	[MaQT] [nvarchar](50) NULL,
	[MaTG] [nvarchar](50) NULL,
	[MaTDHV] [nvarchar](50) NULL,
	[MaTDNN] [nvarchar](50) NULL,
	[MaTDTH] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[MaDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPB] [nvarchar](50) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[SoLuongNhanVien] [smallint] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUOCTICH]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUOCTICH](
	[MaQT] [nvarchar](50) NOT NULL,
	[TenQT] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUOCTICH] PRIMARY KEY CLUSTERED 
(
	[MaQT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nchar](50) NULL,
	[MatKhau] [nchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TienLuong]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienLuong](
	[MaNhanVien] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[MaHSLuong] [nvarchar](50) NULL,
	[TienLuong] [float] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TONGIAO]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TONGIAO](
	[MaTG] [nvarchar](50) NOT NULL,
	[TenTG] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TONGIAO] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRINHDOHOCVAN]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRINHDOHOCVAN](
	[MaTDHV] [nvarchar](50) NOT NULL,
	[TenTDHV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRINHDOHOCVAN] PRIMARY KEY CLUSTERED 
(
	[MaTDHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRINHDONGOAINGU]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRINHDONGOAINGU](
	[MaTDNN] [nvarchar](50) NOT NULL,
	[TenTDNN] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRINHDONGOAINGU] PRIMARY KEY CLUSTERED 
(
	[MaTDNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRINHDOTINHOC]    Script Date: 26/12/2019 10:29:35 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRINHDOTINHOC](
	[MaTDTH] [nvarchar](50) NOT NULL,
	[TenTDTH] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRINHDOTINHOC] PRIMARY KEY CLUSTERED 
(
	[MaTDTH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'1', N'Bậc 1')
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'2', N'Bậc 2')
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'3', N'Bậc 3')
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'4', N'Bậc 4')
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'5', N'Bậc 5')
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'6', N'Bậc 6')
INSERT [dbo].[BAC] ([MaBac], [TenBac]) VALUES (N'7', N'Bậc 7')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [PhongBan], [GhiChu]) VALUES (N'BV', N'Bảo Vệ', N'', N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [PhongBan], [GhiChu]) VALUES (N'GD', N'Giảng Dạy', N'', N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [PhongBan], [GhiChu]) VALUES (N'KT', N'Kiểm Toán', N'', N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [PhongBan], [GhiChu]) VALUES (N'QL', N'Quản Lý', N'', N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [PhongBan], [GhiChu]) VALUES (N'TK', N'Thống Kê', N'', N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [PhongBan], [GhiChu]) VALUES (N'YT', N'Y Tế', N'', N'')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [GhiChu]) VALUES (N'GD', N'Giám Đốc', NULL)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [GhiChu]) VALUES (N'NV', N'Nhân Viên', NULL)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [GhiChu]) VALUES (N'PGD', N'Phó Giám Đốc', NULL)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [GhiChu]) VALUES (N'TP', N'Trưởng Phòng', NULL)
INSERT [dbo].[DANTOC] ([MaDT], [TenDT], [GhiChu]) VALUES (N'DT1', N'Kinh', N'')
INSERT [dbo].[DANTOC] ([MaDT], [TenDT], [GhiChu]) VALUES (N'DT2', N'Tài', N'')
INSERT [dbo].[DANTOC] ([MaDT], [TenDT], [GhiChu]) VALUES (N'DT3', N'Thái', N'')
INSERT [dbo].[DANTOC] ([MaDT], [TenDT], [GhiChu]) VALUES (N'DT4', N'Thượng', N'')
INSERT [dbo].[DANTOC] ([MaDT], [TenDT], [GhiChu]) VALUES (N'DT5', N'Khơ Me', N'')
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV11', N'BV1', N'1', 1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV12', N'BV1', N'2', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV13', N'BV1', N'3', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV14', N'BV1', N'4', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV15', N'BV1', N'5', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV16', N'BV1', N'6', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV17', N'BV1', N'7', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV21', N'BV2', N'1', 15)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV22', N'BV2', N'2', 25)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV23', N'BV2', N'3', 35)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV24', N'BV2', N'4', 45)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV25', N'BV2', N'5', 55)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV26', N'BV2', N'6', 65)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSBV27', N'BV2', N'7', 75)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD11', N'GD1', N'1', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD12', N'GD1', N'2', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD13', N'GD1', N'3', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD14', N'GD1', N'4', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD15', N'GD1', N'5', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD16', N'GD1', N'6', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD17', N'GD1', N'7', 8)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD21', N'GD2', N'1', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD22', N'GD2', N'2', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD23', N'GD2', N'3', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD24', N'GD2', N'4', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD25', N'GD2', N'5', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD26', N'GD2', N'6', 8)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD27', N'GD2', N'7', 9)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD31', N'GD3', N'1', 1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD32', N'GD3', N'2', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD33', N'GD3', N'3', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD34', N'GD3', N'4', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD35', N'GD3', N'5', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD36', N'GD3', N'6', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSGD37', N'GD3', N'7', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT11', N'KT1', N'1', 1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT12', N'KT1', N'2', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT13', N'KT1', N'3', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT14', N'KT1', N'4', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT15', N'KT1', N'5', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT16', N'KT1', N'6', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT17', N'KT1', N'7', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT21', N'KT2', N'1', 15)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT22', N'KT2', N'2', 25)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT23', N'KT2', N'3', 35)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT24', N'KT2', N'4', 45)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT25', N'KT2', N'5', 55)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT26', N'KT2', N'6', 65)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSKT27', N'KT2', N'7', 75)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL11', N'QL1', N'1', 1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL12', N'QL1', N'2', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL13', N'QL1', N'3', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL14', N'QL1', N'4', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL15', N'QL1', N'5', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL16', N'QL1', N'6', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL17', N'QL1', N'7', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL21', N'QL2', N'1', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL22', N'QL2', N'2', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL23', N'QL2', N'3', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL24', N'QL2', N'4', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL25', N'QL2', N'5', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL26', N'QL2', N'6', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL27', N'QL2', N'7', 8)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL31', N'QL3', N'1', 2.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL32', N'QL3', N'2', 3.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL33', N'QL3', N'3', 4.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL34', N'QL3', N'4', 5.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL35', N'QL3', N'5', 6.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL36', N'QL3', N'6', 7.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSQL37', N'QL3', N'7', 8.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK11', N'TK1', N'1', 1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK12', N'TK1', N'2', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK13', N'TK1', N'3', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK14', N'TK1', N'4', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK15', N'TK1', N'5', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK16', N'TK1', N'6', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSTK17', N'TK1', N'7', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT11', N'YT1', N'1', 1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT12', N'YT1', N'2', 2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT13', N'YT1', N'3', 3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT14', N'YT1', N'4', 4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT15', N'YT1', N'5', 5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT16', N'YT1', N'6', 6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT17', N'YT1', N'7', 7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT21', N'YT2', N'1', 1.1)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT22', N'YT2', N'2', 2.2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT23', N'YT2', N'3', 2.3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT24', N'YT2', N'4', 2.4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT25', N'YT2', N'5', 2.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT26', N'YT2', N'6', 2.6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT27', N'YT2', N'7', 2.7)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT31', N'YT3', N'1', 2.2)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT32', N'YT3', N'2', 2.3)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT33', N'YT3', N'3', 2.4)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT34', N'YT3', N'4', 2.5)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT35', N'YT3', N'5', 4.6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT36', N'YT3', N'6', 4.6)
INSERT [dbo].[HESOLUONGNHANVIEN] ([MaHSLuong], [MaNgachLuong], [MaBAC], [HSLuong]) VALUES (N'HSYT37', N'YT3', N'7', 0.47)
INSERT [dbo].[HESOPHUCAP] ([MaHSPC], [HSPC]) VALUES (N'PC0', 0)
INSERT [dbo].[HESOPHUCAP] ([MaHSPC], [HSPC]) VALUES (N'PC1', 0.1)
INSERT [dbo].[HESOPHUCAP] ([MaHSPC], [HSPC]) VALUES (N'PC2', 0.2)
INSERT [dbo].[HESOPHUCAP] ([MaHSPC], [HSPC]) VALUES (N'PC3', 0.3)
INSERT [dbo].[HESOPHUCAP] ([MaHSPC], [HSPC]) VALUES (N'PC4', 0.4)
INSERT [dbo].[HESOPHUCAP] ([MaHSPC], [HSPC]) VALUES (N'PC5', 0.5)
INSERT [dbo].[HONNHAN] ([MaNV], [TenVoChong], [NTDuoi15], [NTTren15], [NTTren60]) VALUES (N'1', NULL, NULL, NULL, NULL)
INSERT [dbo].[HONNHAN] ([MaNV], [TenVoChong], [NTDuoi15], [NTTren15], [NTTren60]) VALUES (N'2', NULL, NULL, NULL, NULL)
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'BV1', N'Nhân Viên Bảo Vệ')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'BV2', N'Quản Lý Đội Bảo Vệ')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'GD1', N'Giảng Viên Chính')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'GD2', N'Giảng Viên ')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'GD3', N'Giảng Viên Hợp Đồng')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'KT1', N'Nhân Viên Kiểm Toán')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'KT2', N'Chuyên Viên Kiểm Toán')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'QL1', N'Quản lý thư viện')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'QL2', N'Quản lý Sinh Viên')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'QL3', N'Quản lý Bảo Hiểm')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'TK1', N'Thống Kê ')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'YT1', N'Y tá')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'YT2', N'Y tá thời vụ')
INSERT [dbo].[NGACH] ([MaNgach], [TenNgach]) VALUES (N'YT3', N'Y tá Chính')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaBac], [MaBoPhan], [MaCV], [MaHSLuong], [MaNV], [MaNgach], [MaPB], [MaQT], [MaTG], [MaTDHV], [MaTDNN], [MaTDTH], [GhiChu], [MaDT]) VALUES (N'NV1', N'Vũ Anh Khoa', N'1', N'BV', N'GD', N'HSBV11', N'1', N'BV1', N'ATTT', N'In', N'KG', N'CN', N'IE4', N'A', N'', N'DT1')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaBac], [MaBoPhan], [MaCV], [MaHSLuong], [MaNV], [MaNgach], [MaPB], [MaQT], [MaTG], [MaTDHV], [MaTDNN], [MaTDTH], [GhiChu], [MaDT]) VALUES (N'NV2', N'Anh Nam', N'1', N'BV', N'GD', N'HSBV11', N'1', N'BV1', N'ATTT', N'In', N'KG', N'CN', N'IE4', N'A', N'', N'DT1')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaBac], [MaBoPhan], [MaCV], [MaHSLuong], [MaNV], [MaNgach], [MaPB], [MaQT], [MaTG], [MaTDHV], [MaTDNN], [MaTDTH], [GhiChu], [MaDT]) VALUES (N'NV3', N'Nguyễn Lê Chấn Nam', N'1', N'BV', N'NV', N'HSBV11', N'1', N'BV2', N'ATTT', N'In', N'KG', N'CN', N'IE4', N'A', N'', N'DT1')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MaBac], [MaBoPhan], [MaCV], [MaHSLuong], [MaNV], [MaNgach], [MaPB], [MaQT], [MaTG], [MaTDHV], [MaTDNN], [MaTDTH], [GhiChu], [MaDT]) VALUES (N'NV4', N'Nguyễn Phi Phú', N'1', N'BV', N'NV', N'HSBV11', N'1', N'BV1', N'ATTT', N'In', N'KG', N'CN', N'IE4', N'A', N'', N'DT1')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'ATTT', N'An Toàn Thông Tin', 2, N'')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'CNPM', N'Khoa Công Nghệ Phần Mềm', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'CTSV', N'Phòng Công Tác Sinh Viên', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'HTTT', N'Hệ Thống Thông Tin', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'KTMT', N'Kỹ Thuật Máy Tính', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'KHMT', N'Khoa Học Máy Tính', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'KHTC', N'Phòng Kế Hoạch Tài Chính', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'MMT', N'Mạng Máy Tính Và Truyền Thông', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'PDT', N'Phòng Đào Tào', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'PKD', N'Phòng Kinh Doanh', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'PTS', N'Phòng Tuyển Sinh', 0, NULL)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [SoLuongNhanVien], [GhiChu]) VALUES (N'TMDT', N'Thương Mại Điện Tử', 0, NULL)
INSERT [dbo].[QUOCTICH] ([MaQT], [TenQT], [GhiChu]) VALUES (N'In', N'Ấn Độ', NULL)
INSERT [dbo].[QUOCTICH] ([MaQT], [TenQT], [GhiChu]) VALUES (N'UK', N'Anh', NULL)
INSERT [dbo].[QUOCTICH] ([MaQT], [TenQT], [GhiChu]) VALUES (N'US', N'Mỹ', NULL)
INSERT [dbo].[QUOCTICH] ([MaQT], [TenQT], [GhiChu]) VALUES (N'VN', N'Việt Nam', NULL)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'liem', N'123')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'liem123', N'123456')
INSERT [dbo].[TienLuong] ([MaNhanVien], [TenNhanVien], [MaHSLuong], [TienLuong], [Thang], [Nam], [GhiChu]) VALUES (N'NV2', N'Anh Nam', N'HSBV11', 0, 12, 2019, N'Chưa Chấm Công')
INSERT [dbo].[TienLuong] ([MaNhanVien], [TenNhanVien], [MaHSLuong], [TienLuong], [Thang], [Nam], [GhiChu]) VALUES (N'NV2', N'Anh Nam', N'HSBV11', 0, 1, 2020, N'Chưa Chấm Công')
INSERT [dbo].[TienLuong] ([MaNhanVien], [TenNhanVien], [MaHSLuong], [TienLuong], [Thang], [Nam], [GhiChu]) VALUES (N'NV3', N'Nguyễn Lê Chấn Nam', N'HSBV11', 0, 12, 2019, N'Chưa Chấm Công')
INSERT [dbo].[TienLuong] ([MaNhanVien], [TenNhanVien], [MaHSLuong], [TienLuong], [Thang], [Nam], [GhiChu]) VALUES (N'NV4', N'Nguyễn Phi Phú', N'HSBV11', 0, 12, 2019, N'Chưa Chấm Công')
INSERT [dbo].[TONGIAO] ([MaTG], [TenTG], [GhiChu]) VALUES (N'KG', N'Không', NULL)
INSERT [dbo].[TONGIAO] ([MaTG], [TenTG], [GhiChu]) VALUES (N'PG', N'Phật Giáo', NULL)
INSERT [dbo].[TONGIAO] ([MaTG], [TenTG], [GhiChu]) VALUES (N'TCG', N'Thiên Chúa Giáo', NULL)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [GhiChu]) VALUES (N'CN', N'Cử Nhân', NULL)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [GhiChu]) VALUES (N'GS', N'Giáo Sư', NULL)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [GhiChu]) VALUES (N'KS', N'Kỹ Sư', NULL)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [GhiChu]) VALUES (N'PGS', N'Phó Giáo Sư', NULL)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [GhiChu]) VALUES (N'TS', N'Tiến Sĩ', NULL)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [GhiChu]) VALUES (N'Th.S', N'Thạc Sĩ', NULL)
INSERT [dbo].[TRINHDONGOAINGU] ([MaTDNN], [TenTDNN]) VALUES (N'IE4', N'Ielts 4')
INSERT [dbo].[TRINHDONGOAINGU] ([MaTDNN], [TenTDNN]) VALUES (N'IE6.5', N'Ielts 6.5')
INSERT [dbo].[TRINHDONGOAINGU] ([MaTDNN], [TenTDNN]) VALUES (N'IE8', N'Ielts 8')
INSERT [dbo].[TRINHDONGOAINGU] ([MaTDNN], [TenTDNN]) VALUES (N'To5', N'Toiec 500')
INSERT [dbo].[TRINHDONGOAINGU] ([MaTDNN], [TenTDNN]) VALUES (N'To7', N'Toiec700')
INSERT [dbo].[TRINHDONGOAINGU] ([MaTDNN], [TenTDNN]) VALUES (N'To9', N'Toiec 900')
INSERT [dbo].[TRINHDOTINHOC] ([MaTDTH], [TenTDTH]) VALUES (N'A', N'Tin Học Văn Phòng')
INSERT [dbo].[TRINHDOTINHOC] ([MaTDTH], [TenTDTH]) VALUES (N'B', N'Tin Học Quản Lý')
INSERT [dbo].[TRINHDOTINHOC] ([MaTDTH], [TenTDTH]) VALUES (N'C', N'Tin Học Kế Toán')
INSERT [dbo].[TRINHDOTINHOC] ([MaTDTH], [TenTDTH]) VALUES (N'D', N'TIn Học Giảng Dạy')
