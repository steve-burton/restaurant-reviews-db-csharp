USE [review]
GO
/****** Object:  Table [dbo].[cuisine]    Script Date: 12/8/2016 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuisine](
	[name] [varchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[restaurant]    Script Date: 12/8/2016 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[restaurant](
	[name] [varchar](225) NULL,
	[description] [varchar](255) NULL,
	[cuisine_id] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[cuisine] ON 

INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'Pizzaria', 1)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 2)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'1', 3)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'1', 4)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'Pizza', 5)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 6)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'1', 7)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 8)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 9)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 10)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 11)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 12)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 13)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 14)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 15)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 16)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 17)
INSERT [dbo].[cuisine] ([name], [id]) VALUES (N'pizza', 18)
SET IDENTITY_INSERT [dbo].[cuisine] OFF
SET IDENTITY_INSERT [dbo].[restaurant] ON 

INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'Joe''s Pizza', N'Portland''s finest pizzaria', 1, 1)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'Joe''s Pizza', N'Portland''s finest pizzaria', 1, 2)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'Joes Pizza', N'Portlands finest pizzaria', 1, 3)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'pizza', N'pizza', 1, 4)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'pizza', N'pizza', 1, 5)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'p', N'p', 1, 6)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'p', N'p', 1, 7)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'p', N'p', 1, 8)
SET IDENTITY_INSERT [dbo].[restaurant] OFF
