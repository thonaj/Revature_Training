CREATE SCHEMA [ToDoApp] 
GO

CREATE TABLE [ToDoApp].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](250) NOT NULL,
	[Completed] [bit] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED (	[ItemId] ) 
 );
GO