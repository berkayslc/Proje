USE [master]
GO
/****** Object:  Database [Bilgiler]    Script Date: 5.06.2022 18:26:58 ******/
CREATE DATABASE [Bilgiler]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bilgiler', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bilgiler.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bilgiler_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bilgiler_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bilgiler] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bilgiler].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bilgiler] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bilgiler] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bilgiler] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bilgiler] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bilgiler] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bilgiler] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bilgiler] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bilgiler] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bilgiler] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bilgiler] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bilgiler] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bilgiler] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bilgiler] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bilgiler] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bilgiler] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bilgiler] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bilgiler] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bilgiler] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bilgiler] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bilgiler] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bilgiler] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bilgiler] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bilgiler] SET RECOVERY FULL 
GO
ALTER DATABASE [Bilgiler] SET  MULTI_USER 
GO
ALTER DATABASE [Bilgiler] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bilgiler] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bilgiler] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bilgiler] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bilgiler] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bilgiler] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bilgiler', N'ON'
GO
ALTER DATABASE [Bilgiler] SET QUERY_STORE = OFF
GO
USE [Bilgiler]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ad_soyad] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borclar](
	[miktar] [int] NULL,
	[borc_sahibi_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Petler]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Petler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[isim] [nvarchar](50) NULL,
	[tur] [nvarchar](50) NULL,
	[cinsiyet] [nvarchar](50) NULL,
	[sahip_id] [int] NULL,
	[dogum] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevu]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevu](
	[saat] [nvarchar](5) NULL,
	[rnd_sahibi_id] [int] NOT NULL,
	[rnd_pet_id] [int] NOT NULL,
	[veteriner_adsoyad] [nvarchar](50) NULL,
	[aciklama] [nvarchar](200) NULL,
	[tarih] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sahiplendirme]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sahiplendirme](
	[yas] [nvarchar](50) NULL,
	[tur] [nvarchar](50) NULL,
	[cinsiyet] [nvarchar](50) NULL,
	[imgpath] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sahipler]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sahipler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ad_soyad] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[telefon] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veterinerler]    Script Date: 5.06.2022 18:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veterinerler](
	[ad_soyad] [nvarchar](50) NOT NULL,
	[telefon] [varchar](15) NULL,
	[unvan] [nvarchar](20) NULL,
 CONSTRAINT [PK_Veterinerler] PRIMARY KEY CLUSTERED 
(
	[ad_soyad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([ad_soyad], [sifre], [email]) VALUES (N'i', N'1', N'ilaydaglba@gmail.com')
INSERT [dbo].[Admin] ([ad_soyad], [sifre], [email]) VALUES (N'İlayda Gölbaşı', N'1234', N'ilaydaglba@gmail.com')
GO
INSERT [dbo].[Borclar] ([miktar], [borc_sahibi_id]) VALUES (350, 1)
INSERT [dbo].[Borclar] ([miktar], [borc_sahibi_id]) VALUES (900, 2)
INSERT [dbo].[Borclar] ([miktar], [borc_sahibi_id]) VALUES (200, 13)
GO
SET IDENTITY_INSERT [dbo].[Petler] ON 

INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (9, N'Kete', N'Kedi', N'Kısırlaştırılmış dişi', 1, N'01.05.2020')
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (10, N'Gece', N'Kedi', N'Kısırlaştırılmış dişi', 9, N'01.05.2020')
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (11, N'Pepi', N'Kedi', N'Erkek', 9, N'01.01.2021')
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (12, N'Limon', N'Kuş', N'Erkek', 1, N'01.01.2014')
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (14, N'Edgar', N'Köpek', N'Kısırlaştırılmış erkek', 4, NULL)
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (15, N'Pilav', N'Kedi', N'Kısırlaştırılmış erkek', 2, NULL)
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (16, N'Mantı', N'Kedi', N'Dişi', 3, NULL)
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (17, N'Şans', N'Köpek', N'Kısırlaştırılmış dişi', 5, N'  .  .')
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (18, N'Pipkin', N'Kemirgen', N'Erkek', 6, NULL)
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (20, N'Misha', N'Köpek', N'Kısırlaştırılmış dişi', 8, NULL)
INSERT [dbo].[Petler] ([id], [isim], [tur], [cinsiyet], [sahip_id], [dogum]) VALUES (22, N'dsgfds', N'Kedi', N'Erkek', 13, N'  .  .')
SET IDENTITY_INSERT [dbo].[Petler] OFF
GO
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'10.00', 1, 9, N'Enes Doğan', N'Kontrol', N'2.6.2022')
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'15.00', 3, 16, N'Murat Öztürk', N'Kısırlaştırma', N'17.6.2022')
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'15.00', 2, 15, N'Enes Doğan', N'Kontrol', N'14.6.2022')
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'11.00', 4, 14, N'Engin Ertaş', N'Karma aşı', N'11.6.2022')
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'10.00', 1, 9, N'Enes Doğan', N'fghg', N'10.6.2022')
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'15.00', 1, 9, N'Engin Ertaş', N'Kontrol', N'4.6.2022')
INSERT [dbo].[Randevu] ([saat], [rnd_sahibi_id], [rnd_pet_id], [veteriner_adsoyad], [aciklama], [tarih]) VALUES (N'09.00', 2, 15, N'Zeynep Kesici', N'Aşı', N'4.6.2022')
GO
INSERT [dbo].[Sahiplendirme] ([yas], [tur], [cinsiyet], [imgpath]) VALUES (N'Genç (6-12 ay)', N'Kedi', N'Dişi', N'C:\Users\ilayda\WindowsFormsApp7\Images\kedi1.jpg')
INSERT [dbo].[Sahiplendirme] ([yas], [tur], [cinsiyet], [imgpath]) VALUES (N'Yetişkin', N'Köpek', N'Kısır Erkek', N'C:\Users\ilayda\WindowsFormsApp7\Images\kopek1.jpg')
INSERT [dbo].[Sahiplendirme] ([yas], [tur], [cinsiyet], [imgpath]) VALUES (N'Yavru(0-3 ay)', N'Kedi', N'Dişi', N'C:\Users\ilayda\WindowsFormsApp7\Images\kedi2.jpg')
INSERT [dbo].[Sahiplendirme] ([yas], [tur], [cinsiyet], [imgpath]) VALUES (N'Yetişkin', N'Köpek', N'Kısır Dişi', N'C:\Users\ilayda\WindowsFormsApp7\Images\kopek2.jpg')
INSERT [dbo].[Sahiplendirme] ([yas], [tur], [cinsiyet], [imgpath]) VALUES (N'Yetişkin', N'Kedi', N'Kısır Dişi', N'C:\Users\ilayda\WindowsFormsApp7\Images\kedi3.jpg')
GO
SET IDENTITY_INSERT [dbo].[Sahipler] ON 

INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (1, N'İlayda Gölbaşı', N'ilaydaglba@gmail.com', N'5078260246')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (2, N'Mina Ünal', N'minaaunal@gmail.com', N'5380290323')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (3, N'Furkan Başar', N'furkanbasar@gmail.com', N'5465060642')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (4, N'Umut Gölbaşı', N'umutgolbasi@gmail.com', N'5075498549')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (5, N'Ahmet Korkmaz', N'ahmetkorkmaz@gmail.com', N'5555555555')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (6, N'Sevgi Karlık', N'sevgikarlik@gmail.com', N'5555555551')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (7, N'Ayşe Öztürk', N'ayseozturk@gmail.com', N'5555555552')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (8, N'Hikmet Darıcı', N'daricihikmet@gmail.com', N'5555555553')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (9, N'Zehra Gölbaşı', N'zehragolbasi@gmail.com', N'5555555554')
INSERT [dbo].[Sahipler] ([id], [ad_soyad], [email], [telefon]) VALUES (13, N'fgdg', N'gfdg', N'55')
SET IDENTITY_INSERT [dbo].[Sahipler] OFF
GO
INSERT [dbo].[Veterinerler] ([ad_soyad], [telefon], [unvan]) VALUES (N'Enes Doğan', N'05055585511', N'Doç. Dr. Vet. Hek.')
INSERT [dbo].[Veterinerler] ([ad_soyad], [telefon], [unvan]) VALUES (N'Engin Ertaş', N'0502555555', N'Vet. Hek.')
INSERT [dbo].[Veterinerler] ([ad_soyad], [telefon], [unvan]) VALUES (N'Murat Öztürk', N'05055555555', N'Vet. Hek. Dr')
INSERT [dbo].[Veterinerler] ([ad_soyad], [telefon], [unvan]) VALUES (N'Zeynep Kesici', N'05555555555', N'Vet. Hek. Dr')
GO
ALTER TABLE [dbo].[Borclar]  WITH CHECK ADD  CONSTRAINT [FK_Borclar_Sahipler1] FOREIGN KEY([borc_sahibi_id])
REFERENCES [dbo].[Sahipler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borclar] CHECK CONSTRAINT [FK_Borclar_Sahipler1]
GO
ALTER TABLE [dbo].[Petler]  WITH CHECK ADD  CONSTRAINT [FK_Petler_Sahipler] FOREIGN KEY([sahip_id])
REFERENCES [dbo].[Sahipler] ([id])
GO
ALTER TABLE [dbo].[Petler] CHECK CONSTRAINT [FK_Petler_Sahipler]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Petler] FOREIGN KEY([rnd_pet_id])
REFERENCES [dbo].[Petler] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Petler]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Sahipler] FOREIGN KEY([rnd_sahibi_id])
REFERENCES [dbo].[Sahipler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Sahipler]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Veterinerler] FOREIGN KEY([veteriner_adsoyad])
REFERENCES [dbo].[Veterinerler] ([ad_soyad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Veterinerler]
GO
USE [master]
GO
ALTER DATABASE [Bilgiler] SET  READ_WRITE 
GO
