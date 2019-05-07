USE [InventoryManagement]
GO

/****** Object:  StoredProcedure [dbo].[spGetItems]    Script Date: 5/7/2019 6:40:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spGetItems]
as
begin
select itemId,itemName, itemCode,itemDescription,price,name as categoryname , CompanyName
from Item join Category on Item.categoryId = Category.categoryId 
join tblCompany on Item.companyId = tblCompany.CompanyId
end
GO


