USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spSearchProduct]    Script Date: 5/7/2019 6:40:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[spSearchProduct]
@ProdName nvarchar(100) = NULL
As
Begin

 Select * from Product where
 (productName like '%'+@ProdName+'%' OR @ProdName IS NULL) 
End

GO


