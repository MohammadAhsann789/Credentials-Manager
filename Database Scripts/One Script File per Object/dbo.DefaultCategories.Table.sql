USE [Credentials Manager]
GO
/****** Object:  Table [dbo].[DefaultCategories]    Script Date: 4/8/2023 1150 36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefaultCategories](
	[CategoryID] [int] IDENTITY(-1,-1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CategoryTitle] [varchar](150) NOT NULL,
 CONSTRAINT [PK_DefaultCategories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
