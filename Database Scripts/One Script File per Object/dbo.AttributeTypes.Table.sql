USE [Credentials Manager]
GO
/****** Object:  Table [dbo].[AttributeTypes]    Script Date: 4/8/2023 1150 34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeTypes](
	[UserID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[AttributeName] [varchar](50) NOT NULL,
	[DataType] [varchar](50) NOT NULL,
	[IsRequired] [bit] NOT NULL,
	[IsHide] [bit] NULL,
 CONSTRAINT [PK_AttributeTypes] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[CategoryID] ASC,
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttributeTypes]  WITH CHECK ADD  CONSTRAINT [FK_AttributeTypes_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[AttributeTypes] CHECK CONSTRAINT [FK_AttributeTypes_UserID]
GO
