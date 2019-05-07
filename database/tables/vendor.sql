USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[Vendor]    Script Date: 5/7/2019 6:39:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Vendor](
	[vendorID] [int] IDENTITY(1,1) NOT NULL,
	[organisationName] [nvarchar](50) NULL,
	[vendorCode] [varchar](10) NULL,
	[vendorName] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[city] [varchar](20) NULL,
	[state] [varchar](20) NULL,
	[postalcode] [varchar](10) NULL,
	[contactno] [varchar](11) NULL,
	[mail] [varchar](50) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[vendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


