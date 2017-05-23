CREATE TABLE [dbo].[Contacts]
(
	[ContactId] INT NOT NULL PRIMARY KEY,
	[Name] varchar(50) not null,
	[Company] varchar(50) not null,
	[Position] varchar(50) not null,
	[Country] varchar(50) not null,
	[email] varchar(50) not null,
	[PublicID] uniqueidentifier not null
)
