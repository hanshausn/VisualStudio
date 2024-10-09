CREATE TABLE [AUTHOR]
(
	[AuthorId] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[AuthorName] [varchar](50) NOT NULL UNIQUE
) 
GO


CREATE TABLE [PUBLISHER]
(
	[PublisherId] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[PublisherName] [varchar](50) NOT NULL UNIQUE
) 
GO


CREATE TABLE [CATEGORY]
(
	[CategoryId] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[CategoryName] [varchar](50) NOT NULL UNIQUE
) 
GO


CREATE TABLE [BOOK]
(
	[BookId] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Title] [varchar](50) NOT NULL UNIQUE,
	[ISBN] [varchar](20) NOT NULL,
	[PublisherId] [int] NOT NULL FOREIGN KEY REFERENCES [PUBLISHER] ([PublisherId]),
	[AuthorId] [int] NOT NULL FOREIGN KEY REFERENCES [AUTHOR] ([AuthorId]),
	[CategoryId] [int] NOT NULL FOREIGN KEY REFERENCES [CATEGORY] ([CategoryId])
) 
GO