USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 5/7/2019 6:38:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PurchaseOrder](
	[porderid] [int] IDENTITY(1,1) NOT NULL,
	[productCode] [varchar](10) NULL,
	[productName] [varchar](50) NULL,
	[purchasePrice] [decimal](18, 2) NULL,
	[discount] [decimal](18, 2) NULL,
	[quantity] [int] NULL,
	[quantityNeeded] [int] NULL,
	[totalAmount] [decimal](18, 2) NULL,
	[supplierCode] [varchar](10) NULL,
	[invoiceNo] [varchar](10) NULL,
	[invoiceDate] [datetime] NULL,
	[orderDate] [datetime] NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[porderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


