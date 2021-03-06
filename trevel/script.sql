USE [trevel]
GO
/****** Object:  Table [dbo].[StatusTask]    Script Date: 09.06.2022 8:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusTask](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 09.06.2022 8:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Desck] [nvarchar](50) NOT NULL,
	[PublicDate] [date] NOT NULL,
	[IdOwner] [int] NOT NULL,
	[IdWorker] [int] NOT NULL,
	[IdStatusTask] [int] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 09.06.2022 8:37:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Second_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StatusTask] ON 

INSERT [dbo].[StatusTask] ([Id], [Name]) VALUES (1, N'Free')
INSERT [dbo].[StatusTask] ([Id], [Name]) VALUES (2, N'Ready')
INSERT [dbo].[StatusTask] ([Id], [Name]) VALUES (3, N'Readly')
SET IDENTITY_INSERT [dbo].[StatusTask] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([Id], [Name], [Desck], [PublicDate], [IdOwner], [IdWorker], [IdStatusTask]) VALUES (22, N'Война и мир', N'Литература ', CAST(N'2022-12-12' AS Date), 2, 3, 2)
INSERT [dbo].[Task] ([Id], [Name], [Desck], [PublicDate], [IdOwner], [IdWorker], [IdStatusTask]) VALUES (42, N'Война', N'История ', CAST(N'2022-12-12' AS Date), 3, 2, 2)
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [First_Name], [Second_Name], [Last_Name], [Login], [Pass], [Phone]) VALUES (2, N'Беркут', N'Александровна', N'Александра', N'QWERT', N'qwert', N'89239438909')
INSERT [dbo].[User] ([Id], [First_Name], [Second_Name], [Last_Name], [Login], [Pass], [Phone]) VALUES (3, N'Бекер', N'Артемович', N'Артем', N'ASDFG', N'asdfg', N'89248769668')
INSERT [dbo].[User] ([Id], [First_Name], [Second_Name], [Last_Name], [Login], [Pass], [Phone]) VALUES (4, N'Фролова', N'Родионовна', N'Алиса', N'TREWQ', N'trewq', N'89349456786')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_StatusTask] FOREIGN KEY([IdStatusTask])
REFERENCES [dbo].[StatusTask] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_StatusTask]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_User2] FOREIGN KEY([IdOwner])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_User2]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_User3] FOREIGN KEY([IdWorker])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_User3]
GO
