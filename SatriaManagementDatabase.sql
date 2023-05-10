USE [master]
GO
/****** Object:  Database [SatriaManagementDatabase]    Script Date: 10/05/2023 19:45:53 ******/
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
/****** Object:  Table [dbo].[Block]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Block](
	[ID] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Asset] [decimal](18, 0) NOT NULL,
	[Capacity] [bigint] NOT NULL,
	[Gender] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Block] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [bigint] NOT NULL,
	[BlockID] [bigint] NOT NULL,
	[RoomNo] [varchar](50) NOT NULL,
	[LevelNum] [bigint] NOT NULL,
	[RoomFees] [decimal](18, 0) NOT NULL,
	[MaxCapacity] [bigint] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Transaction]    Script Date: 10/05/2023 19:45:53 ******/
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
/****** Object:  Table [dbo].[StaffUser]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffUser](
	[ID] [bigint] NOT NULL,
	[StaffID] [bigint] NOT NULL,
	[BlockID] [bigint] NULL,
	[Salary] [decimal](18, 0) NOT NULL,
	[SuperAdmin] [bit] NULL,
	[DateStartWork] [date] NOT NULL,
 CONSTRAINT [PK_Staff_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Room]    Script Date: 10/05/2023 19:45:53 ******/
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
/****** Object:  Table [dbo].[StudentUser]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentUser](
	[ID] [bigint] NOT NULL,
	[StudentID] [bigint] NOT NULL,
	[MatircNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Student_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[ID] [bigint] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TransactionDate] [date] NOT NULL,
	[Withdrawal] [bit] NOT NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [bigint] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[PhoneNum] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[UserTypeID] [bigint] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 10/05/2023 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[ID] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Block] ([ID], [Name], [Asset], [Capacity], [Gender], [Status]) VALUES (1, N'Kasturi', CAST(0 AS Decimal(18, 0)), 20, 1, 1)
INSERT [dbo].[Block] ([ID], [Name], [Asset], [Capacity], [Gender], [Status]) VALUES (2, N'Lekir', CAST(0 AS Decimal(18, 0)), 20, 0, 1)
GO
INSERT [dbo].[UserType] ([ID], [Name]) VALUES (1, N'Student')
INSERT [dbo].[UserType] ([ID], [Name]) VALUES (2, N'Staff')
INSERT [dbo].[UserType] ([ID], [Name]) VALUES (3, N'SuperAdmin')
GO
/****** Object:  Index [IX_Room]    Script Date: 10/05/2023 19:45:53 ******/
CREATE NONCLUSTERED INDEX [IX_Room] ON [dbo].[Room]
(
	[BlockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Staff]    Script Date: 10/05/2023 19:45:53 ******/
ALTER TABLE [dbo].[StaffUser] ADD  CONSTRAINT [IX_Staff] UNIQUE NONCLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Student_Room]    Script Date: 10/05/2023 19:45:53 ******/
ALTER TABLE [dbo].[Student_Room] ADD  CONSTRAINT [IX_Student_Room] UNIQUE NONCLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Student_Room_1]    Script Date: 10/05/2023 19:45:53 ******/
ALTER TABLE [dbo].[Student_Room] ADD  CONSTRAINT [IX_Student_Room_1] UNIQUE NONCLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Student_1]    Script Date: 10/05/2023 19:45:53 ******/
ALTER TABLE [dbo].[StudentUser] ADD  CONSTRAINT [IX_Student_1] UNIQUE NONCLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Student]    Script Date: 10/05/2023 19:45:53 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Student] ON [dbo].[StudentUser]
(
	[MatircNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User]    Script Date: 10/05/2023 19:45:53 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_User] ON [dbo].[User]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Block] FOREIGN KEY([BlockID])
REFERENCES [dbo].[Block] ([ID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Block]
GO
ALTER TABLE [dbo].[Staff_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Transaction_Transaction] FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transaction] ([ID])
GO
ALTER TABLE [dbo].[Staff_Transaction] CHECK CONSTRAINT [FK_Staff_Transaction_Transaction]
GO
ALTER TABLE [dbo].[Staff_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Transaction_User] FOREIGN KEY([StaffID])
REFERENCES [dbo].[StaffUser] ([StaffID])
GO
ALTER TABLE [dbo].[Staff_Transaction] CHECK CONSTRAINT [FK_Staff_Transaction_User]
GO
ALTER TABLE [dbo].[StaffUser]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Block] FOREIGN KEY([BlockID])
REFERENCES [dbo].[Block] ([ID])
GO
ALTER TABLE [dbo].[StaffUser] CHECK CONSTRAINT [FK_Staff_Block]
GO
ALTER TABLE [dbo].[StaffUser]  WITH CHECK ADD  CONSTRAINT [FK_Staff_User] FOREIGN KEY([StaffID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[StaffUser] CHECK CONSTRAINT [FK_Staff_User]
GO
ALTER TABLE [dbo].[Student_Room]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[Student_Room] CHECK CONSTRAINT [FK_Student_Room_Room]
GO
ALTER TABLE [dbo].[Student_Room]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[StudentUser] ([StudentID])
GO
ALTER TABLE [dbo].[Student_Room] CHECK CONSTRAINT [FK_Student_Room_Student]
GO
ALTER TABLE [dbo].[Student_Room]  WITH CHECK ADD  CONSTRAINT [FK_Student_Room_Transaction] FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transaction] ([ID])
GO
ALTER TABLE [dbo].[Student_Room] CHECK CONSTRAINT [FK_Student_Room_Transaction]
GO
ALTER TABLE [dbo].[StudentUser]  WITH CHECK ADD  CONSTRAINT [FK_Student_User] FOREIGN KEY([StudentID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[StudentUser] CHECK CONSTRAINT [FK_Student_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserType] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[UserType] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserType]
GO
USE [master]
GO
ALTER DATABASE [SatriaManagementDatabase] SET  READ_WRITE 
GO
