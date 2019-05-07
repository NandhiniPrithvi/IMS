USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spSearchSupplier]    Script Date: 5/7/2019 6:40:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create Procedure [dbo].[spSearchSupplier]
@SupplierName nvarchar(100) = NULL
As
Begin

 Select * from Vendor where
 (vendorName like '%'+@SupplierName+'%' OR @SupplierName IS NULL) 
End

GO


