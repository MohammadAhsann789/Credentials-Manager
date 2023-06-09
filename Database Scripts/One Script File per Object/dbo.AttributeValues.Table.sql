USE [Credentials Manager]
GO
/****** Object:  Table [dbo].[AttributeValues]    Script Date: 4/8/2023 1150 34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeValues](
	[UserID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[ReferenceKey] [int] NOT NULL,
	[AttributeValue] [varchar](max) NOT NULL,
 CONSTRAINT [PK_AttributeValues_1] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC,
	[TypeID] ASC,
	[UserID] ASC,
	[ReferenceKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttributeValues]  WITH CHECK ADD  CONSTRAINT [FK_AttributeValues_TypeID] FOREIGN KEY([CategoryID], [TypeID], [UserID], [ReferenceKey])
REFERENCES [dbo].[AttributeValues] ([CategoryID], [TypeID], [UserID], [ReferenceKey])
GO
ALTER TABLE [dbo].[AttributeValues] CHECK CONSTRAINT [FK_AttributeValues_TypeID]
GO
ALTER TABLE [dbo].[AttributeValues]  WITH CHECK ADD  CONSTRAINT [FK_AttributeValues_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[AttributeValues] CHECK CONSTRAINT [FK_AttributeValues_UserID]
GO
