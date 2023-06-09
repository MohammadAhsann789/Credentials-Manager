USE [Credentials Manager]
GO
/****** Object:  Table [dbo].[CategoriesImage]    Script Date: 4/8/2023 1150 36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesImage](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[CatgeoryTitleLogoImage] [image] NOT NULL,
	[CategoryBtnHighlightedImage] [image] NOT NULL,
	[CategoryBtnUnHighlightedImage] [image] NOT NULL,
 CONSTRAINT [PK_CategoryButtonsImages] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CategoriesImage]  WITH CHECK ADD  CONSTRAINT [FK_CategoriesImage_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[CategoriesImage] CHECK CONSTRAINT [FK_CategoriesImage_UserID]
GO
