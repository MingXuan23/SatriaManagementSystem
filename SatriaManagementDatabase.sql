USE [master]
GO
/****** Object:  Database [SatriaManagementDatabase]    Script Date: 13/05/2023 21:41:50 ******/
CREATE DATABASE [SatriaManagementDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SatriaManagementDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SatriaManagementDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SatriaManagementDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SatriaManagementDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SatriaManagementDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SatriaManagementDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SatriaManagementDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SatriaManagementDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SatriaManagementDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SatriaManagementDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SatriaManagementDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SatriaManagementDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [SatriaManagementDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SatriaManagementDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SatriaManagementDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SatriaManagementDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SatriaManagementDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SatriaManagementDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SatriaManagementDatabase] SET QUERY_STORE = OFF
GO
USE [SatriaManagementDatabase]
GO
/****** Object:  Table [dbo].[Blocks]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blocks](
	[ID] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Asset] [decimal](18, 0) NOT NULL,
	[Capacity] [bigint] NOT NULL,
	[Gender] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Blocks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[ID] [bigint] NOT NULL,
	[BlockID] [bigint] NOT NULL,
	[RoomNo] [varchar](50) NOT NULL,
	[LevelNum] [bigint] NOT NULL,
	[RoomFees] [decimal](18, 0) NOT NULL,
	[MaxCapacity] [bigint] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [bigint] NOT NULL,
	[BlockID] [bigint] NULL,
	[Salary] [decimal](18, 0) NOT NULL,
	[SuperAdmin] [bit] NOT NULL,
	[DateStartWork] [datetime] NOT NULL,
 CONSTRAINT [PK_Users_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Transaction]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Transaction](
	[ID] [bigint] NOT NULL,
	[StaffID] [bigint] NOT NULL,
	[TransactionID] [bigint] NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Staff_Transaction] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [bigint] NOT NULL,
	[MatircNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Room]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Room](
	[ID] [bigint] NOT NULL,
	[StudentID] [bigint] NOT NULL,
	[RoomID] [bigint] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[TransactionID] [bigint] NULL,
 CONSTRAINT [PK_Student_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[ID] [bigint] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Withdrawal] [bit] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [bigint] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[PhoneNum] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[UserTypeID] [bigint] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTypes]    Script Date: 13/05/2023 21:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTypes](
	[ID] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Blocks] ([ID], [Name], [Asset], [Capacity], [Gender], [Status]) VALUES (1, N'Kasturi', CAST(0 AS Decimal(18, 0)), 15, 1, 1)
INSERT [dbo].[Blocks] ([ID], [Name], [Asset], [Capacity], [Gender], [Status]) VALUES (2, N'Lekir', CAST(0 AS Decimal(18, 0)), 15, 0, 1)
INSERT [dbo].[Blocks] ([ID], [Name], [Asset], [Capacity], [Gender], [Status]) VALUES (3, N'Lekiu ', CAST(0 AS Decimal(18, 0)), 15, 0, 1)
GO
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (1, 1, N'Kasturi-1-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (2, 1, N'Kasturi-2-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (3, 1, N'Kasturi-3-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (4, 1, N'Kasturi-1-2', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (5, 1, N'Kasturi-2-2', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (6, 1, N'Kasturi-3-2', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (7, 1, N'Kasturi-1-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (8, 1, N'Kasturi-2-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (9, 1, N'Kasturi-3-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (10, 1, N'Kasturi-1-4', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (11, 1, N'Kasturi-2-4', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (12, 1, N'Kasturi-3-4', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (13, 1, N'Kasturi-1-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (14, 1, N'Kasturi-2-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (15, 1, N'Kasturi-3-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (16, 2, N'Lekir-1-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (17, 2, N'Lekir-2-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (18, 2, N'Lekir-3-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (19, 2, N'Lekir-1-2', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (20, 2, N'Lekir-2-2', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (21, 2, N'Lekir-3-2', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (22, 2, N'Lekir-1-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (23, 2, N'Lekir-2-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (24, 2, N'Lekir-3-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (25, 2, N'Lekir-1-4', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (26, 2, N'Lekir-2-4', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (27, 2, N'Lekir-3-4', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (28, 2, N'Lekir-1-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (29, 2, N'Lekir-2-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (30, 2, N'Lekir-3-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (31, 3, N'Lekiu -1-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (32, 3, N'Lekiu -2-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (33, 3, N'Lekiu -3-1', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (34, 3, N'Lekiu -1-2', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (35, 3, N'Lekiu -2-2', 1, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (36, 3, N'Lekiu -3-2', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (37, 3, N'Lekiu -1-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (38, 3, N'Lekiu -2-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (39, 3, N'Lekiu -3-3', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (40, 3, N'Lekiu -1-4', 2, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (41, 3, N'Lekiu -2-4', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (42, 3, N'Lekiu -3-4', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (43, 3, N'Lekiu -1-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (44, 3, N'Lekiu -2-5', 3, CAST(200 AS Decimal(18, 0)), 2)
INSERT [dbo].[Rooms] ([ID], [BlockID], [RoomNo], [LevelNum], [RoomFees], [MaxCapacity]) VALUES (45, 3, N'Lekiu -3-5', 3, CAST(200 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[Staff] ([StaffID], [BlockID], [Salary], [SuperAdmin], [DateStartWork]) VALUES (1, NULL, CAST(2000 AS Decimal(18, 0)), 1, CAST(N'2023-05-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Users] ([ID], [Username], [FullName], [Password], [PhoneNum], [Email], [Gender], [UserTypeID], [Status]) VALUES (1, N'Mingxuan', N'Mingxuan', N'abc123', N'123456789', N'helloWorld@gmail.com', 1, 3, 1)
GO
INSERT [dbo].[UserTypes] ([ID], [Name]) VALUES (1, N'Student')
INSERT [dbo].[UserTypes] ([ID], [Name]) VALUES (2, N'Staff')
INSERT [dbo].[UserTypes] ([ID], [Name]) VALUES (3, N'SuperAdmin')
GO
/****** Object:  Index [IX_FK_Room_Block]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Room_Block] ON [dbo].[Rooms]
(
	[BlockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Staff_Block]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Staff_Block] ON [dbo].[Staff]
(
	[BlockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Staff_User]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Staff_User] ON [dbo].[Staff]
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Staff_Transaction_Transaction]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Staff_Transaction_Transaction] ON [dbo].[Staff_Transaction]
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Staff_Transaction_User]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Staff_Transaction_User] ON [dbo].[Staff_Transaction]
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Student_User]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Student_User] ON [dbo].[Student]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Student_Room_Room]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Student_Room_Room] ON [dbo].[Student_Room]
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Student_Room_Student]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Student_Room_Student] ON [dbo].[Student_Room]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Student_Room_Transaction]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Student_Room_Transaction] ON [dbo].[Student_Room]
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_User_UserType]    Script Date: 13/05/2023 21:41:51 ******/
CREATE NONCLUSTERED INDEX [IX_FK_User_UserType] ON [dbo].[Users]
(
	[UserTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Room_Block] FOREIGN KEY([BlockID])
REFERENCES [dbo].[Blocks] ([ID])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Room_Block]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Block] FOREIGN KEY([BlockID])
REFERENCES [dbo].[Blocks] ([ID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Block]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_User] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_User]
GO
ALTER TABLE [dbo].[Staff_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Transaction_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Staff_Transaction] CHECK CONSTRAINT [FK_Staff_Transaction_Staff]
GO
ALTER TABLE [dbo].[Staff_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Transaction_Transaction] FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([ID])
GO
ALTER TABLE [dbo].[Staff_Transaction] CHECK CONSTRAINT [FK_Staff_Transaction_Transaction]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Users] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Users]
GO
ALTER TABLE [dbo].[Student_Room]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Rooms] ([ID])
GO
ALTER TABLE [dbo].[Student_Room] CHECK CONSTRAINT [FK_Student_Room_Room]
GO
ALTER TABLE [dbo].[Student_Room]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[Student_Room] CHECK CONSTRAINT [FK_Student_Room_Student]
GO
ALTER TABLE [dbo].[Student_Room]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room_Transaction] FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([ID])
GO
ALTER TABLE [dbo].[Student_Room] CHECK CONSTRAINT [FK_Student_Room_Transaction]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_UserType] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[UserTypes] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_UserType]
GO
USE [master]
GO
ALTER DATABASE [SatriaManagementDatabase] SET  READ_WRITE 
GO
