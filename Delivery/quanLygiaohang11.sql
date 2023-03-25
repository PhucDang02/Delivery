USE [quanlygiaohang11]
GO
/****** Object:  Table [dbo].[DH]    Script Date: 3/26/2023 12:28:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DH](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[MaVanDon] [nvarchar](10) NOT NULL,
	[HoTenNG] [nvarchar](30) NULL,
	[DiaChiNG] [nvarchar](50) NULL,
	[SdtNG] [nvarchar](30) NULL,
	[HotenNN] [nvarchar](30) NULL,
	[DiaChiNN] [nvarchar](30) NULL,
	[SdtNN] [nvarchar](30) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DH_DaNhan]    Script Date: 3/26/2023 12:28:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DH_DaNhan](
	[MaDH_DaNhan] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NULL,
	[MaVanDon] [nvarchar](10) NOT NULL,
	[HoTenNG] [nvarchar](30) NULL,
	[DiaChiNG] [nvarchar](50) NULL,
	[SdtNG] [nvarchar](30) NULL,
	[HotenNN] [nvarchar](30) NULL,
	[DiaChiNN] [nvarchar](30) NULL,
	[SdtNN] [nvarchar](30) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDH_DaNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DH] ON 

INSERT [dbo].[DH] ([MaDH], [MaVanDon], [HoTenNG], [DiaChiNG], [SdtNG], [HotenNN], [DiaChiNN], [SdtNN], [TrangThai]) VALUES (18, N'VD003', N'Nguyễn Ngọc Phương', N'Q7 HCM', N'0956475936', N'Trương Phú Lợi', N'Tây Ninh', N'07553856934', N'Chờ xử lý')
SET IDENTITY_INSERT [dbo].[DH] OFF
GO
SET IDENTITY_INSERT [dbo].[DH_DaNhan] ON 

INSERT [dbo].[DH_DaNhan] ([MaDH_DaNhan], [MaDH], [MaVanDon], [HoTenNG], [DiaChiNG], [SdtNG], [HotenNN], [DiaChiNN], [SdtNN], [TrangThai]) VALUES (1, 15, N'VD01', N'Quang Khải', N'Q. Tân Bình', N'0856489365', N'Bảo Hiệp', N'Gò Vấp HCM', N'0956693651', N'Đã nhận')
INSERT [dbo].[DH_DaNhan] ([MaDH_DaNhan], [MaDH], [MaVanDon], [HoTenNG], [DiaChiNG], [SdtNG], [HotenNN], [DiaChiNN], [SdtNN], [TrangThai]) VALUES (2, 16, N'VD001', N'Chiêm Đức Giang', N'Q6 HCM', N'0385341231', N'Đặng Ngọc Phúc', N'Q3  HCM', N'0908973123', N'Chờ xử lý')
INSERT [dbo].[DH_DaNhan] ([MaDH_DaNhan], [MaDH], [MaVanDon], [HoTenNG], [DiaChiNG], [SdtNG], [HotenNN], [DiaChiNN], [SdtNN], [TrangThai]) VALUES (3, 17, N'VD002', N'Đinh Quang Khải', N'Q. Tân Bình', N'0856489365', N'Tống Bảo Hiệp', N'Gò Vấp HCM', N'0956693651', N'Chờ xử lý')
SET IDENTITY_INSERT [dbo].[DH_DaNhan] OFF
GO
