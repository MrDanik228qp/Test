USE [Radchenko_Ychot_rabot]
GO
/****** Object:  Table [dbo].[Sotrudniki]    Script Date: 14.02.2024 9:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sotrudniki](
	[Kod_sotrudnika] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [varchar](max) NOT NULL,
	[Kabinet] [nvarchar](max) NULL,
	[Predmet] [varchar](max) NULL,
	[Specialnost] [varchar](max) NULL,
 CONSTRAINT [PK_Sotrudniki] PRIMARY KEY CLUSTERED 
(
	[Kod_sotrudnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stydenti]    Script Date: 14.02.2024 9:27:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stydenti](
	[Kod_studenta] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [varchar](max) NULL,
	[Birth] [date] NULL,
	[Gryppa] [varchar](max) NULL,
	[Data_postypleniya] [date] NULL,
	[Kyrs] [nvarchar](max) NULL,
	[Specialnost] [varchar](max) NULL,
 CONSTRAINT [PK_Stydenti] PRIMARY KEY CLUSTERED 
(
	[Kod_studenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ychot_rabot]    Script Date: 14.02.2024 9:27:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ychot_rabot](
	[№_Raboti] [int] IDENTITY(1,1) NOT NULL,
	[Kyrs] [nchar](10) NULL,
	[Specialnost] [varchar](max) NULL,
	[Predmet] [varchar](max) NULL,
	[KOD_Stidenta] [int] NULL,
	[KOD_Sotrudnika] [int] NULL,
	[Ocenka] [nchar](10) NULL,
	[Vid_raboti] [varchar](max) NULL,
	[Srok_sdachi] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ychot_rabot] PRIMARY KEY CLUSTERED 
(
	[№_Raboti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ychot_rabot]  WITH CHECK ADD  CONSTRAINT [FK_Ychot_rabot_Sotrudniki] FOREIGN KEY([KOD_Sotrudnika])
REFERENCES [dbo].[Sotrudniki] ([Kod_sotrudnika])
GO
ALTER TABLE [dbo].[Ychot_rabot] CHECK CONSTRAINT [FK_Ychot_rabot_Sotrudniki]
GO
ALTER TABLE [dbo].[Ychot_rabot]  WITH CHECK ADD  CONSTRAINT [FK_Ychot_rabot_Stydenti] FOREIGN KEY([KOD_Stidenta])
REFERENCES [dbo].[Stydenti] ([Kod_studenta])
GO
ALTER TABLE [dbo].[Ychot_rabot] CHECK CONSTRAINT [FK_Ychot_rabot_Stydenti]
GO
