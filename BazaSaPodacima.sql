USE [test]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Name] [nvarchar](140) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Path] [nvarchar](250) NOT NULL,
	[Alt] [nvarchar](250) NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[ProductId] [int] NULL,
	[OrderId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[OrderStatus] [int] NOT NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UseCaseLogs]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UseCaseLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[UseCaseName] [nvarchar](max) NULL,
	[Data] [nvarchar](max) NULL,
	[Actor] [nvarchar](max) NULL,
 CONSTRAINT [PK_UseCaseLogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserUseCase]    Script Date: 7/2/2020 10:42:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserUseCase](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[UseCaseId] [int] NOT NULL,
 CONSTRAINT [PK_UserUseCase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200624025740_proba', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625010512_dodavanje_tabela', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625013558_izmena_tabela', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625023227_dodavanje_konfiguracije', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625030936_dodavanje-konfig', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200627170438_izmena_naziva_tabele_dodavanje_kolona', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200627170701_izmena_naziva_tabele_dodavanje_kolona2', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200630203025_Dodavanje_Uloga_koriscenja', N'3.1.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200702063407_DodavanjeUseCaseLogs', N'3.1.5')
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (1, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 0, N'Phone')
INSERT [dbo].[Categories] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (9, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 0, N'TV')
INSERT [dbo].[Categories] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (11, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 0, N'PC')
INSERT [dbo].[Categories] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (12, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-01T22:34:45.8936092' AS DateTime2), 0, NULL, 0, N'BelaTehnika')
INSERT [dbo].[Categories] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name]) VALUES (16, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 0, N'Bastenska oprema')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Path], [Alt], [ProductId]) VALUES (1, CAST(N'2020-07-02T08:21:53.5463251' AS DateTime2), NULL, 0, NULL, 1, N'386da61d-185d-4605-aeb4-15d535c794fe.jpg', N'Slika', 1)
INSERT [dbo].[Images] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Path], [Alt], [ProductId]) VALUES (2, CAST(N'2020-07-02T08:37:05.3021106' AS DateTime2), NULL, 0, NULL, 1, N'e243e05a-f73e-470a-a157-20b9427f23e9.png', N'Slika', 1)
INSERT [dbo].[Images] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Path], [Alt], [ProductId]) VALUES (3, CAST(N'2020-07-02T08:39:02.4713268' AS DateTime2), NULL, 0, NULL, 1, N'1b6ef4cb-8778-4f45-b348-870bd0e2209f.png', N'Slika', 1)
SET IDENTITY_INSERT [dbo].[Images] OFF
SET IDENTITY_INSERT [dbo].[OrderInfo] ON 

INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (1, CAST(N'2020-07-02T00:39:45.7754820' AS DateTime2), NULL, 0, NULL, 1, 1, 1, 2, N'Tessttsdds', CAST(1212.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (2, CAST(N'2020-07-02T10:18:58.4278925' AS DateTime2), NULL, 0, NULL, 1, 22, 2, 2, N'Mašina za pranje veša 7 kg/1200ob', CAST(22.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (3, CAST(N'2020-07-02T10:19:06.5511192' AS DateTime2), NULL, 0, NULL, 1, 23, 3, 2, N'24" LED Vox 24DSA306H', CAST(10.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (4, CAST(N'2020-07-02T10:19:39.3492590' AS DateTime2), NULL, 0, NULL, 1, 20, 4, 3, N'Mašina za pranje veša Gorenje WEI 863S', CAST(66.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (5, CAST(N'2020-07-02T10:20:35.2917593' AS DateTime2), NULL, 0, NULL, 1, 35, 5, 3, N'32" LED Favorit', CAST(54.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (6, CAST(N'2020-07-02T10:20:35.2917602' AS DateTime2), NULL, 0, NULL, 1, 37, 5, 1, N'32" LED LG', CAST(9.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (7, CAST(N'2020-07-02T10:21:25.6276993' AS DateTime2), NULL, 0, NULL, 1, 16, 6, 1, N'Mašina za pranje veša Bosch Mašina za pranje veša Bosch', CAST(45.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (8, CAST(N'2020-07-02T10:21:25.6276999' AS DateTime2), NULL, 0, NULL, 1, 25, 6, 1, N'32" LED Alpha 32G7NHS', CAST(11.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (9, CAST(N'2020-07-02T10:26:03.0782405' AS DateTime2), NULL, 0, NULL, 1, 31, 7, 1, N'32" LED Philips 32PHT4203/12', CAST(66.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (10, CAST(N'2020-07-02T10:26:08.9232727' AS DateTime2), NULL, 0, NULL, 1, 32, 8, 1, N'32" LED LG 32LM550BPLB', CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (11, CAST(N'2020-07-02T10:26:18.4265714' AS DateTime2), NULL, 0, NULL, 1, 33, 9, 1, N'32" Smart LED LG 32LM6300PLA', CAST(56.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (12, CAST(N'2020-07-02T10:26:43.4817796' AS DateTime2), NULL, 0, NULL, 1, 34, 10, 1, N'32'''' Smart Android LED', CAST(22.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (13, CAST(N'2020-07-02T10:26:57.1491043' AS DateTime2), NULL, 0, NULL, 1, 38, 11, 1, N'ALTOS HUNTER', CAST(55.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (14, CAST(N'2020-07-02T10:27:31.8217604' AS DateTime2), NULL, 0, NULL, 1, 1, 12, 1, N'Tessttsdds', CAST(1212.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (15, CAST(N'2020-07-02T10:27:40.3785205' AS DateTime2), NULL, 0, NULL, 1, 16, 13, 1, N'Mašina za pranje veša Bosch Mašina za pranje veša Bosch', CAST(45.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (16, CAST(N'2020-07-02T10:27:46.5896411' AS DateTime2), NULL, 0, NULL, 1, 20, 14, 1, N'Mašina za pranje veša Gorenje WEI 863S', CAST(66.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (17, CAST(N'2020-07-02T10:30:38.6553105' AS DateTime2), NULL, 0, NULL, 1, 23, 15, 1, N'24" LED Vox 24DSA306H', CAST(10.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (18, CAST(N'2020-07-02T10:30:48.3792822' AS DateTime2), NULL, 0, NULL, 1, 32, 16, 1, N'32" LED LG 32LM550BPLB', CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (19, CAST(N'2020-07-02T10:31:15.4071324' AS DateTime2), NULL, 0, NULL, 1, 32, 17, 1, N'32" LED LG 32LM550BPLB', CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (20, CAST(N'2020-07-02T10:31:15.4071330' AS DateTime2), NULL, 0, NULL, 1, 1, 17, 1, N'Tessttsdds', CAST(1212.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (21, CAST(N'2020-07-02T10:31:28.5248909' AS DateTime2), NULL, 0, NULL, 1, 32, 18, 1, N'32" LED LG 32LM550BPLB', CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (22, CAST(N'2020-07-02T10:31:28.5248935' AS DateTime2), NULL, 0, NULL, 1, 12, 18, 1, N'Mašina za pranje veša 6 kg/1200', CAST(25.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (23, CAST(N'2020-07-02T10:33:32.5831027' AS DateTime2), NULL, 0, NULL, 1, 11, 19, 4, N'Candy Mašina za pranje veša', CAST(34.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (24, CAST(N'2020-07-02T10:33:39.1890175' AS DateTime2), NULL, 0, NULL, 1, 11, 20, 1, N'Candy Mašina za pranje veša', CAST(34.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (25, CAST(N'2020-07-02T10:34:15.2186976' AS DateTime2), NULL, 0, NULL, 1, 11, 21, 1, N'Candy Mašina za pranje veša', CAST(34.99 AS Decimal(18, 2)))
INSERT [dbo].[OrderInfo] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [ProductId], [OrderId], [Quantity], [Name], [Price]) VALUES (26, CAST(N'2020-07-02T10:34:15.2187004' AS DateTime2), NULL, 0, NULL, 1, 31, 21, 1, N'32" LED Philips 32PHT4203/12', CAST(66.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[OrderInfo] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (1, CAST(N'2020-07-02T00:39:45.7747207' AS DateTime2), CAST(N'2020-07-02T02:52:38.9085556' AS DateTime2), 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 5, 2, N'adresa 1')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (2, CAST(N'2020-07-02T10:18:58.4272957' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 5, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (3, CAST(N'2020-07-02T10:19:06.5511137' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 5, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (4, CAST(N'2020-07-02T10:19:39.3492488' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 5, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (5, CAST(N'2020-07-02T10:20:35.2917522' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 5, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (6, CAST(N'2020-07-02T10:21:25.6276920' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 5, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (7, CAST(N'2020-07-02T10:26:03.0776617' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (8, CAST(N'2020-07-02T10:26:08.9232679' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (9, CAST(N'2020-07-02T10:26:18.4265365' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (10, CAST(N'2020-07-02T10:26:43.4817745' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (11, CAST(N'2020-07-02T10:26:57.1490962' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (12, CAST(N'2020-07-02T10:27:31.8217523' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (13, CAST(N'2020-07-02T10:27:40.3784955' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (14, CAST(N'2020-07-02T10:27:46.5896342' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 12, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (15, CAST(N'2020-07-02T10:30:38.6552869' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (16, CAST(N'2020-07-02T10:30:48.3792595' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (17, CAST(N'2020-07-02T10:31:15.4071266' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (18, CAST(N'2020-07-02T10:31:28.5248833' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (19, CAST(N'2020-07-02T10:33:32.5830974' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (20, CAST(N'2020-07-02T10:33:39.1890125' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
INSERT [dbo].[Orders] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Date], [UserId], [OrderStatus], [Address]) VALUES (21, CAST(N'2020-07-02T10:34:15.2186926' AS DateTime2), NULL, 0, NULL, 1, CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), 6, 0, N'Zdravka Celara 15')
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (1, CAST(N'2020-07-01T03:27:35.4699077' AS DateTime2), CAST(N'2020-07-02T10:31:15.4071342' AS DateTime2), 0, NULL, 1, N'Tessttsdds', CAST(1212.00 AS Decimal(18, 2)), N'Tesfsfdfdf', 32, 1)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (4, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 1, N'Iphone', CAST(13.00 AS Decimal(18, 2)), N'Opis', 3, 1)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (5, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 1, N'Iphone 10', CAST(1134.00 AS Decimal(18, 2)), N'Najbolji telefon', 66, 1)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (8, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 1, N'Iphone 11', CAST(1999.00 AS Decimal(18, 2)), N'Najnoviji telefon od Apple-a', 2, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (11, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:34:15.2187036' AS DateTime2), 0, NULL, 1, N'Candy Mašina za pranje veša', CAST(34.99 AS Decimal(18, 2)), N'Mašina za pranje veša Candy', 82, 12)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (12, CAST(N'2020-07-10T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:31:28.5249056' AS DateTime2), 0, NULL, 1, N'Mašina za pranje veša 6 kg/1200', CAST(25.99 AS Decimal(18, 2)), N'Mašina za pranje veša VOX WM 1260 YT', 21, 12)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (16, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:27:40.3785339' AS DateTime2), 0, NULL, 1, N'Mašina za pranje veša Bosch Mašina za pranje veša Bosch', CAST(45.99 AS Decimal(18, 2)), N'Mašina za pranje veša Bosch', 0, 12)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (18, CAST(N'2020-07-11T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 1, N'Mašina za pranje veša 7 kg', CAST(33.00 AS Decimal(18, 2)), N'Mašina za pranje veša Candy CSO4 1075DB3', 66, 12)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (20, CAST(N'2020-07-09T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:27:46.5896421' AS DateTime2), 0, NULL, 1, N'Mašina za pranje veša Gorenje WEI 863S', CAST(66.00 AS Decimal(18, 2)), N' Jedinstveni talasasti oblik WaveActive bubnja', 0, 12)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (22, CAST(N'2020-06-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:18:58.4279925' AS DateTime2), 0, NULL, 1, N'Mašina za pranje veša 7 kg/1200ob', CAST(22.00 AS Decimal(18, 2)), N'omogućiće vam kvalitetno pranje veša', 5, 12)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (23, CAST(N'2020-07-08T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:30:38.6553247' AS DateTime2), 0, NULL, 1, N'24" LED Vox 24DSA306H', CAST(10.99 AS Decimal(18, 2)), N' HD Ready', 62, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (24, CAST(N'2020-07-04T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 1, N'32" Fox 32DLE80', CAST(66.00 AS Decimal(18, 2)), N'1366x768 HD Ready, HDMI, USB', 5, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (25, CAST(N'2020-06-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:21:25.6277014' AS DateTime2), 0, NULL, 1, N'32" LED Alpha 32G7NHS', CAST(11.00 AS Decimal(18, 2)), N'HD Ready', 8, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (28, CAST(N'2020-06-02T00:00:00.0000000' AS DateTime2), NULL, 0, NULL, 1, N'32" LED Elit L-3217ST2', CAST(33.00 AS Decimal(18, 2)), N'HD Ready', 8, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (31, CAST(N'2020-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:34:15.2187052' AS DateTime2), 0, NULL, 1, N'32" LED Philips 32PHT4203/12', CAST(66.00 AS Decimal(18, 2)), N'HD Ready', 31, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (32, CAST(N'2020-06-09T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:31:28.5248968' AS DateTime2), 0, NULL, 1, N'32" LED LG 32LM550BPLB', CAST(88.00 AS Decimal(18, 2)), N'HD Ready', 72, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (33, CAST(N'2020-06-11T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:26:18.4265725' AS DateTime2), 0, NULL, 1, N'32" Smart LED LG 32LM6300PLA', CAST(56.00 AS Decimal(18, 2)), N'Full HD', 1, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (34, CAST(N'2020-07-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:26:43.4817802' AS DateTime2), 0, NULL, 1, N'32'''' Smart Android LED', CAST(22.00 AS Decimal(18, 2)), N'ELIT L-3219AST2', 1, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (35, CAST(N'2020-05-19T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:20:35.2917612' AS DateTime2), 0, NULL, 1, N'32" LED Favorit', CAST(54.00 AS Decimal(18, 2)), N'32DN4P4T2, HD Ready-', 63, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (37, CAST(N'2020-06-07T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:20:35.2917624' AS DateTime2), 0, NULL, 1, N'32" LED LG', CAST(9.00 AS Decimal(18, 2)), N'32LK510BPLD, HD Ready', 42, 9)
INSERT [dbo].[Products] ([Id], [CreatedAt], [ModifiedAt], [IsDeleted], [DeletedAt], [IsActive], [Name], [Price], [Description], [Quantity], [CategoryId]) VALUES (38, CAST(N'2020-04-08T00:00:00.0000000' AS DateTime2), CAST(N'2020-07-02T10:26:57.1491052' AS DateTime2), 0, NULL, 1, N'ALTOS HUNTER', CAST(55.00 AS Decimal(18, 2)), N' AMD Ryzen 3 3200G/8GB/SSD ', 5, 11)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (1, N'User', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, 0, NULL)
INSERT [dbo].[Roles] ([Id], [Name], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (3, N'Admin', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, 0, NULL)
INSERT [dbo].[Roles] ([Id], [Name], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (5, N'Iphone', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[UseCaseLogs] ON 

INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (1, CAST(N'2020-07-02T06:39:02.0750988' AS DateTime2), N'Image upload using Ef-a', N'{"Path":{"ContentDisposition":"form-data; name=\"Path\"; filename=\"Screenshot_4.png\"","ContentType":"image/png","Headers":{"Content-Disposition":["form-data; name=\"Path\"; filename=\"Screenshot_4.png\""],"Content-Type":["image/png"]},"Length":102003,"Name":"Path","FileName":"Screenshot_4.png"},"Alt":"Slika","ProductId":1}', N'Test')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (2, CAST(N'2020-07-02T07:02:25.3136998' AS DateTime2), N'UseCase search.', N'{"Email":null,"DatumOd":"0001-01-01T00:00:00","DatumDo":"0001-01-01T00:00:00","Name":null,"NotAutorizedActor":false,"PerPage":5,"Page":1}', N'Test')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (3, CAST(N'2020-07-02T07:03:27.4123143' AS DateTime2), N'UseCase search.', N'{"Email":null,"DatumOd":"0001-01-01T00:00:00","DatumDo":"0001-01-01T00:00:00","Name":null,"NotAutorizedActor":false,"PerPage":5,"Page":1}', N'Test')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (4, CAST(N'2020-07-02T07:23:04.1389179' AS DateTime2), N'User search.', N'{"Name":null,"PerPage":5,"Page":1}', N'Test')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (5, CAST(N'2020-07-02T08:18:58.0025044' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":22,"Quantity":2}]}', N'Admin')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (6, CAST(N'2020-07-02T08:19:06.5384810' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":23,"Quantity":2}]}', N'Admin')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (7, CAST(N'2020-07-02T08:19:39.3256518' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":20,"Quantity":3}]}', N'Admin')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (8, CAST(N'2020-07-02T08:20:35.2629972' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":35,"Quantity":3},{"ProductId":37,"Quantity":1}]}', N'Admin')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (9, CAST(N'2020-07-02T08:21:25.6079148' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":16,"Quantity":1},{"ProductId":25,"Quantity":1}]}', N'Admin')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (10, CAST(N'2020-07-02T08:26:02.6307654' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":31,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (11, CAST(N'2020-07-02T08:26:08.9099399' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":32,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (12, CAST(N'2020-07-02T08:26:18.4055317' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":33,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (13, CAST(N'2020-07-02T08:26:43.4700143' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":34,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (14, CAST(N'2020-07-02T08:26:57.1384571' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":38,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (15, CAST(N'2020-07-02T08:27:31.8051294' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":1,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (16, CAST(N'2020-07-02T08:27:40.3623859' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":16,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (17, CAST(N'2020-07-02T08:27:46.5726901' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":20,"Quantity":1}]}', N'Mark112222')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (18, CAST(N'2020-07-02T08:29:20.7512338' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":20,"Quantity":1}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (19, CAST(N'2020-07-02T08:30:38.6179565' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":23,"Quantity":1}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (20, CAST(N'2020-07-02T08:30:48.3634987' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":32,"Quantity":1}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (21, CAST(N'2020-07-02T08:31:15.3957860' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":32,"Quantity":1},{"ProductId":1,"Quantity":1}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (22, CAST(N'2020-07-02T08:31:28.4954031' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":32,"Quantity":1},{"ProductId":12,"Quantity":1}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (23, CAST(N'2020-07-02T08:33:32.5648406' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":11,"Quantity":4}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (24, CAST(N'2020-07-02T08:33:39.1797541' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":11,"Quantity":1}]}', N'Pera')
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (25, CAST(N'2020-07-02T08:34:15.2027865' AS DateTime2), N'Create Order using EF', N'{"OrderDate":"2020-07-18T00:00:00","Address":"Zdravka Celara 15","Items":[{"ProductId":11,"Quantity":1},{"ProductId":31,"Quantity":1}]}', N'Pera')
SET IDENTITY_INSERT [dbo].[UseCaseLogs] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Username], [FirstName], [LastName], [Password], [Email], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt], [RoleId]) VALUES (5, N'Admin', N'Admin', N'Admin', N'Admin', N'Admin@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, 0, NULL, 1)
INSERT [dbo].[Users] ([Id], [Username], [FirstName], [LastName], [Password], [Email], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt], [RoleId]) VALUES (6, N'Pera', N'Pera', N'Pera', N'Pera', N'pera@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 0, 0, NULL, 1)
INSERT [dbo].[Users] ([Id], [Username], [FirstName], [LastName], [Password], [Email], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt], [RoleId]) VALUES (10, N'Markoczv314', N'Marko', N'Milivojevic', N'proba123', N'markoczv314@gmail.com', CAST(N'2020-07-02T06:27:59.0013035' AS DateTime2), NULL, 1, 0, NULL, 1)
INSERT [dbo].[Users] ([Id], [Username], [FirstName], [LastName], [Password], [Email], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt], [RoleId]) VALUES (11, N'Mark1122', N'Marko', N'Milivojevic', N'proba123', N'markoczv314@gmail.com', CAST(N'2020-07-02T06:42:09.3001677' AS DateTime2), NULL, 1, 0, NULL, 1)
INSERT [dbo].[Users] ([Id], [Username], [FirstName], [LastName], [Password], [Email], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt], [RoleId]) VALUES (12, N'Mark112222', N'Marko', N'Milivojevic', N'proba123', N'markoczv314@gmail.com', CAST(N'2020-07-02T06:46:27.9691618' AS DateTime2), NULL, 1, 0, NULL, 1)
INSERT [dbo].[Users] ([Id], [Username], [FirstName], [LastName], [Password], [Email], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt], [RoleId]) VALUES (13, N'Mirko', N'Marko', N'Milivojevic', N'proba123', N'markoczv314@gmail.com', CAST(N'2020-07-02T06:51:33.2406566' AS DateTime2), NULL, 1, 0, NULL, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[UserUseCase] ON 

INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (1, 5, 1)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (2, 5, 2)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (3, 5, 3)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (4, 5, 4)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (5, 5, 5)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (6, 5, 6)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (7, 5, 7)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (8, 5, 8)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (9, 5, 9)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (10, 5, 10)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (11, 6, 5)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (12, 5, 11)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (13, 5, 12)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (14, 5, 13)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (15, 5, 14)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (16, 5, 15)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (17, 5, 16)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (18, 5, 17)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (19, 5, 18)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (20, 5, 19)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (21, 5, 20)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (22, 5, 21)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (23, 5, 22)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (24, 5, 23)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (25, 5, 24)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (26, 5, 25)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (27, 5, 26)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (28, 5, 27)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (29, 5, 28)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (30, 5, 29)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (31, 5, 30)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (32, 12, 12)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (33, 12, 1)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (34, 12, 2)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (35, 12, 3)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (36, 12, 4)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (37, 12, 5)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (38, 10, 1)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (39, 11, 1)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (40, 13, 1)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (41, 6, 2)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (42, 12, 20)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (43, 12, 19)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (44, 12, 10)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (45, 12, 15)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (46, 12, 11)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (47, 12, 12)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (49, 12, 13)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (51, 12, 17)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (53, 12, 25)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (54, 12, 14)
INSERT [dbo].[UserUseCase] ([Id], [UserId], [UseCaseId]) VALUES (55, 6, 14)
SET IDENTITY_INSERT [dbo].[UserUseCase] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Categories_Name]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Categories_Name] ON [dbo].[Categories]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Images_ProductId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_Images_ProductId] ON [dbo].[Images]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderInfo_OrderId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderInfo_OrderId] ON [dbo].[OrderInfo]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderInfo_ProductId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderInfo_ProductId] ON [dbo].[OrderInfo]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Products_Name]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Products_Name] ON [dbo].[Products]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Roles_Name]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Roles_Name] ON [dbo].[Roles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_Users_Username]    Script Date: 7/2/2020 10:42:26 AM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [AK_Users_Username] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_RoleId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_Users_RoleId] ON [dbo].[Users]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserUseCase_UserId]    Script Date: 7/2/2020 10:42:26 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserUseCase_UserId] ON [dbo].[UserUseCase]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderInfo] ADD  DEFAULT ((0.0)) FOR [Price]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [OrderStatus]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [CategoryId]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [RoleId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Products_ProductId]
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfo_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderInfo] CHECK CONSTRAINT [FK_OrderInfo_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfo_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderInfo] CHECK CONSTRAINT [FK_OrderInfo_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users_UserId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserUseCase]  WITH CHECK ADD  CONSTRAINT [FK_UserUseCase_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserUseCase] CHECK CONSTRAINT [FK_UserUseCase_Users_UserId]
GO
