USE [master]
GO
/****** Object:  Database [Web]    Script Date: 26-May-20 10:42:52 PM ******/
CREATE DATABASE [Web]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Web', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Web.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Web_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Web_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Web] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Web].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Web] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Web] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Web] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Web] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Web] SET ARITHABORT OFF 
GO
ALTER DATABASE [Web] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Web] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Web] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Web] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Web] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Web] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Web] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Web] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Web] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Web] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Web] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Web] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Web] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Web] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Web] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Web] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Web] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Web] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Web] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Web] SET  MULTI_USER 
GO
ALTER DATABASE [Web] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Web] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Web] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Web] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Web]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 26-May-20 10:42:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](10) NULL,
	[password] [varchar](10) NULL,
	[displayname] [nvarchar](10) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[category]    Script Date: 26-May-20 10:42:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Logo]    Script Date: 26-May-20 10:42:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](50) NULL,
	[SourceName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Logo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinTuc]    Script Date: 26-May-20 10:42:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TinTuc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[description] [nvarchar](50) NULL,
	[dateup] [date] NULL,
	[topList] [bit] NULL,
	[Imagedemo] [nvarchar](50) NULL,
	[Link] [varchar](50) NULL,
	[IDlogo] [int] NULL,
	[IDcategory] [int] NULL,
 CONSTRAINT [PK_TinTuc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID], [userName], [password], [displayname]) VALUES (2, N'danh', N'123', N'danh')
INSERT [dbo].[Account] ([ID], [userName], [password], [displayname]) VALUES (3, N'nam', N'123', N'namngu')
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([ID], [CategoryName]) VALUES (2, N'Bóng Đá')
INSERT [dbo].[category] ([ID], [CategoryName]) VALUES (9, N'VietLot')
INSERT [dbo].[category] ([ID], [CategoryName]) VALUES (10, N'THời trang')
INSERT [dbo].[category] ([ID], [CategoryName]) VALUES (11, N'Bài Bạc')
SET IDENTITY_INSERT [dbo].[category] OFF
SET IDENTITY_INSERT [dbo].[Logo] ON 

INSERT [dbo].[Logo] ([ID], [Image], [SourceName]) VALUES (6, N'jdas', N'24h')
INSERT [dbo].[Logo] ([ID], [Image], [SourceName]) VALUES (7, N'áda', N'Bongda')
INSERT [dbo].[Logo] ([ID], [Image], [SourceName]) VALUES (8, N'ádas', N'Zingnews')
INSERT [dbo].[Logo] ([ID], [Image], [SourceName]) VALUES (9, N'ewq', N'Hutech')
SET IDENTITY_INSERT [dbo].[Logo] OFF
SET IDENTITY_INSERT [dbo].[TinTuc] ON 

INSERT [dbo].[TinTuc] ([ID], [title], [description], [dateup], [topList], [Imagedemo], [Link], [IDlogo], [IDcategory]) VALUES (4, N'akqw', N'helo', CAST(0x9A220B00 AS Date), 1, N'sada', N'dsdv', 7, 9)
INSERT [dbo].[TinTuc] ([ID], [title], [description], [dateup], [topList], [Imagedemo], [Link], [IDlogo], [IDcategory]) VALUES (5, N'yayaa', N'huhu', CAST(0xAF230B00 AS Date), 0, N'uaaa', N'qwr', 8, 10)
INSERT [dbo].[TinTuc] ([ID], [title], [description], [dateup], [topList], [Imagedemo], [Link], [IDlogo], [IDcategory]) VALUES (6, N'Linkka', N'Hôm nay linh đói quá', NULL, NULL, NULL, N'http://', 6, 11)
SET IDENTITY_INSERT [dbo].[TinTuc] OFF
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD  CONSTRAINT [FK_TinTuc_category] FOREIGN KEY([IDcategory])
REFERENCES [dbo].[category] ([ID])
GO
ALTER TABLE [dbo].[TinTuc] CHECK CONSTRAINT [FK_TinTuc_category]
GO
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD  CONSTRAINT [FK_TinTuc_Logo] FOREIGN KEY([IDlogo])
REFERENCES [dbo].[Logo] ([ID])
GO
ALTER TABLE [dbo].[TinTuc] CHECK CONSTRAINT [FK_TinTuc_Logo]
GO
USE [master]
GO
ALTER DATABASE [Web] SET  READ_WRITE 
GO
