USE [master]
GO
/****** Object:  Database [QuanLyTiemGiatLa]    Script Date: 03/18/2019 23:38:24 ******/
CREATE DATABASE [QuanLyTiemGiatLa] ON  PRIMARY 
( NAME = N'QuanLyTiemGiatLa', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\data\QuanLyTiemGiatLa.mdf' , SIZE = 240640KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyTiemGiatLa_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\data\QuanLyTiemGiatLa_1.ldf' , SIZE = 29504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'QuanLyTiemGiatLa', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTiemGiatLa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET  READ_WRITE 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTiemGiatLa] SET DB_CHAINING OFF 
GO
USE [QuanLyTiemGiatLa]
GO
/****** Object:  User [sa_bak]    Script Date: 03/18/2019 23:33:07 ******/
CREATE USER [sa_bak] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[KieuGiatLa]    Script Date: 03/18/2019 23:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KieuGiatLa](
	[MaKieuGiat] [int] IDENTITY(1,1) NOT NULL,
	[TenKieuGiat] [nvarchar](100) NULL,
 CONSTRAINT [PK_KieuGiatLa] PRIMARY KEY CLUSTERED 
(
	[MaKieuGiat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Insert]    Script Date: 03/18/2019 23:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_Insert]
(
	@TenKhachHang nvarchar(100),
	@DiaChi nvarchar(200) = null,
	@DienThoai varchar(20) = null,
	@MaVip int = null,
	@SoTheVip varchar(20) = null
)
AS
BEGIN
	DECLARE @sql nvarchar(500);
	------------------------------------------------	
	SET @sql = 'INSERT INTO KhachHang(TenKhachHang';	
	IF (@DiaChi is not null)
		SET @sql = @sql + ',DiaChi';
	IF (@DienThoai is not null)
		SET @sql = @sql + ',DienThoai';
	IF (@MaVip is not null)
		SET @sql = @sql + ',MaVip';
	IF (@SoTheVip is not null)
		SET @sql = @sql + ',SoTheVip';
	------------------------------------------------
	SET @sql = @sql + ') VALUES(N''' + @TenKhachHang + '''';
	IF (@DiaChi is not null)
		SET @sql = @sql + ',N''' + @DiaChi + '''';
	IF (@DienThoai is not null)
		SET @sql = @sql + ',N''' + @DienThoai + '''';
	IF (@MaVip is not null)
		SET @sql = @sql + ',' + CAST(@MaVip AS VARCHAR);
	IF (@SoTheVip is not null)
		SET @sql = @sql + ',N''' + @SoTheVip + '''';
	------------------------------------------------
	SET @sql = @sql + ')';
	SET @sql = @sql + ';SELECT SCOPE_IDENTITY();';
	------------------------------------------------
	EXEC(@sql);	
END
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 03/18/2019 23:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLoaiHang] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHang] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieu_Delete]    Script Date: 03/18/2019 23:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieu_Delete]
(
	@IDChiTietPhieu bigint
)
AS
BEGIN
	DELETE dbo.ChiTietPhieu WHERE IDChiTietPhieu = @IDChiTietPhieu
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_Phieu_TinhTongTien]    Script Date: 03/18/2019 23:33:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_Phieu_TinhTongTien]
(
	@MaPhieu bigint
)
RETURNS bigint
AS
BEGIN
	DECLARE @ResultVar bigint;
	SELECT @ResultVar = sum(Soluong * DonGia) FROM dbo.ChiTietPhieu where dbo.ChiTietPhieu.MaPhieu = @MaPhieu;
	RETURN @ResultVar
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_Delete]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Phieu_Delete]
(
	@MaPhieu bigint
)
AS
BEGIN
	DELETE dbo.Phieu WHERE MaPhieu = @MaPhieu
END
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 03/18/2019 23:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [int] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DotGiamGia]    Script Date: 03/18/2019 23:32:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DotGiamGia](
	[MaDotGiamGia] [int] IDENTITY(1,1) NOT NULL,
	[TenDotGiamGia] [nvarchar](200) NULL,
	[TuNgay] [datetime] NULL,
	[DenNgay] [datetime] NULL,
	[GiamGia] [int] NULL,
 CONSTRAINT [PK_DotGiamGia] PRIMARY KEY CLUSTERED 
(
	[MaDotGiamGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Phieu_SelectByNgayLap]    Script Date: 03/18/2019 23:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_Phieu_SelectByNgayLap]
(
	@TuNgay datetime = null,
	@DenNgay datetime = null
)
AS
BEGIN
	DECLARE @sql nvarchar(500);
	SET @sql = '
	SELECT
	MaKhachHang,
	GiamGia,
	TongTien
	FROM dbo.Phieu
	WHERE DaThanhToan = 1';
	IF (@TuNgay IS NOT null AND @DenNgay is not null)
		BEGIN
			SET @sql = @sql + '	AND datediff(day, ''' + CAST(@TuNgay AS VARCHAR) + ''', NgayLap) >= 0';
			SET @sql = @sql + ' AND	datediff(day, ''' + CAST(@DenNgay AS VARCHAR) + ''', NgayLap) <= 0';
		END
	exec (@sql);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuSlot_SelectViecCanLam]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuSlot_SelectViecCanLam]
(
	@tungay datetime = null,
	@denngay datetime = null,
	@maphieu bigint = null,
	@mavach bigint = null,
	@TenHang nvarchar(100) = null
)
AS
BEGIN
	DECLARE @sql nvarchar(900);
	SET @sql = '
	SELECT
	dbo.Phieu_Slot.*,
	dbo.MatHang.TenHang, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM
	dbo.Phieu_Slot 
	INNER JOIN dbo.Phieu ON dbo.Phieu_Slot.MaPhieu = dbo.Phieu.MaPhieu 
	INNER JOIN dbo.KieuGiatLa ON dbo.Phieu_Slot.MaKieuGiat = dbo.KieuGiatLa.MaKieuGiat
	INNER JOIN dbo.MatHang ON dbo.Phieu_Slot.MaHang = dbo.MatHang.MaHang
	WHERE 1=1'
	IF (@tungay is not null)
		SET @sql = @sql + ' AND datediff(day, dbo.Phieu.NgayHenTra, ''' + CAST(@tungay AS VARCHAR) + ''') <= 0';
	IF (@denngay is not null)
		SET @sql = @sql + ' AND datediff(day, dbo.Phieu.NgayHenTra, ''' + CAST(@denngay AS VARCHAR) + ''') >= 0';
	IF (@maphieu is not null)
		SET @sql = @sql + ' AND dbo.Phieu_Slot.MaPhieu = ' + CAST(@maphieu AS VARCHAR);
	IF (@mavach is not null)
		SET @sql = @sql + ' AND dbo.Phieu_Slot.MaVach = ' + CAST(@mavach AS VARCHAR);
	IF (@TenHang is not null)
		SET @sql = @sql + ' AND dbo.MatHang.TenHang LIKE N''%' + @TenHang + '%''';
	EXEC (@sql);
END
GO
/****** Object:  Table [dbo].[MucDoVip]    Script Date: 03/18/2019 23:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucDoVip](
	[MaVip] [int] IDENTITY(1,1) NOT NULL,
	[TenVip] [nvarchar](50) NULL,
	[GiamGia] [int] NULL,
 CONSTRAINT [PK_MucDoVip] PRIMARY KEY CLUSTERED 
(
	[MaVip] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Information]    Script Date: 03/18/2019 23:32:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Information](
	[PhieuChotKetGanNhat] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChotKet]    Script Date: 03/18/2019 23:32:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChotKet](
	[MaChotKet] [int] IDENTITY(1,1) NOT NULL,
	[ThoiDiemChot] [datetime] NULL,
	[SoTienChot] [bigint] NULL,
	[NguoiChot] [varchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[TuPhieu] [bigint] NULL,
	[DenPhieu] [bigint] NULL,
 CONSTRAINT [PK_ChotKet] PRIMARY KEY CLUSTERED 
(
	[MaChotKet] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_SearchByWhere]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_SearchByWhere]
(
	@where nvarchar(400)
)
AS
BEGIN
	DECLARE @sql nvarchar(500);
	SET @sql = 'SELECT dbo.KhachHang.*,
	dbo.MucDoVip.TenVip 
	FROM dbo.KhachHang LEFT OUTER JOIN dbo.MucDoVip
	ON dbo.KhachHang.MaVip = dbo.MucDoVip.MaVip ' + @where;
	EXEC(@sql);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectBySql]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectBySql]
(
	@sql nvarchar(1000)
)	
AS
BEGIN
	EXEC (@sql);	
END
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/18/2019 23:33:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserName] [varchar](50) NOT NULL,
	[PassWord] [varchar](50) NULL,
	[Quyen] [tinyint] NULL,
	[HoTen] [nvarchar](50) NULL,
	[QuyenHan] [varchar](30) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Search]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_Search]
(
	@TenKhachHang nvarchar(100) = null,
	@DiaChi nvarchar(200) = null,
	@DienThoai varchar(20) = null,
	@SoTheVip varchar(20) = null
)
AS
BEGIN
	DECLARE @sql nvarchar(500);
	SET @sql = 'SELECT dbo.KhachHang.*,
	dbo.MucDoVip.TenVip, dbo.MucDoVip.GiamGia
	FROM dbo.KhachHang LEFT OUTER JOIN dbo.MucDoVip
	ON dbo.KhachHang.MaVip = dbo.MucDoVip.MaVip WHERE 1=1';
	IF (@TenKhachHang IS NOT null)
		SET @sql = @sql + ' AND TenKhachHang LIKE N''%' + @TenKhachHang + '%''';
	IF (@DiaChi IS NOT null)
		SET @sql = @sql + ' AND DiaChi LIKE N''%' + @DiaChi + '%''';
	IF (@DienThoai IS NOT null)
		SET @sql = @sql + ' AND DienThoai LIKE ''%' + @DienThoai + '%''';
	IF (@SoTheVip IS NOT null)
		SET @sql = @sql + ' AND SoTheVip = N''' + @SoTheVip + '''';
	EXEC(@sql);
END
GO
/****** Object:  Table [dbo].[ChiTietPhieu]    Script Date: 03/18/2019 23:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieu](
	[IDChiTietPhieu] [bigint] IDENTITY(1,1) NOT NULL,
	[MaPhieu] [bigint] NULL,
	[MaHang] [int] NULL,
	[MaKieuGiat] [int] NULL,
	[Soluong] [int] NULL,
	[DonGia] [bigint] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietPhieu] PRIMARY KEY CLUSTERED 
(
	[IDChiTietPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangGia]    Script Date: 03/18/2019 23:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangGia](
	[IDGia] [int] IDENTITY(1,1) NOT NULL,
	[MaHang] [int] NULL,
	[MaKieuGiat] [int] NULL,
	[DonGia] [bigint] NULL,
	[SoSanPham] [tinyint] NULL,
 CONSTRAINT [PK_BangGia] PRIMARY KEY CLUSTERED 
(
	[IDGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 03/18/2019 23:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaHang] [int] IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](200) NULL,
	[MaLoaiHang] [int] NULL,
	[ImageStringFile] [nvarchar](500) NULL,
 CONSTRAINT [PK_Hang] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shelf]    Script Date: 03/18/2019 23:33:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shelf](
	[MaKho] [int] NOT NULL,
	[Slot] [int] NOT NULL,
	[MaCacPhieuDangSuDung] [varchar](100) NULL,
 CONSTRAINT [PK_Shelf] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC,
	[Slot] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phieu]    Script Date: 03/18/2019 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phieu](
	[MaPhieu] [bigint] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [bigint] NULL,
	[NgayLap] [datetime] NULL,
	[NgayHenTra] [datetime] NULL,
	[GiamGia] [int] NULL,
	[DaThanhToan] [bit] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[DaTraDo] [bit] NULL,
	[UserName] [varchar](50) NULL,
	[TongTien] [bigint] NULL,
	[SoLanIn] [int] NULL,
	[PhiGiaoNhan] [int] NULL,
	[IsPhieuHuy] [bit] NULL,
	[IsSynced] [bit] NULL,
 CONSTRAINT [PK_Phieu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phieu_Slot]    Script Date: 03/18/2019 23:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phieu_Slot](
	[MaPhieu] [bigint] NOT NULL,
	[STT] [int] NOT NULL,
	[MaHang] [int] NULL,
	[MaKieuGiat] [int] NULL,
	[Kho] [nvarchar](50) NULL,
	[Slot] [int] NULL,
	[DaTra] [bit] NULL,
	[MaVach] [bigint] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[SoHieuSanPham] [varchar](10) NULL,
	[NgayTra] [varchar](16) NULL,
	[ThoiDiemLuu] [varchar](50) NULL,
 CONSTRAINT [PK_Phieu_Slot] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[STT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phieu_Slot_DaTra]    Script Date: 03/18/2019 23:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phieu_Slot_DaTra](
	[MaPhieu] [bigint] NOT NULL,
	[STT] [int] NOT NULL,
	[MaHang] [int] NULL,
	[MaKieuGiat] [int] NULL,
	[Kho] [nvarchar](50) NULL,
	[Slot] [int] NULL,
	[DaTra] [bit] NULL,
	[MaVach] [bigint] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[SoHieuSanPham] [varchar](10) NULL,
	[NgayTra] [varchar](16) NULL,
	[ThoiDiemLuu] [varchar](50) NULL,
 CONSTRAINT [PK_Phieu_Slot_DaTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[STT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 03/18/2019 23:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [bigint] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [varchar](20) NULL,
	[MaVip] [int] NULL,
	[SoTheVip] [varchar](20) NULL,
	[IsSynced] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuSlot_DaTra_SelectByMaPhieu]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------
CREATE PROCEDURE [dbo].[sp_PhieuSlot_DaTra_SelectByMaPhieu]
(
	@MaPhieu bigint
)
AS
BEGIN
	SELECT
	dbo.Phieu_Slot_DaTra.*,
	dbo.MatHang.TenHang, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM 
	dbo.Phieu_Slot_DaTra
	INNER JOIN dbo.MatHang ON dbo.Phieu_Slot_DaTra.MaHang = dbo.MatHang.MaHang 
	INNER JOIN dbo.KieuGiatLa ON dbo.Phieu_Slot_DaTra.MaKieuGiat = dbo.KieuGiatLa.MaKieuGiat
	WHERE dbo.Phieu_Slot_DaTra.MaPhieu=@MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KieuGiatLa_SelectByMaHang]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KieuGiatLa_SelectByMaHang]
(
	@MaHang int
)
AS
BEGIN
	SELECT
	dbo.KieuGiatLa.MaKieuGiat, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM 
	dbo.KieuGiatLa INNER JOIN dbo.BangGia 
	ON dbo.KieuGiatLa.MaKieuGiat = dbo.BangGia.MaKieuGiat
	WHERE dbo.BangGia.MaHang = @MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KieuGiatLa_SelectAll]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KieuGiatLa_SelectAll]
AS
BEGIN
	SELECT 
	MaKieuGiat,
	TenKieuGiat
	FROM dbo.KieuGiatLa
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KieuGiatLa_Delete]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_KieuGiatLa_Delete]
(
	@MaKieuGiat int
)
AS
BEGIN
	DELETE dbo.KieuGiatLa WHERE MaKieuGiat = @MaKieuGiat
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KieuGiatLa_Insert]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KieuGiatLa_Insert]
(
	@TenKieuGiat nvarchar(100)
)
AS
BEGIN
	INSERT INTO dbo.KieuGiatLa(TenKieuGiat)
	VALUES (@TenKieuGiat);
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KieuGiatLa_Update]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KieuGiatLa_Update]
(
	@MaKieuGiat int,
	@TenKieuGiat nvarchar(100)
)
AS
BEGIN
	UPDATE dbo.KieuGiatLa SET 
	TenKieuGiat = @TenKieuGiat
	WHERE MaKieuGiat = @MaKieuGiat
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BangGia_SelectAll]    Script Date: 03/18/2019 23:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BangGia_SelectAll]
AS
BEGIN
	SELECT     
	dbo.BangGia.IDGia, 
	dbo.BangGia.MaHang, 
	dbo.BangGia.MaKieuGiat, 
	dbo.BangGia.DonGia,
	dbo.BangGia.SoSanPham,
	dbo.MatHang.TenHang, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM         
	dbo.BangGia INNER JOIN dbo.MatHang 
	ON dbo.BangGia.MaHang = dbo.MatHang.MaHang 
	INNER JOIN dbo.KieuGiatLa
	ON dbo.BangGia.MaKieuGiat = dbo.KieuGiatLa.MaKieuGiat
	ORDER BY dbo.MatHang.TenHang, dbo.KieuGiatLa.TenKieuGiat
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieu_SelectByMaPhieu]    Script Date: 03/18/2019 23:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieu_SelectByMaPhieu]
(
	@MaPhieu bigint
)
AS
BEGIN
	SELECT
	dbo.ChiTietPhieu.IDChiTietPhieu, 
	dbo.ChiTietPhieu.MaHang, 
	dbo.ChiTietPhieu.MaKieuGiat, 
	dbo.ChiTietPhieu.Soluong, 
	dbo.ChiTietPhieu.DonGia,
	dbo.ChiTietPhieu.GhiChu,
	dbo.MatHang.TenHang, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM
	dbo.ChiTietPhieu INNER JOIN	dbo.MatHang ON dbo.ChiTietPhieu.MaHang = dbo.MatHang.MaHang 
	INNER JOIN dbo.KieuGiatLa ON dbo.ChiTietPhieu.MaKieuGiat = dbo.KieuGiatLa.MaKieuGiat
	WHERE dbo.ChiTietPhieu.MaPhieu = @MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuSlot_SelectByMaPhieu]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------
CREATE PROCEDURE [dbo].[sp_PhieuSlot_SelectByMaPhieu]
(
	@MaPhieu bigint
)
AS
BEGIN
	SELECT
	dbo.Phieu_Slot.*,
	dbo.MatHang.TenHang, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM 
	dbo.Phieu_Slot 
	INNER JOIN dbo.MatHang ON dbo.Phieu_Slot.MaHang = dbo.MatHang.MaHang 
	INNER JOIN dbo.KieuGiatLa ON dbo.Phieu_Slot.MaKieuGiat = dbo.KieuGiatLa.MaKieuGiat
	WHERE dbo.Phieu_Slot.MaPhieu=@MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuSlot_SelectByMavach]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------
CREATE PROCEDURE [dbo].[sp_PhieuSlot_SelectByMavach]
(
	@MaVach bigint = null
)
AS
BEGIN
	SELECT
	dbo.Phieu_Slot.*,
	dbo.MatHang.TenHang, 
	dbo.KieuGiatLa.TenKieuGiat
	FROM 
	dbo.Phieu_Slot 
	INNER JOIN dbo.MatHang ON dbo.Phieu_Slot.MaHang = dbo.MatHang.MaHang 
	INNER JOIN dbo.KieuGiatLa ON dbo.Phieu_Slot.MaKieuGiat = dbo.KieuGiatLa.MaKieuGiat
	WHERE dbo.Phieu_Slot.MaPhieu IN
	(
		SELECT dbo.Phieu_Slot.MaPhieu FROM dbo.Phieu_Slot WHERE dbo.Phieu_Slot.MaVach=@MaVach
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoaiHang_SelectAll]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoaiHang_SelectAll]
AS
BEGIN
	SELECT MaLoaiHang,TenLoaiHang FROM dbo.LoaiHang ORDER BY TenLoaiHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoaiHang_Insert]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoaiHang_Insert]
(
	@TenLoaiHang nvarchar(100)
)
AS
BEGIN
	INSERT INTO LoaiHang(TenLoaiHang) VALUES (@TenLoaiHang);
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoaiHang_Delete]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoaiHang_Delete]
(
	@MaLoaiHang int
)
AS
BEGIN
	DELETE dbo.LoaiHang WHERE MaLoaiHang = @MaLoaiHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoaiHang_Update]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoaiHang_Update]
(
	@MaLoaiHang int,
	@TenLoaiHang nvarchar(100) = null
)
AS
BEGIN
	UPDATE dbo.LoaiHang SET 
	TenLoaiHang = @TenLoaiHang
	WHERE MaLoaiHang = @MaLoaiHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Kho_Update]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Kho_Update]
(
	@MaKho int,
	@TenKho nvarchar(50),
	@GhiChu nvarchar(50) = null
)
AS
BEGIN
	UPDATE dbo.Kho SET 
	TenKho = @TenKho,
	GhiChu = @GhiChu
	WHERE MaKho = @MaKho;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Kho_Delete]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Kho_Delete]
(
	@MaKho int
)
AS
BEGIN
	DELETE dbo.Kho WHERE MaKho = @MaKho;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Kho_Insert]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Kho_Insert]
(
	@TenKho nvarchar(50),
	@GhiChu nvarchar(50) = null
)
AS
BEGIN
	INSERT INTO dbo.Kho(TenKho,GhiChu) VALUES (@TenKho,@GhiChu);
	SELECT SCOPE_IDENTITY();	
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Kho_SelectAll]    Script Date: 03/18/2019 23:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Kho_SelectAll]
AS
BEGIN
	SELECT 
	MaKho,
	TenKho,
	GhiChu,
	(SELECT COUNT(*) FROM dbo.Shelf WHERE dbo.Shelf.MaKho = dbo.Kho.MaKho) AS SoLuongSlot
	FROM dbo.Kho
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Update]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_Update]
(
	@MaKhachHang bigint,
	@TenKhachHang nvarchar(100) = null,
	@DiaChi nvarchar(200) = null,
	@DienThoai varchar(20) = null,
	@MaVip int = null,
	@SoTheVip varchar(20) = null
)
AS
BEGIN
	UPDATE KhachHang SET 
	TenKhachHang = @TenKhachHang,
	DiaChi = @DiaChi,
	DienThoai = @DienThoai,
	MaVip = @MaVip,
	SoTheVip = @SoTheVip
	WHERE MaKhachHang = @MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Delete]    Script Date: 03/18/2019 23:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_Delete]
(
	@MaKhachHang bigint
)
AS
BEGIN
	DELETE KhachHang WHERE MaKhachHang = @MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_SelectAll]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_SelectAll]
AS
BEGIN
	SELECT
	dbo.KhachHang.*,
	dbo.MucDoVip.TenVip 
	FROM dbo.KhachHang LEFT OUTER JOIN dbo.MucDoVip
	ON dbo.KhachHang.MaVip = dbo.MucDoVip.MaVip
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_SelectByMaKhachHang]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_SelectByMaKhachHang]
(
	@MaKhachHang bigint
)
AS
BEGIN
	SELECT 
	dbo.KhachHang.*,
	dbo.MucDoVip.TenVip,
	dbo.MucDoVip.GiamGia
	FROM dbo.KhachHang LEFT OUTER JOIN dbo.MucDoVip
	ON dbo.KhachHang.MaVip = dbo.MucDoVip.MaVip
	WHERE MaKhachHang = @MaKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_SelectByNgayLap]    Script Date: 03/18/2019 23:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------
CREATE PROCEDURE [dbo].[sp_Phieu_SelectByNgayLap]
(
	@TuNgay datetime,
	@DenNgay datetime
)
AS
BEGIN
	SELECT
	dbo.Phieu.*,
	dbo.KhachHang.TenKhachHang
	FROM dbo.Phieu
	LEFT OUTER JOIN dbo.KhachHang 
	ON dbo.Phieu.MaKhachHang = dbo.KhachHang.MaKhachHang
	WHERE
	datediff(day, @TuNgay, NgayLap) >= 0
	AND
	datediff(day, @DenNgay, NgayLap) <= 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_SearchNangCao]    Script Date: 03/18/2019 23:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------
CREATE PROCEDURE [dbo].[sp_Phieu_SearchNangCao]
(
	@tatca bit = null,
	@DaTraDo bit = null,
	@MaPhieu bigint = null,
	@DienThoai varchar(20) = null,
	@TenKhachHang nvarchar(100) = null,
	@tungay datetime = null,
	@denngay datetime = null
)
AS
BEGIN
	IF (@tatca is not null)
		BEGIN
			SELECT
			dbo.Phieu.*,
			dbo.KhachHang.TenKhachHang
			FROM dbo.Phieu LEFT OUTER JOIN dbo.KhachHang 
			ON dbo.Phieu.MaKhachHang = dbo.KhachHang.MaKhachHang
			--ORDER BY MaPhieu ASC;
		END
	ELSE
		BEGIN
			DECLARE @sql nvarchar(1100);
			SET @sql = 'SELECT
			dbo.Phieu.*,
			dbo.KhachHang.TenKhachHang
			FROM dbo.Phieu LEFT OUTER JOIN dbo.KhachHang 
			ON dbo.Phieu.MaKhachHang = dbo.KhachHang.MaKhachHang
			WHERE 1=1';
			IF (@DaTraDo IS NOT null)
				SET @sql = @sql + ' AND DaTraDo = ' + CAST(@DaTraDo AS VARCHAR);
			IF (@MaPhieu IS NOT null)
				SET @sql = @sql + ' AND MaPhieu = ' +  CAST(@MaPhieu AS VARCHAR);
			IF (@DienThoai IS NOT null)
				SET @sql = @sql + ' AND dbo.KhachHang.DienThoai like ''%' + @DienThoai + '%''';
			IF (@TenKhachHang IS NOT null)
				SET @sql = @sql + ' AND dbo.KhachHang.TenKhachHang like N''%' + @TenKhachHang + '%''';			
			IF (@tungay is not null)
				SET @sql = @sql + ' AND datediff(day, ''' + CAST(@tungay AS VARCHAR) + ''', dbo.Phieu.Ngaylap) >= 0';
			IF (@denngay is not null)
				SET @sql = @sql + ' AND datediff(day, ''' + CAST(@denngay AS VARCHAR) + ''', dbo.Phieu.Ngaylap) <= 0';
			--SET @sql = @sql + ' ORDER BY MaPhieu ASC'
			EXEC (@sql);
		END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_SelectBySoTheVip]    Script Date: 03/18/2019 23:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------
CREATE PROCEDURE [dbo].[sp_KhachHang_SelectBySoTheVip]
(
	@SoTheVip	varchar(20)
)
AS
BEGIN
	SELECT
	dbo.KhachHang.*,
	dbo.MucDoVip.TenVip,
	dbo.MucDoVip.GiamGia
	FROM dbo.KhachHang LEFT OUTER JOIN dbo.MucDoVip
	ON dbo.KhachHang.MaVip = dbo.MucDoVip.MaVip
	WHERE dbo.KhachHang.SoTheVip = @SoTheVip
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_SelectBy_TuPhieu_DenPhieu]    Script Date: 03/18/2019 23:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Phieu_SelectBy_TuPhieu_DenPhieu]
(
	@tuphieu bigint,
	@denphieu bigint
)
AS
BEGIN
	SELECT
	dbo.Phieu.*,
	dbo.KhachHang.TenKhachHang
	FROM dbo.Phieu
	LEFT OUTER JOIN dbo.KhachHang 
	ON dbo.Phieu.MaKhachHang = dbo.KhachHang.MaKhachHang
	WHERE
	dbo.Phieu.MaPhieu >= @tuphieu
	AND
	dbo.Phieu.MaPhieu <= @denphieu
	ORDER BY dbo.Phieu.MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_SelectByMaKieuGiat]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- select by ma kieu giat
CREATE PROCEDURE [dbo].[sp_MatHang_SelectByMaKieuGiat]
(
	@MaKieuGiat int
)
AS
BEGIN
	SELECT
	dbo.MatHang.MaHang, 
	dbo.MatHang.TenHang,
	dbo.MatHang.ImageStringFile
	FROM 
	dbo.MatHang INNER JOIN dbo.BangGia 
	ON dbo.MatHang.MaHang = dbo.BangGia.MaHang
	WHERE dbo.BangGia.MaKieuGiat = @MaKieuGiat
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_SelectAll]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_SelectAll]
AS
BEGIN
	SELECT 
	MaHang,
	MaLoaiHang,
	TenHang,
	ImageStringFile
	FROM dbo.MatHang
	ORDER BY TenHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Insert]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_Insert]
(
	@TenHang nvarchar(200),
	@MaLoaiHang int,	
	@ImageStringFile nvarchar(500) = null	
)
AS
BEGIN
	INSERT INTO dbo.MatHang(TenHang,MaLoaiHang,ImageStringFile)
	VALUES (@TenHang,@MaLoaiHang,@ImageStringFile);
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Update]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_Update]
(
	@MaHang int,
	@TenHang nvarchar(200),
	@MaLoaiHang int,
	@ImageStringFile nvarchar(500) = null
)
AS
BEGIN
	UPDATE dbo.MatHang SET 
	TenHang = @TenHang,
	MaLoaiHang = @MaLoaiHang,
	ImageStringFile = @ImageStringFile
	WHERE MaHang = @MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Delete]    Script Date: 03/18/2019 23:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_Delete]
(
	@MaHang int
)
AS
BEGIN
	DELETE dbo.MatHang WHERE MaHang = @MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieu_Insert]    Script Date: 03/18/2019 23:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieu_Insert]
(
	@MaPhieu bigint,
	@MaHang int,
	@MaKieuGiat int,
	@Soluong int,
	@DonGia bigint,
	@GhiChu nvarchar(50) = null
)
AS
BEGIN
	INSERT INTO dbo.ChiTietPhieu(
	MaPhieu,
	MaHang,
	MaKieuGiat,
	Soluong,	
	DonGia,
	GhiChu
	) VALUES (
	@MaPhieu,
	@MaHang,
	@MaKieuGiat,
	@Soluong,	
	@DonGia,
	@GhiChu);
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieu_Update]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieu_Update]
(
	@IDChiTietPhieu bigint,
	@MaHang int,
	@MaKieuGiat int,
	@Soluong int,	
	@DonGia bigint,
	@GhiChu nvarchar(50) = null
)
AS
BEGIN
	UPDATE dbo.ChiTietPhieu SET
	MaHang = @MaHang,
	MaKieuGiat = @MaKieuGiat,
	Soluong = @Soluong,
	DonGia = @DonGia,
	GhiChu = @GhiChu
	WHERE IDChiTietPhieu = @IDChiTietPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BangGia_CheckExist]    Script Date: 03/18/2019 23:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BangGia_CheckExist]
(
	@IDGia int = null,
	@MaHang int,
	@MaKieuGiat int
)
AS
BEGIN
	IF (@IDGia IS NOT null)
		SELECT count(*) FROM dbo.BangGia WHERE MaHang = @MaHang AND MaKieuGiat = @MaKieuGiat AND IDGia <> @IDGia;
	ELSE
		SELECT count(*) FROM dbo.BangGia WHERE MaHang = @MaHang AND MaKieuGiat = @MaKieuGiat;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BangGia_Insert]    Script Date: 03/18/2019 23:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BangGia_Insert]
(
	@MaHang int,
	@MaKieuGiat int,
	@DonGia bigint,
	@SoSanPham tinyint
)
AS
BEGIN
	INSERT INTO dbo.BangGia(MaHang,MaKieuGiat,DonGia, SoSanPham)
	VALUES (@MaHang,@MaKieuGiat,@DonGia, @SoSanPham);
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BangGia_Delete]    Script Date: 03/18/2019 23:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BangGia_Delete]
(
	@IDGia int
)
AS
BEGIN
	DELETE dbo.BangGia WHERE IDGia = @IDGia
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BangGia_Update]    Script Date: 03/18/2019 23:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BangGia_Update]
(
	@IDGia int,
	@MaHang int,
	@MaKieuGiat int,
	@DonGia bigint,
	@SoSanPham tinyint
)
AS
BEGIN
	UPDATE dbo.BangGia SET 
	MaHang = @MaHang,
	MaKieuGiat = @MaKieuGiat,
	DonGia = @DonGia,
	SoSanPham = @SoSanPham
	WHERE IDGia = @IDGia
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Shelf_SelectByMaKho]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Shelf_SelectByMaKho]
(
	@MaKho int
)
AS
BEGIN
	SELECT Slot,MaCacPhieuDangSuDung FROM dbo.Shelf WHERE MaKho = @MaKho
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Shelf_IsExist]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Shelf_IsExist]
(
	@MaKho int,
	@Slot int
)
AS
BEGIN
	SELECT MaCacPhieuDangSuDung FROM dbo.Shelf WHERE MaKho = @MaKho AND Slot = @Slot
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Shelf_Insert]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Shelf_Insert]
(
	@MaKho int,
	@Slot int
)
AS
BEGIN
	INSERT INTO dbo.Shelf(MaKho,Slot) VALUES (@MaKho,@Slot);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Shelf_DeleteBigger]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Shelf_DeleteBigger]
(
	@MaKho int,
	@Slot int
)
AS
BEGIN
	DELETE dbo.Shelf WHERE MaKho = @MaKho AND Slot > @Slot;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Shelf_Update]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Shelf_Update]
(
	@MaKho int,
	@Slot int,
	@MaCacPhieuDangSuDung varchar(100) = null
)
AS
BEGIN
	UPDATE dbo.Shelf 
	SET MaCacPhieuDangSuDung = @MaCacPhieuDangSuDung
	WHERE MaKho = @MaKho AND Slot = @Slot;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_SelectByMaPhieu]    Script Date: 03/18/2019 23:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------
CREATE PROCEDURE [dbo].[sp_Phieu_SelectByMaPhieu]
(
	@MaPhieu bigint
)
AS
BEGIN
	SELECT
	*
	FROM dbo.Phieu 
	WHERE MaPhieu = @MaPhieu;	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_Insert]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------
CREATE PROCEDURE [dbo].[sp_Phieu_Insert]
(
	@MaKhachHang bigint = null,
	@GhiChu nvarchar(200) = null,
	@UserName varchar(50) = null,
	@NgayLap datetime,
	@NgayHenTra datetime,
	@GiamGia bigint,
	@DaThanhToan bit,
	@TongTien bigint,
	@PhiGiaoNhan int = NULL
)
AS
BEGIN
	INSERT INTO dbo.Phieu(MaKhachHang,NgayLap,NgayHenTra,GiamGia,DaTraDo,GhiChu,DaThanhToan,UserName,TongTien,PhiGiaoNhan)
	VALUES (@MaKhachHang,@NgayLap,@NgayHenTra,@GiamGia,0,@GhiChu,@DaThanhToan,@UserName,@TongTien,@PhiGiaoNhan);
	SELECT SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_SelectByMaxMaPhieu]    Script Date: 03/18/2019 23:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Phieu_SelectByMaxMaPhieu]
AS
BEGIN
	SELECT max(MaPhieu)	FROM dbo.Phieu;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_SelectTongTienByMaPhieu]    Script Date: 03/18/2019 23:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Phieu_SelectTongTienByMaPhieu]
(
	@TuPhieu bigint,
	@DenPhieu bigint
)
AS
BEGIN
	SELECT SUM (TongTien) FROM dbo.Phieu
	WHERE
	MaPhieu >= @TuPhieu
	AND
	MaPhieu <= @DenPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_UpdateSoLanIn]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------
CREATE PROCEDURE [dbo].[sp_Phieu_UpdateSoLanIn]
(
	@MaPhieu bigint,
	@SoLanIn int
)
AS
BEGIN
	UPDATE dbo.Phieu SET
	SoLanIn=@SoLanIn
	WHERE MaPhieu = @MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Phieu_UpdateDaTraDo]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------
CREATE PROCEDURE [dbo].[sp_Phieu_UpdateDaTraDo]
(
	@MaPhieu bigint,
	@DaTraDo bit
)
AS
BEGIN
	UPDATE dbo.Phieu SET
	DaTraDo=@DaTraDo,
	DaThanhToan=1
	WHERE MaPhieu = @MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DotGiamGia_Insert]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DotGiamGia_Insert]
(
	@TenDotGiamGia nvarchar(200) = null,
    @TuNgay datetime,
    @DenNgay datetime,
    @GiamGia int
)
AS
BEGIN
	INSERT INTO DotGiamGia
           (TenDotGiamGia
           ,TuNgay
           ,DenNgay
           ,GiamGia)
     VALUES
           (@TenDotGiamGia
           ,@TuNgay
           ,@DenNgay
           ,@GiamGia)
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DotGiamGia_Update]    Script Date: 03/18/2019 23:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DotGiamGia_Update]
(
	@MaDotGiamGia int,
	@TenDotGiamGia nvarchar(200) = null,
	@TuNgay datetime,
    @DenNgay datetime,
    @GiamGia int
)
AS
BEGIN
	UPDATE DotGiamGia
	SET	TenDotGiamGia = @TenDotGiamGia,
		TuNgay = @TuNgay,
		DenNgay = @DenNgay,
		GiamGia = @GiamGia
	WHERE MaDotGiamGia = @MaDotGiamGia
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DotGiamGia_Delete]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DotGiamGia_Delete]
(
	@MaDotGiamGia int
)
AS
BEGIN
	DELETE FROM DotGiamGia WHERE MaDotGiamGia = @MaDotGiamGia
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DotGiamGia_SelectAll]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DotGiamGia_SelectAll]
AS
BEGIN
	SELECT MaDotGiamGia
      ,TenDotGiamGia
      ,TuNgay
      ,DenNgay
      ,GiamGia
	FROM DotGiamGia
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DotGiamGia_SelectByNgay]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DotGiamGia_SelectByNgay]
(
	@ngay datetime
)
AS
BEGIN
	SELECT MaDotGiamGia
		,TenDotGiamGia
		,TuNgay
		,DenNgay
		,GiamGia
	FROM DotGiamGia
	WHERE
	datediff(day, TuNgay, @ngay) >= 0 
	AND
	datediff(day, DenNgay, @ngay) <= 0;		
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuSlot_DeleteByMaPhieu]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuSlot_DeleteByMaPhieu]
(
	@MaPhieu bigint
)
AS
BEGIN
	DELETE FROM Phieu_Slot WHERE MaPhieu=@MaPhieu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuSlot_SelectByKhoSlot]    Script Date: 03/18/2019 23:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuSlot_SelectByKhoSlot]
(
	@Kho nvarchar(50),
	@Slot int
)
AS
BEGIN
	SELECT DISTINCT
	MaPhieu
	FROM 
	dbo.Phieu_Slot
	WHERE Kho = @Kho AND Slot = @Slot AND DaTra = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MucDoVip_Delete]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MucDoVip_Delete]
(
	@MaVip int
)
AS
BEGIN
	DELETE dbo.MucDoVip WHERE MaVip = @MaVip
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MucDoVip_Insert]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MucDoVip_Insert]
(
	@TenVip nvarchar(50),
	@GiamGia int
)
AS
BEGIN
	INSERT INTO dbo.MucDoVip(TenVip,GiamGia) VALUES (@TenVip,@GiamGia);
	SELECT SCOPE_IDENTITY();	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MucDoVip_SelectAll]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MucDoVip_SelectAll]
AS
BEGIN
	SELECT MaVip,TenVip,GiamGia	FROM dbo.MucDoVip
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MucDoVip_Update]    Script Date: 03/18/2019 23:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MucDoVip_Update]
(
	@MaVip int,
	@TenVip nvarchar(50),
	@GiamGia int
)
AS
BEGIN
	UPDATE dbo.MucDoVip SET 
	TenVip = @TenVip,
	GiamGia = @GiamGia
	WHERE MaVip = @MaVip
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Information_Update_PhieuChotKetGanNhat]    Script Date: 03/18/2019 23:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
creATE PROCEDURE [dbo].[sp_Information_Update_PhieuChotKetGanNhat]
(
	@PhieuChotKetGanNhat bigint
)
AS
BEGIN
	UPDATE Information SET PhieuChotKetGanNhat = @PhieuChotKetGanNhat;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Information_Select]    Script Date: 03/18/2019 23:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Information_Select]
AS
BEGIN
	SELECT * FROM Information
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChotKet_Insert]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------
CREATE PROCEDURE [dbo].[sp_ChotKet_Insert]
(
	@ThoiDiemChot datetime = NULL,
	@TuPhieu bigint = NULL,
	@DenPhieu bigint = NULL,
	@SoTienChot bigint = NULL,
	@NguoiChot varchar(50) = NULL,
	@GhiChu nvarchar(200) = NULL
)
AS
BEGIN
	INSERT ChotKet(ThoiDiemChot, TuPhieu, DenPhieu, SoTienChot, NguoiChot, GhiChu)
	VALUES (@ThoiDiemChot, @TuPhieu, @DenPhieu, @SoTienChot, @NguoiChot, @GhiChu);
	SELECT SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChotKet_Select]    Script Date: 03/18/2019 23:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------
CREATE PROCEDURE [dbo].[sp_ChotKet_Select]
(
	@tungay datetime = null,
	@denngay datetime = null
)
AS
BEGIN
	IF (@tungay IS NOT null AND @denngay IS NOT null)
		BEGIN
			SELECT
			*
			FROM ChotKet
			WHERE
			datediff(day, ThoiDiemChot, @tungay) >= 0
			AND
			datediff(day, ThoiDiemChot, @denngay) <= 0
		END
	ELSE
		BEGIN
			SELECT
			*
			FROM ChotKet
		END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_User_SelectAll]    Script Date: 03/18/2019 23:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_User_SelectAll]
AS
BEGIN
	SELECT UserName,PassWord,Quyen,HoTen,QuyenHan FROM dbo.[User]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_User_SelectByUserName]    Script Date: 03/18/2019 23:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_User_SelectByUserName]
(
	@UserName varchar(50)
)
AS
BEGIN
	SELECT PassWord,Quyen,HoTen,QuyenHan FROM dbo.[User] WHERE UserName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[sp_User_Delete]    Script Date: 03/18/2019 23:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_User_Delete]
(
	@UserName varchar(50)
)
AS
BEGIN
	DELETE dbo.[User] WHERE UserName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[sp_User_Insert]    Script Date: 03/18/2019 23:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_User_Insert]
(
	@UserName varchar(50),
	@PassWord varchar(50),
	@Quyen tinyint,
	@HoTen nvarchar(50),
	@QuyenHan varchar(30)
)
AS
BEGIN
	INSERT INTO dbo.[User](
	UserName,
	PassWord,
	Quyen,
	HoTen,
	QuyenHan
	) VALUES (
	@UserName,
	@PassWord,
	@Quyen,
	@HoTen,
	@QuyenHan
	);	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_User_Update]    Script Date: 03/18/2019 23:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_User_Update]
(
	@UserName varchar(50),
	@PassWord varchar(50),
	@Quyen tinyint,
	@HoTen nvarchar(50),
	@QuyenHan varchar(30)
)
AS
BEGIN
	UPDATE dbo.[User] SET
	PassWord = @PassWord,
	Quyen = @Quyen,
	HoTen = @HoTen,
	QuyenHan = @QuyenHan
	WHERE UserName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[sp_User_ChangePass]    Script Date: 03/18/2019 23:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_User_ChangePass]
(
	@UserName varchar(50),
	@PassWord varchar(50)
)
AS
BEGIN
	UPDATE dbo.[User] SET
	PassWord = @PassWord
	WHERE UserName = @UserName
END
GO
/****** Object:  ForeignKey [FK_BangGia_KieuGiatLa]    Script Date: 03/18/2019 23:32:51 ******/
ALTER TABLE [dbo].[BangGia]  WITH CHECK ADD  CONSTRAINT [FK_BangGia_KieuGiatLa] FOREIGN KEY([MaKieuGiat])
REFERENCES [dbo].[KieuGiatLa] ([MaKieuGiat])
GO
ALTER TABLE [dbo].[BangGia] CHECK CONSTRAINT [FK_BangGia_KieuGiatLa]
GO
/****** Object:  ForeignKey [FK_BangGia_MatHang]    Script Date: 03/18/2019 23:32:51 ******/
ALTER TABLE [dbo].[BangGia]  WITH CHECK ADD  CONSTRAINT [FK_BangGia_MatHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[BangGia] CHECK CONSTRAINT [FK_BangGia_MatHang]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieu_KieuGiatLa]    Script Date: 03/18/2019 23:32:53 ******/
ALTER TABLE [dbo].[ChiTietPhieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieu_KieuGiatLa] FOREIGN KEY([MaKieuGiat])
REFERENCES [dbo].[KieuGiatLa] ([MaKieuGiat])
GO
ALTER TABLE [dbo].[ChiTietPhieu] CHECK CONSTRAINT [FK_ChiTietPhieu_KieuGiatLa]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieu_MatHang]    Script Date: 03/18/2019 23:32:53 ******/
ALTER TABLE [dbo].[ChiTietPhieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieu_MatHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[ChiTietPhieu] CHECK CONSTRAINT [FK_ChiTietPhieu_MatHang]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieu_Phieu]    Script Date: 03/18/2019 23:32:53 ******/
ALTER TABLE [dbo].[ChiTietPhieu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieu_Phieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[ChiTietPhieu] CHECK CONSTRAINT [FK_ChiTietPhieu_Phieu]
GO
/****** Object:  ForeignKey [FK_KhachHang_MucDoVip]    Script Date: 03/18/2019 23:32:56 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_MucDoVip] FOREIGN KEY([MaVip])
REFERENCES [dbo].[MucDoVip] ([MaVip])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_MucDoVip]
GO
/****** Object:  ForeignKey [FK_MatHang_LoaiHang]    Script Date: 03/18/2019 23:32:59 ******/
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_LoaiHang] FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LoaiHang] ([MaLoaiHang])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_LoaiHang]
GO
/****** Object:  ForeignKey [FK_Phieu_KhachHang]    Script Date: 03/18/2019 23:33:01 ******/
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_KhachHang]
GO
/****** Object:  ForeignKey [FK_Phieu_Slot_MatHang]    Script Date: 03/18/2019 23:33:03 ******/
ALTER TABLE [dbo].[Phieu_Slot]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_Slot_MatHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[Phieu_Slot] CHECK CONSTRAINT [FK_Phieu_Slot_MatHang]
GO
/****** Object:  ForeignKey [FK_Phieu_Slot_Phieu]    Script Date: 03/18/2019 23:33:03 ******/
ALTER TABLE [dbo].[Phieu_Slot]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_Slot_Phieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[Phieu_Slot] CHECK CONSTRAINT [FK_Phieu_Slot_Phieu]
GO
/****** Object:  ForeignKey [FK_Phieu_Slot_DaTra_MatHang]    Script Date: 03/18/2019 23:33:05 ******/
ALTER TABLE [dbo].[Phieu_Slot_DaTra]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_Slot_DaTra_MatHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[Phieu_Slot_DaTra] CHECK CONSTRAINT [FK_Phieu_Slot_DaTra_MatHang]
GO
/****** Object:  ForeignKey [FK_Phieu_Slot_DaTra_Phieu]    Script Date: 03/18/2019 23:33:05 ******/
ALTER TABLE [dbo].[Phieu_Slot_DaTra]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_Slot_DaTra_Phieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[Phieu_Slot_DaTra] CHECK CONSTRAINT [FK_Phieu_Slot_DaTra_Phieu]
GO
/****** Object:  ForeignKey [FK_Shelf_Kho]    Script Date: 03/18/2019 23:33:06 ******/
ALTER TABLE [dbo].[Shelf]  WITH CHECK ADD  CONSTRAINT [FK_Shelf_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Shelf] CHECK CONSTRAINT [FK_Shelf_Kho]
GO
