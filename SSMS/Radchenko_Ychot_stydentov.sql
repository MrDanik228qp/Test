USE [master]
GO

/****** Object:  Database [Radchenko_Ychot_rabot]    Script Date: 14.02.2024 9:20:01 ******/
DROP DATABASE [Radchenko_Ychot_rabot]
GO

/****** Object:  Database [Radchenko_Ychot_rabot]    Script Date: 14.02.2024 9:20:01 ******/
CREATE DATABASE [Radchenko_Ychot_rabot]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Radchenko_Ychot_rabot', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Радченко Учёт работ студентов заочного отделения.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Radchenko_Ychot_rabot_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Радченко Учёт работ студентов заочного отделения_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Radchenko_Ychot_rabot].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ARITHABORT OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET  MULTI_USER 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Radchenko_Ychot_rabot] SET  READ_WRITE 
GO

