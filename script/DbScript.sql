/****** Object:  Table [dbo].[Applications]    Script Date: 3/25/2020 09:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Applications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[Tracking] [varchar](255) NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationTracings]    Script Date: 3/25/2020 09:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationTracings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[Status] [bit] NULL,
	[Message] [nvarchar](max) NULL,
 CONSTRAINT [PK_ApplicationTracing] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/25/2020 09:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Applications] ON 

INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (32, N'Aplication Name 1', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (33, N'Aplication Name 2', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (34, N'Aplication Name 3', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (35, N'Aplication Name 4', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (36, N'Aplication Name 5', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (37, N'Aplication Name 6', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (38, N'Aplication Name 7', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (39, N'Aplication Name 8', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (40, N'Aplication Name 9', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (41, N'Aplication Name 10', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (42, N'Aplication Name 11', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (43, N'Aplication Name 12', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (44, N'Aplication Name 13', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (45, N'Aplication Name 14', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (46, N'Aplication Name 15', N'http://www.test.com', 1, 1, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (47, N'Aplication Name 1', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (48, N'Aplication Name 2', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (49, N'Aplication Name 3', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (50, N'Aplication Name 4', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (51, N'Aplication Name 5', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (52, N'Aplication Name 6', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (53, N'Aplication Name 7', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (54, N'Aplication Name 8', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (55, N'Aplication Name 9', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (56, N'Aplication Name 10', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (57, N'Aplication Name 11', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (58, N'Aplication Name 12', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (59, N'Aplication Name 13', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (60, N'Aplication Name 14', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
INSERT [dbo].[Applications] ([Id], [Name], [Url], [Status], [UserId], [Tracking]) VALUES (61, N'Aplication Name 15', N'http://www.test.com', 1, 2, N'0 0/1 * * * ? *')
SET IDENTITY_INSERT [dbo].[Applications] OFF
SET IDENTITY_INSERT [dbo].[ApplicationTracings] ON 

INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (26, 32, CAST(N'2020-03-25T08:41:03.557' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (27, 32, CAST(N'2020-03-25T08:41:03.800' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (28, 32, CAST(N'2020-03-25T08:41:03.807' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (29, 32, CAST(N'2020-03-25T08:41:03.810' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (30, 32, CAST(N'2020-03-25T08:41:03.810' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (31, 32, CAST(N'2020-03-25T08:41:03.810' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (32, 32, CAST(N'2020-03-25T08:41:03.813' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (33, 32, CAST(N'2020-03-25T08:41:03.813' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (34, 32, CAST(N'2020-03-25T08:41:03.817' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (35, 32, CAST(N'2020-03-25T08:41:03.817' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (36, 32, CAST(N'2020-03-25T08:41:03.820' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (37, 32, CAST(N'2020-03-25T08:41:03.820' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (38, 32, CAST(N'2020-03-25T08:41:03.820' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (39, 33, CAST(N'2020-03-25T08:41:03.823' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (40, 33, CAST(N'2020-03-25T08:41:03.823' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (41, 33, CAST(N'2020-03-25T08:41:03.827' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (42, 33, CAST(N'2020-03-25T08:41:03.827' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (43, 33, CAST(N'2020-03-25T08:41:03.830' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (44, 33, CAST(N'2020-03-25T08:41:03.830' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (45, 33, CAST(N'2020-03-25T08:41:03.833' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (46, 33, CAST(N'2020-03-25T08:41:03.833' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (47, 33, CAST(N'2020-03-25T08:41:03.837' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (48, 33, CAST(N'2020-03-25T08:41:03.837' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (49, 33, CAST(N'2020-03-25T08:41:03.840' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (50, 33, CAST(N'2020-03-25T08:41:03.840' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (51, 33, CAST(N'2020-03-25T08:41:03.843' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (52, 34, CAST(N'2020-03-25T08:41:03.843' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (53, 34, CAST(N'2020-03-25T08:41:03.847' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (54, 34, CAST(N'2020-03-25T08:41:03.847' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (55, 34, CAST(N'2020-03-25T08:41:03.850' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (56, 34, CAST(N'2020-03-25T08:41:03.850' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (57, 34, CAST(N'2020-03-25T08:41:03.853' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (58, 34, CAST(N'2020-03-25T08:41:03.853' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (59, 34, CAST(N'2020-03-25T08:41:03.857' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (60, 34, CAST(N'2020-03-25T08:41:03.857' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (61, 34, CAST(N'2020-03-25T08:41:03.860' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (62, 34, CAST(N'2020-03-25T08:41:03.860' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (63, 34, CAST(N'2020-03-25T08:41:03.863' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (64, 34, CAST(N'2020-03-25T08:41:03.863' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (65, 35, CAST(N'2020-03-25T08:41:03.867' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (66, 35, CAST(N'2020-03-25T08:41:03.870' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (67, 35, CAST(N'2020-03-25T08:41:03.870' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (68, 35, CAST(N'2020-03-25T08:41:03.873' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (69, 35, CAST(N'2020-03-25T08:41:03.873' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (70, 35, CAST(N'2020-03-25T08:41:03.877' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (71, 35, CAST(N'2020-03-25T08:41:03.880' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (72, 35, CAST(N'2020-03-25T08:41:03.880' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (73, 35, CAST(N'2020-03-25T08:41:03.883' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (74, 35, CAST(N'2020-03-25T08:41:03.883' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (75, 35, CAST(N'2020-03-25T08:41:03.887' AS DateTime), 1, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (76, 35, CAST(N'2020-03-25T08:41:03.890' AS DateTime), 0, N'Request Test')
INSERT [dbo].[ApplicationTracings] ([Id], [ApplicationId], [CreateDate], [Status], [Message]) VALUES (77, 35, CAST(N'2020-03-25T08:41:03.890' AS DateTime), 1, N'Request Test')
SET IDENTITY_INSERT [dbo].[ApplicationTracings] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email]) VALUES (1, N'Test', N'Test', N'test@test.com')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email]) VALUES (2, N'Test2', N'Test2', N'test@test2.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_Application_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_Application_User_UserId]
GO
ALTER TABLE [dbo].[ApplicationTracings]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationTracing_Application_ApplicationId] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[Applications] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ApplicationTracings] CHECK CONSTRAINT [FK_ApplicationTracing_Application_ApplicationId]
GO
