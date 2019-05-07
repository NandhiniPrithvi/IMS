USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[Item]    Script Date: 5/7/2019 6:38:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Item](
	[itemId] [int] IDENTITY(1,1) NOT NULL,
	[categoryId] [int] NOT NULL,
	[itemName] [nvarchar](50) NULL,
	[itemCode] [nvarchar](50) NULL,
	[itemDescription] [nvarchar](50) NULL,
	[price] [decimal](18, 3) NULL,
	[companyId] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[itemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Category] FOREIGN KEY([categoryId])
REFERENCES [dbo].[Category] ([categoryId])
GO

ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Category]
GO

ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_tblCompany] FOREIGN KEY([companyId])
REFERENCES [dbo].[tblCompany] ([CompanyId])
GO

ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_tblCompany]
GO


