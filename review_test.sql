USE [review_test]
GO
/****** Object:  Table [dbo].[cuisine]    Script Date: 12/8/2016 5:46:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuisine](
	[name] [varchar](255) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[restaurant]    Script Date: 12/8/2016 5:46:44 PM ******/
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
SET IDENTITY_INSERT [dbo].[restaurant] ON 

INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'Joes Pizza', N'Pizza', 61, 82)
INSERT [dbo].[restaurant] ([name], [description], [cuisine_id], [id]) VALUES (N'Joes Pizza', N'Pizza', 61, 83)
SET IDENTITY_INSERT [dbo].[restaurant] OFF
