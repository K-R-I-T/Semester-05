USE [master]
GO
/****** Object:  Database [OnlyArts]    Script Date: 3/7/2024 7:45:18 PM ******/
CREATE DATABASE [OnlyArts]
GO
ALTER DATABASE [OnlyArts] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlyArts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlyArts] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlyArts] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlyArts] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlyArts] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlyArts] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlyArts] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlyArts] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlyArts] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlyArts] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlyArts] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlyArts] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlyArts] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlyArts] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlyArts] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlyArts] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlyArts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlyArts] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlyArts] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlyArts] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlyArts] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlyArts] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlyArts] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlyArts] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OnlyArts] SET  MULTI_USER 
GO
ALTER DATABASE [OnlyArts] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlyArts] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlyArts] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlyArts] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlyArts] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OnlyArts] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [OnlyArts] SET QUERY_STORE = OFF
GO
USE [OnlyArts]
GO
/****** Object:  Table [dbo].[Artwork_reactions]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artwork_reactions](
	[artwork_id] [varchar](20) NOT NULL,
	[user_id] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[artwork_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artworks]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artworks](
	[artwork_id] [varchar](20) NOT NULL,
	[owner_id] [varchar](20) NOT NULL,
	[cate_id] [varchar](20) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NULL,
	[artwork_image] [varchar](max) NULL,
	[price] [float] NOT NULL,
	[released_date] [datetime] DEFAULT CURRENT_TIMESTAMP NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_Artworks_1] PRIMARY KEY CLUSTERED 
(
	[artwork_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[user_id] [varchar](20) NOT NULL,
	[artwork_id] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[artwork_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[cate_id] [varchar](20) NOT NULL,
	[cate_name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[cate_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[artwork_id] [varchar](20) NOT NULL,
	[commenter_id] [varchar](20) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[comment_time] [datetime] NOT NULL,
	[comment_id] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Followings]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Followings](
	[user_id] [varchar](20) NOT NULL,
	[followed_user_id] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[followed_user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[image_id] [varchar](20) NOT NULL,
	[image] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[image_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[user_id] [varchar](20) NOT NULL,
	[notice_time] [datetime] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_details]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_details](
	[order_id] [varchar](20) NOT NULL,
	[artwork_id] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [varchar](20) NOT NULL,
	[user_id] [varchar](20) NOT NULL,
	[status] [int] NOT NULL,
	[payment_method] [nvarchar](max) NOT NULL,
	[order_time] [datetime] NOT NULL,
	[total_price] [float] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[report_id] [varchar](20) NOT NULL,
	[artwork_id] [varchar](20) NOT NULL,
	[reporter_id] [varchar](20) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[report_time] [datetime] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[report_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports_handler]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports_handler](
	[report_id] [varchar](20) NOT NULL,
	[mod_id] [varchar](20) NOT NULL,
	[description] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[customer_id] [varchar](20) NOT NULL,
	[publisher_id] [varchar](20) NOT NULL,
	[request_time] [datetime] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[status] [int] NOT NULL,
	[request_id] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[request_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responses]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responses](
	[request_id] [varchar](20) NOT NULL,
	[response_id] [varchar](20) NOT NULL,
	[image] [varchar](max) NOT NULL,
	[description] [nvarchar](max) NULL,
	[response_time] [datetime] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_Responses] PRIMARY KEY CLUSTERED 
(
	[response_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[role_id] [varchar](20) NOT NULL,
	[role_name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tokens]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tokens](
	[user_id] [varchar](20) NOT NULL,
	[token] [varchar](max) NOT NULL,
	[status] [int] NOT NULL,
	[validDate] [datetime] NOT NULL,
	[expiredDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [varchar](20) NOT NULL,
	[role_id] [varchar](20) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[phone] [varchar](15) NULL,
	[email] [varchar](max) NOT NULL,
	[address] [nvarchar](max) NULL,
	[join_date] [date] NOT NULL,
	[bio] [nvarchar](max) NULL,
	[status] [int] NOT NULL,
	[password] [varchar](max) NOT NULL,
	[avatar] [varchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_favor]    Script Date: 3/7/2024 7:45:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_favor](
	[artwork_id] [varchar](20) NOT NULL,
	[user_id] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[artwork_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Artwork_reactions] ([artwork_id], [user_id]) VALUES (N'AW0001', N'US0002')
INSERT [dbo].[Artwork_reactions] ([artwork_id], [user_id]) VALUES (N'AW0001', N'US0004')
GO
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'11415264452407448589', N'US0002', N'CT0028', N'Test2', N'Test2', N'0xFFD8FFE000104A46494600010100000100010000FFE201174578696600004D4D002A00000008000C013F0002000000100000002A0101000300000001000000E1F20303200001000000A00200215684532', 100, CAST(N'2024-03-03T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'33942448349504420947', N'US0002', N'CT0028', N'Test', N'Test', N'0xFFD8FFE000104A46494600010100000100010000FFE201174578696600004D4D002A00000008000C013F0002000000100000002A0101000300000001000000E1F20303200001000000A00200000', 0, CAST(N'2024-03-03T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0001', N'US0002', N'CT0028', N'Sunset Serenade', N'A serene depiction of sunset over the ocean', NULL, 200, CAST(N'2023-05-15T09:00:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0002', N'US0003', N'CT0024', N'Abstract Whispers', N'Vibrant abstract artwork for the imaginative', NULL, 150, CAST(N'2023-06-20T14:30:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0003', N'US0004', N'CT0032', N'Floral Symphony', N'Delicate flowers in a picturesque arrangement', NULL, 180, CAST(N'2023-07-10T11:45:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0004', N'US0005', N'CT0028', N'Oceanic Bliss', N'Dynamic waves crashing against rocky cliffs', NULL, 250, CAST(N'2023-08-05T10:15:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0005', N'US0006', N'CT0020', N'Urban Nightscapes', N'A cityscape alive with the glow of night lights', NULL, 300, CAST(N'2023-09-18T16:20:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0006', N'US0007', N'CT0028', N'Mountain Majesty', N'Majestic peaks rise against a golden sunrise', NULL, 400, CAST(N'2023-10-30T08:45:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0007', N'US0008', N'CT0020', N'Urban Chaos', N'Abstract representation of bustling city life', NULL, 180, CAST(N'2023-12-12T09:30:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0008', N'US0009', N'CT0024', N'Wildfire Symphony', N'Fiery colors dance in an intense', NULL, 270, CAST(N'2024-01-05T10:00:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0009', N'US0010', N'CT0028', N'Tranquil Waters', N'Peaceful waters reflecting the tranquility', NULL, 320, CAST(N'2024-02-20T11:15:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0010', N'US0011', N'CT0024', N'Celestial Constellations', N'Cosmic masterpiece depicting celestial bodies', NULL, 500, CAST(N'2024-03-08T14:45:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0011', N'US0012', N'CT0028', N'Autumnal Reverie', N'Rich hues of autumn foliage in a serene forest', NULL, 220, CAST(N'2023-11-25T13:10:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0012', N'US0013', N'CT0033', N'Enigmatic Woods', N'Mystical forest scene shrouded in darkness', NULL, 280, CAST(N'2024-04-10T10:30:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0013', N'US0014', N'CT0001', N'Desert Mirage', N'Surreal desert landscape evoking mirage', NULL, 380, CAST(N'2024-05-15T09:00:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0014', N'US0015', N'CT0017', N'Oceanic Depths', N'Vivid underwater world teeming with life', NULL, 450, CAST(N'2024-06-20T14:30:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0015', N'US0016', N'CT0024', N'Harmonious Fusion', N'Abstract composition of harmonious elements', NULL, 220, CAST(N'2024-07-10T11:45:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0016', N'US0017', N'CT0028', N'Moonlit Meadows', N'Mystical moonlit landscape with ethereal glow', NULL, 300, CAST(N'2024-08-05T10:15:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0017', N'US0018', N'CT0024', N'Galactic Odyssey', N'Interstellar artwork inspired by the cosmos', NULL, 600, CAST(N'2024-09-18T16:20:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0018', N'US0019', N'CT0033', N'Enchanted Realms', N'Whimsical scene filled with enchanting elements', NULL, 350, CAST(N'2024-10-30T08:45:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0019', N'US0020', N'CT0019', N'Rustic Charms', N'Rustic countryside charm captured in paint', NULL, 280, CAST(N'2024-11-25T13:10:00.000' AS DateTime), 0)
INSERT [dbo].[Artworks] ([artwork_id], [owner_id], [cate_id], [name], [description], [artwork_image], [price], [released_date], [status]) VALUES (N'AW0020', N'US0017', N'CT0028', N'Sunset Sail', N'Sailboat drifting under a fiery sunset sky', NULL, 400, CAST(N'2024-12-12T09:30:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0001', N'AbstractStyle')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0002', N'Animation')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0003', N'Basic')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0004', N'Classic')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0005', N'Complex')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0006', N'Digital')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0007', N'DigitalTech')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0008', N'Expressionism')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0009', N'Fabric')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0010', N'FamousPortrait')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0011', N'Impressionism')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0012', N'Interior')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0013', N'Modern')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0014', N'Natural')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0015', N'Paper')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0016', N'Pastel')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0017', N'Realistic')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0018', N'Sketch')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0019', N'Traditional')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0020', N'Urban')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0021', N'Wall')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0022', N'Watercolor')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0023', N'Wood')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0024', N'Abstract')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0025', N'Acrylic')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0026', N'Charcoal')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0027', N'Comic')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0028', N'Landscape')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0029', N'Oil')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0030', N'Pencil')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0031', N'Portrait')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0032', N'StillLife')
INSERT [dbo].[Categories] ([cate_id], [cate_name]) VALUES (N'CT0033', N'Fantasy')
GO
INSERT [dbo].[Comments] ([artwork_id], [commenter_id], [description], [comment_time], [comment_id]) VALUES (N'AW0001', N'US0002', N'nicenicenice', CAST(N'2024-03-03T00:00:00.000' AS DateTime), N'46122584900219254691')
GO
INSERT [dbo].[Notifications] ([user_id], [notice_time], [description], [status]) VALUES (N'US0002', CAST(N'2024-03-04T00:00:00.000' AS DateTime), N'Thank you for your report, we had comfirmed that wrong!', 0)
INSERT [dbo].[Notifications] ([user_id], [notice_time], [description], [status]) VALUES (N'US0002', CAST(N'2024-03-04T00:00:00.000' AS DateTime), N'Thank you for your report, we had comfirmed that right!', 0)
INSERT [dbo].[Notifications] ([user_id], [notice_time], [description], [status]) VALUES (N'US0002', CAST(N'2024-03-04T00:00:00.000' AS DateTime), N'Warning: You are reported by someone, because of Copyright problem', 0)
GO
INSERT [dbo].[Reports] ([report_id], [artwork_id], [reporter_id], [description], [report_time], [status]) VALUES (N'91565546063901690907', N'11415264452407448589', N'US0002', N'thang nay an trom ban quyen cua t', CAST(N'2024-03-03T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[Reports_handler] ([report_id], [mod_id], [description]) VALUES (N'91565546063901690907', N'US0002', N'Accepted')
INSERT [dbo].[Reports_handler] ([report_id], [mod_id], [description]) VALUES (N'91565546063901690907', N'US0001', N'Accepted')
INSERT [dbo].[Reports_handler] ([report_id], [mod_id], [description]) VALUES (N'91565546063901690907', N'US0001', N'Accecpted')
GO
INSERT [dbo].[Roles] ([role_id], [role_name]) VALUES (N'AD', N'Administrator')
INSERT [dbo].[Roles] ([role_id], [role_name]) VALUES (N'CR', N'Creator')
INSERT [dbo].[Roles] ([role_id], [role_name]) VALUES (N'CT', N'Customer')
GO
INSERT [dbo].[Tokens] ([user_id], [token], [status], [validDate], [expiredDate]) VALUES (N'US0001', N'hieuvuanguday', 1, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2025-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0001', N'AD', N'Thuc', N'Hoang Ngoc', N'1234567890', N'thuc@example.com', N'123 Main St, City', CAST(N'2022-05-10' AS Date), N'', 1, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0002', N'CT', N'Alice', N'Johnson', N'9876543210', N'alice.j@example.com', N'456 Elm St, Town', CAST(N'2023-06-22' AS Date), N'Passionate about capturing...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0003', N'CR', N'Bob', N'Smith', N'5551234567', N'bob.smith@example.com', N'789 Oak St, Village', CAST(N'2023-07-18' AS Date), N'Exploring the depths of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0004', N'CT', N'Emily', N'Brown', N'2223334444', N'emily.b@example.com', N'101 Pine St, Hamlet', CAST(N'2023-08-05' AS Date), N'Finding beauty in simplicity...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0005', N'CR', N'Michael', N'Lee', N'1112223333', N'michael.lee@example.com', N'202 Maple Ave, Park', CAST(N'2023-08-15' AS Date), N'Nature lover and landscape...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0006', N'CT', N'Sarah', N'Garcia', N'3334445555', N'sarah.g@example.com', N'303 Cedar Rd, County', CAST(N'2023-09-02' AS Date), N'Creating art that tells...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0007', N'CT', N'David', N'Martinez', N'4445556666', N'david.m@example.com', N'505 Walnut Ln, Bay', CAST(N'2023-09-20' AS Date), N'Drawing inspiration from...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0008', N'CT', N'Olivia', N'Hernandez', N'6667778888', N'olivia.h@example.com', N'707 Cherry Dr, Port', CAST(N'2023-10-11' AS Date), N'Exploring the intersection...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0009', N'CT', N'James', N'Wright', N'7778889999', N'james.w@example.com', N'909 Pineapple Cir, Isle', CAST(N'2023-10-29' AS Date), N'Combining traditional techniques...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0010', N'CT', N'Emma', N'Nguyen', N'9990001111', N'emma.n@example.com', N'111 Orange Blvd, Cove', CAST(N'2023-11-14' AS Date), N'Pushing the boundaries of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0011', N'CT', N'Ethan', N'Kim', N'1239876543', N'ethan.k@example.com', N'222 Banana St, Beach', CAST(N'2023-11-30' AS Date), N'Exploring the realms of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0012', N'CT', N'Mia', N'Patel', N'5556667777', N'mia.p@example.com', N'333 Grape Rd, Cliff', CAST(N'2023-12-15' AS Date), N'Finding harmony in chaos...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0013', N'CT', N'Sophia', N'Gonzales', N'7778889999', N'sophia.g@example.com', N'444 Lemon Ave, Hill', CAST(N'2024-01-03' AS Date), N'Capturing emotions through...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0014', N'CT', N'Alexander', N'Carter', N'1112223333', N'alexander.c@example.com', N'555 Lime Blvd, Valley', CAST(N'2024-01-20' AS Date), N'Reflecting the beauty of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0015', N'CT', N'Charlotte', N'Ramirez', N'4445556666', N'charlotte.r@example.com', N'666 Blue St, Mountain', CAST(N'2024-02-05' AS Date), N'Delving into the depths of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0016', N'CT', N'Liam', N'Stewart', N'9998887777', N'liam.s@example.com', N'777 Peach Dr, Lake', CAST(N'2024-02-18' AS Date), N'Exploring the fusion of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0017', N'CT', N'Amelia', N'Peterson', N'5554443333', N'amelia.p@example.com', N'888 Water Rd, River', CAST(N'2024-03-02' AS Date), N'Finding inspiration in everyday...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0018', N'CT', N'Benjamin', N'Morris', N'1113335555', N'benjamin.m@example.com', N'999 Fire Ave, Desert', CAST(N'2024-03-20' AS Date), N'Fusing tradition with innovation...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0019', N'CT', N'Harper', N'James', N'6665554444', N'harper.j@example.com', N'111 Wind Dr, Fores', CAST(N'2024-04-05' AS Date), N'Embracing the fluidity of...', 0, N'1', NULL)
INSERT [dbo].[Users] ([user_id], [role_id], [first_name], [last_name], [phone], [email], [address], [join_date], [bio], [status], [password], [avatar]) VALUES (N'US0020', N'CT', N'Evelyn', N'Watson', N'2228889999', N'evelyn.w@example.com', N'222 Snow Ln, Tundra', CAST(N'2024-04-22' AS Date), N'Infusing art with...', 0, N'1', NULL)
GO
INSERT [dbo].[Users_favor] ([artwork_id], [user_id]) VALUES (N'AW0001', N'US0003')
INSERT [dbo].[Users_favor] ([artwork_id], [user_id]) VALUES (N'AW0001', N'US0004')
INSERT [dbo].[Users_favor] ([artwork_id], [user_id]) VALUES (N'AW0002', N'US0010')
INSERT [dbo].[Users_favor] ([artwork_id], [user_id]) VALUES (N'AW0005', N'US0002')
GO
ALTER TABLE [dbo].[Artwork_reactions]  WITH CHECK ADD  CONSTRAINT [FK__Artwork_r__artwo__753864A1] FOREIGN KEY([artwork_id])
REFERENCES [dbo].[Artworks] ([artwork_id])
GO
ALTER TABLE [dbo].[Artwork_reactions] CHECK CONSTRAINT [FK__Artwork_r__artwo__753864A1]
GO
ALTER TABLE [dbo].[Artwork_reactions]  WITH CHECK ADD  CONSTRAINT [FK__Artwork_r__user___762C88DA] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Artwork_reactions] CHECK CONSTRAINT [FK__Artwork_r__user___762C88DA]
GO
ALTER TABLE [dbo].[Artworks]  WITH CHECK ADD  CONSTRAINT [FK_Artworks_Categories] FOREIGN KEY([cate_id])
REFERENCES [dbo].[Categories] ([cate_id])
GO
ALTER TABLE [dbo].[Artworks] CHECK CONSTRAINT [FK_Artworks_Categories]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Artworks] FOREIGN KEY([artwork_id])
REFERENCES [dbo].[Artworks] ([artwork_id])
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Artworks]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Users]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Artworks] FOREIGN KEY([artwork_id])
REFERENCES [dbo].[Artworks] ([artwork_id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Artworks]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users] FOREIGN KEY([commenter_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users]
GO
ALTER TABLE [dbo].[Followings]  WITH CHECK ADD  CONSTRAINT [FK__Following__follo__6E8B6712] FOREIGN KEY([followed_user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Followings] CHECK CONSTRAINT [FK__Following__follo__6E8B6712]
GO
ALTER TABLE [dbo].[Followings]  WITH CHECK ADD  CONSTRAINT [FK__Following__user___6D9742D9] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Followings] CHECK CONSTRAINT [FK__Following__user___6D9742D9]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_Notifications_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_Notifications_Users]
GO
ALTER TABLE [dbo].[Order_details]  WITH CHECK ADD  CONSTRAINT [FK_Order_details_Artworks] FOREIGN KEY([artwork_id])
REFERENCES [dbo].[Artworks] ([artwork_id])
GO
ALTER TABLE [dbo].[Order_details] CHECK CONSTRAINT [FK_Order_details_Artworks]
GO
ALTER TABLE [dbo].[Order_details]  WITH CHECK ADD  CONSTRAINT [FK_Order_details_Orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([order_id])
GO
ALTER TABLE [dbo].[Order_details] CHECK CONSTRAINT [FK_Order_details_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Artworks] FOREIGN KEY([artwork_id])
REFERENCES [dbo].[Artworks] ([artwork_id])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Artworks]
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Users] FOREIGN KEY([reporter_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Users]
GO
ALTER TABLE [dbo].[Reports_handler]  WITH CHECK ADD  CONSTRAINT [FK_Reports_handler_Reports] FOREIGN KEY([report_id])
REFERENCES [dbo].[Reports] ([report_id])
GO
ALTER TABLE [dbo].[Reports_handler] CHECK CONSTRAINT [FK_Reports_handler_Reports]
GO
ALTER TABLE [dbo].[Reports_handler]  WITH CHECK ADD  CONSTRAINT [FK_Reports_handler_Users] FOREIGN KEY([mod_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Reports_handler] CHECK CONSTRAINT [FK_Reports_handler_Users]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Users] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Users]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Users1] FOREIGN KEY([publisher_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Users1]
GO
ALTER TABLE [dbo].[Responses]  WITH CHECK ADD  CONSTRAINT [FK_Responses_Requests] FOREIGN KEY([response_id])
REFERENCES [dbo].[Requests] ([request_id])
GO
ALTER TABLE [dbo].[Responses] CHECK CONSTRAINT [FK_Responses_Requests]
GO
ALTER TABLE [dbo].[Tokens]  WITH CHECK ADD  CONSTRAINT [FK_Tokens_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Tokens] CHECK CONSTRAINT [FK_Tokens_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([role_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
ALTER TABLE [dbo].[Users_favor]  WITH CHECK ADD  CONSTRAINT [FK__Users_fav__artwo__79FD19BE] FOREIGN KEY([artwork_id])
REFERENCES [dbo].[Artworks] ([artwork_id])
GO
ALTER TABLE [dbo].[Users_favor] CHECK CONSTRAINT [FK__Users_fav__artwo__79FD19BE]
GO
ALTER TABLE [dbo].[Users_favor]  WITH CHECK ADD  CONSTRAINT [FK__Users_fav__user___7AF13DF7] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Users_favor] CHECK CONSTRAINT [FK__Users_fav__user___7AF13DF7]
GO
USE [master]
GO
ALTER DATABASE [OnlyArts] SET  READ_WRITE 
GO
