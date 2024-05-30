
/****** Object:  Table [dbo].[Clients]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[FIO] [nvarchar](max) NOT NULL,
	[CodeClient] [int] NOT NULL,
	[PassportData] [nvarchar](max) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[CodeClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[CodeEmployee] [int] NOT NULL,
	[id_Post] [int] NULL,
	[FIO] [nvarchar](max) NULL,
	[Login] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Image] [image] NULL,
	[PhotoPath] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogInSystem]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogInSystem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_CodeEmployee] [int] NOT NULL,
	[LastEntry] [date] NOT NULL,
	[InputType] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LogInSystem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CodeOrder] [nvarchar](max) NOT NULL,
	[DateСreation] [date] NOT NULL,
	[TimeOrder] [nvarchar](max) NOT NULL,
	[id_CodeClient] [int] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[DateClosing] [date] NULL,
	[TimeRental] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[idPost] [int] NOT NULL,
	[NamePost] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[idPost] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ID] [int] NOT NULL,
	[NameService] [nvarchar](max) NOT NULL,
	[CodeService] [nvarchar](max) NOT NULL,
	[CostHour] [money] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicesOrders]    Script Date: 30.11.23 11:55:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicesOrders](
	[idServiceOrder] [int] IDENTITY(1,1) NOT NULL,
	[Id_Order] [int] NOT NULL,
	[Services] [int] NOT NULL,
 CONSTRAINT [PK_ServicesOrders] PRIMARY KEY CLUSTERED 
(
	[idServiceOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([id_Post])
REFERENCES [dbo].[Post] ([idPost])
GO
ALTER TABLE [dbo].[LogInSystem]  WITH CHECK ADD  CONSTRAINT [FK_LogInSystem_Employee] FOREIGN KEY([id_CodeEmployee])
REFERENCES [dbo].[Employee] ([CodeEmployee])
GO
ALTER TABLE [dbo].[LogInSystem] CHECK CONSTRAINT [FK_LogInSystem_Employee]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([id_CodeClient])
REFERENCES [dbo].[Clients] ([CodeClient])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[ServicesOrders]  WITH CHECK ADD  CONSTRAINT [FK_ServicesOrders_Orders] FOREIGN KEY([Id_Order])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[ServicesOrders] CHECK CONSTRAINT [FK_ServicesOrders_Orders]
GO
ALTER TABLE [dbo].[ServicesOrders]  WITH CHECK ADD  CONSTRAINT [FK_ServicesOrders_Services] FOREIGN KEY([Services])
REFERENCES [dbo].[Services] ([ID])
GO
ALTER TABLE [dbo].[ServicesOrders] CHECK CONSTRAINT [FK_ServicesOrders_Services]
GO
