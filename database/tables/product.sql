USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 5/7/2019 6:38:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Product](
	[productCode] [varchar](10) NOT NULL,
	[productName] [varchar](50) NULL,
	[category] [int] NULL,
	[company] [int] NULL,
	[purchasePrice] [decimal](18, 2) NULL,
	[salesPrice] [decimal](18, 2) NULL,
	[sgst] [decimal](18, 2) NULL,
	[cgst] [decimal](18, 2) NULL,
	[hsnCode] [varchar](10) NULL,
	[discount] [decimal](18, 2) NULL,
	[quantity] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([category])
REFERENCES [dbo].[Category] ([categoryId])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO


