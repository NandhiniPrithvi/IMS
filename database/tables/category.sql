USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 5/7/2019 6:37:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Category](
	[categoryId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](100) NULL,
	[lastUpdated] [datetime] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Category] FOREIGN KEY([categoryId])
REFERENCES [dbo].[Category] ([categoryId])
GO

ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Category]
GO


