/*
 Pre-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.   
 Use SQLCMD syntax to include a file in the pre-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the pre-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/

USE [master]
GO
/****** Object:  Database [MonsterDB]    Script Date: 10/25/2016 4:49:25 PM ******/
CREATE DATABASE [MonsterDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MonsterDB', FILENAME = N'D:\RDSDBDATA\DATA\MonsterDB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MonsterDB_log', FILENAME = N'D:\RDSDBDATA\DATA\MonsterDB_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MonsterDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MonsterDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MonsterDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MonsterDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MonsterDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MonsterDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MonsterDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MonsterDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MonsterDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MonsterDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MonsterDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MonsterDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MonsterDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MonsterDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MonsterDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MonsterDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MonsterDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MonsterDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MonsterDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MonsterDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MonsterDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MonsterDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MonsterDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MonsterDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MonsterDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MonsterDB] SET  MULTI_USER 
GO
ALTER DATABASE [MonsterDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MonsterDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MonsterDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MonsterDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MonsterDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MonsterDB]
GO
/****** Object:  User [sqladmin]    Script Date: 10/25/2016 4:49:25 PM ******/
CREATE USER [sqladmin] FOR LOGIN [sqladmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sqladmin]
GO
/****** Object:  Schema [Monster]    Script Date: 10/25/2016 4:49:25 PM ******/
CREATE SCHEMA [Monster]
GO
/****** Object:  Table [Monster].[Gender]    Script Date: 10/25/2016 4:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Monster].[Gender](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Monster].[Monster]    Script Date: 10/25/2016 4:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Monster].[Monster](
	[MonsterId] [int] IDENTITY(1,1) NOT NULL,
	[GenderId] [int] NULL,
	[TitleId] [int] NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[PicturePath] [nvarchar](256) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [pk_monster_monsterid] PRIMARY KEY CLUSTERED 
(
	[MonsterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Monster].[MonsterType]    Script Date: 10/25/2016 4:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Monster].[MonsterType](
	[MonsterTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_MonsterType] PRIMARY KEY CLUSTERED 
(
	[MonsterTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Monster].[Title]    Script Date: 10/25/2016 4:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Monster].[Title](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED 
(
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [Monster].[Monster]  WITH CHECK ADD  CONSTRAINT [FK_Monster_Gender] FOREIGN KEY([GenderId])
REFERENCES [Monster].[Gender] ([GenderId])
GO
ALTER TABLE [Monster].[Monster] CHECK CONSTRAINT [FK_Monster_Gender]
GO
ALTER TABLE [Monster].[Monster]  WITH CHECK ADD  CONSTRAINT [FK_Monster_MonsterType] FOREIGN KEY([MonsterId])
REFERENCES [Monster].[MonsterType] ([MonsterTypeId])
GO
ALTER TABLE [Monster].[Monster] CHECK CONSTRAINT [FK_Monster_MonsterType]
GO
ALTER TABLE [Monster].[Monster]  WITH CHECK ADD  CONSTRAINT [FK_Monster_Title] FOREIGN KEY([TitleId])
REFERENCES [Monster].[Title] ([TitleId])
GO
ALTER TABLE [Monster].[Monster] CHECK CONSTRAINT [FK_Monster_Title]
GO
/****** Object:  DdlTrigger [rds_deny_backups_trigger]    Script Date: 10/25/2016 4:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [rds_deny_backups_trigger] ON DATABASE WITH EXECUTE AS 'dbo' FOR
 ADD_ROLE_MEMBER, GRANT_DATABASE AS BEGIN
   SET NOCOUNT ON;
   SET ANSI_PADDING ON;
 
   DECLARE @data xml;
   DECLARE @user sysname;
   DECLARE @role sysname;
   DECLARE @type sysname;
   DECLARE @sql NVARCHAR(MAX);
   DECLARE @permissions TABLE(name sysname PRIMARY KEY);
   
   SELECT @data = EVENTDATA();
   SELECT @type = @data.value('(/EVENT_INSTANCE/EventType)[1]', 'sysname');
    
   IF @type = 'ADD_ROLE_MEMBER' BEGIN
      SELECT @user = @data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'sysname'),
       @role = @data.value('(/EVENT_INSTANCE/RoleName)[1]', 'sysname');

      IF @role IN ('db_owner', 'db_backupoperator') BEGIN
         SELECT @sql = 'DENY BACKUP DATABASE, BACKUP LOG TO ' + QUOTENAME(@user);
         EXEC(@sql);
      END
   END ELSE IF @type = 'GRANT_DATABASE' BEGIN
      INSERT INTO @permissions(name)
      SELECT Permission.value('(text())[1]', 'sysname') FROM
       @data.nodes('/EVENT_INSTANCE/Permissions/Permission')
      AS DatabasePermissions(Permission);
      
      IF EXISTS (SELECT * FROM @permissions WHERE name IN ('BACKUP DATABASE',
       'BACKUP LOG'))
         RAISERROR('Cannot grant backup database or backup log', 15, 1) WITH LOG;       
   END
END


GO
ENABLE TRIGGER [rds_deny_backups_trigger] ON DATABASE
GO
USE [master]
GO
ALTER DATABASE [MonsterDB] SET  READ_WRITE 
GO
