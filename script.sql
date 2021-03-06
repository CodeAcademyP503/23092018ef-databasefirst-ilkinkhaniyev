USE [DepozitDb]
GO
/****** Object:  Table [dbo].[Credit]    Script Date: 04-Oct-18 7:06:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date_of_Credit] [datetime] NOT NULL,
	[Price] [decimal](16, 2) NOT NULL,
	[People_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 04-Oct-18 7:06:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Credit]  WITH CHECK ADD FOREIGN KEY([People_Id])
REFERENCES [dbo].[People] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[usp_People]    Script Date: 04-Oct-18 7:06:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[usp_People]
AS
SELECT P.Id,P.Name,Sum(C.Price) as Salary FROM People as P
INNER JOIN Credit as C
ON P.Id=C.People_Id
Group by P.Id,P.Name
GO
/****** Object:  StoredProcedure [dbo].[usp_Peoplee]    Script Date: 04-Oct-18 7:06:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[usp_Peoplee]
AS
SELECT P.Id,P.Name,Sum(C.Price) FROM People as P
INNER JOIN Credit as C
ON P.Id=C.People_Id
Group by P.Id,P.Name
GO
