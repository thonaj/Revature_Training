CREATE SCHEMA [Monster] 
GO

CREATE TABLE [Monster].[Gender](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED (	[GenderId] ) 
 );
GO


CREATE TABLE [Monster].[Monster](
	[MonsterId] [int] IDENTITY(1,1) NOT NULL,
	[GenderId] [int] NULL,
	[TitleId] [int] NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[PicturePath] [nvarchar](256) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [pk_monster_monsterid] PRIMARY KEY CLUSTERED (	[MonsterId] )
);
GO


CREATE TABLE [Monster].[MonsterType](
	[MonsterTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_MonsterType] PRIMARY KEY CLUSTERED (	[MonsterTypeId] )
);
GO


CREATE TABLE [Monster].[Title](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](250) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED ( [TitleId] )
);
GO


ALTER TABLE [Monster].[Monster]  ADD  CONSTRAINT [FK_Monster_Gender] FOREIGN KEY([GenderId])
REFERENCES [Monster].[Gender] ([GenderId])
GO



ALTER TABLE [Monster].[Monster]  ADD  CONSTRAINT [FK_Monster_MonsterType] FOREIGN KEY([TypeId])
REFERENCES [Monster].[MonsterType] ([MonsterTypeId])
GO



ALTER TABLE [Monster].[Monster]  ADD  CONSTRAINT [FK_Monster_Title] FOREIGN KEY([TitleId])
REFERENCES [Monster].[Title] ([TitleId])
GO





