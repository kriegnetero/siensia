USE [master]
GO
/****** Object:  Database [cine_view]    Script Date: 23/06/2025 21:31:57 ******/
CREATE DATABASE [cine_view]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cine_view', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\cine_view.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cine_view_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\cine_view_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [cine_view] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cine_view].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cine_view] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cine_view] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cine_view] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cine_view] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cine_view] SET ARITHABORT OFF 
GO
ALTER DATABASE [cine_view] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cine_view] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cine_view] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cine_view] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cine_view] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cine_view] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cine_view] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cine_view] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cine_view] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cine_view] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cine_view] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cine_view] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cine_view] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cine_view] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cine_view] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cine_view] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cine_view] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cine_view] SET RECOVERY FULL 
GO
ALTER DATABASE [cine_view] SET  MULTI_USER 
GO
ALTER DATABASE [cine_view] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cine_view] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cine_view] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cine_view] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cine_view] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cine_view] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cine_view', N'ON'
GO
ALTER DATABASE [cine_view] SET QUERY_STORE = ON
GO
ALTER DATABASE [cine_view] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cine_view]
GO
/****** Object:  Table [dbo].[a_review]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[a_review](
	[cod] [int] NOT NULL,
	[stat] [varchar](5) NULL,
	[review] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lista_negra]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lista_negra](
	[email] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[moderador]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[moderador](
	[email] [varchar](60) NOT NULL,
	[senha] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registro_acesso]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registro_acesso](
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](60) NULL,
	[email] [varchar](60) NULL,
	[senha] [varchar](60) NULL,
	[foto] [varchar](255) NULL,
	[fav_genero] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[resposta]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[resposta](
	[cod] [int] NULL,
	[id_reposta] [int] IDENTITY(1,1) NOT NULL,
	[resposta] [text] NULL,
	[email] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reposta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[review]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[review](
	[nome_filme] [varchar](60) NULL,
	[nota] [int] NULL,
	[comentario] [text] NULL,
	[genero] [varchar](255) NULL,
	[cartaz] [varchar](255) NULL,
	[email] [varchar](60) NULL,
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviewer]    Script Date: 23/06/2025 21:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviewer](
	[id] [varchar](60) NULL,
	[email] [varchar](60) NOT NULL,
	[senha] [varchar](60) NULL,
	[foto] [varchar](255) NULL,
	[fav_genero] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[lista_negra]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[reviewer] ([email])
GO
ALTER TABLE [dbo].[moderador]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[reviewer] ([email])
GO
ALTER TABLE [dbo].[resposta]  WITH CHECK ADD FOREIGN KEY([cod])
REFERENCES [dbo].[review] ([cod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[review]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[reviewer] ([email])
GO
USE [master]
GO
ALTER DATABASE [cine_view] SET  READ_WRITE 
GO
